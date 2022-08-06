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
        /// The complete <see cref="RefLearningResourceAccessModeType"> List
         /// </summary>
        public static List<RefLearningResourceAccessModeType> RefLearningResourceAccessModeTypeList = new List<RefLearningResourceAccessModeType>
        {
            new RefLearningResourceAccessModeType { Id=Guid.Parse("e6c8c91f-d129-4e5c-bdf2-9f8bf3a37e0a"), Code="auditory", Description="Auditory", Definition="Auditory is an access mode through which the intellectual content of a described learning resource or adaptation is communicated.", SortOrder=Convert.ToDecimal("2.00") },
            new RefLearningResourceAccessModeType { Id=Guid.Parse("287447b8-e157-4e01-85c5-4641cf82a1e7"), Code="colorDependent", Description="Color Dependent", Definition="Color Dependent is an access mode through which the intellectual content of a described learning resource or adaptation is communicated.", SortOrder=Convert.ToDecimal("4.00") },
            new RefLearningResourceAccessModeType { Id=Guid.Parse("4a28e9b9-36ea-4adb-901a-2ce63694cca3"), Code="tactile", Description="Tactile", Definition="Tactile is an access mode through which the intellectual content of a described learning resource or adaptation is communicated.", SortOrder=Convert.ToDecimal("6.00") },
            new RefLearningResourceAccessModeType { Id=Guid.Parse("492661f9-d504-4104-a27b-d05e97463d43"), Code="textOnImage", Description="Text On Image", Definition="Text On Image is an access mode through which the intellectual content of a described learning resource or adaptation is communicated.", SortOrder=Convert.ToDecimal("8.00") },
            new RefLearningResourceAccessModeType { Id=Guid.Parse("419d3faa-1ff5-436c-9b72-16c5e6805c5e"), Code="textual", Description="Textual", Definition="Textual is an access mode through which the intellectual content of a described learning resource or adaptation is communicated.", SortOrder=Convert.ToDecimal("10.00") },
            new RefLearningResourceAccessModeType { Id=Guid.Parse("59cc16c5-9017-4565-920c-4c4cb8ccc00e"), Code="visual", Description="Visual", Definition="Visual is an access mode through which the intellectual content of a described learning resource or adaptation is communicated.", SortOrder=Convert.ToDecimal("12.00") },
        };

        /// <summary>
        /// The RefLearningResourceAccessModeType Pick List
         /// </summary>
        public static List<RefLearningResourceAccessModeType> RefLearningResourceAccessModeTypePickList = new List<RefLearningResourceAccessModeType>
        {
            new RefLearningResourceAccessModeType { Id=Guid.Parse("e6c8c91f-d129-4e5c-bdf2-9f8bf3a37e0a"), Code="auditory", Description="Auditory", SortOrder=Convert.ToDecimal("2.00") },
            new RefLearningResourceAccessModeType { Id=Guid.Parse("287447b8-e157-4e01-85c5-4641cf82a1e7"), Code="colorDependent", Description="Color Dependent", SortOrder=Convert.ToDecimal("4.00") },
            new RefLearningResourceAccessModeType { Id=Guid.Parse("4a28e9b9-36ea-4adb-901a-2ce63694cca3"), Code="tactile", Description="Tactile", SortOrder=Convert.ToDecimal("6.00") },
            new RefLearningResourceAccessModeType { Id=Guid.Parse("492661f9-d504-4104-a27b-d05e97463d43"), Code="textOnImage", Description="Text On Image", SortOrder=Convert.ToDecimal("8.00") },
            new RefLearningResourceAccessModeType { Id=Guid.Parse("419d3faa-1ff5-436c-9b72-16c5e6805c5e"), Code="textual", Description="Textual", SortOrder=Convert.ToDecimal("10.00") },
            new RefLearningResourceAccessModeType { Id=Guid.Parse("59cc16c5-9017-4565-920c-4c4cb8ccc00e"), Code="visual", Description="Visual", SortOrder=Convert.ToDecimal("12.00") },
       };
   }
}
