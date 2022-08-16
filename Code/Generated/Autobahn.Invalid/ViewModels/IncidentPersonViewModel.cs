//**********************************************************
//* DomainName: Invalid or Unreferenced Models
//* FileName:   IncidentPersonViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Invalid.ViewModels
{
     /// <summary>
     /// The IncidentPersonViewModel
     /// </summary>
    public partial class IncidentPersonViewModel : ViewModelBase, Interfaces.IIncidentPerson
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from IncidentPerson";

        // member variable for the Identifier property
        private Guid? _Identifier;

        // member variable for the RecordEndDateTime property
        private  _RecordEndDateTime;

        // member variable for the RecordStartDateTime property
        private  _RecordStartDateTime;

        // member variable for the RefIncidentPersonRoleTypeId property
        private  _RefIncidentPersonRoleTypeId;

        // member variable for the RefIncidentPersonTypeId property
        private  _RefIncidentPersonTypeId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// </summary>
        public Guid? Identifier { get => _Identifier; set => SetProperty(ref _Identifier, value); }

        /// <summary>
        /// </summary>
        public  RecordEndDateTime { get => _RecordEndDateTime; set => SetProperty(ref _RecordEndDateTime, value); }

        /// <summary>
        /// </summary>
        public  RecordStartDateTime { get => _RecordStartDateTime; set => SetProperty(ref _RecordStartDateTime, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefIncidentPersonRoleType"/> model
        /// </summary>
        public  RefIncidentPersonRoleTypeId { get => _RefIncidentPersonRoleTypeId; set => SetProperty(ref _RefIncidentPersonRoleTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefIncidentPersonType"/> model
        /// </summary>
        public  RefIncidentPersonTypeId { get => _RefIncidentPersonTypeId; set => SetProperty(ref _RefIncidentPersonTypeId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IIncidentPerson model)
        {
            IsBusy = true;
            Id = model.Id;
            Identifier = model.Identifier; // 
            RecordEndDateTime = model.RecordEndDateTime; // 
            RecordStartDateTime = model.RecordStartDateTime; // 
            RefIncidentPersonRoleTypeId = model.RefIncidentPersonRoleTypeId; // 
            RefIncidentPersonTypeId = model.RefIncidentPersonTypeId; // 
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
