
using System;
namespace com.tk.orm.model
{
    /**
     * DEVICE_STATUSModel表数据交互对象
     * annotation=@MessagePackMessage 
     * Without annotation You register your class before use.
     * MessagePack.register(MyClass.class);
     */ 
    public class DEVICE_STATUS 
    {

        /// <summary>
        /// </summary>
        public long GPSIndex{ get; set; }

        /// <summary>
        /// </summary>
        public DateTime aDatetime{ get; set; }

        /// <summary>
        /// </summary>
        public double X{ get; set; }

        /// <summary>
        /// </summary>
        public double Y{ get; set; }

        /// <summary>
        /// </summary>
        public double Height{ get; set; }

        /// <summary>
        /// </summary>
        public double dltaX{ get; set; }

        /// <summary>
        /// </summary>
        public double dltaY{ get; set; }

        /// <summary>
        /// </summary>
        public double dltaH{ get; set; }
    }
}
