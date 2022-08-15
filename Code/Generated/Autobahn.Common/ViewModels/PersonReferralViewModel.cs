//**********************************************************
//* DomainName: Common Models
//* FileName:   PersonReferralViewModel.cs
//**********************************************************

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The PersonReferralViewModel
     /// </summary>
    public partial class PersonReferralViewModel : ViewModelBase, Interfaces.IPersonReferral
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from PersonReferral";

        // member variable for the ReferralDate property
        private System.DateTime? _ReferralDate;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the PersonReferralViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// The date of referral.
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20453">Referral Date</a>
        /// </para>
        /// </summary>
        [DisplayName("Referral Date")]
        public System.DateTime? ReferralDate { get => _ReferralDate; set => SetProperty(ref _ReferralDate, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IPersonReferral model)
        {
            IsBusy = true;
            Id = model.Id;
            ReferralDate = model.ReferralDate; // Referral Date
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
