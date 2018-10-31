using System.Collections.Generic;
using System.Linq;

namespace test.BW
{
    class BW_Events
    {
        private testEntities context;

        public BW_Events(testEntities _context)
        {
            context = _context;
        }

        public List<IS_Events> Get()
        {
            return context.IS_Events.ToList();
        }

        public bool Post(IS_Events events)
        {

            context.IS_Events.Add(events);
            context.SaveChanges();
            return true;

        }
        public void Put(IS_Events events)
        {
            //context.IS_Employees.
        }
        public bool Delete(int eventID)
        {
            var a = Get().Find(x => x.EventID == eventID);
            if (a != null)
            {
                context.IS_Events.Remove(a);
                context.SaveChanges();
                return true;
            }
            return false;

        }
    }
}
