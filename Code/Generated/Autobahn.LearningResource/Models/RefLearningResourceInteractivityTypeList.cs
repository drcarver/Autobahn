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
        public static List<RefLearningResourceInteractivityType> RefLearningResourceInteractivityTypeList = new List<RefLearningResourceInteractivityType>
        {
            new RefLearningResourceInteractivityType { Id=Guid.Parse("efe9a64d-17db-4de5-bb4d-7e5fbc10f39c"), Code="Active", Description="Active", Definition="The predominate mode of learning supported by the learning resource is: Active", SortOrder=Convert.ToDecimal("1.00") },
            new RefLearningResourceInteractivityType { Id=Guid.Parse("d739f93f-921c-42d9-ab56-5453d9b95ae3"), Code="Expositive", Description="Expositive", Definition="The predominate mode of learning supported by the learning resource is: Expositive", SortOrder=Convert.ToDecimal("2.00") },
            new RefLearningResourceInteractivityType { Id=Guid.Parse("96ff7b74-a267-46a7-b877-5da60e33c5e6"), Code="Mixed", Description="Mixed", Definition="The predominate mode of learning supported by the learning resource is: Mixed", SortOrder=Convert.ToDecimal("3.00") },
        };

        /// <summary>
        /// The RefLearningResourceInteractivityType Pick List
         /// </summary>
        public static List<RefLearningResourceInteractivityType> RefLearningResourceInteractivityTypePickList = new List<RefLearningResourceInteractivityType>
        {
            new RefLearningResourceInteractivityType { Id=Guid.Parse("efe9a64d-17db-4de5-bb4d-7e5fbc10f39c"), Code="Active", Description="Active", SortOrder=Convert.ToDecimal("1.00") },
            new RefLearningResourceInteractivityType { Id=Guid.Parse("d739f93f-921c-42d9-ab56-5453d9b95ae3"), Code="Expositive", Description="Expositive", SortOrder=Convert.ToDecimal("2.00") },
            new RefLearningResourceInteractivityType { Id=Guid.Parse("96ff7b74-a267-46a7-b877-5da60e33c5e6"), Code="Mixed", Description="Mixed", SortOrder=Convert.ToDecimal("3.00") },
       };
   }
}
