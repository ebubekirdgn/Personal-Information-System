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
            ViewBag.PersonalLeaveTypes = _personalLeaveTypesBusiness.GetAllPersonalLeaveType().Data;

            return View();
        }

        [HttpPost]
        public IActionResult Create(PersonalLeaveRequestVM model, int? id)
        {
            var user = JsonConvert.DeserializeObject<SessionContext>(HttpContext.Session.GetString(ResultConstant.LoginUserInfo));

            #region CreateOrEditExample

            if (id > 0)
            {
                _personalLeaveRequestBusiness.EditPersonalLeaveRequest(model, user);
                return RedirectToAction("Index");
            }
            else
            {
                var data = _personalLeaveRequestBusiness.CreatePersonalLeaveRequest(model, user);
                if (data.IsSuccess)
                    return RedirectToAction("Index");
                return View(model);
            }

            #endregion CreateOrEditExample
        }

        public ActionResult Edit(int? id)
        {
            ViewBag.PersonalLeaveTypes = _personalLeaveTypesBusiness.GetAllPersonalLeaveType().Data;
            if (id > 0)
            {
                var data = _personalLeaveRequestBusiness.GetAllLeaveRequestById((int)id);
                return View(data.Data);
            }
            else
                return View();
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            if (id <= 0)
                return Json(new { success = false, message = "Silmek için Kayıt Seçiniz" });

            var data = _personalLeaveRequestBusiness.RemovePersonalRequest(id);
            if (data.IsSuccess)
                return Json(new { success = data.IsSuccess, message = data.Message });
            else
                return Json(new { success = data.IsSuccess, message = data.Message });
        }
    }
}