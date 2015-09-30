
using System;
namespace com.tk.orm.model
{
    /**
     * ROLERIGHTModel表数据交互对象
     * annotation=@MessagePackMessage 
     * Without annotation You register your class before use.
     * MessagePack.register(MyClass.class);
     */ 
    public class ROLERIGHT 
    {

        /// <summary>
        /// </summary>
        public int ID{ get; set; }

        /// <summary>
        /// </summary>
        public int ROLE_ID{ get; set; }

        /// <summary>
        /// </summary>
        public int RIGHT_ID{ get; set; }
    }
}
