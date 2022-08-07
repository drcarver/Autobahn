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
        /// The complete <see cref="RefTitleIIIProfessionalDevelopmentTypeModel"> List
         /// </summary>
        public static List<RefTitleIIIProfessionalDevelopmentTypeModel> RefTitleIIIProfessionalDevelopmentTypeList = new List<RefTitleIIIProfessionalDevelopmentTypeModel>
        {
            new RefTitleIIIProfessionalDevelopmentType { Id=Guid.Parse("d219633b-4efe-40f4-9e53-05055498ee35"), Code="InstructionalStrategies", Description="Instructional strategies", Definition="The type of Title III professional development utilized is Instructional strategies.", SortOrder=Convert.ToDecimal("1.00") },
            new RefTitleIIIProfessionalDevelopmentType { Id=Guid.Parse("880b6cf9-16cf-4fb6-9392-357fd0cf2e91"), Code="Assessment", Description="Assessment", Definition="The type of Title III professional development utilized is Assessment.", SortOrder=Convert.ToDecimal("2.00") },
            new RefTitleIIIProfessionalDevelopmentType { Id=Guid.Parse("634895f2-53cf-4e3e-98aa-e832e06f03c0"), Code="ELPContentStandards", Description="ELP and content standards", Definition="The type of Title III professional development utilized is ELP and content standards.", SortOrder=Convert.ToDecimal("3.00") },
            new RefTitleIIIProfessionalDevelopmentType { Id=Guid.Parse("6cad82f4-7f7e-4a15-8d3a-14a5545063ef"), Code="CurriculumAlignmentELP", Description="Curriculum alignment to ELP standards", Definition="The type of Title III professional development utilized is Curriculum alignment to ELP standards.", SortOrder=Convert.ToDecimal("4.00") },
            new RefTitleIIIProfessionalDevelopmentType { Id=Guid.Parse("8a2a5f6c-4c7f-4b4c-b268-3db402f8bef6"), Code="SubjectMatter", Description="Subject matter", Definition="The type of Title III professional development utilized is Subject matter.", SortOrder=Convert.ToDecimal("5.00") },
            new RefTitleIIIProfessionalDevelopmentType { Id=Guid.Parse("9a46542b-d7f7-4931-90fe-eda92ef186a0"), Code="Other", Description="Other", Definition="The type of Title III professional development utilized is in a category not yet defined in CEDS.", SortOrder=Convert.ToDecimal("6.00") },
        };

        /// <summary>
        /// The Reference RefTitleIIIProfessionalDevelopmentType Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefTitleIIIProfessionalDevelopmentTypeViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefTitleIIIProfessionalDevelopmentType { Id=Guid.Parse("d219633b-4efe-40f4-9e53-05055498ee35"), Description="Instructional strategies", SortOrder=Convert.ToDecimal("1.00") },
            new RefTitleIIIProfessionalDevelopmentType { Id=Guid.Parse("880b6cf9-16cf-4fb6-9392-357fd0cf2e91"), Description="Assessment", SortOrder=Convert.ToDecimal("2.00") },
            new RefTitleIIIProfessionalDevelopmentType { Id=Guid.Parse("634895f2-53cf-4e3e-98aa-e832e06f03c0"), Description="ELP and content standards", SortOrder=Convert.ToDecimal("3.00") },
            new RefTitleIIIProfessionalDevelopmentType { Id=Guid.Parse("6cad82f4-7f7e-4a15-8d3a-14a5545063ef"), Description="Curriculum alignment to ELP standards", SortOrder=Convert.ToDecimal("4.00") },
            new RefTitleIIIProfessionalDevelopmentType { Id=Guid.Parse("8a2a5f6c-4c7f-4b4c-b268-3db402f8bef6"), Description="Subject matter", SortOrder=Convert.ToDecimal("5.00") },
            new RefTitleIIIProfessionalDevelopmentType { Id=Guid.Parse("9a46542b-d7f7-4931-90fe-eda92ef186a0"), Description="Other", SortOrder=Convert.ToDecimal("6.00") },
       };
   }
}
