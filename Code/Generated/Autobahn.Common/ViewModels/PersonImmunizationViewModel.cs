//**********************************************************
//* DomainName: Common Models
//* FileName:   PersonImmunizationViewModel.cs
//**********************************************************

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The PersonImmunizationViewModel
     /// </summary>
    public partial class PersonImmunizationViewModel : ViewModelBase, Interfaces.IPersonImmunization
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from PersonImmunization";

        // member variable for the ImmunizationDate property
        private Guid? _ImmunizationDate;

        // member variable for the RecordEndDateTime property
        private  _RecordEndDateTime;

        // member variable for the RecordStartDateTime property
        private  _RecordStartDateTime;

        // member variable for the RefImmunizationTypeId property
        private  _RefImmunizationTypeId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// </summary>
        public Guid? ImmunizationDate { get => _ImmunizationDate; set => SetProperty(ref _ImmunizationDate, value); }

        /// <summary>
        /// </summary>
        public  RecordEndDateTime { get => _RecordEndDateTime; set => SetProperty(ref _RecordEndDateTime, value); }

        /// <summary>
        /// </summary>
        public  RecordStartDateTime { get => _RecordStartDateTime; set => SetProperty(ref _RecordStartDateTime, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefImmunizationType"/> model
        /// </summary>
        public  RefImmunizationTypeId { get => _RefImmunizationTypeId; set => SetProperty(ref _RefImmunizationTypeId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IPersonImmunization model)
        {
            IsBusy = true;
            Id = model.Id;
            ImmunizationDate = model.ImmunizationDate; // 
            RecordEndDateTime = model.RecordEndDateTime; // 
            RecordStartDateTime = model.RecordStartDateTime; // 
            RefImmunizationTypeId = model.RefImmunizationTypeId; // 
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
