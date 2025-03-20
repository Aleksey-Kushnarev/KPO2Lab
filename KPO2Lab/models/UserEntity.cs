using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KPO2Lab.models
{

    public class UserEntity : IEntity, IHasParent
    {
        [Key]
        public int id { get; set; }

        public string name { get; set; }
        public string surname { get; set; }

        public int task { get; set; }


        [ForeignKey("task")]
        public TaskEntity? Task { get; set; }

        public UserEntity()
        {

            name = string.Empty;
            surname = string.Empty;

        }
        public override string ToString()
        {
            return $" ID:{this.id} | Name {this.name} {this.surname} |" +
            $"Task: {this.task}";


        }

        public void SetParentId(int newId) => task = newId;
        public int GetParentId() => task;
    }
}
