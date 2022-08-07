//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefSupervisedClinicalExperienceList.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefSupervisedClinicalExperience Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefSupervisedClinicalExperienceModel"> List
         /// </summary>
        public static List<RefSupervisedClinicalExperienceModel> RefSupervisedClinicalExperienceList = new List<RefSupervisedClinicalExperienceModel>
        {
            new RefSupervisedClinicalExperience { Id=Guid.Parse("28e807f6-6372-4352-856d-35630e2788d7"), Code="Yes", Description="Yes", Definition="", SortOrder=Convert.ToDecimal("1.00") },
            new RefSupervisedClinicalExperience { Id=Guid.Parse("0965008a-c9e4-49e5-9e60-ecb72daa0a7f"), Code="No", Description="No", Definition="", SortOrder=Convert.ToDecimal("2.00") },
            new RefSupervisedClinicalExperience { Id=Guid.Parse("037affea-cb3c-4ccc-bde1-e366b2b45d73"), Code="NA", Description="Not applicable", Definition="", SortOrder=Convert.ToDecimal("3.00") },
        };

        /// <summary>
        /// The Reference RefSupervisedClinicalExperience Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefSupervisedClinicalExperienceViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefSupervisedClinicalExperience { Id=Guid.Parse("28e807f6-6372-4352-856d-35630e2788d7"), Description="Yes", SortOrder=Convert.ToDecimal("1.00") },
            new RefSupervisedClinicalExperience { Id=Guid.Parse("0965008a-c9e4-49e5-9e60-ecb72daa0a7f"), Description="No", SortOrder=Convert.ToDecimal("2.00") },
            new RefSupervisedClinicalExperience { Id=Guid.Parse("037affea-cb3c-4ccc-bde1-e366b2b45d73"), Description="Not applicable", SortOrder=Convert.ToDecimal("3.00") },
       };
   }
}
