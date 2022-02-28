using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SiteManagement.Business.Abstract;
using SiteManagement.Business.Concrete;
using SiteManagement.Entities;
using System.Collections.Generic;

namespace SiteManagement.API.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class ResidentsController : ControllerBase
    {
        private IResidentService _residentService;
        public ResidentsController()
        {
            _residentService = new ResidentManager();
        }

        [HttpGet]
        public List<Resident> Get()
        {
            return _residentService.GetAllResidents();
        }

        [HttpGet("{id}")]
        public Resident Get(int id)
        {
            return _residentService.GetResidentById(id);
        }

        [HttpPost]
        public Resident Create([FromBody] Resident resident)
        {
            return _residentService.CreateResident(resident);
        }

        [HttpPut]
        public Resident Update([FromBody] Resident resident)
        {
            return _residentService.CreateResident(resident);
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
             _residentService.DeleteResident(id);
        }
    }
}
