//**********************************************************
//* DomainName: Facilities
//* FileName:   FacilitySchoolDesignViewModel.cs
//***************************************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using Autobahn.Common.Models;
using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Facilities.ViewModels
{
     /// <summary>
     /// The FacilitySchoolDesign View Model
     /// </summary>
    public partial class FacilitySchoolDesignViewModel : ViewModelBase, Interfaces.IFacilitySchoolDesign
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from FacilitySchoolDesign";

        // member variable for the FacilityDesignId property
        private Guid _FacilityDesignId;

        // RefBuildingSchoolDesignTypeId -- (backing property for Building School Design Type)
        private Guid _RefBuildingSchoolDesignTypeId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IFacilityDesign"/> model
        /// </summary>
        public Guid FacilityDesignId { get => _FacilityDesignId; set => SetProperty(ref _FacilityDesignId, value); }

        /// <summary>
        /// Building School Design Type
        /// <para>
        /// The physical layout and character of a school facility, as determined by age groups served and educational programs provided.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20809">Building School Design Type</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid RefBuildingSchoolDesignTypeId { get => _RefBuildingSchoolDesignTypeId; set => SetProperty(ref _RefBuildingSchoolDesignTypeId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IFacilitySchoolDesign model)
        {
            IsBusy = true;
            Id = model.Id;
            FacilityDesignId = model.FacilityDesignId; // 
            RefBuildingSchoolDesignTypeId = model.RefBuildingSchoolDesignTypeId; // Building School Design Type
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
