//**********************************************************
//* DomainName: Facilities
//* FileName:   FacilityDesignConstructionViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Facilities.ViewModels
{
     /// <summary>
     /// The FacilityDesignConstructionViewModel
     /// </summary>
    public partial class FacilityDesignConstructionViewModel : ViewModelBase, Interfaces.IFacilityDesignConstruction
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from FacilityDesignConstruction";

        // member variable for the FacilityAdditionYear property
        private System.String _FacilityAdditionYear;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the FacilityDesignConstructionViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// The year the construction on the addition was completed.
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20750">Facility Addition Year</a>
        /// </para>
        /// </summary>
        [DisplayName("Facility Addition Year")]
        public System.String FacilityAdditionYear { get => _FacilityAdditionYear; set => SetProperty(ref _FacilityAdditionYear, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IFacilityDesignConstruction model)
        {
            IsBusy = true;
            Id = model.Id;
            FacilityAdditionYear = model.FacilityAdditionYear; // Facility Addition Year
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
