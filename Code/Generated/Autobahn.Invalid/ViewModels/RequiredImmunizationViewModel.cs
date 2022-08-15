//**********************************************************
//* DomainName: Invalid or Unreferenced Models
//* FileName:   RequiredImmunizationViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Invalid.ViewModels
{
     /// <summary>
     /// The RequiredImmunizationViewModel
     /// </summary>
    public partial class RequiredImmunizationViewModel : ViewModelBase, Interfaces.IRequiredImmunization
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from RequiredImmunization";

        #endregion

        #region Properties
        /// <summary>
        /// The title of the RequiredImmunizationViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IRequiredImmunization model)
        {
            IsBusy = true;
            Id = model.Id;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
