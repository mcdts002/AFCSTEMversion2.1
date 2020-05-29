using AFCSTEM.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AFCSTEM.Models
{
    public class SQLTeamRepository : ITeamRepository
    {

        private readonly ApplicationDbContext context;

        public SQLTeamRepository(ApplicationDbContext context)
        {
            this.context = context;
        }

        public Team CreateTeam(String StudentId, int DEF2, int DEF3, int DEF4, int DEF5, int DEF6,
            int DEF1, int FWD1, int FWD2, int FWD3, int FWD4, int FWD5, int FWD6, int MID1, int MID2, int MID3, int MID4, int RUCK1, int RUCK2)
        {
            Team newTeam = new Team();
            newTeam.StudentId = StudentId;
            newTeam.MID1 = MID1;
            newTeam.MID2 = MID2;
            newTeam.MID3 = MID3;
            newTeam.MID4 = MID4;
            newTeam.FWD1 = FWD1;
            newTeam.FWD2 = FWD2;
            newTeam.FWD3 = FWD3;
            newTeam.FWD4 = FWD4;
            newTeam.FWD5 = FWD5;
            newTeam.FWD6 = FWD6;
            newTeam.DEF1 = DEF1;
            newTeam.DEF2 = DEF2;
            newTeam.DEF3 = DEF3;
            newTeam.DEF4 = DEF4;
            newTeam.DEF5 = DEF5;
            newTeam.DEF6 = DEF6;
            newTeam.RUCK1 = RUCK1;
            newTeam.RUCK2 = RUCK2;


            context.Teams.Add(newTeam);
            context.SaveChanges();
            return newTeam;
        }

        public Team GetTeam(string id)
        {
            return context.Teams.Find(id);
        }

        public Team UpdateTeam(Team team, int DEF2, int DEF3, int DEF4, int DEF5, int DEF6,
            int DEF1, int FWD1, int FWD2, int FWD3, int FWD4, int FWD5, int FWD6, int MID1, int MID2, int MID3, int MID4, int RUCK1, int RUCK2)
        {
            team.MID1 = MID1;
            team.MID2 = MID2;
            team.MID3 = MID3;
            team.MID4 = MID4;
            team.FWD1 = FWD1;
            team.FWD2 = FWD2;
            team.FWD3 = FWD3;
            team.FWD4 = FWD4;
            team.FWD5 = FWD5;
            team.FWD6 = FWD6;
            team.DEF1 = DEF1;
            team.DEF2 = DEF2;
            team.DEF3 = DEF3;
            team.DEF4 = DEF4;
            team.DEF5 = DEF5;
            team.DEF6 = DEF6;
            team.RUCK1 = RUCK1;
            team.RUCK2 = RUCK2;


            var teamUpdate = context.Teams.Attach(team);
            teamUpdate.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
            return team;
        }
    }
}
