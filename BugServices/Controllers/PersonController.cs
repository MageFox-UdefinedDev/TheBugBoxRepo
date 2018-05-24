using BugServices.DB;
using BugServices.Models;
using System.Collections.Generic;
using System.Web.Http;

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