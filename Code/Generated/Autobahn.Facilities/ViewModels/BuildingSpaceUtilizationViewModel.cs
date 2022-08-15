//**********************************************************
//* DomainName: Facilities
//* FileName:   BuildingSpaceUtilizationViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Facilities.ViewModels
{
     /// <summary>
     /// The BuildingSpaceUtilizationViewModel
     /// </summary>
    public partial class BuildingSpaceUtilizationViewModel : ViewModelBase, Interfaces.IBuildingSpaceUtilization
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from BuildingSpaceUtilization";

        // member variable for the RefBuildingInstructionalSpaceFactorTypeId property
        private Guid? _RefBuildingInstructionalSpaceFactorTypeId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the BuildingSpaceUtilizationViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefBuildingInstructionalSpaceFactorType"/> model
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20832">Building Instructional Space Factor Type</a>
        /// </para>
        /// </summary>
        [DisplayName("Building Instructional Space Factor Type")]
        public Guid? RefBuildingInstructionalSpaceFactorTypeId { get => _RefBuildingInstructionalSpaceFactorTypeId; set => SetProperty(ref _RefBuildingInstructionalSpaceFactorTypeId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IBuildingSpaceUtilization model)
        {
            IsBusy = true;
            Id = model.Id;
            RefBuildingInstructionalSpaceFactorTypeId = model.RefBuildingInstructionalSpaceFactorTypeId; // Building Instructional Space Factor Type
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
