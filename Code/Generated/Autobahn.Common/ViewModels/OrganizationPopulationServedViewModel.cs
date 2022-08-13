//**********************************************************
//* DomainName: Common Models
//* FileName:   OrganizationPopulationServedViewModel.cs
//**********************************************************

using CommunityToolkit.Maui;

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The OrganizationPopulationServedViewModel
     /// </summary>
    public partial class OrganizationPopulationServedViewModel : ViewModelBase, Interfaces.IOrganizationPopulationServed
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from OrganizationPopulationServed";

        // member variable for the AgeUnit property
        private System.String _AgeUnit;

        // member variable for the OldestAgeServed property
        private System.Int32? _OldestAgeServed;

        // member variable for the OrganizationId property
        private Guid _OrganizationId;

        // member variable for the RefPopulationServedId property
        private Guid? _RefPopulationServedId;

        // member variable for the YoungestAgeServed property
        private System.Int32? _YoungestAgeServed;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the OrganizationPopulationServedViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// The youngest age of children a class/group is authorized or licensed to serve.  (Age is specified in months)
        /// </summary>
        public System.String AgeUnit { get => _AgeUnit; set => SetProperty(ref _AgeUnit, value); }

        /// <summary>
        /// The youngest age of children a class/group is authorized or licensed to serve.  (Age is specified in months)
        /// </summary>
        public System.Int32? OldestAgeServed { get => _OldestAgeServed; set => SetProperty(ref _OldestAgeServed, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="Organization"/> model
        /// </summary>
        public Guid OrganizationId { get => _OrganizationId; set => SetProperty(ref _OrganizationId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefPopulationServed"/> model
        /// </summary>
        public Guid? RefPopulationServedId { get => _RefPopulationServedId; set => SetProperty(ref _RefPopulationServedId, value); }

        /// <summary>
        /// The youngest age of children a class/group is authorized or licensed to serve.  (Age is specified in months)
        /// </summary>
        public System.Int32? YoungestAgeServed { get => _YoungestAgeServed; set => SetProperty(ref _YoungestAgeServed, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IOrganizationPopulationServed model)
        {
            IsBusy = true;
            Id = model.Id;
            AgeUnit = model.AgeUnit;
            OldestAgeServed = model.OldestAgeServed;
            OrganizationId = model.OrganizationId;
            RefPopulationServedId = model.RefPopulationServedId;
            YoungestAgeServed = model.YoungestAgeServed;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
