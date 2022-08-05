//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RequiredImmunizationViewModel.cs
//**********************************************************


namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The RequiredImmunizationViewModel
     /// </summary>
    public partial class RequiredImmunizationViewModel : ViewModelBase, Interfaces.IRequiredImmunization
    {
#region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from RequiredImmunization";

        // member variable for the OrganizationId property
        private Guid _OrganizationId;

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
        /// The title of the RequiredImmunizationViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="OrganizationId"/> model
        /// </summary>
        public Guid OrganizationId { get => _OrganizationId; set => SetProperty(ref _OrganizationId, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="RefImmunizationTypeId"/> model
        /// </summary>
        public Guid RefImmunizationTypeId { get => _RefImmunizationTypeId; set => SetProperty(ref _RefImmunizationTypeId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IRequiredImmunization model)
        {
            IsBusy = true;
            Id = model.Id;
            OrganizationId = model.OrganizationId;
            RefImmunizationTypeId = model.RefImmunizationTypeId;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
