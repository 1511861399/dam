
using System;
namespace com.tk.orm.model
{
    /**
     * ationModel表数据交互对象
     * annotation=@MessagePackMessage 
     * Without annotation You register your class before use.
     * MessagePack.register(MyClass.class);
     */
    public class station 
    {

        /// <summary>
        /// </summary>
        public int sId{ get; set; }

        /// <summary>
        /// </summary>
        public string sName{ get; set; }

        /// <summary>
        /// </summary>
        public int sStatus{ get; set; }

        /// <summary>
        /// </summary>
        public int sSn{ get; set; }

        /// <summary>
        /// </summary>
        public string sComment{ get; set; }

        /// <summary>
        /// </summary>
        public double Sx{ get; set; }

        /// <summary>
        /// </summary>
        public double Sy{ get; set; }

        /// <summary>
        /// </summary>
        public double Sh{ get; set; }

        /// <summary>
        /// </summary>
        public double sB{ get; set; }

        /// <summary>
        /// </summary>
        public double sL{ get; set; }

        /// <summary>
        /// </summary>
        public double sHeight{ get; set; }

        /// <summary>
        /// </summary>
        public string sCoorName{ get; set; }

        /// <summary>
        /// </summary>
        public string sSpeedName{ get; set; }

        /// <summary>
        /// </summary>
        public int sStyle{ get; set; }

        /// <summary>
        /// </summary>
        public double s1x{ get; set; }

        /// <summary>
        /// </summary>
        public double s1y{ get; set; }

        /// <summary>
        /// </summary>
        public double s1h{ get; set; }
    }
}
