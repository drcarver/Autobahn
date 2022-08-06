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
        public static List<RefLearningResourceAccessHazardType> RefLearningResourceAccessHazardTypeList = new List<RefLearningResourceAccessHazardType>
        {
            new RefLearningResourceAccessHazardType { Id=Guid.Parse("fdb31b03-b9fd-4e55-85bd-65c2df9beb6a"), Code="Flashing", Description="Flashing", Definition="Flashing is a characteristic of the described learning resource that is physiologically dangerous to some users.", SortOrder=Convert.ToDecimal("4.00") },
            new RefLearningResourceAccessHazardType { Id=Guid.Parse("1d1d5e71-242e-4ee3-83f4-51253382936d"), Code="MotionSimulation", Description="Motion simulation", Definition="Motion simulation is a characteristic of the described learning resource that is physiologically dangerous to some users.", SortOrder=Convert.ToDecimal("6.00") },
            new RefLearningResourceAccessHazardType { Id=Guid.Parse("582701e0-a63b-469d-850f-b7eece59d726"), Code="Sound", Description="Sound", Definition="Sound is a characteristic of the described learning resource that is physiologically dangerous to some users.", SortOrder=Convert.ToDecimal("8.00") },
        };

        /// <summary>
        /// The RefLearningResourceAccessHazardType Pick List
         /// </summary>
        public static List<RefLearningResourceAccessHazardType> RefLearningResourceAccessHazardTypePickList = new List<RefLearningResourceAccessHazardType>
        {
            new RefLearningResourceAccessHazardType { Id=Guid.Parse("fdb31b03-b9fd-4e55-85bd-65c2df9beb6a"), Code="Flashing", Description="Flashing", SortOrder=Convert.ToDecimal("4.00") },
            new RefLearningResourceAccessHazardType { Id=Guid.Parse("1d1d5e71-242e-4ee3-83f4-51253382936d"), Code="MotionSimulation", Description="Motion simulation", SortOrder=Convert.ToDecimal("6.00") },
            new RefLearningResourceAccessHazardType { Id=Guid.Parse("582701e0-a63b-469d-850f-b7eece59d726"), Code="Sound", Description="Sound", SortOrder=Convert.ToDecimal("8.00") },
       };
   }
}
