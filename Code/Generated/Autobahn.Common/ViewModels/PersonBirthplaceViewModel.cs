//**********************************************************
//* DomainName: Common Models
//* FileName:   PersonBirthplaceViewModel.cs
//**********************************************************

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The PersonBirthplaceViewModel
     /// </summary>
    public partial class PersonBirthplaceViewModel : ViewModelBase, Interfaces.IPersonBirthplace
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from PersonBirthplace";

        // member variable for the City property
        private  _City;

        // member variable for the RecordEndDateTime property
        private  _RecordEndDateTime;

        // member variable for the RecordStartDateTime property
        private  _RecordStartDateTime;

        // member variable for the RefCountryId property
        private Guid? _RefCountryId;

        // member variable for the RefStateId property
        private  _RefStateId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// </summary>
        public  City { get => _City; set => SetProperty(ref _City, value); }

        /// <summary>
        /// </summary>
        public  RecordEndDateTime { get => _RecordEndDateTime; set => SetProperty(ref _RecordEndDateTime, value); }

        /// <summary>
        /// </summary>
        public  RecordStartDateTime { get => _RecordStartDateTime; set => SetProperty(ref _RecordStartDateTime, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCountry"/> model
        /// </summary>
        public Guid? RefCountryId { get => _RefCountryId; set => SetProperty(ref _RefCountryId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefState"/> model
        /// </summary>
        public  RefStateId { get => _RefStateId; set => SetProperty(ref _RefStateId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IPersonBirthplace model)
        {
            IsBusy = true;
            Id = model.Id;
            City = model.City; // 
            RecordEndDateTime = model.RecordEndDateTime; // 
            RecordStartDateTime = model.RecordStartDateTime; // 
            RefCountryId = model.RefCountryId; // 
            RefStateId = model.RefStateId; // 
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
