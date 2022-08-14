//**********************************************************
//* DomainName: Invalid or Unreferenced Models
//* FileName:   CourseSectionViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

namespace Autobahn.Invalid.ViewModels
{
     /// <summary>
     /// The CourseSectionViewModel
     /// </summary>
    public partial class CourseSectionViewModel : ViewModelBase, Interfaces.ICourseSection
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from CourseSection";

        // member variable for the AvailableCarnegieUnitCredit property
        private System.Decimal? _AvailableCarnegieUnitCredit;

        // member variable for the CourseId property
        private Guid _CourseId;

        // member variable for the MaximumCapacity property
        private System.Int32? _MaximumCapacity;

        // member variable for the OrganizationCalendarSessionId property
        private Guid? _OrganizationCalendarSessionId;

        // member variable for the OrganizationId property
        private Guid _OrganizationId;

        // member variable for the RefAdditionalCreditTypeId property
        private Guid? _RefAdditionalCreditTypeId;

        // member variable for the RefAdvancedPlacementCourseCodeId property
        private Guid? _RefAdvancedPlacementCourseCodeId;

        // member variable for the RefCourseSectionDeliveryModeId property
        private Guid? _RefCourseSectionDeliveryModeId;

        // member variable for the RefCreditTypeEarnedId property
        private Guid? _RefCreditTypeEarnedId;

        // member variable for the RefInstructionLanguageId property
        private Guid? _RefInstructionLanguageId;

        // member variable for the RefSingleSexClassStatusId property
        private Guid? _RefSingleSexClassStatusId;

        // member variable for the RelatedCompetencyDefinitions property
        private System.String _RelatedCompetencyDefinitions;

        // member variable for the TimeRequiredForCompletion property
        private System.Decimal? _TimeRequiredForCompletion;

        // member variable for the VirtualIndicator property
        private System.Boolean? _VirtualIndicator;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the CourseSectionViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Measured in Carnegie units, the amount of credit available to a student who successfully meets the objectives of the course. A course meeting every day for one period of the school day over the span of a school year offers one Carnegie unit. A Carnegie unit is thus a measure of "seat time" rather than a measure of attainment of the course objectives.
        /// </summary>
        public System.Decimal? AvailableCarnegieUnitCredit { get => _AvailableCarnegieUnitCredit; set => SetProperty(ref _AvailableCarnegieUnitCredit, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="Course"/> model
        /// </summary>
        public Guid CourseId { get => _CourseId; set => SetProperty(ref _CourseId, value); }

        /// <summary>
        /// Measured in Carnegie units, the amount of credit available to a student who successfully meets the objectives of the course. A course meeting every day for one period of the school day over the span of a school year offers one Carnegie unit. A Carnegie unit is thus a measure of "seat time" rather than a measure of attainment of the course objectives.
        /// </summary>
        public System.Int32? MaximumCapacity { get => _MaximumCapacity; set => SetProperty(ref _MaximumCapacity, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="OrganizationCalendarSession"/> model
        /// </summary>
        public Guid? OrganizationCalendarSessionId { get => _OrganizationCalendarSessionId; set => SetProperty(ref _OrganizationCalendarSessionId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="Organization"/> model
        /// </summary>
        public Guid OrganizationId { get => _OrganizationId; set => SetProperty(ref _OrganizationId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAdditionalCreditType"/> model
        /// </summary>
        public Guid? RefAdditionalCreditTypeId { get => _RefAdditionalCreditTypeId; set => SetProperty(ref _RefAdditionalCreditTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAdvancedPlacementCourseCode"/> model
        /// </summary>
        public Guid? RefAdvancedPlacementCourseCodeId { get => _RefAdvancedPlacementCourseCodeId; set => SetProperty(ref _RefAdvancedPlacementCourseCodeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCourseSectionDeliveryMode"/> model
        /// </summary>
        public Guid? RefCourseSectionDeliveryModeId { get => _RefCourseSectionDeliveryModeId; set => SetProperty(ref _RefCourseSectionDeliveryModeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCreditTypeEarned"/> model
        /// </summary>
        public Guid? RefCreditTypeEarnedId { get => _RefCreditTypeEarnedId; set => SetProperty(ref _RefCreditTypeEarnedId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefInstructionLanguage"/> model
        /// </summary>
        public Guid? RefInstructionLanguageId { get => _RefInstructionLanguageId; set => SetProperty(ref _RefInstructionLanguageId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefSingleSexClassStatus"/> model
        /// </summary>
        public Guid? RefSingleSexClassStatusId { get => _RefSingleSexClassStatusId; set => SetProperty(ref _RefSingleSexClassStatusId, value); }

        /// <summary>
        /// Measured in Carnegie units, the amount of credit available to a student who successfully meets the objectives of the course. A course meeting every day for one period of the school day over the span of a school year offers one Carnegie unit. A Carnegie unit is thus a measure of "seat time" rather than a measure of attainment of the course objectives.
        /// </summary>
        public System.String RelatedCompetencyDefinitions { get => _RelatedCompetencyDefinitions; set => SetProperty(ref _RelatedCompetencyDefinitions, value); }

        /// <summary>
        /// Measured in Carnegie units, the amount of credit available to a student who successfully meets the objectives of the course. A course meeting every day for one period of the school day over the span of a school year offers one Carnegie unit. A Carnegie unit is thus a measure of "seat time" rather than a measure of attainment of the course objectives.
        /// </summary>
        public System.Decimal? TimeRequiredForCompletion { get => _TimeRequiredForCompletion; set => SetProperty(ref _TimeRequiredForCompletion, value); }

        /// <summary>
        /// Measured in Carnegie units, the amount of credit available to a student who successfully meets the objectives of the course. A course meeting every day for one period of the school day over the span of a school year offers one Carnegie unit. A Carnegie unit is thus a measure of "seat time" rather than a measure of attainment of the course objectives.
        /// </summary>
        public System.Boolean? VirtualIndicator { get => _VirtualIndicator; set => SetProperty(ref _VirtualIndicator, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.ICourseSection model)
        {
            IsBusy = true;
            Id = model.Id;
            AvailableCarnegieUnitCredit = model.AvailableCarnegieUnitCredit;
            CourseId = model.CourseId;
            MaximumCapacity = model.MaximumCapacity;
            OrganizationCalendarSessionId = model.OrganizationCalendarSessionId;
            OrganizationId = model.OrganizationId;
            RefAdditionalCreditTypeId = model.RefAdditionalCreditTypeId;
            RefAdvancedPlacementCourseCodeId = model.RefAdvancedPlacementCourseCodeId;
            RefCourseSectionDeliveryModeId = model.RefCourseSectionDeliveryModeId;
            RefCreditTypeEarnedId = model.RefCreditTypeEarnedId;
            RefInstructionLanguageId = model.RefInstructionLanguageId;
            RefSingleSexClassStatusId = model.RefSingleSexClassStatusId;
            RelatedCompetencyDefinitions = model.RelatedCompetencyDefinitions;
            TimeRequiredForCompletion = model.TimeRequiredForCompletion;
            VirtualIndicator = model.VirtualIndicator;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
