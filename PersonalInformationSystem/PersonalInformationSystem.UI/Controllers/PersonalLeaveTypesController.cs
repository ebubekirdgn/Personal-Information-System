using Microsoft.AspNetCore.Mvc;
using PersonalInformationSystem.Business.Contracts;

namespace PersonalInformationSystem.UI.Controllers
{
    public class PersonalLeaveTypesController : Controller
    {
        private readonly IPersonalLeaveTypesBusiness _personalLeaveTypesBusiness;

        public PersonalLeaveTypesController(IPersonalLeaveTypesBusiness personalLeaveTypesBusiness)
        {
            _personalLeaveTypesBusiness = personalLeaveTypesBusiness;
        }

        public IActionResult Index()
        {
            var data = _personalLeaveTypesBusiness.GetAllPersonalLeaveType();

            if (data.IsSuccess)
            {
                var result = data.Data;
                return View(result);
            }
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }
    }
}