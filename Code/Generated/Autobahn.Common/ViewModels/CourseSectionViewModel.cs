//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   CourseSectionViewModel.cs
//**********************************************************


namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The CourseSectionViewModel
     /// </summary>
    public partial class CourseSectionViewModel : ViewModelBase, Interfaces.ICourseSection
    {
#region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from CourseSection";

        // member variable for the OrganizationId property
        private Guid _OrganizationId;

        // member variable for the CourseId property
        private Guid _CourseId;

        // member variable for the AvailableCarnegieUnitCredit property
        private System.Decimal? _AvailableCarnegieUnitCredit;

        // member variable for the TimeRequiredForCompletion property
        private System.Decimal? _TimeRequiredForCompletion;

        // member variable for the VirtualIndicator property
        private System.Boolean? _VirtualIndicator;

        // member variable for the OrganizationCalendarSessionId property
        private Guid? _OrganizationCalendarSessionId;

        // member variable for the MaximumCapacity property
        private System.Int32? _MaximumCapacity;

        // member variable for the RelatedCompetencyDefinitions property
        private System.String _RelatedCompetencyDefinitions;

        // member variable for the RefCourseSectionDeliveryModeId property
        private Guid? _RefCourseSectionDeliveryModeId;

        // member variable for the RefSingleSexClassStatusId property
        private Guid? _RefSingleSexClassStatusId;

        // member variable for the RefAdditionalCreditTypeId property
        private Guid? _RefAdditionalCreditTypeId;

        // member variable for the RefInstructionLanguageId property
        private Guid? _RefInstructionLanguageId;

        // member variable for the RefCreditTypeEarnedId property
        private Guid? _RefCreditTypeEarnedId;

        // member variable for the RefAdvancedPlacementCourseCodeId property
        private Guid? _RefAdvancedPlacementCourseCodeId;

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
        /// The title of the CourseSectionViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="OrganizationId"/> model
        /// </summary>
        public Guid OrganizationId { get => _OrganizationId; set => SetProperty(ref _OrganizationId, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="CourseId"/> model
        /// </summary>
        public Guid CourseId { get => _CourseId; set => SetProperty(ref _CourseId, value); }

        public System.Decimal? AvailableCarnegieUnitCredit { get => _AvailableCarnegieUnitCredit; set => SetProperty(ref _AvailableCarnegieUnitCredit, value); }

        public System.Decimal? TimeRequiredForCompletion { get => _TimeRequiredForCompletion; set => SetProperty(ref _TimeRequiredForCompletion, value); }

        public System.Boolean? VirtualIndicator { get => _VirtualIndicator; set => SetProperty(ref _VirtualIndicator, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="OrganizationCalendarSessionId"/> model
        /// </summary>
        public Guid? OrganizationCalendarSessionId { get => _OrganizationCalendarSessionId; set => SetProperty(ref _OrganizationCalendarSessionId, value); }

        public System.Int32? MaximumCapacity { get => _MaximumCapacity; set => SetProperty(ref _MaximumCapacity, value); }

        public System.String RelatedCompetencyDefinitions  { get => _RelatedCompetencyDefinitions; set => SetProperty(ref _RelatedCompetencyDefinitions, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCourseSectionDeliveryModeId"/> model
        /// </summary>
        public Guid? RefCourseSectionDeliveryModeId { get => _RefCourseSectionDeliveryModeId; set => SetProperty(ref _RefCourseSectionDeliveryModeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefSingleSexClassStatusId"/> model
        /// </summary>
        public Guid? RefSingleSexClassStatusId { get => _RefSingleSexClassStatusId; set => SetProperty(ref _RefSingleSexClassStatusId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAdditionalCreditTypeId"/> model
        /// </summary>
        public Guid? RefAdditionalCreditTypeId { get => _RefAdditionalCreditTypeId; set => SetProperty(ref _RefAdditionalCreditTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefInstructionLanguageId"/> model
        /// </summary>
        public Guid? RefInstructionLanguageId { get => _RefInstructionLanguageId; set => SetProperty(ref _RefInstructionLanguageId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCreditTypeEarnedId"/> model
        /// </summary>
        public Guid? RefCreditTypeEarnedId { get => _RefCreditTypeEarnedId; set => SetProperty(ref _RefCreditTypeEarnedId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAdvancedPlacementCourseCodeId"/> model
        /// </summary>
        public Guid? RefAdvancedPlacementCourseCodeId { get => _RefAdvancedPlacementCourseCodeId; set => SetProperty(ref _RefAdvancedPlacementCourseCodeId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.ICourseSection model)
        {
            IsBusy = true;
            Id = model.Id;
            OrganizationId = model.OrganizationId;
            CourseId = model.CourseId;
            AvailableCarnegieUnitCredit = model.AvailableCarnegieUnitCredit;
            TimeRequiredForCompletion = model.TimeRequiredForCompletion;
            VirtualIndicator = model.VirtualIndicator;
            OrganizationCalendarSessionId = model.OrganizationCalendarSessionId;
            MaximumCapacity = model.MaximumCapacity;
            RelatedCompetencyDefinitions = model.RelatedCompetencyDefinitions;
            RefCourseSectionDeliveryModeId = model.RefCourseSectionDeliveryModeId;
            RefSingleSexClassStatusId = model.RefSingleSexClassStatusId;
            RefAdditionalCreditTypeId = model.RefAdditionalCreditTypeId;
            RefInstructionLanguageId = model.RefInstructionLanguageId;
            RefCreditTypeEarnedId = model.RefCreditTypeEarnedId;
            RefAdvancedPlacementCourseCodeId = model.RefAdvancedPlacementCourseCodeId;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
