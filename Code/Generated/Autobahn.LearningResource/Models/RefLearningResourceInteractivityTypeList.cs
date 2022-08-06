//**********************************************************
//* DomainName: Autobahn.LearningResource
//* FileName:   RefLearningResourceInteractivityTypeList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.LearningResource.Models
{
     /// <summary>
     /// The list of RefLearningResourceInteractivityType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefLearningResourceInteractivityType"> List
         /// </summary>
        public static List<RefLearningResourceInteractivityType> RefLearningResourceInteractivityTypeList = new List<RefLearningResourceInteractivityType> =
        {
            new RefLearningResourceInteractivityType { Id=Guid.Parse("292fdb26-3c58-42e4-8a5a-018371299e8d"), Code="The predominate mode of learning supported by the learning resource is: Active", Description="Active", Definition="", SortOrder=0 },
            new RefLearningResourceInteractivityType { Id=Guid.Parse("4878c3c5-e46b-46d1-9529-80fb17f2a367"), Code="The predominate mode of learning supported by the learning resource is: Expositive", Description="Expositive", Definition="", SortOrder=0 },
            new RefLearningResourceInteractivityType { Id=Guid.Parse("4fc1e5e6-60b6-4cb2-9729-64e55af73024"), Code="The predominate mode of learning supported by the learning resource is: Mixed", Description="Mixed", Definition="", SortOrder=0 },
        };

        /// <summary>
        /// The RefLearningResourceInteractivityType Pick List
         /// </summary>
        public static List<RefLearningResourceInteractivityType> RefLearningResourceInteractivityTypePickList = new List<RefLearningResourceInteractivityType> =
        {
            new RefLearningResourceInteractivityType { Id=Guid.Parse("292fdb26-3c58-42e4-8a5a-018371299e8d"), Code="The predominate mode of learning supported by the learning resource is: Active", SortOrder=0 },
            new RefLearningResourceInteractivityType { Id=Guid.Parse("4878c3c5-e46b-46d1-9529-80fb17f2a367"), Code="The predominate mode of learning supported by the learning resource is: Expositive", SortOrder=0 },
            new RefLearningResourceInteractivityType { Id=Guid.Parse("4fc1e5e6-60b6-4cb2-9729-64e55af73024"), Code="The predominate mode of learning supported by the learning resource is: Mixed", SortOrder=0 },
       };
   }
}
