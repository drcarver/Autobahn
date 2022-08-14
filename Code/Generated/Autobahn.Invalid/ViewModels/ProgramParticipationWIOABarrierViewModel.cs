//**********************************************************
//* DomainName: Invalid or Unreferenced Models
//* FileName:   ProgramParticipationWIOABarrierViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

namespace Autobahn.Invalid.ViewModels
{
     /// <summary>
     /// The ProgramParticipationWIOABarrierViewModel
     /// </summary>
    public partial class ProgramParticipationWIOABarrierViewModel : ViewModelBase, Interfaces.IProgramParticipationWIOABarrier
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from ProgramParticipationWIOABarrier";

        // member variable for the ProgramParticipationWIOABarriersId property
        private Guid _ProgramParticipationWIOABarriersId;

        // member variable for the ProgramParticipationWIOAId property
        private Guid _ProgramParticipationWIOAId;

        // member variable for the RefWIOABarrierstoEmploymentId property
        private Guid? _RefWIOABarrierstoEmploymentId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the ProgramParticipationWIOABarrierViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="ProgramParticipationWIOABarriers"/> model
        /// </summary>
        public Guid ProgramParticipationWIOABarriersId { get => _ProgramParticipationWIOABarriersId; set => SetProperty(ref _ProgramParticipationWIOABarriersId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="ProgramParticipationWIOA"/> model
        /// </summary>
        public Guid ProgramParticipationWIOAId { get => _ProgramParticipationWIOAId; set => SetProperty(ref _ProgramParticipationWIOAId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefWIOABarrierstoEmployment"/> model
        /// </summary>
        public Guid? RefWIOABarrierstoEmploymentId { get => _RefWIOABarrierstoEmploymentId; set => SetProperty(ref _RefWIOABarrierstoEmploymentId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IProgramParticipationWIOABarrier model)
        {
            IsBusy = true;
            Id = model.Id;
            ProgramParticipationWIOABarriersId = model.ProgramParticipationWIOABarriersId;
            ProgramParticipationWIOAId = model.ProgramParticipationWIOAId;
            RefWIOABarrierstoEmploymentId = model.RefWIOABarrierstoEmploymentId;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
