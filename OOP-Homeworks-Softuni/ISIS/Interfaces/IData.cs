
using System.Collections;
using System.Collections.Generic;

namespace Test1.Interfaces
{
   public interface IData
    {
        //set everything that is needed as data
       ICollection<IGroup> Groups { get; }

       void AddGroup(IGroup group);
    }
}
