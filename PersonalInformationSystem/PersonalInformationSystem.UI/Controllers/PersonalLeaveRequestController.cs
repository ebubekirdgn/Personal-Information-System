using Microsoft.AspNetCore.Mvc;

namespace PersonalInformationSystem.UI.Controllers
{
    public class PersonalLeaveRequestController : Controller
    {
        private readonly IPersonalLeaveRequestBusiness _personalLeaveRequestBusiness;


        public PersonalLeaveRequestController(IPersonalLeaveRequestBusiness personalLeaveRequestBusiness)
        {
            _personalLeaveRequestBusiness = personalLeaveRequestBusiness;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
