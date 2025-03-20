using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KPO2Lab.models
{
    public class RegisteredUserEntity
    {

        [Key]
        public int id { get; set; }

        public string login { get; set; }
        public string password { get; set; }
        public DateTime? registration_date { get; set; }
        public bool is_active { get; set; }

        public RegisteredUserEntity()
        {
            login = string.Empty;
            password = string.Empty;
            registration_date = DateTime.UtcNow; // Устанавливаем текущую дату
            is_active = true; // По умолчанию активен
        }
    }
}
