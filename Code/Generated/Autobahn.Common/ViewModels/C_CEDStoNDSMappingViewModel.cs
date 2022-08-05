//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   C_CEDStoNDSMappingViewModel.cs
//**********************************************************


namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The C_CEDStoNDSMappingViewModel
     /// </summary>
    public partial class C_CEDStoNDSMappingViewModel : ViewModelBase, Interfaces.IC_CEDStoNDSMapping
    {
#region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from C_CEDStoNDSMapping";

        // member variable for the GlobalID property
        private System.String _GlobalID;

        // member variable for the TableName property
        private System.String _TableName;

        // member variable for the ColumnName property
        private System.String _ColumnName;

        // member variable for the Version property
        private System.String _Version;

#endregion

        #region Properties
        /// <summary>
        /// The title of the C_CEDStoNDSMappingViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        public System.String GlobalID  { get => _GlobalID; set => SetProperty(ref _GlobalID, value); }

        public System.String TableName  { get => _TableName; set => SetProperty(ref _TableName, value); }

        public System.String ColumnName  { get => _ColumnName; set => SetProperty(ref _ColumnName, value); }

        public System.String Version  { get => _Version; set => SetProperty(ref _Version, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IC_CEDStoNDSMapping model)
        {
            IsBusy = true;
            Id = model.Id;
            GlobalID = model.GlobalID;
            TableName = model.TableName;
            ColumnName = model.ColumnName;
            Version = model.Version;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
