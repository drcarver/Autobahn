//**********************************************************
//* DomainName: Early Learning (EL)
//* FileName:   ELOrganizationAvailabilityViewModel.cs
//* Name:       Early Learning Program Annual Operating Weeks
//* Definition: The number of operating weeks per year for an early learning program.
//***************************************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using Autobahn.Common.Models;
using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.EarlyLearning.ViewModels
{
     /// <summary>
     /// The number of operating weeks per year for an early learning program.
     /// </summary>
    public partial class ELOrganizationAvailabilityViewModel : ViewModelBase, Interfaces.IELOrganizationAvailability
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from ELOrganizationAvailability";

        // AnnualOperatingWeeks -- (backing property for Early Learning Program Annual Operating Weeks)
        private System.Int32? _AnnualOperatingWeeks;

        // DaysAvailablePerWeek -- (backing property for Days Available Per Week)
        private System.Int32? _DaysAvailablePerWeek;

        // HoursAvailablePerDay -- (backing property for Hours Available Per Day)
        private System.Decimal? _HoursAvailablePerDay;

        // NumberOfClassrooms -- (backing property for Number of Classrooms)
        private System.Int32? _NumberOfClassrooms;

        // member variable for the OrganizationId property
        private Guid _OrganizationId;

        // RefEnvironmentSettingId -- (backing property for Early Childhood Setting)
        private Guid? _RefEnvironmentSettingId;

        // RefServiceOptionId -- (backing property for Service Option Variation)
        private Guid? _RefServiceOptionId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Early Learning Program Annual Operating Weeks
        /// <para>
        /// The number of operating weeks per year for an early learning program.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19824">Early Learning Program Annual Operating Weeks</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.Int32? AnnualOperatingWeeks { get => _AnnualOperatingWeeks; set => SetProperty(ref _AnnualOperatingWeeks, value); }

        /// <summary>
        /// Days Available Per Week
        /// <para>
        /// The number of days per week the site or classroom is open for children to attend.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19354">Days Available Per Week</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.Int32? DaysAvailablePerWeek { get => _DaysAvailablePerWeek; set => SetProperty(ref _DaysAvailablePerWeek, value); }

        /// <summary>
        /// Hours Available Per Day
        /// <para>
        /// The number of hours per day the site or classroom is open for children to attend.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19353">Hours Available Per Day</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.Decimal? HoursAvailablePerDay { get => _HoursAvailablePerDay; set => SetProperty(ref _HoursAvailablePerDay, value); }

        /// <summary>
        /// Number of Classrooms
        /// <para>
        /// The total number of classrooms for a program, facility, location, or other educational environment.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19844">Number of Classrooms</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.Int32? NumberOfClassrooms { get => _NumberOfClassrooms; set => SetProperty(ref _NumberOfClassrooms, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IOrganization"/> model
        /// </summary>
        public Guid OrganizationId { get => _OrganizationId; set => SetProperty(ref _OrganizationId, value); }

        /// <summary>
        /// Early Childhood Setting
        /// <para>
        /// The site or setting in which  early childhood care, education, and/or services are provided.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19355">Early Childhood Setting</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefEnvironmentSettingId { get => _RefEnvironmentSettingId; set => SetProperty(ref _RefEnvironmentSettingId, value); }

        /// <summary>
        /// Service Option Variation
        /// <para>
        /// Nature of early childhood program, class or group in which a person is enrolled.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19352">Service Option Variation</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefServiceOptionId { get => _RefServiceOptionId; set => SetProperty(ref _RefServiceOptionId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IELOrganizationAvailability model)
        {
            IsBusy = true;
            Id = model.Id;
            AnnualOperatingWeeks = model.AnnualOperatingWeeks; // Early Learning Program Annual Operating Weeks
            DaysAvailablePerWeek = model.DaysAvailablePerWeek; // Days Available Per Week
            HoursAvailablePerDay = model.HoursAvailablePerDay; // Hours Available Per Day
            NumberOfClassrooms = model.NumberOfClassrooms; // Number of Classrooms
            OrganizationId = model.OrganizationId; // 
            RefEnvironmentSettingId = model.RefEnvironmentSettingId; // Early Childhood Setting
            RefServiceOptionId = model.RefServiceOptionId; // Service Option Variation
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
