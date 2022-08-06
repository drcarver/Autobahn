//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefAllergySeverityList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefAllergySeverity Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefAllergySeverity"> List
         /// </summary>
        public static List<RefAllergySeverity> RefAllergySeverityList = new List<RefAllergySeverity> =
        {
            new RefAllergySeverity { Id=Guid.Parse("906ba3bd-6f6e-47ef-9f39-bab296322193"), Code="The level of severity of a person's reaction to an allergen is mild.", Description="Mild", Definition="", SortOrder=0 },
            new RefAllergySeverity { Id=Guid.Parse("2e5d6f16-0c7f-411f-8bbd-6bd898612d4e"), Code="The level of severity of a person's reaction to an allergen is severe.", Description="Severe", Definition="", SortOrder=0 },
        };

        /// <summary>
        /// The RefAllergySeverity Pick List
         /// </summary>
        public static List<RefAllergySeverity> RefAllergySeverityPickList = new List<RefAllergySeverity> =
        {
            new RefAllergySeverity { Id=Guid.Parse("906ba3bd-6f6e-47ef-9f39-bab296322193"), Code="The level of severity of a person's reaction to an allergen is mild.", SortOrder=0 },
            new RefAllergySeverity { Id=Guid.Parse("2e5d6f16-0c7f-411f-8bbd-6bd898612d4e"), Code="The level of severity of a person's reaction to an allergen is severe.", SortOrder=0 },
       };
   }
}
