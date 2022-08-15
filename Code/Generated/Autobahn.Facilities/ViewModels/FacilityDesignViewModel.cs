//**********************************************************
//* DomainName: Facilities
//* FileName:   FacilityDesignViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Facilities.ViewModels
{
     /// <summary>
     /// The FacilityDesignViewModel
     /// </summary>
    public partial class FacilityDesignViewModel : ViewModelBase, Interfaces.IFacilityDesign
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from FacilityDesign";

        // member variable for the RefBuildingDesignTypeId property
        private Guid? _RefBuildingDesignTypeId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the FacilityDesignViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefBuildingDesignType"/> model
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20797">Building Design Type</a>
        /// </para>
        /// </summary>
        [DisplayName("Building Design Type")]
        public Guid? RefBuildingDesignTypeId { get => _RefBuildingDesignTypeId; set => SetProperty(ref _RefBuildingDesignTypeId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IFacilityDesign model)
        {
            IsBusy = true;
            Id = model.Id;
            RefBuildingDesignTypeId = model.RefBuildingDesignTypeId; // Building Design Type
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
