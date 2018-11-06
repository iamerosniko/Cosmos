using System;
using System.Collections.Generic;
using System.Linq;
using test.DTO;

namespace test.BW
{
    class BW_EventRegistration
    {
        private testEntities context;
        private BW_Employees _bwEmp;
        private BW_Events _bwEvnt;

        public BW_EventRegistration(testEntities _context)
        {
            context = _context;
            _bwEmp = new BW_Employees(_context);
            _bwEvnt = new BW_Events(_context);
        }

        public List<EventRegistered> Get()
        {
            var eventRegistratonList = context.IS_EventRegistration.OrderBy(x => x.EventRegistrationSignedDate).ToList();
            List<EventRegistered> registeredEmployees = new List<EventRegistered>();
            foreach (var eRL in eventRegistratonList)
            {
                var tempEmp = _bwEmp.Get().Find(x => x.WorkdayID == eRL.WorkdayID);
                var tempEvnt = _bwEvnt.Get().Find(x => x.EventID == eRL.EventID);

                if (tempEmp != null && tempEvnt != null)
                {
                    registeredEmployees.Add(new EventRegistered
                    {
                        EmployeeName = tempEmp.EmployeeName,
                        EventName = tempEvnt.EventName,
                        EventRegistrationSignedDate = eRL.EventRegistrationSignedDate,
                        WorkdayID = tempEmp.WorkdayID,
                        TeamName = tempEmp.EmployeeTeam,
                        TeamLeader = tempEmp.EmployeeTeamLeader
                    });
                }
            }
            return registeredEmployees;
        }

        public bool Post(IS_EventRegistration registration)
        {
            //determine if already registered
            var registered = context.IS_EventRegistration.ToList()
                .Find(x => x.EventID == registration.EventID && x.WorkdayID == registration.WorkdayID);
            if (registered == null)
            {
                //EventRegistrationSignedDate = DateTime.Now.ToShortDateString(),

                registration.EventRegistrationSignedDate = DateTime.Now.ToShortDateString() + "-" + DateTime.Now.ToShortTimeString();
                context.IS_EventRegistration.Add(registration);
                context.SaveChanges();
                return true;
            }
            return false;
        }

    }
}
