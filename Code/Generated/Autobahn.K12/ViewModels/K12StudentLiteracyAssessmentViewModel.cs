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
            new ReferenceModelBase { Id=Guid.Parse("8ef6d661-dc19-4e6c-aad9-c1997b93862f"), Code="TABE", Description="TABE", Definition="TABE is the type of literacy test administered.", SortOrder=Convert.ToDecimal("1.00") },
            new ReferenceModelBase { Id=Guid.Parse("23f0f205-90f1-44db-99dc-0c79bd0346ed"), Code="CASAS", Description="CASAS", Definition="CASAS is the type of literacy test administered.", SortOrder=Convert.ToDecimal("2.00") },
            new ReferenceModelBase { Id=Guid.Parse("07810e20-2e4d-4331-84e4-cd068aeaa3db"), Code="BEST", Description="BEST", Definition="BEST is the type of literacy test administered.", SortOrder=Convert.ToDecimal("3.00") },
            new ReferenceModelBase { Id=Guid.Parse("f0a5e384-0985-449b-9998-86ed2aa80de5"), Code="BESTPlus", Description="BESTPlus", Definition="BESTPlus is the type of literacy test administered.", SortOrder=Convert.ToDecimal("4.00") },
            new ReferenceModelBase { Id=Guid.Parse("9131850c-3312-4318-bd75-8413277a0a08"), Code="BESTLiteracy", Description="BEST Literacy", Definition="BEST Literacy is the type of literacy test administered.", SortOrder=Convert.ToDecimal("5.00") },
            new ReferenceModelBase { Id=Guid.Parse("cc7b4245-1258-4175-b25e-211f9cc5858d"), Code="PPVT-III", Description="PPVT-III", Definition="PPVT-III is the type of literacy test administered.", SortOrder=Convert.ToDecimal("6.00") },
            new ReferenceModelBase { Id=Guid.Parse("14cd7984-dddb-4d4d-b2c7-208f4c08dd7a"), Code="PPVT-IV", Description="PPVT-IV", Definition="PPVT-IV is the type of literacy test administered.", SortOrder=Convert.ToDecimal("7.00") },
            new ReferenceModelBase { Id=Guid.Parse("6fc4349c-5494-44fa-8c15-4eb843131414"), Code="TVIP", Description="TVIP", Definition="TVIP is the type of literacy test administered.", SortOrder=Convert.ToDecimal("8.00") },
            new ReferenceModelBase { Id=Guid.Parse("c9ae5e13-e172-45e4-9c3f-5c902d0ebd74"), Code="PALSPreKUpperCase", Description="PALS PreK Upper Case", Definition="PALS PreK Upper Case is the type of literacy test administered.", SortOrder=Convert.ToDecimal("9.00") },
            new ReferenceModelBase { Id=Guid.Parse("f025f225-a2d3-427e-801e-364943067393"), Code="PEPScaleI", Description="PEP Scale I", Definition="PEP Scale I is the type of literacy test administered.", SortOrder=Convert.ToDecimal("10.00") },
            new ReferenceModelBase { Id=Guid.Parse("36a4264f-337e-4222-8349-1ba52f3555a3"), Code="PEPScaleII", Description="PEP Scale II", Definition="PEP Scale II is the type of literacy test administered.", SortOrder=Convert.ToDecimal("11.00") },
            new ReferenceModelBase { Id=Guid.Parse("3ddbee5a-813a-4d73-aa59-03e9d77f4df6"), Code="PEPScaleIII", Description="PEP Scale III", Definition="PEP Scale III is the type of literacy test administered.", SortOrder=Convert.ToDecimal("12.00") },
            new ReferenceModelBase { Id=Guid.Parse("30e93d68-daa2-4aca-8e76-e0c1315d1e3b"), Code="PEPScaleIV", Description="PEP Scale IV", Definition="PEP Scale IV is the type of literacy test administered.", SortOrder=Convert.ToDecimal("13.00") },
            new ReferenceModelBase { Id=Guid.Parse("4ad4258c-7f7c-4318-8183-6fbaccce90ed"), Code="Other", Description="Other", Definition="The type of literacy test administered is in a category not yet defined by CEDS.", SortOrder=Convert.ToDecimal("14.00") },
        };
        #endregion
    }
}
