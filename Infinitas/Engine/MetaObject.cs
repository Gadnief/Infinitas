using System;
namespace Infinitas.Engine
{
    public class MetaObject
    {
        public Guid ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public MetaObject(string name, string description)
        {
            Name = name;
            Description = description;

            ID = new Guid();
        }


    }
}
