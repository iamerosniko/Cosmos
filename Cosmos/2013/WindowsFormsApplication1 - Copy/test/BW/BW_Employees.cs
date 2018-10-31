using System.Collections.Generic;
using System.Linq;

namespace test.BW
{
    class BW_Employees
    {
        private testEntities context;

        public BW_Employees(testEntities _context)
        {
            context = _context;
        }

        public List<IS_Employees> Get()
        {
            return context.IS_Employees.ToList();
        }

        public void Post(IS_Employees employees)
        {
            context.IS_Employees.Add(employees);
            context.SaveChanges();
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
