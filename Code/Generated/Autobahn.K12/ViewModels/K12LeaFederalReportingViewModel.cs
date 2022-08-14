//**********************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12LeaFederalReportingViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

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
        private System.Boolean? _DesegregationOrderOrPlan;

        // member variable for the HarassmentOrBullyingPolicy property
        private System.Boolean? _HarassmentOrBullyingPolicy;

        // member variable for the InterscholasticSportParticipantsFemale property
        private System.Int32? _InterscholasticSportParticipantsFemale;

        // member variable for the InterscholasticSportParticipantsMale property
        private System.Int32? _InterscholasticSportParticipantsMale;

        // member variable for the InterscholasticSportsFemaleOnly property
        private System.Int32? _InterscholasticSportsFemaleOnly;

        // member variable for the InterscholasticSportsMaleOnly property
        private System.Int32? _InterscholasticSportsMaleOnly;

        // member variable for the InterscholasticTeamsFemaleOnly property
        private System.Int32? _InterscholasticTeamsFemaleOnly;

        // member variable for the InterscholasticTeamsMaleOnly property
        private System.Int32? _InterscholasticTeamsMaleOnly;

        // member variable for the K12LeaId property
        private Guid _K12LeaId;

        // member variable for the RefBarrierToEducatingHomelessId property
        private Guid? _RefBarrierToEducatingHomelessId;

        // member variable for the RefIntegratedTechnologyStatusId property
        private Guid? _RefIntegratedTechnologyStatusId;

        // member variable for the StateAssessmentAdminFunding property
        private System.Decimal? _StateAssessmentAdminFunding;

        // member variable for the StateAssessStandardsFunding property
        private System.Decimal? _StateAssessStandardsFunding;

        // member variable for the TerminatedTitleIIIProgramFailure property
        private System.Boolean? _TerminatedTitleIIIProgramFailure;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the K12LeaFederalReportingViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// An indication whether the LEA is covered by a desegregation plan either ordered by a court or entered into with the Office for Civil Rights under Title VI of the Civil Rights Act of 1964.
        /// </summary>
        public System.Boolean? DesegregationOrderOrPlan { get => _DesegregationOrderOrPlan; set => SetProperty(ref _DesegregationOrderOrPlan, value); }

        /// <summary>
        /// An indication whether the LEA is covered by a desegregation plan either ordered by a court or entered into with the Office for Civil Rights under Title VI of the Civil Rights Act of 1964.
        /// </summary>
        public System.Boolean? HarassmentOrBullyingPolicy { get => _HarassmentOrBullyingPolicy; set => SetProperty(ref _HarassmentOrBullyingPolicy, value); }

        /// <summary>
        /// An indication whether the LEA is covered by a desegregation plan either ordered by a court or entered into with the Office for Civil Rights under Title VI of the Civil Rights Act of 1964.
        /// </summary>
        public System.Int32? InterscholasticSportParticipantsFemale { get => _InterscholasticSportParticipantsFemale; set => SetProperty(ref _InterscholasticSportParticipantsFemale, value); }

        /// <summary>
        /// An indication whether the LEA is covered by a desegregation plan either ordered by a court or entered into with the Office for Civil Rights under Title VI of the Civil Rights Act of 1964.
        /// </summary>
        public System.Int32? InterscholasticSportParticipantsMale { get => _InterscholasticSportParticipantsMale; set => SetProperty(ref _InterscholasticSportParticipantsMale, value); }

        /// <summary>
        /// An indication whether the LEA is covered by a desegregation plan either ordered by a court or entered into with the Office for Civil Rights under Title VI of the Civil Rights Act of 1964.
        /// </summary>
        public System.Int32? InterscholasticSportsFemaleOnly { get => _InterscholasticSportsFemaleOnly; set => SetProperty(ref _InterscholasticSportsFemaleOnly, value); }

        /// <summary>
        /// An indication whether the LEA is covered by a desegregation plan either ordered by a court or entered into with the Office for Civil Rights under Title VI of the Civil Rights Act of 1964.
        /// </summary>
        public System.Int32? InterscholasticSportsMaleOnly { get => _InterscholasticSportsMaleOnly; set => SetProperty(ref _InterscholasticSportsMaleOnly, value); }

        /// <summary>
        /// An indication whether the LEA is covered by a desegregation plan either ordered by a court or entered into with the Office for Civil Rights under Title VI of the Civil Rights Act of 1964.
        /// </summary>
        public System.Int32? InterscholasticTeamsFemaleOnly { get => _InterscholasticTeamsFemaleOnly; set => SetProperty(ref _InterscholasticTeamsFemaleOnly, value); }

        /// <summary>
        /// An indication whether the LEA is covered by a desegregation plan either ordered by a court or entered into with the Office for Civil Rights under Title VI of the Civil Rights Act of 1964.
        /// </summary>
        public System.Int32? InterscholasticTeamsMaleOnly { get => _InterscholasticTeamsMaleOnly; set => SetProperty(ref _InterscholasticTeamsMaleOnly, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="K12Lea"/> model
        /// </summary>
        public Guid K12LeaId { get => _K12LeaId; set => SetProperty(ref _K12LeaId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefBarrierToEducatingHomeless"/> model
        /// </summary>
        public Guid? RefBarrierToEducatingHomelessId { get => _RefBarrierToEducatingHomelessId; set => SetProperty(ref _RefBarrierToEducatingHomelessId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefIntegratedTechnologyStatus"/> model
        /// </summary>
        public Guid? RefIntegratedTechnologyStatusId { get => _RefIntegratedTechnologyStatusId; set => SetProperty(ref _RefIntegratedTechnologyStatusId, value); }

        /// <summary>
        /// An indication whether the LEA is covered by a desegregation plan either ordered by a court or entered into with the Office for Civil Rights under Title VI of the Civil Rights Act of 1964.
        /// </summary>
        public System.Decimal? StateAssessmentAdminFunding { get => _StateAssessmentAdminFunding; set => SetProperty(ref _StateAssessmentAdminFunding, value); }

        /// <summary>
        /// An indication whether the LEA is covered by a desegregation plan either ordered by a court or entered into with the Office for Civil Rights under Title VI of the Civil Rights Act of 1964.
        /// </summary>
        public System.Decimal? StateAssessStandardsFunding { get => _StateAssessStandardsFunding; set => SetProperty(ref _StateAssessStandardsFunding, value); }

        /// <summary>
        /// An indication whether the LEA is covered by a desegregation plan either ordered by a court or entered into with the Office for Civil Rights under Title VI of the Civil Rights Act of 1964.
        /// </summary>
        public System.Boolean? TerminatedTitleIIIProgramFailure { get => _TerminatedTitleIIIProgramFailure; set => SetProperty(ref _TerminatedTitleIIIProgramFailure, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IK12LeaFederalReporting model)
        {
            IsBusy = true;
            Id = model.Id;
            DesegregationOrderOrPlan = model.DesegregationOrderOrPlan;
            HarassmentOrBullyingPolicy = model.HarassmentOrBullyingPolicy;
            InterscholasticSportParticipantsFemale = model.InterscholasticSportParticipantsFemale;
            InterscholasticSportParticipantsMale = model.InterscholasticSportParticipantsMale;
            InterscholasticSportsFemaleOnly = model.InterscholasticSportsFemaleOnly;
            InterscholasticSportsMaleOnly = model.InterscholasticSportsMaleOnly;
            InterscholasticTeamsFemaleOnly = model.InterscholasticTeamsFemaleOnly;
            InterscholasticTeamsMaleOnly = model.InterscholasticTeamsMaleOnly;
            K12LeaId = model.K12LeaId;
            RefBarrierToEducatingHomelessId = model.RefBarrierToEducatingHomelessId;
            RefIntegratedTechnologyStatusId = model.RefIntegratedTechnologyStatusId;
            StateAssessmentAdminFunding = model.StateAssessmentAdminFunding;
            StateAssessStandardsFunding = model.StateAssessStandardsFunding;
            TerminatedTitleIIIProgramFailure = model.TerminatedTitleIIIProgramFailure;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
