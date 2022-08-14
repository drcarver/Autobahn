//**********************************************************
//* DomainName: Postsecondary (PS)
//* FileName:   PsStudentAdmissionTestViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

namespace Autobahn.Postsecondary.ViewModels
{
     /// <summary>
     /// The PsStudentAdmissionTestViewModel
     /// </summary>
    public partial class PsStudentAdmissionTestViewModel : ViewModelBase, Interfaces.IPsStudentAdmissionTest
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from PsStudentAdmissionTest";

        // member variable for the OrganizationPersonRoleId property
        private Guid _OrganizationPersonRoleId;

        // member variable for the RefStandardizedAdmissionTestId property
        private Guid _RefStandardizedAdmissionTestId;

        // member variable for the StandardizedAdmissionTestScore property
        private System.Decimal? _StandardizedAdmissionTestScore;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the PsStudentAdmissionTestViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="OrganizationPersonRole"/> model
        /// </summary>
        public Guid OrganizationPersonRoleId { get => _OrganizationPersonRoleId; set => SetProperty(ref _OrganizationPersonRoleId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefStandardizedAdmissionTest"/> model
        /// </summary>
        public Guid RefStandardizedAdmissionTestId { get => _RefStandardizedAdmissionTestId; set => SetProperty(ref _RefStandardizedAdmissionTestId, value); }

        /// <summary>
        /// The quantitative score on a standardized admission test reported to a postsecondary institution.
        /// </summary>
        public System.Decimal? StandardizedAdmissionTestScore { get => _StandardizedAdmissionTestScore; set => SetProperty(ref _StandardizedAdmissionTestScore, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IPsStudentAdmissionTest model)
        {
            IsBusy = true;
            Id = model.Id;
            OrganizationPersonRoleId = model.OrganizationPersonRoleId;
            RefStandardizedAdmissionTestId = model.RefStandardizedAdmissionTestId;
            StandardizedAdmissionTestScore = model.StandardizedAdmissionTestScore;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
