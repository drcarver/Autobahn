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
        public static List<RefIncidentMultipleOffenseType> RefIncidentMultipleOffenseTypeList = new List<RefIncidentMultipleOffenseType> =
        {
            new RefIncidentMultipleOffenseType { Id=Guid.Parse("2e003290-fb61-4d22-aa0c-251065c9dc3c"), Code="The offense was primary in nature when a single incident included more than one type of offense.", Description="Primary", Definition="", SortOrder=0 },
            new RefIncidentMultipleOffenseType { Id=Guid.Parse("8953e742-dc72-4eac-8ced-50c2fe559ab6"), Code="The offense was secondary in nature when a single incident included more than one type of offense.", Description="Secondary", Definition="", SortOrder=0 },
        };

        /// <summary>
        /// The RefIncidentMultipleOffenseType Pick List
         /// </summary>
        public static List<RefIncidentMultipleOffenseType> RefIncidentMultipleOffenseTypePickList = new List<RefIncidentMultipleOffenseType> =
        {
            new RefIncidentMultipleOffenseType { Id=Guid.Parse("2e003290-fb61-4d22-aa0c-251065c9dc3c"), Code="The offense was primary in nature when a single incident included more than one type of offense.", SortOrder=0 },
            new RefIncidentMultipleOffenseType { Id=Guid.Parse("8953e742-dc72-4eac-8ced-50c2fe559ab6"), Code="The offense was secondary in nature when a single incident included more than one type of offense.", SortOrder=0 },
       };
   }
}
