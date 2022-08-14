//**********************************************************
//* DomainName: Common Models
//* FileName:   OrganizationIndicatorViewModel.cs
//**********************************************************

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The OrganizationIndicatorViewModel
     /// </summary>
    public partial class OrganizationIndicatorViewModel : ViewModelBase, Interfaces.IOrganizationIndicator
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from OrganizationIndicator";

        // member variable for the IndicatorValue property
        private System.String _IndicatorValue;

        // member variable for the OrganizationId property
        private Guid _OrganizationId;

        // member variable for the RefOrganizationIndicatorId property
        private Guid _RefOrganizationIndicatorId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the OrganizationIndicatorViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// An indication of whether the school has students who are ability grouped for classroom instruction in mathematics or English/reading/language arts.
        /// </summary>
        public System.String IndicatorValue { get => _IndicatorValue; set => SetProperty(ref _IndicatorValue, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="Organization"/> model
        /// </summary>
        public Guid OrganizationId { get => _OrganizationId; set => SetProperty(ref _OrganizationId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefOrganizationIndicator"/> model
        /// </summary>
        public Guid RefOrganizationIndicatorId { get => _RefOrganizationIndicatorId; set => SetProperty(ref _RefOrganizationIndicatorId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IOrganizationIndicator model)
        {
            IsBusy = true;
            Id = model.Id;
            IndicatorValue = model.IndicatorValue;
            OrganizationId = model.OrganizationId;
            RefOrganizationIndicatorId = model.RefOrganizationIndicatorId;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
