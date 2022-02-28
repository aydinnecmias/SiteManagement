using Site.Abstract;
using Site.Concrete;
using SiteManagement.Business.Abstract;
using SiteManagement.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiteManagement.Business.Concrete
{
    public class ResidentManager : IResidentService
    {
        private IResidentRepository _residentRepository;
        public ResidentManager()
        {
            _residentRepository = new ResidentRepository();
        }
        public Resident CreateResident(Resident resident)
        {
            return _residentRepository.CreateResident(resident);
        }

        public void DeleteResident(int id)
        {
            _residentRepository.DeleteResident(id);
        }

        public List<Resident> GetAllResidents()
        {
            return _residentRepository.GetAllResidents();
        }

        public Resident GetResidentById(int id)
        {
            if (id > 0)
            {
            return _residentRepository.GetResidentById(id);

            }
            throw new Exception("Id can not be less than 1");
            
        }

        public Resident UpdateResident(Resident resident)
        {
            return _residentRepository.UpdateResident(resident);
        }
    }
}
