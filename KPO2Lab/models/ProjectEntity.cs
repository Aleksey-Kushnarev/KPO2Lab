using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KPO2Lab.models
{
    public class ProjectEntity: IEntity
    {
        [Key]
        public int id { get; set; }

        public string name { get; set; }
        public ICollection<TaskEntity>? Tasks { get; set; }

        public ProjectEntity() {

            name = string.Empty;
        }

        public override string ToString()
        {
            return $" {name}";
        }


        int? GetParentId() { return null; }


    }
}
