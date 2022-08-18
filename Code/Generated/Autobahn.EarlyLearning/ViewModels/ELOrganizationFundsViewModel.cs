//**********************************************************
//* DomainName: Early Learning (EL)
//* FileName:   ELOrganizationFundsViewModel.cs
//* Name:       Record End Date Time
//* Definition: The end date and, optionally, time that a record is active as used to support version control.
//***************************************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using Autobahn.Common.Models;
using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.EarlyLearning.ViewModels
{
     /// <summary>
     /// The end date and, optionally, time that a record is active as used to support version control.
     /// </summary>
    public partial class ELOrganizationFundsViewModel : ViewModelBase, Interfaces.IELOrganizationFunds
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from ELOrganizationFunds";

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IELOrganizationFunds model)
        {
            IsBusy = true;
            Id = model.Id;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
