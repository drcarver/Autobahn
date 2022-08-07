//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   FinancialAccountProgramViewModel.cs
//**********************************************************


namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The FinancialAccountProgramViewModel
     /// </summary>
    public partial class FinancialAccountProgramViewModel : ViewModelBase, Interfaces.IFinancialAccountProgramViewModel
    {
#region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from FinancialAccountProgram";

        // member variable for the Name property
        private System.String _Name;

        // member variable for the ProgramNumber property
        private System.String _ProgramNumber;

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
        /// The title of the FinancialAccountProgramViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        public System.String Name  { get => _Name; set => SetProperty(ref _Name, value); }

        public System.String ProgramNumber  { get => _ProgramNumber; set => SetProperty(ref _ProgramNumber, value); }

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
