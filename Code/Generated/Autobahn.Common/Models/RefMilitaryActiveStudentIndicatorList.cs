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
        public static List<RefMilitaryActiveStudentIndicator> RefMilitaryActiveStudentIndicatorList = new List<RefMilitaryActiveStudentIndicator>
        {
            new RefMilitaryActiveStudentIndicator { Id=Guid.Parse("1c5bb6a1-d1a9-4bdd-a37c-ed88d85794ea"), Code="NotActive", Description="Not Active", Definition="Student is not active in the military.", SortOrder=Convert.ToDecimal("1.00") },
            new RefMilitaryActiveStudentIndicator { Id=Guid.Parse("e54cac58-a535-45ab-8a4a-a708bf7a0e15"), Code="Active", Description="Active", Definition="Student is an Active member of the Active Duty Forces, National Guard, or Reserve Forces.", SortOrder=Convert.ToDecimal("3.00") },
            new RefMilitaryActiveStudentIndicator { Id=Guid.Parse("36080f3b-43a1-4974-a05a-7f0fc72c7f24"), Code="Unknown", Description="Unknown", Definition="It is unknown whether or not the Student is active in the military.", SortOrder=Convert.ToDecimal("5.00") },
        };

        /// <summary>
        /// The RefMilitaryActiveStudentIndicator Pick List
         /// </summary>
        public static List<RefMilitaryActiveStudentIndicator> RefMilitaryActiveStudentIndicatorPickList = new List<RefMilitaryActiveStudentIndicator>
        {
            new RefMilitaryActiveStudentIndicator { Id=Guid.Parse("1c5bb6a1-d1a9-4bdd-a37c-ed88d85794ea"), Code="NotActive", Description="Not Active", SortOrder=Convert.ToDecimal("1.00") },
            new RefMilitaryActiveStudentIndicator { Id=Guid.Parse("e54cac58-a535-45ab-8a4a-a708bf7a0e15"), Code="Active", Description="Active", SortOrder=Convert.ToDecimal("3.00") },
            new RefMilitaryActiveStudentIndicator { Id=Guid.Parse("36080f3b-43a1-4974-a05a-7f0fc72c7f24"), Code="Unknown", Description="Unknown", SortOrder=Convert.ToDecimal("5.00") },
       };
   }
}
