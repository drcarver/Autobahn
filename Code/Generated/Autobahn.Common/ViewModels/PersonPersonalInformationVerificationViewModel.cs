//**********************************************************
//* DomainName: Common Models
//* FileName:   PersonPersonalInformationVerificationViewModel.cs
//**********************************************************

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The PersonPersonalInformationVerificationViewModel
     /// </summary>
    public partial class PersonPersonalInformationVerificationViewModel : ViewModelBase, Interfaces.IPersonPersonalInformationVerification
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from PersonPersonalInformationVerification";

        // member variable for the RefPersonalInformationVerificationId property
        private Guid? _RefPersonalInformationVerificationId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the PersonPersonalInformationVerificationViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefPersonalInformationVerification"/> model
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19611">Personal Information Verification</a>
        /// </para>
        /// </summary>
        [DisplayName("Personal Information Verification")]
        public Guid? RefPersonalInformationVerificationId { get => _RefPersonalInformationVerificationId; set => SetProperty(ref _RefPersonalInformationVerificationId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IPersonPersonalInformationVerification model)
        {
            IsBusy = true;
            Id = model.Id;
            RefPersonalInformationVerificationId = model.RefPersonalInformationVerificationId; // Personal Information Verification
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
