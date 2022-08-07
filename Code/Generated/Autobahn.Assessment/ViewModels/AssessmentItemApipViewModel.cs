//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   AssessmentItemApipViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

namespace Autobahn.Assessment.ViewModels
{
     /// <summary>
     /// The AssessmentItemApipViewModel
     /// </summary>
    public partial class AssessmentItemApipViewModel : ViewModelBase, Interfaces.IAssessmentItemApipViewModel
    {
#region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from AssessmentItemApip";

        // member variable for the AssessmentItemId property
        private Guid _AssessmentItemId;

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

        // member variable for the RecordStatusId property
        private Guid? _RecordStatusId;

        // member variable for the DataCollectionId property
        private Guid? _DataCollectionId;

#endregion

        #region Properties
        /// <summary>
        /// The title of the AssessmentItemApipViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="AssessmentItemId"/> model
        /// </summary>
        public Guid AssessmentItemId { get => _AssessmentItemId; set => SetProperty(ref _AssessmentItemId, value); }

        public System.Boolean? AdaptiveIndicator { get => _AdaptiveIndicator; set => SetProperty(ref _AdaptiveIndicator, value); }

        public System.String ResponseProcessingTemplateUrl  { get => _ResponseProcessingTemplateUrl; set => SetProperty(ref _ResponseProcessingTemplateUrl, value); }

        public System.String ResponseProcessingXml  { get => _ResponseProcessingXml; set => SetProperty(ref _ResponseProcessingXml, value); }

        public System.String ResponseDeclarationXml  { get => _ResponseDeclarationXml; set => SetProperty(ref _ResponseDeclarationXml, value); }

        public System.String OutcomeDeclarationXml  { get => _OutcomeDeclarationXml; set => SetProperty(ref _OutcomeDeclarationXml, value); }

        public System.String TemplateDeclarationXml  { get => _TemplateDeclarationXml; set => SetProperty(ref _TemplateDeclarationXml, value); }

        public System.String TemplateProcessingXml  { get => _TemplateProcessingXml; set => SetProperty(ref _TemplateProcessingXml, value); }

        public System.String ModalFeedbackXml  { get => _ModalFeedbackXml; set => SetProperty(ref _ModalFeedbackXml, value); }

        public System.String ItemBodyXml  { get => _ItemBodyXml; set => SetProperty(ref _ItemBodyXml, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IAssessmentItemApip model)
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
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
