//**********************************************************
//* DomainName: Common Models
//* FileName:   StaffEvaluationPartViewModel.cs
//**********************************************************

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The StaffEvaluationPartViewModel
     /// </summary>
    public partial class StaffEvaluationPartViewModel : ViewModelBase, Interfaces.IStaffEvaluationPart
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from StaffEvaluationPart";

        #endregion

        #region Properties
        /// <summary>
        /// The title of the StaffEvaluationPartViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IStaffEvaluationPart model)
        {
            IsBusy = true;
            Id = model.Id;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
