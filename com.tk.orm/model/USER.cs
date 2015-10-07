
using System;
namespace com.tk.orm.model
{
    /**
     * USERModel表数据交互对象
     * annotation=@MessagePackMessage 
     * Without annotation You register your class before use.
     * MessagePack.register(MyClass.class);
     */ 
    public class USER 
    {

        /// <summary>
        /// </summary>
        public int ID{ get; set; }

        /// <summary>
        /// </summary>
        public string NAME{ get; set; }

        /// <summary>
        /// </summary>
        public string PASSWORD{ get; set; }

        /// <summary>
        /// </summary>
        public string REAL_NAME{ get; set; }

        /// <summary>
        /// </summary>
        public string GENDER{ get; set; }

        /// <summary>
        /// </summary>
        public string DEPT{ get; set; }

        /// <summary>
        /// </summary>
        public string TEL{ get; set; }

        /// <summary>
        /// </summary>
        public string EMAIL{ get; set; }

        /// <summary>
        /// </summary>
        public byte STATE{ get; set; }
    }
}
