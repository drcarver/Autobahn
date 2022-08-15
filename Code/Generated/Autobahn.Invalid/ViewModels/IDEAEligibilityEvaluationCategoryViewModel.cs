//**********************************************************
//* DomainName: Invalid or Unreferenced Models
//* FileName:   IDEAEligibilityEvaluationCategoryViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Invalid.ViewModels
{
     /// <summary>
     /// The IDEAEligibilityEvaluationCategoryViewModel
     /// </summary>
    public partial class IDEAEligibilityEvaluationCategoryViewModel : ViewModelBase, Interfaces.IIDEAEligibilityEvaluationCategory
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from IDEAEligibilityEvaluationCategory";

        // member variable for the RefIDEAEligibilityEvaluationCategoryId property
        private Guid _RefIDEAEligibilityEvaluationCategoryId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the IDEAEligibilityEvaluationCategoryViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefIDEAEligibilityEvaluationCategory"/> model
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20710">IDEA Eligibility Evaluation Category</a>
        /// </para>
        /// </summary>
        [DisplayName("IDEA Eligibility Evaluation Category")]
        public Guid RefIDEAEligibilityEvaluationCategoryId { get => _RefIDEAEligibilityEvaluationCategoryId; set => SetProperty(ref _RefIDEAEligibilityEvaluationCategoryId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IIDEAEligibilityEvaluationCategory model)
        {
            IsBusy = true;
            Id = model.Id;
            RefIDEAEligibilityEvaluationCategoryId = model.RefIDEAEligibilityEvaluationCategoryId; // IDEA Eligibility Evaluation Category
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
