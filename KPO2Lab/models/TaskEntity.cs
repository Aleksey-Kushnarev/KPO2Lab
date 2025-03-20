using KPO2Lab.models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Threading.Tasks;
namespace KPO2Lab
{
    public class TaskEntity : IEntity, IHasParent
    {
        [Key]
        public int id { get; set; }

        public string name { get; set; }

        public int project { get; set; }
        

        [ForeignKey("project")]
        public ProjectEntity? Project { get; set; }

        public ICollection<UserEntity> Users { get; set; } = new List<UserEntity>();



        public TaskEntity() { 
        
            name = string.Empty;

        }

        public override string ToString()
        {
            return $"{id} {name} {project}"; 
        }

        public void SetParentId(int newId)
        {
            project = newId;
        }

        public int GetParentId() => project;
    }

}