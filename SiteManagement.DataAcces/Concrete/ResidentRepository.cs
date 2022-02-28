using Site.Abstract;
using SiteManagement.DataAcces;
using SiteManagement.Entities;
using System.Collections.Generic;
using System.Linq;

namespace Site.Concrete
{
    public class ResidentRepository : IResidentRepository

    {
        public List<Resident> GetAllResidents()
        {
            using (var siteDbContext = new SiteDbContext())
            {
                return siteDbContext.Residents.ToList(); 
            }
        }

        public Resident CreateResident(Resident resident)
        {
            using (var siteDbContext = new SiteDbContext())
            {
                siteDbContext.Residents.Add(resident);
                siteDbContext.SaveChanges();
                return resident;
            }
        }

        public void DeleteResident(int id)
        {
            using (var siteDbContext = new SiteDbContext())
            {
                var deleteResident = GetResidentById(id);
                siteDbContext.Residents.Remove(deleteResident);
                siteDbContext.SaveChanges();
            }
        }


        public Resident GetResidentById(int id)
        {
            using (var siteDbContext = new SiteDbContext())
            {
                return siteDbContext.Residents.Find(id);
            }
        }

        public Resident UpdateResident(Resident resident)
        {
            using (var siteDbContext = new SiteDbContext())
            {
                siteDbContext.Residents.Update(resident);
                siteDbContext.SaveChanges();
                return resident;
            }

        }
    }
}
