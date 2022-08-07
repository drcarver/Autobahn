//**********************************************************
//* DomainName: Autobahn.LearningResource
//* FileName:   RefLearningResourceAccessModeTypeList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.LearningResource.Models
{
     /// <summary>
     /// The list of RefLearningResourceAccessModeType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefLearningResourceAccessModeTypeModel"> List
         /// </summary>
        public static List<RefLearningResourceAccessModeTypeModel> RefLearningResourceAccessModeTypeList = new List<RefLearningResourceAccessModeTypeModel>
        {
            new RefLearningResourceAccessModeType { Id=Guid.Parse("ec7bf332-2f0c-463c-83a6-91555d6bc425"), Code="auditory", Description="Auditory", Definition="Auditory is an access mode through which the intellectual content of a described learning resource or adaptation is communicated.", SortOrder=Convert.ToDecimal("2.00") },
            new RefLearningResourceAccessModeType { Id=Guid.Parse("eb6288cf-cfaf-4be8-8f46-8908af1b74bc"), Code="colorDependent", Description="Color Dependent", Definition="Color Dependent is an access mode through which the intellectual content of a described learning resource or adaptation is communicated.", SortOrder=Convert.ToDecimal("4.00") },
            new RefLearningResourceAccessModeType { Id=Guid.Parse("92e56cfc-1376-488f-9d7f-b816468058e5"), Code="tactile", Description="Tactile", Definition="Tactile is an access mode through which the intellectual content of a described learning resource or adaptation is communicated.", SortOrder=Convert.ToDecimal("6.00") },
            new RefLearningResourceAccessModeType { Id=Guid.Parse("fe68edc6-02d5-4fd9-8ba0-8a4466bacd58"), Code="textOnImage", Description="Text On Image", Definition="Text On Image is an access mode through which the intellectual content of a described learning resource or adaptation is communicated.", SortOrder=Convert.ToDecimal("8.00") },
            new RefLearningResourceAccessModeType { Id=Guid.Parse("1e9b3527-8db2-4889-b370-0dc64812ff49"), Code="textual", Description="Textual", Definition="Textual is an access mode through which the intellectual content of a described learning resource or adaptation is communicated.", SortOrder=Convert.ToDecimal("10.00") },
            new RefLearningResourceAccessModeType { Id=Guid.Parse("e337911a-3569-407a-9829-de7696206277"), Code="visual", Description="Visual", Definition="Visual is an access mode through which the intellectual content of a described learning resource or adaptation is communicated.", SortOrder=Convert.ToDecimal("12.00") },
        };

        /// <summary>
        /// The Reference RefLearningResourceAccessModeType Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefLearningResourceAccessModeTypeViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefLearningResourceAccessModeType { Id=Guid.Parse("ec7bf332-2f0c-463c-83a6-91555d6bc425"), Description="Auditory", SortOrder=Convert.ToDecimal("2.00") },
            new RefLearningResourceAccessModeType { Id=Guid.Parse("eb6288cf-cfaf-4be8-8f46-8908af1b74bc"), Description="Color Dependent", SortOrder=Convert.ToDecimal("4.00") },
            new RefLearningResourceAccessModeType { Id=Guid.Parse("92e56cfc-1376-488f-9d7f-b816468058e5"), Description="Tactile", SortOrder=Convert.ToDecimal("6.00") },
            new RefLearningResourceAccessModeType { Id=Guid.Parse("fe68edc6-02d5-4fd9-8ba0-8a4466bacd58"), Description="Text On Image", SortOrder=Convert.ToDecimal("8.00") },
            new RefLearningResourceAccessModeType { Id=Guid.Parse("1e9b3527-8db2-4889-b370-0dc64812ff49"), Description="Textual", SortOrder=Convert.ToDecimal("10.00") },
            new RefLearningResourceAccessModeType { Id=Guid.Parse("e337911a-3569-407a-9829-de7696206277"), Description="Visual", SortOrder=Convert.ToDecimal("12.00") },
       };
   }
}
