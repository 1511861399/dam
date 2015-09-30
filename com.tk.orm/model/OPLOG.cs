
using System;
namespace com.tk.orm.model
{
    /**
     * OPLOGModel表数据交互对象
     * annotation=@MessagePackMessage 
     * Without annotation You register your class before use.
     * MessagePack.register(MyClass.class);
     */ 
    public class OPLOG 
    {

        /// <summary>
        /// </summary>
        public int ID{ get; set; }

        /// <summary>
        /// </summary>
        public DateTime ODATETIME{ get; set; }

        /// <summary>
        /// </summary>
        public string ONAME{ get; set; }

        /// <summary>
        /// </summary>
        public string LOG_INFO{ get; set; }

        /// <summary>
        /// </summary>
        public int EVENT{ get; set; }

        /// <summary>
        /// </summary>
        public string OMODULE{ get; set; }
    }
}
