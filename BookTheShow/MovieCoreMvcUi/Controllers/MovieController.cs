using BookTheShowEntity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace MovieCoreMvcUi.Controllers
{
    public class MovieController : Controller
    {   IConfiguration _configuration;
        public MovieController(IConfiguration configuration)
        {

            _configuration = configuration;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult MovieEntry()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> MovieEntry(Moviev moviev)
        {
            ViewBag.status = "";
            //using grabage collection only for inbuilt classes
            using (HttpClient client=new HttpClient())
            {
                StringContent content = new StringContent(JsonConvert.SerializeObject(moviev),Encoding.UTF8,"application/json");
                string endPoint = _configuration["WebApiBaseUrl"] + "Movie/AddMovie";//api controller name and its function

                using(var response = await client.PostAsync(endPoint,content))
                {
                    if(response.StatusCode==System.Net.HttpStatusCode.OK)
                    {   //dynamic viewbag we can create any variable name in run time
                        ViewBag.status = "Ok";
                        ViewBag.message = "Movie Details Saved Successfull!!";
                    }

                    else
                    {
                        ViewBag.status = "Error";
                        ViewBag.message = "Wrong Entries";
                    }

                }
            }
            return View();
        }

    }
}
