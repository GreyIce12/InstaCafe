using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InstaCafe1.Models
{
    public class Cart
    {
        public int Cart_Id { get; set; }
        public Product Product_Id { get; set; }
        //public Member_Role Member_Id{ get; set; }
        public Cart Cart_Status_Id { get; set; }


    }
}
