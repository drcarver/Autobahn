//**********************************************************
//* DomainName: Autobahn.LearningResource
//* FileName:   RefLearningResourceAccessHazardTypeList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.LearningResource.Models
{
     /// <summary>
     /// The list of RefLearningResourceAccessHazardType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefLearningResourceAccessHazardType"> List
         /// </summary>
        public static List<RefLearningResourceAccessHazardType> RefLearningResourceAccessHazardTypeList = new List<RefLearningResourceAccessHazardType> =
        {
            new RefLearningResourceAccessHazardType { Id=Guid.Parse("df703a3a-5af7-4819-b2f1-41e04fdda218"), Code="Flashing is a characteristic of the described learning resource that is physiologically dangerous to some users.", Description="Flashing", Definition="", SortOrder=0 },
            new RefLearningResourceAccessHazardType { Id=Guid.Parse("b81bc948-491e-4aa0-81a9-a1d21654d988"), Code="Motion simulation is a characteristic of the described learning resource that is physiologically dangerous to some users.", Description="MotionSimulation", Definition="", SortOrder=0 },
            new RefLearningResourceAccessHazardType { Id=Guid.Parse("d60a8a82-daa1-4cd8-8d4f-444e3d60105e"), Code="Sound is a characteristic of the described learning resource that is physiologically dangerous to some users.", Description="Sound", Definition="", SortOrder=0 },
        };

        /// <summary>
        /// The RefLearningResourceAccessHazardType Pick List
         /// </summary>
        public static List<RefLearningResourceAccessHazardType> RefLearningResourceAccessHazardTypePickList = new List<RefLearningResourceAccessHazardType> =
        {
            new RefLearningResourceAccessHazardType { Id=Guid.Parse("df703a3a-5af7-4819-b2f1-41e04fdda218"), Code="Flashing is a characteristic of the described learning resource that is physiologically dangerous to some users.", SortOrder=0 },
            new RefLearningResourceAccessHazardType { Id=Guid.Parse("b81bc948-491e-4aa0-81a9-a1d21654d988"), Code="Motion simulation is a characteristic of the described learning resource that is physiologically dangerous to some users.", SortOrder=0 },
            new RefLearningResourceAccessHazardType { Id=Guid.Parse("d60a8a82-daa1-4cd8-8d4f-444e3d60105e"), Code="Sound is a characteristic of the described learning resource that is physiologically dangerous to some users.", SortOrder=0 },
       };
   }
}
