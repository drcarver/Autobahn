//**********************************************************
//* DomainName: Assessments
//* FileName:   AssessmentFormSectionViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

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

        // member variable for the GUID property
        private System.String _GUID;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the AssessmentFormSectionViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// The globally unique identifier of an Assessment using a RFC 4122 compliant hexadecimal string.
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19982">Assessment GUID</a>
        /// </para>
        /// </summary>
        [DisplayName("Assessment GUID")]
        public System.String GUID { get => _GUID; set => SetProperty(ref _GUID, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IAssessmentFormSection model)
        {
            IsBusy = true;
            Id = model.Id;
            GUID = model.GUID; // Assessment GUID
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
