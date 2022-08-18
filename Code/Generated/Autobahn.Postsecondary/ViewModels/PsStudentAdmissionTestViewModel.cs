//**********************************************************
//* DomainName: Postsecondary (PS)
//* FileName:   PsStudentAdmissionTestViewModel.cs
//***************************************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using Autobahn.Common.Models;
using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Postsecondary.ViewModels
{
     /// <summary>
     /// The PsStudentAdmissionTest View Model
     /// </summary>
    public partial class PsStudentAdmissionTestViewModel : ViewModelBase, Interfaces.IPsStudentAdmissionTest
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from PsStudentAdmissionTest";

        // member variable for the OrganizationPersonRoleId property
        private Guid _OrganizationPersonRoleId;

        // RefStandardizedAdmissionTestId -- (backing property for Standardized Admission Test Type)
        private Guid _RefStandardizedAdmissionTestId;

        // StandardizedAdmissionTestScore -- (backing property for Standardized Admission Test Score)
        private System.Decimal? _StandardizedAdmissionTestScore;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
        /// </summary>
        public Guid OrganizationPersonRoleId { get => _OrganizationPersonRoleId; set => SetProperty(ref _OrganizationPersonRoleId, value); }

        /// <summary>
        /// Standardized Admission Test Type
        /// <para>
        /// The type of test prepared and administered by an agency that is independent of any postsecondary education institution and is typically used for admissions purposes. Tests provide information about prospective students and their academic qualifications relative to a national sample.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19266">Standardized Admission Test Type</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid RefStandardizedAdmissionTestId { get => _RefStandardizedAdmissionTestId; set => SetProperty(ref _RefStandardizedAdmissionTestId, value); }

        /// <summary>
        /// Standardized Admission Test Score
        /// <para>
        /// The quantitative score on a standardized admission test reported to a postsecondary institution.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19265">Standardized Admission Test Score</a>
        /// </para>
        /// </summary>
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
            OrganizationPersonRoleId = model.OrganizationPersonRoleId; // 
            RefStandardizedAdmissionTestId = model.RefStandardizedAdmissionTestId; // Standardized Admission Test Type
            StandardizedAdmissionTestScore = model.StandardizedAdmissionTestScore; // Standardized Admission Test Score
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }

        #region RefStandardizedAdmissionTest List
        /// <summary>
        /// The complete <see cref="RefStandardizedAdmissionTest"> List
        /// </summary>
        private static List<ReferenceModelBase> RefStandardizedAdmissionTestList = new List<ReferenceModelBase>
        {
            new ReferenceModelBase { Id=Guid.Parse("afefc266-d058-4e98-9e3a-ae5189b72281"), Code="SAT_Reading", Description="SAT Reading", Definition="SAT Reading is a test used for admissions purposes.", SortOrder=Convert.ToDecimal("1.00") },
            new ReferenceModelBase { Id=Guid.Parse("7d971858-903c-456b-ac47-c1f2eefcea56"), Code="SAT_Writing", Description="SAT Writing", Definition="SAT Writing is a test used for admissions purposes.", SortOrder=Convert.ToDecimal("2.00") },
            new ReferenceModelBase { Id=Guid.Parse("f1ac3dd4-07e7-4675-9ecd-030f33e5e840"), Code="SAT_Math", Description="SAT Math", Definition="SAT Math is a test used for admissions purposes.", SortOrder=Convert.ToDecimal("3.00") },
            new ReferenceModelBase { Id=Guid.Parse("9847c197-4acb-4b65-a94d-6747a0aa4a6f"), Code="SAT_Total", Description="SAT Total", Definition="SAT Total is a test used for admissions purposes.", SortOrder=Convert.ToDecimal("4.00") },
            new ReferenceModelBase { Id=Guid.Parse("8f72bbea-f825-49d6-935f-29cb873dd2c0"), Code="ACT_English", Description="ACT English", Definition="ACT English is a test used for admissions purposes.", SortOrder=Convert.ToDecimal("5.00") },
            new ReferenceModelBase { Id=Guid.Parse("5a6eb8af-178e-469a-89e1-5ec8ffcb56a5"), Code="ACT_Math", Description="ACT Math", Definition="ACT Math is a test used for admissions purposes.", SortOrder=Convert.ToDecimal("6.00") },
            new ReferenceModelBase { Id=Guid.Parse("2fea47c1-3812-439a-8f70-b5031ce5c6bf"), Code="ACT_Reading", Description="ACT Reading", Definition="ACT Reading is a test used for admissions purposes.", SortOrder=Convert.ToDecimal("7.00") },
            new ReferenceModelBase { Id=Guid.Parse("b3b3d2e7-75a2-412a-8d30-49946ec03755"), Code="ACT_Science", Description="ACT Science", Definition="ACT Science is a test used for admissions purposes.", SortOrder=Convert.ToDecimal("8.00") },
            new ReferenceModelBase { Id=Guid.Parse("c81b7f79-1873-45c8-8714-d420dc6f291f"), Code="ACT_Composite", Description="ACT Composite", Definition="ACT Composite is a test used for admissions purposes.", SortOrder=Convert.ToDecimal("9.00") },
            new ReferenceModelBase { Id=Guid.Parse("08731709-0d22-49ab-bd84-733e032a935e"), Code="COMPASS_reading", Description="COMPASS reading", Definition="COMPASS reading is a test used for admissions purposes.", SortOrder=Convert.ToDecimal("10.00") },
            new ReferenceModelBase { Id=Guid.Parse("97bec452-af2d-494e-95f5-d1d5e8bc6eae"), Code="COMPASS_writing", Description="COMPASS writing", Definition="COMPASS writing is a test used for admissions purposes.", SortOrder=Convert.ToDecimal("11.00") },
            new ReferenceModelBase { Id=Guid.Parse("aa3f2d8b-3bf8-4bc8-b44b-58ab41fa8eb5"), Code="COMPASS_math", Description="COMPASS math", Definition="COMPASS math is a test used for admissions purposes.", SortOrder=Convert.ToDecimal("12.00") },
            new ReferenceModelBase { Id=Guid.Parse("ed754608-3b4d-4b9f-841c-266fcc943ddb"), Code="Accuplacer_reading", Description="Accuplacer reading", Definition="Accuplacer reading is a test used for admissions purposes.", SortOrder=Convert.ToDecimal("13.00") },
            new ReferenceModelBase { Id=Guid.Parse("92220f5c-3aeb-4a42-bff9-675e9c0ccd1e"), Code="Accuplacer_writing", Description="Accuplacer writing", Definition="Accuplacer writing is a test used for admissions purposes.", SortOrder=Convert.ToDecimal("14.00") },
            new ReferenceModelBase { Id=Guid.Parse("d34f0972-7127-417a-8fa1-bd1a895189fa"), Code="Accuplacer_math", Description="Accuplacer math", Definition="Accuplacer math is a test used for admissions purposes.", SortOrder=Convert.ToDecimal("15.00") },
            new ReferenceModelBase { Id=Guid.Parse("768d7e9f-8c9e-4cca-b0eb-f7e6bb28633a"), Code="Other", Description="Other", Definition="The test type used for admissions purposes is not yet included in CEDS as a Standardized Admissions Test Type.", SortOrder=Convert.ToDecimal("100.00") },
        };
        #endregion
    }
}
