using BugServices.Models;
using System.Collections.Generic;
using System.Web.Http;
using BugServices.DB;

namespace BugServices.Controllers
{
    public class PersonController : ApiController
    {
        [HttpGet]
        public List<Person> GetAllPerson() => Mock.GetAllPersonMock();

        [HttpGet]
        public Person GetFindPerson(int id) => Mock.GetFindPerson(id);
    }
}