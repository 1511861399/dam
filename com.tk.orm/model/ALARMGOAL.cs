
using System;
namespace com.tk.orm.model
{
    /**
     * ALARMGOALModel表数据交互对象
     * annotation=@MessagePackMessage 
     * Without annotation You register your class before use.
     * MessagePack.register(MyClass.class);
     */ 
    public class ALARMGOAL 
    {

        /// <summary>
        /// </summary>
        public int ID{ get; set; }

        /// <summary>
        /// </summary>
        public string NAME{ get; set; }

        /// <summary>
        /// </summary>
        public string TEL{ get; set; }

        /// <summary>
        /// </summary>
        public string EMAIL{ get; set; }
    }
}
