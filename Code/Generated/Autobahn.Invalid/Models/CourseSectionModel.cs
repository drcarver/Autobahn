//**********************************************************
//* DomainName: Invalid or Unreferenced Models
//* FileName:   CourseSectionModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Invalid.Models
{
     /// <summary>
     /// The CourseSection Model
     /// </summary>
    public partial class CourseSectionModel : AutobahnBase, Interfaces.ICourseSection
    {
        /// <summary>
        /// 
        /// </summary>
        public Guid? AvailableCarnegieUnitCredit { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  MaximumCapacity { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  OrganizationCalendarSessionId { get; set; }

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
        public  RefAdditionalCreditTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefAdvancedPlacementCourseCodeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefCourseSectionDeliveryModeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefInstructionLanguageId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefSingleSexClassStatusId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RelatedCompetencyDefinitions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  TimeRequiredForCompletion { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  VirtualIndicator { get; set; }

    }
}
