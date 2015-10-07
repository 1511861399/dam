
using System;
namespace com.tk.orm.model
{
    /**
     * _STATUSModel表数据交互对象
     * annotation=@MessagePackMessage 
     * Without annotation You register your class before use.
     * MessagePack.register(MyClass.class);
     */
    public class SB_STATUS 
    {

        /// <summary>
        /// </summary>
        public int SN{ get; set; }

        /// <summary>
        /// </summary>
        public string SNAME{ get; set; }

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
