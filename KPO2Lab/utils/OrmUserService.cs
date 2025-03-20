using KPO2Lab.models;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KPO2Lab.utils
{
    public class OrmUserService
    {
        private string ERROR_MESSAGE_USER_NOT_EXISTS = "Пользователя с таким именем не существует";
        private string ERROR_MESSAGE_USER_EXISTS = "Пользователь с таким именем уже существует";
        private string ERROR_INCORRECT_PASSWORD = "Пароль неверный";
        private string ERROR_ILEGAL_PASSWORD = "Пароль слишком прост! Должен быть хотя бы " +
            "1 спецсимвол, 1 цифра и длина не менее 8";

        private readonly AppDbContext context;

        public OrmUserService(IServiceProvider provider)
        {
            context = provider.GetRequiredService<AppDbContext>();
        }

        public void RegisterUser(string login, string password)
        {
            var user = GetUser(login);
            if (user != null) {
                throw new UserNotExistsException(ERROR_MESSAGE_USER_EXISTS);
            }
            if (!PasswordHelper.ValidatePasswordStrength(password))
            {
                throw new UserNotExistsException(ERROR_ILEGAL_PASSWORD);
            }

            string hashedPassword = PasswordHelper.GenerateHashPassword(password);

            var newUser = new RegisteredUserEntity
            {
                login = login,
                password = hashedPassword,
                registration_date = DateTime.UtcNow,
                is_active = true
            };

            context.RegisteredUser.Add(newUser);
            context.SaveChanges();


        }

        public void LoginUser(string login, string password)
        {
            var user = GetUser(login);
            if (user == null)
            {
                throw new UserNotExistsException(ERROR_MESSAGE_USER_NOT_EXISTS);
            }
            CheckPassword(password, user.password);

        }

        private RegisteredUserEntity? GetUser(string login)
        {

            
            return context.RegisteredUser.FirstOrDefault(u => u.login == login); ;
        }

        private void CheckPassword(string password, string userPassword)
        {
            if (!PasswordHelper.VerifyPassword(password, userPassword))
            {
                throw new InvalidPasswordException(ERROR_INCORRECT_PASSWORD);
            }

        }


        public List<RegisteredUserEntity> GetUsers()
        {
            return context.RegisteredUser.ToList();
        }

        public RegisteredUserEntity? GetLastUser()
        {
            return context.RegisteredUser.OrderBy(u => u.id).LastOrDefault();
        }

        public void DeleteUser(RegisteredUserEntity? user)
        {
            if (user == null) { return; }
            context.RegisteredUser.Remove(user);
            context.SaveChanges();
        }

        public List<RegisteredUserEntity> FindByName(string login)
        {
            return context.RegisteredUser.Where(u => u.login == login).ToList();
        }

        public void UpdateUser(RegisteredUserEntity user)
        {
            context.RegisteredUser.Update(user);
            context.SaveChanges();
        }
    }
}
