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
        public static List<RefLearningResourceAccessModeType> RefLearningResourceAccessModeTypeList = new List<RefLearningResourceAccessModeType> =
        {
            new RefLearningResourceAccessModeType { Id=Guid.Parse("35ee180b-400b-41f1-b477-4f58e270171e"), Code="Auditory is an access mode through which the intellectual content of a described learning resource or adaptation is communicated.", Description="auditory", Definition="", SortOrder=0 },
            new RefLearningResourceAccessModeType { Id=Guid.Parse("4e40e3d9-93b0-4caa-b089-fc87c5af4496"), Code="Color Dependent is an access mode through which the intellectual content of a described learning resource or adaptation is communicated.", Description="colorDependent", Definition="", SortOrder=0 },
            new RefLearningResourceAccessModeType { Id=Guid.Parse("37919dee-639e-4a25-807d-2eec0ae87ae1"), Code="Tactile is an access mode through which the intellectual content of a described learning resource or adaptation is communicated.", Description="tactile", Definition="", SortOrder=0 },
            new RefLearningResourceAccessModeType { Id=Guid.Parse("40bb59f8-02ac-45a8-8cf1-7e2d99dbb8a6"), Code="Text On Image is an access mode through which the intellectual content of a described learning resource or adaptation is communicated.", Description="textOnImage", Definition="", SortOrder=0 },
            new RefLearningResourceAccessModeType { Id=Guid.Parse("fc0e91d8-c1c9-4897-9bfe-14cea9fc3efb"), Code="Textual is an access mode through which the intellectual content of a described learning resource or adaptation is communicated.", Description="textual", Definition="", SortOrder=0 },
            new RefLearningResourceAccessModeType { Id=Guid.Parse("633a1f35-193f-4e7a-8228-569c21c9bb47"), Code="Visual is an access mode through which the intellectual content of a described learning resource or adaptation is communicated.", Description="visual", Definition="", SortOrder=0 },
        };

        /// <summary>
        /// The RefLearningResourceAccessModeType Pick List
         /// </summary>
        public static List<RefLearningResourceAccessModeType> RefLearningResourceAccessModeTypePickList = new List<RefLearningResourceAccessModeType> =
        {
            new RefLearningResourceAccessModeType { Id=Guid.Parse("35ee180b-400b-41f1-b477-4f58e270171e"), Code="Auditory is an access mode through which the intellectual content of a described learning resource or adaptation is communicated.", SortOrder=0 },
            new RefLearningResourceAccessModeType { Id=Guid.Parse("4e40e3d9-93b0-4caa-b089-fc87c5af4496"), Code="Color Dependent is an access mode through which the intellectual content of a described learning resource or adaptation is communicated.", SortOrder=0 },
            new RefLearningResourceAccessModeType { Id=Guid.Parse("37919dee-639e-4a25-807d-2eec0ae87ae1"), Code="Tactile is an access mode through which the intellectual content of a described learning resource or adaptation is communicated.", SortOrder=0 },
            new RefLearningResourceAccessModeType { Id=Guid.Parse("40bb59f8-02ac-45a8-8cf1-7e2d99dbb8a6"), Code="Text On Image is an access mode through which the intellectual content of a described learning resource or adaptation is communicated.", SortOrder=0 },
            new RefLearningResourceAccessModeType { Id=Guid.Parse("fc0e91d8-c1c9-4897-9bfe-14cea9fc3efb"), Code="Textual is an access mode through which the intellectual content of a described learning resource or adaptation is communicated.", SortOrder=0 },
            new RefLearningResourceAccessModeType { Id=Guid.Parse("633a1f35-193f-4e7a-8228-569c21c9bb47"), Code="Visual is an access mode through which the intellectual content of a described learning resource or adaptation is communicated.", SortOrder=0 },
       };
   }
}
