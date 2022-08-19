//**********************************************************
//* DomainName: Postsecondary (PS)
//* FileName:   PsInstitutionViewModel.cs
//***************************************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using Autobahn.Common.Models;
using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Postsecondary.ViewModels
{
     /// <summary>
     /// The PsInstitution View Model
     /// </summary>
    public partial class PsInstitutionViewModel : ViewModelBase, Interfaces.IPsInstitution
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from PsInstitution";

        // InstitutionallyControlledHousingStatus -- (backing property for Institutionally Controlled Housing Status)
        private System.Boolean? _InstitutionallyControlledHousingStatus;

        // member variable for the OrganizationId property
        private Guid _OrganizationId;

        // RefAdministrativeFundingControlId -- (backing property for Administrative Funding Control)
        private Guid? _RefAdministrativeFundingControlId;

        // RefAdmissionConsiderationLevelId -- (backing property for Admission Consideration Level)
        private Guid? _RefAdmissionConsiderationLevelId;

        // RefAdmissionConsiderationTypeId -- (backing property for Admission Consideration Type)
        private Guid? _RefAdmissionConsiderationTypeId;

        // RefCarnegieBasicClassificationId -- (backing property for Carnegie Basic Classification)
        private Guid? _RefCarnegieBasicClassificationId;

        // RefControlOfInstitutionId -- (backing property for Control of Institution)
        private Guid? _RefControlOfInstitutionId;

        // RefIncreasedLearningTimeTypeId -- (backing property for Increased Learning Time Type)
        private Guid? _RefIncreasedLearningTimeTypeId;

        // RefLevelOfInstitutionId -- (backing property for Level of Institution)
        private Guid? _RefLevelOfInstitutionId;

        // RefPredominantCalendarSystemId -- (backing property for Predominant Calendar System)
        private Guid? _RefPredominantCalendarSystemId;

        // RefTenureSystemId -- (backing property for Tenure System)
        private Guid? _RefTenureSystemId;

        // VirtualIndicator -- (backing property for Virtual Indicator)
        private System.Boolean? _VirtualIndicator;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Institutionally Controlled Housing Status
        /// <para>
        /// An indication of whether an institution has any residence hall or housing facility located on- or off-campus that is owned or controlled by an institution and used by the institution in direct support of or in a manner related to, the institution's educational purposes.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19727">Institutionally Controlled Housing Status</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.Boolean? InstitutionallyControlledHousingStatus { get => _InstitutionallyControlledHousingStatus; set => SetProperty(ref _InstitutionallyControlledHousingStatus, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IOrganization"/> model
        /// </summary>
        public Guid OrganizationId { get => _OrganizationId; set => SetProperty(ref _OrganizationId, value); }

        /// <summary>
        /// Administrative Funding Control
        /// <para>
        /// The type of education institution as classified by its funding source.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19012">Administrative Funding Control</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefAdministrativeFundingControlId { get => _RefAdministrativeFundingControlId; set => SetProperty(ref _RefAdministrativeFundingControlId, value); }

        /// <summary>
        /// Admission Consideration Level
        /// <para>
        /// The level of consideration given a type of admission criteria used at an institution during the selection process.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20558">Admission Consideration Level</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefAdmissionConsiderationLevelId { get => _RefAdmissionConsiderationLevelId; set => SetProperty(ref _RefAdmissionConsiderationLevelId, value); }

        /// <summary>
        /// Admission Consideration Type
        /// <para>
        /// The type of admission consideration used at an institution during the selection process.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20559">Admission Consideration Type</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefAdmissionConsiderationTypeId { get => _RefAdmissionConsiderationTypeId; set => SetProperty(ref _RefAdmissionConsiderationTypeId, value); }

        /// <summary>
        /// Carnegie Basic Classification
        /// <para>
        /// The Basic Classification is an update of the traditional classification framework developed by the Carnegie Commission on Higher Education in 1970 to support its research program, and later published in 1973 for use by other researchers.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19038">Carnegie Basic Classification</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefCarnegieBasicClassificationId { get => _RefCarnegieBasicClassificationId; set => SetProperty(ref _RefCarnegieBasicClassificationId, value); }

        /// <summary>
        /// Control of Institution
        /// <para>
        /// A classification of whether a postsecondary institution is operated by publicly elected or appointed officials (public control) or by privately elected or appointed officials and derives its major source of funds from private sources (private control). 
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19048">Control of Institution</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefControlOfInstitutionId { get => _RefControlOfInstitutionId; set => SetProperty(ref _RefControlOfInstitutionId, value); }

        /// <summary>
        /// Increased Learning Time Type
        /// <para>
        /// The types of increased learning time provided.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19164">Increased Learning Time Type</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefIncreasedLearningTimeTypeId { get => _RefIncreasedLearningTimeTypeId; set => SetProperty(ref _RefIncreasedLearningTimeTypeId, value); }

        /// <summary>
        /// Level of Institution
        /// <para>
        /// A classification of whether a postsecondary institution's highest level of offering is a program of 4-years or higher (4 year), 2-but-less-than 4-years (2 year), or less than 2-years.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19178">Level of Institution</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefLevelOfInstitutionId { get => _RefLevelOfInstitutionId; set => SetProperty(ref _RefLevelOfInstitutionId, value); }

        /// <summary>
        /// Predominant Calendar System
        /// <para>
        /// The method by which an institution structures most of its courses for the academic year.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19705">Predominant Calendar System</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefPredominantCalendarSystemId { get => _RefPredominantCalendarSystemId; set => SetProperty(ref _RefPredominantCalendarSystemId, value); }

        /// <summary>
        /// Tenure System
        /// <para>
        /// An indicator of whether an institution has personnel positions that lead to consideration for tenure.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19715">Tenure System</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefTenureSystemId { get => _RefTenureSystemId; set => SetProperty(ref _RefTenureSystemId, value); }

        /// <summary>
        /// Virtual Indicator
        /// <para>
        /// Indicates a school, institution, program, or course section focuses primarily on instruction in which students and teachers are separated by time and/or location and interact through the use of computers and/or telecommunications technologies.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20167">Virtual Indicator</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.Boolean? VirtualIndicator { get => _VirtualIndicator; set => SetProperty(ref _VirtualIndicator, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IPsInstitution model)
        {
            IsBusy = true;
            Id = model.Id;
            InstitutionallyControlledHousingStatus = model.InstitutionallyControlledHousingStatus; // Institutionally Controlled Housing Status
            OrganizationId = model.OrganizationId; // 
            RefAdministrativeFundingControlId = model.RefAdministrativeFundingControlId; // Administrative Funding Control
            RefAdmissionConsiderationLevelId = model.RefAdmissionConsiderationLevelId; // Admission Consideration Level
            RefAdmissionConsiderationTypeId = model.RefAdmissionConsiderationTypeId; // Admission Consideration Type
            RefCarnegieBasicClassificationId = model.RefCarnegieBasicClassificationId; // Carnegie Basic Classification
            RefControlOfInstitutionId = model.RefControlOfInstitutionId; // Control of Institution
            RefIncreasedLearningTimeTypeId = model.RefIncreasedLearningTimeTypeId; // Increased Learning Time Type
            RefLevelOfInstitutionId = model.RefLevelOfInstitutionId; // Level of Institution
            RefPredominantCalendarSystemId = model.RefPredominantCalendarSystemId; // Predominant Calendar System
            RefTenureSystemId = model.RefTenureSystemId; // Tenure System
            VirtualIndicator = model.VirtualIndicator; // Virtual Indicator
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }

        #region RefLevelOfInstitution List
        /// <summary>
        /// The complete <see cref="RefLevelOfInstitution"> List
        /// </summary>
        private static List<ReferenceModelBase> RefLevelOfInstitutionList = new List<ReferenceModelBase>
        {
            new ReferenceModelBase { Id=Guid.Parse("18b394d5-40f0-4d89-9814-1ab4dfb23636"), Code="FourYear", Description="Four or more years", Definition="The postsecondary institution's highest level of offering is a program of four or more years.", SortOrder=Convert.ToDecimal("1.00") },
            new ReferenceModelBase { Id=Guid.Parse("d880fa90-bcc3-4a82-9fd1-006798e01057"), Code="TwoToFour", Description="At least 2 but less than 4 years", Definition="The postsecondary institution's highest level of offering is a program of at least 2 but less than 4 years.", SortOrder=Convert.ToDecimal("2.00") },
            new ReferenceModelBase { Id=Guid.Parse("831525f5-438e-4a5e-9681-abdfbd8841e3"), Code="LessThanTwo", Description="Less than 2 years (below associate)", Definition="The postsecondary institution's highest level of offering is a program of less than 2 years (below associate).", SortOrder=Convert.ToDecimal("3.00") },
        };
        #endregion

        #region RefPredominantCalendarSystem List
        /// <summary>
        /// The complete <see cref="RefPredominantCalendarSystem"> List
        /// </summary>
        private static List<ReferenceModelBase> RefPredominantCalendarSystemList = new List<ReferenceModelBase>
        {
            new ReferenceModelBase { Id=Guid.Parse("84b6efdc-8f34-4b13-a783-b81c003ad158"), Code="Semester", Description="Semester ", Definition="The institution structures most of its courses for the academic year by Semester.", SortOrder=Convert.ToDecimal("1.00") },
            new ReferenceModelBase { Id=Guid.Parse("c115c961-e8f8-4f6b-810f-d34ada152d8e"), Code="Quarter", Description="Quarter ", Definition="The institution structures most of its courses for the academic year by Quarter.", SortOrder=Convert.ToDecimal("2.00") },
            new ReferenceModelBase { Id=Guid.Parse("ca3b1ad7-defa-4eaa-9954-f5febeabfba5"), Code="Trimester", Description="Trimester", Definition="The institution structures most of its courses for the academic year by Trimester.", SortOrder=Convert.ToDecimal("3.00") },
            new ReferenceModelBase { Id=Guid.Parse("20cc2fe4-ea4b-4c26-8a36-f6c46ed29d7d"), Code="4-1-4", Description="4-1-4 or similar plan", Definition="The institution structures most of its courses for the academic year by 4-1-4 or similar plan.", SortOrder=Convert.ToDecimal("4.00") },
            new ReferenceModelBase { Id=Guid.Parse("1763353a-085f-49a6-911d-58cd4504d854"), Code="Other", Description="Other academic plan", Definition="The institution structures most of its courses for the academic year by an academic plan not yet defined in CEDS.", SortOrder=Convert.ToDecimal("5.00") },
            new ReferenceModelBase { Id=Guid.Parse("5cb8c4dc-ffaf-497f-8ae7-8ec9519f2616"), Code="DiffersByProgram", Description="Differs by program", Definition="The method by which an institution structures most of its courses for the academic year differs by program.", SortOrder=Convert.ToDecimal("6.00") },
            new ReferenceModelBase { Id=Guid.Parse("671e6607-7b96-41d0-916f-26f0e9b311e8"), Code="ContinuousBasis", Description="Continuous basis", Definition="The institution structures most of its courses for the academic year on a continuous basis.", SortOrder=Convert.ToDecimal("7.00") },
        };
        #endregion

        #region RefTenureSystem List
        /// <summary>
        /// The complete <see cref="RefTenureSystem"> List
        /// </summary>
        private static List<ReferenceModelBase> RefTenureSystemList = new List<ReferenceModelBase>
        {
            new ReferenceModelBase { Id=Guid.Parse("c8bde9c6-fc79-43e5-9e13-3076b0423ae5"), Code="Yes", Description="Yes", Definition="", SortOrder=Convert.ToDecimal("1.00") },
            new ReferenceModelBase { Id=Guid.Parse("a41a9ddd-8d49-416f-abf6-1f22e8da7eef"), Code="No", Description="No", Definition="", SortOrder=Convert.ToDecimal("2.00") },
        };
        #endregion
    }
}
