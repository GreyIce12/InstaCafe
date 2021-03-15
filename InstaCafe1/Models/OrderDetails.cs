using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InstaCafe1.Models
{
    public class OrderDetails
    {

        public int Shipping_Detail_Id { get; set; }
        //public Member_Role Member_Id  { get; set; }
        public string Address { get; set; }
        public string City { get; set; }

        public string State { get; set; }
        public string Country { get; set; }
        public string Zip_Code { get; set; }
        public int Order_Id { get; set; }
        public double Amount_Paid { get; set; }
        public string Payment_Type { get; set; }

    }
}
