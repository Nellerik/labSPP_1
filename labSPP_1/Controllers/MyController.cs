using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace labSPP_1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MyController : ControllerBase
    {
        [HttpGet("task1")]
        public string GetString()
        {
            return "Сообщение";
        }

        [HttpGet("task2")]
        public IResult GetJson()
        {
            Product product = new Product
            {
             ImageUrl = "https://algo.by/media_images/site/l/v/i/videokarta-gigabyte-geforce-rtx-2060-super-windforce-oc-8gb-gddr6-gv-n206swf2oc-8gd-1.jpeg",
             Name = "Видеокарта Gigabyte GeForce RTX 2060 Super WindForce",
             Description = "8 ГБ GDDR6, 1470 МГц / 1680 МГц, 2176sp, 34 RT-ядер, трассировка лучей, 256 бит, 2 слота, питание 8 pin, HDMI, DisplayPort"
            };

            return Results.Json(product);
        }
    }

    public class Product
    {
        public string ImageUrl { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
