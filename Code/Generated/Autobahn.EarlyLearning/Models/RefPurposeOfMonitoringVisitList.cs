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
        /// The complete <see cref="RefPurposeOfMonitoringVisitModel"> List
         /// </summary>
        public static List<RefPurposeOfMonitoringVisitModel> RefPurposeOfMonitoringVisitList = new List<RefPurposeOfMonitoringVisitModel>
        {
            new RefPurposeOfMonitoringVisit { Id=Guid.Parse("36cd3105-6740-4c54-8053-b61482d28274"), Code="LicensingVisits", Description="Licensing Visits", Definition="The monitoring visit is for licensing.", SortOrder=Convert.ToDecimal("1.00") },
            new RefPurposeOfMonitoringVisit { Id=Guid.Parse("c8b0c37f-bbb6-4eb9-921a-c1a2774a0f72"), Code="HeathSafety", Description="Health and Safety", Definition="The monitoring visit is for Health and Safety.", SortOrder=Convert.ToDecimal("3.00") },
            new RefPurposeOfMonitoringVisit { Id=Guid.Parse("41083dd8-abfb-4b50-8c3b-b24607e451fc"), Code="Renewal", Description="Renewal", Definition="The monitoring visit is for Renewal.", SortOrder=Convert.ToDecimal("5.00") },
            new RefPurposeOfMonitoringVisit { Id=Guid.Parse("aaee26fe-7e5f-4052-8564-20c82c52d6cb"), Code="Review", Description="Review", Definition="The monitoring visit is for Review.", SortOrder=Convert.ToDecimal("7.00") },
            new RefPurposeOfMonitoringVisit { Id=Guid.Parse("9045848e-9e30-498d-b152-9f6570bf61fd"), Code="Other", Description="Other", Definition="The monitoring visit is for Other.", SortOrder=Convert.ToDecimal("9.00") },
        };

        /// <summary>
        /// The Reference RefPurposeOfMonitoringVisit Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefPurposeOfMonitoringVisitViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefPurposeOfMonitoringVisit { Id=Guid.Parse("36cd3105-6740-4c54-8053-b61482d28274"), Description="Licensing Visits", SortOrder=Convert.ToDecimal("1.00") },
            new RefPurposeOfMonitoringVisit { Id=Guid.Parse("c8b0c37f-bbb6-4eb9-921a-c1a2774a0f72"), Description="Health and Safety", SortOrder=Convert.ToDecimal("3.00") },
            new RefPurposeOfMonitoringVisit { Id=Guid.Parse("41083dd8-abfb-4b50-8c3b-b24607e451fc"), Description="Renewal", SortOrder=Convert.ToDecimal("5.00") },
            new RefPurposeOfMonitoringVisit { Id=Guid.Parse("aaee26fe-7e5f-4052-8564-20c82c52d6cb"), Description="Review", SortOrder=Convert.ToDecimal("7.00") },
            new RefPurposeOfMonitoringVisit { Id=Guid.Parse("9045848e-9e30-498d-b152-9f6570bf61fd"), Description="Other", SortOrder=Convert.ToDecimal("9.00") },
       };
   }
}
