//**********************************************************
//* DomainName: Invalid or Unreferenced Models
//* FileName:   FinancialAccountProgramViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

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
        private Guid? _Name;

        // member variable for the ProgramNumber property
        private  _ProgramNumber;

        // member variable for the RecordEndDateTime property
        private  _RecordEndDateTime;

        // member variable for the RecordStartDateTime property
        private  _RecordStartDateTime;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// </summary>
        public Guid? Name { get => _Name; set => SetProperty(ref _Name, value); }

        /// <summary>
        /// </summary>
        public  ProgramNumber { get => _ProgramNumber; set => SetProperty(ref _ProgramNumber, value); }

        /// <summary>
        /// </summary>
        public  RecordEndDateTime { get => _RecordEndDateTime; set => SetProperty(ref _RecordEndDateTime, value); }

        /// <summary>
        /// </summary>
        public  RecordStartDateTime { get => _RecordStartDateTime; set => SetProperty(ref _RecordStartDateTime, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IFinancialAccountProgram model)
        {
            IsBusy = true;
            Id = model.Id;
            Name = model.Name; // 
            ProgramNumber = model.ProgramNumber; // 
            RecordEndDateTime = model.RecordEndDateTime; // 
            RecordStartDateTime = model.RecordStartDateTime; // 
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
