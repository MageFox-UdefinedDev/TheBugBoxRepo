using BugServices.Models;
using System.Collections.Generic;

namespace BugServices.DB
{
    public static partial class Mock
    {
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