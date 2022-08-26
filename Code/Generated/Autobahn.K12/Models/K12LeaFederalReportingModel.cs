//**********************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12leaFederalReportingModel.cs
//***************************************************************************

using Autobahn.Interfaces.K12;
using Autobahn.Interfaces.Common;
using Autobahn.Common.Models;

namespace Autobahn.K12.Models
{
     /// <summary>
     /// The K12leaFederalReporting Model
     /// </summary>
    public partial class K12leaFederalReportingModel : AutobahnBase, IK12leaFederalReporting
    {
        public Boolean? DesegregationOrderOrPlan { get; set; }

        public Boolean? HarassmentOrBullyingPolicy { get; set; }

        public Int32? InterscholasticSportParticipantsFemale { get; set; }

        public Int32? InterscholasticSportParticipantsMale { get; set; }

        public Int32? InterscholasticSportsFemaleOnly { get; set; }

        public Int32? InterscholasticSportsMaleOnly { get; set; }

        public Int32? InterscholasticTeamsFemaleOnly { get; set; }

        public Int32? InterscholasticTeamsMaleOnly { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IK12lea"/> model
        /// </summary>
        public Guid K12leaId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefBarrierToEducatingHomeless"/> model
        /// </summary>
        public Guid? RefBarrierToEducatingHomelessId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefIntegratedTechnologyStatus"/> model
        /// </summary>
        public Guid? RefIntegratedTechnologyStatusId { get; set; }

        public Decimal? StateAssessmentAdminFunding { get; set; }

        public Decimal? StateAssessStandardsFunding { get; set; }

        public Boolean? TerminatedTitleIiiprogramFailure { get; set; }

    }
}
