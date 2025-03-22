using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShopCMS.Models
{
    public class Product
    {
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }                 

        public string Name { get; set; }            
        public string Description { get; set; }     
        public string Content { get; set; }        
        public int Price { get; set; }             
        public int Stock { get; set; }             

        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.None)]
        public byte[] Image { get; set; }          

        public int CategoryId { get; set; }         
        
        public Category Category { get; set; }        
    }

    public class ProductInfo
    {
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }            
        public string Description { get; set; }    
        public string Content { get; set; }        
        public int Price { get; set; }             
        public int Stock { get; set; }             
        public int CategoryId { get; set; }        
    }

    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }           
        public List<Product> Products { get; set; }     
    }

    public class Order
    {
        [DisplayFormat(DataFormatString = "{0:000000}")]
        public int Id { get; set; }
        public DateTime OrderDate { get; set; }
        public string UserId { get; set; }
        public string UserName { get; set; }
        public int Total { get; set; }

        [Required]
        public string ReceiverName { get; set; }
        [Required]
        public string ReceiverAdress { get; set; }
        [Required]
        public string ReceiverPhone { get; set; }

        public bool isPaid { get; set; }
        public bool IsEnabled { get; set; }
        public List<OrderItem> OrderItem { get; set; }
    }

    public class OrderItem
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public string Sugar { get; set; }
        public string Iced { get; set; }
        public int Amount { get; set; }
        public int SubTotal { get; set; }
    }

    public class Comment
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Content { get; set; }
        public DateTime Time { get; set; }
        public int ProductID { get; set; }
        public Product Product { get; set; }
    }
}
