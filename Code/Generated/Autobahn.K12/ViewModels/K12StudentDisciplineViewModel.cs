//**********************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12StudentDisciplineViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;
using CommunityToolkit.Maui;

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

        // member variable for the DisciplinaryActionEndDate property
        private System.DateTime? _DisciplinaryActionEndDate;

        // member variable for the DisciplinaryActionStartDate property
        private System.DateTime? _DisciplinaryActionStartDate;

        // member variable for the DurationOfDisciplinaryAction property
        private System.Decimal? _DurationOfDisciplinaryAction;

        // member variable for the EducationalServicesAfterRemoval property
        private System.Boolean? _EducationalServicesAfterRemoval;

        // member variable for the FullYearExpulsion property
        private System.Boolean? _FullYearExpulsion;

        // member variable for the IEPPlacementMeetingIndicator property
        private System.Boolean? _IEPPlacementMeetingIndicator;

        // member variable for the IncidentId property
        private Guid? _IncidentId;

        // member variable for the OrganizationPersonRoleId property
        private Guid _OrganizationPersonRoleId;

        // member variable for the RefDisciplinaryActionTakenId property
        private Guid? _RefDisciplinaryActionTakenId;

        // member variable for the RefDisciplineLengthDifferenceReasonId property
        private Guid? _RefDisciplineLengthDifferenceReasonId;

        // member variable for the RefDisciplineMethodFirearmsId property
        private Guid? _RefDisciplineMethodFirearmsId;

        // member variable for the RefDisciplineMethodOfCwdId property
        private Guid? _RefDisciplineMethodOfCwdId;

        // member variable for the RefDisciplineReasonId property
        private Guid? _RefDisciplineReasonId;

        // member variable for the RefIDEADisciplineMethodFirearmId property
        private Guid? _RefIDEADisciplineMethodFirearmId;

        // member variable for the RefIdeaInterimRemovalId property
        private Guid? _RefIdeaInterimRemovalId;

        // member variable for the RefIdeaInterimRemovalReasonId property
        private Guid? _RefIdeaInterimRemovalReasonId;

        // member variable for the RelatedToZeroTolerancePolicy property
        private System.Boolean? _RelatedToZeroTolerancePolicy;

        // member variable for the ShortenedExpulsion property
        private System.Boolean? _ShortenedExpulsion;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the K12StudentDisciplineViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// The year, month and day on which a discipline action ends.
        /// </summary>
        public System.DateTime? DisciplinaryActionEndDate { get => _DisciplinaryActionEndDate; set => SetProperty(ref _DisciplinaryActionEndDate, value); }

        /// <summary>
        /// The year, month and day on which a discipline action ends.
        /// </summary>
        public System.DateTime? DisciplinaryActionStartDate { get => _DisciplinaryActionStartDate; set => SetProperty(ref _DisciplinaryActionStartDate, value); }

        /// <summary>
        /// The year, month and day on which a discipline action ends.
        /// </summary>
        public System.Decimal? DurationOfDisciplinaryAction { get => _DurationOfDisciplinaryAction; set => SetProperty(ref _DurationOfDisciplinaryAction, value); }

        /// <summary>
        /// The year, month and day on which a discipline action ends.
        /// </summary>
        public System.Boolean? EducationalServicesAfterRemoval { get => _EducationalServicesAfterRemoval; set => SetProperty(ref _EducationalServicesAfterRemoval, value); }

        /// <summary>
        /// The year, month and day on which a discipline action ends.
        /// </summary>
        public System.Boolean? FullYearExpulsion { get => _FullYearExpulsion; set => SetProperty(ref _FullYearExpulsion, value); }

        /// <summary>
        /// The year, month and day on which a discipline action ends.
        /// </summary>
        public System.Boolean? IEPPlacementMeetingIndicator { get => _IEPPlacementMeetingIndicator; set => SetProperty(ref _IEPPlacementMeetingIndicator, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="Incident"/> model
        /// </summary>
        public Guid? IncidentId { get => _IncidentId; set => SetProperty(ref _IncidentId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="OrganizationPersonRole"/> model
        /// </summary>
        public Guid OrganizationPersonRoleId { get => _OrganizationPersonRoleId; set => SetProperty(ref _OrganizationPersonRoleId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefDisciplinaryActionTaken"/> model
        /// </summary>
        public Guid? RefDisciplinaryActionTakenId { get => _RefDisciplinaryActionTakenId; set => SetProperty(ref _RefDisciplinaryActionTakenId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefDisciplineLengthDifferenceReason"/> model
        /// </summary>
        public Guid? RefDisciplineLengthDifferenceReasonId { get => _RefDisciplineLengthDifferenceReasonId; set => SetProperty(ref _RefDisciplineLengthDifferenceReasonId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefDisciplineMethodFirearms"/> model
        /// </summary>
        public Guid? RefDisciplineMethodFirearmsId { get => _RefDisciplineMethodFirearmsId; set => SetProperty(ref _RefDisciplineMethodFirearmsId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefDisciplineMethodOfCwd"/> model
        /// </summary>
        public Guid? RefDisciplineMethodOfCwdId { get => _RefDisciplineMethodOfCwdId; set => SetProperty(ref _RefDisciplineMethodOfCwdId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefDisciplineReason"/> model
        /// </summary>
        public Guid? RefDisciplineReasonId { get => _RefDisciplineReasonId; set => SetProperty(ref _RefDisciplineReasonId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefIDEADisciplineMethodFirearm"/> model
        /// </summary>
        public Guid? RefIDEADisciplineMethodFirearmId { get => _RefIDEADisciplineMethodFirearmId; set => SetProperty(ref _RefIDEADisciplineMethodFirearmId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefeaInterimRemoval"/> model
        /// </summary>
        public Guid? RefIdeaInterimRemovalId { get => _RefIdeaInterimRemovalId; set => SetProperty(ref _RefIdeaInterimRemovalId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefeaInterimRemovalReason"/> model
        /// </summary>
        public Guid? RefIdeaInterimRemovalReasonId { get => _RefIdeaInterimRemovalReasonId; set => SetProperty(ref _RefIdeaInterimRemovalReasonId, value); }

        /// <summary>
        /// The year, month and day on which a discipline action ends.
        /// </summary>
        public System.Boolean? RelatedToZeroTolerancePolicy { get => _RelatedToZeroTolerancePolicy; set => SetProperty(ref _RelatedToZeroTolerancePolicy, value); }

        /// <summary>
        /// The year, month and day on which a discipline action ends.
        /// </summary>
        public System.Boolean? ShortenedExpulsion { get => _ShortenedExpulsion; set => SetProperty(ref _ShortenedExpulsion, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IK12StudentDiscipline model)
        {
            IsBusy = true;
            Id = model.Id;
            DisciplinaryActionEndDate = model.DisciplinaryActionEndDate;
            DisciplinaryActionStartDate = model.DisciplinaryActionStartDate;
            DurationOfDisciplinaryAction = model.DurationOfDisciplinaryAction;
            EducationalServicesAfterRemoval = model.EducationalServicesAfterRemoval;
            FullYearExpulsion = model.FullYearExpulsion;
            IEPPlacementMeetingIndicator = model.IEPPlacementMeetingIndicator;
            IncidentId = model.IncidentId;
            OrganizationPersonRoleId = model.OrganizationPersonRoleId;
            RefDisciplinaryActionTakenId = model.RefDisciplinaryActionTakenId;
            RefDisciplineLengthDifferenceReasonId = model.RefDisciplineLengthDifferenceReasonId;
            RefDisciplineMethodFirearmsId = model.RefDisciplineMethodFirearmsId;
            RefDisciplineMethodOfCwdId = model.RefDisciplineMethodOfCwdId;
            RefDisciplineReasonId = model.RefDisciplineReasonId;
            RefIDEADisciplineMethodFirearmId = model.RefIDEADisciplineMethodFirearmId;
            RefIdeaInterimRemovalId = model.RefIdeaInterimRemovalId;
            RefIdeaInterimRemovalReasonId = model.RefIdeaInterimRemovalReasonId;
            RelatedToZeroTolerancePolicy = model.RelatedToZeroTolerancePolicy;
            ShortenedExpulsion = model.ShortenedExpulsion;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
