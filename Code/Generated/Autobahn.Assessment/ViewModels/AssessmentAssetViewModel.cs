//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   AssessmentAssetViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

namespace Autobahn.Assessment.ViewModels
{
     /// <summary>
     /// The AssessmentAssetViewModel
     /// </summary>
    public partial class AssessmentAssetViewModel : ViewModelBase, Interfaces.IAssessmentAssetViewModel
    {
#region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from AssessmentAsset";

        // member variable for the Version property
        private System.String _Version;

        // member variable for the PublishedDate property
        private System.DateTime? _PublishedDate;

        // member variable for the Identifier property
        private System.String _Identifier;

        // member variable for the RefAssessmentAssestIdentifierType property
        private System.Int32? _RefAssessmentAssestIdentifierType;

        // member variable for the Name property
        private System.String _Name;

        // member variable for the RefAssessmentAssetTypeId property
        private Guid? _RefAssessmentAssetTypeId;

        // member variable for the Owner property
        private System.String _Owner;

        // member variable for the RefAssessmentLanguageId property
        private Guid? _RefAssessmentLanguageId;

        // member variable for the ContentXML property
        private System.String _ContentXML;

        // member variable for the ContentMimeType property
        private System.String _ContentMimeType;

        // member variable for the ContentUrl property
        private System.String _ContentUrl;

        // member variable for the LearningResourceId property
        private Guid? _LearningResourceId;

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
        /// The title of the AssessmentAssetViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        public System.String Version  { get => _Version; set => SetProperty(ref _Version, value); }

        public System.DateTime? PublishedDate { get => _PublishedDate; set => SetProperty(ref _PublishedDate, value); }

        public System.String Identifier  { get => _Identifier; set => SetProperty(ref _Identifier, value); }

        public System.Int32? RefAssessmentAssestIdentifierType { get => _RefAssessmentAssestIdentifierType; set => SetProperty(ref _RefAssessmentAssestIdentifierType, value); }

        public System.String Name  { get => _Name; set => SetProperty(ref _Name, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAssessmentAssetTypeId"/> model
        /// </summary>
        public Guid? RefAssessmentAssetTypeId { get => _RefAssessmentAssetTypeId; set => SetProperty(ref _RefAssessmentAssetTypeId, value); }

        public System.String Owner  { get => _Owner; set => SetProperty(ref _Owner, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAssessmentLanguageId"/> model
        /// </summary>
        public Guid? RefAssessmentLanguageId { get => _RefAssessmentLanguageId; set => SetProperty(ref _RefAssessmentLanguageId, value); }

        public System.String ContentXML  { get => _ContentXML; set => SetProperty(ref _ContentXML, value); }

        public System.String ContentMimeType  { get => _ContentMimeType; set => SetProperty(ref _ContentMimeType, value); }

        public System.String ContentUrl  { get => _ContentUrl; set => SetProperty(ref _ContentUrl, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="LearningResourceId"/> model
        /// </summary>
        public Guid? LearningResourceId { get => _LearningResourceId; set => SetProperty(ref _LearningResourceId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IAssessmentAsset model)
        {
            IsBusy = true;
            Id = model.Id;
            Version = model.Version;
            PublishedDate = model.PublishedDate;
            Identifier = model.Identifier;
            RefAssessmentAssestIdentifierType = model.RefAssessmentAssestIdentifierType;
            Name = model.Name;
            RefAssessmentAssetTypeId = model.RefAssessmentAssetTypeId;
            Owner = model.Owner;
            RefAssessmentLanguageId = model.RefAssessmentLanguageId;
            ContentXML = model.ContentXML;
            ContentMimeType = model.ContentMimeType;
            ContentUrl = model.ContentUrl;
            LearningResourceId = model.LearningResourceId;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
