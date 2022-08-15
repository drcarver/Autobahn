//**********************************************************
//* DomainName: Assessments
//* FileName:   AssessmentItemViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Assessments.ViewModels
{
     /// <summary>
     /// The AssessmentItemViewModel
     /// </summary>
    public partial class AssessmentItemViewModel : ViewModelBase, Interfaces.IAssessmentItem
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from AssessmentItem";

        // member variable for the RefAssessmentItemTypeId property
        private Guid? _RefAssessmentItemTypeId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the AssessmentItemViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAssessmentItemType"/> model
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19382">Assessment Item Type</a>
        /// </para>
        /// </summary>
        [DisplayName("Assessment Item Type")]
        public Guid? RefAssessmentItemTypeId { get => _RefAssessmentItemTypeId; set => SetProperty(ref _RefAssessmentItemTypeId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IAssessmentItem model)
        {
            IsBusy = true;
            Id = model.Id;
            RefAssessmentItemTypeId = model.RefAssessmentItemTypeId; // Assessment Item Type
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
