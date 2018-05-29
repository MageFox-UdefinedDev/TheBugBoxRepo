using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using BugBox.Models;

namespace BugBox.Services
{
    internal class DummyService : IServices
    {
        private static List<Person> _personList = new List<Person>()
        {
                new Person(){PersonId = 0, Nick="Fox", Password="FoxPass" },
                new Person(){PersonId = 1, Nick="Bunny", Password="BunnyPass" },
                new Person(){PersonId = 2, Nick="Boar", Password="BoarPass" }
        };

        private static List<Trap> _traps = new List<Trap>()
        {
            new Trap(){ TrapId = 0, Name = "Afla", Comment = "Es una cajita ROJA puesta el dia 22/02/2021", Latitude = 36.960235, Longitude =  -122.019472, Status = 1},
            new Trap(){ TrapId = 1, Name = "Beta", Comment = "Es una cajita AZUL puesta el dia 28/02/2021", Latitude = 36.9628066, Longitude = -122.0194722, Status = 2},
            new Trap(){ TrapId = 2, Name = "Charlie", Comment = "Es una cajita MORADA puesta el dia 7/02/2021", Latitude = 36.9628066, Longitude = -122.0194722, Status = 2},
            new Trap(){ TrapId = 3, Name = "Delta", Comment = "Es una cajita ROSA puesta el dia 31/02/2021", Latitude = 36.9628066, Longitude =-122.0194722, Status = 3},
            new Trap(){ TrapId = 4, Name = "Echo", Comment = "Es una cajita LILA puesta el dia 16/02/2021", Latitude = 36.9628066, Longitude = -122.0194722, Status = 3},
            new Trap(){ TrapId = 5, Name = "Foxtrot", Comment = "Es una cajita VERDE puesta el dia 17/02/2021", Latitude = 36.9628066, Longitude = -122.0194722, Status = 1},
            new Trap(){ TrapId = 6, Name = "Golf", Comment = "Es una cajita NEGRA puesta el dia 11/02/2021", Latitude = 36.9628066, Longitude = -122.0194722, Status = 1},
            new Trap(){ TrapId = 7, Name = "Hotel", Comment = "Es una cajita BLANCA puesta el dia 09/02/2021", Latitude = 36.9628066, Longitude = -122.0194722, Status = 3}
        };

        public Task<Person> FindPerson(int id)
        {
            return Task.Run(() => FindPersonPrivate(id));
        }

        public Task<Trap> FindTrap(int id)
        {
            return Task.Run(() => FindTrapPrivate(id));
        }

        public Task<List<Person>> GetAllPerson()
        {
            return Task.Run(() => GetAllPersonPrivate());
        }

        public Task<List<Trap>> GetAllTraps()
        {
            return Task.Run(() => GetAllTrapsPrivate());
        }

        #region public dummys

        public List<Trap> GetAllTrapsPublic()
        {
            return _traps;
        }

        public List<Person> GetAllPersonPublic()
        {
            return _personList;
        }

        public Trap FindTrapPublic(int id)
        {
            return _traps.Find(x => x.TrapId == id);
        }

        public Person FindPersonPublic(int id)
        {
            return _personList.Find(x => x.PersonId == id);
        }

        #endregion public dummys

        #region Private dummys

        private List<Trap> GetAllTrapsPrivate()
        {
            return _traps;
        }

        private List<Person> GetAllPersonPrivate()
        {
            return _personList;
        }

        private Trap FindTrapPrivate(int id)
        {
            return _traps.Find(x => x.TrapId == id);
        }

        private Person FindPersonPrivate(int id)
        {
            return _personList.Find(x => x.PersonId == id);
        }

        #endregion Private dummys
    }
}