//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   K12StudentDisciplineViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

namespace Autobahn.K12.ViewModels
{
     /// <summary>
     /// The K12StudentDisciplineViewModel
     /// </summary>
    public partial class K12StudentDisciplineViewModel : ViewModelBase, Interfaces.IK12StudentDiscipline
    {
#region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from K12StudentDiscipline";

        // member variable for the OrganizationPersonRoleId property
        private Guid _OrganizationPersonRoleId;

        // member variable for the RefDisciplineReasonId property
        private Guid? _RefDisciplineReasonId;

        // member variable for the RefDisciplinaryActionTakenId property
        private Guid? _RefDisciplinaryActionTakenId;

        // member variable for the DisciplinaryActionStartDate property
        private System.DateTime? _DisciplinaryActionStartDate;

        // member variable for the DisciplinaryActionEndDate property
        private System.DateTime? _DisciplinaryActionEndDate;

        // member variable for the DurationOfDisciplinaryAction property
        private System.Decimal? _DurationOfDisciplinaryAction;

        // member variable for the RefDisciplineLengthDifferenceReasonId property
        private Guid? _RefDisciplineLengthDifferenceReasonId;

        // member variable for the FullYearExpulsion property
        private System.Boolean? _FullYearExpulsion;

        // member variable for the ShortenedExpulsion property
        private System.Boolean? _ShortenedExpulsion;

        // member variable for the EducationalServicesAfterRemoval property
        private System.Boolean? _EducationalServicesAfterRemoval;

        // member variable for the RefIdeaInterimRemovalId property
        private Guid? _RefIdeaInterimRemovalId;

        // member variable for the RefIdeaInterimRemovalReasonId property
        private Guid? _RefIdeaInterimRemovalReasonId;

        // member variable for the RelatedToZeroTolerancePolicy property
        private System.Boolean? _RelatedToZeroTolerancePolicy;

        // member variable for the IncidentId property
        private Guid? _IncidentId;

        // member variable for the IEPPlacementMeetingIndicator property
        private System.Boolean? _IEPPlacementMeetingIndicator;

        // member variable for the RefDisciplineMethodFirearmsId property
        private Guid? _RefDisciplineMethodFirearmsId;

        // member variable for the RefDisciplineMethodOfCwdId property
        private Guid? _RefDisciplineMethodOfCwdId;

