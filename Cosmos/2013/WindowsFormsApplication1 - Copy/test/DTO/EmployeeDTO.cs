namespace test.DTO
{
    class EmployeeDTO
    {
        public string WorkdayID { get; set; }
        public string EmployeeName { get; set; }
        public string EmployeeTeam { get; set; }
        public string EmployeeTeamLeader { get; set; }
    }
    class EmployeeDTO2
    {
        public dynamic WorkdayID { get; set; }
        public dynamic EmployeeName { get; set; }
        public dynamic EmployeeTeam { get; set; }
        public dynamic EmployeeTeamLeader { get; set; }
    }
}
