//**********************************************************
//* DomainName: Facilities
//* FileName:   FacilitySchoolDesignViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Facilities.ViewModels
{
     /// <summary>
     /// The FacilitySchoolDesignViewModel
     /// </summary>
    public partial class FacilitySchoolDesignViewModel : ViewModelBase, Interfaces.IFacilitySchoolDesign
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from FacilitySchoolDesign";

        // member variable for the RefBuildingSchoolDesignTypeId property
        private Guid _RefBuildingSchoolDesignTypeId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the FacilitySchoolDesignViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefBuildingSchoolDesignType"/> model
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20809">Building School Design Type</a>
        /// </para>
        /// </summary>
        [DisplayName("Building School Design Type")]
        public Guid RefBuildingSchoolDesignTypeId { get => _RefBuildingSchoolDesignTypeId; set => SetProperty(ref _RefBuildingSchoolDesignTypeId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IFacilitySchoolDesign model)
        {
            IsBusy = true;
            Id = model.Id;
            RefBuildingSchoolDesignTypeId = model.RefBuildingSchoolDesignTypeId; // Building School Design Type
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
