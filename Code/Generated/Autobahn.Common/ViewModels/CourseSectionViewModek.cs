//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   CourseSectionViewModel.cs
//**********************************************************

using Prism.Mvvm;
using Autobahn.Common.Interfaces;
using Autobahn.Autobahn.Common.Interfaces;

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The CourseSectionViewModel
     /// </summary>
    public partial class CourseSectionViewModel : BindableBase, ICourseSection
    {
#region "Backing Fields"
        // member variable for the AvailableCarnegieUnitCredit property
        private System.Decimal? _AvailableCarnegieUnitCredit;

        // member variable for the TimeRequiredForCompletion property
        private System.Decimal? _TimeRequiredForCompletion;

        // member variable for the VirtualIndicator property
        private System.Boolean? _VirtualIndicator;

        // member variable for the MaximumCapacity property
        private System.Int32? _MaximumCapacity;

        // member variable for the RelatedCompetencyDefinitions property
        private System.String _RelatedCompetencyDefinitions;

        // member variable for the RecordStartDateTime property
        private System.DateTime? _RecordStartDateTime;

        // member variable for the RecordEndDateTime property
        private System.DateTime? _RecordEndDateTime;

#endregion

#region Properties
        /// <summary>
        /// Reference to a required instance of the <see cref="OrganizationId"/> model
        /// </summary>
        public Guid OrganizationId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="CourseId"/> model
        /// </summary>
        public Guid CourseId { get; set; }

        public System.Decimal? AvailableCarnegieUnitCredit { get => _AvailableCarnegieUnitCredit; set => SetProperty(ref _AvailableCarnegieUnitCredit, value); }

        public System.Decimal? TimeRequiredForCompletion { get => _TimeRequiredForCompletion; set => SetProperty(ref _TimeRequiredForCompletion, value); }

        public System.Boolean? VirtualIndicator { get => _VirtualIndicator; set => SetProperty(ref _VirtualIndicator, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="OrganizationCalendarSessionId"/> model
        /// </summary>
        public Guid? OrganizationCalendarSessionId { get; set; }

        public System.Int32? MaximumCapacity { get => _MaximumCapacity; set => SetProperty(ref _MaximumCapacity, value); }

        public System.String RelatedCompetencyDefinitions  { get => _RelatedCompetencyDefinitions; set => SetProperty(ref _RelatedCompetencyDefinitions, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCourseSectionDeliveryModeId"/> model
        /// </summary>
        public Guid? RefCourseSectionDeliveryModeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefSingleSexClassStatusId"/> model
        /// </summary>
        public Guid? RefSingleSexClassStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAdditionalCreditTypeId"/> model
        /// </summary>
        public Guid? RefAdditionalCreditTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefInstructionLanguageId"/> model
        /// </summary>
        public Guid? RefInstructionLanguageId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCreditTypeEarnedId"/> model
        /// </summary>
        public Guid? RefCreditTypeEarnedId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAdvancedPlacementCourseCodeId"/> model
        /// </summary>
        public Guid? RefAdvancedPlacementCourseCodeId { get; set; }

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
        public void Load(ICourseSection model)
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
