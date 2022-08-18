//**********************************************************
//* DomainName: Common Models
//* FileName:   OrganizationIndicatorViewModel.cs
//***************************************************************************

using Autobahn.Common.Models;
using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The OrganizationIndicator View Model
     /// </summary>
    public partial class OrganizationIndicatorViewModel : ViewModelBase, Interfaces.IOrganizationIndicator
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from OrganizationIndicator";

        // member variable for the IndicatorValue property
        private System.String _IndicatorValue;

        // member variable for the OrganizationId property
        private Guid _OrganizationId;

        // RefOrganizationIndicatorId -- (backing property for Ability Grouping Status)
        private Guid _RefOrganizationIndicatorId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        public System.String IndicatorValue { get => _IndicatorValue; set => SetProperty(ref _IndicatorValue, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IOrganization"/> model
        /// </summary>
        public Guid OrganizationId { get => _OrganizationId; set => SetProperty(ref _OrganizationId, value); }

        /// <summary>
        /// Ability Grouping Status
        /// <para>
        /// An indication of whether the school has students who are ability grouped for classroom instruction in mathematics or English/reading/language arts.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19000">Ability Grouping Status</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid RefOrganizationIndicatorId { get => _RefOrganizationIndicatorId; set => SetProperty(ref _RefOrganizationIndicatorId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IOrganizationIndicator model)
        {
            IsBusy = true;
            Id = model.Id;
            IndicatorValue = model.IndicatorValue; // 
            OrganizationId = model.OrganizationId; // 
            RefOrganizationIndicatorId = model.RefOrganizationIndicatorId; // Ability Grouping Status
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }

        #region RefOrganizationIndicator List
        /// <summary>
        /// The complete <see cref="RefOrganizationIndicator"> List
        /// </summary>
        private static List<ReferenceModelBase> RefOrganizationIndicatorList = new List<ReferenceModelBase>
        {
            new ReferenceModelBase { Id=Guid.Parse("aee1e5ea-ca2b-4656-b88a-dd700256fc3c"), Code="AP Course Self Selection", Description="Advanced Placement Course Self Selection", Definition="", SortOrder=Convert.ToDecimal("") },
            new ReferenceModelBase { Id=Guid.Parse("1c073242-de6f-41de-a7b1-9b05817394e4"), Code="PersistentlyLowestAchievingSchool", Description="Persistently Lowest Achieving School", Definition="", SortOrder=Convert.ToDecimal("") },
            new ReferenceModelBase { Id=Guid.Parse("cee04e85-a3a1-4c3f-aaae-ce1f81706b64"), Code="SharedTime", Description="Shared Time", Definition="", SortOrder=Convert.ToDecimal("") },
            new ReferenceModelBase { Id=Guid.Parse("b2912672-0d4d-4550-a5db-2b49fbb05438"), Code="AbilityGrouping", Description="Ability Grouping", Definition="", SortOrder=Convert.ToDecimal("") },
            new ReferenceModelBase { Id=Guid.Parse("10cdfd71-a418-4b3a-be56-5e5aa80eb6cc"), Code="ProgramProvidesTranslatedMaterials", Description="Program Provides Translated Materials", Definition="", SortOrder=Convert.ToDecimal("") },
            new ReferenceModelBase { Id=Guid.Parse("53a58de3-fe1e-4ffd-9e77-bb5ebdc7503b"), Code="EarlyLearningProgramDevelopmentalScreening", Description="Early Learning Program Developmental Screening", Definition="", SortOrder=Convert.ToDecimal("") },
            new ReferenceModelBase { Id=Guid.Parse("c03de87f-752e-468a-a1e1-623ca732d42e"), Code="ProgramProvidesWrittenHandbook", Description="Program Provides Written Handbook", Definition="", SortOrder=Convert.ToDecimal("") },
            new ReferenceModelBase { Id=Guid.Parse("603b318d-aff7-4775-a9d8-f953a6984a32"), Code="ProgramCollectsParentalFeedback", Description="Program Collects Parental Feedback", Definition="", SortOrder=Convert.ToDecimal("") },
            new ReferenceModelBase { Id=Guid.Parse("1608e8f6-d2fc-4cc5-9d8b-3dfa79490229"), Code="ProgramProvidesParentInvolvementOpportunity", Description="Program Provides Parent Involvement Opportunity", Definition="", SortOrder=Convert.ToDecimal("") },
            new ReferenceModelBase { Id=Guid.Parse("33c17890-1731-4585-9266-82682f367ea8"), Code="ProgramProvidesParentEducation", Description="Program Provides Parent Education", Definition="", SortOrder=Convert.ToDecimal("") },
            new ReferenceModelBase { Id=Guid.Parse("f660f985-670e-4d90-aaa5-47faa81c376e"), Code="AssessmentSharedwithParents", Description="Assessment Shared with Parents", Definition="", SortOrder=Convert.ToDecimal("") },
            new ReferenceModelBase { Id=Guid.Parse("935cb495-a7f0-490b-94bb-7738eec613d6"), Code="ProgramFollowsSalaryScale", Description="Program Follows Salary Scale", Definition="", SortOrder=Convert.ToDecimal("") },
            new ReferenceModelBase { Id=Guid.Parse("c05b92ad-dbbf-4560-9a66-58c9b2ecc077"), Code="DifferentialShiftPay", Description="Differential Shift Pay", Definition="", SortOrder=Convert.ToDecimal("") },
            new ReferenceModelBase { Id=Guid.Parse("b56c467f-5738-42b3-b811-696afc33a316"), Code="Virtual", Description="Virtual", Definition="", SortOrder=Convert.ToDecimal("") },
        };
        #endregion
    }
}
