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
        public static List<RefSchoolType> RefSchoolTypeList = new List<RefSchoolType>
        {
            new RefSchoolType { Id=Guid.Parse("d35919d0-3bfc-4fce-96c1-29d799dd3039"), Code="Regular", Description="Regular School", Definition="A school that does not focus primarily on career and technical, special, or alternative education, although it may provide these programs in addition to a regular curriculum.", SortOrder=Convert.ToDecimal("1.00") },
            new RefSchoolType { Id=Guid.Parse("77a0af5b-77bd-4f77-a07e-364dc8deedf2"), Code="Special", Description="Special Education School", Definition="A  school that focuses primarily on serving the educational needs of students with disabilities (IDEA) and which adapts curriculum, materials, or instruction for these students.", SortOrder=Convert.ToDecimal("2.00") },
            new RefSchoolType { Id=Guid.Parse("79936f0c-80e6-4803-b0a1-93a5e4a65de2"), Code="CareerAndTechnical", Description="Career and Technical Education School", Definition="A school that focuses primarily on providing secondary students with an occupationally relevant or career-related curriculum, including formal preparation for technical or professional occupations.", SortOrder=Convert.ToDecimal("3.00") },
            new RefSchoolType { Id=Guid.Parse("0c6e4860-6333-4994-bd61-4b6cf9ef25c2"), Code="Alternative", Description="Alternative Education School", Definition="A school that addresses the needs of students that typically cannot be met in a regular school program and is designed to meet the needs of students with academic difficulties, students with discipline problems, or both students with academic difficulties and discipline problems.", SortOrder=Convert.ToDecimal("4.00") },
            new RefSchoolType { Id=Guid.Parse("2f3b30a6-61d6-4af8-ad8c-7932fff223c6"), Code="Reportable", Description="Reportable Program", Definition="The permitted value \u0022reportable program\u0022 is available for SEAs that have data to report to EDFacts at the school level that the SEA has determined does not meet the definition of a public elementary/secondary school.", SortOrder=Convert.ToDecimal("5.00") },
        };

        /// <summary>
        /// The RefSchoolType Pick List
         /// </summary>
        public static List<RefSchoolType> RefSchoolTypePickList = new List<RefSchoolType>
        {
            new RefSchoolType { Id=Guid.Parse("d35919d0-3bfc-4fce-96c1-29d799dd3039"), Code="Regular", Description="Regular School", SortOrder=Convert.ToDecimal("1.00") },
            new RefSchoolType { Id=Guid.Parse("77a0af5b-77bd-4f77-a07e-364dc8deedf2"), Code="Special", Description="Special Education School", SortOrder=Convert.ToDecimal("2.00") },
            new RefSchoolType { Id=Guid.Parse("79936f0c-80e6-4803-b0a1-93a5e4a65de2"), Code="CareerAndTechnical", Description="Career and Technical Education School", SortOrder=Convert.ToDecimal("3.00") },
            new RefSchoolType { Id=Guid.Parse("0c6e4860-6333-4994-bd61-4b6cf9ef25c2"), Code="Alternative", Description="Alternative Education School", SortOrder=Convert.ToDecimal("4.00") },
            new RefSchoolType { Id=Guid.Parse("2f3b30a6-61d6-4af8-ad8c-7932fff223c6"), Code="Reportable", Description="Reportable Program", SortOrder=Convert.ToDecimal("5.00") },
       };
   }
}
