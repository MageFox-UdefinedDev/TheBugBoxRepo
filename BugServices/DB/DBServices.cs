using BugServices.Models;
using System.Collections.Generic;

namespace BugServices.DB
{
    public interface DBServices
    {
        List<Person> GetAllPerson();

        Person FindPerson();

        List<Trap> GetAllTrap();

        Trap FindTrap();
    }
}