using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MbmStore.Models
{
    public class OrderItem : Product
    {
        //properties
        public int OrderItemId { get; set; }
        public int ProductId { get; set; }
        public Product Product;
        public int Quantity { get; set; }
        public decimal TotalPrice { get; }


        //constructor
        public OrderItem()
        {

        }
        public OrderItem(Product product, int quantity)
        {
            Product = product;
            Quantity = quantity;
        }
    }
}
