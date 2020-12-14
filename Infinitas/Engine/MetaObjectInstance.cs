using System;
namespace Infinitas.Engine
{
    public class MetaObjectInstance
    {
        public MetaObject metaObject { get; set; }
        public Guid ID_placed { get; set; }
        public int x_position { get; set; }
        public int y_position { get; set; }

        public MetaObjectInstance()
        {

        }
    }
}
