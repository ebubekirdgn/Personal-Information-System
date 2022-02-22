namespace PersonalInformationSystem.UI.Controllers
{
    [Authorize(Roles = ResultConstant.Admin_Role)]
    public class PersonalLeaveAssignController : Controller
    {
        #region Variables

        private readonly IPersonalLeaveAssignBusiness _personalLeaveAssignBusiness;
        private readonly IPersonalLeaveRequestBusiness _personalLeaveRequestBusiness;

        #endregion Variables

        public PersonalLeaveAssignController(IPersonalLeaveAssignBusiness personalLeaveAssignBusiness, IPersonalLeaveRequestBusiness personalLeaveRequestBusiness)
        {
            _personalLeaveAssignBusiness = personalLeaveAssignBusiness;
            _personalLeaveRequestBusiness = personalLeaveRequestBusiness;
        }

        public IActionResult Index()
        {
            var data = _personalLeaveRequestBusiness.GetSendApprovedLeaveRequests();
            if (data.IsSuccess)
                return View(data.Data);
            return View();
        }
    }
}