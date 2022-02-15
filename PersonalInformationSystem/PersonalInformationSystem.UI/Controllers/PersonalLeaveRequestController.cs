using Microsoft.AspNetCore.Mvc;

namespace PersonalInformationSystem.UI.Controllers
{
    public class PersonalLeaveRequestController : Controller
    {

        private readonly IPersonalLeaveRequestBusiness _personalLeaveRequestBusiness;
        private readonly IPersonalLeaveTypesBusiness _personalLeaveTypesBusiness;

        public PersonalLeaveRequestController(IPersonalLeaveRequestBusiness personalLeaveRequestBusiness,IPersonalLeaveTypesBusiness personalLeaveTypesBusiness)
        {
            _personalLeaveRequestBusiness = personalLeaveRequestBusiness;
            _personalLeaveTypesBusiness = personalLeaveTypesBusiness;
        }


        public IActionResult Index()
        {
            var user = JsonConvert.DeserializeObject<SessionContext>(HttpContext.Session.GetString(ResultConstant.LoginUserInfo));

            var requestModel = _personalLeaveRequestBusiness.GetAllLeaveRequestByUserId(user.LoginId);
            ViewBag.EmployeeLeaveTypes = _personalLeaveTypesBusiness.GetAllPersonalLeaveType();
            if (requestModel.IsSuccess)
                return View(requestModel.Data);
            return View(user);
        }

        public IActionResult Create()
        {
            ViewBag.EmployeeLeaveTypes = _personalLeaveTypesBusiness.GetAllPersonalLeaveType().Data;

            return View();
        }
    }
}