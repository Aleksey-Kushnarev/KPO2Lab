using KPO2Lab.models;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.Extensions.DependencyInjection;
using System.Xml.Linq;

namespace KPO2Lab.utils
{
    public class Orm
    {
        private readonly AppDbContext context;

        public Orm(IServiceProvider provider) {
            
            context = provider.GetRequiredService<AppDbContext>();

        }

   

        public List<TaskEntity> GetTasksInProject(ProjectEntity project)
        {
            return context.Tasks.Where(t => t.project == project.id).ToList();
        }

        public List<ProjectEntity> GetProjects()
        {
            return context.Projects.ToList();
        }

        public List<UserEntity> GetUserInTask(TaskEntity task)
        {
            return context.User.Where(t => t.task == task.id).ToList();;
        }


        public bool DeleteEntity<T>(int entityId) where T : class
        {
            var entity = context.Set<T>().Find(entityId);
            if (entity != null)
            {
                context.Set<T>().Remove(entity);
                context.SaveChanges();
                return true;
            }
            return false;
        }


        public bool AddEntity<T>(T? entity) where T : class, IEntity
        {
            int? parentId = (entity is IHasParent parentEntity) ? parentEntity.GetParentId() : (int?)null;

            if (entity != null && FindEntityByName<T>(entity.name) == null)
            {

                context.Set<T>().Add(entity);
                context.SaveChanges();
                return true;
            }
            return false;
            
        }


        public T? FindEntityByName<T>(string name) where T : class, IEntity
        {
            T? check_entity = context.Set<T>().FirstOrDefault(e => e.name == name);
            return check_entity;
        }

        public T? FindEntityById<T>(int id) where T : class, IEntity
        {
            T? check_entity = context.Set<T>().FirstOrDefault(e => e.id == id);
            return check_entity;
        }

        public void UpdateEntity<T>(T entity) where T : class, IEntity
        {
            context.Set<T>().Update(entity);
            context.SaveChanges();
        }



        public void ChangeParent<T>(int entityId, int newParentId) where T : class, IEntity, IHasParent
        {
            T? entity = context.Set<T>().FirstOrDefault(e => e.id == entityId);
            if (entity != null)
            {
                entity.SetParentId(newParentId);
                context.SaveChanges();
            }
        }

    }
}
