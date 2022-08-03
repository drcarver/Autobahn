//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   FinancialAccountProgramViewModel.cs
//**********************************************************

using Prism.Mvvm;
using Autobahn.Common.Interfaces;
using Autobahn.Autobahn.Common.Interfaces;

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The FinancialAccountProgramViewModel
     /// </summary>
    public partial class FinancialAccountProgramViewModel : BindableBase, IFinancialAccountProgram
    {
#region "Backing Fields"
        // member variable for the Name property
        private System.String _Name;

        // member variable for the ProgramNumber property
        private System.String _ProgramNumber;

        // member variable for the RecordStartDateTime property
        private System.DateTime? _RecordStartDateTime;

        // member variable for the RecordEndDateTime property
        private System.DateTime? _RecordEndDateTime;

#endregion

#region Properties
        public System.String Name  { get => _Name; set => SetProperty(ref _Name, value); }

        public System.String ProgramNumber  { get => _ProgramNumber; set => SetProperty(ref _ProgramNumber, value); }

        public System.DateTime? RecordStartDateTime { get => _RecordStartDateTime; set => SetProperty(ref _RecordStartDateTime, value); }

        public System.DateTime? RecordEndDateTime { get => _RecordEndDateTime; set => SetProperty(ref _RecordEndDateTime, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RecordStatusId"/> model
        /// </summary>
        public Guid? RecordStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollectionId"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

#endregion


        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(IFinancialAccountProgram model)
        {
            IsBusy = true;
            Id = model.Id;
            Name = model.Name;
            ProgramNumber = model.ProgramNumber;
            RecordStartDateTime = model.RecordStartDateTime;
            RecordEndDateTime = model.RecordEndDateTime;
            RecordStatusId = model.RecordStatusId;
            DataCollectionId = model.DataCollectionId;
            IsChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
