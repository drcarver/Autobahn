//**********************************************************
//* DomainName: Early Learning (EL)
//* FileName:   ELEnrollmentOtherFundingViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.EarlyLearning.ViewModels
{
     /// <summary>
     /// The ELEnrollmentOtherFundingViewModel
     /// </summary>
    public partial class ELEnrollmentOtherFundingViewModel : ViewModelBase, Interfaces.IELEnrollmentOtherFunding
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from ELEnrollmentOtherFunding";

        #endregion

        #region Properties
        /// <summary>
        /// The title of the ELEnrollmentOtherFundingViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IELEnrollmentOtherFunding model)
        {
            IsBusy = true;
            Id = model.Id;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
