using Microsoft.AspNetCore.Mvc;
namespace greystore.Controllers
{
    public class ErrorController : Controller
    {
        public ViewResult Error() => View();
    }
}