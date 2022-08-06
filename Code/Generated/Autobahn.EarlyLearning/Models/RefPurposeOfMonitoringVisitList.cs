//**********************************************************
//* DomainName: Autobahn.EarlyLearning
//* FileName:   RefPurposeOfMonitoringVisitList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.EarlyLearning.Models
{
     /// <summary>
     /// The list of RefPurposeOfMonitoringVisit Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefPurposeOfMonitoringVisit"> List
         /// </summary>
        public static List<RefPurposeOfMonitoringVisit> RefPurposeOfMonitoringVisitList = new List<RefPurposeOfMonitoringVisit>
        {
            new RefPurposeOfMonitoringVisit { Id=Guid.Parse("6277de2a-4c40-46ba-b974-07565aa3f7b9"), Code="LicensingVisits", Description="Licensing Visits", Definition="The monitoring visit is for licensing.", SortOrder=Convert.ToDecimal("1.00") },
            new RefPurposeOfMonitoringVisit { Id=Guid.Parse("e24399a0-7030-4288-af9c-f9721e83ee6c"), Code="HeathSafety", Description="Health and Safety", Definition="The monitoring visit is for Health and Safety.", SortOrder=Convert.ToDecimal("3.00") },
            new RefPurposeOfMonitoringVisit { Id=Guid.Parse("f6607b31-33aa-4ac9-952b-16896cf0b3c0"), Code="Renewal", Description="Renewal", Definition="The monitoring visit is for Renewal.", SortOrder=Convert.ToDecimal("5.00") },
            new RefPurposeOfMonitoringVisit { Id=Guid.Parse("8a995981-b6c2-4698-a077-832b3e8fcc58"), Code="Review", Description="Review", Definition="The monitoring visit is for Review.", SortOrder=Convert.ToDecimal("7.00") },
            new RefPurposeOfMonitoringVisit { Id=Guid.Parse("5d5fde92-cd5e-461f-bdde-482fa0d823f0"), Code="Other", Description="Other", Definition="The monitoring visit is for Other.", SortOrder=Convert.ToDecimal("9.00") },
        };

        /// <summary>
        /// The RefPurposeOfMonitoringVisit Pick List
         /// </summary>
        public static List<RefPurposeOfMonitoringVisit> RefPurposeOfMonitoringVisitPickList = new List<RefPurposeOfMonitoringVisit>
        {
            new RefPurposeOfMonitoringVisit { Id=Guid.Parse("6277de2a-4c40-46ba-b974-07565aa3f7b9"), Code="LicensingVisits", Description="Licensing Visits", SortOrder=Convert.ToDecimal("1.00") },
            new RefPurposeOfMonitoringVisit { Id=Guid.Parse("e24399a0-7030-4288-af9c-f9721e83ee6c"), Code="HeathSafety", Description="Health and Safety", SortOrder=Convert.ToDecimal("3.00") },
            new RefPurposeOfMonitoringVisit { Id=Guid.Parse("f6607b31-33aa-4ac9-952b-16896cf0b3c0"), Code="Renewal", Description="Renewal", SortOrder=Convert.ToDecimal("5.00") },
            new RefPurposeOfMonitoringVisit { Id=Guid.Parse("8a995981-b6c2-4698-a077-832b3e8fcc58"), Code="Review", Description="Review", SortOrder=Convert.ToDecimal("7.00") },
            new RefPurposeOfMonitoringVisit { Id=Guid.Parse("5d5fde92-cd5e-461f-bdde-482fa0d823f0"), Code="Other", Description="Other", SortOrder=Convert.ToDecimal("9.00") },
       };
   }
}
