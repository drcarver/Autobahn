//**********************************************************
//* DomainName: Autobahn.EarlyLearning
//* FileName:   RefELLevelOfSpecializationList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.EarlyLearning.Models
{
     /// <summary>
     /// The list of RefELLevelOfSpecialization Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefELLevelOfSpecializationModel"> List
         /// </summary>
        public static List<RefELLevelOfSpecializationModel> RefELLevelOfSpecializationList = new List<RefELLevelOfSpecializationModel>
        {
            new RefELLevelOfSpecialization { Id=Guid.Parse("db25a63b-4870-4df3-8d42-3ada358c1928"), Code="Major", Description="Major", Definition="The person majored in early learning.", SortOrder=Convert.ToDecimal("1.00") },
            new RefELLevelOfSpecialization { Id=Guid.Parse("b3809157-1a8e-4fa6-9334-95ab32092967"), Code="Minor", Description="Minor", Definition="The person minored in early learning.", SortOrder=Convert.ToDecimal("2.00") },
            new RefELLevelOfSpecialization { Id=Guid.Parse("45211d0e-71cd-4397-8f97-6e8e37652a0e"), Code="AreaOfEmphasis", Description="Area of emphasis or concentration", Definition="The person had early learning as an area of emphasis or concentration.", SortOrder=Convert.ToDecimal("3.00") },
            new RefELLevelOfSpecialization { Id=Guid.Parse("3d45f8d5-09b7-4474-a335-0b43bbe49935"), Code="PostDegreeStudy", Description="Post-degree study", Definition="Early learning was a focus of post-degree study by the person.", SortOrder=Convert.ToDecimal("4.00") },
            new RefELLevelOfSpecialization { Id=Guid.Parse("96c3f48f-8c56-4483-a06a-4f1175a5e404"), Code="AreaOfInterest", Description="Area of Interest", Definition="Early learning was as area of Interest for the person.", SortOrder=Convert.ToDecimal("5.00") },
        };

        /// <summary>
        /// The Reference RefELLevelOfSpecialization Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefELLevelOfSpecializationViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefELLevelOfSpecialization { Id=Guid.Parse("db25a63b-4870-4df3-8d42-3ada358c1928"), Description="Major", SortOrder=Convert.ToDecimal("1.00") },
            new RefELLevelOfSpecialization { Id=Guid.Parse("b3809157-1a8e-4fa6-9334-95ab32092967"), Description="Minor", SortOrder=Convert.ToDecimal("2.00") },
            new RefELLevelOfSpecialization { Id=Guid.Parse("45211d0e-71cd-4397-8f97-6e8e37652a0e"), Description="Area of emphasis or concentration", SortOrder=Convert.ToDecimal("3.00") },
            new RefELLevelOfSpecialization { Id=Guid.Parse("3d45f8d5-09b7-4474-a335-0b43bbe49935"), Description="Post-degree study", SortOrder=Convert.ToDecimal("4.00") },
            new RefELLevelOfSpecialization { Id=Guid.Parse("96c3f48f-8c56-4483-a06a-4f1175a5e404"), Description="Area of Interest", SortOrder=Convert.ToDecimal("5.00") },
       };
   }
}
