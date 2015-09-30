
using System;
namespace com.tk.orm.model
{
    /**
     * ALARMSETTINGModel表数据交互对象
     * annotation=@MessagePackMessage 
     * Without annotation You register your class before use.
     * MessagePack.register(MyClass.class);
     */ 
    public class ALARMSETTING 
    {

        /// <summary>
        /// </summary>
        public int ID{ get; set; }

        /// <summary>
        /// </summary>
        public int STATIONID{ get; set; }

        /// <summary>
        /// </summary>
        public byte ALEVEl{ get; set; }

        /// <summary>
        /// </summary>
        public double SXLIMIT{ get; set; }

        /// <summary>
        /// </summary>
        public double SYLIMIT{ get; set; }

        /// <summary>
        /// </summary>
        public double SHLIMIT{ get; set; }

        /// <summary>
        /// </summary>
        public double SPXLIMIT{ get; set; }

        /// <summary>
        /// </summary>
        public double SPYLIMIT{ get; set; }

        /// <summary>
        /// </summary>
        public double SPHLIMIT{ get; set; }

        /// <summary>
        /// </summary>
        public double SX1LIMIT{ get; set; }

        /// <summary>
        /// </summary>
        public double SY1LIMIT{ get; set; }

        /// <summary>
        /// </summary>
        public double SH1LIMIT{ get; set; }
    }
}
