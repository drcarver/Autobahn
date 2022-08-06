//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   RefAssessmentNeedHazardTypeList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Assessment.Models
{
     /// <summary>
     /// The list of RefAssessmentNeedHazardType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefAssessmentNeedHazardType"> List
         /// </summary>
        public static List<RefAssessmentNeedHazardType> RefAssessmentNeedHazardTypeList = new List<RefAssessmentNeedHazardType>
        {
            new RefAssessmentNeedHazardType { Id=Guid.Parse("feeeae60-b84b-4fd4-ac18-8e06b05ea86e"), Code="Flashing", Description="Flashing", Definition="Flashing is specified as part of an Assessment Personal Needs Profile as a characteristic of a digital resource that may be dangerous to a user.", SortOrder=Convert.ToDecimal("1.00") },
            new RefAssessmentNeedHazardType { Id=Guid.Parse("60a033bb-a680-4bf1-affd-fb6eb7f5ab0e"), Code="Sound", Description="Sound", Definition="Sound is specified as part of an Assessment Personal Needs Profile as a characteristic of a digital resource that may be dangerous to a user.", SortOrder=Convert.ToDecimal("2.00") },
            new RefAssessmentNeedHazardType { Id=Guid.Parse("76c358e7-b256-47cf-bcaa-066f15c8dc58"), Code="Olfactory", Description="Olfactory", Definition="Olfactory is specified as part of an Assessment Personal Needs Profile as a characteristic of a digital resource that may be dangerous to a user.", SortOrder=Convert.ToDecimal("3.00") },
            new RefAssessmentNeedHazardType { Id=Guid.Parse("7baa6f42-aaf0-4555-8a06-c31c26007838"), Code="MotionSimulation", Description="Motion simulation", Definition="Motion simulation is specified as part of an Assessment Personal Needs Profile as a characteristic of a digital resource that may be dangerous to a user.", SortOrder=Convert.ToDecimal("4.00") },
        };

        /// <summary>
        /// The RefAssessmentNeedHazardType Pick List
         /// </summary>
        public static List<RefAssessmentNeedHazardType> RefAssessmentNeedHazardTypePickList = new List<RefAssessmentNeedHazardType>
        {
            new RefAssessmentNeedHazardType { Id=Guid.Parse("feeeae60-b84b-4fd4-ac18-8e06b05ea86e"), Code="Flashing", Description="Flashing", SortOrder=Convert.ToDecimal("1.00") },
            new RefAssessmentNeedHazardType { Id=Guid.Parse("60a033bb-a680-4bf1-affd-fb6eb7f5ab0e"), Code="Sound", Description="Sound", SortOrder=Convert.ToDecimal("2.00") },
            new RefAssessmentNeedHazardType { Id=Guid.Parse("76c358e7-b256-47cf-bcaa-066f15c8dc58"), Code="Olfactory", Description="Olfactory", SortOrder=Convert.ToDecimal("3.00") },
            new RefAssessmentNeedHazardType { Id=Guid.Parse("7baa6f42-aaf0-4555-8a06-c31c26007838"), Code="MotionSimulation", Description="Motion simulation", SortOrder=Convert.ToDecimal("4.00") },
       };
   }
}
