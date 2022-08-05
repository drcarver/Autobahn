//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   PersonImmunizationViewModel.cs
//**********************************************************


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

        // member variable for the PersonId property
        private Guid _PersonId;

        // member variable for the ImmunizationDate property
        private System.DateTime _ImmunizationDate;

        // member variable for the RefImmunizationTypeId property
        private Guid _RefImmunizationTypeId;

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
        /// The title of the PersonImmunizationViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="PersonId"/> model
        /// </summary>
        public Guid PersonId { get => _PersonId; set => SetProperty(ref _PersonId, value); }

        public System.DateTime ImmunizationDate  { get => _ImmunizationDate; set => SetProperty(ref _ImmunizationDate, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="RefImmunizationTypeId"/> model
        /// </summary>
        public Guid RefImmunizationTypeId { get => _RefImmunizationTypeId; set => SetProperty(ref _RefImmunizationTypeId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IPersonImmunization model)
        {
            IsBusy = true;
            Id = model.Id;
            PersonId = model.PersonId;
            ImmunizationDate = model.ImmunizationDate;
            RefImmunizationTypeId = model.RefImmunizationTypeId;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
