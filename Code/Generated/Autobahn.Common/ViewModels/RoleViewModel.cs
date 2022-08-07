//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RoleViewModel.cs
//**********************************************************


namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The RoleViewModel
     /// </summary>
    public partial class RoleViewModel : ViewModelBase, Interfaces.IRoleViewModel
    {
#region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from Role";

        // member variable for the Name property
        private System.String _Name;

        // member variable for the RefJurisdictionId property
        private Guid? _RefJurisdictionId;

        // member variable for the RecordStartDateTime property
        private System.DateTime? _RecordStartDateTime;

        // member variable for the RecordEndDateTime property
        private System.DateTime? _RecordEndDateTime;

        // member variable for the RefRoleId property
        private Guid? _RefRoleId;

        // member variable for the RecordStatusId property
        private Guid? _RecordStatusId;

        // member variable for the DataCollectionId property
        private Guid? _DataCollectionId;

#endregion

        #region Properties
        /// <summary>
        /// The title of the RoleViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        public System.String Name  { get => _Name; set => SetProperty(ref _Name, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefJurisdictionId"/> model
        /// </summary>
        public Guid? RefJurisdictionId { get => _RefJurisdictionId; set => SetProperty(ref _RefJurisdictionId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefRoleId"/> model
        /// </summary>
        public Guid? RefRoleId { get => _RefRoleId; set => SetProperty(ref _RefRoleId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IRole model)
        {
            IsBusy = true;
            Id = model.Id;
            Name = model.Name;
            RefJurisdictionId = model.RefJurisdictionId;
            RefRoleId = model.RefRoleId;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
