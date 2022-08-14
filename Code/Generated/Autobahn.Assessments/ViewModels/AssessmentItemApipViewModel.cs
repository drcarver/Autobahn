//**********************************************************
//* DomainName: Assessments
//* FileName:   AssessmentItemApipViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

namespace Autobahn.Assessments.ViewModels
{
     /// <summary>
     /// The AssessmentItemApipViewModel
     /// </summary>
    public partial class AssessmentItemApipViewModel : ViewModelBase, Interfaces.IAssessmentItemApip
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from AssessmentItemApip";

        // member variable for the AdaptiveIndicator property
        private System.Boolean? _AdaptiveIndicator;

        // member variable for the AssessmentItemId property
        private Guid _AssessmentItemId;

        // member variable for the ItemBodyXml property
        private System.String _ItemBodyXml;

        // member variable for the ModalFeedbackXml property
        private System.String _ModalFeedbackXml;

        // member variable for the OutcomeDeclarationXml property
        private System.String _OutcomeDeclarationXml;

        // member variable for the ResponseDeclarationXml property
        private System.String _ResponseDeclarationXml;

        // member variable for the ResponseProcessingTemplateUrl property
        private System.String _ResponseProcessingTemplateUrl;

        // member variable for the ResponseProcessingXml property
        private System.String _ResponseProcessingXml;

        // member variable for the TemplateDeclarationXml property
        private System.String _TemplateDeclarationXml;

        // member variable for the TemplateProcessingXml property
        private System.String _TemplateProcessingXml;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the AssessmentItemApipViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// These templates are described using the processing language defined in IMS Global APIP specification and are distributed (in XML form) along with it. Delivery engines that support generalized response processing do not need to implement special mechanisms to support them as a template file can be parsed directly while processing the assessment item that refers to it. This element provides the URL for the template.
        /// </summary>
        public System.Boolean? AdaptiveIndicator { get => _AdaptiveIndicator; set => SetProperty(ref _AdaptiveIndicator, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="AssessmentItem"/> model
        /// </summary>
        public Guid AssessmentItemId { get => _AssessmentItemId; set => SetProperty(ref _AssessmentItemId, value); }

        /// <summary>
        /// These templates are described using the processing language defined in IMS Global APIP specification and are distributed (in XML form) along with it. Delivery engines that support generalized response processing do not need to implement special mechanisms to support them as a template file can be parsed directly while processing the assessment item that refers to it. This element provides the URL for the template.
        /// </summary>
        public System.String ItemBodyXml { get => _ItemBodyXml; set => SetProperty(ref _ItemBodyXml, value); }

        /// <summary>
        /// These templates are described using the processing language defined in IMS Global APIP specification and are distributed (in XML form) along with it. Delivery engines that support generalized response processing do not need to implement special mechanisms to support them as a template file can be parsed directly while processing the assessment item that refers to it. This element provides the URL for the template.
        /// </summary>
        public System.String ModalFeedbackXml { get => _ModalFeedbackXml; set => SetProperty(ref _ModalFeedbackXml, value); }

        /// <summary>
        /// These templates are described using the processing language defined in IMS Global APIP specification and are distributed (in XML form) along with it. Delivery engines that support generalized response processing do not need to implement special mechanisms to support them as a template file can be parsed directly while processing the assessment item that refers to it. This element provides the URL for the template.
        /// </summary>
        public System.String OutcomeDeclarationXml { get => _OutcomeDeclarationXml; set => SetProperty(ref _OutcomeDeclarationXml, value); }

        /// <summary>
        /// These templates are described using the processing language defined in IMS Global APIP specification and are distributed (in XML form) along with it. Delivery engines that support generalized response processing do not need to implement special mechanisms to support them as a template file can be parsed directly while processing the assessment item that refers to it. This element provides the URL for the template.
        /// </summary>
        public System.String ResponseDeclarationXml { get => _ResponseDeclarationXml; set => SetProperty(ref _ResponseDeclarationXml, value); }

        /// <summary>
        /// These templates are described using the processing language defined in IMS Global APIP specification and are distributed (in XML form) along with it. Delivery engines that support generalized response processing do not need to implement special mechanisms to support them as a template file can be parsed directly while processing the assessment item that refers to it. This element provides the URL for the template.
        /// </summary>
        public System.String ResponseProcessingTemplateUrl { get => _ResponseProcessingTemplateUrl; set => SetProperty(ref _ResponseProcessingTemplateUrl, value); }

        /// <summary>
        /// These templates are described using the processing language defined in IMS Global APIP specification and are distributed (in XML form) along with it. Delivery engines that support generalized response processing do not need to implement special mechanisms to support them as a template file can be parsed directly while processing the assessment item that refers to it. This element provides the URL for the template.
        /// </summary>
        public System.String ResponseProcessingXml { get => _ResponseProcessingXml; set => SetProperty(ref _ResponseProcessingXml, value); }

        /// <summary>
        /// These templates are described using the processing language defined in IMS Global APIP specification and are distributed (in XML form) along with it. Delivery engines that support generalized response processing do not need to implement special mechanisms to support them as a template file can be parsed directly while processing the assessment item that refers to it. This element provides the URL for the template.
        /// </summary>
        public System.String TemplateDeclarationXml { get => _TemplateDeclarationXml; set => SetProperty(ref _TemplateDeclarationXml, value); }

        /// <summary>
        /// These templates are described using the processing language defined in IMS Global APIP specification and are distributed (in XML form) along with it. Delivery engines that support generalized response processing do not need to implement special mechanisms to support them as a template file can be parsed directly while processing the assessment item that refers to it. This element provides the URL for the template.
        /// </summary>
        public System.String TemplateProcessingXml { get => _TemplateProcessingXml; set => SetProperty(ref _TemplateProcessingXml, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IAssessmentItemApip model)
        {
            IsBusy = true;
            Id = model.Id;
            AdaptiveIndicator = model.AdaptiveIndicator;
            AssessmentItemId = model.AssessmentItemId;
            ItemBodyXml = model.ItemBodyXml;
            ModalFeedbackXml = model.ModalFeedbackXml;
            OutcomeDeclarationXml = model.OutcomeDeclarationXml;
            ResponseDeclarationXml = model.ResponseDeclarationXml;
            ResponseProcessingTemplateUrl = model.ResponseProcessingTemplateUrl;
            ResponseProcessingXml = model.ResponseProcessingXml;
            TemplateDeclarationXml = model.TemplateDeclarationXml;
            TemplateProcessingXml = model.TemplateProcessingXml;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
