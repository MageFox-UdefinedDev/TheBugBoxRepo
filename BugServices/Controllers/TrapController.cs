using BugServices.DB;
using BugServices.Models;
using System.Collections.Generic;
using System.Web.Http;

namespace BugServices.Controllers
{
    public class TrapController : ApiController
    {
        [HttpGet]
        public List<Trap> GetAllTrap() => Mock.GetAllTrapMock();

        [HttpGet]
        public Trap GetFindTrap(int id) => Mock.GetFindTrap(id);
    }
}