//**********************************************************
//* DomainName: Autobahn.Interfaces.Common
//* FileName:   ICourseSectionLocation.cs
//**********************************************************

namespace Autobahn.Interfaces.Common;

public interface ICourseSection : IAutobahnBase
{
    Guid OrganizationId { get; set; }
    Guid CourseId { get; set; }
    decimal? AvailableCarnegieUnitCredit { get; set; }
    decimal? TimeRequiredForCompletion { get; set; }
    bool? VirtualIndicator { get; set; }
    Guid? OrganizationCalendarSessionId { get; set; }
    int? MaximumCapacity { get; set; }
    string RelatedCompetencyDefinitions { get; set; }
    Guid? RefCourseSectionDeliveryModeId { get; set; }
    Guid? RefSingleSexClassStatusId { get; set; }
    Guid? RefAdditionalCreditTypeId { get; set; }
    Guid? RefInstructionLanguageId { get; set; }
    Guid? RefCreditTypeEarnedId { get; set; }
    Guid? RefAdvancedPlacementCourseCodeId { get; set; }
}