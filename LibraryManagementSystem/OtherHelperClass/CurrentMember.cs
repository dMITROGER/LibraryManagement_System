using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.HelperClass
{
   //class for tracking current member
    public static class CurrentMember
    {
        private static Member Current { get; set; }

        public static Member GetCurrentMember()
        {
            return Current;
        }

        public static void SetCurrentMember(Member member)
        {
            Current = member;
        }
    }
}
