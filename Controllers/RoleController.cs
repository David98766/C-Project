using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

// This code is from a Yogihosting Tutorial available here: https://www.yogihosting.com/aspnet-core-identity-roles/

namespace Identity.Controllers
{
    public class RoleController : Controller
    {
        private RoleManager<IdentityRole> roleManager;
        public RoleController(RoleManager<IdentityRole> roleMgr)
        {
            roleManager = roleMgr;
        }

        public ViewResult Index() => View(roleManager.Roles);

        private void Errors(IdentityResult result)
        {
            foreach (IdentityError error in result.Errors)
                ModelState.AddModelError("", error.Description);
        }
    }
}