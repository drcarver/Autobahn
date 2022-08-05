//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   AutobahnViewModel.cs
//**********************************************************


namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The AutobahnViewModel
     /// </summary>
    public partial class AutobahnViewModel : ViewModelBase, Interfaces.IAutobahn
    {
#region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from Autobahn";

        // member variable for the Database property
        private System.Data.Entity.Database _Database;

        // member variable for the ChangeTracker property
        private System.Data.Entity.Infrastructure.DbChangeTracker _ChangeTracker;

        // member variable for the Configuration property
        private System.Data.Entity.Infrastructure.DbContextConfiguration _Configuration;

#endregion

        #region Properties
        /// <summary>
        /// The title of the AutobahnViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        public System.Data.Entity.Database Database  { get => _Database; set => SetProperty(ref _Database, value); }

        public System.Data.Entity.Infrastructure.DbChangeTracker ChangeTracker  { get => _ChangeTracker; set => SetProperty(ref _ChangeTracker, value); }

        public System.Data.Entity.Infrastructure.DbContextConfiguration Configuration  { get => _Configuration; set => SetProperty(ref _Configuration, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IAutobahn model)
        {
            IsBusy = true;
            Id = model.Id;
            Database = model.Database;
            ChangeTracker = model.ChangeTracker;
            Configuration = model.Configuration;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
