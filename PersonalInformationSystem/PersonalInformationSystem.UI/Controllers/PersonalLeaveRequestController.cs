
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

            return View();
        }
    }
}
