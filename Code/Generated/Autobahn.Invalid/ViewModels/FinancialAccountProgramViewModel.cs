//**********************************************************
//* DomainName: Invalid or Unreferenced Models
//* FileName:   FinancialAccountProgramViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

namespace Autobahn.Invalid.ViewModels
{
     /// <summary>
     /// The FinancialAccountProgramViewModel
     /// </summary>
    public partial class FinancialAccountProgramViewModel : ViewModelBase, Interfaces.IFinancialAccountProgram
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from FinancialAccountProgram";

        // member variable for the Name property
        private System.String _Name;

        // member variable for the ProgramNumber property
        private System.String _ProgramNumber;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the FinancialAccountProgramViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// The name given to the program area in an educational institution's accounting system.
        /// </summary>
        public System.String Name { get => _Name; set => SetProperty(ref _Name, value); }

        /// <summary>
        /// The name given to the program area in an educational institution's accounting system.
        /// </summary>
        public System.String ProgramNumber { get => _ProgramNumber; set => SetProperty(ref _ProgramNumber, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IFinancialAccountProgram model)
        {
            IsBusy = true;
            Id = model.Id;
            Name = model.Name;
            ProgramNumber = model.ProgramNumber;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
