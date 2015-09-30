
using System;
namespace com.tk.orm.model
{
    /**
     * RIGHTModel表数据交互对象
     * annotation=@MessagePackMessage 
     * Without annotation You register your class before use.
     * MessagePack.register(MyClass.class);
     */ 
    public class RIGHT 
    {

        /// <summary>
        /// </summary>
        public int ID{ get; set; }

        /// <summary>
        /// </summary>
        public string NAME{ get; set; }

        /// <summary>
        /// </summary>
        public string DESCRIPTION{ get; set; }
    }
}
