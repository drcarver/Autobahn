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

        // member variable for the RefRecordStatusCreatorEntityId property
        private Guid? _RefRecordStatusCreatorEntityId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the RecordStatusViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefRecordStatusCreatorEntity"/> model
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20956">Record Status Creator Entity</a>
        /// </para>
        /// </summary>
        [DisplayName("Record Status Creator Entity")]
        public Guid? RefRecordStatusCreatorEntityId { get => _RefRecordStatusCreatorEntityId; set => SetProperty(ref _RefRecordStatusCreatorEntityId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IRecordStatus model)
        {
            IsBusy = true;
            Id = model.Id;
            RefRecordStatusCreatorEntityId = model.RefRecordStatusCreatorEntityId; // Record Status Creator Entity
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
