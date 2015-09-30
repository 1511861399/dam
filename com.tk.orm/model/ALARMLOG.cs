
using System;
namespace com.tk.orm.model
{
    /**
     * ALARMLOGModel表数据交互对象
     * annotation=@MessagePackMessage 
     * Without annotation You register your class before use.
     * MessagePack.register(MyClass.class);
     */ 
    public class ALARMLOG 
    {

        /// <summary>
        /// </summary>
        public int ID{ get; set; }

        /// <summary>
        /// </summary>
        public DateTime ADATETIME{ get; set; }

        /// <summary>
        /// </summary>
        public int PROJECTID{ get; set; }

        /// <summary>
        /// </summary>
        public int STATIONID{ get; set; }

        /// <summary>
        /// </summary>
        public byte ALEVEl{ get; set; }

        /// <summary>
        /// </summary>
        public string AEVENT{ get; set; }
    }
}
