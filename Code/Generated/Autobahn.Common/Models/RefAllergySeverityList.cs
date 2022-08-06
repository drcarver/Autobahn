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
        public static List<RefAllergySeverity> RefAllergySeverityList = new List<RefAllergySeverity>
        {
            new RefAllergySeverity { Id=Guid.Parse("4a06dff3-df72-41ff-beba-b9dcf0f6868e"), Code="Mild", Description="Mild allergic reaction", Definition="The level of severity of a person's reaction to an allergen is mild.", SortOrder=Convert.ToDecimal("1.00") },
            new RefAllergySeverity { Id=Guid.Parse("d009e6f7-34d2-41b8-9f77-965aaa8ae63e"), Code="Severe", Description="Severe allergic reaction", Definition="The level of severity of a person's reaction to an allergen is severe.", SortOrder=Convert.ToDecimal("2.00") },
        };

        /// <summary>
        /// The RefAllergySeverity Pick List
         /// </summary>
        public static List<RefAllergySeverity> RefAllergySeverityPickList = new List<RefAllergySeverity>
        {
            new RefAllergySeverity { Id=Guid.Parse("4a06dff3-df72-41ff-beba-b9dcf0f6868e"), Code="Mild", Description="Mild allergic reaction", SortOrder=Convert.ToDecimal("1.00") },
            new RefAllergySeverity { Id=Guid.Parse("d009e6f7-34d2-41b8-9f77-965aaa8ae63e"), Code="Severe", Description="Severe allergic reaction", SortOrder=Convert.ToDecimal("2.00") },
       };
   }
}
