using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using OnlineShopCMS.Data;
using OnlineShopCMS.Models;

namespace OnlineShopCMS.Controllers;

// This is where the Web API accessed.
[ApiController]
[Route("api/[controller]")]
public class TestController : ControllerBase
{
        private readonly OnlineShopContext _context;

        public TestController(OnlineShopContext context)
        {
            _context = context;
        }
     
        [HttpGet("TestGetValue")]
        public IActionResult GetValues()
        {
            return new JsonResult("This is retuen from test Get Values");
        }

        /// <summary>
        /// Returns the price of a frame based on its dimensions.
        /// </summary>
        /// <param name="Height">The height of the frame.</param>
        /// <param name="Width">The width of the frame.</param>
        /// <returns>The price, in dollars, of the picture frame.</returns>
        /// <remarks>
        /// Sample request:
        ///
        ///     Get /api/priceframe/5/10
        ///
        /// </remarks>
        /// <response code="200">Returns the cost of the frame in dollars.</response>
        /// <response code="400">If the amount of frame material needed is less than 20 inches or greater than 1000 inches.</response>
        // [Route("/api/[Controller]")]
        // [HttpGet("{Height}/{Width}", Name=nameof(GetPrice))]
        // [Produces("text/plain")]
        // [ProducesResponseType(StatusCodes.Status200OK)]
        // [ProducesResponseType(StatusCodes.Status400BadRequest)]
        // public ActionResult<string> GetPrice(string Height, string Width)
        // {
        //     string result;
        //     result = CalculatePrice(Double.Parse(Height), Double.Parse(Width));
        //     if (result == "not valid")
        //     {
        //         return BadRequest(result);
        //     }
        //     else
        //     {
        //         return Ok($"The cost of a {Height}x{Width} frame is ${result}");
        //     }
        // }

        // private string CalculatePrice(double height,double width)
        // {
        //     double perimeter;
        //     perimeter = (2*height) + (2*width);

        //     if ((perimeter > 20.00 ) &&  (perimeter <= 50.00))
        //     {
        //         return "20.00";
        //     }
        //     if ((perimeter > 50.00) && (perimeter <= 100.00))
        //     {
        //         return "50.00";
        //     }
        //     if ((perimeter > 100.00) && (perimeter <= 1000.00))
        //     {
        //         return "100.00";
        //     }
        //     return  "not valid";
        // }

        [HttpGet("GetAllProducts")]
        [Produces("text/json")]
        public IEnumerable<Product> GetAllProduct(string searchString)
        {
            var result = from m in _context.Product select m;

            if (!string.IsNullOrEmpty(searchString))
            {
                result = result.Where(s => s.Name.Contains(searchString));
            }
            
            return result;
        }

        [HttpGet("ProductId")]
        [Produces("text/json")]
        public async Task<ActionResult<Product>> GetProductById(int id)
        {
            var result = from m in _context.Product where m.Id == id select m;
            
            return Ok(result);
        }
           
        [HttpPost("CreateProduct")]                
        public async Task<IActionResult> CreateProduct([FromBody] ProductInfo productInfo)        
        {            
            var item = new Product()
            {
                Name = productInfo.Name,
                Description = productInfo.Description,
                Content = productInfo.Content,
                Stock = productInfo.Stock,
                Price = productInfo.Price,
                CategoryId = productInfo.CategoryId
            };
                _context.Add(item);
                await _context.SaveChangesAsync();                
            
            return CreatedAtAction(nameof(GetProductById), new { name = item.Name }, item);
        }

        [HttpPut("UpdateProduct")]        
        public async Task<IActionResult> UpdateProduct([FromBody] ProductInfo productInfo)
        {            
            var result = await _context.Product.SingleOrDefaultAsync(x=>x.Id == productInfo.Id);
            if(result == null)
            {
                return NotFound(new { Message = $"Product with id {productInfo.Id} not found." });
            }
            
            result.Name = productInfo.Name;
            result.Description = productInfo.Description;
            result.Content = productInfo.Content;
            result.Price = productInfo.Price;
            result.Stock = productInfo.Stock;
            result.CategoryId = productInfo.CategoryId;

            _context.Product.Update(result);
            await _context.SaveChangesAsync();
        
            return CreatedAtAction(nameof(GetProductById), new { id = result.Id }, result);
        }

        [HttpDelete("DeleteProduct")]        
        public async Task<IActionResult> DeleteProduct(int productId)
        {
            var result = await _context.Product.SingleOrDefaultAsync(x => x.Id == productId);
            if(result == null)
            {
                return NotFound(new { Message = $"Product with id {productId} not found." });
            }
        
            _context.Product.Remove(result);
            await _context.SaveChangesAsync();

            return Ok(new { Message = $"Product with id {productId} has been deleted." });
        }
        
