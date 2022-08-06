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
        public static List<RefAssessmentNeedHazardType> RefAssessmentNeedHazardTypeList = new List<RefAssessmentNeedHazardType> =
        {
            new RefAssessmentNeedHazardType { Id=Guid.Parse("65bc1271-5dee-40e7-81b8-fc00f5d9511f"), Code="Flashing is specified as part of an Assessment Personal Needs Profile as a characteristic of a digital resource that may be dangerous to a user.", Description="Flashing", Definition="", SortOrder=0 },
            new RefAssessmentNeedHazardType { Id=Guid.Parse("9299ded2-9ef7-4832-a7fe-f0559babe2c1"), Code="Sound is specified as part of an Assessment Personal Needs Profile as a characteristic of a digital resource that may be dangerous to a user.", Description="Sound", Definition="", SortOrder=0 },
            new RefAssessmentNeedHazardType { Id=Guid.Parse("647e95e1-5012-4eb5-8a13-bbcb1b1bafff"), Code="Olfactory is specified as part of an Assessment Personal Needs Profile as a characteristic of a digital resource that may be dangerous to a user.", Description="Olfactory", Definition="", SortOrder=0 },
            new RefAssessmentNeedHazardType { Id=Guid.Parse("daab577e-f250-4c7f-aad1-58d864e1f719"), Code="Motion simulation is specified as part of an Assessment Personal Needs Profile as a characteristic of a digital resource that may be dangerous to a user.", Description="MotionSimulation", Definition="", SortOrder=0 },
        };

        /// <summary>
        /// The RefAssessmentNeedHazardType Pick List
         /// </summary>
        public static List<RefAssessmentNeedHazardType> RefAssessmentNeedHazardTypePickList = new List<RefAssessmentNeedHazardType> =
        {
            new RefAssessmentNeedHazardType { Id=Guid.Parse("65bc1271-5dee-40e7-81b8-fc00f5d9511f"), Code="Flashing is specified as part of an Assessment Personal Needs Profile as a characteristic of a digital resource that may be dangerous to a user.", SortOrder=0 },
            new RefAssessmentNeedHazardType { Id=Guid.Parse("9299ded2-9ef7-4832-a7fe-f0559babe2c1"), Code="Sound is specified as part of an Assessment Personal Needs Profile as a characteristic of a digital resource that may be dangerous to a user.", SortOrder=0 },
            new RefAssessmentNeedHazardType { Id=Guid.Parse("647e95e1-5012-4eb5-8a13-bbcb1b1bafff"), Code="Olfactory is specified as part of an Assessment Personal Needs Profile as a characteristic of a digital resource that may be dangerous to a user.", SortOrder=0 },
            new RefAssessmentNeedHazardType { Id=Guid.Parse("daab577e-f250-4c7f-aad1-58d864e1f719"), Code="Motion simulation is specified as part of an Assessment Personal Needs Profile as a characteristic of a digital resource that may be dangerous to a user.", SortOrder=0 },
       };
   }
}
