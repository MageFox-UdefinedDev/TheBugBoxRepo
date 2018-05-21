using BugServices.Models;
using System.Collections.Generic;

namespace BugServices.DB
{
    public static partial class Mock
    {
        public static List<Person> GetAllPersonMock()
        {
            return _personList;
        }

        public static Person GetFindPerson(int id)
        {
            return _personList.Find(x => x.PersonId == id);
        }
    }
}