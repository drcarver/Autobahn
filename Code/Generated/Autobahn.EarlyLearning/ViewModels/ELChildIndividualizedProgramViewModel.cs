//**********************************************************
//* DomainName: Autobahn.EarlyLearning
//* FileName:   ELChildIndividualizedProgramViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

namespace Autobahn.EarlyLearning.ViewModels
{
     /// <summary>
     /// The ELChildIndividualizedProgramViewModel
     /// </summary>
    public partial class ELChildIndividualizedProgramViewModel : ViewModelBase, Interfaces.IELChildIndividualizedProgramViewModel
    {
#region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from ELChildIndividualizedProgram";

        // member variable for the PersonId property
        private Guid _PersonId;

        // member variable for the IndividualizedProgramId property
        private Guid? _IndividualizedProgramId;

        // member variable for the RefIDEAIEPStatusId property
        private Guid? _RefIDEAIEPStatusId;

        // member variable for the RefIDEAPartCEligibilityCategoryId property
        private Guid? _RefIDEAPartCEligibilityCategoryId;

        // member variable for the RecordStartDateTime property
        private System.DateTime? _RecordStartDateTime;

        // member variable for the RecordEndDateTime property
        private System.DateTime? _RecordEndDateTime;

        // member variable for the RecordStatusId property
        private Guid? _RecordStatusId;

        // member variable for the DataCollectionId property
        private Guid? _DataCollectionId;

#endregion

        #region Properties
        /// <summary>
        /// The title of the ELChildIndividualizedProgramViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="PersonId"/> model
        /// </summary>
        public Guid PersonId { get => _PersonId; set => SetProperty(ref _PersonId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IndividualizedProgramId"/> model
        /// </summary>
        public Guid? IndividualizedProgramId { get => _IndividualizedProgramId; set => SetProperty(ref _IndividualizedProgramId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefIDEAIEPStatusId"/> model
        /// </summary>
        public Guid? RefIDEAIEPStatusId { get => _RefIDEAIEPStatusId; set => SetProperty(ref _RefIDEAIEPStatusId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefIDEAPartCEligibilityCategoryId"/> model
        /// </summary>
        public Guid? RefIDEAPartCEligibilityCategoryId { get => _RefIDEAPartCEligibilityCategoryId; set => SetProperty(ref _RefIDEAPartCEligibilityCategoryId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IELChildIndividualizedProgram model)
        {
            IsBusy = true;
            Id = model.Id;
            PersonId = model.PersonId;
            IndividualizedProgramId = model.IndividualizedProgramId;
            RefIDEAIEPStatusId = model.RefIDEAIEPStatusId;
            RefIDEAPartCEligibilityCategoryId = model.RefIDEAPartCEligibilityCategoryId;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
