//**********************************************************
//* DomainName: Assessments
//* FileName:   AssessmentItemApipViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

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
        private  _AdaptiveIndicator;

        // member variable for the ItemBodyXml property
        private  _ItemBodyXml;

        // member variable for the ModalFeedbackXml property
        private  _ModalFeedbackXml;

        // member variable for the OutcomeDeclarationXml property
        private  _OutcomeDeclarationXml;

        // member variable for the RecordEndDateTime property
        private  _RecordEndDateTime;

        // member variable for the RecordStartDateTime property
        private  _RecordStartDateTime;

        // member variable for the ResponseDeclarationXml property
        private  _ResponseDeclarationXml;

        // member variable for the ResponseProcessingTemplateUrl property
        private Guid? _ResponseProcessingTemplateUrl;

        // member variable for the ResponseProcessingXml property
        private  _ResponseProcessingXml;

        // member variable for the TemplateDeclarationXml property
        private  _TemplateDeclarationXml;

        // member variable for the TemplateProcessingXml property
        private  _TemplateProcessingXml;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// </summary>
        public  AdaptiveIndicator { get => _AdaptiveIndicator; set => SetProperty(ref _AdaptiveIndicator, value); }

        /// <summary>
        /// </summary>
        public  ItemBodyXml { get => _ItemBodyXml; set => SetProperty(ref _ItemBodyXml, value); }

        /// <summary>
        /// </summary>
        public  ModalFeedbackXml { get => _ModalFeedbackXml; set => SetProperty(ref _ModalFeedbackXml, value); }

        /// <summary>
        /// </summary>
        public  OutcomeDeclarationXml { get => _OutcomeDeclarationXml; set => SetProperty(ref _OutcomeDeclarationXml, value); }

        /// <summary>
        /// </summary>
        public  RecordEndDateTime { get => _RecordEndDateTime; set => SetProperty(ref _RecordEndDateTime, value); }

        /// <summary>
        /// </summary>
        public  RecordStartDateTime { get => _RecordStartDateTime; set => SetProperty(ref _RecordStartDateTime, value); }

        /// <summary>
        /// </summary>
        public  ResponseDeclarationXml { get => _ResponseDeclarationXml; set => SetProperty(ref _ResponseDeclarationXml, value); }

        /// <summary>
        /// </summary>
        public Guid? ResponseProcessingTemplateUrl { get => _ResponseProcessingTemplateUrl; set => SetProperty(ref _ResponseProcessingTemplateUrl, value); }

        /// <summary>
        /// </summary>
        public  ResponseProcessingXml { get => _ResponseProcessingXml; set => SetProperty(ref _ResponseProcessingXml, value); }

        /// <summary>
        /// </summary>
        public  TemplateDeclarationXml { get => _TemplateDeclarationXml; set => SetProperty(ref _TemplateDeclarationXml, value); }

        /// <summary>
        /// </summary>
        public  TemplateProcessingXml { get => _TemplateProcessingXml; set => SetProperty(ref _TemplateProcessingXml, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IAssessmentItemApip model)
        {
            IsBusy = true;
            Id = model.Id;
            AdaptiveIndicator = model.AdaptiveIndicator; // 
            ItemBodyXml = model.ItemBodyXml; // 
            ModalFeedbackXml = model.ModalFeedbackXml; // 
            OutcomeDeclarationXml = model.OutcomeDeclarationXml; // 
            RecordEndDateTime = model.RecordEndDateTime; // 
            RecordStartDateTime = model.RecordStartDateTime; // 
            ResponseDeclarationXml = model.ResponseDeclarationXml; // 
            ResponseProcessingTemplateUrl = model.ResponseProcessingTemplateUrl; // 
            ResponseProcessingXml = model.ResponseProcessingXml; // 
            TemplateDeclarationXml = model.TemplateDeclarationXml; // 
            TemplateProcessingXml = model.TemplateProcessingXml; // 
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
