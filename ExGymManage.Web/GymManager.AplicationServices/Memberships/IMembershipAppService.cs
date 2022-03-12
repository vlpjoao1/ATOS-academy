using GymManager.Core.Memberships;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManager.AplicationServices.Memberships
{
    public interface IMembershipAppService
    {
        List<Membership> GetMemberships();

        int AddMembership(Membership membership);
        void EditMembership(Membership membership);
        Membership GetMembership(int membershipId);

        void DeleteMembership(int membershipId);
    }
}
