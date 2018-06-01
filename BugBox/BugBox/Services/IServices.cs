using BugBox.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BugBox.Services
{
    internal interface IServices
    {
        Task<List<Trap>> GetAllTraps();

        Task<Trap> FindTrap(int id);

        Task<List<Person>> GetAllPerson();

        Task<Person> FindPerson(int id);

        Task<Person> AddPerson(Person person);

        Task<Trap> AddTrap(Trap trap);
    }
}