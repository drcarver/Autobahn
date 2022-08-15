//**********************************************************
//* DomainName: Facilities
//* FileName:   BuildingSystemCategoryViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Facilities.ViewModels
{
     /// <summary>
     /// The BuildingSystemCategoryViewModel
     /// </summary>
    public partial class BuildingSystemCategoryViewModel : ViewModelBase, Interfaces.IBuildingSystemCategory
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from BuildingSystemCategory";

        // member variable for the RefBuildingAirDistributionSystemTypeId property
        private Guid? _RefBuildingAirDistributionSystemTypeId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the BuildingSystemCategoryViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefBuildingAirDistributionSystemType"/> model
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20771">Building Air Distribution System Type</a>
        /// </para>
        /// </summary>
        [DisplayName("Building Air Distribution System Type")]
        public Guid? RefBuildingAirDistributionSystemTypeId { get => _RefBuildingAirDistributionSystemTypeId; set => SetProperty(ref _RefBuildingAirDistributionSystemTypeId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IBuildingSystemCategory model)
        {
            IsBusy = true;
            Id = model.Id;
            RefBuildingAirDistributionSystemTypeId = model.RefBuildingAirDistributionSystemTypeId; // Building Air Distribution System Type
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
