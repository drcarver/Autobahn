//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefMilitaryVeteranStudentIndicatorList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefMilitaryVeteranStudentIndicator Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefMilitaryVeteranStudentIndicator"> List
         /// </summary>
        public static List<RefMilitaryVeteranStudentIndicator> RefMilitaryVeteranStudentIndicatorList = new List<RefMilitaryVeteranStudentIndicator>
        {
            new RefMilitaryVeteranStudentIndicator { Id=Guid.Parse("37342595-8b64-48bf-8425-c3f29d7aa4c2"), Code="NotVeteran", Description="Not a Veteran", Definition="Student is not a veteran of the military.", SortOrder=Convert.ToDecimal("1.00") },
            new RefMilitaryVeteranStudentIndicator { Id=Guid.Parse("5bd1a350-1db8-4726-ba1c-3049ca2189b3"), Code="Veteran", Description="Veteran", Definition="Student is a Veteran of the Active Duty Forces, National Guard, or Reserve Forces.", SortOrder=Convert.ToDecimal("3.00") },
            new RefMilitaryVeteranStudentIndicator { Id=Guid.Parse("866172ff-a58c-4161-945b-ae021e6e9afa"), Code="Unknown", Description="Unknown", Definition="It is unknown whether or not the Student is a veteran of the military.", SortOrder=Convert.ToDecimal("5.00") },
        };

        /// <summary>
        /// The RefMilitaryVeteranStudentIndicator Pick List
         /// </summary>
        public static List<RefMilitaryVeteranStudentIndicator> RefMilitaryVeteranStudentIndicatorPickList = new List<RefMilitaryVeteranStudentIndicator>
        {
            new RefMilitaryVeteranStudentIndicator { Id=Guid.Parse("37342595-8b64-48bf-8425-c3f29d7aa4c2"), Code="NotVeteran", Description="Not a Veteran", SortOrder=Convert.ToDecimal("1.00") },
            new RefMilitaryVeteranStudentIndicator { Id=Guid.Parse("5bd1a350-1db8-4726-ba1c-3049ca2189b3"), Code="Veteran", Description="Veteran", SortOrder=Convert.ToDecimal("3.00") },
            new RefMilitaryVeteranStudentIndicator { Id=Guid.Parse("866172ff-a58c-4161-945b-ae021e6e9afa"), Code="Unknown", Description="Unknown", SortOrder=Convert.ToDecimal("5.00") },
       };
   }
}
