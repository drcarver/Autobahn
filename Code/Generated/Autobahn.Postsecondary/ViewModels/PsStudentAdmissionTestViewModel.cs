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
            new ReferenceModelBase { Id=Guid.Parse("0bf223db-8cc2-42d5-9a9a-6d074daff97f"), Code="SAT_Reading", Description="SAT Reading", Definition="SAT Reading is a test used for admissions purposes.", SortOrder=Convert.ToDecimal("1.00") },
            new ReferenceModelBase { Id=Guid.Parse("046579ea-ec9b-4101-9db8-dbdabcf2fe0f"), Code="SAT_Writing", Description="SAT Writing", Definition="SAT Writing is a test used for admissions purposes.", SortOrder=Convert.ToDecimal("2.00") },
            new ReferenceModelBase { Id=Guid.Parse("4a10fbf4-ce19-4c02-ba85-0973c8129d34"), Code="SAT_Math", Description="SAT Math", Definition="SAT Math is a test used for admissions purposes.", SortOrder=Convert.ToDecimal("3.00") },
            new ReferenceModelBase { Id=Guid.Parse("ecc69751-7f5f-4f73-a2b0-9b1b2b938986"), Code="SAT_Total", Description="SAT Total", Definition="SAT Total is a test used for admissions purposes.", SortOrder=Convert.ToDecimal("4.00") },
            new ReferenceModelBase { Id=Guid.Parse("a347bd45-408c-4b89-ab6f-3512e2c16c6f"), Code="ACT_English", Description="ACT English", Definition="ACT English is a test used for admissions purposes.", SortOrder=Convert.ToDecimal("5.00") },
            new ReferenceModelBase { Id=Guid.Parse("d5d58439-12c2-4a78-abfe-23d0b1768b40"), Code="ACT_Math", Description="ACT Math", Definition="ACT Math is a test used for admissions purposes.", SortOrder=Convert.ToDecimal("6.00") },
            new ReferenceModelBase { Id=Guid.Parse("752ec74e-f3e8-4b98-bb8c-0399e069ae80"), Code="ACT_Reading", Description="ACT Reading", Definition="ACT Reading is a test used for admissions purposes.", SortOrder=Convert.ToDecimal("7.00") },
            new ReferenceModelBase { Id=Guid.Parse("9af6d154-ce77-47a4-98be-a2219426d854"), Code="ACT_Science", Description="ACT Science", Definition="ACT Science is a test used for admissions purposes.", SortOrder=Convert.ToDecimal("8.00") },
            new ReferenceModelBase { Id=Guid.Parse("06107f01-7186-4583-8c65-b84860b1143d"), Code="ACT_Composite", Description="ACT Composite", Definition="ACT Composite is a test used for admissions purposes.", SortOrder=Convert.ToDecimal("9.00") },
            new ReferenceModelBase { Id=Guid.Parse("38127db7-5e70-4870-95c8-239d8d0c9f15"), Code="COMPASS_reading", Description="COMPASS reading", Definition="COMPASS reading is a test used for admissions purposes.", SortOrder=Convert.ToDecimal("10.00") },
            new ReferenceModelBase { Id=Guid.Parse("7c716208-63c1-4e02-a411-e8577d615258"), Code="COMPASS_writing", Description="COMPASS writing", Definition="COMPASS writing is a test used for admissions purposes.", SortOrder=Convert.ToDecimal("11.00") },
            new ReferenceModelBase { Id=Guid.Parse("5266577f-7c89-430b-8258-43a994059d0f"), Code="COMPASS_math", Description="COMPASS math", Definition="COMPASS math is a test used for admissions purposes.", SortOrder=Convert.ToDecimal("12.00") },
            new ReferenceModelBase { Id=Guid.Parse("3095bfab-5ac4-4687-976a-bde676e153d8"), Code="Accuplacer_reading", Description="Accuplacer reading", Definition="Accuplacer reading is a test used for admissions purposes.", SortOrder=Convert.ToDecimal("13.00") },
            new ReferenceModelBase { Id=Guid.Parse("71866efc-e5e1-4d1d-9dd4-94a433e2f4d5"), Code="Accuplacer_writing", Description="Accuplacer writing", Definition="Accuplacer writing is a test used for admissions purposes.", SortOrder=Convert.ToDecimal("14.00") },
            new ReferenceModelBase { Id=Guid.Parse("9d065a09-e45d-4970-a03e-a977bfed12b9"), Code="Accuplacer_math", Description="Accuplacer math", Definition="Accuplacer math is a test used for admissions purposes.", SortOrder=Convert.ToDecimal("15.00") },
            new ReferenceModelBase { Id=Guid.Parse("5b997fad-3f6e-4970-9192-758084946697"), Code="Other", Description="Other", Definition="The test type used for admissions purposes is not yet included in CEDS as a Standardized Admissions Test Type.", SortOrder=Convert.ToDecimal("100.00") },
        };
        #endregion
    }
}
