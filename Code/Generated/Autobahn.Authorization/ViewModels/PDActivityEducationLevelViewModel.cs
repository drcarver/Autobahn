//**********************************************************
//* DomainName: Authentication and Authorization
//* FileName:   PDActivityEducationLevelViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;
using CommunityToolkit.Maui;

namespace Autobahn.Authorization.ViewModels
{
     /// <summary>
     /// The PDActivityEducationLevelViewModel
     /// </summary>
    public partial class PDActivityEducationLevelViewModel : ViewModelBase, Interfaces.IPDActivityEducationLevel
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from PDActivityEducationLevel";

        // member variable for the ProfessionalDevelopmentActivityId property
        private Guid _ProfessionalDevelopmentActivityId;

        // member variable for the RefPDActivityEducationLevelsAddressedId property
        private Guid _RefPDActivityEducationLevelsAddressedId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the PDActivityEducationLevelViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="ProfessionalDevelopmentActivity"/> model
        /// </summary>
        public Guid ProfessionalDevelopmentActivityId { get => _ProfessionalDevelopmentActivityId; set => SetProperty(ref _ProfessionalDevelopmentActivityId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefPDActivityEducationLevelsAddressed"/> model
        /// </summary>
        public Guid RefPDActivityEducationLevelsAddressedId { get => _RefPDActivityEducationLevelsAddressedId; set => SetProperty(ref _RefPDActivityEducationLevelsAddressedId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IPDActivityEducationLevel model)
        {
            IsBusy = true;
            Id = model.Id;
            ProfessionalDevelopmentActivityId = model.ProfessionalDevelopmentActivityId;
            RefPDActivityEducationLevelsAddressedId = model.RefPDActivityEducationLevelsAddressedId;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
