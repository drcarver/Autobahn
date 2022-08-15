//**********************************************************
//* DomainName: Invalid or Unreferenced Models
//* FileName:   IEPAuthorizationRejectedViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Invalid.ViewModels
{
     /// <summary>
     /// The IEPAuthorizationRejectedViewModel
     /// </summary>
    public partial class IEPAuthorizationRejectedViewModel : ViewModelBase, Interfaces.IIEPAuthorizationRejected
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from IEPAuthorizationRejected";

        // member variable for the PortionDescription property
        private System.String _PortionDescription;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the IEPAuthorizationRejectedViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Portion the authorizer does not want executed.
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20704">IEP Authorization Rejected Portion Description</a>
        /// </para>
        /// </summary>
        [DisplayName("IEP Authorization Rejected Portion Description")]
        public System.String PortionDescription { get => _PortionDescription; set => SetProperty(ref _PortionDescription, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IIEPAuthorizationRejected model)
        {
            IsBusy = true;
            Id = model.Id;
            PortionDescription = model.PortionDescription; // IEP Authorization Rejected Portion Description
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
