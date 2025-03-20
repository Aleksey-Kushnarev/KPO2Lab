using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KPO2Lab.models
{
    public interface IHasParent
    {
         void SetParentId(int newId) { }
         int GetParentId() { return 0; }

    }
}
