//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   K12LeaFederalReportingViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

namespace Autobahn.K12.ViewModels
{
     /// <summary>
     /// The K12LeaFederalReportingViewModel
     /// </summary>
    public partial class K12LeaFederalReportingViewModel : ViewModelBase, Interfaces.IK12LeaFederalReportingViewModel
    {
#region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from K12LeaFederalReporting";

        // member variable for the K12LeaId property
        private Guid _K12LeaId;

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

        // member variable for the RefBarrierToEducatingHomelessId property
        private Guid? _RefBarrierToEducatingHomelessId;

        // member variable for the RefIntegratedTechnologyStatusId property
        private Guid? _RefIntegratedTechnologyStatusId;

        // member variable for the RecordStartDateTime property
        private System.DateTime? _RecordStartDateTime;

        // member variable for the RecordEndDateTime property
        private System.DateTime? _RecordEndDateTime;

        // member variable for the RecordStatusId property
        private Guid? _RecordStatusId;

        // member variable for the DataCollectionId property
        private Guid? _DataCollectionId;

#endregion

        #region Properties
        /// <summary>
        /// The title of the K12LeaFederalReportingViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="K12LeaId"/> model
        /// </summary>
        public Guid K12LeaId { get => _K12LeaId; set => SetProperty(ref _K12LeaId, value); }

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
        public Guid? RefBarrierToEducatingHomelessId { get => _RefBarrierToEducatingHomelessId; set => SetProperty(ref _RefBarrierToEducatingHomelessId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefIntegratedTechnologyStatusId"/> model
        /// </summary>
        public Guid? RefIntegratedTechnologyStatusId { get => _RefIntegratedTechnologyStatusId; set => SetProperty(ref _RefIntegratedTechnologyStatusId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IK12LeaFederalReporting model)
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
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
