using OfficeOpenXml;
using System.Collections.Generic;
using System.Data;
using System.IO;
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

        public List<IS_Employees> import(string path)
        {
            //readExcel
            DataTable employee = GetDataTableFromExcel(path);
            //toList
            List<IS_Employees> employeeList = empDTToList(employee);
            //process
            return employeeList;
        }
        private DataTable GetDataTableFromExcel(string path, bool hasHeader = true)
        {
            using (var pck = new ExcelPackage())
            {
                using (var stream = File.OpenRead(path))
                {
                    pck.Load(stream);
                }
                var ws = pck.Workbook.Worksheets.First();
                DataTable tbl = new DataTable();
                foreach (var firstRowCell in ws.Cells[1, 1, 1, ws.Dimension.End.Column])
                {
                    tbl.Columns.Add(hasHeader ? firstRowCell.Text : string.Format("Column {0}", firstRowCell.Start.Column));
                }
                var startRow = hasHeader ? 2 : 1;
                for (int rowNum = startRow; rowNum <= ws.Dimension.End.Row; rowNum++)
                {
                    var wsRow = ws.Cells[rowNum, 1, rowNum, ws.Dimension.End.Column];
                    DataRow row = tbl.Rows.Add();
                    foreach (var cell in wsRow)
                    {
                        row[cell.Start.Column - 1] = cell.Text;
                    }
                }
                return tbl;
            }
        }
        private List<IS_Employees> empDTToList(DataTable dt)
        {
            List<IS_Employees> empList = new List<IS_Employees>();
            empList = (from DataRow dr in dt.Rows
                       select new IS_Employees()
                       {
                           WorkdayID = dr[0].ToString(),
                           EmployeeFirstName = dr[1].ToString(),
                           EmployeeMiddleName = dr[2].ToString(),
                           EmployeeLastName = dr[3].ToString(),
                           EmployeeTeam = dr[4].ToString(),
                           EmployeeTeamLeader = dr[5].ToString()
                       }).ToList();
            return empList;
        }
    }
}
