
using System;
namespace com.tk.orm.model
{
    /**
     * SATModel表数据交互对象
     * annotation=@MessagePackMessage 
     * Without annotation You register your class before use.
     * MessagePack.register(MyClass.class);
     */ 
    public class SAT 
    {

        /// <summary>
        /// </summary>
        public int ID{ get; set; }

        /// <summary>
        /// </summary>
        public int STATION_ID{ get; set; }

        /// <summary>
        /// </summary>
        public int SPRN{ get; set; }

        /// <summary>
        /// </summary>
        public double SELEV{ get; set; }

        /// <summary>
        /// </summary>
        public double SAZM{ get; set; }

        /// <summary>
        /// </summary>
        public double SL1{ get; set; }

        /// <summary>
        /// </summary>
        public double SL2{ get; set; }
    }
}
