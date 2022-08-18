//**********************************************************
//* DomainName: Common Models
//* FileName:   StaffEmploymentViewModel.cs
//***************************************************************************

using Autobahn.Common.Models;
using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The StaffEmployment View Model
     /// </summary>
    public partial class StaffEmploymentViewModel : ViewModelBase, Interfaces.IStaffEmployment
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from StaffEmployment";

        // FullTimeEquivalency -- (backing property for Staff Full Time Equivalency)
        private System.Decimal? _FullTimeEquivalency;

        // HireDate -- (backing property for Hire Date)
        private System.DateTime? _HireDate;

        // member variable for the OrganizationPersonRoleId property
        private Guid _OrganizationPersonRoleId;

        // PositionTitle -- (backing property for Position Title)
        private System.String _PositionTitle;

        // RefEmploymentSeparationReasonId -- (backing property for Employment Separation Reason)
        private Guid? _RefEmploymentSeparationReasonId;

        // RefEmploymentSeparationTypeId -- (backing property for Employment Separation Type)
        private Guid? _RefEmploymentSeparationTypeId;

        // StandardOccupationalClassification -- (backing property for Standard Occupational Classification)
        private System.String _StandardOccupationalClassification;

        // UnionMembershipName -- (backing property for Union Membership Name)
        private System.String _UnionMembershipName;

        // WeeksEmployedPerYear -- (backing property for Weeks Employed Per Year)
        private System.Int32? _WeeksEmployedPerYear;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Staff Full Time Equivalency
        /// <para>
        /// The ratio between the hours of work expected in a position and the hours of work normally expected in a full-time position in the same setting.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19118">Staff Full Time Equivalency</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.Decimal? FullTimeEquivalency { get => _FullTimeEquivalency; set => SetProperty(ref _FullTimeEquivalency, value); }

        /// <summary>
        /// Hire Date
        /// <para>
        /// The year, month and day on which a person was hired for a position, or consecutive positions within the same organization and job classification.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19143">Hire Date</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.DateTime? HireDate { get => _HireDate; set => SetProperty(ref _HireDate, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
        /// </summary>
        public Guid OrganizationPersonRoleId { get => _OrganizationPersonRoleId; set => SetProperty(ref _OrganizationPersonRoleId, value); }

        /// <summary>
        /// Position Title
        /// <para>
        /// The descriptive name of a person's position.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19213">Position Title</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.String PositionTitle { get => _PositionTitle; set => SetProperty(ref _PositionTitle, value); }

        /// <summary>
        /// Employment Separation Reason
        /// <para>
        /// The primary reason for the termination of the employment relationship.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19613">Employment Separation Reason</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefEmploymentSeparationReasonId { get => _RefEmploymentSeparationReasonId; set => SetProperty(ref _RefEmploymentSeparationReasonId, value); }

        /// <summary>
        /// Employment Separation Type
        /// <para>
        /// A designation of the type of separation occurring between a person and the organization.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19614">Employment Separation Type</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefEmploymentSeparationTypeId { get => _RefEmploymentSeparationTypeId; set => SetProperty(ref _RefEmploymentSeparationTypeId, value); }

        /// <summary>
        /// Standard Occupational Classification
        /// <para>
        /// A Bureau of Labor Statistics coding system for classifying occupations by work performed and, in some cases, on the skills, education and training needed to perform the work at a competent level.  See https://www.bls.gov/soc/2018/major_groups.htm.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19707">Standard Occupational Classification</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.String StandardOccupationalClassification { get => _StandardOccupationalClassification; set => SetProperty(ref _StandardOccupationalClassification, value); }

        /// <summary>
        /// Union Membership Name
        /// <para>
        /// The name of the labor organization of which the person is a member.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20469">Union Membership Name</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.String UnionMembershipName { get => _UnionMembershipName; set => SetProperty(ref _UnionMembershipName, value); }

        /// <summary>
        /// Weeks Employed Per Year
        /// <para>
        /// The number of weeks employed by year.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20470">Weeks Employed Per Year</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.Int32? WeeksEmployedPerYear { get => _WeeksEmployedPerYear; set => SetProperty(ref _WeeksEmployedPerYear, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IStaffEmployment model)
        {
            IsBusy = true;
            Id = model.Id;
            FullTimeEquivalency = model.FullTimeEquivalency; // Staff Full Time Equivalency
            HireDate = model.HireDate; // Hire Date
            OrganizationPersonRoleId = model.OrganizationPersonRoleId; // 
            PositionTitle = model.PositionTitle; // Position Title
            RefEmploymentSeparationReasonId = model.RefEmploymentSeparationReasonId; // Employment Separation Reason
            RefEmploymentSeparationTypeId = model.RefEmploymentSeparationTypeId; // Employment Separation Type
            StandardOccupationalClassification = model.StandardOccupationalClassification; // Standard Occupational Classification
            UnionMembershipName = model.UnionMembershipName; // Union Membership Name
            WeeksEmployedPerYear = model.WeeksEmployedPerYear; // Weeks Employed Per Year
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }

        #region RefEmploymentSeparationType List
        /// <summary>
        /// The complete <see cref="RefEmploymentSeparationType"> List
        /// </summary>
        private static List<ReferenceModelBase> RefEmploymentSeparationTypeList = new List<ReferenceModelBase>
        {
            new ReferenceModelBase { Id=Guid.Parse("04891585-1c8f-429c-8de7-f28bdd5f343e"), Code="Involuntary", Description="Involuntary separation", Definition="Involuntary separation is the type of separation occurring between a person and the organization.", SortOrder=Convert.ToDecimal("1.00") },
            new ReferenceModelBase { Id=Guid.Parse("3bbd6e60-049d-4397-b1c9-925a3ec5600e"), Code="MutualAgreement", Description="Mutual agreement", Definition="Mutual agreement is the type of separation occurring between a person and the organization.", SortOrder=Convert.ToDecimal("2.00") },
            new ReferenceModelBase { Id=Guid.Parse("301f64a9-c568-4ae4-92e8-f70217ce6f3b"), Code="Other", Description="Other", Definition="The type of separation occurring between a person and the organization is in a category not yet defined in CEDS.", SortOrder=Convert.ToDecimal("3.00") },
            new ReferenceModelBase { Id=Guid.Parse("6d69bb76-405e-4e08-a1d6-71cfefc53841"), Code="Voluntary", Description="Voluntary separation", Definition="Voluntary separation is the type of separation occurring between a person and the organization.", SortOrder=Convert.ToDecimal("4.00") },
        };
        #endregion
    }
}
