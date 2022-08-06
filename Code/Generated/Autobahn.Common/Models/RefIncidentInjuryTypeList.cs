//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefIncidentInjuryTypeList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefIncidentInjuryType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefIncidentInjuryType"> List
         /// </summary>
        public static List<RefIncidentInjuryType> RefIncidentInjuryTypeList = new List<RefIncidentInjuryType> =
        {
            new RefIncidentInjuryType { Id=Guid.Parse("6bf03b9f-9d80-4711-a462-5cf68c9bf6b7"), Code="", Description="MajorInjury", Definition="", SortOrder=0 },
            new RefIncidentInjuryType { Id=Guid.Parse("decb451e-9b8c-4967-953f-766d8838ab4a"), Code="", Description="MinorInjury", Definition="", SortOrder=0 },
            new RefIncidentInjuryType { Id=Guid.Parse("99bafe78-347b-4dc4-a920-a3d43c6fcdee"), Code="", Description="NoInjury", Definition="", SortOrder=0 },
            new RefIncidentInjuryType { Id=Guid.Parse("94977eba-53df-43fc-b43e-793d08e6c32b"), Code="", Description="SeriousBodilyInjury", Definition="", SortOrder=0 },
            new RefIncidentInjuryType { Id=Guid.Parse("7d57e0ce-1294-4943-b020-f1201a469f3f"), Code="", Description="FatalInjury", Definition="", SortOrder=0 },
        };

        /// <summary>
        /// The RefIncidentInjuryType Pick List
         /// </summary>
        public static List<RefIncidentInjuryType> RefIncidentInjuryTypePickList = new List<RefIncidentInjuryType> =
        {
            new RefIncidentInjuryType { Id=Guid.Parse("6bf03b9f-9d80-4711-a462-5cf68c9bf6b7"), Code="", SortOrder=0 },
            new RefIncidentInjuryType { Id=Guid.Parse("decb451e-9b8c-4967-953f-766d8838ab4a"), Code="", SortOrder=0 },
            new RefIncidentInjuryType { Id=Guid.Parse("99bafe78-347b-4dc4-a920-a3d43c6fcdee"), Code="", SortOrder=0 },
            new RefIncidentInjuryType { Id=Guid.Parse("94977eba-53df-43fc-b43e-793d08e6c32b"), Code="", SortOrder=0 },
            new RefIncidentInjuryType { Id=Guid.Parse("7d57e0ce-1294-4943-b020-f1201a469f3f"), Code="", SortOrder=0 },
       };
   }
}
