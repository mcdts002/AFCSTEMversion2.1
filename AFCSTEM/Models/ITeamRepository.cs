using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AFCSTEM.Models
{
    public interface ITeamRepository
    {
        Team GetTeam(string id);

        Team CreateTeam(String StudentId, int DEF2, int DEF3, int DEF4, int DEF5, int DEF6,
            int DEF1, int FWD1, int FWD2, int FWD3, int FWD4, int FWD5, int FWD6, int MID1, int MID2, int MID3, int MID4, int RUCK1, int RUCK2);

        Team UpdateTeam(Team team, int DEF2, int DEF3, int DEF4, int DEF5, int DEF6,
            int DEF1, int FWD1, int FWD2, int FWD3, int FWD4, int FWD5, int FWD6, int MID1, int MID2, int MID3, int MID4, int RUCK1, int RUCK2);
    }
}