        // member variable for the RefIDEADisciplineMethodFirearmId property
        private Guid? _RefIDEADisciplineMethodFirearmId;

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
        /// The title of the K12StudentDisciplineViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="OrganizationPersonRoleId"/> model
        /// </summary>
        public Guid OrganizationPersonRoleId { get => _OrganizationPersonRoleId; set => SetProperty(ref _OrganizationPersonRoleId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefDisciplineReasonId"/> model
        /// </summary>
        public Guid? RefDisciplineReasonId { get => _RefDisciplineReasonId; set => SetProperty(ref _RefDisciplineReasonId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefDisciplinaryActionTakenId"/> model
        /// </summary>
        public Guid? RefDisciplinaryActionTakenId { get => _RefDisciplinaryActionTakenId; set => SetProperty(ref _RefDisciplinaryActionTakenId, value); }

        public System.DateTime? DisciplinaryActionStartDate { get => _DisciplinaryActionStartDate; set => SetProperty(ref _DisciplinaryActionStartDate, value); }

        public System.DateTime? DisciplinaryActionEndDate { get => _DisciplinaryActionEndDate; set => SetProperty(ref _DisciplinaryActionEndDate, value); }

        public System.Decimal? DurationOfDisciplinaryAction { get => _DurationOfDisciplinaryAction; set => SetProperty(ref _DurationOfDisciplinaryAction, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefDisciplineLengthDifferenceReasonId"/> model
        /// </summary>
        public Guid? RefDisciplineLengthDifferenceReasonId { get => _RefDisciplineLengthDifferenceReasonId; set => SetProperty(ref _RefDisciplineLengthDifferenceReasonId, value); }

        public System.Boolean? FullYearExpulsion { get => _FullYearExpulsion; set => SetProperty(ref _FullYearExpulsion, value); }

        public System.Boolean? ShortenedExpulsion { get => _ShortenedExpulsion; set => SetProperty(ref _ShortenedExpulsion, value); }

        public System.Boolean? EducationalServicesAfterRemoval { get => _EducationalServicesAfterRemoval; set => SetProperty(ref _EducationalServicesAfterRemoval, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefIdeaInterimRemovalId"/> model
        /// </summary>
        public Guid? RefIdeaInterimRemovalId { get => _RefIdeaInterimRemovalId; set => SetProperty(ref _RefIdeaInterimRemovalId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefIdeaInterimRemovalReasonId"/> model
        /// </summary>
        public Guid? RefIdeaInterimRemovalReasonId { get => _RefIdeaInterimRemovalReasonId; set => SetProperty(ref _RefIdeaInterimRemovalReasonId, value); }

        public System.Boolean? RelatedToZeroTolerancePolicy { get => _RelatedToZeroTolerancePolicy; set => SetProperty(ref _RelatedToZeroTolerancePolicy, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IncidentId"/> model
        /// </summary>
        public Guid? IncidentId { get => _IncidentId; set => SetProperty(ref _IncidentId, value); }

        public System.Boolean? IEPPlacementMeetingIndicator { get => _IEPPlacementMeetingIndicator; set => SetProperty(ref _IEPPlacementMeetingIndicator, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefDisciplineMethodFirearmsId"/> model
        /// </summary>
        public Guid? RefDisciplineMethodFirearmsId { get => _RefDisciplineMethodFirearmsId; set => SetProperty(ref _RefDisciplineMethodFirearmsId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefDisciplineMethodOfCwdId"/> model
        /// </summary>
        public Guid? RefDisciplineMethodOfCwdId { get => _RefDisciplineMethodOfCwdId; set => SetProperty(ref _RefDisciplineMethodOfCwdId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefIDEADisciplineMethodFirearmId"/> model
        /// </summary>
        public Guid? RefIDEADisciplineMethodFirearmId { get => _RefIDEADisciplineMethodFirearmId; set => SetProperty(ref _RefIDEADisciplineMethodFirearmId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IK12StudentDiscipline model)
        {
            IsBusy = true;
            Id = model.Id;
            OrganizationPersonRoleId = model.OrganizationPersonRoleId;
            RefDisciplineReasonId = model.RefDisciplineReasonId;
            RefDisciplinaryActionTakenId = model.RefDisciplinaryActionTakenId;
            DisciplinaryActionStartDate = model.DisciplinaryActionStartDate;
            DisciplinaryActionEndDate = model.DisciplinaryActionEndDate;
            DurationOfDisciplinaryAction = model.DurationOfDisciplinaryAction;
            RefDisciplineLengthDifferenceReasonId = model.RefDisciplineLengthDifferenceReasonId;
            FullYearExpulsion = model.FullYearExpulsion;
            ShortenedExpulsion = model.ShortenedExpulsion;
            EducationalServicesAfterRemoval = model.EducationalServicesAfterRemoval;
            RefIdeaInterimRemovalId = model.RefIdeaInterimRemovalId;
            RefIdeaInterimRemovalReasonId = model.RefIdeaInterimRemovalReasonId;
            RelatedToZeroTolerancePolicy = model.RelatedToZeroTolerancePolicy;
            IncidentId = model.IncidentId;
            IEPPlacementMeetingIndicator = model.IEPPlacementMeetingIndicator;
            RefDisciplineMethodFirearmsId = model.RefDisciplineMethodFirearmsId;
            RefDisciplineMethodOfCwdId = model.RefDisciplineMethodOfCwdId;
            RefIDEADisciplineMethodFirearmId = model.RefIDEADisciplineMethodFirearmId;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