        [HttpGet("GetAllCategory")]
        [Produces("text/json")]
        public async Task<ActionResult<Product>> GetAllCategory()
        {
            var result = from m in _context.Category select m;
            
            return Ok(result);
        }


        [HttpGet("GetCategoryById")]
        [Produces("text/json")]
        public async Task<ActionResult<Product>> GetCategoryById(int id)
        {
            var result = from m in _context.Category where m.Id == id select m;
            
            return Ok(result);
        }

        // POST: Create              
        [HttpPost("CreateCategory")]                
        public async Task<IActionResult> CreateCategory([FromBody] string categoryName)        
        {   
            var item = new Category() { Name = categoryName };
            
            _context.Add(item);
            await _context.SaveChangesAsync();                
        
            return CreatedAtAction(nameof(GetCategoryById), new { name = item.Name }, item);
        }

        [HttpPut("UpdateCategory")]        
        public async Task<IActionResult> UpdateCategory(int categoryId, string newCategoryName)
        {
            var result = await _context.Category.FindAsync(categoryId);
            if(result == null)
            {
                return NotFound(new { Message = $"Category with id {categoryId} not found." });
            }
            result.Name = newCategoryName;
            _context.Category.Update(result);
            await _context.SaveChangesAsync();
        
            return CreatedAtAction(nameof(GetCategoryById), new { id = categoryId }, result);
        }

        [HttpDelete("DeleteCategory")]        
        public async Task<IActionResult> DeleteCategory(int categoryId)
        {
            var result = await _context.Category.SingleOrDefaultAsync(x => x.Id == categoryId);
            if(result == null)
            {
                return NotFound(new { Message = $"Category with id {categoryId} not found." });
            }
        
            _context.Category.Remove(result);
            await _context.SaveChangesAsync();

            return Ok(new { Message = $"Category with id {categoryId} deleted." });
        }

        [HttpGet("GetAllOrder")]
        [Produces("text/json")]
        public async Task<ActionResult<Order>> GetAllOrder()
        {
            var result = from m in _context.Order select m;
            var orderitems = from m in _context.OrderItem select m;
            foreach(var item in result)
            {
                item.OrderItem = orderitems.Where(p => p.OrderId == item.Id).ToList(); 
            }

            if(result == null)
            {
                return NotFound(new { Message = $"Not any order data founded." });
            }

            return Ok(result);
        }

        [HttpGet("GetOrderById")]
        [Produces("text/json")]
        public async Task<ActionResult<Order>> GetOrderById(int id)
        {
            var result = await _context.Order.SingleOrDefaultAsync(x=>x.Id == id);            
            var orderItems = await _context.OrderItem.Where(p => p.OrderId == id).ToListAsync();
            result.OrderItem = orderItems; 
            
            if(result == null)
            {
                return NotFound(new { Message = $"id {id}'s order not found." });
            }

            return Ok(result);
        }

        // POST: Create and return new order's Id             
        [HttpPost("CreateOrder")]                
        public async Task<ActionResult<int>> CreateOrder([FromBody] Order order)        
        {               
            _context.Order.Add(order);
            await _context.SaveChangesAsync();                
            
            int maxOrderId = _context.Order.Max(o => o.Id);                
            
            return Ok(maxOrderId);
        }

        [HttpPut("UpdateOrder")]        
        public async Task<IActionResult> UpdateOrder([FromBody] Order order)
        {
            var result = await _context.Order.SingleOrDefaultAsync(x => x.Id == order.Id);
            if(result == null)
            {
                return NotFound(new { Message = $"Order with id {order.Id} not found." });
            }      
       
            result.UserId = order.UserId;
            result.UserName = order.UserName;
            result.Total = order.Total;
            result.ReceiverName = order.ReceiverName;
            result.ReceiverAdress = order.ReceiverAdress;
            result.ReceiverPhone = order.ReceiverPhone;
            result.OrderDate = order.OrderDate;
            result.isPaid = order.isPaid;
            
            _context.Order.Update(result);
            await _context.SaveChangesAsync();
        
            return CreatedAtAction(nameof(GetOrderById), new { id = result.Id }, result);
        }

        /// <summary>
        /// Not actually delete data, just update IsEnabled column to False.
        /// </summary>
        [HttpPatch("DeleteOrder")]        
        public async Task<IActionResult> DeleteOrder(int orderId)
        {
            var result = await _context.Order.SingleOrDefaultAsync(x => x.Id == orderId);
            if(result == null)
            {
                return NotFound(new { Message = $"Order with id {orderId} not found." });
            }

            result.IsEnabled = false;
            _context.Order.Update(result);
            await _context.SaveChangesAsync();

            return Ok(new { Message = $"Order id={orderId} has been deleted." });
        }        
}
