using DateTimeChecker.Model;
using DateTimeChecker.ServiceContract;
using Microsoft.AspNetCore.Mvc;

namespace DateTimeChecker.Controllers
{
    public class HomeController : Controller
    {
        private readonly IDateTimeService _dateTimeService;

        public HomeController(IDateTimeService dateTimeService)
        {
            _dateTimeService = dateTimeService;
        }

        [Route("/")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        [Route("/checkday")]
        public IActionResult CheckDay(Date date)
        {
            var totalDayInMonth = _dateTimeService.CheckDayInMonth(date.Month, date.Year);
            if (totalDayInMonth == 0 || date.Day > totalDayInMonth)
            {
                ViewBag.Result = $"{date} is Not correct date time!";
                return View();
            }
            ViewBag.Result = $"{date} is correct day time!";
            return View(date);
        }
    }
}
