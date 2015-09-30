
using System;
namespace com.tk.orm.model
{
    /**
     * USERROLEModel表数据交互对象
     * annotation=@MessagePackMessage 
     * Without annotation You register your class before use.
     * MessagePack.register(MyClass.class);
     */ 
    public class USERROLE 
    {

        /// <summary>
        /// </summary>
        public int ID{ get; set; }

        /// <summary>
        /// </summary>
        public int USER_ID{ get; set; }

        /// <summary>
        /// </summary>
        public int ROLE_ID{ get; set; }

        /// <summary>
        /// </summary>
        public int PROJ_ID{ get; set; }
    }
}
