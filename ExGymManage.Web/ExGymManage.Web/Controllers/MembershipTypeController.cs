using GymManager.AplicationServices.Memberships;
using GymManager.Core.Memberships;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExGymManage.Web.Controllers
{
    public class MembershipTypeController : Controller
    {
        private readonly IMembershipAppService _membershipAppService;
        public MembershipTypeController(IMembershipAppService membershipAppService)
        {
            _membershipAppService = membershipAppService;

            
        }
        public IActionResult Index()
        {
            List<Membership> memberships = _membershipAppService.GetMemberships();
            return View(memberships);
        }

        public IActionResult Create()
        {
            return View();
        }
        public IActionResult Edit(int membershipId)
        {
            Membership membership = _membershipAppService.GetMembership(membershipId);
            return View(membership);
        }
        public IActionResult Delete(int membershipId)
        {
            _membershipAppService.DeleteMembership(membershipId);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Create(Membership membership)
        {
            membership.CreatedOn = new DateTime();
            _membershipAppService.AddMembership(membership);
            return RedirectToAction("Index");
        }
        [HttpPost]
        public IActionResult Edit(Membership membership)
        {
            _membershipAppService.EditMembership(membership);
            return RedirectToAction("Index");
        }




    }
}
