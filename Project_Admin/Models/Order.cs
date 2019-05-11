using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Project_Admin.Models
{
    public class Order
    {
       
        public int OrderId { get; set; }

        public int StatuName { get; set; }

        public DateTime CreateDate { get; set; }

        public int CreateUserId { get; set; }

        public DateTime? UpdateDate { get; set; }

        public int UserId { get; set; }

        public Tuser User { get; set; }

        public int UserAddressId { get; set; }

        public int StatusId { get; set; }

        public Statu Status { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal TotalProductPrice { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal TotalDiscount { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal TotalPrice { get; set; }

        public virtual List<OrderPayment> Order_Payments { get; set; }

        public virtual List<OrderProduct> OrderProducts { get; set; }




    }
}
