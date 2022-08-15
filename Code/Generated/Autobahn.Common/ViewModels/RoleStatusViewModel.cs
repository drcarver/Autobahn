//**********************************************************
//* DomainName: Common Models
//* FileName:   RoleStatusViewModel.cs
//**********************************************************

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The RoleStatusViewModel
     /// </summary>
    public partial class RoleStatusViewModel : ViewModelBase, Interfaces.IRoleStatus
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from RoleStatus";

        // member variable for the RefRoleStatusId property
        private Guid? _RefRoleStatusId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the RoleStatusViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefRoleStatus"/> model
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19094">Enrollment Status</a>
        /// </para>
        /// </summary>
        [DisplayName("Enrollment Status")]
        public Guid? RefRoleStatusId { get => _RefRoleStatusId; set => SetProperty(ref _RefRoleStatusId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IRoleStatus model)
        {
            IsBusy = true;
            Id = model.Id;
            RefRoleStatusId = model.RefRoleStatusId; // Enrollment Status
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
