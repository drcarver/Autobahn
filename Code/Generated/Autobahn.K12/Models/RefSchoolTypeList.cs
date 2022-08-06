//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   RefSchoolTypeList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.K12.Models
{
     /// <summary>
     /// The list of RefSchoolType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefSchoolType"> List
         /// </summary>
        public static List<RefSchoolType> RefSchoolTypeList = new List<RefSchoolType> =
        {
            new RefSchoolType { Id=Guid.Parse("c9af4e5c-0273-4e1c-9825-aab6dbb93f83"), Code="A school that does not focus primarily on career and technical, special, or alternative education, although it may provide these programs in addition to a regular curriculum.", Description="Regular", Definition="", SortOrder=0 },
            new RefSchoolType { Id=Guid.Parse("979bd38a-c48d-4d45-b300-2c2720fc6969"), Code="A  school that focuses primarily on serving the educational needs of students with disabilities (IDEA) and which adapts curriculum, materials, or instruction for these students.", Description="Special", Definition="", SortOrder=0 },
            new RefSchoolType { Id=Guid.Parse("1990c9b3-b003-4538-b297-0e76145737fe"), Code="A school that focuses primarily on providing secondary students with an occupationally relevant or career-related curriculum, including formal preparation for technical or professional occupations.", Description="CareerAndTechnical", Definition="", SortOrder=0 },
            new RefSchoolType { Id=Guid.Parse("97d95e04-9e87-48bd-aa13-06d7c0b03c02"), Code="A school that addresses the needs of students that typically cannot be met in a regular school program and is designed to meet the needs of students with academic difficulties, students with discipline problems, or both students with academic difficulties and discipline problems.", Description="Alternative", Definition="", SortOrder=0 },
            new RefSchoolType { Id=Guid.Parse("ec75596b-049d-4d84-bb98-ab08bbe0c87c"), Code="The permitted value "reportable program" is available for SEAs that have data to report to EDFacts at the school level that the SEA has determined does not meet the definition of a public elementary/secondary school.", Description="Reportable", Definition="", SortOrder=0 },
        };

        /// <summary>
        /// The RefSchoolType Pick List
         /// </summary>
        public static List<RefSchoolType> RefSchoolTypePickList = new List<RefSchoolType> =
        {
            new RefSchoolType { Id=Guid.Parse("c9af4e5c-0273-4e1c-9825-aab6dbb93f83"), Code="A school that does not focus primarily on career and technical, special, or alternative education, although it may provide these programs in addition to a regular curriculum.", SortOrder=0 },
            new RefSchoolType { Id=Guid.Parse("979bd38a-c48d-4d45-b300-2c2720fc6969"), Code="A  school that focuses primarily on serving the educational needs of students with disabilities (IDEA) and which adapts curriculum, materials, or instruction for these students.", SortOrder=0 },
            new RefSchoolType { Id=Guid.Parse("1990c9b3-b003-4538-b297-0e76145737fe"), Code="A school that focuses primarily on providing secondary students with an occupationally relevant or career-related curriculum, including formal preparation for technical or professional occupations.", SortOrder=0 },
            new RefSchoolType { Id=Guid.Parse("97d95e04-9e87-48bd-aa13-06d7c0b03c02"), Code="A school that addresses the needs of students that typically cannot be met in a regular school program and is designed to meet the needs of students with academic difficulties, students with discipline problems, or both students with academic difficulties and discipline problems.", SortOrder=0 },
            new RefSchoolType { Id=Guid.Parse("ec75596b-049d-4d84-bb98-ab08bbe0c87c"), Code="The permitted value "reportable program" is available for SEAs that have data to report to EDFacts at the school level that the SEA has determined does not meet the definition of a public elementary/secondary school.", SortOrder=0 },
       };
   }
}
