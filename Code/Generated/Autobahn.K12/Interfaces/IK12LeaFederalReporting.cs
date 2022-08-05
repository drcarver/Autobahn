//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   IK12LeaFederalReporting.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.K12.Interfaces
{
     /// <summary>
     /// The IK12LeaFederalReporting
     /// </summary>
    public partial interface IK12LeaFederalReporting : IAutobahnBase
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="K12Lea"/> model
        /// </summary>
        Guid K12LeaId { get; set; }

        /// <summary>
        /// Defines the K12LeaFederalReporting.DesegregationOrderOrPlan nullable property
        /// </summary>
        System.Boolean? DesegregationOrderOrPlan { get; set; }

        /// <summary>
        /// Defines the K12LeaFederalReporting.HarassmentOrBullyingPolicy nullable property
        /// </summary>
        System.Boolean? HarassmentOrBullyingPolicy { get; set; }

        /// <summary>
        /// Defines the K12LeaFederalReporting.StateAssessmentAdminFunding nullable property
        /// </summary>
        System.Decimal? StateAssessmentAdminFunding { get; set; }

        /// <summary>
        /// Defines the K12LeaFederalReporting.StateAssessStandardsFunding nullable property
        /// </summary>
        System.Decimal? StateAssessStandardsFunding { get; set; }

        /// <summary>
        /// Defines the K12LeaFederalReporting.TerminatedTitleIIIProgramFailure nullable property
        /// </summary>
        System.Boolean? TerminatedTitleIIIProgramFailure { get; set; }

        /// <summary>
        /// Defines the K12LeaFederalReporting.InterscholasticSportsMaleOnly nullable property
        /// </summary>
        System.Int32? InterscholasticSportsMaleOnly { get; set; }

        /// <summary>
        /// Defines the K12LeaFederalReporting.InterscholasticSportsFemaleOnly nullable property
        /// </summary>
        System.Int32? InterscholasticSportsFemaleOnly { get; set; }

        /// <summary>
        /// Defines the K12LeaFederalReporting.InterscholasticTeamsMaleOnly nullable property
        /// </summary>
        System.Int32? InterscholasticTeamsMaleOnly { get; set; }

        /// <summary>
        /// Defines the K12LeaFederalReporting.InterscholasticTeamsFemaleOnly nullable property
        /// </summary>
        System.Int32? InterscholasticTeamsFemaleOnly { get; set; }

        /// <summary>
        /// Defines the K12LeaFederalReporting.InterscholasticSportParticipantsMale nullable property
        /// </summary>
        System.Int32? InterscholasticSportParticipantsMale { get; set; }

        /// <summary>
        /// Defines the K12LeaFederalReporting.InterscholasticSportParticipantsFemale nullable property
        /// </summary>
        System.Int32? InterscholasticSportParticipantsFemale { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefBarrierToEducatingHomeless"/> model
        /// </summary>
        Guid? RefBarrierToEducatingHomelessId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefIntegratedTechnologyStatus"/> model
        /// </summary>
        Guid? RefIntegratedTechnologyStatusId { get; set; }

    }
}
