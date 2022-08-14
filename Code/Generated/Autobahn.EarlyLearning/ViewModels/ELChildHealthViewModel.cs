//**********************************************************
//* DomainName: Early Learning (EL)
//* FileName:   ELChildHealthViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

namespace Autobahn.EarlyLearning.ViewModels
{
     /// <summary>
     /// The ELChildHealthViewModel
     /// </summary>
    public partial class ELChildHealthViewModel : ViewModelBase, Interfaces.IELChildHealth
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from ELChildHealth";

        // member variable for the PersonId property
        private Guid _PersonId;

        // member variable for the RefScheduledWellChildScreeningId property
        private Guid? _RefScheduledWellChildScreeningId;

        // member variable for the WellChildScreeningReceivedDate property
        private System.DateTime? _WellChildScreeningReceivedDate;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the ELChildHealthViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="Person"/> model
        /// </summary>
        public Guid PersonId { get => _PersonId; set => SetProperty(ref _PersonId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefScheduledWellChildScreening"/> model
        /// </summary>
        public Guid? RefScheduledWellChildScreeningId { get => _RefScheduledWellChildScreeningId; set => SetProperty(ref _RefScheduledWellChildScreeningId, value); }

        /// <summary>
        /// The individual well child visit scheduled according to the AAP recommended periodicity schedule.
        /// </summary>
        public System.DateTime? WellChildScreeningReceivedDate { get => _WellChildScreeningReceivedDate; set => SetProperty(ref _WellChildScreeningReceivedDate, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IELChildHealth model)
        {
            IsBusy = true;
            Id = model.Id;
            PersonId = model.PersonId;
            RefScheduledWellChildScreeningId = model.RefScheduledWellChildScreeningId;
            WellChildScreeningReceivedDate = model.WellChildScreeningReceivedDate;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
