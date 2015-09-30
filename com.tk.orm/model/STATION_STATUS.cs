
using System;
namespace com.tk.orm.model
{
    /**
     * STATION_STATUSModel表数据交互对象
     * annotation=@MessagePackMessage 
     * Without annotation You register your class before use.
     * MessagePack.register(MyClass.class);
     */ 
    public class STATION_STATUS 
    {

        /// <summary>
        /// </summary>
        public int ID{ get; set; }

        /// <summary>
        /// </summary>
        public int STATION_ID{ get; set; }

        /// <summary>
        /// </summary>
        public byte LINKSTATUS{ get; set; }

        /// <summary>
        /// </summary>
        public byte ALARMSTATUS{ get; set; }

        /// <summary>
        /// </summary>
        public byte QUITSTATUS{ get; set; }
    }
}
