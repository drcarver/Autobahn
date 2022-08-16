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
        /// 
        /// </summary>
        Guid? DesegregationOrderOrPlan { get; set; }

        /// <summary>
        /// 
        /// </summary>
         HarassmentOrBullyingPolicy { get; set; }

        /// <summary>
        /// 
        /// </summary>
         InterscholasticSportParticipantsFemale { get; set; }

        /// <summary>
        /// 
        /// </summary>
         InterscholasticSportParticipantsMale { get; set; }

        /// <summary>
        /// 
        /// </summary>
         InterscholasticSportsFemaleOnly { get; set; }

        /// <summary>
        /// 
        /// </summary>
         InterscholasticSportsMaleOnly { get; set; }

        /// <summary>
        /// 
        /// </summary>
         InterscholasticTeamsFemaleOnly { get; set; }

        /// <summary>
        /// 
        /// </summary>
         InterscholasticTeamsMaleOnly { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RecordEndDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RecordStartDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefBarrierToEducatingHomelessId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefIntegratedTechnologyStatusId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         StateAssessmentAdminFunding { get; set; }

        /// <summary>
        /// 
        /// </summary>
         StateAssessStandardsFunding { get; set; }

        /// <summary>
        /// 
        /// </summary>
         TerminatedTitleIIIProgramFailure { get; set; }

    }
}
