//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   AssessmentItemApipViewModel.cs
//**********************************************************

using Prism.Mvvm;
using Autobahn.Common.Interfaces;
using Autobahn.Autobahn.Assessment.Interfaces;

namespace Autobahn.Assessment.ViewModels
{
     /// <summary>
     /// The AssessmentItemApipViewModel
     /// </summary>
    public partial class AssessmentItemApipViewModel : BindableBase, IAssessmentItemApip
    {
#region "Backing Fields"
        // member variable for the AdaptiveIndicator property
        private System.Boolean? _AdaptiveIndicator;

        // member variable for the ResponseProcessingTemplateUrl property
        private System.String _ResponseProcessingTemplateUrl;

        // member variable for the ResponseProcessingXml property
        private System.String _ResponseProcessingXml;

        // member variable for the ResponseDeclarationXml property
        private System.String _ResponseDeclarationXml;

        // member variable for the OutcomeDeclarationXml property
        private System.String _OutcomeDeclarationXml;

        // member variable for the TemplateDeclarationXml property
        private System.String _TemplateDeclarationXml;

        // member variable for the TemplateProcessingXml property
        private System.String _TemplateProcessingXml;

        // member variable for the ModalFeedbackXml property
        private System.String _ModalFeedbackXml;

        // member variable for the ItemBodyXml property
        private System.String _ItemBodyXml;

        // member variable for the RecordStartDateTime property
        private System.DateTime? _RecordStartDateTime;

        // member variable for the RecordEndDateTime property
        private System.DateTime? _RecordEndDateTime;

#endregion

#region Properties
        /// <summary>
        /// Reference to a required instance of the <see cref="AssessmentItemId"/> model
        /// </summary>
        public Guid AssessmentItemId { get; set; }

        public System.Boolean? AdaptiveIndicator { get => _AdaptiveIndicator; set => SetProperty(ref _AdaptiveIndicator, value); }

        public System.String ResponseProcessingTemplateUrl  { get => _ResponseProcessingTemplateUrl; set => SetProperty(ref _ResponseProcessingTemplateUrl, value); }

        public System.String ResponseProcessingXml  { get => _ResponseProcessingXml; set => SetProperty(ref _ResponseProcessingXml, value); }

        public System.String ResponseDeclarationXml  { get => _ResponseDeclarationXml; set => SetProperty(ref _ResponseDeclarationXml, value); }

        public System.String OutcomeDeclarationXml  { get => _OutcomeDeclarationXml; set => SetProperty(ref _OutcomeDeclarationXml, value); }

        public System.String TemplateDeclarationXml  { get => _TemplateDeclarationXml; set => SetProperty(ref _TemplateDeclarationXml, value); }

        public System.String TemplateProcessingXml  { get => _TemplateProcessingXml; set => SetProperty(ref _TemplateProcessingXml, value); }

        public System.String ModalFeedbackXml  { get => _ModalFeedbackXml; set => SetProperty(ref _ModalFeedbackXml, value); }

        public System.String ItemBodyXml  { get => _ItemBodyXml; set => SetProperty(ref _ItemBodyXml, value); }

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
        public void Load(IAssessmentItemApip model)
        {
            IsBusy = true;
            Id = model.Id;
            AssessmentItemId = model.AssessmentItemId;
            AdaptiveIndicator = model.AdaptiveIndicator;
            ResponseProcessingTemplateUrl = model.ResponseProcessingTemplateUrl;
            ResponseProcessingXml = model.ResponseProcessingXml;
            ResponseDeclarationXml = model.ResponseDeclarationXml;
            OutcomeDeclarationXml = model.OutcomeDeclarationXml;
            TemplateDeclarationXml = model.TemplateDeclarationXml;
            TemplateProcessingXml = model.TemplateProcessingXml;
            ModalFeedbackXml = model.ModalFeedbackXml;
            ItemBodyXml = model.ItemBodyXml;
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
