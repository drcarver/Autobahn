//**********************************************************
//* DomainName: Invalid or Unreferenced Models
//* FileName:   CourseSectionViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

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
        private Guid? _AvailableCarnegieUnitCredit;

        // member variable for the MaximumCapacity property
        private  _MaximumCapacity;

        // member variable for the OrganizationCalendarSessionId property
        private  _OrganizationCalendarSessionId;

        // member variable for the RecordEndDateTime property
        private  _RecordEndDateTime;

        // member variable for the RecordStartDateTime property
        private  _RecordStartDateTime;

        // member variable for the RefAdditionalCreditTypeId property
        private  _RefAdditionalCreditTypeId;

        // member variable for the RefAdvancedPlacementCourseCodeId property
        private  _RefAdvancedPlacementCourseCodeId;

        // member variable for the RefCourseSectionDeliveryModeId property
        private  _RefCourseSectionDeliveryModeId;

        // member variable for the RefInstructionLanguageId property
        private  _RefInstructionLanguageId;

        // member variable for the RefSingleSexClassStatusId property
        private  _RefSingleSexClassStatusId;

        // member variable for the RelatedCompetencyDefinitions property
        private  _RelatedCompetencyDefinitions;

        // member variable for the TimeRequiredForCompletion property
        private  _TimeRequiredForCompletion;

        // member variable for the VirtualIndicator property
        private  _VirtualIndicator;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// </summary>
        public Guid? AvailableCarnegieUnitCredit { get => _AvailableCarnegieUnitCredit; set => SetProperty(ref _AvailableCarnegieUnitCredit, value); }

        /// <summary>
        /// </summary>
        public  MaximumCapacity { get => _MaximumCapacity; set => SetProperty(ref _MaximumCapacity, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="OrganizationCalendarSession"/> model
        /// </summary>
        public  OrganizationCalendarSessionId { get => _OrganizationCalendarSessionId; set => SetProperty(ref _OrganizationCalendarSessionId, value); }

        /// <summary>
        /// </summary>
        public  RecordEndDateTime { get => _RecordEndDateTime; set => SetProperty(ref _RecordEndDateTime, value); }

        /// <summary>
        /// </summary>
        public  RecordStartDateTime { get => _RecordStartDateTime; set => SetProperty(ref _RecordStartDateTime, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAdditionalCreditType"/> model
        /// </summary>
        public  RefAdditionalCreditTypeId { get => _RefAdditionalCreditTypeId; set => SetProperty(ref _RefAdditionalCreditTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAdvancedPlacementCourseCode"/> model
        /// </summary>
        public  RefAdvancedPlacementCourseCodeId { get => _RefAdvancedPlacementCourseCodeId; set => SetProperty(ref _RefAdvancedPlacementCourseCodeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCourseSectionDeliveryMode"/> model
        /// </summary>
        public  RefCourseSectionDeliveryModeId { get => _RefCourseSectionDeliveryModeId; set => SetProperty(ref _RefCourseSectionDeliveryModeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefInstructionLanguage"/> model
        /// </summary>
        public  RefInstructionLanguageId { get => _RefInstructionLanguageId; set => SetProperty(ref _RefInstructionLanguageId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefSingleSexClassStatus"/> model
        /// </summary>
        public  RefSingleSexClassStatusId { get => _RefSingleSexClassStatusId; set => SetProperty(ref _RefSingleSexClassStatusId, value); }

        /// <summary>
        /// </summary>
        public  RelatedCompetencyDefinitions { get => _RelatedCompetencyDefinitions; set => SetProperty(ref _RelatedCompetencyDefinitions, value); }

        /// <summary>
        /// </summary>
        public  TimeRequiredForCompletion { get => _TimeRequiredForCompletion; set => SetProperty(ref _TimeRequiredForCompletion, value); }

        /// <summary>
        /// </summary>
        public  VirtualIndicator { get => _VirtualIndicator; set => SetProperty(ref _VirtualIndicator, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.ICourseSection model)
        {
            IsBusy = true;
            Id = model.Id;
            AvailableCarnegieUnitCredit = model.AvailableCarnegieUnitCredit; // 
            MaximumCapacity = model.MaximumCapacity; // 
            OrganizationCalendarSessionId = model.OrganizationCalendarSessionId; // 
            RecordEndDateTime = model.RecordEndDateTime; // 
            RecordStartDateTime = model.RecordStartDateTime; // 
            RefAdditionalCreditTypeId = model.RefAdditionalCreditTypeId; // 
            RefAdvancedPlacementCourseCodeId = model.RefAdvancedPlacementCourseCodeId; // 
            RefCourseSectionDeliveryModeId = model.RefCourseSectionDeliveryModeId; // 
            RefInstructionLanguageId = model.RefInstructionLanguageId; // 
            RefSingleSexClassStatusId = model.RefSingleSexClassStatusId; // 
            RelatedCompetencyDefinitions = model.RelatedCompetencyDefinitions; // 
            TimeRequiredForCompletion = model.TimeRequiredForCompletion; // 
            VirtualIndicator = model.VirtualIndicator; // 
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
