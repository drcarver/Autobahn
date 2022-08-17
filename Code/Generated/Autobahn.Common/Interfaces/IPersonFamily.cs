//***************************************************************************
//* DomainName: Common Models Interfaces (used by both models and View Models
//* FileName:   IPersonFamily.cs
//***************************************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IPersonFamily Interface
     /// </summary>
    public partial interface IPersonFamily : IAutobahnBase
    {
        /// <summary>
        /// Family Identifier
        /// <para>
        /// A unique number or alphanumeric code assigned to a family by a school, school system, a state, or other agency or entity.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19784">Family Identifier</a>
        /// </para>
        /// </summary>
        System.String FamilyIdentifier { get; set; }

        /// <summary>
        /// Family Income
        /// <para>
        /// Total income of family from all sources. Income includes money, wages or salary before deductions; net income from non-farm self-employment; net income from farm self-employment; regular payments from Social Security or railroad retirement; payments from unemployment compensation, strike benefits from union funds, workers' compensation, veterans benefits (with the exception noted below), public assistance (including Temporary Assistance for Needy Families, Supplemental Security Income, Emergency Assistance money payments, and non-Federally funded General Assistance or General Relief money payments); training stipends; alimony, child support, and military family allotments or other regular support from an absent family member or someone not living in the household; private pensions, government employee pensions (including military retirement pay), and regular insurance or annuity payments; college or university scholarships, grants, fellowships, and assistantships; and dividends, interest, net rental income, net royalties, and periodic receipts from estates or trusts; and net gambling or lottery winnings.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19331">Family Income</a>
        /// </para>
        /// </summary>
        System.Decimal? FamilyIncome { get; set; }

        /// <summary>
        /// Included in Counted Family Size
        /// <para>
        /// Denotes whether this family member is counted in the family size as it pertains to the federal poverty level
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20591">Included in Counted Family Size</a>
        /// </para>
        /// </summary>
        System.Boolean? IncludedInCountedFamilySize { get; set; }

        /// <summary>
        /// Number of Household College Students
        /// <para>
        /// Number of people, including the student, who will attend at least half-time in the current academic year, a program that leads to a college degree or certificate
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20950">Number of Household College Students</a>
        /// </para>
        /// </summary>
        System.Int32? NumberOfHouseholdCollegeStudents { get; set; }

        /// <summary>
        /// Number of People in Family
        /// <para>
        /// Total number of persons in immediate family. Family means for the purposes of the regulations in this part all persons: (i) Living in the same household who are: (A) Supported by the income of the parent(s) or guardian(s) of the child enrolling or participating in the program; or (B) Related to the child by blood, marriage, or adoption; or &#x0D;
        /// </para>
        /// </summary>
        System.Int32? NumberOfPeopleInFamily { get; set; }

        /// <summary>
        /// Number of People in Household
        /// <para>
        /// Total number of persons residing in the same household.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19330">Number of People in Household</a>
        /// </para>
        /// </summary>
        System.Int32? NumberOfPeopleInHousehold { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IPerson"/> model
        /// </summary>
        Guid PersonId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefCommunicationMethod"/> model
        /// </summary>
        Guid? RefCommunicationMethodId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefELProgramEligibility"/> model
        /// </summary>
        Guid? RefELProgramEligibilityId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefFamilyIncomeSource"/> model
        /// </summary>
        Guid? RefFamilyIncomeSourceId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefHighestEducationLevelCompleted"/> model
        /// </summary>
        Guid? RefHighestEducationLevelCompletedId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefIncomeCalculationMethod"/> model
        /// </summary>
        Guid? RefIncomeCalculationMethodId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefProofOfResidencyType"/> model
        /// </summary>
        Guid? RefProofOfResidencyTypeId { get; set; }

    }
}
