//**********************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12LeaFederalReportingModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.K12.Models
{
     /// <summary>
     /// The K12LeaFederalReporting Model
     /// </summary>
    public partial class K12LeaFederalReportingModel : AutobahnBase, Interfaces.IK12LeaFederalReporting
    {
        /// <summary>
        /// An indication whether the LEA is covered by a desegregation plan either ordered by a court or entered into with the Office for Civil Rights under Title VI of the Civil Rights Act of 1964.
        /// </summary>
        public System.Boolean? DesegregationOrderOrPlan { get; set; }

        /// <summary>
        /// An indication whether the LEA is covered by a desegregation plan either ordered by a court or entered into with the Office for Civil Rights under Title VI of the Civil Rights Act of 1964.
        /// </summary>
        public System.Boolean? HarassmentOrBullyingPolicy { get; set; }

        /// <summary>
        /// An indication whether the LEA is covered by a desegregation plan either ordered by a court or entered into with the Office for Civil Rights under Title VI of the Civil Rights Act of 1964.
        /// </summary>
        public System.Int32? InterscholasticSportParticipantsFemale { get; set; }

        /// <summary>
        /// An indication whether the LEA is covered by a desegregation plan either ordered by a court or entered into with the Office for Civil Rights under Title VI of the Civil Rights Act of 1964.
        /// </summary>
        public System.Int32? InterscholasticSportParticipantsMale { get; set; }

        /// <summary>
        /// An indication whether the LEA is covered by a desegregation plan either ordered by a court or entered into with the Office for Civil Rights under Title VI of the Civil Rights Act of 1964.
        /// </summary>
        public System.Int32? InterscholasticSportsFemaleOnly { get; set; }

        /// <summary>
        /// An indication whether the LEA is covered by a desegregation plan either ordered by a court or entered into with the Office for Civil Rights under Title VI of the Civil Rights Act of 1964.
        /// </summary>
        public System.Int32? InterscholasticSportsMaleOnly { get; set; }

        /// <summary>
        /// An indication whether the LEA is covered by a desegregation plan either ordered by a court or entered into with the Office for Civil Rights under Title VI of the Civil Rights Act of 1964.
        /// </summary>
        public System.Int32? InterscholasticTeamsFemaleOnly { get; set; }

        /// <summary>
        /// An indication whether the LEA is covered by a desegregation plan either ordered by a court or entered into with the Office for Civil Rights under Title VI of the Civil Rights Act of 1964.
        /// </summary>
        public System.Int32? InterscholasticTeamsMaleOnly { get; set; }

        /// <summary>
        /// An indication whether the LEA is covered by a desegregation plan either ordered by a court or entered into with the Office for Civil Rights under Title VI of the Civil Rights Act of 1964.
        /// </summary>
        public Guid K12LeaId { get; set; }

        /// <summary>
        /// An indication whether the LEA is covered by a desegregation plan either ordered by a court or entered into with the Office for Civil Rights under Title VI of the Civil Rights Act of 1964.
        /// </summary>
        public Guid? RefBarrierToEducatingHomelessId { get; set; }

        /// <summary>
        /// An indication whether the LEA is covered by a desegregation plan either ordered by a court or entered into with the Office for Civil Rights under Title VI of the Civil Rights Act of 1964.
        /// </summary>
        public Guid? RefIntegratedTechnologyStatusId { get; set; }

        /// <summary>
        /// An indication whether the LEA is covered by a desegregation plan either ordered by a court or entered into with the Office for Civil Rights under Title VI of the Civil Rights Act of 1964.
        /// </summary>
        public System.Decimal? StateAssessmentAdminFunding { get; set; }

        /// <summary>
        /// An indication whether the LEA is covered by a desegregation plan either ordered by a court or entered into with the Office for Civil Rights under Title VI of the Civil Rights Act of 1964.
        /// </summary>
        public System.Decimal? StateAssessStandardsFunding { get; set; }

        /// <summary>
        /// An indication whether the LEA is covered by a desegregation plan either ordered by a court or entered into with the Office for Civil Rights under Title VI of the Civil Rights Act of 1964.
        /// </summary>
        public System.Boolean? TerminatedTitleIIIProgramFailure { get; set; }

    }
}
