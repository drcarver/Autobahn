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
        public static List<RefDisabilityConditionStatusCode> RefDisabilityConditionStatusCodeList = new List<RefDisabilityConditionStatusCode> =
        {
            new RefDisabilityConditionStatusCode { Id=Guid.Parse("6ffd8201-9a53-4b4a-92c7-7932e302596c"), Code="A person's disability has been confirmed as a permanent disability.", Description="Permanent", Definition="", SortOrder=0 },
            new RefDisabilityConditionStatusCode { Id=Guid.Parse("2bb9e90a-2a40-4457-ac48-13f2e7fc9762"), Code="A person's disability has been confirmed as a temporary disability.", Description="Temporary", Definition="", SortOrder=0 },
        };

        /// <summary>
        /// The RefDisabilityConditionStatusCode Pick List
         /// </summary>
        public static List<RefDisabilityConditionStatusCode> RefDisabilityConditionStatusCodePickList = new List<RefDisabilityConditionStatusCode> =
        {
            new RefDisabilityConditionStatusCode { Id=Guid.Parse("6ffd8201-9a53-4b4a-92c7-7932e302596c"), Code="A person's disability has been confirmed as a permanent disability.", SortOrder=0 },
            new RefDisabilityConditionStatusCode { Id=Guid.Parse("2bb9e90a-2a40-4457-ac48-13f2e7fc9762"), Code="A person's disability has been confirmed as a temporary disability.", SortOrder=0 },
       };
   }
}
