using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoComputerShare.OptionalSelection
{
  
    public abstract class ISelectionOption
    {
        public SelectionEnum Option;
        public virtual void ExecuteOption()
        {
            
        }
    }
}
