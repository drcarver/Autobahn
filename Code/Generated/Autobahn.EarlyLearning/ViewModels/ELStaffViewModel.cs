//**********************************************************
//* DomainName: Early Learning (EL)
//* FileName:   ELStaffViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

namespace Autobahn.EarlyLearning.ViewModels
{
     /// <summary>
     /// The ELStaffViewModel
     /// </summary>
    public partial class ELStaffViewModel : ViewModelBase, Interfaces.IELStaff
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from ELStaff";

        // member variable for the OrganizationPersonRoleId property
        private Guid _OrganizationPersonRoleId;

        // member variable for the RefChildDevelopmentAssociateTypeId property
        private Guid? _RefChildDevelopmentAssociateTypeId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the ELStaffViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="OrganizationPersonRole"/> model
        /// </summary>
        public Guid OrganizationPersonRoleId { get => _OrganizationPersonRoleId; set => SetProperty(ref _OrganizationPersonRoleId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefChildDevelopmentAssociateType"/> model
        /// </summary>
        public Guid? RefChildDevelopmentAssociateTypeId { get => _RefChildDevelopmentAssociateTypeId; set => SetProperty(ref _RefChildDevelopmentAssociateTypeId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IELStaff model)
        {
            IsBusy = true;
            Id = model.Id;
            OrganizationPersonRoleId = model.OrganizationPersonRoleId;
            RefChildDevelopmentAssociateTypeId = model.RefChildDevelopmentAssociateTypeId;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
