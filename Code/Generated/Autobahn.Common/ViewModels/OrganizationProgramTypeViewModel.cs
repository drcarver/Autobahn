//**********************************************************
//* DomainName: Common Models
//* FileName:   OrganizationProgramTypeViewModel.cs
//**********************************************************

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The OrganizationProgramTypeViewModel
     /// </summary>
    public partial class OrganizationProgramTypeViewModel : ViewModelBase, Interfaces.IOrganizationProgramType
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from OrganizationProgramType";

        // member variable for the OrganizationId property
        private Guid _OrganizationId;

        // member variable for the RefProgramTypeId property
        private Guid _RefProgramTypeId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the OrganizationProgramTypeViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="Organization"/> model
        /// </summary>
        public Guid OrganizationId { get => _OrganizationId; set => SetProperty(ref _OrganizationId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefProgramType"/> model
        /// </summary>
        public Guid RefProgramTypeId { get => _RefProgramTypeId; set => SetProperty(ref _RefProgramTypeId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IOrganizationProgramType model)
        {
            IsBusy = true;
            Id = model.Id;
            OrganizationId = model.OrganizationId;
            RefProgramTypeId = model.RefProgramTypeId;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
