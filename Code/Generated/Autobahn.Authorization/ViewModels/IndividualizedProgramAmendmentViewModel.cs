//**********************************************************
//* DomainName: Authentication and Authorization
//* FileName:   IndividualizedProgramAmendmentViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;
using CommunityToolkit.Maui;

namespace Autobahn.Authorization.ViewModels
{
     /// <summary>
     /// The IndividualizedProgramAmendmentViewModel
     /// </summary>
    public partial class IndividualizedProgramAmendmentViewModel : ViewModelBase, Interfaces.IIndividualizedProgramAmendment
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from IndividualizedProgramAmendment";

        // member variable for the IndividualizedProgramId property
        private Guid _IndividualizedProgramId;

        // member variable for the ReasonDescription property
        private System.String _ReasonDescription;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the IndividualizedProgramAmendmentViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IndividualizedProgram"/> model
        /// </summary>
        public Guid IndividualizedProgramId { get => _IndividualizedProgramId; set => SetProperty(ref _IndividualizedProgramId, value); }

        /// <summary>
        /// Description of the reason changes were made to the individualized program service plan.
        /// </summary>
        public System.String ReasonDescription { get => _ReasonDescription; set => SetProperty(ref _ReasonDescription, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IIndividualizedProgramAmendment model)
        {
            IsBusy = true;
            Id = model.Id;
            IndividualizedProgramId = model.IndividualizedProgramId;
            ReasonDescription = model.ReasonDescription;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
