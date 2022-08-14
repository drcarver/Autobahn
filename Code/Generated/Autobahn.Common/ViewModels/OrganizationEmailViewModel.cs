//**********************************************************
//* DomainName: Common Models
//* FileName:   OrganizationEmailViewModel.cs
//**********************************************************

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The OrganizationEmailViewModel
     /// </summary>
    public partial class OrganizationEmailViewModel : ViewModelBase, Interfaces.IOrganizationEmail
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from OrganizationEmail";

        // member variable for the DoNotPublishIndicator property
        private System.Boolean? _DoNotPublishIndicator;

        // member variable for the ElectronicMailAddress property
        private System.String _ElectronicMailAddress;

        // member variable for the OrganizationId property
        private Guid _OrganizationId;

        // member variable for the RefEmailTypeId property
        private Guid? _RefEmailTypeId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the OrganizationEmailViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// The numbers, letters, and symbols used to identify an electronic mail (e-mail) user within the network to which the person or organization belongs.
        /// </summary>
        public System.Boolean? DoNotPublishIndicator { get => _DoNotPublishIndicator; set => SetProperty(ref _DoNotPublishIndicator, value); }

        /// <summary>
        /// The numbers, letters, and symbols used to identify an electronic mail (e-mail) user within the network to which the person or organization belongs.
        /// </summary>
        public System.String ElectronicMailAddress { get => _ElectronicMailAddress; set => SetProperty(ref _ElectronicMailAddress, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="Organization"/> model
        /// </summary>
        public Guid OrganizationId { get => _OrganizationId; set => SetProperty(ref _OrganizationId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefEmailType"/> model
        /// </summary>
        public Guid? RefEmailTypeId { get => _RefEmailTypeId; set => SetProperty(ref _RefEmailTypeId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IOrganizationEmail model)
        {
            IsBusy = true;
            Id = model.Id;
            DoNotPublishIndicator = model.DoNotPublishIndicator;
            ElectronicMailAddress = model.ElectronicMailAddress;
            OrganizationId = model.OrganizationId;
            RefEmailTypeId = model.RefEmailTypeId;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
