//**********************************************************
//* DomainName: Facilities
//* FileName:   FacilityManagementViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Facilities.ViewModels
{
     /// <summary>
     /// The FacilityManagementViewModel
     /// </summary>
    public partial class FacilityManagementViewModel : ViewModelBase, Interfaces.IFacilityManagement
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from FacilityManagement";

        // member variable for the RefBuildingCharterSchoolRealtyAccessTypeId property
        private Guid? _RefBuildingCharterSchoolRealtyAccessTypeId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the FacilityManagementViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefBuildingCharterSchoolRealtyAccessType"/> model
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20846">Building Charter School Realty Access Type</a>
        /// </para>
        /// </summary>
        [DisplayName("Building Charter School Realty Access Type")]
        public Guid? RefBuildingCharterSchoolRealtyAccessTypeId { get => _RefBuildingCharterSchoolRealtyAccessTypeId; set => SetProperty(ref _RefBuildingCharterSchoolRealtyAccessTypeId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IFacilityManagement model)
        {
            IsBusy = true;
            Id = model.Id;
            RefBuildingCharterSchoolRealtyAccessTypeId = model.RefBuildingCharterSchoolRealtyAccessTypeId; // Building Charter School Realty Access Type
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
