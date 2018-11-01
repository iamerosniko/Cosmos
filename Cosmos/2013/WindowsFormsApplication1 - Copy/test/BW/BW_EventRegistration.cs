using System.Collections.Generic;
using System.Linq;

namespace test.BW
{
    class BW_EventRegistration
    {
        private testEntities context;

        public BW_EventRegistration(testEntities _context)
        {
            context = _context;
        }

        public List<IS_EventRegistration> Get()
        {
            return context.IS_EventRegistration.ToList();
        }

        public bool Post(IS_EventRegistration registration)
        {
            //determine if already registered
            var registered = Get().Find(x => x.EventID == registration.EventID && x.WorkdayID == registration.WorkdayID);
            if (registered == null)
            {
                context.IS_EventRegistration.Add(registration);
                context.SaveChanges();
                return true;
            }
            return false;
        }

    }
}
