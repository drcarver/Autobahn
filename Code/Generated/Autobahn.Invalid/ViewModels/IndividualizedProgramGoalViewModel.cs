//**********************************************************
//* DomainName: Invalid or Unreferenced Models
//* FileName:   IndividualizedProgramGoalViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Invalid.ViewModels
{
     /// <summary>
     /// The IndividualizedProgramGoalViewModel
     /// </summary>
    public partial class IndividualizedProgramGoalViewModel : ViewModelBase, Interfaces.IIndividualizedProgramGoal
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from IndividualizedProgramGoal";

        // member variable for the RefIEPGoalTypeId property
        private Guid? _RefIEPGoalTypeId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the IndividualizedProgramGoalViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefIEPGoalType"/> model
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20679">IEP Goal Type</a>
        /// </para>
        /// </summary>
        [DisplayName("IEP Goal Type")]
        public Guid? RefIEPGoalTypeId { get => _RefIEPGoalTypeId; set => SetProperty(ref _RefIEPGoalTypeId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IIndividualizedProgramGoal model)
        {
            IsBusy = true;
            Id = model.Id;
            RefIEPGoalTypeId = model.RefIEPGoalTypeId; // IEP Goal Type
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
