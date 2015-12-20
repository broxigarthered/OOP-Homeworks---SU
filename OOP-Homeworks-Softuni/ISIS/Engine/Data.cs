
using System;
using System.Collections.Generic;
using Test1.Interfaces;

namespace Test1.Engine
{
    public class Data : IData
    {

        //Constructor
        public Data()
        {
            Groups = new LinkedList<IGroup>();
        }


        //Properties
        public ICollection<IGroup> Groups { get; }

        //Methods

        public void AddGroup(IGroup group)
        {
            if (group == null)
            {
                throw new ArgumentNullException("Group cannot be null");
            }

            this.Groups.Add(group);
        }
    }
}
