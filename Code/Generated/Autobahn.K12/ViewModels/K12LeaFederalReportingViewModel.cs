//**********************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12LeaFederalReportingViewModel.cs
//***************************************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using Autobahn.Common.Models;
using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.K12.ViewModels
{
     /// <summary>
     /// The K12LeaFederalReporting View Model
     /// </summary>
    public partial class K12LeaFederalReportingViewModel : ViewModelBase, Interfaces.IK12LeaFederalReporting
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from K12LeaFederalReporting";

        // DesegregationOrderOrPlan -- (backing property for Desegregation Order or Plan)
        private System.Boolean? _DesegregationOrderOrPlan;

        // HarassmentOrBullyingPolicy -- (backing property for Harassment or Bullying Policy Status)
        private System.Boolean? _HarassmentOrBullyingPolicy;

        // InterscholasticSportParticipantsFemale -- (backing property for Interscholastic Sport Participants - Female Only)
        private System.Int32? _InterscholasticSportParticipantsFemale;

        // InterscholasticSportParticipantsMale -- (backing property for Interscholastic Sport Participants - Male Only)
        private System.Int32? _InterscholasticSportParticipantsMale;

        // InterscholasticSportsFemaleOnly -- (backing property for Interscholastic Sports - Female Only)
        private System.Int32? _InterscholasticSportsFemaleOnly;

        // InterscholasticSportsMaleOnly -- (backing property for Interscholastic Sports - Male Only)
        private System.Int32? _InterscholasticSportsMaleOnly;

        // InterscholasticTeamsFemaleOnly -- (backing property for Interscholastic Teams - Female Only)
        private System.Int32? _InterscholasticTeamsFemaleOnly;

        // InterscholasticTeamsMaleOnly -- (backing property for Interscholastic Teams - Male Only)
        private System.Int32? _InterscholasticTeamsMaleOnly;

        // member variable for the K12LeaId property
        private Guid _K12LeaId;

        // RefBarrierToEducatingHomelessId -- (backing property for Barrier to Educating Homeless)
        private Guid? _RefBarrierToEducatingHomelessId;

        // RefIntegratedTechnologyStatusId -- (backing property for Integrated Technology Status)
        private Guid? _RefIntegratedTechnologyStatusId;

        // StateAssessmentAdminFunding -- (backing property for State Assessment Administration Funding)
        private System.Decimal? _StateAssessmentAdminFunding;

        // StateAssessStandardsFunding -- (backing property for State Assessment Standards Funding)
        private System.Decimal? _StateAssessStandardsFunding;

        // TerminatedTitleIIIProgramFailure -- (backing property for Terminated Title III Programs Due to Failure)
        private System.Boolean? _TerminatedTitleIIIProgramFailure;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Desegregation Order or Plan
        /// <para>
        /// An indication whether the LEA is covered by a desegregation plan either ordered by a court or entered into with the Office for Civil Rights under Title VI of the Civil Rights Act of 1964.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19080">Desegregation Order or Plan</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.Boolean? DesegregationOrderOrPlan { get => _DesegregationOrderOrPlan; set => SetProperty(ref _DesegregationOrderOrPlan, value); }

        /// <summary>
        /// Harassment or Bullying Policy Status
        /// <para>
        /// An indication of whether the education unit has adopted written policy prohibiting harassment and bullying on the basis of a civil rights law.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19135">Harassment or Bullying Policy Status</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.Boolean? HarassmentOrBullyingPolicy { get => _HarassmentOrBullyingPolicy; set => SetProperty(ref _HarassmentOrBullyingPolicy, value); }

        /// <summary>
        /// Interscholastic Sport Participants - Female Only
        /// <para>
        /// The number of female students who participated on an interscholastic team.  A student should be counted once for each team she was on.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19665">Interscholastic Sport Participants - Female Only</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.Int32? InterscholasticSportParticipantsFemale { get => _InterscholasticSportParticipantsFemale; set => SetProperty(ref _InterscholasticSportParticipantsFemale, value); }

        /// <summary>
        /// Interscholastic Sport Participants - Male Only
        /// <para>
        /// The number of male students who participated on an interscholastic team.  A student should be counted once for each team he was on.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19664">Interscholastic Sport Participants - Male Only</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.Int32? InterscholasticSportParticipantsMale { get => _InterscholasticSportParticipantsMale; set => SetProperty(ref _InterscholasticSportParticipantsMale, value); }

        /// <summary>
        /// Interscholastic Sports - Female Only
        /// <para>
        /// The number of interscholastic sports in which only female students participate.  Sports include distinct sports such as football, basketball, soccer but not intramural sports or cheerleading.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19661">Interscholastic Sports - Female Only</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.Int32? InterscholasticSportsFemaleOnly { get => _InterscholasticSportsFemaleOnly; set => SetProperty(ref _InterscholasticSportsFemaleOnly, value); }

        /// <summary>
        /// Interscholastic Sports - Male Only
        /// <para>
        /// The number of interscholastic sports in which only male students participate.  Sports include distinct sports such as football, basketball, soccer but not intramural sports or cheerleading.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19660">Interscholastic Sports - Male Only</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.Int32? InterscholasticSportsMaleOnly { get => _InterscholasticSportsMaleOnly; set => SetProperty(ref _InterscholasticSportsMaleOnly, value); }

        /// <summary>
        /// Interscholastic Teams - Female Only
        /// <para>
        /// The number of interscholastic teams in which only female students participate.  Teams include each competitive level team in each sport, such as freshman team, junior varsity team, and varsity team but not intramural sports or cheerleading.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19663">Interscholastic Teams - Female Only</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.Int32? InterscholasticTeamsFemaleOnly { get => _InterscholasticTeamsFemaleOnly; set => SetProperty(ref _InterscholasticTeamsFemaleOnly, value); }

        /// <summary>
        /// Interscholastic Teams - Male Only
        /// <para>
        /// The number of interscholastic teams in which only male students participate.  Teams include each competitive level team in each sport, such as freshman team, junior varsity team, and varsity team but not intramural sports or cheerleading.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19662">Interscholastic Teams - Male Only</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.Int32? InterscholasticTeamsMaleOnly { get => _InterscholasticTeamsMaleOnly; set => SetProperty(ref _InterscholasticTeamsMaleOnly, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IK12Lea"/> model
        /// </summary>
        public Guid K12LeaId { get => _K12LeaId; set => SetProperty(ref _K12LeaId, value); }

        /// <summary>
        /// Barrier to Educating Homeless
        /// <para>
        /// Barriers to the enrollment and success of homeless children and youths.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19439">Barrier to Educating Homeless</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefBarrierToEducatingHomelessId { get => _RefBarrierToEducatingHomelessId; set => SetProperty(ref _RefBarrierToEducatingHomelessId, value); }

        /// <summary>
        /// Integrated Technology Status
        /// <para>
        /// An indication of the extent to which the district has effectively and fully integrated technology, as defined by the state.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19170">Integrated Technology Status</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefIntegratedTechnologyStatusId { get => _RefIntegratedTechnologyStatusId; set => SetProperty(ref _RefIntegratedTechnologyStatusId, value); }

        /// <summary>
        /// State Assessment Administration Funding
        /// <para>
        /// The percentage of funds used to administer assessments required by section 1111(b) or to carry out other activities described in section 6111 and other activities related to ensuring that the State's schools and local educational agencies are held accountable for results.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19444">State Assessment Administration Funding</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.Decimal? StateAssessmentAdminFunding { get => _StateAssessmentAdminFunding; set => SetProperty(ref _StateAssessmentAdminFunding, value); }

        /// <summary>
        /// State Assessment Standards Funding
        /// <para>
        /// The percentage of funds used to pay the costs of the development of the State assessments and standards required by section 1111(b).
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19443">State Assessment Standards Funding</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.Decimal? StateAssessStandardsFunding { get => _StateAssessStandardsFunding; set => SetProperty(ref _StateAssessStandardsFunding, value); }

        /// <summary>
        /// Terminated Title III Programs Due to Failure
        /// <para>
        /// An indication of whether a Title III program or activity was terminated due to failure to meet goals.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19473">Terminated Title III Programs Due to Failure</a>
        /// </para>
        /// </summary>
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
            DesegregationOrderOrPlan = model.DesegregationOrderOrPlan; // Desegregation Order or Plan
            HarassmentOrBullyingPolicy = model.HarassmentOrBullyingPolicy; // Harassment or Bullying Policy Status
            InterscholasticSportParticipantsFemale = model.InterscholasticSportParticipantsFemale; // Interscholastic Sport Participants - Female Only
            InterscholasticSportParticipantsMale = model.InterscholasticSportParticipantsMale; // Interscholastic Sport Participants - Male Only
            InterscholasticSportsFemaleOnly = model.InterscholasticSportsFemaleOnly; // Interscholastic Sports - Female Only
            InterscholasticSportsMaleOnly = model.InterscholasticSportsMaleOnly; // Interscholastic Sports - Male Only
            InterscholasticTeamsFemaleOnly = model.InterscholasticTeamsFemaleOnly; // Interscholastic Teams - Female Only
            InterscholasticTeamsMaleOnly = model.InterscholasticTeamsMaleOnly; // Interscholastic Teams - Male Only
            K12LeaId = model.K12LeaId; // 
            RefBarrierToEducatingHomelessId = model.RefBarrierToEducatingHomelessId; // Barrier to Educating Homeless
            RefIntegratedTechnologyStatusId = model.RefIntegratedTechnologyStatusId; // Integrated Technology Status
            StateAssessmentAdminFunding = model.StateAssessmentAdminFunding; // State Assessment Administration Funding
            StateAssessStandardsFunding = model.StateAssessStandardsFunding; // State Assessment Standards Funding
            TerminatedTitleIIIProgramFailure = model.TerminatedTitleIIIProgramFailure; // Terminated Title III Programs Due to Failure
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
