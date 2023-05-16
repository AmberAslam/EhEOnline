using EhEOnline.Server.Data;
using EhEOnline.Shared;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EhEOnline.Server.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ContactController : ControllerBase
    {
        private readonly mydatabase _mydatabase;
        public ContactController(mydatabase database)
        {
            _mydatabase = database;
        }

        [HttpGet]
        public async Task<ActionResult<List<ContactUs>>> ContactUs()
        {
            var contactUs = await _mydatabase.ContactUs.ToListAsync();
            return contactUs;
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, ContactUs updated)
        {
            var contactUs = await _mydatabase.ContactUs.FindAsync(id);
            contactUs.id = updated.id;
            contactUs.name = updated.name;
            contactUs.phone = updated.phone;
            contactUs.email = updated.email;
            contactUs.comment = updated.comment;


            await _mydatabase.SaveChangesAsync();

            return OK(updated);
        }

        private IActionResult OK(ContactUs updated)
        {
            throw new NotImplementedException();
        }
    }
}
