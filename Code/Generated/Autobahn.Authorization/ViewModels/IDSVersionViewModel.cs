//**********************************************************
//* DomainName: Authentication and Authorization
//* FileName:   IDSVersionViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;
using CommunityToolkit.Maui;

namespace Autobahn.Authorization.ViewModels
{
     /// <summary>
     /// The IDSVersionViewModel
     /// </summary>
    public partial class IDSVersionViewModel : ViewModelBase, Interfaces.IIDSVersion
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from IDSVersion";

        // member variable for the CurrentVersion property
        private System.Boolean _CurrentVersion;

        // member variable for the IDSVersionDate property
        private System.DateTime _IDSVersionDate;

        // member variable for the IDSVersionNumber property
        private System.String _IDSVersionNumber;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the IDSVersionViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// 
        /// </summary>
        public System.Boolean CurrentVersion { get => _CurrentVersion; set => SetProperty(ref _CurrentVersion, value); }

        /// <summary>
        /// 
        /// </summary>
        public System.DateTime IDSVersionDate { get => _IDSVersionDate; set => SetProperty(ref _IDSVersionDate, value); }

        /// <summary>
        /// 
        /// </summary>
        public System.String IDSVersionNumber { get => _IDSVersionNumber; set => SetProperty(ref _IDSVersionNumber, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IIDSVersion model)
        {
            IsBusy = true;
            Id = model.Id;
            CurrentVersion = model.CurrentVersion;
            IDSVersionDate = model.IDSVersionDate;
            IDSVersionNumber = model.IDSVersionNumber;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
