//**********************************************************
//* DomainName: Assessments
//* FileName:   AssessmentFormSectionViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

namespace Autobahn.Assessments.ViewModels
{
     /// <summary>
     /// The AssessmentFormSectionViewModel
     /// </summary>
    public partial class AssessmentFormSectionViewModel : ViewModelBase, Interfaces.IAssessmentFormSection
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from AssessmentFormSection";

        // member variable for the AssessmentItemBankIdentifier property
        private System.String _AssessmentItemBankIdentifier;

        // member variable for the AssessmentItemBankName property
        private System.String _AssessmentItemBankName;

        // member variable for the ChildOfFormSectionId property
        private Guid? _ChildOfFormSectionId;

        // member variable for the GUID property
        private System.String _GUID;

        // member variable for the Identifier property
        private System.String _Identifier;

        // member variable for the LearningResourceId property
        private Guid? _LearningResourceId;

        // member variable for the PublishedDate property
        private System.DateTime? _PublishedDate;

        // member variable for the RefAssessmentFormSectionIdentificationSystemId property
        private Guid? _RefAssessmentFormSectionIdentificationSystemId;

        // member variable for the SectionReentry property
        private System.Boolean? _SectionReentry;

        // member variable for the SectionSealed property
        private System.Boolean? _SectionSealed;

        // member variable for the SectionTimeLimit property
        private System.TimeSpan? _SectionTimeLimit;

        // member variable for the Version property
        private System.String _Version;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the AssessmentFormSectionViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// The globally unique identifier of an Assessment Form Section using a RFC 4122 compliant hexadecimal string.
        /// </summary>
        public System.String AssessmentItemBankIdentifier { get => _AssessmentItemBankIdentifier; set => SetProperty(ref _AssessmentItemBankIdentifier, value); }

        /// <summary>
        /// The globally unique identifier of an Assessment Form Section using a RFC 4122 compliant hexadecimal string.
        /// </summary>
        public System.String AssessmentItemBankName { get => _AssessmentItemBankName; set => SetProperty(ref _AssessmentItemBankName, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="ChildOfFormSection"/> model
        /// </summary>
        public Guid? ChildOfFormSectionId { get => _ChildOfFormSectionId; set => SetProperty(ref _ChildOfFormSectionId, value); }

        /// <summary>
        /// The globally unique identifier of an Assessment Form Section using a RFC 4122 compliant hexadecimal string.
        /// </summary>
        public System.String GUID { get => _GUID; set => SetProperty(ref _GUID, value); }

        /// <summary>
        /// The globally unique identifier of an Assessment Form Section using a RFC 4122 compliant hexadecimal string.
        /// </summary>
        public System.String Identifier { get => _Identifier; set => SetProperty(ref _Identifier, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="LearningResource"/> model
        /// </summary>
        public Guid? LearningResourceId { get => _LearningResourceId; set => SetProperty(ref _LearningResourceId, value); }

        /// <summary>
        /// The globally unique identifier of an Assessment Form Section using a RFC 4122 compliant hexadecimal string.
        /// </summary>
        public System.DateTime? PublishedDate { get => _PublishedDate; set => SetProperty(ref _PublishedDate, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAssessmentFormSectionentificationSystem"/> model
        /// </summary>
        public Guid? RefAssessmentFormSectionIdentificationSystemId { get => _RefAssessmentFormSectionIdentificationSystemId; set => SetProperty(ref _RefAssessmentFormSectionIdentificationSystemId, value); }

        /// <summary>
        /// The globally unique identifier of an Assessment Form Section using a RFC 4122 compliant hexadecimal string.
        /// </summary>
        public System.Boolean? SectionReentry { get => _SectionReentry; set => SetProperty(ref _SectionReentry, value); }

        /// <summary>
        /// The globally unique identifier of an Assessment Form Section using a RFC 4122 compliant hexadecimal string.
        /// </summary>
        public System.Boolean? SectionSealed { get => _SectionSealed; set => SetProperty(ref _SectionSealed, value); }

        /// <summary>
        /// The globally unique identifier of an Assessment Form Section using a RFC 4122 compliant hexadecimal string.
        /// </summary>
        public System.TimeSpan? SectionTimeLimit { get => _SectionTimeLimit; set => SetProperty(ref _SectionTimeLimit, value); }

        /// <summary>
        /// The globally unique identifier of an Assessment Form Section using a RFC 4122 compliant hexadecimal string.
        /// </summary>
        public System.String Version { get => _Version; set => SetProperty(ref _Version, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IAssessmentFormSection model)
        {
            IsBusy = true;
            Id = model.Id;
            AssessmentItemBankIdentifier = model.AssessmentItemBankIdentifier;
            AssessmentItemBankName = model.AssessmentItemBankName;
            ChildOfFormSectionId = model.ChildOfFormSectionId;
            GUID = model.GUID;
            Identifier = model.Identifier;
            LearningResourceId = model.LearningResourceId;
            PublishedDate = model.PublishedDate;
            RefAssessmentFormSectionIdentificationSystemId = model.RefAssessmentFormSectionIdentificationSystemId;
            SectionReentry = model.SectionReentry;
            SectionSealed = model.SectionSealed;
            SectionTimeLimit = model.SectionTimeLimit;
            Version = model.Version;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
