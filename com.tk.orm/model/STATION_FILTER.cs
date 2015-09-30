
using System;
namespace com.tk.orm.model
{
    /**
     * STATION_FILTERModel表数据交互对象
     * annotation=@MessagePackMessage 
     * Without annotation You register your class before use.
     * MessagePack.register(MyClass.class);
     */ 
    public class STATION_FILTER 
    {

        /// <summary>
        /// </summary>
        public long ID{ get; set; }

        /// <summary>
        /// </summary>
        public DateTime GDATETIME{ get; set; }

        /// <summary>
        /// </summary>
        public double X{ get; set; }

        /// <summary>
        /// </summary>
        public double Y{ get; set; }

        /// <summary>
        /// </summary>
        public double H{ get; set; }

        /// <summary>
        /// </summary>
        public double XSPEED{ get; set; }

        /// <summary>
        /// </summary>
        public double YSPEED{ get; set; }

        /// <summary>
        /// </summary>
        public double HSPEED{ get; set; }

        /// <summary>
        /// </summary>
        public double XACCELERATION{ get; set; }

        /// <summary>
        /// </summary>
        public double YACCELERATION{ get; set; }

        /// <summary>
        /// </summary>
        public double HACCELERATION{ get; set; }

        /// <summary>
        /// </summary>
        public int STYLE{ get; set; }
    }
}
