//**********************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12leaFederalReportingModel.cs
//***************************************************************************

using Autobahn.Education.Interfaces.K12;

namespace Autobahn.Education.K12.Models
{
     /// <summary>
     /// The K12leaFederalReporting Model
     /// </summary>
    public partial class K12leaFederalReportingModel : IK12leaFederalReporting
    {
        // Concrete implementation of IAutobahnBase
        #region IAutobahnBase
        /// <summary>
        /// Gets the model's changed status.
        /// </summary>
        public bool IsChanged { get; private set; } = false;

        /// <summary>
        /// Resets the model's state to unchanged by accepting the modifications.
        /// </summary>
        public void AcceptChanges()
        {
             IsChanged = false;
             IsNew = false;
        }

        /// <summary>
        /// True if the model is new and unsaved.
        /// </summary>
        public bool IsNew { get; set; } =  false;

        /// <summary>
        /// Is it a deleted model?
        /// </summary>
        public bool IsDeleted { get; set; } = false;

        /// <summary>
        /// The Id of the Model
        /// </summary>
        public Guid Id { get; set; } = Guid.NewGuid();
        #endregion

        #region IK12leaFederalReporting
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

        #endregion
    }
}
