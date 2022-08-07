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
        /// The complete <see cref="RefSchoolTypeModel"> List
         /// </summary>
        public static List<RefSchoolTypeModel> RefSchoolTypeList = new List<RefSchoolTypeModel>
        {
            new RefSchoolType { Id=Guid.Parse("6b12c775-cb62-4112-9430-ee6d096d3bda"), Code="Regular", Description="Regular School", Definition="A school that does not focus primarily on career and technical, special, or alternative education, although it may provide these programs in addition to a regular curriculum.", SortOrder=Convert.ToDecimal("1.00") },
            new RefSchoolType { Id=Guid.Parse("2db73755-888a-407e-a96d-1d774f0fe15f"), Code="Special", Description="Special Education School", Definition="A  school that focuses primarily on serving the educational needs of students with disabilities (IDEA) and which adapts curriculum, materials, or instruction for these students.", SortOrder=Convert.ToDecimal("2.00") },
            new RefSchoolType { Id=Guid.Parse("dff2c371-dc35-4c03-8a06-c8a03d160fcc"), Code="CareerAndTechnical", Description="Career and Technical Education School", Definition="A school that focuses primarily on providing secondary students with an occupationally relevant or career-related curriculum, including formal preparation for technical or professional occupations.", SortOrder=Convert.ToDecimal("3.00") },
            new RefSchoolType { Id=Guid.Parse("816ecd72-891d-4dc4-9a29-48c75c26d23e"), Code="Alternative", Description="Alternative Education School", Definition="A school that addresses the needs of students that typically cannot be met in a regular school program and is designed to meet the needs of students with academic difficulties, students with discipline problems, or both students with academic difficulties and discipline problems.", SortOrder=Convert.ToDecimal("4.00") },
            new RefSchoolType { Id=Guid.Parse("697350c0-82e3-4420-9884-3d0e62dfaff8"), Code="Reportable", Description="Reportable Program", Definition="The permitted value \u0022reportable program\u0022 is available for SEAs that have data to report to EDFacts at the school level that the SEA has determined does not meet the definition of a public elementary/secondary school.", SortOrder=Convert.ToDecimal("5.00") },
        };

        /// <summary>
        /// The Reference RefSchoolType Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefSchoolTypeViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefSchoolType { Id=Guid.Parse("6b12c775-cb62-4112-9430-ee6d096d3bda"), Description="Regular School", SortOrder=Convert.ToDecimal("1.00") },
            new RefSchoolType { Id=Guid.Parse("2db73755-888a-407e-a96d-1d774f0fe15f"), Description="Special Education School", SortOrder=Convert.ToDecimal("2.00") },
            new RefSchoolType { Id=Guid.Parse("dff2c371-dc35-4c03-8a06-c8a03d160fcc"), Description="Career and Technical Education School", SortOrder=Convert.ToDecimal("3.00") },
            new RefSchoolType { Id=Guid.Parse("816ecd72-891d-4dc4-9a29-48c75c26d23e"), Description="Alternative Education School", SortOrder=Convert.ToDecimal("4.00") },
            new RefSchoolType { Id=Guid.Parse("697350c0-82e3-4420-9884-3d0e62dfaff8"), Description="Reportable Program", SortOrder=Convert.ToDecimal("5.00") },
       };
   }
}
