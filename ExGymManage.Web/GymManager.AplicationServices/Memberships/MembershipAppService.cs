using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GymManager.Core.Memberships;

namespace GymManager.AplicationServices.Memberships
{
    public class MembershipAppService : IMembershipAppService
    {
        private static List<Membership> Memberships = new List<Membership>();

        public List<Membership> GetMemberships()
        {
            /*Memberships.Add(new Membership { 
                Id=1,
                Name="Member 1 month",
                CreatedOn=new DateTime(),
                Duration=3
            });*/
            return Memberships;
        }

        public int AddMembership(Membership membership)
        {
            membership.Id = new Random().Next();
            Memberships.Add(membership);
            return membership.Id;
        }

        public void EditMembership(Membership membership)
        {
            var ms = Memberships.Where(x => x.Id == membership.Id).FirstOrDefault();
            ms.Name = membership.Name;
            ms.Cost = membership.Cost;
            ms.CreatedOn = membership.CreatedOn;
            ms.Duration = membership.Duration;
        }

        public Membership GetMembership(int memberId)
        {
            var ms = Memberships.Where(x => x.Id == memberId).FirstOrDefault();
            return ms;
        }

        public void DeleteMembership(int membershipId)
        {
            //localizamos el elemento en la lista
            var m = Memberships.Where(x => x.Id == membershipId).FirstOrDefault();
            Memberships.Remove(m);
        }
    }
}
