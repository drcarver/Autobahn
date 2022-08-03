//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   K12StudentCohort.cs
//**********************************************************

using Autobahn.K12.Interfaces;

namespace Autobahn.K12.Models
{
     /// <summary>
     /// The K12StudentCohort
     /// </summary>
    public partial class K12StudentCohort : IK12StudentCohort
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="OrganizationPersonRole"/> model
        /// </summary>
        public Guid OrganizationPersonRoleId { get; set; }

        /// <summary>
        /// Defines the K12StudentCohort.CohortYear non nullable property
        /// </summary>
        public System.String CohortYear { get; set; }

        /// <summary>
        /// Defines the K12StudentCohort.CohortGraduationYear non nullable property
        /// </summary>
        public System.String CohortGraduationYear { get; set; }

        /// <summary>
        /// Defines the K12StudentCohort.GraduationRateSurveyCohortYear non nullable property
        /// </summary>
        public System.String GraduationRateSurveyCohortYear { get; set; }

        /// <summary>
        /// Defines the K12StudentCohort.GraduationRateSurveyIndicator nullable property
        /// </summary>
        public System.Boolean? GraduationRateSurveyIndicator { get; set; }

        /// <summary>
        /// Defines the K12StudentCohort.CohortDescription non nullable property
        /// </summary>
        public System.String CohortDescription { get; set; }

        /// <summary>
        /// Defines the K12StudentCohort.RecordStartDateTime nullable property
        /// </summary>
        public System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the K12StudentCohort.RecordEndDateTime nullable property
        /// </summary>
        public System.DateTime? RecordEndDateTime { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RecordStatus"/> model
        /// </summary>
        public Guid? RecordStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
