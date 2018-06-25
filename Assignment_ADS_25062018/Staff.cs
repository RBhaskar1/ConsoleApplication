using System;
using System.Collections.Generic;
using System.Linq;

namespace Assignment_ADS_25062018
{
    public class Staff
    {
        public int StaffID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int JobType { get; set; }
        public string Job { get; set; }
        public int Manager { get; set; } //StaffID

        public HashSet<Staff> StaffMembers = new HashSet<Staff>();

        public void AddStaff(Staff st)
        {
            StaffMembers.Add(st);
        }

        public void ModifyStaff(Staff st)
        {
            Staff staff = StaffMembers.FirstOrDefault(s => s.StaffID == st.StaffID);
            staff = st;
        }

        public void DeleteStaff(Staff st)
        {
            StaffMembers.Remove(st);
        }

        public void InitializeStaff()
        {
            Staff st1 = new Staff
            {
                StaffID = 1,
                FirstName = "Mark",
                LastName = "White",
                JobType = 1,
                Job = "Manager",
                Manager = 0
            };
            Staff st2 = new Staff
            {
                StaffID = 2,
                FirstName = "Hudson",
                LastName = "Blake",
                JobType = 2,
                Job = "Cashier",
                Manager = 1
            };
            Staff st3 = new Staff
            {
                StaffID = 3,
                FirstName = "Thomason",
                LastName = "Cook",
                JobType = 3,
                Job = "Chief Chef",
                Manager = 1
            };
            Staff st4 = new Staff
            {
                StaffID = 4,
                FirstName = "Alice",
                LastName = "Hendry",
                JobType = 4,
                Job = "Chef",
                Manager = 3
            };
            Staff st5 = new Staff
            {
                StaffID = 5,
                FirstName = "William",
                LastName = "Blake",
                JobType = 4,
                Job = "Chef",
                Manager = 3
            };
            Staff st6 = new Staff
            {
                StaffID = 6,
                FirstName = "Alexender",
                LastName = "Falais",
                JobType = 4,
                Job = "Chef",
                Manager = 3
            };
            Staff st7 = new Staff
            {
                StaffID = 7,
                FirstName = "Stephenie",
                LastName = "Joking",
                JobType = 5,
                Job = "Coffee Maker",
                Manager = 3
            };
            Staff st8 = new Staff
            {
                StaffID = 8,
                FirstName = "Mark",
                LastName = "Happy",
                JobType = 5,
                Job = "Coffee Maker",
                Manager = 3
            };
            Staff st9 = new Staff
            {
                StaffID = 9,
                FirstName = "John",
                LastName = "Steve",
                JobType = 5,
                Job = "Coffee Maker",
                Manager = 3
            };
            Staff st10 = new Staff
            {
                StaffID = 10,
                FirstName = "Jenifer",
                LastName = "Stone",
                JobType = 6,
                Job = "Waiter",
                Manager = 2
            };
            Staff st11 = new Staff
            {
                StaffID = 11,
                FirstName = "Jasmine",
                LastName = "WhWahite",
                JobType = 6,
                Job = "Waiter",
                Manager = 2
            };
            Staff st12 = new Staff
            {
                StaffID = 12,
                FirstName = "Smith",
                LastName = "Henry",
                JobType = 6,
                Job = "Waiter",
                Manager = 2
            };

            StaffMembers.Add(st1);
            StaffMembers.Add(st2);
            StaffMembers.Add(st3);
            StaffMembers.Add(st4);
            StaffMembers.Add(st5);
            StaffMembers.Add(st6);
            StaffMembers.Add(st7);
            StaffMembers.Add(st8);
            StaffMembers.Add(st9);
            StaffMembers.Add(st10);
            StaffMembers.Add(st11);
            StaffMembers.Add(st12);

        }
    }
}
