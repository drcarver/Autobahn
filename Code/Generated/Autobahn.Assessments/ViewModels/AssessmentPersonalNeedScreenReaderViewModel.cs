//**********************************************************
//* DomainName: Assessments
//* FileName:   AssessmentPersonalNeedScreenReaderViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Assessments.ViewModels
{
     /// <summary>
     /// The AssessmentPersonalNeedScreenReaderViewModel
     /// </summary>
    public partial class AssessmentPersonalNeedScreenReaderViewModel : ViewModelBase, Interfaces.IAssessmentPersonalNeedScreenReader
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from AssessmentPersonalNeedScreenReader";

        // member variable for the RefAssessmentNeedUsageTypeId property
        private Guid? _RefAssessmentNeedUsageTypeId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the AssessmentPersonalNeedScreenReaderViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAssessmentNeedUsageType"/> model
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20028">Assessment Need Usage Type</a>
        /// </para>
        /// </summary>
        [DisplayName("Assessment Need Usage Type")]
        public Guid? RefAssessmentNeedUsageTypeId { get => _RefAssessmentNeedUsageTypeId; set => SetProperty(ref _RefAssessmentNeedUsageTypeId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IAssessmentPersonalNeedScreenReader model)
        {
            IsBusy = true;
            Id = model.Id;
            RefAssessmentNeedUsageTypeId = model.RefAssessmentNeedUsageTypeId; // Assessment Need Usage Type
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
