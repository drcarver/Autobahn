//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefMilitaryActiveStudentIndicatorList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefMilitaryActiveStudentIndicator Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefMilitaryActiveStudentIndicator"> List
         /// </summary>
        public static List<RefMilitaryActiveStudentIndicator> RefMilitaryActiveStudentIndicatorList = new List<RefMilitaryActiveStudentIndicator> =
        {
            new RefMilitaryActiveStudentIndicator { Id=Guid.Parse("3cde8d9d-d61b-480f-8503-fac4ae4f6810"), Code="Student is not active in the military.", Description="NotActive", Definition="", SortOrder=0 },
            new RefMilitaryActiveStudentIndicator { Id=Guid.Parse("2b876314-45a7-4a9c-908f-2e04c5d60013"), Code="Student is an Active member of the Active Duty Forces, National Guard, or Reserve Forces.", Description="Active", Definition="", SortOrder=0 },
            new RefMilitaryActiveStudentIndicator { Id=Guid.Parse("a7e957ed-80e2-477b-a05c-99bdce63007b"), Code="It is unknown whether or not the Student is active in the military.", Description="Unknown", Definition="", SortOrder=0 },
        };

        /// <summary>
        /// The RefMilitaryActiveStudentIndicator Pick List
         /// </summary>
        public static List<RefMilitaryActiveStudentIndicator> RefMilitaryActiveStudentIndicatorPickList = new List<RefMilitaryActiveStudentIndicator> =
        {
            new RefMilitaryActiveStudentIndicator { Id=Guid.Parse("3cde8d9d-d61b-480f-8503-fac4ae4f6810"), Code="Student is not active in the military.", SortOrder=0 },
            new RefMilitaryActiveStudentIndicator { Id=Guid.Parse("2b876314-45a7-4a9c-908f-2e04c5d60013"), Code="Student is an Active member of the Active Duty Forces, National Guard, or Reserve Forces.", SortOrder=0 },
            new RefMilitaryActiveStudentIndicator { Id=Guid.Parse("a7e957ed-80e2-477b-a05c-99bdce63007b"), Code="It is unknown whether or not the Student is active in the military.", SortOrder=0 },
       };
   }
}
