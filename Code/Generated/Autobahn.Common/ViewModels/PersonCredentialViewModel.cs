//**********************************************************
//* DomainName: Common Models
//* FileName:   PersonCredentialViewModel.cs
//**********************************************************

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The PersonCredentialViewModel
     /// </summary>
    public partial class PersonCredentialViewModel : ViewModelBase, Interfaces.IPersonCredential
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from PersonCredential";

        // member variable for the ExpirationDate property
        private System.DateTime? _ExpirationDate;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the PersonCredentialViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// The year, month, and day on which the child is no longer eligible for the  Program.
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20305">Early Learning Program Eligibility Expiration Date</a>
        /// </para>
        /// </summary>
        [DisplayName("Early Learning Program Eligibility Expiration Date")]
        public System.DateTime? ExpirationDate { get => _ExpirationDate; set => SetProperty(ref _ExpirationDate, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IPersonCredential model)
        {
            IsBusy = true;
            Id = model.Id;
            ExpirationDate = model.ExpirationDate; // Early Learning Program Eligibility Expiration Date
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
