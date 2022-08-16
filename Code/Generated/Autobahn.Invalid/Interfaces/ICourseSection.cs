//***************************************************************************
//* DomainName: Invalid or Unreferenced Models Interfaces (used by both models and View Models
//* FileName:   ICourseSection.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Invalid.Interfaces
{
     /// <summary>
     /// The ICourseSection Interface
     /// </summary>
    public partial interface ICourseSection : IAutobahnBase
    {
        /// <summary>
        /// 
        /// </summary>
        Guid? AvailableCarnegieUnitCredit { get; set; }

        /// <summary>
        /// 
        /// </summary>
         MaximumCapacity { get; set; }

        /// <summary>
        /// 
        /// </summary>
         OrganizationCalendarSessionId { get; set; }

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
         RefAdditionalCreditTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefAdvancedPlacementCourseCodeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefCourseSectionDeliveryModeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefInstructionLanguageId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefSingleSexClassStatusId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RelatedCompetencyDefinitions { get; set; }

        /// <summary>
        /// 
        /// </summary>
         TimeRequiredForCompletion { get; set; }

        /// <summary>
        /// 
        /// </summary>
         VirtualIndicator { get; set; }

    }
}
