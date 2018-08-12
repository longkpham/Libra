using LibraClient.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Threading.Tasks;

namespace OnlineSalesTool.Controllers
{
    public class SpaEntryController : Controller
    {
        public SpaEntryController()
        {
        }

        [HttpGet]
        //SPA entry
        public async Task<IActionResult> Index()
        {
            return await Task.FromResult(View());
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
