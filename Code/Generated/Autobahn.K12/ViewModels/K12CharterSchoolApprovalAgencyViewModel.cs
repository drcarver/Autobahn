//**********************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12CharterSchoolApprovalAgencyViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;
using CommunityToolkit.Maui;

namespace Autobahn.K12.ViewModels
{
     /// <summary>
     /// The K12CharterSchoolApprovalAgencyViewModel
     /// </summary>
    public partial class K12CharterSchoolApprovalAgencyViewModel : ViewModelBase, Interfaces.IK12CharterSchoolApprovalAgency
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from K12CharterSchoolApprovalAgency";

        #endregion

        #region Properties
        /// <summary>
        /// The title of the K12CharterSchoolApprovalAgencyViewModel
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
