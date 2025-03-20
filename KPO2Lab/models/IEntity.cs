using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KPO2Lab.models
{
    public interface IEntity
    {
         int id { get; set; }

         string name { get; set; }

        int? GetParentId() { return null; }

    }
}
