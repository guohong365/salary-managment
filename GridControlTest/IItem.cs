using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GridControlTest
{
    public interface IItem
    {
        string Id { get; set; }
        string Name { get; set; }
    }

    public interface IItem2 : IItem
    {
       string Desc { get; set; }
    }

    public class ItemBase : IItem
    {
        public string Id { get; set; }
        public string Name { get; set; }

        public ItemBase(string id, string name)
        {
            Id = id;
            Name = name;
        }
    }

    public class Item2 : ItemBase
    {
        public Item2(string id, string name, string desc) : base(id, name)
        {
            Desc = desc;
        }
        public string Desc { get; set; }
    }
}
