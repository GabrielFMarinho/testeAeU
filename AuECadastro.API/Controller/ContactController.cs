using AuERegister.Repository;
using AuERegister.Repository.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AuECadastro.API.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactController : ControllerBase
    {
        private readonly Repository _repository;
        public ContactController()
        {
            _repository = new Repository();
        }

        [HttpGet("GetAllContacts")]
        public ActionResult<List<Contact>> GetAllContacts()
        {
            List<Contact> person = new List<Contact>();
            person.Add(new Contact { Id = 1, Name = "Gabriel", Sex = "Masculino", City = "JF" });
            person.Add(new Contact { Id = 2, Name = "Teste", Sex = "Masculino", City = "LD" });
            person.Add(new Contact { Id = 3, Name = "Maria", Sex = "Feminino", City = "Bicas" });
            person.Add(new Contact { Id = 4, Name = "Lara", Sex = "Feminino", City = "Leopoldina" });
            


            return _repository.GetAllPersons();
        }

        [HttpPost("AddContact")]
        public ActionResult<bool> AddContact(Contact contact) {
            bool result = _repository.AddContact(contact);
            return true;
        }
        
        // GET: PessoaController/Details/5
        /*public ActionResult<List<PersonViewModel>> Details(int id)
        {
            List<PersonViewModel> person = new List<PersonViewModel>();
            return person;
        }*/

        /*// POST: PessoaController/Create
        [HttpPost]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // POST: PessoaController/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PessoaController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }*/

    }
}
