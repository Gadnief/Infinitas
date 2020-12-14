using System;
namespace Infinitas.Engine
{
    public class MetaObjectInstance
    {
        public MetaObject metaObject { get; set; }
        public Guid ID_Instance { get; set; }
        public int x_position { get; set; }
        public int y_position { get; set; }

        public MetaObjectInstance(MetaObject metaObject, int x_position, int y_position)
        {
            this.metaObject = metaObject;
            this.x_position = x_position;
            this.y_position = y_position;
            this.ID_Instance = new Guid();
        }
    }
}
