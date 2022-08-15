//**********************************************************
//* DomainName: Common Models
//* FileName:   StaffEvaluationViewModel.cs
//**********************************************************

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The StaffEvaluationViewModel
     /// </summary>
    public partial class StaffEvaluationViewModel : ViewModelBase, Interfaces.IStaffEvaluation
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from StaffEvaluation";

        // member variable for the Outcome property
        private System.String _Outcome;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the StaffEvaluationViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// The result of an assessment of a person's performance.
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19102">Staff Evaluation Outcome</a>
        /// </para>
        /// </summary>
        [DisplayName("Staff Evaluation Outcome")]
        public System.String Outcome { get => _Outcome; set => SetProperty(ref _Outcome, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IStaffEvaluation model)
        {
            IsBusy = true;
            Id = model.Id;
            Outcome = model.Outcome; // Staff Evaluation Outcome
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
