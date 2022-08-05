//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   AssessmentFormSectionViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

namespace Autobahn.Assessment.ViewModels
{
     /// <summary>
     /// The AssessmentFormSectionViewModel
     /// </summary>
    public partial class AssessmentFormSectionViewModel : ViewModelBase, Interfaces.IAssessmentFormSection
    {
#region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from AssessmentFormSection";

        // member variable for the Identifier property
        private System.String _Identifier;

        // member variable for the RefAssessmentFormSectionIdentificationSystemId property
        private Guid? _RefAssessmentFormSectionIdentificationSystemId;

        // member variable for the PublishedDate property
        private System.DateTime? _PublishedDate;

        // member variable for the Version property
        private System.String _Version;

        // member variable for the SectionTimeLimit property
        private System.TimeSpan? _SectionTimeLimit;

        // member variable for the SectionSealed property
        private System.Boolean? _SectionSealed;

        // member variable for the SectionReentry property
        private System.Boolean? _SectionReentry;

        // member variable for the AssessmentItemBankIdentifier property
        private System.String _AssessmentItemBankIdentifier;

        // member variable for the AssessmentItemBankName property
        private System.String _AssessmentItemBankName;

        // member variable for the ChildOf_FormSectionId property
        private Guid? _ChildOf_FormSectionId;

        // member variable for the LearningResourceId property
        private Guid? _LearningResourceId;

        // member variable for the GUID property
        private System.String _GUID;

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
        /// The title of the AssessmentFormSectionViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        public System.String Identifier  { get => _Identifier; set => SetProperty(ref _Identifier, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAssessmentFormSectionIdentificationSystemId"/> model
        /// </summary>
        public Guid? RefAssessmentFormSectionIdentificationSystemId { get => _RefAssessmentFormSectionIdentificationSystemId; set => SetProperty(ref _RefAssessmentFormSectionIdentificationSystemId, value); }

        public System.DateTime? PublishedDate { get => _PublishedDate; set => SetProperty(ref _PublishedDate, value); }

        public System.String Version  { get => _Version; set => SetProperty(ref _Version, value); }

        public System.TimeSpan? SectionTimeLimit { get => _SectionTimeLimit; set => SetProperty(ref _SectionTimeLimit, value); }

        public System.Boolean? SectionSealed { get => _SectionSealed; set => SetProperty(ref _SectionSealed, value); }

        public System.Boolean? SectionReentry { get => _SectionReentry; set => SetProperty(ref _SectionReentry, value); }

        public System.String AssessmentItemBankIdentifier  { get => _AssessmentItemBankIdentifier; set => SetProperty(ref _AssessmentItemBankIdentifier, value); }

        public System.String AssessmentItemBankName  { get => _AssessmentItemBankName; set => SetProperty(ref _AssessmentItemBankName, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="ChildOf_FormSectionId"/> model
        /// </summary>
        public Guid? ChildOf_FormSectionId { get => _ChildOf_FormSectionId; set => SetProperty(ref _ChildOf_FormSectionId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="LearningResourceId"/> model
        /// </summary>
        public Guid? LearningResourceId { get => _LearningResourceId; set => SetProperty(ref _LearningResourceId, value); }

        public System.String GUID  { get => _GUID; set => SetProperty(ref _GUID, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IAssessmentFormSection model)
        {
            IsBusy = true;
            Id = model.Id;
            Identifier = model.Identifier;
            RefAssessmentFormSectionIdentificationSystemId = model.RefAssessmentFormSectionIdentificationSystemId;
            PublishedDate = model.PublishedDate;
            Version = model.Version;
            SectionTimeLimit = model.SectionTimeLimit;
            SectionSealed = model.SectionSealed;
            SectionReentry = model.SectionReentry;
            AssessmentItemBankIdentifier = model.AssessmentItemBankIdentifier;
            AssessmentItemBankName = model.AssessmentItemBankName;
            ChildOf_FormSectionId = model.ChildOf_FormSectionId;
            LearningResourceId = model.LearningResourceId;
            GUID = model.GUID;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
