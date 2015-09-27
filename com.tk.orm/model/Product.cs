using System;

namespace com.tk.orm.model
{
   public class Product
    {
       public int ProductId { get; set; }
       public string ProductName { get; set; }
       public string ProductCompany { get; set; }
       public DateTime SignDate { get; set; }
       public DateTime UpdateDate { get; set; }

       public Product() { }
    }
}
