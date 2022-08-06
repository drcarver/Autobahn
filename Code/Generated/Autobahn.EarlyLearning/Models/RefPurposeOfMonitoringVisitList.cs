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
        public static List<RefPurposeOfMonitoringVisit> RefPurposeOfMonitoringVisitList = new List<RefPurposeOfMonitoringVisit> =
        {
            new RefPurposeOfMonitoringVisit { Id=Guid.Parse("d8ab42f2-2fd7-4667-8119-48c19beb61aa"), Code="The monitoring visit is for licensing.", Description="LicensingVisits", Definition="", SortOrder=0 },
            new RefPurposeOfMonitoringVisit { Id=Guid.Parse("b3c0717b-804c-4f85-bd40-418839865f77"), Code="The monitoring visit is for Health and Safety.", Description="HeathSafety", Definition="", SortOrder=0 },
            new RefPurposeOfMonitoringVisit { Id=Guid.Parse("4c0cdc58-1ed7-46f6-8fc7-3976bbdd7b0b"), Code="The monitoring visit is for Renewal.", Description="Renewal", Definition="", SortOrder=0 },
            new RefPurposeOfMonitoringVisit { Id=Guid.Parse("6ce6aa6d-e9f0-446c-b2c8-93266fd3ff7c"), Code="The monitoring visit is for Review.", Description="Review", Definition="", SortOrder=0 },
            new RefPurposeOfMonitoringVisit { Id=Guid.Parse("7a8f4b67-d68e-49d0-b608-ce069f2d562f"), Code="The monitoring visit is for Other.", Description="Other", Definition="", SortOrder=0 },
        };

        /// <summary>
        /// The RefPurposeOfMonitoringVisit Pick List
         /// </summary>
        public static List<RefPurposeOfMonitoringVisit> RefPurposeOfMonitoringVisitPickList = new List<RefPurposeOfMonitoringVisit> =
        {
            new RefPurposeOfMonitoringVisit { Id=Guid.Parse("d8ab42f2-2fd7-4667-8119-48c19beb61aa"), Code="The monitoring visit is for licensing.", SortOrder=0 },
            new RefPurposeOfMonitoringVisit { Id=Guid.Parse("b3c0717b-804c-4f85-bd40-418839865f77"), Code="The monitoring visit is for Health and Safety.", SortOrder=0 },
            new RefPurposeOfMonitoringVisit { Id=Guid.Parse("4c0cdc58-1ed7-46f6-8fc7-3976bbdd7b0b"), Code="The monitoring visit is for Renewal.", SortOrder=0 },
            new RefPurposeOfMonitoringVisit { Id=Guid.Parse("6ce6aa6d-e9f0-446c-b2c8-93266fd3ff7c"), Code="The monitoring visit is for Review.", SortOrder=0 },
            new RefPurposeOfMonitoringVisit { Id=Guid.Parse("7a8f4b67-d68e-49d0-b608-ce069f2d562f"), Code="The monitoring visit is for Other.", SortOrder=0 },
       };
   }
}
