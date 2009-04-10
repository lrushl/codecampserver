using System.Web.Mvc;
using CodeCampServer.Core.Domain;
using CodeCampServer.Core.Domain.Model;
using CodeCampServer.UI.Models.Forms;

namespace CodeCampServer.UI.Controllers
{
    public class AdminController : SmartController
    {
        private readonly IUserRepository _repository;

        public AdminController(IUserRepository repository)
        {
            _repository = repository;
        }


        public ActionResult Index(Conference conference)
        {
            User user = _repository.GetByUserName("admin");
            if (user == null)
            {
                return RedirectToAction<UserController>(c => c.Edit(null));
            }
            var model = new AdminForm() {ConferenceIsSelected = conference != null};

            return View(model);
        }
    }
}