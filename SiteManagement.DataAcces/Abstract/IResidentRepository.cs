using SiteManagement.Entities;
using System.Collections.Generic;

namespace Site.Abstract
{
    public interface IResidentRepository
    {

        List<Resident> GetAllResidents();

        Resident GetResidentById(int id);

        Resident CreateResident(Resident resident);

        Resident UpdateResident(Resident resident);

        void DeleteResident(int id);



    }
}
