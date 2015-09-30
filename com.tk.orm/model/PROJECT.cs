
using System;
namespace com.tk.orm.model
{
    /**
     * PROJECTModel表数据交互对象
     * annotation=@MessagePackMessage 
     * Without annotation You register your class before use.
     * MessagePack.register(MyClass.class);
     */ 
    public class PROJECT 
    {

        /// <summary>
        /// </summary>
        public int ID{ get; set; }

        /// <summary>
        /// </summary>
        public string PNAME{ get; set; }

        /// <summary>
        /// </summary>
        public string PADDRESS{ get; set; }

        /// <summary>
        /// </summary>
        public string PMAP_PATH{ get; set; }

        /// <summary>
        /// </summary>
        public double SCALE{ get; set; }
    }
}
