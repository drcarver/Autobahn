//**********************************************************
//* DomainName: Invalid or Unreferenced Models
//* FileName:   C_CEDStoNDSMappingViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Invalid.ViewModels
{
     /// <summary>
     /// The C_CEDStoNDSMappingViewModel
     /// </summary>
    public partial class C_CEDStoNDSMappingViewModel : ViewModelBase, Interfaces.IC_CEDStoNDSMapping
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from C_CEDStoNDSMapping";

        // member variable for the GlobalID property
        private System.String _GlobalID;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the C_CEDStoNDSMappingViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// </summary>
        public System.String GlobalID { get => _GlobalID; set => SetProperty(ref _GlobalID, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IC_CEDStoNDSMapping model)
        {
            IsBusy = true;
            Id = model.Id;
            GlobalID = model.GlobalID; // 
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
