//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IRefCourseSectionAssessmentReportingMethod.cs
//**********************************************************

namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IRefCourseSectionAssessmentReportingMethod
     /// </summary>
    public partial interface IRefCourseSectionAssessmentReportingMethod
    {
        /// <summary>
        /// Defines the RefCourseSectionAssessmentReportingMethod.Description non nullable property
        /// </summary>
        System.String Description { get; set; }

        /// <summary>
        /// Defines the RefCourseSectionAssessmentReportingMethod.Code non nullable property
        /// </summary>
        System.String Code { get; set; }

        /// <summary>
        /// Defines the RefCourseSectionAssessmentReportingMethod.Definition non nullable property
        /// </summary>
        System.String Definition { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefJurisdiction"/> model
        /// </summary>
        Guid? RefJurisdictionId { get; set; }

        /// <summary>
        /// Defines the RefCourseSectionAssessmentReportingMethod.SortOrder nullable property
        /// </summary>
        System.Decimal? SortOrder { get; set; }

        /// <summary>
        /// Defines the RefCourseSectionAssessmentReportingMethod.RecordStartDateTime nullable property
        /// </summary>
        System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the RefCourseSectionAssessmentReportingMethod.RecordEndDateTime nullable property
        /// </summary>
        System.DateTime? RecordEndDateTime { get; set; }

    }
}
