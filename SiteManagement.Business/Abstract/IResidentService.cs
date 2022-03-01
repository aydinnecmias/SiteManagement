using SiteManagement.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiteManagement.Business.Abstract
{
   public interface IResidentService
    {
        List<Resident> GetAllResidents();

        Resident GetResidentById(int id);
        Resident GetResidentByName(string name);

        Resident CreateResident(Resident resident);

        Resident UpdateResident(Resident resident);

        void DeleteResident(int id);
    }
}
