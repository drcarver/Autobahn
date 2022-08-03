//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   K12StudentDisciplineViewModel.cs
//**********************************************************

using Prism.Mvvm;
using Autobahn.Common.Interfaces;
using Autobahn.Autobahn.K12.Interfaces;

namespace Autobahn.K12.ViewModels
{
     /// <summary>
     /// The K12StudentDisciplineViewModel
     /// </summary>
    public partial class K12StudentDisciplineViewModel : BindableBase, IK12StudentDiscipline
    {
#region "Backing Fields"
        // member variable for the DisciplinaryActionStartDate property
        private System.DateTime? _DisciplinaryActionStartDate;

        // member variable for the DisciplinaryActionEndDate property
        private System.DateTime? _DisciplinaryActionEndDate;

        // member variable for the DurationOfDisciplinaryAction property
        private System.Decimal? _DurationOfDisciplinaryAction;

        // member variable for the FullYearExpulsion property
        private System.Boolean? _FullYearExpulsion;

        // member variable for the ShortenedExpulsion property
        private System.Boolean? _ShortenedExpulsion;

        // member variable for the EducationalServicesAfterRemoval property
        private System.Boolean? _EducationalServicesAfterRemoval;

        // member variable for the RelatedToZeroTolerancePolicy property
        private System.Boolean? _RelatedToZeroTolerancePolicy;

        // member variable for the IEPPlacementMeetingIndicator property
        private System.Boolean? _IEPPlacementMeetingIndicator;

        // member variable for the RecordStartDateTime property
        private System.DateTime? _RecordStartDateTime;

        // member variable for the RecordEndDateTime property
        private System.DateTime? _RecordEndDateTime;

#endregion

#region Properties
        /// <summary>
        /// Reference to a required instance of the <see cref="OrganizationPersonRoleId"/> model
        /// </summary>
        public Guid OrganizationPersonRoleId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefDisciplineReasonId"/> model
        /// </summary>
        public Guid? RefDisciplineReasonId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefDisciplinaryActionTakenId"/> model
        /// </summary>
        public Guid? RefDisciplinaryActionTakenId { get; set; }

        public System.DateTime? DisciplinaryActionStartDate { get => _DisciplinaryActionStartDate; set => SetProperty(ref _DisciplinaryActionStartDate, value); }

        public System.DateTime? DisciplinaryActionEndDate { get => _DisciplinaryActionEndDate; set => SetProperty(ref _DisciplinaryActionEndDate, value); }

        public System.Decimal? DurationOfDisciplinaryAction { get => _DurationOfDisciplinaryAction; set => SetProperty(ref _DurationOfDisciplinaryAction, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefDisciplineLengthDifferenceReasonId"/> model
        /// </summary>
        public Guid? RefDisciplineLengthDifferenceReasonId { get; set; }

        public System.Boolean? FullYearExpulsion { get => _FullYearExpulsion; set => SetProperty(ref _FullYearExpulsion, value); }

        public System.Boolean? ShortenedExpulsion { get => _ShortenedExpulsion; set => SetProperty(ref _ShortenedExpulsion, value); }

        public System.Boolean? EducationalServicesAfterRemoval { get => _EducationalServicesAfterRemoval; set => SetProperty(ref _EducationalServicesAfterRemoval, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefIdeaInterimRemovalId"/> model
        /// </summary>
        public Guid? RefIdeaInterimRemovalId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefIdeaInterimRemovalReasonId"/> model
        /// </summary>
        public Guid? RefIdeaInterimRemovalReasonId { get; set; }

        public System.Boolean? RelatedToZeroTolerancePolicy { get => _RelatedToZeroTolerancePolicy; set => SetProperty(ref _RelatedToZeroTolerancePolicy, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IncidentId"/> model
        /// </summary>
        public Guid? IncidentId { get; set; }

        public System.Boolean? IEPPlacementMeetingIndicator { get => _IEPPlacementMeetingIndicator; set => SetProperty(ref _IEPPlacementMeetingIndicator, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefDisciplineMethodFirearmsId"/> model
        /// </summary>
        public Guid? RefDisciplineMethodFirearmsId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefDisciplineMethodOfCwdId"/> model
        /// </summary>
        public Guid? RefDisciplineMethodOfCwdId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefIDEADisciplineMethodFirearmId"/> model
        /// </summary>
        public Guid? RefIDEADisciplineMethodFirearmId { get; set; }

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
        public void Load(IK12StudentDiscipline model)
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
