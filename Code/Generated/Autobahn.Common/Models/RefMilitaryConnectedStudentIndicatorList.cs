//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefMilitaryConnectedStudentIndicatorList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefMilitaryConnectedStudentIndicator Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefMilitaryConnectedStudentIndicator"> List
         /// </summary>
        public static List<RefMilitaryConnectedStudentIndicator> RefMilitaryConnectedStudentIndicatorList = new List<RefMilitaryConnectedStudentIndicator>
        {
            new RefMilitaryConnectedStudentIndicator { Id=Guid.Parse("a00be554-5709-4b1f-8a1a-2dbdb4bf10e9"), Code="NotMilitaryConnected", Description="Not Military Connected", Definition="Student is not military-connected.", SortOrder=Convert.ToDecimal("1.00") },
            new RefMilitaryConnectedStudentIndicator { Id=Guid.Parse("681668d5-a092-463c-aad6-3617fc307a18"), Code="ActiveDuty", Description="Active Duty", Definition="Student is a dependent of a member of the Active Duty Forces (full-time) Army, Navy, Air Force, Marine Corps, or Coast Guard or is a dependent of a member on Full-Time National Guard Duty.", SortOrder=Convert.ToDecimal("3.00") },
            new RefMilitaryConnectedStudentIndicator { Id=Guid.Parse("5c68ade8-334f-4582-87c7-2e13c82df54f"), Code="NationalGuardOrReserve", Description="National Guard Or Reserve", Definition="Student is a dependent of a member of the National Guard (not full-time duty) or Reserve Forces (Army, Navy, Air Force, Marine Corps, or Coast Guard).", SortOrder=Convert.ToDecimal("5.00") },
            new RefMilitaryConnectedStudentIndicator { Id=Guid.Parse("22d4b438-cdf5-4987-b3b4-3428fb477f1f"), Code="Unknown", Description="Unknown", Definition="It is unknown whether or not the student is military-connected.", SortOrder=Convert.ToDecimal("7.00") },
        };

        /// <summary>
        /// The RefMilitaryConnectedStudentIndicator Pick List
         /// </summary>
        public static List<RefMilitaryConnectedStudentIndicator> RefMilitaryConnectedStudentIndicatorPickList = new List<RefMilitaryConnectedStudentIndicator>
        {
            new RefMilitaryConnectedStudentIndicator { Id=Guid.Parse("a00be554-5709-4b1f-8a1a-2dbdb4bf10e9"), Code="NotMilitaryConnected", Description="Not Military Connected", SortOrder=Convert.ToDecimal("1.00") },
            new RefMilitaryConnectedStudentIndicator { Id=Guid.Parse("681668d5-a092-463c-aad6-3617fc307a18"), Code="ActiveDuty", Description="Active Duty", SortOrder=Convert.ToDecimal("3.00") },
            new RefMilitaryConnectedStudentIndicator { Id=Guid.Parse("5c68ade8-334f-4582-87c7-2e13c82df54f"), Code="NationalGuardOrReserve", Description="National Guard Or Reserve", SortOrder=Convert.ToDecimal("5.00") },
            new RefMilitaryConnectedStudentIndicator { Id=Guid.Parse("22d4b438-cdf5-4987-b3b4-3428fb477f1f"), Code="Unknown", Description="Unknown", SortOrder=Convert.ToDecimal("7.00") },
       };
   }
}
