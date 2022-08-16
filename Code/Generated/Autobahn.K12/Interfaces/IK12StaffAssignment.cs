//***************************************************************************
//* DomainName: Elementary and Secondary (K12) Interfaces (used by both models and View Models
//* FileName:   IK12StaffAssignment.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.K12.Interfaces
{
     /// <summary>
     /// The IK12StaffAssignment Interface
     /// </summary>
    public partial interface IK12StaffAssignment : IAutobahnBase
    {
        /// <summary>
        /// 
        /// </summary>
         ContributionPercentage { get; set; }

        /// <summary>
        /// 
        /// </summary>
         FullTimeEquivalency { get; set; }

        /// <summary>
        /// 
        /// </summary>
         HighlyQualifiedTeacherIndicator { get; set; }

        /// <summary>
        /// 
        /// </summary>
         ItinerantTeacher { get; set; }

        /// <summary>
        /// 
        /// </summary>
         PrimaryAssignment { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RecordEndDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RecordStartDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefClassroomPositionTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefEDFactsTeacherInexperiencedStatusId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        Guid? RefK12StaffClassificationId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefMepStaffCategoryId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefOutOfFieldStatusId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefProfessionalEducationJobClassificationId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefSpecialEducationAgeGroupTaughtId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefSpecialEducationStaffCategoryId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefTeachingAssignmentRoleId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefTitleIProgramStaffCategoryId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         SpecialEducationParaprofessional { get; set; }

        /// <summary>
        /// 
        /// </summary>
         SpecialEducationRelatedServicesPersonnel { get; set; }

        /// <summary>
        /// 
        /// </summary>
         SpecialEducationTeacher { get; set; }

        /// <summary>
        /// 
        /// </summary>
         TeacherOfRecord { get; set; }

    }
}
