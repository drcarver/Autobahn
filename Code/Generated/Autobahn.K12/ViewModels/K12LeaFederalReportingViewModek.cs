//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   K12LeaFederalReportingViewModel.cs
//**********************************************************

using Prism.Mvvm;
using Autobahn.Common.Interfaces;
using Autobahn.Autobahn.K12.Interfaces;

namespace Autobahn.K12.ViewModels
{
     /// <summary>
     /// The K12LeaFederalReportingViewModel
     /// </summary>
    public partial class K12LeaFederalReportingViewModel : BindableBase, IK12LeaFederalReporting
    {
#region "Backing Fields"
        // member variable for the DesegregationOrderOrPlan property
        private System.Boolean? _DesegregationOrderOrPlan;

        // member variable for the HarassmentOrBullyingPolicy property
        private System.Boolean? _HarassmentOrBullyingPolicy;

        // member variable for the StateAssessmentAdminFunding property
        private System.Decimal? _StateAssessmentAdminFunding;

        // member variable for the StateAssessStandardsFunding property
        private System.Decimal? _StateAssessStandardsFunding;

        // member variable for the TerminatedTitleIIIProgramFailure property
        private System.Boolean? _TerminatedTitleIIIProgramFailure;

        // member variable for the InterscholasticSportsMaleOnly property
        private System.Int32? _InterscholasticSportsMaleOnly;

        // member variable for the InterscholasticSportsFemaleOnly property
        private System.Int32? _InterscholasticSportsFemaleOnly;

        // member variable for the InterscholasticTeamsMaleOnly property
        private System.Int32? _InterscholasticTeamsMaleOnly;

        // member variable for the InterscholasticTeamsFemaleOnly property
        private System.Int32? _InterscholasticTeamsFemaleOnly;

        // member variable for the InterscholasticSportParticipantsMale property
        private System.Int32? _InterscholasticSportParticipantsMale;

        // member variable for the InterscholasticSportParticipantsFemale property
        private System.Int32? _InterscholasticSportParticipantsFemale;

        // member variable for the RecordStartDateTime property
        private System.DateTime? _RecordStartDateTime;

        // member variable for the RecordEndDateTime property
        private System.DateTime? _RecordEndDateTime;

#endregion

#region Properties
        /// <summary>
        /// Reference to a required instance of the <see cref="K12LeaId"/> model
        /// </summary>
        public Guid K12LeaId { get; set; }

        public System.Boolean? DesegregationOrderOrPlan { get => _DesegregationOrderOrPlan; set => SetProperty(ref _DesegregationOrderOrPlan, value); }

        public System.Boolean? HarassmentOrBullyingPolicy { get => _HarassmentOrBullyingPolicy; set => SetProperty(ref _HarassmentOrBullyingPolicy, value); }

        public System.Decimal? StateAssessmentAdminFunding { get => _StateAssessmentAdminFunding; set => SetProperty(ref _StateAssessmentAdminFunding, value); }

        public System.Decimal? StateAssessStandardsFunding { get => _StateAssessStandardsFunding; set => SetProperty(ref _StateAssessStandardsFunding, value); }

        public System.Boolean? TerminatedTitleIIIProgramFailure { get => _TerminatedTitleIIIProgramFailure; set => SetProperty(ref _TerminatedTitleIIIProgramFailure, value); }

        public System.Int32? InterscholasticSportsMaleOnly { get => _InterscholasticSportsMaleOnly; set => SetProperty(ref _InterscholasticSportsMaleOnly, value); }

        public System.Int32? InterscholasticSportsFemaleOnly { get => _InterscholasticSportsFemaleOnly; set => SetProperty(ref _InterscholasticSportsFemaleOnly, value); }

        public System.Int32? InterscholasticTeamsMaleOnly { get => _InterscholasticTeamsMaleOnly; set => SetProperty(ref _InterscholasticTeamsMaleOnly, value); }

        public System.Int32? InterscholasticTeamsFemaleOnly { get => _InterscholasticTeamsFemaleOnly; set => SetProperty(ref _InterscholasticTeamsFemaleOnly, value); }

        public System.Int32? InterscholasticSportParticipantsMale { get => _InterscholasticSportParticipantsMale; set => SetProperty(ref _InterscholasticSportParticipantsMale, value); }

        public System.Int32? InterscholasticSportParticipantsFemale { get => _InterscholasticSportParticipantsFemale; set => SetProperty(ref _InterscholasticSportParticipantsFemale, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefBarrierToEducatingHomelessId"/> model
        /// </summary>
        public Guid? RefBarrierToEducatingHomelessId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefIntegratedTechnologyStatusId"/> model
        /// </summary>
        public Guid? RefIntegratedTechnologyStatusId { get; set; }

        public System.DateTime? RecordStartDateTime { get => _RecordStartDateTime; set => SetProperty(ref _RecordStartDateTime, value); }

        public System.DateTime? RecordEndDateTime { get => _RecordEndDateTime; set => SetProperty(ref _RecordEndDateTime, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RecordStatusId"/> model
        /// </summary>
        public Guid? RecordStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollectionId"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

#endregion


        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(IK12LeaFederalReporting model)
        {
            IsBusy = true;
            Id = model.Id;
            K12LeaId = model.K12LeaId;
            DesegregationOrderOrPlan = model.DesegregationOrderOrPlan;
            HarassmentOrBullyingPolicy = model.HarassmentOrBullyingPolicy;
            StateAssessmentAdminFunding = model.StateAssessmentAdminFunding;
            StateAssessStandardsFunding = model.StateAssessStandardsFunding;
            TerminatedTitleIIIProgramFailure = model.TerminatedTitleIIIProgramFailure;
            InterscholasticSportsMaleOnly = model.InterscholasticSportsMaleOnly;
            InterscholasticSportsFemaleOnly = model.InterscholasticSportsFemaleOnly;
            InterscholasticTeamsMaleOnly = model.InterscholasticTeamsMaleOnly;
            InterscholasticTeamsFemaleOnly = model.InterscholasticTeamsFemaleOnly;
            InterscholasticSportParticipantsMale = model.InterscholasticSportParticipantsMale;
            InterscholasticSportParticipantsFemale = model.InterscholasticSportParticipantsFemale;
            RefBarrierToEducatingHomelessId = model.RefBarrierToEducatingHomelessId;
            RefIntegratedTechnologyStatusId = model.RefIntegratedTechnologyStatusId;
            RecordStartDateTime = model.RecordStartDateTime;
            RecordEndDateTime = model.RecordEndDateTime;
            RecordStatusId = model.RecordStatusId;
            DataCollectionId = model.DataCollectionId;
            IsChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
