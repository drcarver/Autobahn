//**********************************************************
//* DomainName: Assessments
//* FileName:   AssessmentAssetViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

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
        private  _ContentMimeType;

        // member variable for the ContentUrl property
        private  _ContentUrl;

        // member variable for the ContentXML property
        private  _ContentXML;

        // member variable for the Identifier property
        private  _Identifier;

        // member variable for the Name property
        private  _Name;

        // member variable for the Owner property
        private  _Owner;

        // member variable for the PublishedDate property
        private  _PublishedDate;

        // member variable for the RecordEndDateTime property
        private  _RecordEndDateTime;

        // member variable for the RecordStartDateTime property
        private  _RecordStartDateTime;

        // member variable for the RefAssessmentAssestIdentifierType property
        private  _RefAssessmentAssestIdentifierType;

        // member variable for the RefAssessmentAssetTypeId property
        private  _RefAssessmentAssetTypeId;

        // member variable for the RefAssessmentLanguageId property
        private Guid? _RefAssessmentLanguageId;

        // member variable for the Version property
        private  _Version;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// </summary>
        public  ContentMimeType { get => _ContentMimeType; set => SetProperty(ref _ContentMimeType, value); }

        /// <summary>
        /// </summary>
        public  ContentUrl { get => _ContentUrl; set => SetProperty(ref _ContentUrl, value); }

        /// <summary>
        /// </summary>
        public  ContentXML { get => _ContentXML; set => SetProperty(ref _ContentXML, value); }

        /// <summary>
        /// </summary>
        public  Identifier { get => _Identifier; set => SetProperty(ref _Identifier, value); }

        /// <summary>
        /// </summary>
        public  Name { get => _Name; set => SetProperty(ref _Name, value); }

        /// <summary>
        /// </summary>
        public  Owner { get => _Owner; set => SetProperty(ref _Owner, value); }

        /// <summary>
        /// </summary>
        public  PublishedDate { get => _PublishedDate; set => SetProperty(ref _PublishedDate, value); }

        /// <summary>
        /// </summary>
        public  RecordEndDateTime { get => _RecordEndDateTime; set => SetProperty(ref _RecordEndDateTime, value); }

        /// <summary>
        /// </summary>
        public  RecordStartDateTime { get => _RecordStartDateTime; set => SetProperty(ref _RecordStartDateTime, value); }

        /// <summary>
        /// </summary>
        public  RefAssessmentAssestIdentifierType { get => _RefAssessmentAssestIdentifierType; set => SetProperty(ref _RefAssessmentAssestIdentifierType, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAssessmentAssetType"/> model
        /// </summary>
        public  RefAssessmentAssetTypeId { get => _RefAssessmentAssetTypeId; set => SetProperty(ref _RefAssessmentAssetTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAssessmentLanguage"/> model
        /// </summary>
        public Guid? RefAssessmentLanguageId { get => _RefAssessmentLanguageId; set => SetProperty(ref _RefAssessmentLanguageId, value); }

        /// <summary>
        /// </summary>
        public  Version { get => _Version; set => SetProperty(ref _Version, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IAssessmentAsset model)
        {
            IsBusy = true;
            Id = model.Id;
            ContentMimeType = model.ContentMimeType; // 
            ContentUrl = model.ContentUrl; // 
            ContentXML = model.ContentXML; // 
            Identifier = model.Identifier; // 
            Name = model.Name; // 
            Owner = model.Owner; // 
            PublishedDate = model.PublishedDate; // 
            RecordEndDateTime = model.RecordEndDateTime; // 
            RecordStartDateTime = model.RecordStartDateTime; // 
            RefAssessmentAssestIdentifierType = model.RefAssessmentAssestIdentifierType; // 
            RefAssessmentAssetTypeId = model.RefAssessmentAssetTypeId; // 
            RefAssessmentLanguageId = model.RefAssessmentLanguageId; // 
            Version = model.Version; // 
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
