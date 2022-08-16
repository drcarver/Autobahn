//**********************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12LeaFederalReportingViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.K12.ViewModels
{
     /// <summary>
     /// The K12LeaFederalReportingViewModel
     /// </summary>
    public partial class K12LeaFederalReportingViewModel : ViewModelBase, Interfaces.IK12LeaFederalReporting
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from K12LeaFederalReporting";

        // member variable for the DesegregationOrderOrPlan property
        private Guid? _DesegregationOrderOrPlan;

        // member variable for the HarassmentOrBullyingPolicy property
        private  _HarassmentOrBullyingPolicy;

        // member variable for the InterscholasticSportParticipantsFemale property
        private  _InterscholasticSportParticipantsFemale;

        // member variable for the InterscholasticSportParticipantsMale property
        private  _InterscholasticSportParticipantsMale;

        // member variable for the InterscholasticSportsFemaleOnly property
        private  _InterscholasticSportsFemaleOnly;

        // member variable for the InterscholasticSportsMaleOnly property
        private  _InterscholasticSportsMaleOnly;

        // member variable for the InterscholasticTeamsFemaleOnly property
        private  _InterscholasticTeamsFemaleOnly;

        // member variable for the InterscholasticTeamsMaleOnly property
        private  _InterscholasticTeamsMaleOnly;

        // member variable for the RecordEndDateTime property
        private  _RecordEndDateTime;

        // member variable for the RecordStartDateTime property
        private  _RecordStartDateTime;

        // member variable for the RefBarrierToEducatingHomelessId property
        private  _RefBarrierToEducatingHomelessId;

        // member variable for the RefIntegratedTechnologyStatusId property
        private  _RefIntegratedTechnologyStatusId;

        // member variable for the StateAssessmentAdminFunding property
        private  _StateAssessmentAdminFunding;

        // member variable for the StateAssessStandardsFunding property
        private  _StateAssessStandardsFunding;

        // member variable for the TerminatedTitleIIIProgramFailure property
        private  _TerminatedTitleIIIProgramFailure;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// </summary>
        public Guid? DesegregationOrderOrPlan { get => _DesegregationOrderOrPlan; set => SetProperty(ref _DesegregationOrderOrPlan, value); }

        /// <summary>
        /// </summary>
        public  HarassmentOrBullyingPolicy { get => _HarassmentOrBullyingPolicy; set => SetProperty(ref _HarassmentOrBullyingPolicy, value); }

        /// <summary>
        /// </summary>
        public  InterscholasticSportParticipantsFemale { get => _InterscholasticSportParticipantsFemale; set => SetProperty(ref _InterscholasticSportParticipantsFemale, value); }

        /// <summary>
        /// </summary>
        public  InterscholasticSportParticipantsMale { get => _InterscholasticSportParticipantsMale; set => SetProperty(ref _InterscholasticSportParticipantsMale, value); }

        /// <summary>
        /// </summary>
        public  InterscholasticSportsFemaleOnly { get => _InterscholasticSportsFemaleOnly; set => SetProperty(ref _InterscholasticSportsFemaleOnly, value); }

        /// <summary>
        /// </summary>
        public  InterscholasticSportsMaleOnly { get => _InterscholasticSportsMaleOnly; set => SetProperty(ref _InterscholasticSportsMaleOnly, value); }

        /// <summary>
        /// </summary>
        public  InterscholasticTeamsFemaleOnly { get => _InterscholasticTeamsFemaleOnly; set => SetProperty(ref _InterscholasticTeamsFemaleOnly, value); }

        /// <summary>
        /// </summary>
        public  InterscholasticTeamsMaleOnly { get => _InterscholasticTeamsMaleOnly; set => SetProperty(ref _InterscholasticTeamsMaleOnly, value); }

        /// <summary>
        /// </summary>
        public  RecordEndDateTime { get => _RecordEndDateTime; set => SetProperty(ref _RecordEndDateTime, value); }

        /// <summary>
        /// </summary>
        public  RecordStartDateTime { get => _RecordStartDateTime; set => SetProperty(ref _RecordStartDateTime, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefBarrierToEducatingHomeless"/> model
        /// </summary>
        public  RefBarrierToEducatingHomelessId { get => _RefBarrierToEducatingHomelessId; set => SetProperty(ref _RefBarrierToEducatingHomelessId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefIntegratedTechnologyStatus"/> model
        /// </summary>
        public  RefIntegratedTechnologyStatusId { get => _RefIntegratedTechnologyStatusId; set => SetProperty(ref _RefIntegratedTechnologyStatusId, value); }

        /// <summary>
        /// </summary>
        public  StateAssessmentAdminFunding { get => _StateAssessmentAdminFunding; set => SetProperty(ref _StateAssessmentAdminFunding, value); }

        /// <summary>
        /// </summary>
        public  StateAssessStandardsFunding { get => _StateAssessStandardsFunding; set => SetProperty(ref _StateAssessStandardsFunding, value); }

        /// <summary>
        /// </summary>
        public  TerminatedTitleIIIProgramFailure { get => _TerminatedTitleIIIProgramFailure; set => SetProperty(ref _TerminatedTitleIIIProgramFailure, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IK12LeaFederalReporting model)
        {
            IsBusy = true;
            Id = model.Id;
            DesegregationOrderOrPlan = model.DesegregationOrderOrPlan; // 
            HarassmentOrBullyingPolicy = model.HarassmentOrBullyingPolicy; // 
            InterscholasticSportParticipantsFemale = model.InterscholasticSportParticipantsFemale; // 
            InterscholasticSportParticipantsMale = model.InterscholasticSportParticipantsMale; // 
            InterscholasticSportsFemaleOnly = model.InterscholasticSportsFemaleOnly; // 
            InterscholasticSportsMaleOnly = model.InterscholasticSportsMaleOnly; // 
            InterscholasticTeamsFemaleOnly = model.InterscholasticTeamsFemaleOnly; // 
            InterscholasticTeamsMaleOnly = model.InterscholasticTeamsMaleOnly; // 
            RecordEndDateTime = model.RecordEndDateTime; // 
            RecordStartDateTime = model.RecordStartDateTime; // 
            RefBarrierToEducatingHomelessId = model.RefBarrierToEducatingHomelessId; // 
            RefIntegratedTechnologyStatusId = model.RefIntegratedTechnologyStatusId; // 
            StateAssessmentAdminFunding = model.StateAssessmentAdminFunding; // 
            StateAssessStandardsFunding = model.StateAssessStandardsFunding; // 
            TerminatedTitleIIIProgramFailure = model.TerminatedTitleIIIProgramFailure; // 
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
