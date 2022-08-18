//**********************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12StudentEmploymentViewModel.cs
//***************************************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using Autobahn.Common.Models;
using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.K12.ViewModels
{
     /// <summary>
     /// The K12StudentEmployment View Model
     /// </summary>
    public partial class K12StudentEmploymentViewModel : ViewModelBase, Interfaces.IK12StudentEmployment
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from K12StudentEmployment";

        // EmploymentNaicsCode -- (backing property for Employment NAICS Code)
        private System.String _EmploymentNaicsCode;

        // member variable for the OrganizationPersonRoleId property
        private Guid _OrganizationPersonRoleId;

        // RefEmployedAfterExitId -- (backing property for Employed After Exit)
        private Guid? _RefEmployedAfterExitId;

        // RefEmployedWhileEnrolledId -- (backing property for Employed While Enrolled)
        private Guid? _RefEmployedWhileEnrolledId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Employment NAICS Code
        /// <para>
        /// The North American Industry Classification System (NAICS) code associated with an individual's employment.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20070">Employment NAICS Code</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.String EmploymentNaicsCode { get => _EmploymentNaicsCode; set => SetProperty(ref _EmploymentNaicsCode, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
        /// </summary>
        public Guid OrganizationPersonRoleId { get => _OrganizationPersonRoleId; set => SetProperty(ref _OrganizationPersonRoleId, value); }

        /// <summary>
        /// Employed After Exit
        /// <para>
        /// An individual who is a paid employee or works in his or her own business, profession, or farm, as reported through the State Unemployment Insurance Wage Report, FEDES, or WRIS, after exiting secondary, postsecondary, or adult education or workforce programs.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19990">Employed After Exit</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefEmployedAfterExitId { get => _RefEmployedAfterExitId; set => SetProperty(ref _RefEmployedAfterExitId, value); }

        /// <summary>
        /// Employed While Enrolled
        /// <para>
        /// An individual who is a paid employee or works in his or her own business, profession, or farm, as reported through the State Unemployment Insurance Wage Report, FEDES, or WRIS, and at the same time is enrolled in secondary, postsecondary, or adult education or workforce programs.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19989">Employed While Enrolled</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefEmployedWhileEnrolledId { get => _RefEmployedWhileEnrolledId; set => SetProperty(ref _RefEmployedWhileEnrolledId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IK12StudentEmployment model)
        {
            IsBusy = true;
            Id = model.Id;
            EmploymentNaicsCode = model.EmploymentNaicsCode; // Employment NAICS Code
            OrganizationPersonRoleId = model.OrganizationPersonRoleId; // 
            RefEmployedAfterExitId = model.RefEmployedAfterExitId; // Employed After Exit
            RefEmployedWhileEnrolledId = model.RefEmployedWhileEnrolledId; // Employed While Enrolled
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
