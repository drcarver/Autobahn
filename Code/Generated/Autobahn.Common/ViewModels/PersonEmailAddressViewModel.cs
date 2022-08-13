//**********************************************************
//* DomainName: Common Models
//* FileName:   PersonEmailAddressViewModel.cs
//**********************************************************

using CommunityToolkit.Maui;

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

        // member variable for the DoNotPublishIndicator property
        private System.Boolean? _DoNotPublishIndicator;

        // member variable for the EmailAddress property
        private System.String _EmailAddress;

        // member variable for the PersonId property
        private Guid _PersonId;

        // member variable for the RefEmailTypeId property
        private Guid? _RefEmailTypeId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the PersonEmailAddressViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// The numbers, letters, and symbols used to identify an electronic mail (e-mail) user within the network to which the person or organization belongs.
        /// </summary>
        public System.Boolean? DoNotPublishIndicator { get => _DoNotPublishIndicator; set => SetProperty(ref _DoNotPublishIndicator, value); }

        /// <summary>
        /// The numbers, letters, and symbols used to identify an electronic mail (e-mail) user within the network to which the person or organization belongs.
        /// </summary>
        public System.String EmailAddress { get => _EmailAddress; set => SetProperty(ref _EmailAddress, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="Person"/> model
        /// </summary>
        public Guid PersonId { get => _PersonId; set => SetProperty(ref _PersonId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefEmailType"/> model
        /// </summary>
        public Guid? RefEmailTypeId { get => _RefEmailTypeId; set => SetProperty(ref _RefEmailTypeId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IPersonEmailAddress model)
        {
            IsBusy = true;
            Id = model.Id;
            DoNotPublishIndicator = model.DoNotPublishIndicator;
            EmailAddress = model.EmailAddress;
            PersonId = model.PersonId;
            RefEmailTypeId = model.RefEmailTypeId;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
