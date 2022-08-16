//**********************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12StudentDisciplineViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

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
        private Guid? _DisciplinaryActionEndDate;

        // member variable for the DisciplinaryActionStartDate property
        private  _DisciplinaryActionStartDate;

        // member variable for the DurationOfDisciplinaryAction property
        private  _DurationOfDisciplinaryAction;

        // member variable for the EducationalServicesAfterRemoval property
        private  _EducationalServicesAfterRemoval;

        // member variable for the FullYearExpulsion property
        private  _FullYearExpulsion;

        // member variable for the IEPPlacementMeetingIndicator property
        private  _IEPPlacementMeetingIndicator;

        // member variable for the RecordEndDateTime property
        private  _RecordEndDateTime;

        // member variable for the RecordStartDateTime property
        private  _RecordStartDateTime;

        // member variable for the RefDisciplinaryActionTakenId property
        private  _RefDisciplinaryActionTakenId;

        // member variable for the RefDisciplineLengthDifferenceReasonId property
        private  _RefDisciplineLengthDifferenceReasonId;

        // member variable for the RefDisciplineMethodFirearmsId property
        private  _RefDisciplineMethodFirearmsId;

        // member variable for the RefDisciplineMethodOfCwdId property
        private  _RefDisciplineMethodOfCwdId;

        // member variable for the RefDisciplineReasonId property
        private  _RefDisciplineReasonId;

        // member variable for the RefIDEADisciplineMethodFirearmId property
        private  _RefIDEADisciplineMethodFirearmId;

        // member variable for the RefIdeaInterimRemovalId property
        private  _RefIdeaInterimRemovalId;

        // member variable for the RefIdeaInterimRemovalReasonId property
        private  _RefIdeaInterimRemovalReasonId;

        // member variable for the RelatedToZeroTolerancePolicy property
        private  _RelatedToZeroTolerancePolicy;

        // member variable for the ShortenedExpulsion property
        private  _ShortenedExpulsion;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// </summary>
        public Guid? DisciplinaryActionEndDate { get => _DisciplinaryActionEndDate; set => SetProperty(ref _DisciplinaryActionEndDate, value); }

        /// <summary>
        /// </summary>
        public  DisciplinaryActionStartDate { get => _DisciplinaryActionStartDate; set => SetProperty(ref _DisciplinaryActionStartDate, value); }

        /// <summary>
        /// </summary>
        public  DurationOfDisciplinaryAction { get => _DurationOfDisciplinaryAction; set => SetProperty(ref _DurationOfDisciplinaryAction, value); }

        /// <summary>
        /// </summary>
        public  EducationalServicesAfterRemoval { get => _EducationalServicesAfterRemoval; set => SetProperty(ref _EducationalServicesAfterRemoval, value); }

        /// <summary>
        /// </summary>
        public  FullYearExpulsion { get => _FullYearExpulsion; set => SetProperty(ref _FullYearExpulsion, value); }

        /// <summary>
        /// </summary>
        public  IEPPlacementMeetingIndicator { get => _IEPPlacementMeetingIndicator; set => SetProperty(ref _IEPPlacementMeetingIndicator, value); }

        /// <summary>
        /// </summary>
        public  RecordEndDateTime { get => _RecordEndDateTime; set => SetProperty(ref _RecordEndDateTime, value); }

        /// <summary>
        /// </summary>
        public  RecordStartDateTime { get => _RecordStartDateTime; set => SetProperty(ref _RecordStartDateTime, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefDisciplinaryActionTaken"/> model
        /// </summary>
        public  RefDisciplinaryActionTakenId { get => _RefDisciplinaryActionTakenId; set => SetProperty(ref _RefDisciplinaryActionTakenId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefDisciplineLengthDifferenceReason"/> model
        /// </summary>
        public  RefDisciplineLengthDifferenceReasonId { get => _RefDisciplineLengthDifferenceReasonId; set => SetProperty(ref _RefDisciplineLengthDifferenceReasonId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefDisciplineMethodFirearms"/> model
        /// </summary>
        public  RefDisciplineMethodFirearmsId { get => _RefDisciplineMethodFirearmsId; set => SetProperty(ref _RefDisciplineMethodFirearmsId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefDisciplineMethodOfCwd"/> model
        /// </summary>
        public  RefDisciplineMethodOfCwdId { get => _RefDisciplineMethodOfCwdId; set => SetProperty(ref _RefDisciplineMethodOfCwdId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefDisciplineReason"/> model
        /// </summary>
        public  RefDisciplineReasonId { get => _RefDisciplineReasonId; set => SetProperty(ref _RefDisciplineReasonId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefIDEADisciplineMethodFirearm"/> model
        /// </summary>
        public  RefIDEADisciplineMethodFirearmId { get => _RefIDEADisciplineMethodFirearmId; set => SetProperty(ref _RefIDEADisciplineMethodFirearmId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefeaInterimRemoval"/> model
        /// </summary>
        public  RefIdeaInterimRemovalId { get => _RefIdeaInterimRemovalId; set => SetProperty(ref _RefIdeaInterimRemovalId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefeaInterimRemovalReason"/> model
        /// </summary>
        public  RefIdeaInterimRemovalReasonId { get => _RefIdeaInterimRemovalReasonId; set => SetProperty(ref _RefIdeaInterimRemovalReasonId, value); }

        /// <summary>
        /// </summary>
        public  RelatedToZeroTolerancePolicy { get => _RelatedToZeroTolerancePolicy; set => SetProperty(ref _RelatedToZeroTolerancePolicy, value); }

        /// <summary>
        /// </summary>
        public  ShortenedExpulsion { get => _ShortenedExpulsion; set => SetProperty(ref _ShortenedExpulsion, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IK12StudentDiscipline model)
        {
            IsBusy = true;
            Id = model.Id;
            DisciplinaryActionEndDate = model.DisciplinaryActionEndDate; // 
            DisciplinaryActionStartDate = model.DisciplinaryActionStartDate; // 
            DurationOfDisciplinaryAction = model.DurationOfDisciplinaryAction; // 
            EducationalServicesAfterRemoval = model.EducationalServicesAfterRemoval; // 
            FullYearExpulsion = model.FullYearExpulsion; // 
            IEPPlacementMeetingIndicator = model.IEPPlacementMeetingIndicator; // 
            RecordEndDateTime = model.RecordEndDateTime; // 
            RecordStartDateTime = model.RecordStartDateTime; // 
            RefDisciplinaryActionTakenId = model.RefDisciplinaryActionTakenId; // 
            RefDisciplineLengthDifferenceReasonId = model.RefDisciplineLengthDifferenceReasonId; // 
            RefDisciplineMethodFirearmsId = model.RefDisciplineMethodFirearmsId; // 
            RefDisciplineMethodOfCwdId = model.RefDisciplineMethodOfCwdId; // 
            RefDisciplineReasonId = model.RefDisciplineReasonId; // 
            RefIDEADisciplineMethodFirearmId = model.RefIDEADisciplineMethodFirearmId; // 
            RefIdeaInterimRemovalId = model.RefIdeaInterimRemovalId; // 
            RefIdeaInterimRemovalReasonId = model.RefIdeaInterimRemovalReasonId; // 
            RelatedToZeroTolerancePolicy = model.RelatedToZeroTolerancePolicy; // 
            ShortenedExpulsion = model.ShortenedExpulsion; // 
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
