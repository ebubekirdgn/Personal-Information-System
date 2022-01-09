

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

        [HttpPost]
        public ActionResult Create(PersonalLeaveTypeVM model)
        {
            if (ModelState.IsValid)
            {
                #region CreateOrEditExample
                //if (model.Id > 0)
                //{
                //    var data = _personalLeaveTypesBusiness.EditEmployeeLeaveType(model);

                //}
                //else
                //{
                //    var data = _personalLeaveTypesBusiness.CreateEmployeeLeaveType(model);
                //    if (data.IsSuccess)
                //    {
                //        return RedirectToAction("Index");
                //    }
                //    return View(model);
                //} 
                #endregion
                var data = _personalLeaveTypesBusiness.CreatePersonalLeaveType(model);
                if (data.IsSuccess)
                {
                    return RedirectToAction("Index");
                }
                return View(model);
            }
            else
                return View(model);
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            if (id < 0)
                return View();

            var data = _personalLeaveTypesBusiness.GetAllEmployeeLeaveType(id);
            if (data.IsSuccess)
                return View(data.Data);
            return View();
        }

        [ValidateAntiForgeryToken]
        [HttpPost]
        public ActionResult Edit(PersonalLeaveTypeVM model)
        {
            if (ModelState.IsValid)
            {
                var data = _personalLeaveTypesBusiness.EditEmployeeLeaveType(model);
                if (data.IsSuccess)
                {
                    return RedirectToAction("Index");
                }
                return View(model);
            }
            else
                return View(model);
        }


    }
}