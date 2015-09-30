
using System;
namespace com.tk.orm.model
{
    /**
     * STATION_ACCESSModel表数据交互对象
     * annotation=@MessagePackMessage 
     * Without annotation You register your class before use.
     * MessagePack.register(MyClass.class);
     */ 
    public class STATION_ACCESS 
    {

        /// <summary>
        /// </summary>
        public int ID{ get; set; }

        /// <summary>
        /// </summary>
        public int STATION_ID{ get; set; }

        /// <summary>
        /// </summary>
        public byte ACCESS_STYLE{ get; set; }

        /// <summary>
        /// </summary>
        public string ACCESS_PARAS{ get; set; }
    }
}
