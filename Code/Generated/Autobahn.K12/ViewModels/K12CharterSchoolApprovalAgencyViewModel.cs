//**********************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12CharterSchoolApprovalAgencyViewModel.cs
//* Name:       Record End Date Time
//* Definition: The end date and, optionally, time that a record is active as used to support version control.
//***************************************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using Autobahn.Common.Models;
using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.K12.ViewModels
{
     /// <summary>
     /// The end date and, optionally, time that a record is active as used to support version control.
     /// </summary>
    public partial class K12CharterSchoolApprovalAgencyViewModel : ViewModelBase, Interfaces.IK12CharterSchoolApprovalAgency
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from K12CharterSchoolApprovalAgency";

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
        public void Load(Interfaces.IK12CharterSchoolApprovalAgency model)
        {
            IsBusy = true;
            Id = model.Id;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
