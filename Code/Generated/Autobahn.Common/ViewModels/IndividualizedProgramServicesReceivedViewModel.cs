//**********************************************************
//* DomainName: Common Models
//* FileName:   IndividualizedProgramServicesReceivedViewModel.cs
//***************************************************************************

using Autobahn.Common.Models;
using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The IndividualizedProgramServicesReceived View Model
     /// </summary>
    public partial class IndividualizedProgramServicesReceivedViewModel : ViewModelBase, Interfaces.IIndividualizedProgramServicesReceived
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from IndividualizedProgramServicesReceived";

        // member variable for the IndividualizedProgramId property
        private Guid _IndividualizedProgramId;

        // member variable for the ServicesReceivedId property
        private Guid _ServicesReceivedId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IIndividualizedProgram"/> model
        /// </summary>
        public Guid IndividualizedProgramId { get => _IndividualizedProgramId; set => SetProperty(ref _IndividualizedProgramId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IServicesReceived"/> model
        /// </summary>
        public Guid ServicesReceivedId { get => _ServicesReceivedId; set => SetProperty(ref _ServicesReceivedId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IIndividualizedProgramServicesReceived model)
        {
            IsBusy = true;
            Id = model.Id;
            IndividualizedProgramId = model.IndividualizedProgramId; // 
            ServicesReceivedId = model.ServicesReceivedId; // 
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
