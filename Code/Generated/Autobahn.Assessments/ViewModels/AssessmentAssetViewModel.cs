//**********************************************************
//* DomainName: Assessments
//* FileName:   AssessmentAssetViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

namespace Autobahn.Assessments.ViewModels
{
     /// <summary>
     /// The AssessmentAssetViewModel
     /// </summary>
    public partial class AssessmentAssetViewModel : ViewModelBase, Interfaces.IAssessmentAsset
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from AssessmentAsset";

        // member variable for the ContentMimeType property
        private System.String _ContentMimeType;

        // member variable for the ContentUrl property
        private System.String _ContentUrl;

        // member variable for the ContentXML property
        private System.String _ContentXML;

        // member variable for the Identifier property
        private System.String _Identifier;

        // member variable for the LearningResourceId property
        private Guid? _LearningResourceId;

        // member variable for the Name property
        private System.String _Name;

        // member variable for the Owner property
        private System.String _Owner;

        // member variable for the PublishedDate property
        private System.DateTime? _PublishedDate;

        // member variable for the RefAssessmentAssestIdentifierType property
        private System.Int32? _RefAssessmentAssestIdentifierType;

        // member variable for the RefAssessmentAssetTypeId property
        private Guid? _RefAssessmentAssetTypeId;

        // member variable for the RefAssessmentLanguageId property
        private Guid? _RefAssessmentLanguageId;

        // member variable for the Version property
        private System.String _Version;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the AssessmentAssetViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// The language in which the assessment form is designed to be delivered.
        /// </summary>
        public System.String ContentMimeType { get => _ContentMimeType; set => SetProperty(ref _ContentMimeType, value); }

        /// <summary>
        /// The language in which the assessment form is designed to be delivered.
        /// </summary>
        public System.String ContentUrl { get => _ContentUrl; set => SetProperty(ref _ContentUrl, value); }

        /// <summary>
        /// The language in which the assessment form is designed to be delivered.
        /// </summary>
        public System.String ContentXML { get => _ContentXML; set => SetProperty(ref _ContentXML, value); }

        /// <summary>
        /// The language in which the assessment form is designed to be delivered.
        /// </summary>
        public System.String Identifier { get => _Identifier; set => SetProperty(ref _Identifier, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="LearningResource"/> model
        /// </summary>
        public Guid? LearningResourceId { get => _LearningResourceId; set => SetProperty(ref _LearningResourceId, value); }

        /// <summary>
        /// The language in which the assessment form is designed to be delivered.
        /// </summary>
        public System.String Name { get => _Name; set => SetProperty(ref _Name, value); }

        /// <summary>
        /// The language in which the assessment form is designed to be delivered.
        /// </summary>
        public System.String Owner { get => _Owner; set => SetProperty(ref _Owner, value); }

        /// <summary>
        /// The language in which the assessment form is designed to be delivered.
        /// </summary>
        public System.DateTime? PublishedDate { get => _PublishedDate; set => SetProperty(ref _PublishedDate, value); }

        /// <summary>
        /// The language in which the assessment form is designed to be delivered.
        /// </summary>
        public System.Int32? RefAssessmentAssestIdentifierType { get => _RefAssessmentAssestIdentifierType; set => SetProperty(ref _RefAssessmentAssestIdentifierType, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAssessmentAssetType"/> model
        /// </summary>
        public Guid? RefAssessmentAssetTypeId { get => _RefAssessmentAssetTypeId; set => SetProperty(ref _RefAssessmentAssetTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAssessmentLanguage"/> model
        /// </summary>
        public Guid? RefAssessmentLanguageId { get => _RefAssessmentLanguageId; set => SetProperty(ref _RefAssessmentLanguageId, value); }

        /// <summary>
        /// The language in which the assessment form is designed to be delivered.
        /// </summary>
        public System.String Version { get => _Version; set => SetProperty(ref _Version, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IAssessmentAsset model)
        {
            IsBusy = true;
            Id = model.Id;
            ContentMimeType = model.ContentMimeType;
            ContentUrl = model.ContentUrl;
            ContentXML = model.ContentXML;
            Identifier = model.Identifier;
            LearningResourceId = model.LearningResourceId;
            Name = model.Name;
            Owner = model.Owner;
            PublishedDate = model.PublishedDate;
            RefAssessmentAssestIdentifierType = model.RefAssessmentAssestIdentifierType;
            RefAssessmentAssetTypeId = model.RefAssessmentAssetTypeId;
            RefAssessmentLanguageId = model.RefAssessmentLanguageId;
            Version = model.Version;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
