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

        // member variable for the ResponseProcessingTemplateUrl property
        private System.String _ResponseProcessingTemplateUrl;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the AssessmentItemApipViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// These templates are described using the processing language defined in IMS Global APIP specification and are distributed (in XML form) along with it. Delivery engines that support generalized response processing do not need to implement special mechanisms to support them as a template file can be parsed directly while processing the assessment item that refers to it. This element provides the URL for the template.
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20103">Assessment Item APIP Response Processing Template URL</a>
        /// </para>
        /// </summary>
        [DisplayName("Assessment Item APIP Response Processing Template URL")]
        public System.String ResponseProcessingTemplateUrl { get => _ResponseProcessingTemplateUrl; set => SetProperty(ref _ResponseProcessingTemplateUrl, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IAssessmentItemApip model)
        {
            IsBusy = true;
            Id = model.Id;
            ResponseProcessingTemplateUrl = model.ResponseProcessingTemplateUrl; // Assessment Item APIP Response Processing Template URL
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
