
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
        public DateTime? aDatetime{ get; set; }

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
        /// 数据处理类型：0原始 1分钟 2小时 3天 4月 5年
        /// </summary>
        public int? Style{ get; set; }

        /// <summary>
        /// </summary>
        public double Dx { get; set; }

        /// <summary>
        /// </summary>
        public double Dy { get; set; }

        /// <summary>
        /// </summary>
        public double Dh { get; set; }
    }
}
