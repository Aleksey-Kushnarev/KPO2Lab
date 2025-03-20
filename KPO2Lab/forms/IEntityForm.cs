using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KPO2Lab.forms
{
    public interface IEntityForm<T> where T : class
    {
        int EntityId { get; }
        T? NewEntity { get; }

    }
}
