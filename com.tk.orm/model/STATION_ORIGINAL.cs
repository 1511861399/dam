
using System;
namespace com.tk.orm.model
{
    /**
     * STATION_ORIGINALModel表数据交互对象
     * annotation=@MessagePackMessage 
     * Without annotation You register your class before use.
     * MessagePack.register(MyClass.class);
     */ 
    public class STATION_ORIGINAL 
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
        public double DLTAX{ get; set; }

        /// <summary>
        /// </summary>
        public double DLTAY{ get; set; }

        /// <summary>
        /// </summary>
        public double DLTAH{ get; set; }
    }
}
