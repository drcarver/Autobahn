//**********************************************************
//* DomainName: Early Learning (EL)
//* FileName:   ELOrganizationAvailabilityViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.EarlyLearning.ViewModels
{
     /// <summary>
     /// The ELOrganizationAvailabilityViewModel
     /// </summary>
    public partial class ELOrganizationAvailabilityViewModel : ViewModelBase, Interfaces.IELOrganizationAvailability
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from ELOrganizationAvailability";

        // member variable for the RefServiceOptionId property
        private Guid? _RefServiceOptionId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the ELOrganizationAvailabilityViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefServiceOption"/> model
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19352">Service Option Variation</a>
        /// </para>
        /// </summary>
        [DisplayName("Service Option Variation")]
        public Guid? RefServiceOptionId { get => _RefServiceOptionId; set => SetProperty(ref _RefServiceOptionId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IELOrganizationAvailability model)
        {
            IsBusy = true;
            Id = model.Id;
            RefServiceOptionId = model.RefServiceOptionId; // Service Option Variation
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
