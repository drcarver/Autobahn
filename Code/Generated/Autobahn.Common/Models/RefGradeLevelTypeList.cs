//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefGradeLevelTypeList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefGradeLevelType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefGradeLevelType"> List
         /// </summary>
        public static List<RefGradeLevelType> RefGradeLevelTypeList = new List<RefGradeLevelType>
        {
            new RefGradeLevelType { Id=Guid.Parse("167a5def-a3ae-4d57-a463-9c4fa9eb8e9b"), Code="000100", Description="Entry Grade Level", Definition="", SortOrder=Convert.ToDecimal("") },
            new RefGradeLevelType { Id=Guid.Parse("4e63e9b0-bb2a-4fa9-95c5-58554fca1416"), Code="000125", Description="Grade Level When Course Taken", Definition="", SortOrder=Convert.ToDecimal("") },
            new RefGradeLevelType { Id=Guid.Parse("fcc4ee59-e3a2-48da-812c-06b0bd2a89bd"), Code="000126", Description="Grade Level When Assessed", Definition="", SortOrder=Convert.ToDecimal("") },
            new RefGradeLevelType { Id=Guid.Parse("560c9ed5-21c2-4bb9-a362-618532aa4678"), Code="000131", Description="Grades Offered", Definition="", SortOrder=Convert.ToDecimal("") },
            new RefGradeLevelType { Id=Guid.Parse("d156e8d5-b9dc-4ed1-bf04-a4a656f41d98"), Code="000177", Description="Assessment Level for Which Designed", Definition="", SortOrder=Convert.ToDecimal("") },
            new RefGradeLevelType { Id=Guid.Parse("48af51a6-7853-4362-9049-0c408269b3d1"), Code="001057", Description="Assessment Registration Grade Level to Be Assessed", Definition="", SortOrder=Convert.ToDecimal("") },
            new RefGradeLevelType { Id=Guid.Parse("8c6975a3-a25c-4ec5-aaef-58d9875e1abc"), Code="001210", Description="Exit Grade Level", Definition="", SortOrder=Convert.ToDecimal("") },
        };

        /// <summary>
        /// The RefGradeLevelType Pick List
         /// </summary>
        public static List<RefGradeLevelType> RefGradeLevelTypePickList = new List<RefGradeLevelType>
        {
            new RefGradeLevelType { Id=Guid.Parse("167a5def-a3ae-4d57-a463-9c4fa9eb8e9b"), Code="000100", Description="Entry Grade Level", SortOrder=Convert.ToDecimal("") },
            new RefGradeLevelType { Id=Guid.Parse("4e63e9b0-bb2a-4fa9-95c5-58554fca1416"), Code="000125", Description="Grade Level When Course Taken", SortOrder=Convert.ToDecimal("") },
            new RefGradeLevelType { Id=Guid.Parse("fcc4ee59-e3a2-48da-812c-06b0bd2a89bd"), Code="000126", Description="Grade Level When Assessed", SortOrder=Convert.ToDecimal("") },
            new RefGradeLevelType { Id=Guid.Parse("560c9ed5-21c2-4bb9-a362-618532aa4678"), Code="000131", Description="Grades Offered", SortOrder=Convert.ToDecimal("") },
            new RefGradeLevelType { Id=Guid.Parse("d156e8d5-b9dc-4ed1-bf04-a4a656f41d98"), Code="000177", Description="Assessment Level for Which Designed", SortOrder=Convert.ToDecimal("") },
            new RefGradeLevelType { Id=Guid.Parse("48af51a6-7853-4362-9049-0c408269b3d1"), Code="001057", Description="Assessment Registration Grade Level to Be Assessed", SortOrder=Convert.ToDecimal("") },
            new RefGradeLevelType { Id=Guid.Parse("8c6975a3-a25c-4ec5-aaef-58d9875e1abc"), Code="001210", Description="Exit Grade Level", SortOrder=Convert.ToDecimal("") },
       };
   }
}
