//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   K12LeaFederalReporting.cs
//**********************************************************

using Autobahn.K12.Interfaces;

namespace Autobahn.K12.Models
{
     /// <summary>
     /// The K12LeaFederalReporting
     /// </summary>
    public partial class K12LeaFederalReporting : IK12LeaFederalReporting
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="K12Lea"/> model
        /// </summary>
        public Guid K12LeaId { get; set; }

        /// <summary>
        /// Defines the K12LeaFederalReporting.DesegregationOrderOrPlan nullable property
        /// </summary>
        public System.Boolean? DesegregationOrderOrPlan { get; set; }

        /// <summary>
        /// Defines the K12LeaFederalReporting.HarassmentOrBullyingPolicy nullable property
        /// </summary>
        public System.Boolean? HarassmentOrBullyingPolicy { get; set; }

        /// <summary>
        /// Defines the K12LeaFederalReporting.StateAssessmentAdminFunding nullable property
        /// </summary>
        public System.Decimal? StateAssessmentAdminFunding { get; set; }

        /// <summary>
        /// Defines the K12LeaFederalReporting.StateAssessStandardsFunding nullable property
        /// </summary>
        public System.Decimal? StateAssessStandardsFunding { get; set; }

        /// <summary>
        /// Defines the K12LeaFederalReporting.TerminatedTitleIIIProgramFailure nullable property
        /// </summary>
        public System.Boolean? TerminatedTitleIIIProgramFailure { get; set; }

        /// <summary>
        /// Defines the K12LeaFederalReporting.InterscholasticSportsMaleOnly nullable property
        /// </summary>
        public System.Int32? InterscholasticSportsMaleOnly { get; set; }

        /// <summary>
        /// Defines the K12LeaFederalReporting.InterscholasticSportsFemaleOnly nullable property
        /// </summary>
        public System.Int32? InterscholasticSportsFemaleOnly { get; set; }

        /// <summary>
        /// Defines the K12LeaFederalReporting.InterscholasticTeamsMaleOnly nullable property
        /// </summary>
        public System.Int32? InterscholasticTeamsMaleOnly { get; set; }

        /// <summary>
        /// Defines the K12LeaFederalReporting.InterscholasticTeamsFemaleOnly nullable property
        /// </summary>
        public System.Int32? InterscholasticTeamsFemaleOnly { get; set; }

        /// <summary>
        /// Defines the K12LeaFederalReporting.InterscholasticSportParticipantsMale nullable property
        /// </summary>
        public System.Int32? InterscholasticSportParticipantsMale { get; set; }

        /// <summary>
        /// Defines the K12LeaFederalReporting.InterscholasticSportParticipantsFemale nullable property
        /// </summary>
        public System.Int32? InterscholasticSportParticipantsFemale { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefBarrierToEducatingHomeless"/> model
        /// </summary>
        public Guid? RefBarrierToEducatingHomelessId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefIntegratedTechnologyStatus"/> model
        /// </summary>
        public Guid? RefIntegratedTechnologyStatusId { get; set; }

        /// <summary>
        /// Defines the K12LeaFederalReporting.RecordStartDateTime nullable property
        /// </summary>
        public System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the K12LeaFederalReporting.RecordEndDateTime nullable property
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
