using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KPO2Lab.utils
{
    public class PasswordHelper
    {

        public static string GenerateHashPassword(string password)
        {
            return BCrypt.Net.BCrypt.HashPassword(password);  // Автоматически добавляет соль
        }

        // Проверка соответствия пароля и хеша
        public static bool VerifyPassword(string password, string hashedPassword)
        {
            return BCrypt.Net.BCrypt.Verify(password, hashedPassword);
        }

        // Проверка сложности пароля (минимум 8 символов, хотя бы одна цифра и один спецсимвол)
        public static bool ValidatePasswordStrength(string password)
        {
            if (password.Length < 8) return false;
            if (!password.Any(char.IsDigit)) return false;
            if (!password.Any(ch => !char.IsLetterOrDigit(ch))) return false;
            return true;
        }
    }
}
