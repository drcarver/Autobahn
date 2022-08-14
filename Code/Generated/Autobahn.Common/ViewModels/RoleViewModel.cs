//**********************************************************
//* DomainName: Common Models
//* FileName:   RoleViewModel.cs
//**********************************************************

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The RoleViewModel
     /// </summary>
    public partial class RoleViewModel : ViewModelBase, Interfaces.IRole
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from Role";

        // member variable for the Name property
        private System.String _Name;

        // member variable for the RefRoleId property
        private Guid? _RefRoleId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the RoleViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// The start date and, optionally, time that a record is active as used to support version control.
        /// </summary>
        public System.String Name { get => _Name; set => SetProperty(ref _Name, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefRole"/> model
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
            RefRoleId = model.RefRoleId;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
