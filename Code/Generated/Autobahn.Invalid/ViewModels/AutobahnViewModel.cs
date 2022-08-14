//**********************************************************
//* DomainName: Invalid or Unreferenced Models
//* FileName:   AutobahnViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

namespace Autobahn.Invalid.ViewModels
{
     /// <summary>
     /// The AutobahnViewModel
     /// </summary>
    public partial class AutobahnViewModel : ViewModelBase, Interfaces.IAutobahn
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from Autobahn";

        // member variable for the ChangeTracker property
        private System.Data.Entity.Infrastructure.DbChangeTracker _ChangeTracker;

        // member variable for the Configuration property
        private System.Data.Entity.Infrastructure.DbContextConfiguration _Configuration;

        // member variable for the Database property
        private System.Data.Entity.Database _Database;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the AutobahnViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// 
        /// </summary>
        public System.Data.Entity.Infrastructure.DbChangeTracker ChangeTracker { get => _ChangeTracker; set => SetProperty(ref _ChangeTracker, value); }

        /// <summary>
        /// 
        /// </summary>
        public System.Data.Entity.Infrastructure.DbContextConfiguration Configuration { get => _Configuration; set => SetProperty(ref _Configuration, value); }

        /// <summary>
        /// 
        /// </summary>
        public System.Data.Entity.Database Database { get => _Database; set => SetProperty(ref _Database, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IAutobahn model)
        {
            IsBusy = true;
            Id = model.Id;
            ChangeTracker = model.ChangeTracker;
            Configuration = model.Configuration;
            Database = model.Database;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
