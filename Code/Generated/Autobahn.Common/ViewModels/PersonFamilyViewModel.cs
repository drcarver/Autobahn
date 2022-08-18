//**********************************************************
//* DomainName: Common Models
//* FileName:   PersonFamilyViewModel.cs
//***************************************************************************

using Autobahn.Common.Models;
using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The PersonFamily View Model
     /// </summary>
    public partial class PersonFamilyViewModel : ViewModelBase, Interfaces.IPersonFamily
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from PersonFamily";

        // FamilyIdentifier -- (backing property for Family Identifier)
        private System.String _FamilyIdentifier;

        // FamilyIncome -- (backing property for Family Income)
        private System.Decimal? _FamilyIncome;

        // IncludedInCountedFamilySize -- (backing property for Included in Counted Family Size)
        private System.Boolean? _IncludedInCountedFamilySize;

        // NumberOfHouseholdCollegeStudents -- (backing property for Number of Household College Students)
        private System.Int32? _NumberOfHouseholdCollegeStudents;

        // NumberOfPeopleInFamily -- (backing property for Number of People in Family)
        private System.Int32? _NumberOfPeopleInFamily;

        // NumberOfPeopleInHousehold -- (backing property for Number of People in Household)
        private System.Int32? _NumberOfPeopleInHousehold;

        // member variable for the PersonId property
        private Guid _PersonId;

        // RefCommunicationMethodId -- (backing property for Parent Communication Method)
        private Guid? _RefCommunicationMethodId;

        // RefELProgramEligibilityId -- (backing property for Early Learning Program Eligibility Category)
        private Guid? _RefELProgramEligibilityId;

        // RefFamilyIncomeSourceId -- (backing property for Source of Family Income)
        private Guid? _RefFamilyIncomeSourceId;

        // RefHighestEducationLevelCompletedId -- (backing property for Highest Level of Education Completed)
        private Guid? _RefHighestEducationLevelCompletedId;

        // RefIncomeCalculationMethodId -- (backing property for Income Calculation Method)
        private Guid? _RefIncomeCalculationMethodId;

        // RefProofOfResidencyTypeId -- (backing property for Proof of Residency Type)
        private Guid? _RefProofOfResidencyTypeId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Family Identifier
        /// <para>
        /// A unique number or alphanumeric code assigned to a family by a school, school system, a state, or other agency or entity.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19784">Family Identifier</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.String FamilyIdentifier { get => _FamilyIdentifier; set => SetProperty(ref _FamilyIdentifier, value); }

        /// <summary>
        /// Family Income
        /// <para>
        /// Total income of family from all sources. Income includes money, wages or salary before deductions; net income from non-farm self-employment; net income from farm self-employment; regular payments from Social Security or railroad retirement; payments from unemployment compensation, strike benefits from union funds, workers' compensation, veterans benefits (with the exception noted below), public assistance (including Temporary Assistance for Needy Families, Supplemental Security Income, Emergency Assistance money payments, and non-Federally funded General Assistance or General Relief money payments); training stipends; alimony, child support, and military family allotments or other regular support from an absent family member or someone not living in the household; private pensions, government employee pensions (including military retirement pay), and regular insurance or annuity payments; college or university scholarships, grants, fellowships, and assistantships; and dividends, interest, net rental income, net royalties, and periodic receipts from estates or trusts; and net gambling or lottery winnings.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19331">Family Income</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.Decimal? FamilyIncome { get => _FamilyIncome; set => SetProperty(ref _FamilyIncome, value); }

        /// <summary>
        /// Included in Counted Family Size
        /// <para>
        /// Denotes whether this family member is counted in the family size as it pertains to the federal poverty level
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20591">Included in Counted Family Size</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.Boolean? IncludedInCountedFamilySize { get => _IncludedInCountedFamilySize; set => SetProperty(ref _IncludedInCountedFamilySize, value); }

        /// <summary>
        /// Number of Household College Students
        /// <para>
        /// Number of people, including the student, who will attend at least half-time in the current academic year, a program that leads to a college degree or certificate
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20950">Number of Household College Students</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.Int32? NumberOfHouseholdCollegeStudents { get => _NumberOfHouseholdCollegeStudents; set => SetProperty(ref _NumberOfHouseholdCollegeStudents, value); }

        /// <summary>
        /// Number of People in Family
        /// <para>
        /// Total number of persons in immediate family. Family means for the purposes of the regulations in this part all persons: (i) Living in the same household who are: (A) Supported by the income of the parent(s) or guardian(s) of the child enrolling or participating in the program; or (B) Related to the child by blood, marriage, or adoption; or &#x0D;
        /// </para>
        /// </summary>
        /// </summary>
        public System.Int32? NumberOfPeopleInFamily { get => _NumberOfPeopleInFamily; set => SetProperty(ref _NumberOfPeopleInFamily, value); }

        /// <summary>
        /// Number of People in Household
        /// <para>
        /// Total number of persons residing in the same household.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19330">Number of People in Household</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.Int32? NumberOfPeopleInHousehold { get => _NumberOfPeopleInHousehold; set => SetProperty(ref _NumberOfPeopleInHousehold, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IPerson"/> model
        /// </summary>
        public Guid PersonId { get => _PersonId; set => SetProperty(ref _PersonId, value); }

        /// <summary>
        /// Parent Communication Method
        /// <para>
        /// The types of communication methods with parents.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19857">Parent Communication Method</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefCommunicationMethodId { get => _RefCommunicationMethodId; set => SetProperty(ref _RefCommunicationMethodId, value); }

        /// <summary>
        /// Early Learning Program Eligibility Category
        /// <para>
        /// Category under which the person is eligible for an early childhood program or service.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19304">Early Learning Program Eligibility Category</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefELProgramEligibilityId { get => _RefELProgramEligibilityId; set => SetProperty(ref _RefELProgramEligibilityId, value); }

        /// <summary>
        /// Source of Family Income
        /// <para>
        /// Sources of total family income.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19332">Source of Family Income</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefFamilyIncomeSourceId { get => _RefFamilyIncomeSourceId; set => SetProperty(ref _RefFamilyIncomeSourceId, value); }

        /// <summary>
        /// Highest Level of Education Completed
        /// <para>
        /// The extent of formal instruction a person has received (e.g., the highest grade in school completed or its equivalent or the highest degree received).
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19141">Highest Level of Education Completed</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefHighestEducationLevelCompletedId { get => _RefHighestEducationLevelCompletedId; set => SetProperty(ref _RefHighestEducationLevelCompletedId, value); }

        /// <summary>
        /// Income Calculation Method
        /// <para>
        /// The calculation method used by a program to determine total family income.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19333">Income Calculation Method</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefIncomeCalculationMethodId { get => _RefIncomeCalculationMethodId; set => SetProperty(ref _RefIncomeCalculationMethodId, value); }

        /// <summary>
        /// Proof of Residency Type
        /// <para>
        /// An accepted form of proof of residency in the district/county/other locality.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19305">Proof of Residency Type</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefProofOfResidencyTypeId { get => _RefProofOfResidencyTypeId; set => SetProperty(ref _RefProofOfResidencyTypeId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IPersonFamily model)
        {
            IsBusy = true;
            Id = model.Id;
            FamilyIdentifier = model.FamilyIdentifier; // Family Identifier
            FamilyIncome = model.FamilyIncome; // Family Income
            IncludedInCountedFamilySize = model.IncludedInCountedFamilySize; // Included in Counted Family Size
            NumberOfHouseholdCollegeStudents = model.NumberOfHouseholdCollegeStudents; // Number of Household College Students
            NumberOfPeopleInFamily = model.NumberOfPeopleInFamily; // Number of People in Family
            NumberOfPeopleInHousehold = model.NumberOfPeopleInHousehold; // Number of People in Household
            PersonId = model.PersonId; // 
            RefCommunicationMethodId = model.RefCommunicationMethodId; // Parent Communication Method
            RefELProgramEligibilityId = model.RefELProgramEligibilityId; // Early Learning Program Eligibility Category
            RefFamilyIncomeSourceId = model.RefFamilyIncomeSourceId; // Source of Family Income
            RefHighestEducationLevelCompletedId = model.RefHighestEducationLevelCompletedId; // Highest Level of Education Completed
            RefIncomeCalculationMethodId = model.RefIncomeCalculationMethodId; // Income Calculation Method
            RefProofOfResidencyTypeId = model.RefProofOfResidencyTypeId; // Proof of Residency Type
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
