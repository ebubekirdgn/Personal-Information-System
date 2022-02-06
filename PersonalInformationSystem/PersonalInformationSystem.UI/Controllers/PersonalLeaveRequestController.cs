namespace PersonalInformationSystem.UI.Controllers
{
    public class PersonalLeaveRequestController : Controller
    {
        private readonly IPersonalLeaveRequestBusiness _personalLeaveRequestBusiness;
        private readonly IPersonalLeaveTypesBusiness _personalLeaveTypesBusiness;

        public PersonalLeaveRequestController(IPersonalLeaveRequestBusiness personalLeaveRequestBusiness, IPersonalLeaveTypesBusiness personalLeaveTypesBusiness)
        {
            _personalLeaveRequestBusiness = personalLeaveRequestBusiness;
            _personalLeaveTypesBusiness = personalLeaveTypesBusiness;
        }

        public IActionResult Index()
        {
            var user = JsonConvert.DeserializeObject<SessionContext>(HttpContext.Session.GetString(ResultConstant.LoginUserInfo));

            var requestModel = _personalLeaveRequestBusiness.GetAllLeaveRequestByUserId(user.LoginId);
            ViewBag.PersonalLeaveTypes = _personalLeaveTypesBusiness.GetAllPersonalLeaveType();

            if (requestModel.IsSuccess)
                return View(requestModel.Data);

            return View(user);
        }

        public IActionResult Create()
        {
            ViewBag.EmployeeLeaveTypes = _personalLeaveTypesBusiness.GetAllPersonalLeaveType().Data;

            return View();
        }

        [HttpPost]
        public IActionResult Create(PersonalLeaveRequestVM model, int? id)
        {
            var user = JsonConvert.DeserializeObject<SessionContext>(HttpContext.Session.GetString(ResultConstant.LoginUserInfo));
            #region CreateOrEditExample
            if (id > 0)
            {
                var data = _personalLeaveRequestBusiness.EditPersonalLeaveRequest(model, user);
                return RedirectToAction("Index");
            }
            else
            {
                var data = _personalLeaveRequestBusiness.CreatePersonalLeaveRequest(model, user);
                if (data.IsSuccess)
                    return RedirectToAction("Index");
                return View(model);
            }
            #endregion
        }
    }
}