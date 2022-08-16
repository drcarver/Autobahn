//**********************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12StaffAssignmentModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.K12.Models
{
     /// <summary>
     /// The K12StaffAssignment Model
     /// </summary>
    public partial class K12StaffAssignmentModel : AutobahnBase, Interfaces.IK12StaffAssignment
    {
        /// <summary>
        /// 
        /// </summary>
        public  ContributionPercentage { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  FullTimeEquivalency { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  HighlyQualifiedTeacherIndicator { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  ItinerantTeacher { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  PrimaryAssignment { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RecordEndDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RecordStartDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefClassroomPositionTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefEDFactsTeacherInexperiencedStatusId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Guid? RefK12StaffClassificationId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefMepStaffCategoryId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefOutOfFieldStatusId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefProfessionalEducationJobClassificationId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefSpecialEducationAgeGroupTaughtId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefSpecialEducationStaffCategoryId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefTeachingAssignmentRoleId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefTitleIProgramStaffCategoryId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  SpecialEducationParaprofessional { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  SpecialEducationRelatedServicesPersonnel { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  SpecialEducationTeacher { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  TeacherOfRecord { get; set; }

    }
}
