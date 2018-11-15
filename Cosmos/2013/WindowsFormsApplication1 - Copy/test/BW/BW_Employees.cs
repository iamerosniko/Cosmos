using System.Collections.Generic;
using System.Linq;
using test.DTO;

namespace test.BW
{
    class BW_Employees
    {
        private testEntities context;

        public BW_Employees(testEntities _context)
        {
            context = _context;
        }

        public List<TeamsDTO> GetTeams()
        {
            var a = context.IS_Employees.OrderBy(x => x.EmployeeTeam);
            List<TeamsDTO> teamsTemp = new List<TeamsDTO>();
            List<TeamsDTO> teams = new List<TeamsDTO>();
            foreach (var b in a)
            {
                teamsTemp.Add(new TeamsDTO
                {
                    TeamName = b.EmployeeTeam,
                    Leader = b.EmployeeTeamLeader
                });
            }
            List<string> tmpTeam = teamsTemp.Select(x => x.TeamName).Distinct().ToList();

            foreach (var tt in tmpTeam)
            {
                teams.Add(teamsTemp.Find(x => x.TeamName == tt));
            }
            return teams;
        }
        public List<IS_Employees> Get()
        {
            return context.IS_Employees.OrderBy(x => x.WorkdayID).ToList();
        }

        public bool Post(IS_Employees employees)
        {
            var a = Get().Find(x => x.WorkdayID == employees.WorkdayID);
            if (a == null)
            {
                context.IS_Employees.Add(employees);
                context.SaveChanges();
                return true;
            }
            else
            {
                a.EmployeeFirstName = employees.EmployeeFirstName;
                a.EmployeeLastName = employees.EmployeeLastName;
                a.EmployeeMiddleName = employees.EmployeeMiddleName;
                a.EmployeeTeam = employees.EmployeeTeam;
                a.EmployeeTeamLeader = employees.EmployeeTeamLeader;
                context.SaveChanges();
                return false;
            }
        }
        public void Put(IS_Employees employees)
        {
            //context.IS_Employees.
        }
        public bool Delete(string workdayID)
        {
            var Employee = Get().Find(x => x.WorkdayID == workdayID);
            if (Employee != null)
            {
                context.IS_Employees.Remove(Employee);
                context.SaveChanges();
                return true;
            }
            return false;

        }
    }
}
