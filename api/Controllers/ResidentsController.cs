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
        public ResidentsController(IResidentService residentService)
        {
            _residentService = residentService;
        }

        [HttpGet]
        [Route("GetAllResident}")]
        public IActionResult GetAllResidents()
        {
            var residents = _residentService.GetAllResidents();
            return Ok(residents);
        }

        [HttpGet]
        [Route("GetResidentById/{id}")]
        public IActionResult GetResidentById(int id)
        {
            var resident = _residentService.GetResidentById(id);
            if (resident != null)
            {
                return Ok(resident);
            }
            return NotFound(); 
        }

        [HttpPost]
        [Route("PostResidentById/{id}")]
        public IActionResult PostResidentById([FromBody] Resident resident)
        {   var createdResident = _residentService.CreateResident(resident);
            return CreatedAtAction("Get",new {id = createdResident.Id},createdResident); // 201 + created resident.
        }

        [HttpPut]
        [Route("UpdateResidentById/{id}")]
        public IActionResult UpdateResidentById([FromBody] Resident resident)
        {
            if(_residentService.GetResidentById(resident.Id)!=null)
            {
                return Ok(_residentService.UpdateResident(resident)); // 200 + resident data
            }
            return NotFound();
        }

        [HttpDelete]
        [Route("DeleteResidentById/{id}")]
        public IActionResult DeleteResidentById(int id)
        {
            if (_residentService.GetResidentById(id) != null)
            {
                _residentService.DeleteResident(id); 
                return Ok(); // 200 + resident data
            }
            return NotFound();
            
        }
    }
}
