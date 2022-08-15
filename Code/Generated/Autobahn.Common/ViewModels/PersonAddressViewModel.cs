//**********************************************************
//* DomainName: Common Models
//* FileName:   PersonAddressViewModel.cs
//**********************************************************

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The PersonAddressViewModel
     /// </summary>
    public partial class PersonAddressViewModel : ViewModelBase, Interfaces.IPersonAddress
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from PersonAddress";

        // member variable for the ApartmentRoomOrSuiteNumber property
        private System.String _ApartmentRoomOrSuiteNumber;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the PersonAddressViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// The apartment, room, or suite number of an address.
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19019">Address Apartment Room or Suite Number</a>
        /// </para>
        /// </summary>
        [DisplayName("Address Apartment Room or Suite Number")]
        public System.String ApartmentRoomOrSuiteNumber { get => _ApartmentRoomOrSuiteNumber; set => SetProperty(ref _ApartmentRoomOrSuiteNumber, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IPersonAddress model)
        {
            IsBusy = true;
            Id = model.Id;
            ApartmentRoomOrSuiteNumber = model.ApartmentRoomOrSuiteNumber; // Address Apartment Room or Suite Number
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
