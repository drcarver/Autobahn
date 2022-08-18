//**********************************************************
//* DomainName: Workforce
//* FileName:   WorkforceEmploymentQuarterlyDataViewModel.cs
//***************************************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using Autobahn.Common.Models;
using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Workforce.ViewModels
{
     /// <summary>
     /// The WorkforceEmploymentQuarterlyData View Model
     /// </summary>
    public partial class WorkforceEmploymentQuarterlyDataViewModel : ViewModelBase, Interfaces.IWorkforceEmploymentQuarterlyData
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from WorkforceEmploymentQuarterlyData";

        // EmployedInMultipleJobsCount -- (backing property for Person Employed in Multiple Jobs Count)
        private System.Decimal? _EmployedInMultipleJobsCount;

        // MilitaryEnlistmentAfterExit -- (backing property for Military Enlistment After Exit)
        private System.Boolean? _MilitaryEnlistmentAfterExit;

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
        /// Person Employed in Multiple Jobs Count
        /// <para>
        /// The number of jobs held by a person during the reference period.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19993">Person Employed in Multiple Jobs Count</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.Decimal? EmployedInMultipleJobsCount { get => _EmployedInMultipleJobsCount; set => SetProperty(ref _EmployedInMultipleJobsCount, value); }

        /// <summary>
        /// Military Enlistment After Exit
        /// <para>
        /// An individual who is a member of the uniformed armed forces of the United States as reported through FEDES after exiting secondary, postsecondary, or adult education or workforce programs.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20381">Military Enlistment After Exit</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.Boolean? MilitaryEnlistmentAfterExit { get => _MilitaryEnlistmentAfterExit; set => SetProperty(ref _MilitaryEnlistmentAfterExit, value); }

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
        public void Load(Interfaces.IWorkforceEmploymentQuarterlyData model)
        {
            IsBusy = true;
            Id = model.Id;
            EmployedInMultipleJobsCount = model.EmployedInMultipleJobsCount; // Person Employed in Multiple Jobs Count
            MilitaryEnlistmentAfterExit = model.MilitaryEnlistmentAfterExit; // Military Enlistment After Exit
            OrganizationPersonRoleId = model.OrganizationPersonRoleId; // 
            RefEmployedAfterExitId = model.RefEmployedAfterExitId; // Employed After Exit
            RefEmployedWhileEnrolledId = model.RefEmployedWhileEnrolledId; // Employed While Enrolled
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
