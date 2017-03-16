using Microsoft.AspNetCore.Mvc;

namespace SaveTheAnimals.Controllers
{
    public class ErrorController : Controller
    {
        public ViewResult Error() => View();
    }
}