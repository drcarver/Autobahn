//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefIncidentMultipleOffenseTypeList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefIncidentMultipleOffenseType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefIncidentMultipleOffenseType"> List
         /// </summary>
        public static List<RefIncidentMultipleOffenseType> RefIncidentMultipleOffenseTypeList = new List<RefIncidentMultipleOffenseType>
        {
            new RefIncidentMultipleOffenseType { Id=Guid.Parse("27d4c7fa-8896-4f40-8570-53176ab998c1"), Code="Primary", Description="Primary", Definition="The offense was primary in nature when a single incident included more than one type of offense.", SortOrder=Convert.ToDecimal("1.00") },
            new RefIncidentMultipleOffenseType { Id=Guid.Parse("8e8968bb-2a34-477c-a0c2-30b2d494cff7"), Code="Secondary", Description="Secondary", Definition="The offense was secondary in nature when a single incident included more than one type of offense.", SortOrder=Convert.ToDecimal("2.00") },
        };

        /// <summary>
        /// The RefIncidentMultipleOffenseType Pick List
         /// </summary>
        public static List<RefIncidentMultipleOffenseType> RefIncidentMultipleOffenseTypePickList = new List<RefIncidentMultipleOffenseType>
        {
            new RefIncidentMultipleOffenseType { Id=Guid.Parse("27d4c7fa-8896-4f40-8570-53176ab998c1"), Code="Primary", Description="Primary", SortOrder=Convert.ToDecimal("1.00") },
            new RefIncidentMultipleOffenseType { Id=Guid.Parse("8e8968bb-2a34-477c-a0c2-30b2d494cff7"), Code="Secondary", Description="Secondary", SortOrder=Convert.ToDecimal("2.00") },
       };
   }
}
