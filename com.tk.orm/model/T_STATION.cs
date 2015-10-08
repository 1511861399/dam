
using System;
namespace com.tk.orm.model
{
    /**
     * STATIONModel表数据交互对象
     * annotation=@MessagePackMessage 
     * Without annotation You register your class before use.
     * MessagePack.register(MyClass.class);
     */ 
    public class T_STATION 
    {

        /// <summary>
        /// </summary>
        public int ID{ get; set; }

        /// <summary>
        /// </summary>
        public int PROJ_ID{ get; set; }

        /// <summary>
        /// </summary>
        public byte STATE{ get; set; }

        /// <summary>
        /// </summary>
        public string NAME{ get; set; }

        /// <summary>
        /// </summary>
        public string SSN{ get; set; }

        /// <summary>
        /// </summary>
        public int SSTYLE{ get; set; }

        /// <summary>
        /// </summary>
        public int ESTYLE{ get; set; }

        /// <summary>
        /// </summary>
        public double SX{ get; set; }

        /// <summary>
        /// </summary>
        public double SY{ get; set; }

        /// <summary>
        /// </summary>
        public double SH{ get; set; }

        /// <summary>
        /// </summary>
        public double SB{ get; set; }

        /// <summary>
        /// </summary>
        public double SL{ get; set; }

        /// <summary>
        /// </summary>
        public double SHEIGHT{ get; set; }

        /// <summary>
        /// </summary>
        public string SCOORNAME{ get; set; }

        /// <summary>
        /// </summary>
        public string SFILTERNAME1{ get; set; }

        /// <summary>
        /// </summary>
        public string SFILTERNAME2{ get; set; }

        /// <summary>
        /// </summary>
        public double X{ get; set; }

        /// <summary>
        /// </summary>
        public double Y{ get; set; }

        /// <summary>
        /// </summary>
        public string COMMENT{ get; set; }

        /// <summary>
        /// </summary>
        public string EMODEL{ get; set; }

        /// <summary>
        /// </summary>
        public string EPROVIDER{ get; set; }

        /// <summary>
        /// </summary>
        public DateTime ESTARTDATE{ get; set; }

        /// <summary>
        /// </summary>
        public string EINSTALLER{ get; set; }

        /// <summary>
        /// </summary>
        public double S1X{ get; set; }

        /// <summary>
        /// </summary>
        public double S1Y{ get; set; }

        /// <summary>
        /// </summary>
        public double S1H{ get; set; }

        /// <summary>
        /// </summary>
        public string SCONFIG{ get; set; }
    }
}
