
using System;
namespace com.tk.orm.model
{
    /**
     * armlogModel表数据交互对象
     * annotation=@MessagePackMessage 
     * Without annotation You register your class before use.
     * MessagePack.register(MyClass.class);
     */ 
    public class AlarmLog 
    {

        /// <summary>
        /// </summary>
        public int aId{ get; set; }

        /// <summary>
        /// </summary>
        public int sId{ get; set; }

        /// <summary>
        /// </summary>
        public DateTime aDatetime{ get; set; }

        /// <summary>
        /// </summary>
        public string Event{ get; set; }

        /// <summary>
        /// </summary>
        public int aLevel{ get; set; }
    }
}
