using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Business.Abstract;
using Business.Concerete;
using DataAccess.Concerete.EntityFramework;
using Entities.Concerete;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController] // Attrıbute---- java için Annotation
    public class ProductsController : ControllerBase
    {
        // Loosely coupled 
        // naming convention
        // IoC Container-- inversion on Controller
        IProductService _productService;

        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet("Getall")]
        public IActionResult GetAll()
        {
            //Swagger
            //Dependency chain --
            
            Thread.Sleep(5000);

            var result = _productService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            var result = _productService.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }


        [HttpPost("add")]
        public IActionResult Add(Product product)
        {
            var result = _productService.Add(product);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }
    }
}
