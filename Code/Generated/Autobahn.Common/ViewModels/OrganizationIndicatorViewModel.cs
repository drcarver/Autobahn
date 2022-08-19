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
            new ReferenceModelBase { Id=Guid.Parse("1b101220-aacc-459f-910b-853d895c510d"), Code="AP Course Self Selection", Description="Advanced Placement Course Self Selection", Definition="", SortOrder=Convert.ToDecimal("") },
            new ReferenceModelBase { Id=Guid.Parse("c43bb8c3-b5f6-4812-b646-a3871273ff05"), Code="PersistentlyLowestAchievingSchool", Description="Persistently Lowest Achieving School", Definition="", SortOrder=Convert.ToDecimal("") },
            new ReferenceModelBase { Id=Guid.Parse("2c39f856-56de-4550-b080-f508cae3cf84"), Code="SharedTime", Description="Shared Time", Definition="", SortOrder=Convert.ToDecimal("") },
            new ReferenceModelBase { Id=Guid.Parse("13036590-a6d1-4a1a-b284-2a7b9d82a179"), Code="AbilityGrouping", Description="Ability Grouping", Definition="", SortOrder=Convert.ToDecimal("") },
            new ReferenceModelBase { Id=Guid.Parse("acd43ef4-054d-4775-9e63-49772e07ec85"), Code="ProgramProvidesTranslatedMaterials", Description="Program Provides Translated Materials", Definition="", SortOrder=Convert.ToDecimal("") },
            new ReferenceModelBase { Id=Guid.Parse("245c44ae-a260-4571-9895-d5fc2de175e8"), Code="EarlyLearningProgramDevelopmentalScreening", Description="Early Learning Program Developmental Screening", Definition="", SortOrder=Convert.ToDecimal("") },
            new ReferenceModelBase { Id=Guid.Parse("55ffa354-b011-4121-a193-2cca829730a7"), Code="ProgramProvidesWrittenHandbook", Description="Program Provides Written Handbook", Definition="", SortOrder=Convert.ToDecimal("") },
            new ReferenceModelBase { Id=Guid.Parse("881401a3-14fc-4809-8d51-bc151670374f"), Code="ProgramCollectsParentalFeedback", Description="Program Collects Parental Feedback", Definition="", SortOrder=Convert.ToDecimal("") },
            new ReferenceModelBase { Id=Guid.Parse("66fd0cb3-41d8-4c9d-81a5-a3da1a181392"), Code="ProgramProvidesParentInvolvementOpportunity", Description="Program Provides Parent Involvement Opportunity", Definition="", SortOrder=Convert.ToDecimal("") },
            new ReferenceModelBase { Id=Guid.Parse("aef06d74-cfd8-4904-9fd9-1b108bcb7fb3"), Code="ProgramProvidesParentEducation", Description="Program Provides Parent Education", Definition="", SortOrder=Convert.ToDecimal("") },
            new ReferenceModelBase { Id=Guid.Parse("7ce69b06-7e0d-4948-b4b9-f220f469adfa"), Code="AssessmentSharedwithParents", Description="Assessment Shared with Parents", Definition="", SortOrder=Convert.ToDecimal("") },
            new ReferenceModelBase { Id=Guid.Parse("ff70025c-8923-4357-9a5c-d30e5ff06d10"), Code="ProgramFollowsSalaryScale", Description="Program Follows Salary Scale", Definition="", SortOrder=Convert.ToDecimal("") },
            new ReferenceModelBase { Id=Guid.Parse("1b4e9038-5bbc-4227-a85d-90adfaa497d3"), Code="DifferentialShiftPay", Description="Differential Shift Pay", Definition="", SortOrder=Convert.ToDecimal("") },
            new ReferenceModelBase { Id=Guid.Parse("6c3d8299-7aa4-4475-a8b7-963472aeda05"), Code="Virtual", Description="Virtual", Definition="", SortOrder=Convert.ToDecimal("") },
        };
        #endregion
    }
}
