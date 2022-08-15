//**********************************************************
//* DomainName: Common Models
//* FileName:   PersonEmailAddressViewModel.cs
//**********************************************************

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The PersonEmailAddressViewModel
     /// </summary>
    public partial class PersonEmailAddressViewModel : ViewModelBase, Interfaces.IPersonEmailAddress
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from PersonEmailAddress";

        // member variable for the EmailAddress property
        private System.String _EmailAddress;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the PersonEmailAddressViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// The numbers, letters, and symbols used to identify an electronic mail (e-mail) user within the network to which the person or organization belongs.
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19088">Electronic Mail Address</a>
        /// </para>
        /// </summary>
        [DisplayName("Electronic Mail Address")]
        public System.String EmailAddress { get => _EmailAddress; set => SetProperty(ref _EmailAddress, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IPersonEmailAddress model)
        {
            IsBusy = true;
            Id = model.Id;
            EmailAddress = model.EmailAddress; // Electronic Mail Address
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
