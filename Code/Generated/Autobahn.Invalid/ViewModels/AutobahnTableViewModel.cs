//**********************************************************
//* DomainName: Invalid or Unreferenced Models
//* FileName:   AutobahnTableViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Invalid.ViewModels
{
     /// <summary>
     /// The AutobahnTableViewModel
     /// </summary>
    public partial class AutobahnTableViewModel : ViewModelBase, Interfaces.IAutobahnTable
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from AutobahnTable";

        // member variable for the AutobahnDomainId property
        private Guid? _AutobahnDomainId;

        // member variable for the ColumnName property
        private System.String _ColumnName;

        // member variable for the ColumnType property
        private System.String _ColumnType;

        // member variable for the GlobalId property
        private Guid _GlobalId;

        // member variable for the Id property
        private Guid? _Id;

        // member variable for the ModuleName property
        private System.String _ModuleName;

        // member variable for the TableName property
        private System.String _TableName;

        // member variable for the Version property
        private System.String _Version;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="AutobahnDomain"/> model
        /// </summary>
        public Guid? AutobahnDomainId { get => _AutobahnDomainId; set => SetProperty(ref _AutobahnDomainId, value); }

        /// <summary>
        /// </summary>
        public System.String ColumnName { get => _ColumnName; set => SetProperty(ref _ColumnName, value); }

        /// <summary>
        /// </summary>
        public System.String ColumnType { get => _ColumnType; set => SetProperty(ref _ColumnType, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="Global"/> model
        /// </summary>
        public Guid GlobalId { get => _GlobalId; set => SetProperty(ref _GlobalId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref=""/> model
        /// </summary>
        public Guid? Id { get => _Id; set => SetProperty(ref _Id, value); }

        /// <summary>
        /// </summary>
        public System.String ModuleName { get => _ModuleName; set => SetProperty(ref _ModuleName, value); }

        /// <summary>
        /// </summary>
        public System.String TableName { get => _TableName; set => SetProperty(ref _TableName, value); }

        /// <summary>
        /// </summary>
        public System.String Version { get => _Version; set => SetProperty(ref _Version, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IAutobahnTable model)
        {
            IsBusy = true;
            Id = model.Id;
            AutobahnDomainId = model.AutobahnDomainId; // 
            ColumnName = model.ColumnName; // 
            ColumnType = model.ColumnType; // 
            GlobalId = model.GlobalId; // 
            Id = model.Id; // 
            ModuleName = model.ModuleName; // 
            TableName = model.TableName; // 
            Version = model.Version; // 
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}