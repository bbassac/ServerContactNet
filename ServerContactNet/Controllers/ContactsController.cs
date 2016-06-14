using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using ServerNet.Controllers;
using ServerNet.Repository;
using ServerNet.Models;
using Microsoft.Extensions.Logging;

namespace ServerNet.Controllers
{
    [Route("api/[controller]")]
    public class ContactsController : Controller
    {
        private readonly ILogger<ContactsController> _logger;

        public IContactsRepository ContactsRepo { get; set; }

        public ContactsController(IContactsRepository _repo,ILogger<ContactsController> logger)
        {
            ContactsRepo = _repo;
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Contacts> GetAll()
        {
            _logger.LogCritical("Listing all items");
            return ContactsRepo.GetAll();
   
        }

        [HttpGet("{id}", Name = "GetContacts")]
        public IActionResult GetById(long id)
        {
            var item = ContactsRepo.Find(id);
            if (item == null)
            {
                return NotFound();
            }
            return new ObjectResult(item);
        }

        [HttpPost]
        public IActionResult Create([FromBody] Contacts item)
        {
            if (item == null)
            {
                return BadRequest();
            }
            ContactsRepo.Add(item);
            return CreatedAtRoute("GetContacts", new { Controller = "Contacts", id = item.Id }, item);
        }

        [HttpPut("{id}")]
        public IActionResult Update(long id, [FromBody] Contacts item)
        {
            if (item == null)
            {
                return BadRequest();
            }
            var contactObj = ContactsRepo.Find(id);
            if (contactObj == null)
            {
                return NotFound();
            }
            ContactsRepo.Update(item);
            return new NoContentResult();
        }

        [HttpDelete("{id}")]
        public void Delete(long id)
        {
            ContactsRepo.Remove(id);
        }
    }
}
