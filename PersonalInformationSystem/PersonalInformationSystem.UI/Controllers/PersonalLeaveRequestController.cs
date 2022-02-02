
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
            var user = JsonConvert.DeserializeObject<SessionContext>(HttpContext.Session.GetString(ResultConstant.LoginUserInfo));

            var requestModel = _personalLeaveRequestBusiness.GetAllLeaveRequestByUserId(user.LoginId);
            if (requestModel.IsSuccess)
                return View(requestModel.Data);

            return View(user);
        }
    }
}
