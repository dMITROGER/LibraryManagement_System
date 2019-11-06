using LibraryManagementSystem.HelperClass;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    //this class helps to communicate with DB member table 
    public static class MemberHelper
    {
        static LibraryEntities context = new LibraryEntities();
        // retrieves all members from database
        public static List<Member> GetAllMembers()
        {
            List<Member> allMembers =
                (from m in context.Members
                 select m).ToList();

            return allMembers;
        }

        //returns true if there is such user name in the database
        public static bool IsMember(Member member)
        {
            List<Member> allMembers = GetAllMembers();

            foreach (Member item in allMembers)
            {
                if (item.Username == member.Username)
                    return true;
            }

            return false;
        }

        // returns true is there is a member and password combination in the database
        public static bool LogIn(Member member)
        {
            List<Member> allMembers = GetAllMembers();

            foreach (Member dbMember in allMembers)
            {
                if ((dbMember.Username == member.Username) 
                    && (dbMember.PIN == member.PIN))
                {
                    SetMember(dbMember);
                    return true;
                }
            }

            return false;
        }
        
        //adding a new member to the database
        public static bool Register(Member member)
        {
            context.Members.Add(member);

            context.SaveChanges();

            return IsMember(member);
        }

        // setting current member
        private static void SetMember(Member member)
        {
            CurrentMember.SetCurrentMember(member);
        }

       //creating member ID 
        public static string CreateMemberID()
        {
            List<Member> members = GetAllMembers();

            int intMemberID = 100000000 + members.Count + 1;

            string memberID = intMemberID.ToString();

            return memberID;
        }

        //removing member from database
        public static void RemoveMember(string memberId)
        {
            Member member = context.Members.Find(memberId);
            
            context.Members.Remove(member);

            context.SaveChanges();
        }
    }
}
