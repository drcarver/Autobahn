//**********************************************************
//* DomainName: Common Models
//* FileName:   IndividualizedProgramGoalViewModel.cs
//***************************************************************************

using Autobahn.Common.Models;
using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The IndividualizedProgramGoal View Model
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

        // RefIEPGoalTypeId -- (backing property for IEP Goal Type)
        private Guid? _RefIEPGoalTypeId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IGoal"/> model
        /// </summary>
        public Guid GoalId { get => _GoalId; set => SetProperty(ref _GoalId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IIndividualizedProgram"/> model
        /// </summary>
        public Guid IndividualizedProgramId { get => _IndividualizedProgramId; set => SetProperty(ref _IndividualizedProgramId, value); }

        /// <summary>
        /// IEP Goal Type
        /// <para>
        /// Legal category for an IEP annual goal or short-term objectives.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20679">IEP Goal Type</a>
        /// </para>
        /// </summary>
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
            GoalId = model.GoalId; // 
            IndividualizedProgramId = model.IndividualizedProgramId; // 
            RefIEPGoalTypeId = model.RefIEPGoalTypeId; // IEP Goal Type
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
