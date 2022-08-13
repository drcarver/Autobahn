//***************************************************************************
//* DomainName: Elementary and Secondary (K12) Interfaces (used by both models and View Models
//* FileName:   IK12LeaFederalReporting.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.K12.Interfaces
{
     /// <summary>
     /// The IK12LeaFederalReporting Interface
     /// </summary>
    public partial interface IK12LeaFederalReporting : IAutobahnBase
    {
        /// <summary>
        /// An indication whether the LEA is covered by a desegregation plan either ordered by a court or entered into with the Office for Civil Rights under Title VI of the Civil Rights Act of 1964.
        /// </summary>
        System.Boolean? DesegregationOrderOrPlan { get; set; }

        /// <summary>
        /// An indication whether the LEA is covered by a desegregation plan either ordered by a court or entered into with the Office for Civil Rights under Title VI of the Civil Rights Act of 1964.
        /// </summary>
        System.Boolean? HarassmentOrBullyingPolicy { get; set; }

        /// <summary>
        /// An indication whether the LEA is covered by a desegregation plan either ordered by a court or entered into with the Office for Civil Rights under Title VI of the Civil Rights Act of 1964.
        /// </summary>
        System.Int32? InterscholasticSportParticipantsFemale { get; set; }

        /// <summary>
        /// An indication whether the LEA is covered by a desegregation plan either ordered by a court or entered into with the Office for Civil Rights under Title VI of the Civil Rights Act of 1964.
        /// </summary>
        System.Int32? InterscholasticSportParticipantsMale { get; set; }

        /// <summary>
        /// An indication whether the LEA is covered by a desegregation plan either ordered by a court or entered into with the Office for Civil Rights under Title VI of the Civil Rights Act of 1964.
        /// </summary>
        System.Int32? InterscholasticSportsFemaleOnly { get; set; }

        /// <summary>
        /// An indication whether the LEA is covered by a desegregation plan either ordered by a court or entered into with the Office for Civil Rights under Title VI of the Civil Rights Act of 1964.
        /// </summary>
        System.Int32? InterscholasticSportsMaleOnly { get; set; }

        /// <summary>
        /// An indication whether the LEA is covered by a desegregation plan either ordered by a court or entered into with the Office for Civil Rights under Title VI of the Civil Rights Act of 1964.
        /// </summary>
        System.Int32? InterscholasticTeamsFemaleOnly { get; set; }

        /// <summary>
        /// An indication whether the LEA is covered by a desegregation plan either ordered by a court or entered into with the Office for Civil Rights under Title VI of the Civil Rights Act of 1964.
        /// </summary>
        System.Int32? InterscholasticTeamsMaleOnly { get; set; }

        /// <summary>
        /// An indication whether the LEA is covered by a desegregation plan either ordered by a court or entered into with the Office for Civil Rights under Title VI of the Civil Rights Act of 1964.
        /// </summary>
        Guid K12LeaId { get; set; }

        /// <summary>
        /// An indication whether the LEA is covered by a desegregation plan either ordered by a court or entered into with the Office for Civil Rights under Title VI of the Civil Rights Act of 1964.
        /// </summary>
        Guid? RefBarrierToEducatingHomelessId { get; set; }

        /// <summary>
        /// An indication whether the LEA is covered by a desegregation plan either ordered by a court or entered into with the Office for Civil Rights under Title VI of the Civil Rights Act of 1964.
        /// </summary>
        Guid? RefIntegratedTechnologyStatusId { get; set; }

        /// <summary>
        /// An indication whether the LEA is covered by a desegregation plan either ordered by a court or entered into with the Office for Civil Rights under Title VI of the Civil Rights Act of 1964.
        /// </summary>
        System.Decimal? StateAssessmentAdminFunding { get; set; }

        /// <summary>
        /// An indication whether the LEA is covered by a desegregation plan either ordered by a court or entered into with the Office for Civil Rights under Title VI of the Civil Rights Act of 1964.
        /// </summary>
        System.Decimal? StateAssessStandardsFunding { get; set; }

        /// <summary>
        /// An indication whether the LEA is covered by a desegregation plan either ordered by a court or entered into with the Office for Civil Rights under Title VI of the Civil Rights Act of 1964.
        /// </summary>
        System.Boolean? TerminatedTitleIIIProgramFailure { get; set; }

    }
}
