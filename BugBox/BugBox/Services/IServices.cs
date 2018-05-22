using BugBox.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BugBox.Services
{
    internal interface IServices
    {
        Task<List<Trap>> GetAllTraps();

        Task<Trap> FindTrap(int id);

        Task<List<Person>> GetAllPerson();

        Task<Person> FindPerson(int id);
    }
}