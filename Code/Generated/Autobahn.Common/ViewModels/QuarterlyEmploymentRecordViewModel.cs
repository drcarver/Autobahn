//**********************************************************
//* DomainName: Common Models
//* FileName:   QuarterlyEmploymentRecordViewModel.cs
//***************************************************************************

using Autobahn.Common.Models;
using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The QuarterlyEmploymentRecord View Model
     /// </summary>
    public partial class QuarterlyEmploymentRecordViewModel : ViewModelBase, Interfaces.IQuarterlyEmploymentRecord
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from QuarterlyEmploymentRecord";

        // Earnings -- (backing property for Quarterly Earnings)
        private System.Decimal? _Earnings;

        // EmploymentNAICSCode -- (backing property for Employment NAICS Code)
        private System.String _EmploymentNAICSCode;

        // member variable for the PersonId property
        private Guid _PersonId;

        // RefEmployedPriorToEnrollmentId -- (backing property for Employed Prior to Enrollment)
        private Guid? _RefEmployedPriorToEnrollmentId;

        // RefEmploymentLocationId -- (backing property for Employment Location)
        private Guid? _RefEmploymentLocationId;

        // RefERAdministrativeDataSourceId -- (backing property for Employment Record Administrative Data Source)
        private Guid? _RefERAdministrativeDataSourceId;

        // ReferencePeriodEndDate -- (backing property for Employment Record Reference Period End Date)
        private System.DateTime? _ReferencePeriodEndDate;

        // ReferencePeriodStartDate -- (backing property for Employment Record Reference Period Start Date)
        private System.DateTime? _ReferencePeriodStartDate;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Quarterly Earnings
        /// <para>
        /// The quarterly amount paid to individuals found employed during the reference period.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19991">Quarterly Earnings</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.Decimal? Earnings { get => _Earnings; set => SetProperty(ref _Earnings, value); }

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
        public System.String EmploymentNAICSCode { get => _EmploymentNAICSCode; set => SetProperty(ref _EmploymentNAICSCode, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IPerson"/> model
        /// </summary>
        public Guid PersonId { get => _PersonId; set => SetProperty(ref _PersonId, value); }

        /// <summary>
        /// Employed Prior to Enrollment
        /// <para>
        /// An individual who is a paid employee or works in his or her own business, profession, or farm, as reported through the State Unemployment Insurance Wage Report, FEDES, or WRIS, before enrolling in secondary, postsecondary, or adult education or workforce programs.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20309">Employed Prior to Enrollment</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefEmployedPriorToEnrollmentId { get => _RefEmployedPriorToEnrollmentId; set => SetProperty(ref _RefEmployedPriorToEnrollmentId, value); }

        /// <summary>
        /// Employment Location
        /// <para>
        /// The state or other location in which an individual is found employed.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19992">Employment Location</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefEmploymentLocationId { get => _RefEmploymentLocationId; set => SetProperty(ref _RefEmploymentLocationId, value); }

        /// <summary>
        /// Employment Record Administrative Data Source
        /// <para>
        /// Administrative data source of information used to collect employment and earnings-related data.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19996">Employment Record Administrative Data Source</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefERAdministrativeDataSourceId { get => _RefERAdministrativeDataSourceId; set => SetProperty(ref _RefERAdministrativeDataSourceId, value); }

        /// <summary>
        /// Employment Record Reference Period End Date
        /// <para>
        /// The year, month, and day of the last day of the employment record reference period.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19995">Employment Record Reference Period End Date</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.DateTime? ReferencePeriodEndDate { get => _ReferencePeriodEndDate; set => SetProperty(ref _ReferencePeriodEndDate, value); }

        /// <summary>
        /// Employment Record Reference Period Start Date
        /// <para>
        /// The year, month, and day of the first day of the employment record reference period.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19994">Employment Record Reference Period Start Date</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.DateTime? ReferencePeriodStartDate { get => _ReferencePeriodStartDate; set => SetProperty(ref _ReferencePeriodStartDate, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IQuarterlyEmploymentRecord model)
        {
            IsBusy = true;
            Id = model.Id;
            Earnings = model.Earnings; // Quarterly Earnings
            EmploymentNAICSCode = model.EmploymentNAICSCode; // Employment NAICS Code
            PersonId = model.PersonId; // 
            RefEmployedPriorToEnrollmentId = model.RefEmployedPriorToEnrollmentId; // Employed Prior to Enrollment
            RefEmploymentLocationId = model.RefEmploymentLocationId; // Employment Location
            RefERAdministrativeDataSourceId = model.RefERAdministrativeDataSourceId; // Employment Record Administrative Data Source
            ReferencePeriodEndDate = model.ReferencePeriodEndDate; // Employment Record Reference Period End Date
            ReferencePeriodStartDate = model.ReferencePeriodStartDate; // Employment Record Reference Period Start Date
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
