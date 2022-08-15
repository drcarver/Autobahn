//**********************************************************
//* DomainName: Facilities
//* FileName:   BuildingSystemComponentViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Facilities.ViewModels
{
     /// <summary>
     /// The BuildingSystemComponentViewModel
     /// </summary>
    public partial class BuildingSystemComponentViewModel : ViewModelBase, Interfaces.IBuildingSystemComponent
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from BuildingSystemComponent";

        // member variable for the RefFacilitySystemOrComponentConditionId property
        private Guid? _RefFacilitySystemOrComponentConditionId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the BuildingSystemComponentViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefFacilitySystemOrComponentCondition"/> model
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20774">Facility System or Component Condition</a>
        /// </para>
        /// </summary>
        [DisplayName("Facility System or Component Condition")]
        public Guid? RefFacilitySystemOrComponentConditionId { get => _RefFacilitySystemOrComponentConditionId; set => SetProperty(ref _RefFacilitySystemOrComponentConditionId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IBuildingSystemComponent model)
        {
            IsBusy = true;
            Id = model.Id;
            RefFacilitySystemOrComponentConditionId = model.RefFacilitySystemOrComponentConditionId; // Facility System or Component Condition
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
