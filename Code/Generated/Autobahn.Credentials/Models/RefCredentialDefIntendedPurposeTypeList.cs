//**********************************************************
//* DomainName: Autobahn.Credentials
//* FileName:   RefCredentialDefIntendedPurposeTypeList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Credentials.Models
{
     /// <summary>
     /// The list of RefCredentialDefIntendedPurposeType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefCredentialDefIntendedPurposeTypeModel"> List
         /// </summary>
        public static List<RefCredentialDefIntendedPurposeTypeModel> RefCredentialDefIntendedPurposeTypeList = new List<RefCredentialDefIntendedPurposeTypeModel>
        {
            new RefCredentialDefIntendedPurposeType { Id=Guid.Parse("9b37dd22-e698-44bd-bcf0-32875641f1f5"), Code="GeneralEducation", Description="General Education", Definition="The intended purpose of the credential by the holder is general education.", SortOrder=Convert.ToDecimal("") },
            new RefCredentialDefIntendedPurposeType { Id=Guid.Parse("f092bfd8-aba0-444c-b819-c8ac109c6cc5"), Code="JobOrCareerPreparation", Description="Job/Career Preparation", Definition="The intended purpose of the credential by the holder is job or career preparation.", SortOrder=Convert.ToDecimal("") },
            new RefCredentialDefIntendedPurposeType { Id=Guid.Parse("60ae8712-7844-41c9-b131-15843d3c3e92"), Code="MidCareer", Description="Mid-Career Level", Definition="The intended purpose of the credential by the holder is for mid-career, experienced worker preparation and advancement.", SortOrder=Convert.ToDecimal("") },
            new RefCredentialDefIntendedPurposeType { Id=Guid.Parse("826a3061-57f1-4475-b4c7-336ca4f63971"), Code="PriorExperience", Description="Prior Learning Experience", Definition="The intended purpose of the credential by the holder is for determining prior learning experience of the holder, including but not limited to college credit.", SortOrder=Convert.ToDecimal("") },
        };

        /// <summary>
        /// The Reference RefCredentialDefIntendedPurposeType Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefCredentialDefIntendedPurposeTypeViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefCredentialDefIntendedPurposeType { Id=Guid.Parse("9b37dd22-e698-44bd-bcf0-32875641f1f5"), Description="General Education", SortOrder=Convert.ToDecimal("") },
            new RefCredentialDefIntendedPurposeType { Id=Guid.Parse("f092bfd8-aba0-444c-b819-c8ac109c6cc5"), Description="Job/Career Preparation", SortOrder=Convert.ToDecimal("") },
            new RefCredentialDefIntendedPurposeType { Id=Guid.Parse("60ae8712-7844-41c9-b131-15843d3c3e92"), Description="Mid-Career Level", SortOrder=Convert.ToDecimal("") },
            new RefCredentialDefIntendedPurposeType { Id=Guid.Parse("826a3061-57f1-4475-b4c7-336ca4f63971"), Description="Prior Learning Experience", SortOrder=Convert.ToDecimal("") },
       };
   }
}
