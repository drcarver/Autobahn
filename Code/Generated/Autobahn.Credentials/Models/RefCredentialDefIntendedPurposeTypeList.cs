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
        public static List<RefCredentialDefIntendedPurposeType> RefCredentialDefIntendedPurposeTypeList = new List<RefCredentialDefIntendedPurposeType> =
        {
            new RefCredentialDefIntendedPurposeType { Id=Guid.Parse("8bec27e0-268a-4d9d-985c-bd42c21dd333"), Code="The intended purpose of the credential by the holder is general education.", Description="GeneralEducation", Definition="", SortOrder=0 },
            new RefCredentialDefIntendedPurposeType { Id=Guid.Parse("629cb623-97fd-4746-8d83-beb55b455ce4"), Code="The intended purpose of the credential by the holder is job or career preparation.", Description="JobOrCareerPreparation", Definition="", SortOrder=0 },
            new RefCredentialDefIntendedPurposeType { Id=Guid.Parse("958fb0a5-0199-4645-ac0e-72aa18081d03"), Code="The intended purpose of the credential by the holder is for mid-career, experienced worker preparation and advancement.", Description="MidCareer", Definition="", SortOrder=0 },
            new RefCredentialDefIntendedPurposeType { Id=Guid.Parse("9f12e34a-457b-47dc-873a-78aca9e6f77d"), Code="The intended purpose of the credential by the holder is for determining prior learning experience of the holder, including but not limited to college credit.", Description="PriorExperience", Definition="", SortOrder=0 },
        };

        /// <summary>
        /// The RefCredentialDefIntendedPurposeType Pick List
         /// </summary>
        public static List<RefCredentialDefIntendedPurposeType> RefCredentialDefIntendedPurposeTypePickList = new List<RefCredentialDefIntendedPurposeType> =
        {
            new RefCredentialDefIntendedPurposeType { Id=Guid.Parse("8bec27e0-268a-4d9d-985c-bd42c21dd333"), Code="The intended purpose of the credential by the holder is general education.", SortOrder=0 },
            new RefCredentialDefIntendedPurposeType { Id=Guid.Parse("629cb623-97fd-4746-8d83-beb55b455ce4"), Code="The intended purpose of the credential by the holder is job or career preparation.", SortOrder=0 },
            new RefCredentialDefIntendedPurposeType { Id=Guid.Parse("958fb0a5-0199-4645-ac0e-72aa18081d03"), Code="The intended purpose of the credential by the holder is for mid-career, experienced worker preparation and advancement.", SortOrder=0 },
            new RefCredentialDefIntendedPurposeType { Id=Guid.Parse("9f12e34a-457b-47dc-873a-78aca9e6f77d"), Code="The intended purpose of the credential by the holder is for determining prior learning experience of the holder, including but not limited to college credit.", SortOrder=0 },
       };
   }
}
