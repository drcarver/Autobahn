//**********************************************************
//* DomainName: Facilities
//* FileName:   BuildingSpaceViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Facilities.ViewModels
{
     /// <summary>
     /// The BuildingSpaceViewModel
     /// </summary>
    public partial class BuildingSpaceViewModel : ViewModelBase, Interfaces.IBuildingSpace
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from BuildingSpace";

        // member variable for the SpaceDescription property
        private System.String _SpaceDescription;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the BuildingSpaceViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// A description of the space, as determined by its physical layout and built-in systems and equipment.
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20174">Facility Space Description</a>
        /// </para>
        /// </summary>
        [DisplayName("Facility Space Description")]
        public System.String SpaceDescription { get => _SpaceDescription; set => SetProperty(ref _SpaceDescription, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IBuildingSpace model)
        {
            IsBusy = true;
            Id = model.Id;
            SpaceDescription = model.SpaceDescription; // Facility Space Description
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
