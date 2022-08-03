//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   AssessmentAssetViewModel.cs
//**********************************************************

using Prism.Mvvm;
using Autobahn.Common.Interfaces;
using Autobahn.Autobahn.Assessment.Interfaces;

namespace Autobahn.Assessment.ViewModels
{
     /// <summary>
     /// The AssessmentAssetViewModel
     /// </summary>
    public partial class AssessmentAssetViewModel : BindableBase, IAssessmentAsset
    {
#region "Backing Fields"
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

        // member variable for the Owner property
        private System.String _Owner;

        // member variable for the ContentXML property
        private System.String _ContentXML;

        // member variable for the ContentMimeType property
        private System.String _ContentMimeType;

        // member variable for the ContentUrl property
        private System.String _ContentUrl;

        // member variable for the RecordStartDateTime property
        private System.DateTime? _RecordStartDateTime;

        // member variable for the RecordEndDateTime property
        private System.DateTime? _RecordEndDateTime;

#endregion

#region Properties
        public System.String Version  { get => _Version; set => SetProperty(ref _Version, value); }

        public System.DateTime? PublishedDate { get => _PublishedDate; set => SetProperty(ref _PublishedDate, value); }

        public System.String Identifier  { get => _Identifier; set => SetProperty(ref _Identifier, value); }

        public System.Int32? RefAssessmentAssestIdentifierType { get => _RefAssessmentAssestIdentifierType; set => SetProperty(ref _RefAssessmentAssestIdentifierType, value); }

        public System.String Name  { get => _Name; set => SetProperty(ref _Name, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAssessmentAssetTypeId"/> model
        /// </summary>
        public Guid? RefAssessmentAssetTypeId { get; set; }

        public System.String Owner  { get => _Owner; set => SetProperty(ref _Owner, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAssessmentLanguageId"/> model
        /// </summary>
        public Guid? RefAssessmentLanguageId { get; set; }

        public System.String ContentXML  { get => _ContentXML; set => SetProperty(ref _ContentXML, value); }

        public System.String ContentMimeType  { get => _ContentMimeType; set => SetProperty(ref _ContentMimeType, value); }

        public System.String ContentUrl  { get => _ContentUrl; set => SetProperty(ref _ContentUrl, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="LearningResourceId"/> model
        /// </summary>
        public Guid? LearningResourceId { get; set; }

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
        public void Load(IAssessmentAsset model)
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
