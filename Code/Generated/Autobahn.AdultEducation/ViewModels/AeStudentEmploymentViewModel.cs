//**********************************************************
//* DomainName: Adult Education (AE)
//* FileName:   AeStudentEmploymentViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;
using CommunityToolkit.Maui;

namespace Autobahn.AdultEducation.ViewModels
{
     /// <summary>
     /// The AeStudentEmploymentViewModel
     /// </summary>
    public partial class AeStudentEmploymentViewModel : ViewModelBase, Interfaces.IAeStudentEmployment
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from AeStudentEmployment";

        // member variable for the EmploymentNaicsCode property
        private System.String _EmploymentNaicsCode;

        // member variable for the OrganizationPersonRoleId property
        private Guid _OrganizationPersonRoleId;

        // member variable for the RefEmployedAfterExitId property
        private Guid? _RefEmployedAfterExitId;

        // member variable for the RefEmployedWhileEnrolledId property
        private Guid? _RefEmployedWhileEnrolledId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the AeStudentEmploymentViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// An individual who is a paid employee or works in his or her own business, profession, or farm, as reported through the State Unemployment Insurance Wage Report, FEDES, or WRIS, and at the same time is enrolled in secondary, postsecondary, or adult education or workforce programs.
        /// </summary>
        public System.String EmploymentNaicsCode { get => _EmploymentNaicsCode; set => SetProperty(ref _EmploymentNaicsCode, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="OrganizationPersonRole"/> model
        /// </summary>
        public Guid OrganizationPersonRoleId { get => _OrganizationPersonRoleId; set => SetProperty(ref _OrganizationPersonRoleId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefEmployedAfterExit"/> model
        /// </summary>
        public Guid? RefEmployedAfterExitId { get => _RefEmployedAfterExitId; set => SetProperty(ref _RefEmployedAfterExitId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefEmployedWhileEnrolled"/> model
        /// </summary>
        public Guid? RefEmployedWhileEnrolledId { get => _RefEmployedWhileEnrolledId; set => SetProperty(ref _RefEmployedWhileEnrolledId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IAeStudentEmployment model)
        {
            IsBusy = true;
            Id = model.Id;
            EmploymentNaicsCode = model.EmploymentNaicsCode;
            OrganizationPersonRoleId = model.OrganizationPersonRoleId;
            RefEmployedAfterExitId = model.RefEmployedAfterExitId;
            RefEmployedWhileEnrolledId = model.RefEmployedWhileEnrolledId;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
