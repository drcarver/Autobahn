//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefDisabilityConditionStatusCodeList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefDisabilityConditionStatusCode Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefDisabilityConditionStatusCode"> List
         /// </summary>
        public static List<RefDisabilityConditionStatusCode> RefDisabilityConditionStatusCodeList = new List<RefDisabilityConditionStatusCode>
        {
            new RefDisabilityConditionStatusCode { Id=Guid.Parse("3e3c1f01-4bc6-47cd-9b6f-acb059d86cfe"), Code="Permanent", Description="Disability has been confirmed as a permanent disability", Definition="A person's disability has been confirmed as a permanent disability.", SortOrder=Convert.ToDecimal("1.00") },
            new RefDisabilityConditionStatusCode { Id=Guid.Parse("7456ade4-09ae-4a77-9133-7625a5157e2a"), Code="Temporary", Description="Disability has been confirmed as a temporary disability", Definition="A person's disability has been confirmed as a temporary disability.", SortOrder=Convert.ToDecimal("2.00") },
        };

        /// <summary>
        /// The RefDisabilityConditionStatusCode Pick List
         /// </summary>
        public static List<RefDisabilityConditionStatusCode> RefDisabilityConditionStatusCodePickList = new List<RefDisabilityConditionStatusCode>
        {
            new RefDisabilityConditionStatusCode { Id=Guid.Parse("3e3c1f01-4bc6-47cd-9b6f-acb059d86cfe"), Code="Permanent", Description="Disability has been confirmed as a permanent disability", SortOrder=Convert.ToDecimal("1.00") },
            new RefDisabilityConditionStatusCode { Id=Guid.Parse("7456ade4-09ae-4a77-9133-7625a5157e2a"), Code="Temporary", Description="Disability has been confirmed as a temporary disability", SortOrder=Convert.ToDecimal("2.00") },
       };
   }
}
