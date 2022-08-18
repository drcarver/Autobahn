//**********************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   IDEAEligibilityEvaluationCategoryViewModel.cs
//***************************************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using Autobahn.Common.Models;
using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.K12.ViewModels
{
     /// <summary>
     /// The IDEAEligibilityEvaluationCategory View Model
     /// </summary>
    public partial class IDEAEligibilityEvaluationCategoryViewModel : ViewModelBase, Interfaces.IIDEAEligibilityEvaluationCategory
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from IDEAEligibilityEvaluationCategory";

        // member variable for the EligibilityEvaluationId property
        private Guid _EligibilityEvaluationId;

        // RefIDEAEligibilityEvaluationCategoryId -- (backing property for IDEA Eligibility Evaluation Category)
        private Guid _RefIDEAEligibilityEvaluationCategoryId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IEligibilityEvaluation"/> model
        /// </summary>
        public Guid EligibilityEvaluationId { get => _EligibilityEvaluationId; set => SetProperty(ref _EligibilityEvaluationId, value); }

        /// <summary>
        /// IDEA Eligibility Evaluation Category
        /// <para>
        /// Category of evaluation used for IDEA eligibility.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20710">IDEA Eligibility Evaluation Category</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid RefIDEAEligibilityEvaluationCategoryId { get => _RefIDEAEligibilityEvaluationCategoryId; set => SetProperty(ref _RefIDEAEligibilityEvaluationCategoryId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IIDEAEligibilityEvaluationCategory model)
        {
            IsBusy = true;
            Id = model.Id;
            EligibilityEvaluationId = model.EligibilityEvaluationId; // 
            RefIDEAEligibilityEvaluationCategoryId = model.RefIDEAEligibilityEvaluationCategoryId; // IDEA Eligibility Evaluation Category
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
