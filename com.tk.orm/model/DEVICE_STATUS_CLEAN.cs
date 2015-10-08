
using System;
namespace com.tk.orm.model
{
    /**
     * DEVICE_STATUS_CLEANModel表数据交互对象
     * annotation=@MessagePackMessage 
     * Without annotation You register your class before use.
     * MessagePack.register(MyClass.class);
     */ 
    public class DEVICE_STATUS_CLEAN 
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
        public double XSpeed{ get; set; }

        /// <summary>
        /// </summary>
        public double YSpeed{ get; set; }

        /// <summary>
        /// </summary>
        public double Hspeed{ get; set; }

        /// <summary>
        /// </summary>
        public int Style{ get; set; }
    }
}
