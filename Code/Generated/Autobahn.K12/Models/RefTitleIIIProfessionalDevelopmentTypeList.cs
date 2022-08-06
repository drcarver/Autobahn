//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   RefTitleIIIProfessionalDevelopmentTypeList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.K12.Models
{
     /// <summary>
     /// The list of RefTitleIIIProfessionalDevelopmentType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefTitleIIIProfessionalDevelopmentType"> List
         /// </summary>
        public static List<RefTitleIIIProfessionalDevelopmentType> RefTitleIIIProfessionalDevelopmentTypeList = new List<RefTitleIIIProfessionalDevelopmentType>
        {
            new RefTitleIIIProfessionalDevelopmentType { Id=Guid.Parse("6392e49f-d210-4183-ae19-1a88991ea817"), Code="InstructionalStrategies", Description="Instructional strategies", Definition="The type of Title III professional development utilized is Instructional strategies.", SortOrder=Convert.ToDecimal("1.00") },
            new RefTitleIIIProfessionalDevelopmentType { Id=Guid.Parse("6331957f-384c-4649-8a54-38620f799282"), Code="Assessment", Description="Assessment", Definition="The type of Title III professional development utilized is Assessment.", SortOrder=Convert.ToDecimal("2.00") },
            new RefTitleIIIProfessionalDevelopmentType { Id=Guid.Parse("04ed3902-4367-4625-b6a3-3c2c7912ed24"), Code="ELPContentStandards", Description="ELP and content standards", Definition="The type of Title III professional development utilized is ELP and content standards.", SortOrder=Convert.ToDecimal("3.00") },
            new RefTitleIIIProfessionalDevelopmentType { Id=Guid.Parse("ff4866eb-b5e7-4d9e-b443-b3ecde2a4959"), Code="CurriculumAlignmentELP", Description="Curriculum alignment to ELP standards", Definition="The type of Title III professional development utilized is Curriculum alignment to ELP standards.", SortOrder=Convert.ToDecimal("4.00") },
            new RefTitleIIIProfessionalDevelopmentType { Id=Guid.Parse("d46cfa15-56b8-45e3-b1df-a54ba7779130"), Code="SubjectMatter", Description="Subject matter", Definition="The type of Title III professional development utilized is Subject matter.", SortOrder=Convert.ToDecimal("5.00") },
            new RefTitleIIIProfessionalDevelopmentType { Id=Guid.Parse("b58a81e5-4025-4bec-b8d8-57324d47471d"), Code="Other", Description="Other", Definition="The type of Title III professional development utilized is in a category not yet defined in CEDS.", SortOrder=Convert.ToDecimal("6.00") },
        };

        /// <summary>
        /// The RefTitleIIIProfessionalDevelopmentType Pick List
         /// </summary>
        public static List<RefTitleIIIProfessionalDevelopmentType> RefTitleIIIProfessionalDevelopmentTypePickList = new List<RefTitleIIIProfessionalDevelopmentType>
        {
            new RefTitleIIIProfessionalDevelopmentType { Id=Guid.Parse("6392e49f-d210-4183-ae19-1a88991ea817"), Code="InstructionalStrategies", Description="Instructional strategies", SortOrder=Convert.ToDecimal("1.00") },
            new RefTitleIIIProfessionalDevelopmentType { Id=Guid.Parse("6331957f-384c-4649-8a54-38620f799282"), Code="Assessment", Description="Assessment", SortOrder=Convert.ToDecimal("2.00") },
            new RefTitleIIIProfessionalDevelopmentType { Id=Guid.Parse("04ed3902-4367-4625-b6a3-3c2c7912ed24"), Code="ELPContentStandards", Description="ELP and content standards", SortOrder=Convert.ToDecimal("3.00") },
            new RefTitleIIIProfessionalDevelopmentType { Id=Guid.Parse("ff4866eb-b5e7-4d9e-b443-b3ecde2a4959"), Code="CurriculumAlignmentELP", Description="Curriculum alignment to ELP standards", SortOrder=Convert.ToDecimal("4.00") },
            new RefTitleIIIProfessionalDevelopmentType { Id=Guid.Parse("d46cfa15-56b8-45e3-b1df-a54ba7779130"), Code="SubjectMatter", Description="Subject matter", SortOrder=Convert.ToDecimal("5.00") },
            new RefTitleIIIProfessionalDevelopmentType { Id=Guid.Parse("b58a81e5-4025-4bec-b8d8-57324d47471d"), Code="Other", Description="Other", SortOrder=Convert.ToDecimal("6.00") },
       };
   }
}
