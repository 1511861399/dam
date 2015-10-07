
using System;
namespace com.tk.orm.model
{
    /**
     * tModel表数据交互对象
     * annotation=@MessagePackMessage 
     * Without annotation You register your class before use.
     * MessagePack.register(MyClass.class);
     */
    public class sat 
    {

        /// <summary>
        /// </summary>
        public int sId{ get; set; }

        /// <summary>
        /// </summary>
        public int sPrn{ get; set; }

        /// <summary>
        /// </summary>
        public double sElev{ get; set; }

        /// <summary>
        /// </summary>
        public double sAzm{ get; set; }

        /// <summary>
        /// </summary>
        public double sL1{ get; set; }

        /// <summary>
        /// </summary>
        public double sL2{ get; set; }
    }
}
