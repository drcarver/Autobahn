//**********************************************************
//* DomainName: Early Learning (EL)
//* FileName:   ELChildDevelopmentalAssessmentViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;
using CommunityToolkit.Maui;

namespace Autobahn.EarlyLearning.ViewModels
{
     /// <summary>
     /// The ELChildDevelopmentalAssessmentViewModel
     /// </summary>
    public partial class ELChildDevelopmentalAssessmentViewModel : ViewModelBase, Interfaces.IELChildDevelopmentalAssessment
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from ELChildDevelopmentalAssessment";

        // member variable for the PersonId property
        private Guid _PersonId;

        // member variable for the RefChildDevelopmentalScreeningStatusId property
        private Guid? _RefChildDevelopmentalScreeningStatusId;

        // member variable for the RefDevelopmentalEvaluationFindingId property
        private Guid? _RefDevelopmentalEvaluationFindingId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the ELChildDevelopmentalAssessmentViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="Person"/> model
        /// </summary>
        public Guid PersonId { get => _PersonId; set => SetProperty(ref _PersonId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefChildDevelopmentalScreeningStatus"/> model
        /// </summary>
        public Guid? RefChildDevelopmentalScreeningStatusId { get => _RefChildDevelopmentalScreeningStatusId; set => SetProperty(ref _RefChildDevelopmentalScreeningStatusId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefDevelopmentalEvaluationFinding"/> model
        /// </summary>
        public Guid? RefDevelopmentalEvaluationFindingId { get => _RefDevelopmentalEvaluationFindingId; set => SetProperty(ref _RefDevelopmentalEvaluationFindingId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IELChildDevelopmentalAssessment model)
        {
            IsBusy = true;
            Id = model.Id;
            PersonId = model.PersonId;
            RefChildDevelopmentalScreeningStatusId = model.RefChildDevelopmentalScreeningStatusId;
            RefDevelopmentalEvaluationFindingId = model.RefDevelopmentalEvaluationFindingId;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
