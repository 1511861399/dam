
using System;
namespace com.tk.orm.model
{
    /**
     * TEMPGPSModel表数据交互对象
     * annotation=@MessagePackMessage 
     * Without annotation You register your class before use.
     * MessagePack.register(MyClass.class);
     */ 
    public class TEMPGPS 
    {

        /// <summary>
        /// </summary>
        public long ID{ get; set; }

        /// <summary>
        /// </summary>
        public string GPSID{ get; set; }

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
        public double DX{ get; set; }

        /// <summary>
        /// </summary>
        public double DH{ get; set; }

        /// <summary>
        /// </summary>
        public int START_COUNT{ get; set; }

        /// <summary>
        /// </summary>
        public int FLAG{ get; set; }

        /// <summary>
        /// </summary>
        public DateTime UPDATIME{ get; set; }
    }
}
