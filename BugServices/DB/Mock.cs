using BugServices.Models;
using System.Collections.Generic;

namespace BugServices.DB
{
    public static class Mock
    {
        private static List<Person> _personList = new List<Person>()
        {
                new Person(){PersonId = 0, Nick="Fox", Password="FoxPass" },
                new Person(){PersonId = 1, Nick="Bunny", Password="BunnyPass" },
                new Person(){PersonId = 2, Nick="Boar", Password="BoarPass" }
        };

        private static List<Trap> _traps = new List<Trap>()
        {
            new Trap(){ TrapId = 0, Name = "Afla", Comment = "Es una cajita ROJA puesta el dia 22/02/2021", Latitude = "132.0", Longitude = "-125.0"},
            new Trap(){ TrapId = 1, Name = "Beta", Comment = "Es una cajita AZUL puesta el dia 28/02/2021", Latitude = "132.1", Longitude = "-125.1"},
            new Trap(){ TrapId = 2, Name = "Charlie", Comment = "Es una cajita MORADA puesta el dia 7/02/2021", Latitude = "132.2", Longitude = "-125.2"},
            new Trap(){ TrapId = 3, Name = "Delta", Comment = "Es una cajita ROSA puesta el dia 31/02/2021", Latitude = "132.3", Longitude = "-125.3"},
            new Trap(){ TrapId = 4, Name = "Echo", Comment = "Es una cajita LILA puesta el dia 16/02/2021", Latitude = "132.4", Longitude = "-125.4"},
            new Trap(){ TrapId = 5, Name = "Foxtrot", Comment = "Es una cajita VERDE puesta el dia 17/02/2021", Latitude = "132.5", Longitude = "-125.5"},
            new Trap(){ TrapId = 6, Name = "Golf", Comment = "Es una cajita NEGRA puesta el dia 11/02/2021", Latitude = "132.6", Longitude = "-125.6"},
            new Trap(){ TrapId = 7, Name = "Hotel", Comment = "Es una cajita BLANCA puesta el dia 09/02/2021", Latitude = "132.7", Longitude = "-125.7"}
        };

        public static List<Person> GetAllPersonMock()
        {
            return _personList;
        }

        public static Person GetFindPerson(int id)
        {
            return _personList.Find(x => x.PersonId == id);
        }

        public static List<Trap> GetAllTrapMock()
        {
            return _traps;
        }

        public static Trap GetFindTrap(int id)
        {
            return _traps.Find(x => x.TrapId == id);
        }
    }
}