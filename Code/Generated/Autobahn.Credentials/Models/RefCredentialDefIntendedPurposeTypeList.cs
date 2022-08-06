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
        /// The complete <see cref="RefCredentialDefIntendedPurposeType"> List
         /// </summary>
        public static List<RefCredentialDefIntendedPurposeType> RefCredentialDefIntendedPurposeTypeList = new List<RefCredentialDefIntendedPurposeType>
        {
            new RefCredentialDefIntendedPurposeType { Id=Guid.Parse("11736fc1-3ef1-40ee-a6ca-0f76e88c76a8"), Code="GeneralEducation", Description="General Education", Definition="The intended purpose of the credential by the holder is general education.", SortOrder=Convert.ToDecimal("") },
            new RefCredentialDefIntendedPurposeType { Id=Guid.Parse("cb79137d-cb0b-4ff9-9c48-a4c74cbba2a9"), Code="JobOrCareerPreparation", Description="Job/Career Preparation", Definition="The intended purpose of the credential by the holder is job or career preparation.", SortOrder=Convert.ToDecimal("") },
            new RefCredentialDefIntendedPurposeType { Id=Guid.Parse("6bb1f603-5648-4afd-85ce-9ef1aefaa169"), Code="MidCareer", Description="Mid-Career Level", Definition="The intended purpose of the credential by the holder is for mid-career, experienced worker preparation and advancement.", SortOrder=Convert.ToDecimal("") },
            new RefCredentialDefIntendedPurposeType { Id=Guid.Parse("40b2d40b-8a96-4550-940b-8e5d5fc934b0"), Code="PriorExperience", Description="Prior Learning Experience", Definition="The intended purpose of the credential by the holder is for determining prior learning experience of the holder, including but not limited to college credit.", SortOrder=Convert.ToDecimal("") },
        };

        /// <summary>
        /// The RefCredentialDefIntendedPurposeType Pick List
         /// </summary>
        public static List<RefCredentialDefIntendedPurposeType> RefCredentialDefIntendedPurposeTypePickList = new List<RefCredentialDefIntendedPurposeType>
        {
            new RefCredentialDefIntendedPurposeType { Id=Guid.Parse("11736fc1-3ef1-40ee-a6ca-0f76e88c76a8"), Code="GeneralEducation", Description="General Education", SortOrder=Convert.ToDecimal("") },
            new RefCredentialDefIntendedPurposeType { Id=Guid.Parse("cb79137d-cb0b-4ff9-9c48-a4c74cbba2a9"), Code="JobOrCareerPreparation", Description="Job/Career Preparation", SortOrder=Convert.ToDecimal("") },
            new RefCredentialDefIntendedPurposeType { Id=Guid.Parse("6bb1f603-5648-4afd-85ce-9ef1aefaa169"), Code="MidCareer", Description="Mid-Career Level", SortOrder=Convert.ToDecimal("") },
            new RefCredentialDefIntendedPurposeType { Id=Guid.Parse("40b2d40b-8a96-4550-940b-8e5d5fc934b0"), Code="PriorExperience", Description="Prior Learning Experience", SortOrder=Convert.ToDecimal("") },
       };
   }
}
