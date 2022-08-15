//**********************************************************
//* DomainName: Common Models
//* FileName:   PersonTelephoneViewModel.cs
//**********************************************************

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The PersonTelephoneViewModel
     /// </summary>
    public partial class PersonTelephoneViewModel : ViewModelBase, Interfaces.IPersonTelephone
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from PersonTelephone";

        // member variable for the PrimaryTelephoneNumberIndicator property
        private System.Boolean _PrimaryTelephoneNumberIndicator;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the PersonTelephoneViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// An indication that the telephone number should be used as the principal number for a person or organization.
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19219">Primary Telephone Number Indicator</a>
        /// </para>
        /// </summary>
        [DisplayName("Primary Telephone Number Indicator")]
        public System.Boolean PrimaryTelephoneNumberIndicator { get => _PrimaryTelephoneNumberIndicator; set => SetProperty(ref _PrimaryTelephoneNumberIndicator, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IPersonTelephone model)
        {
            IsBusy = true;
            Id = model.Id;
            PrimaryTelephoneNumberIndicator = model.PrimaryTelephoneNumberIndicator; // Primary Telephone Number Indicator
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
