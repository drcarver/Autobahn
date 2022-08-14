//**********************************************************
//* DomainName: Invalid or Unreferenced Models
//* FileName:   IndividualizedProgramEligibilityViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

namespace Autobahn.Invalid.ViewModels
{
     /// <summary>
     /// The IndividualizedProgramEligibilityViewModel
     /// </summary>
    public partial class IndividualizedProgramEligibilityViewModel : ViewModelBase, Interfaces.IIndividualizedProgramEligibility
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from IndividualizedProgramEligibility";

        // member variable for the ConsentToEvaluateDate property
        private System.DateTime? _ConsentToEvaluateDate;

        // member variable for the ConsentToEvaluateIndicator property
        private System.Boolean? _ConsentToEvaluateIndicator;

        // member variable for the IndividualizedProgramId property
        private Guid _IndividualizedProgramId;

        // member variable for the ParentObservations property
        private System.String _ParentObservations;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the IndividualizedProgramEligibilityViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Indication parent agreed to evaluate student.
        /// </summary>
        public System.DateTime? ConsentToEvaluateDate { get => _ConsentToEvaluateDate; set => SetProperty(ref _ConsentToEvaluateDate, value); }

        /// <summary>
        /// Indication parent agreed to evaluate student.
        /// </summary>
        public System.Boolean? ConsentToEvaluateIndicator { get => _ConsentToEvaluateIndicator; set => SetProperty(ref _ConsentToEvaluateIndicator, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IndividualizedProgram"/> model
        /// </summary>
        public Guid IndividualizedProgramId { get => _IndividualizedProgramId; set => SetProperty(ref _IndividualizedProgramId, value); }

        /// <summary>
        /// Indication parent agreed to evaluate student.
        /// </summary>
        public System.String ParentObservations { get => _ParentObservations; set => SetProperty(ref _ParentObservations, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IIndividualizedProgramEligibility model)
        {
            IsBusy = true;
            Id = model.Id;
            ConsentToEvaluateDate = model.ConsentToEvaluateDate;
            ConsentToEvaluateIndicator = model.ConsentToEvaluateIndicator;
            IndividualizedProgramId = model.IndividualizedProgramId;
            ParentObservations = model.ParentObservations;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
