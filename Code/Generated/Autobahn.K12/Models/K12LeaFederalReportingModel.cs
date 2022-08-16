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
        /// 
        /// </summary>
        public Guid? DesegregationOrderOrPlan { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  HarassmentOrBullyingPolicy { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  InterscholasticSportParticipantsFemale { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  InterscholasticSportParticipantsMale { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  InterscholasticSportsFemaleOnly { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  InterscholasticSportsMaleOnly { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  InterscholasticTeamsFemaleOnly { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  InterscholasticTeamsMaleOnly { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RecordEndDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RecordStartDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefBarrierToEducatingHomelessId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefIntegratedTechnologyStatusId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  StateAssessmentAdminFunding { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  StateAssessStandardsFunding { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  TerminatedTitleIIIProgramFailure { get; set; }

    }
}
