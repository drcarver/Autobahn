//**********************************************************
//* DomainName: Authentication and Authorization
//* FileName:   IndividualizedProgramGoalViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;
using CommunityToolkit.Maui;

namespace Autobahn.Authorization.ViewModels
{
     /// <summary>
     /// The IndividualizedProgramGoalViewModel
     /// </summary>
    public partial class IndividualizedProgramGoalViewModel : ViewModelBase, Interfaces.IIndividualizedProgramGoal
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from IndividualizedProgramGoal";

        // member variable for the GoalId property
        private Guid _GoalId;

        // member variable for the IndividualizedProgramId property
        private Guid _IndividualizedProgramId;

        // member variable for the RefIEPGoalTypeId property
        private Guid? _RefIEPGoalTypeId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the IndividualizedProgramGoalViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="Goal"/> model
        /// </summary>
        public Guid GoalId { get => _GoalId; set => SetProperty(ref _GoalId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IndividualizedProgram"/> model
        /// </summary>
        public Guid IndividualizedProgramId { get => _IndividualizedProgramId; set => SetProperty(ref _IndividualizedProgramId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefIEPGoalType"/> model
        /// </summary>
        public Guid? RefIEPGoalTypeId { get => _RefIEPGoalTypeId; set => SetProperty(ref _RefIEPGoalTypeId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IIndividualizedProgramGoal model)
        {
            IsBusy = true;
            Id = model.Id;
            GoalId = model.GoalId;
            IndividualizedProgramId = model.IndividualizedProgramId;
            RefIEPGoalTypeId = model.RefIEPGoalTypeId;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}