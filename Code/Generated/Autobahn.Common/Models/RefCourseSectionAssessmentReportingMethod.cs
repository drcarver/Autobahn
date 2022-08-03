//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefCourseSectionAssessmentReportingMethod.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The RefCourseSectionAssessmentReportingMethod
     /// </summary>
    public partial class RefCourseSectionAssessmentReportingMethod : IRefCourseSectionAssessmentReportingMethod
    {
        /// <summary>
        /// Defines the RefCourseSectionAssessmentReportingMethod.Description non nullable property
        /// </summary>
        public System.String Description { get; set; }

        /// <summary>
        /// Defines the RefCourseSectionAssessmentReportingMethod.Code non nullable property
        /// </summary>
        public System.String Code { get; set; }

        /// <summary>
        /// Defines the RefCourseSectionAssessmentReportingMethod.Definition non nullable property
        /// </summary>
        public System.String Definition { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefJurisdiction"/> model
        /// </summary>
        public Guid? RefJurisdictionId { get; set; }

        /// <summary>
        /// Defines the RefCourseSectionAssessmentReportingMethod.SortOrder nullable property
        /// </summary>
        public System.Decimal? SortOrder { get; set; }

        /// <summary>
        /// Defines the RefCourseSectionAssessmentReportingMethod.RecordStartDateTime nullable property
        /// </summary>
        public System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the RefCourseSectionAssessmentReportingMethod.RecordEndDateTime nullable property
        /// </summary>
        public System.DateTime? RecordEndDateTime { get; set; }

    }
}
