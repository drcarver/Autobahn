//**********************************************************
//* DomainName: Facilities
//* FileName:   FacilityJointUseViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Facilities.ViewModels
{
     /// <summary>
     /// The FacilityJointUseViewModel
     /// </summary>
    public partial class FacilityJointUseViewModel : ViewModelBase, Interfaces.IFacilityJointUse
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from FacilityJointUse";

        // member variable for the RefBuildingJointUseRationaleTypeId property
        private Guid? _RefBuildingJointUseRationaleTypeId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the FacilityJointUseViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefBuildingJointUseRationaleType"/> model
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20833">Building Joint Use Rationale Type</a>
        /// </para>
        /// </summary>
        [DisplayName("Building Joint Use Rationale Type")]
        public Guid? RefBuildingJointUseRationaleTypeId { get => _RefBuildingJointUseRationaleTypeId; set => SetProperty(ref _RefBuildingJointUseRationaleTypeId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IFacilityJointUse model)
        {
            IsBusy = true;
            Id = model.Id;
            RefBuildingJointUseRationaleTypeId = model.RefBuildingJointUseRationaleTypeId; // Building Joint Use Rationale Type
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
