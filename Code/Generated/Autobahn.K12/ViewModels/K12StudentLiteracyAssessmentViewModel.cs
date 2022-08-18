//**********************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12StudentLiteracyAssessmentViewModel.cs
//***************************************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using Autobahn.Common.Models;
using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.K12.ViewModels
{
     /// <summary>
     /// The K12StudentLiteracyAssessment View Model
     /// </summary>
    public partial class K12StudentLiteracyAssessmentViewModel : ViewModelBase, Interfaces.IK12StudentLiteracyAssessment
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from K12StudentLiteracyAssessment";

        // LiteracyGoalMetStatus -- (backing property for Literacy Goal Met Status)
        private System.Boolean? _LiteracyGoalMetStatus;

        // LiteracyPostTestStatus -- (backing property for Literacy Post Test Status)
        private System.Boolean? _LiteracyPostTestStatus;

        // LiteracyPreTestStatus -- (backing property for Literacy Pre Test Status)
        private System.Boolean? _LiteracyPreTestStatus;

        // member variable for the OrganizationPersonRoleId property
        private Guid _OrganizationPersonRoleId;

        // RefLiteracyAssessmentId -- (backing property for Literacy Assessment Administered Type)
        private Guid? _RefLiteracyAssessmentId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Literacy Goal Met Status
        /// <para>
        /// The participant showed "significant learning gains" on measures of reading, the definition of which is determined at the State level.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19457">Literacy Goal Met Status</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.Boolean? LiteracyGoalMetStatus { get => _LiteracyGoalMetStatus; set => SetProperty(ref _LiteracyGoalMetStatus, value); }

        /// <summary>
        /// Literacy Post Test Status
        /// <para>
        /// The participant completed a literacy post-test.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19458">Literacy Post Test Status</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.Boolean? LiteracyPostTestStatus { get => _LiteracyPostTestStatus; set => SetProperty(ref _LiteracyPostTestStatus, value); }

        /// <summary>
        /// Literacy Pre Test Status
        /// <para>
        /// The participant completed a literacy pre-test.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19459">Literacy Pre Test Status</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.Boolean? LiteracyPreTestStatus { get => _LiteracyPreTestStatus; set => SetProperty(ref _LiteracyPreTestStatus, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
        /// </summary>
        public Guid OrganizationPersonRoleId { get => _OrganizationPersonRoleId; set => SetProperty(ref _OrganizationPersonRoleId, value); }

        /// <summary>
        /// Literacy Assessment Administered Type
        /// <para>
        /// The type of literacy test administered.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19456">Literacy Assessment Administered Type</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefLiteracyAssessmentId { get => _RefLiteracyAssessmentId; set => SetProperty(ref _RefLiteracyAssessmentId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IK12StudentLiteracyAssessment model)
        {
            IsBusy = true;
            Id = model.Id;
            LiteracyGoalMetStatus = model.LiteracyGoalMetStatus; // Literacy Goal Met Status
            LiteracyPostTestStatus = model.LiteracyPostTestStatus; // Literacy Post Test Status
            LiteracyPreTestStatus = model.LiteracyPreTestStatus; // Literacy Pre Test Status
            OrganizationPersonRoleId = model.OrganizationPersonRoleId; // 
            RefLiteracyAssessmentId = model.RefLiteracyAssessmentId; // Literacy Assessment Administered Type
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }

        #region RefLiteracyAssessment List
        /// <summary>
        /// The complete <see cref="RefLiteracyAssessment"> List
        /// </summary>
        private static List<ReferenceModelBase> RefLiteracyAssessmentList = new List<ReferenceModelBase>
        {
            new ReferenceModelBase { Id=Guid.Parse("cad6633c-6498-40bf-88cf-bfb0c304be45"), Code="TABE", Description="TABE", Definition="TABE is the type of literacy test administered.", SortOrder=Convert.ToDecimal("1.00") },
            new ReferenceModelBase { Id=Guid.Parse("91bec935-e81b-4ced-98a3-29a3529cdffd"), Code="CASAS", Description="CASAS", Definition="CASAS is the type of literacy test administered.", SortOrder=Convert.ToDecimal("2.00") },
            new ReferenceModelBase { Id=Guid.Parse("6c34c7d7-8b71-4466-8f46-785215b8f7f4"), Code="BEST", Description="BEST", Definition="BEST is the type of literacy test administered.", SortOrder=Convert.ToDecimal("3.00") },
            new ReferenceModelBase { Id=Guid.Parse("0d8055e7-5fe0-4cbc-a33d-b16df40a82af"), Code="BESTPlus", Description="BESTPlus", Definition="BESTPlus is the type of literacy test administered.", SortOrder=Convert.ToDecimal("4.00") },
            new ReferenceModelBase { Id=Guid.Parse("d6f7003b-235d-466e-84dd-722f61d3a80a"), Code="BESTLiteracy", Description="BEST Literacy", Definition="BEST Literacy is the type of literacy test administered.", SortOrder=Convert.ToDecimal("5.00") },
            new ReferenceModelBase { Id=Guid.Parse("36f92118-5e96-475c-ac8a-271469d8f42e"), Code="PPVT-III", Description="PPVT-III", Definition="PPVT-III is the type of literacy test administered.", SortOrder=Convert.ToDecimal("6.00") },
            new ReferenceModelBase { Id=Guid.Parse("741c3b24-8028-495c-bef0-286e767f8820"), Code="PPVT-IV", Description="PPVT-IV", Definition="PPVT-IV is the type of literacy test administered.", SortOrder=Convert.ToDecimal("7.00") },
            new ReferenceModelBase { Id=Guid.Parse("062629f5-bcbd-4402-b5bb-dd20e589c534"), Code="TVIP", Description="TVIP", Definition="TVIP is the type of literacy test administered.", SortOrder=Convert.ToDecimal("8.00") },
            new ReferenceModelBase { Id=Guid.Parse("7f8b2d24-c3ab-4022-ba31-dda3859f21ff"), Code="PALSPreKUpperCase", Description="PALS PreK Upper Case", Definition="PALS PreK Upper Case is the type of literacy test administered.", SortOrder=Convert.ToDecimal("9.00") },
            new ReferenceModelBase { Id=Guid.Parse("18c5dce4-26ba-4b94-a4bc-3a65da8fddff"), Code="PEPScaleI", Description="PEP Scale I", Definition="PEP Scale I is the type of literacy test administered.", SortOrder=Convert.ToDecimal("10.00") },
            new ReferenceModelBase { Id=Guid.Parse("086254b1-3601-425c-856d-a19047b07e98"), Code="PEPScaleII", Description="PEP Scale II", Definition="PEP Scale II is the type of literacy test administered.", SortOrder=Convert.ToDecimal("11.00") },
            new ReferenceModelBase { Id=Guid.Parse("8fe3adb8-aca7-4c70-9640-6c3ff12c5616"), Code="PEPScaleIII", Description="PEP Scale III", Definition="PEP Scale III is the type of literacy test administered.", SortOrder=Convert.ToDecimal("12.00") },
            new ReferenceModelBase { Id=Guid.Parse("94508c33-ba23-47af-b37b-59bf8eb03bc1"), Code="PEPScaleIV", Description="PEP Scale IV", Definition="PEP Scale IV is the type of literacy test administered.", SortOrder=Convert.ToDecimal("13.00") },
            new ReferenceModelBase { Id=Guid.Parse("030e113b-0c26-48b7-b9e7-704357f6a651"), Code="Other", Description="Other", Definition="The type of literacy test administered is in a category not yet defined by CEDS.", SortOrder=Convert.ToDecimal("14.00") },
        };
        #endregion
    }
}
