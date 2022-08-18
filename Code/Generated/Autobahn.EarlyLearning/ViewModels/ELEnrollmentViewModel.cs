//**********************************************************
//* DomainName: Early Learning (EL)
//* FileName:   ELEnrollmentViewModel.cs
//***************************************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using Autobahn.Common.Models;
using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.EarlyLearning.ViewModels
{
     /// <summary>
     /// The ELEnrollment View Model
     /// </summary>
    public partial class ELEnrollmentViewModel : ViewModelBase, Interfaces.IELEnrollment
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from ELEnrollment";

        // member variable for the ELClassSectionId property
        private Guid? _ELClassSectionId;

        // EnrollmentDate -- (backing property for Enrollment Date)
        private System.DateTime? _EnrollmentDate;

        // NumberOfDaysInAttendance -- (backing property for Number of Days in Attendance)
        private System.Decimal? _NumberOfDaysInAttendance;

        // member variable for the OrganizationPersonRoleId property
        private Guid _OrganizationPersonRoleId;

        // RefELFederalFundingTypeId -- (backing property for Early Learning Federal Funding Type)
        private Guid? _RefELFederalFundingTypeId;

        // RefFoodServiceParticipationId -- (backing property for Participation in School Food Service Programs)
        private Guid? _RefFoodServiceParticipationId;

        // RefIDEAEnvironmentELId -- (backing property for IDEA Educational Environment for Early Childhood)
        private Guid? _RefIDEAEnvironmentELId;

        // RefServiceOptionId -- (backing property for Service Option Variation)
        private Guid? _RefServiceOptionId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IELClassSection"/> model
        /// </summary>
        public Guid? ELClassSectionId { get => _ELClassSectionId; set => SetProperty(ref _ELClassSectionId, value); }

        /// <summary>
        /// Enrollment Date
        /// <para>
        /// The year, month and day on which a person is considered officially enrolled in the program.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19324">Enrollment Date</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.DateTime? EnrollmentDate { get => _EnrollmentDate; set => SetProperty(ref _EnrollmentDate, value); }

        /// <summary>
        /// Number of Days in Attendance
        /// <para>
        /// The number of days a person is present when school is in session during a given reporting period.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19202">Number of Days in Attendance</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.Decimal? NumberOfDaysInAttendance { get => _NumberOfDaysInAttendance; set => SetProperty(ref _NumberOfDaysInAttendance, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
        /// </summary>
        public Guid OrganizationPersonRoleId { get => _OrganizationPersonRoleId; set => SetProperty(ref _OrganizationPersonRoleId, value); }

        /// <summary>
        /// Early Learning Federal Funding Type
        /// <para>
        /// Federal source, even if administered by state or local, that contributes to the EL program.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20294">Early Learning Federal Funding Type</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefELFederalFundingTypeId { get => _RefELFederalFundingTypeId; set => SetProperty(ref _RefELFederalFundingTypeId, value); }

        /// <summary>
        /// Participation in School Food Service Programs
        /// <para>
        /// An indication of a student's participation in free, reduced price, full price breakfast, lunch, snack, supper, and milk programs.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19325">Participation in School Food Service Programs</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefFoodServiceParticipationId { get => _RefFoodServiceParticipationId; set => SetProperty(ref _RefFoodServiceParticipationId, value); }

        /// <summary>
        /// IDEA Educational Environment for Early Childhood
        /// <para>
        /// The program in which children ages 3 through 5 attend and in which these children receive special education and related services.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19550">IDEA Educational Environment for Early Childhood</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefIDEAEnvironmentELId { get => _RefIDEAEnvironmentELId; set => SetProperty(ref _RefIDEAEnvironmentELId, value); }

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
        public void Load(Interfaces.IELEnrollment model)
        {
            IsBusy = true;
            Id = model.Id;
            ELClassSectionId = model.ELClassSectionId; // 
            EnrollmentDate = model.EnrollmentDate; // Enrollment Date
            NumberOfDaysInAttendance = model.NumberOfDaysInAttendance; // Number of Days in Attendance
            OrganizationPersonRoleId = model.OrganizationPersonRoleId; // 
            RefELFederalFundingTypeId = model.RefELFederalFundingTypeId; // Early Learning Federal Funding Type
            RefFoodServiceParticipationId = model.RefFoodServiceParticipationId; // Participation in School Food Service Programs
            RefIDEAEnvironmentELId = model.RefIDEAEnvironmentELId; // IDEA Educational Environment for Early Childhood
            RefServiceOptionId = model.RefServiceOptionId; // Service Option Variation
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
