
using System;
namespace com.tk.orm.model
{
    /**
     * ALARMAPPENDModel表数据交互对象
     * annotation=@MessagePackMessage 
     * Without annotation You register your class before use.
     * MessagePack.register(MyClass.class);
     */ 
    public class ALARMAPPEND 
    {

        /// <summary>
        /// </summary>
        public int ID{ get; set; }

        /// <summary>
        /// </summary>
        public int GOAL_ID{ get; set; }

        /// <summary>
        /// </summary>
        public int METHOD{ get; set; }

        /// <summary>
        /// </summary>
        public byte ALEVEl{ get; set; }
    }
}
