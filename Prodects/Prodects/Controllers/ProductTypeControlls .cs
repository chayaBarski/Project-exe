using Microsoft.AspNetCore.Mvc;
using ENTITES;
using MODEL;


namespace Prodects.Controllers
{
    [ApiController]
    [Route("api/Product")]
    public class ProductTypeControlls : Controller
    {public ProductTypeControlls()
        {

        }
        [HttpGet("ProducsType")]
        public  JsonResult getList()
        {
            try
            {
                 List<ProductItType> list = new List<ProductItType>();
                ProductItTypeEntites P = new ProductItTypeEntites();
               list= P.getAllProductItType();
            return new JsonResult(list);
            }
            catch (Exception e)
            {

                return new JsonResult(e);
            }

        }
        [HttpGet("ProducsTypeAnsSum")]
        public JsonResult getListAndSum()
        {
            try
            {
                List<ProductItType> list = new List<ProductItType>();
                ProductItTypeEntites P = new ProductItTypeEntites();
                list = P.getAllProductItTypeCount();
                return new JsonResult(list);
            }
            catch (Exception e)
            {

                return new JsonResult(e);
            }

        }


    }

}
