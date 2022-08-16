//**********************************************************
//* DomainName: Common Models
//* FileName:   PersonOtherNameViewModel.cs
//**********************************************************

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The PersonOtherNameViewModel
     /// </summary>
    public partial class PersonOtherNameViewModel : ViewModelBase, Interfaces.IPersonOtherName
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from PersonOtherName";

        // member variable for the FirstName property
        private  _FirstName;

        // member variable for the LastName property
        private  _LastName;

        // member variable for the MiddleName property
        private  _MiddleName;

        // member variable for the OtherName property
        private Guid? _OtherName;

        // member variable for the RecordEndDateTime property
        private  _RecordEndDateTime;

        // member variable for the RecordStartDateTime property
        private  _RecordStartDateTime;

        // member variable for the RefOtherNameTypeId property
        private  _RefOtherNameTypeId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// </summary>
        public  FirstName { get => _FirstName; set => SetProperty(ref _FirstName, value); }

        /// <summary>
        /// </summary>
        public  LastName { get => _LastName; set => SetProperty(ref _LastName, value); }

        /// <summary>
        /// </summary>
        public  MiddleName { get => _MiddleName; set => SetProperty(ref _MiddleName, value); }

        /// <summary>
        /// </summary>
        public Guid? OtherName { get => _OtherName; set => SetProperty(ref _OtherName, value); }

        /// <summary>
        /// </summary>
        public  RecordEndDateTime { get => _RecordEndDateTime; set => SetProperty(ref _RecordEndDateTime, value); }

        /// <summary>
        /// </summary>
        public  RecordStartDateTime { get => _RecordStartDateTime; set => SetProperty(ref _RecordStartDateTime, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefOtherNameType"/> model
        /// </summary>
        public  RefOtherNameTypeId { get => _RefOtherNameTypeId; set => SetProperty(ref _RefOtherNameTypeId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IPersonOtherName model)
        {
            IsBusy = true;
            Id = model.Id;
            FirstName = model.FirstName; // 
            LastName = model.LastName; // 
            MiddleName = model.MiddleName; // 
            OtherName = model.OtherName; // 
            RecordEndDateTime = model.RecordEndDateTime; // 
            RecordStartDateTime = model.RecordStartDateTime; // 
            RefOtherNameTypeId = model.RefOtherNameTypeId; // 
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
