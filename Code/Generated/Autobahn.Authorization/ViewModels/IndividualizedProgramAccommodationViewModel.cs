//**********************************************************
//* DomainName: Authentication and Authorization
//* FileName:   IndividualizedProgramAccommodationViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;
using CommunityToolkit.Maui;

namespace Autobahn.Authorization.ViewModels
{
     /// <summary>
     /// The IndividualizedProgramAccommodationViewModel
     /// </summary>
    public partial class IndividualizedProgramAccommodationViewModel : ViewModelBase, Interfaces.IIndividualizedProgramAccommodation
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from IndividualizedProgramAccommodation";

        // member variable for the Applicability property
        private System.String _Applicability;

        // member variable for the IndividualizedProgramId property
        private Guid _IndividualizedProgramId;

        // member variable for the RefAccommodationTypeId property
        private Guid? _RefAccommodationTypeId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the IndividualizedProgramAccommodationViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// The specific accommodation necessary for assessment or instruction.
        /// </summary>
        public System.String Applicability { get => _Applicability; set => SetProperty(ref _Applicability, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IndividualizedProgram"/> model
        /// </summary>
        public Guid IndividualizedProgramId { get => _IndividualizedProgramId; set => SetProperty(ref _IndividualizedProgramId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAccommodationType"/> model
        /// </summary>
        public Guid? RefAccommodationTypeId { get => _RefAccommodationTypeId; set => SetProperty(ref _RefAccommodationTypeId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IIndividualizedProgramAccommodation model)
        {
            IsBusy = true;
            Id = model.Id;
            Applicability = model.Applicability;
            IndividualizedProgramId = model.IndividualizedProgramId;
            RefAccommodationTypeId = model.RefAccommodationTypeId;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
