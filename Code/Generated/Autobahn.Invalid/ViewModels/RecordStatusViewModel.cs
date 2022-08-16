//**********************************************************
//* DomainName: Invalid or Unreferenced Models
//* FileName:   RecordStatusViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Invalid.ViewModels
{
     /// <summary>
     /// The RecordStatusViewModel
     /// </summary>
    public partial class RecordStatusViewModel : ViewModelBase, Interfaces.IRecordStatus
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from RecordStatus";

        // member variable for the RecordStatusDate property
        private  _RecordStatusDate;

        // member variable for the RefRecordStatusCreatorEntityId property
        private Guid? _RefRecordStatusCreatorEntityId;

        // member variable for the RefRecordStatusTypeId property
        private  _RefRecordStatusTypeId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// </summary>
        public  RecordStatusDate { get => _RecordStatusDate; set => SetProperty(ref _RecordStatusDate, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefRecordStatusCreatorEntity"/> model
        /// </summary>
        public Guid? RefRecordStatusCreatorEntityId { get => _RefRecordStatusCreatorEntityId; set => SetProperty(ref _RefRecordStatusCreatorEntityId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefRecordStatusType"/> model
        /// </summary>
        public  RefRecordStatusTypeId { get => _RefRecordStatusTypeId; set => SetProperty(ref _RefRecordStatusTypeId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IRecordStatus model)
        {
            IsBusy = true;
            Id = model.Id;
            RecordStatusDate = model.RecordStatusDate; // 
            RefRecordStatusCreatorEntityId = model.RefRecordStatusCreatorEntityId; // 
            RefRecordStatusTypeId = model.RefRecordStatusTypeId; // 
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
