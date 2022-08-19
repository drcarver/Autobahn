//**********************************************************
//* DomainName: Common Models
//* FileName:   FinancialAccountViewModel.cs
//* Name:       Financial Account Number
//* Definition: A number given to a financial account within a local source accounting system. The number may be a concatenation of a standard  prefix for the type of account with digits added that have specific meaning within the local system.
//***************************************************************************

using Autobahn.Common.Models;
using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// A number given to a financial account within a local source accounting system. The number may be a concatenation of a standard  prefix for the type of account with digits added that have specific meaning within the local system.
     /// </summary>
    public partial class FinancialAccountViewModel : ViewModelBase, Interfaces.IFinancialAccount
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from FinancialAccount";

        // AccountNumber -- (backing property for Financial Account Number)
        private System.String _AccountNumber;

        // member variable for the FederalProgramCode property
        private System.String _FederalProgramCode;

        // FinancialAccountNumber -- (backing property for Financial Account Number)
        private System.String _FinancialAccountNumber;

        // FinancialExpenditureProjectReportingCode -- (backing property for Financial Expenditure K12 Project Reporting Code)
        private System.Decimal? _FinancialExpenditureProjectReportingCode;

        // Name -- (backing property for Financial Account Name)
        private System.String _Name;

        // RefFinancialAccountBalanceSheetCodeId -- (backing property for Financial Account K12 Balance Sheet Code)
        private Guid? _RefFinancialAccountBalanceSheetCodeId;

        // RefFinancialAccountCategoryId -- (backing property for Financial Account Category)
        private Guid? _RefFinancialAccountCategoryId;

        // RefFinancialAccountFundClassificationId -- (backing property for Financial Account K12 Fund Classification)
        private Guid? _RefFinancialAccountFundClassificationId;

        // RefFinancialAccountProgramCodeId -- (backing property for Financial Account K12 Program Code)
        private Guid? _RefFinancialAccountProgramCodeId;

        // RefFinancialAccountRevenueCodeId -- (backing property for Financial Account K12 Revenue Code)
        private Guid? _RefFinancialAccountRevenueCodeId;

        // RefFinancialExpenditureFunctionCodeId -- (backing property for Financial Expenditure K12 Function Code)
        private Guid? _RefFinancialExpenditureFunctionCodeId;

        // RefFinancialExpenditureLevelOfInstructionCodeId -- (backing property for Financial Expenditure K12 Level of Instruction Code)
        private Guid? _RefFinancialExpenditureLevelOfInstructionCodeId;

        // RefFinancialExpenditureObjectCodeId -- (backing property for Financial Expenditure K12 Object Code)
        private Guid? _RefFinancialExpenditureObjectCodeId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Financial Account Number
        /// <para>
        /// A number given to a financial account within a local source accounting system. The number may be a concatenation of a standard  prefix for the type of account with digits added that have specific meaning within the local system.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20530">Financial Account Number</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.String AccountNumber { get => _AccountNumber; set => SetProperty(ref _AccountNumber, value); }

        public System.String FederalProgramCode { get => _FederalProgramCode; set => SetProperty(ref _FederalProgramCode, value); }

        /// <summary>
        /// Financial Account Number
        /// <para>
        /// A number given to a financial account within a local source accounting system. The number may be a concatenation of a standard  prefix for the type of account with digits added that have specific meaning within the local system.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20530">Financial Account Number</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.String FinancialAccountNumber { get => _FinancialAccountNumber; set => SetProperty(ref _FinancialAccountNumber, value); }

        /// <summary>
        /// Financial Expenditure K12 Project Reporting Code
        /// <para>
        /// The project/reporting code permits school districts to accumulate expenditures to meet a variety of specialized reporting requirements at the local, state, and federal levels. It is a three-digit code with the format 00X.   The first two digits identify the particular funding source, authority, or expenditure purpose for which a special record or report is required. The third digit is available to identify particular projects and the fiscal year of the appropriation within that funding source. Each classification is presented by a code range followed by a description.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20532">Financial Expenditure K12 Project Reporting Code</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.Decimal? FinancialExpenditureProjectReportingCode { get => _FinancialExpenditureProjectReportingCode; set => SetProperty(ref _FinancialExpenditureProjectReportingCode, value); }

        /// <summary>
        /// Financial Account Name
        /// <para>
        /// The name given to the financial account in an educational institution's accounting system.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20315">Financial Account Name</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.String Name { get => _Name; set => SetProperty(ref _Name, value); }

        /// <summary>
        /// Financial Account K12 Balance Sheet Code
        /// <para>
        /// Balance sheet accounts and statement of net position accounts are used to track financial transactions for each fund. Such financial statements only report assets, deferred outflows of resources, liabilities, deferred inflows of resources, and equity accounts and are considered "snapshots" of how these accounts stand as of a certain point in time.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20320">Financial Account K12 Balance Sheet Code</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefFinancialAccountBalanceSheetCodeId { get => _RefFinancialAccountBalanceSheetCodeId; set => SetProperty(ref _RefFinancialAccountBalanceSheetCodeId, value); }

        /// <summary>
        /// Financial Account Category
        /// <para>
        /// A label for a grouping of financial accounts, based on type and purpose.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20312">Financial Account Category</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefFinancialAccountCategoryId { get => _RefFinancialAccountCategoryId; set => SetProperty(ref _RefFinancialAccountCategoryId, value); }

        /// <summary>
        /// Financial Account K12 Fund Classification
        /// <para>
        /// A fund is a separate fiscal and accounting entity with a self-balancing set of accounts recording cash and other financial resources, together with all related liabilities and residual equities or balances or changes therein.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20314">Financial Account K12 Fund Classification</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefFinancialAccountFundClassificationId { get => _RefFinancialAccountFundClassificationId; set => SetProperty(ref _RefFinancialAccountFundClassificationId, value); }

        /// <summary>
        /// Financial Account K12 Program Code
        /// <para>
        /// A program is a plan of activities and procedures designed to accomplish a predetermined objective or set of objectives.  The program classification provides the school district with a framework to classify instructional and other expenditures by program to determine cost.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20316">Financial Account K12 Program Code</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefFinancialAccountProgramCodeId { get => _RefFinancialAccountProgramCodeId; set => SetProperty(ref _RefFinancialAccountProgramCodeId, value); }

        /// <summary>
        /// Financial Account K12 Revenue Code
        /// <para>
        /// These codes are for recording revenue and other receivables by source.  Major revenue categories have codes ending in 00 and are further subdivided.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20440">Financial Account K12 Revenue Code</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefFinancialAccountRevenueCodeId { get => _RefFinancialAccountRevenueCodeId; set => SetProperty(ref _RefFinancialAccountRevenueCodeId, value); }

        /// <summary>
        /// Financial Expenditure K12 Function Code
        /// <para>
        /// The function describes the activity for which a service or material object is acquired. The functions of a school district are classified into five broad areas: instruction, support services, operation of noninstructional services, facilities acquisition and construction, and debt service. Functions are further classified into sub functions.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20321">Financial Expenditure K12 Function Code</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefFinancialExpenditureFunctionCodeId { get => _RefFinancialExpenditureFunctionCodeId; set => SetProperty(ref _RefFinancialExpenditureFunctionCodeId, value); }

        /// <summary>
        /// Financial Expenditure K12 Level of Instruction Code
        /// <para>
        /// This classification permits expenditures to be segregated by instructional level.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20531">Financial Expenditure K12 Level of Instruction Code</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefFinancialExpenditureLevelOfInstructionCodeId { get => _RefFinancialExpenditureLevelOfInstructionCodeId; set => SetProperty(ref _RefFinancialExpenditureLevelOfInstructionCodeId, value); }

        /// <summary>
        /// Financial Expenditure K12 Object Code
        /// <para>
        /// This classification is used to describe the service or commodity obtained as the result of a specific expenditure.  Nine major object categories have codes ending in 00 and are further subdivided.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20322">Financial Expenditure K12 Object Code</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefFinancialExpenditureObjectCodeId { get => _RefFinancialExpenditureObjectCodeId; set => SetProperty(ref _RefFinancialExpenditureObjectCodeId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IFinancialAccount model)
        {
            IsBusy = true;
            Id = model.Id;
            AccountNumber = model.AccountNumber; // Financial Account Number
            FederalProgramCode = model.FederalProgramCode; // 
            FinancialAccountNumber = model.FinancialAccountNumber; // Financial Account Number
            FinancialExpenditureProjectReportingCode = model.FinancialExpenditureProjectReportingCode; // Financial Expenditure K12 Project Reporting Code
            Name = model.Name; // Financial Account Name
            RefFinancialAccountBalanceSheetCodeId = model.RefFinancialAccountBalanceSheetCodeId; // Financial Account K12 Balance Sheet Code
            RefFinancialAccountCategoryId = model.RefFinancialAccountCategoryId; // Financial Account Category
            RefFinancialAccountFundClassificationId = model.RefFinancialAccountFundClassificationId; // Financial Account K12 Fund Classification
            RefFinancialAccountProgramCodeId = model.RefFinancialAccountProgramCodeId; // Financial Account K12 Program Code
            RefFinancialAccountRevenueCodeId = model.RefFinancialAccountRevenueCodeId; // Financial Account K12 Revenue Code
            RefFinancialExpenditureFunctionCodeId = model.RefFinancialExpenditureFunctionCodeId; // Financial Expenditure K12 Function Code
            RefFinancialExpenditureLevelOfInstructionCodeId = model.RefFinancialExpenditureLevelOfInstructionCodeId; // Financial Expenditure K12 Level of Instruction Code
            RefFinancialExpenditureObjectCodeId = model.RefFinancialExpenditureObjectCodeId; // Financial Expenditure K12 Object Code
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }

        #region RefFinancialAccountBalanceSheetCode List
        /// <summary>
        /// The complete Financial Account Number List
        /// </summary>
        private static List<ReferenceModelBase> RefFinancialAccountBalanceSheetCodeList = new List<ReferenceModelBase>
        {
            new ReferenceModelBase { Id=Guid.Parse("94e0891e-229c-4b8a-87b4-e8b13a995a9e"), Code="101", Description="Cash in Bank", Definition="All funds on deposit with a bank or savings and loan institution, normally in non-interest-bearing accounts. Interest-bearing accounts, however, that do not meet the definition of an investment (e.g., demand deposits that are interest-bearing) should be recorded herein as well.", SortOrder=Convert.ToDecimal("1.00") },
            new ReferenceModelBase { Id=Guid.Parse("4da09cd4-152a-4d98-a84e-130477aef5a2"), Code="102", Description="Cash on Hand", Definition="Currency, coins, checks, postal and express money orders, and bankers' drafts on hand.", SortOrder=Convert.ToDecimal("2.00") },
            new ReferenceModelBase { Id=Guid.Parse("1890a02f-effe-42fc-8b58-b07ce422b4d8"), Code="103", Description="Petty Cash", Definition="A sum of money set aside to pay small obligations for which the issuance of a formal voucher and check would be too expensive and time consuming.", SortOrder=Convert.ToDecimal("3.00") },
            new ReferenceModelBase { Id=Guid.Parse("ff73e0a3-f112-43f7-88ec-be46b9f27fa3"), Code="104", Description="Change Cash", Definition="A sum of money set aside to provide change.", SortOrder=Convert.ToDecimal("4.00") },
            new ReferenceModelBase { Id=Guid.Parse("c8fa99fd-323b-4d6f-bb6d-e2d212635dc1"), Code="105", Description="Cash With Fiscal Agents", Definition="Deposits with fiscal agents, such as commercial banks, for paying matured bonds and interest.", SortOrder=Convert.ToDecimal("5.00") },
            new ReferenceModelBase { Id=Guid.Parse("e0214def-f8a8-44c0-9eac-c85b160b2416"), Code="111", Description="Investments", Definition="Securities and real estate held for producing income in the form of interest, dividends, rentals, or lease payments. Investments should be presented at fair value as of the reporting date. Gains from changes in the fair value of investments are recorded using revenue account 1530. Losses from changes in the fair value of investments are recorded using expenditure object code 930. Alternatively, gains and losses may be netted and recorded in revenue account 1530. The account does not include capital assets used in school district operations. Separate accounts may be maintained for each category of investments.", SortOrder=Convert.ToDecimal("6.00") },
            new ReferenceModelBase { Id=Guid.Parse("4bea7a84-6f28-4fbb-b74f-58c6e5c14e81"), Code="112", Description="Unamortized Premiums on Investments", Definition="The excess of the amount paid for securities over the face value that has not yet been amortized. Use of this account is restricted to short- term money market investments.", SortOrder=Convert.ToDecimal("7.00") },
            new ReferenceModelBase { Id=Guid.Parse("bb82166c-47d3-47ec-b887-c5e8a81ef710"), Code="113", Description="Unamortized Discounts on Investments (Credit)", Definition="The excess of the face value of securities over the amount paid for them that has not yet been written off. Use of this account is restricted to short-term investments.", SortOrder=Convert.ToDecimal("8.00") },
            new ReferenceModelBase { Id=Guid.Parse("22fc8b92-b669-46ec-b80b-021faf841035"), Code="114", Description="Interest Receivable on Investments", Definition="The amount of interest receivable on investments, excluding interest purchased. Interest purchased should be shown in a separate account.", SortOrder=Convert.ToDecimal("9.00") },
            new ReferenceModelBase { Id=Guid.Parse("abd81c9e-c430-44af-96a9-ee39385abe0c"), Code="115", Description="Accrued Interest on Investments Purchased", Definition="Interest accrued on investments between the last interest payment date and the date of purchase. The account is carried as an asset until the first interest payment date after the date of purchase.", SortOrder=Convert.ToDecimal("10.00") },
            new ReferenceModelBase { Id=Guid.Parse("556373db-2261-43b3-a066-8180fc1533ca"), Code="121", Description="Taxes Receivable", Definition="The uncollected portion of taxes that a school district or government unit has levied and that has become due, including any interest or penalties that may be accrued. Separate accounts may be maintained on the basis of tax roll year, current and delinquent taxes, or both.", SortOrder=Convert.ToDecimal("11.00") },
            new ReferenceModelBase { Id=Guid.Parse("b26677fb-3038-47ad-a651-ad7ba6b031d9"), Code="122", Description="Allowance for Uncollectible Taxes (Credit)", Definition="The portion of taxes receivable estimated not to be collected. The account is shown on the balance sheet as a deduction from the taxes receivable account to arrive at the net taxes receivable. Separate accounts may be maintained on the basis of tax roll year, delinquent taxes, or both.", SortOrder=Convert.ToDecimal("12.00") },
            new ReferenceModelBase { Id=Guid.Parse("082f900a-6e57-44fc-ac82-a732e3d4c040"), Code="131", Description="Interfund Loans Receivable", Definition="An asset account used to record a loan by one fund to another fund in the same governmental unit. It is recommended that separate accounts be maintained for each interfund receivable loan.", SortOrder=Convert.ToDecimal("13.00") },
            new ReferenceModelBase { Id=Guid.Parse("22e88843-a162-4aeb-a7b1-d490d14e087f"), Code="132", Description="Interfund Accounts Receivable", Definition="An asset account used to indicate amounts owed to a particular fund by another fund in the same school district for goods sold or services rendered. It is recommended that separate accounts be maintained for each interfund receivable.", SortOrder=Convert.ToDecimal("14.00") },
            new ReferenceModelBase { Id=Guid.Parse("5ed64104-d2ad-4b34-8c05-3d721dad57a5"), Code="141", Description="Intergovernmental Accounts Receivable", Definition="Amounts due to the reporting governmental unit from another governmental unit. These amounts may represent grants-in-aid, shared taxes, taxes collected for the reporting unit by another unit, loans, and charges for services rendered by the reporting unit for another government. It is recommended that separate accounts be maintained for each interagency receivable.", SortOrder=Convert.ToDecimal("15.00") },
            new ReferenceModelBase { Id=Guid.Parse("a9ebd821-bba1-4bf0-af4b-2b1dc59559ba"), Code="151", Description="Loans Receivable", Definition="Amounts that have been loaned to persons or organizations, including notes taken as security for such loans, where permitted by statutory authority.", SortOrder=Convert.ToDecimal("16.00") },
            new ReferenceModelBase { Id=Guid.Parse("5671e6d3-56e8-408a-aa5b-5230f417fc2c"), Code="152", Description="Allowance for Uncollectible Loans (Credit)", Definition="The portion of loans receivable estimated not to be collected. The account is shown on the balance sheet as a deduction from the other loans receivable account.", SortOrder=Convert.ToDecimal("17.00") },
            new ReferenceModelBase { Id=Guid.Parse("fd18c7bb-cfe5-41f6-80e4-d0678cb39c40"), Code="153", Description="Other Accounts Receivable", Definition="Amounts due on open account from private persons, firms, or corporations for goods and services furnished by a school district (but not including amounts due from other funds or from other governmental units).", SortOrder=Convert.ToDecimal("18.00") },
            new ReferenceModelBase { Id=Guid.Parse("8e13bb67-de17-4cfc-8e02-7b5829d5987c"), Code="154", Description="Allowance for Uncollectible Accounts Receivable (Credit)", Definition="A provision for that portion of accounts receivable that is estimated will not be collected. The account is shown on the balance sheet as a deduction from the other accounts receivable account.", SortOrder=Convert.ToDecimal("19.00") },
            new ReferenceModelBase { Id=Guid.Parse("b3d23b33-3749-47cd-bf0f-7d56eb7caab1"), Code="171", Description="Inventories for Consumption", Definition="The cost of supplies and equipment on hand not yet distributed to requisitioning units.", SortOrder=Convert.ToDecimal("20.00") },
            new ReferenceModelBase { Id=Guid.Parse("24d81a34-314f-4a6a-a618-82390c7456ff"), Code="172", Description="Inventories for Resale", Definition="The value of goods purchased and held by a school district for resale rather than for use in its own operations. Such goods could include unique manufactured inventories, such as student-built homes or equipment.", SortOrder=Convert.ToDecimal("21.00") },
            new ReferenceModelBase { Id=Guid.Parse("c37ce7bb-80c0-4c7a-9558-0593c7f3aab7"), Code="181", Description="Prepaid Items", Definition="Expenditures/expenses paid for benefits not yet received. Prepaid expenses differ from deferred charges in that they are spread over a shorter period of time and are regularly recurring costs of operation. Examples of prepaid expenses are prepaid rent, prepaid interest, and unexpired insurance premiums.", SortOrder=Convert.ToDecimal("22.00") },
            new ReferenceModelBase { Id=Guid.Parse("86aefaab-067c-4b35-8003-761a8aadf3d1"), Code="191", Description="Deposits", Definition="Funds deposited by the school district as a prerequisite to receiving services, goods, or both.", SortOrder=Convert.ToDecimal("23.00") },
            new ReferenceModelBase { Id=Guid.Parse("e8f5fead-52ea-4ea8-894d-94e63c8fb655"), Code="193", Description="Bond Insurance Costs", Definition="Bond insurance costs that are a form of prepayment to be amortized.", SortOrder=Convert.ToDecimal("24.00") },
            new ReferenceModelBase { Id=Guid.Parse("94e8bbda-5332-4ad3-8987-61e29785363c"), Code="194", Description="Premium and Discount on Issuance of Bonds", Definition="Represents amounts to be amortized as debt premium/discount in connection with the issuance of bonds.", SortOrder=Convert.ToDecimal("25.00") },
            new ReferenceModelBase { Id=Guid.Parse("1e319fd1-e624-4aef-9c80-212aed42567d"), Code="199", Description="Other Current Assets", Definition="Current assets not provided for elsewhere.", SortOrder=Convert.ToDecimal("26.00") },
            new ReferenceModelBase { Id=Guid.Parse("0ef2685a-16ce-4fd6-b38c-41bd802f8fb9"), Code="200", Description="Capital Assets", Definition="Those assets that the school district intends to hold or continue to use over a long period of time. Specifically, capital assets include land, improvements to land, easements, buildings and building improvements, vehicles, machinery, equipment, works of art and historical treasures, infrastructure, and all other tangible or intangible assets that are used in operations and that have initial useful lives that extend beyond a single reporting period. This account is used only in proprietary funds, fiduciary funds, and the government-wide financial statements.", SortOrder=Convert.ToDecimal("27.00") },
            new ReferenceModelBase { Id=Guid.Parse("b32c6ddf-c553-4b06-b65e-fff691ad31d0"), Code="211", Description="Land and Land Improvements", Definition="A capital asset account that reflects the acquisition value of land owned by a school district. If land is purchased, this account includes the purchase price and costs such as legal fees, filling and excavation costs, and other associated improvement costs incurred to put the land in condition for its intended use. If land is acquired by gift, the account reflects its fair value at the time of acquisition. Permanent improvements to land, such as grading and fill, should also be accounted for in this account. Land and land improvements are considered nonexhaustible assets owing to their significantly long expected useful life. Nonexhaustible assets are not to be depreciated. Therefore, assets classified by asset code 211 should result in no depreciation expense.", SortOrder=Convert.ToDecimal("28.00") },
            new ReferenceModelBase { Id=Guid.Parse("09165c24-1f4a-4f06-88e6-090e2d8f48f0"), Code="221", Description="Site Improvements", Definition="A capital asset account that reflects the value of nonpermanent improvements to building sites, other than buildings, that add value to land. Examples of such improvements are fences, retaining walls, sidewalks, pavements, gutters, tunnels, and bridges. If the improvements are purchased or constructed, this account contains the purchase or contract price. If improvements are obtained by gift, it reflects the fair value at the time of acquisition. Site improvements are improvements that have a limited useful life. Because these improvements decrease in their value/usefulness over time, it is appropriate to depreciate these assets. Therefore, all capitalized site improvements should be depreciated over their expected useful life.", SortOrder=Convert.ToDecimal("29.00") },
            new ReferenceModelBase { Id=Guid.Parse("86d3581a-fc53-4086-82e6-187c8ca62eaa"), Code="222", Description="Accumulated Depreciation on Site Improvements", Definition="Accumulated amounts for the depreciation of land improvements.", SortOrder=Convert.ToDecimal("30.00") },
            new ReferenceModelBase { Id=Guid.Parse("38115474-7246-4e20-a52d-584beee25f3c"), Code="231", Description="Buildings and Building Improvements", Definition="A capital asset account that reflects the acquisition value of permanent structures used to house persons and property owned by the school district. If buildings are purchased or constructed, this account includes the purchase or contract price of all permanent buildings and the fixtures attached to and forming a permanent part of such buildings. This account includes all building improvements, including upgrades made to building wiring for technology. If buildings are acquired by gift, the account reflects their fair value at the time of acquisition.", SortOrder=Convert.ToDecimal("31.00") },
            new ReferenceModelBase { Id=Guid.Parse("cd10d1c4-8d22-484c-8c3b-01254f6cfa8c"), Code="232", Description="Accumulated Depreciation on Buildings and Building Improvements", Definition="Accumulated amounts for the depreciation of buildings and building improvements.", SortOrder=Convert.ToDecimal("32.00") },
            new ReferenceModelBase { Id=Guid.Parse("cbf4d644-b7db-4bda-ad33-f473a6afde9a"), Code="241", Description="Machinery and Equipment", Definition="Tangible property of a more or less permanent nature, other than land, buildings, or improvements thereto, that is useful in carrying on operations. Examples are machinery, tools, trucks, cars, buses, computers, purchased software, furniture, and furnishings. Appendix E provides criteria to distinguish whether a purchase is a supply or a piece of machinery or equipment.", SortOrder=Convert.ToDecimal("33.00") },
            new ReferenceModelBase { Id=Guid.Parse("9342b93f-e04d-4ae0-878a-409fe2cca7bd"), Code="242", Description="Accumulated Depreciation on Machinery and Equipment", Definition="Accumulated amounts for the depreciation of machinery and equipment.", SortOrder=Convert.ToDecimal("34.00") },
            new ReferenceModelBase { Id=Guid.Parse("fdefb20b-1ec3-4436-a983-2310e5240e0c"), Code="251", Description="Works of Art and Historical Treasures", Definition="Individual items or collections of items that are of artistic or cultural importance.", SortOrder=Convert.ToDecimal("35.00") },
            new ReferenceModelBase { Id=Guid.Parse("3f74f14d-19e6-4787-a421-d44578f05ecd"), Code="252", Description="Accumulated Depreciation on Works of Art and Historical Collections", Definition="Accumulated amounts for the depreciation (as applicable) of works of art and historical treasures.", SortOrder=Convert.ToDecimal("36.00") },
            new ReferenceModelBase { Id=Guid.Parse("3497db4d-38ca-4f53-ab6e-4c483cf5fe0e"), Code="261", Description="Infrastructure", Definition="A capital asset, network, or subsystem that has a useful life that is significantly longer than those of other capital assets. These assets may include water/sewer systems, roads, bridges, tunnels, and other similar assets.", SortOrder=Convert.ToDecimal("37.00") },
            new ReferenceModelBase { Id=Guid.Parse("85d97d8b-0fae-40ae-bea4-845f8a6e0157"), Code="262", Description="Accumulated Depreciation on Infrastructure", Definition="Accumulated amounts for the depreciation of infrastructure assets.", SortOrder=Convert.ToDecimal("38.00") },
            new ReferenceModelBase { Id=Guid.Parse("b91faa38-19d8-4d95-a872-4d8116fff0a9"), Code="271", Description="Construction in Progress", Definition="The cost of construction work undertaken but not yet completed.", SortOrder=Convert.ToDecimal("39.00") },
            new ReferenceModelBase { Id=Guid.Parse("70912859-0f3d-447e-ae57-2db1f640d431"), Code="281", Description="Intangible Assets", Definition="An intangible asset is a capital asset that lacks physical substance, is nonfinancial in nature, and has an initial useful life of more than 1 year. Intangible assets may be purchased or licensed, acquired through nonexchange transactions, or internally generated. Examples include easements, contractual rights, patents, trademarks, and computer software.", SortOrder=Convert.ToDecimal("40.00") },
            new ReferenceModelBase { Id=Guid.Parse("034e575b-5071-4289-82b6-8d2effa191c9"), Code="282", Description="Accumulated Amortization of Intangible Assets", Definition="Accumulated amounts for the amortization of intangible assets.", SortOrder=Convert.ToDecimal("41.00") },
            new ReferenceModelBase { Id=Guid.Parse("3f5ffce2-358d-417f-baae-442e2cd9465d"), Code="300", Description="Deferred Outflows of Resources", Definition="A consumption of net assets by the government that is applicable to a future reporting period.", SortOrder=Convert.ToDecimal("42.00") },
            new ReferenceModelBase { Id=Guid.Parse("5d809987-45ff-4858-998e-472b41c60e11"), Code="401", Description="Interfund Loans Payable", Definition="A liability account used to record a debt owed by one fund to another fund in the same governmental unit. It is recommended that separate accounts be maintained for each interfund loan.", SortOrder=Convert.ToDecimal("43.00") },
            new ReferenceModelBase { Id=Guid.Parse("5d64952b-9949-4af5-afa2-b5de31d25e2f"), Code="402", Description="Interfund Accounts Payable", Definition="A liability account used to indicate amounts owed by a particular fund for services rendered. It is recommended that separate accounts be maintained for each interfund payable.", SortOrder=Convert.ToDecimal("44.00") },
            new ReferenceModelBase { Id=Guid.Parse("10137c93-fc47-45a9-a2e7-66345a98659e"), Code="411", Description="Intergovernmental Accounts Payable", Definition="Amounts owed by the reporting school district to another governmental unit. It is recommended that separate accounts be maintained for each intergovernmental payable.", SortOrder=Convert.ToDecimal("45.00") },
            new ReferenceModelBase { Id=Guid.Parse("eefb4853-e32a-439b-8f38-468a943d9412"), Code="421", Description="Accounts Payable", Definition="Liabilities on open account owed to private persons, firms, or corporations for goods and services received by a school district (but not including amounts due to other funds of the same school district or to other governmental units).", SortOrder=Convert.ToDecimal("46.00") },
            new ReferenceModelBase { Id=Guid.Parse("d7a16e92-ea59-4c5b-8648-89672651a920"), Code="422", Description="Judgments Payable", Definition="Amounts due to be paid by a school district as the result of court decisions, including condemnation awards paid for private property taken for public use.", SortOrder=Convert.ToDecimal("47.00") },
            new ReferenceModelBase { Id=Guid.Parse("4813ec30-809d-459a-ba7f-caa2df195318"), Code="423", Description="Warrants Payable", Definition="Amounts due to designated payees in the form of a written order drawn by the school district directing the school district treasurer to pay a specific amount.", SortOrder=Convert.ToDecimal("48.00") },
            new ReferenceModelBase { Id=Guid.Parse("4909ceac-fa2a-4b0e-b988-c613d2a1c92d"), Code="431", Description="Contracts Payable", Definition="Amounts due on contracts for assets, goods, and services received by a school district.", SortOrder=Convert.ToDecimal("49.00") },
            new ReferenceModelBase { Id=Guid.Parse("2dc647b0-9c83-4df8-a737-6fadaa817d8c"), Code="432", Description="Construction Contracts Payable-Retainage", Definition="Liabilities on account of construction contracts for that portion of the work that has been completed but on which part the liability has not been paid pending final inspection, the lapse of a specified time period, or both. The unpaid amount is usually a stated percentage of the contract price.", SortOrder=Convert.ToDecimal("50.00") },
            new ReferenceModelBase { Id=Guid.Parse("82932361-a27f-45f1-92d5-41ca99c3f735"), Code="433", Description="Construction Contracts Payable", Definition="Amounts due by a school district on contracts for constructing buildings and other structures and other improvements.", SortOrder=Convert.ToDecimal("51.00") },
            new ReferenceModelBase { Id=Guid.Parse("c5fbdefc-0f7d-4763-b89d-95835bc875e1"), Code="441", Description="Matured Bonds Payable", Definition="Bonds that have reached or passed their maturity date but that remain unpaid.", SortOrder=Convert.ToDecimal("52.00") },
            new ReferenceModelBase { Id=Guid.Parse("f7ece50f-9e6b-4247-aafe-e00fb353558f"), Code="442", Description="Bonds Payable-Current", Definition="Bonds that have not reached or passed their maturity date but are due within 1 year or less. This account is used only in proprietary or fiduciary funds, as well as in the government-wide financial statements.", SortOrder=Convert.ToDecimal("53.00") },
            new ReferenceModelBase { Id=Guid.Parse("b7b680d4-c78c-4d66-ac3a-f58d0963e3f6"), Code="443", Description="Unamortized Premiums on Issuance of Bonds", Definition="An account that represents that portion of the excess of bond proceeds over par value and that remains to be amortized over the remaining life of such bonds. This account is used only in proprietary or fiduciary funds, as well as in the government-wide financial statements.", SortOrder=Convert.ToDecimal("54.00") },
            new ReferenceModelBase { Id=Guid.Parse("865af494-fd1f-4f70-8f41-b3aeef94aacb"), Code="451", Description="Loans Payable", Definition="Short-term obligations representing amounts borrowed for short periods of time, usually evidenced by notes payable or warrants payable.", SortOrder=Convert.ToDecimal("55.00") },
            new ReferenceModelBase { Id=Guid.Parse("8ca69c4a-9d56-43f8-a74b-9a332ee22d95"), Code="452", Description="Lease Obligations-Current", Definition="Capital lease obligations that are due within 1 year.", SortOrder=Convert.ToDecimal("56.00") },
            new ReferenceModelBase { Id=Guid.Parse("37a43ab8-34d9-4ac4-89cf-47acb70c54be"), Code="455", Description="Interest Payable", Definition="Interest due within 1 year.", SortOrder=Convert.ToDecimal("57.00") },
            new ReferenceModelBase { Id=Guid.Parse("52537be5-867d-4e0d-9138-115731865434"), Code="461", Description="Accrued Salaries and Benefits", Definition="Salary and fringe benefit costs incurred during the current accounting period that are not payable until a subsequent accounting period.", SortOrder=Convert.ToDecimal("58.00") },
            new ReferenceModelBase { Id=Guid.Parse("b6b2f1ce-1b76-4b53-8bbd-8739d4e00316"), Code="471", Description="Payroll Deductions and Withholdings", Definition="Amounts deducted from employees' salaries for withholding taxes and other purposes. District-paid benefits amounts payable are also included. A separate liability account may be used for each type of benefit.", SortOrder=Convert.ToDecimal("59.00") },
            new ReferenceModelBase { Id=Guid.Parse("1b33f5b2-af26-44b1-81f9-d97a4716c56e"), Code="472", Description="Compensated Absences-Current", Definition="Compensated absences that will be paid within 1 year.", SortOrder=Convert.ToDecimal("60.00") },
            new ReferenceModelBase { Id=Guid.Parse("970aa4c9-4cc6-41d8-95f3-17bef45c224e"), Code="473", Description="Accrued Annual Requirement Contribution Liability", Definition="A liability arising from payments not made to pension funds. This amount represents any difference between the actuarially determined annual required contribution and actual payments made to the pension fund.", SortOrder=Convert.ToDecimal("61.00") },
            new ReferenceModelBase { Id=Guid.Parse("64d1c9df-1c9c-4593-b8f4-3e88b1028b4d"), Code="481", Description="Advances from Grantors", Definition="A liability account that represents resources received from grantors before eligibility requirements are met.", SortOrder=Convert.ToDecimal("62.00") },
            new ReferenceModelBase { Id=Guid.Parse("4f6ffd58-3c1c-43ba-87cf-b0e2c17bcc0d"), Code="491", Description="Deposits Payable", Definition="Liability for deposits received as a prerequisite to providing or receiving services, goods, or both.", SortOrder=Convert.ToDecimal("63.00") },
            new ReferenceModelBase { Id=Guid.Parse("7fba9643-bd52-4725-9feb-57fe4fd6d2cd"), Code="499", Description="Other Current Liabilities", Definition="Other current liabilities not provided for elsewhere.", SortOrder=Convert.ToDecimal("64.00") },
            new ReferenceModelBase { Id=Guid.Parse("fa859a80-e688-4dce-a219-ed812481654a"), Code="500", Description="Long-Term Liabilities", Definition="Obligations with a maturity of more than 1 year. These accounts should be used only with proprietary and fiduciary funds, as well as at the entity-wide level of reporting.", SortOrder=Convert.ToDecimal("65.00") },
            new ReferenceModelBase { Id=Guid.Parse("fd781dea-82f7-427d-acaa-882defd4ec3a"), Code="511", Description="Bonds Payable", Definition="Bonds (general obligation, asset-backed, or revenue-backed) that have not reached or passed their maturity date and that are not due within 1 year.", SortOrder=Convert.ToDecimal("66.00") },
            new ReferenceModelBase { Id=Guid.Parse("2f784935-97bb-470f-a1d3-bc32f6bea5ba"), Code="512", Description="Accreted Interest", Definition="An account that represents interest that is accrued on deep discount bonds. This account should be used by school districts that issue capital appreciation bonds. Such bonds are usually issued at a deep discount from the face value, and no interest payment is made until maturity. Under full accrual accounting, the district is required to accrete the interest on the bonds over the life of the bonds. Accretion is the process of systematically increasing the carrying amount of the bond to its estimated value at the maturity date of the bond. To calculate accreted interest, the district should impute the effective interest rate, using the present value, the face value (or the future value), and the period of the bond, and multiply the effective interest rate by the book value of the debt at the end of the period. Accreted interest is usually recorded as an addition to the outstanding debt liability.", SortOrder=Convert.ToDecimal("67.00") },
            new ReferenceModelBase { Id=Guid.Parse("5e894948-9f21-4903-ad28-a6181fa04a64"), Code="513", Description="Unamortized Gains/Losses on Debt Refundings", Definition="An account that represents the difference between the reacquisition price and the net carrying amount of old debt when a current or advance refunding of debt occurs. This account should be used only when defeasance of debt occurs for proprietary funds and entity-wide statements. The unamortized loss amount should be reported as a deferred outflow of resources and amortized as a component of interest expense in a systematic and rational manner over the remaining life of the old debt or the life of the new debt, whichever is shorter. The unamortized gain amount should be reported as a deferred inflow of resources and amortized as a component of interest expense in a systematic and rational manner over the remaining life of the old debt or the life of the new debt, whichever is shorter.", SortOrder=Convert.ToDecimal("68.00") },
            new ReferenceModelBase { Id=Guid.Parse("59cd8da6-23e5-4e6e-9aa3-548bf1351238"), Code="521", Description="Loans Payable", Definition="An unconditional written promise signed by the maker to pay a certain sum of money 1 year or more after the issuance date.", SortOrder=Convert.ToDecimal("69.00") },
            new ReferenceModelBase { Id=Guid.Parse("cbb11caf-98c1-44f8-8b00-ce33bb455579"), Code="531", Description="Capital Lease Obligations", Definition="Amounts remaining to be paid on capital lease agreements.", SortOrder=Convert.ToDecimal("70.00") },
            new ReferenceModelBase { Id=Guid.Parse("39f42a62-5586-44df-bd59-67e4118b6354"), Code="551", Description="Compensated Absences", Definition="Amounts remaining beyond the period of 1 year to be paid on compensated absences balances.", SortOrder=Convert.ToDecimal("71.00") },
            new ReferenceModelBase { Id=Guid.Parse("4a30c4c0-f146-40fb-81fd-b3d3bbba714f"), Code="553", Description="Special Termination Benefits", Definition="These are benefits offered for a short period of time to employees in connection with their termination of employment. Special termination benefits are often used as an inducement for early retirement or to address budgetary problems.", SortOrder=Convert.ToDecimal("72.00") },
            new ReferenceModelBase { Id=Guid.Parse("50cb3bda-423f-456c-b561-26e254b95cf1"), Code="561", Description="Arbitrage Rebate Liability", Definition="Liabilities arising from arbitrage rebates to the Internal Revenue Service (IRS) from bond financing.", SortOrder=Convert.ToDecimal("73.00") },
            new ReferenceModelBase { Id=Guid.Parse("306c25ca-5f36-4283-a7bf-3013343eb05b"), Code="590", Description="Other Long-Term Liabilities", Definition="Other long-term liabilities not provided for elsewhere. This account represents amounts due after more than 1 year from the balance sheet date for advances from other funds and certain miscellaneous liabilities, including workers' compensation, self-funded insurance, special termination benefits, and legal claims and judgments.", SortOrder=Convert.ToDecimal("74.00") },
            new ReferenceModelBase { Id=Guid.Parse("8d63f598-d802-408e-aeef-38712bf5d173"), Code="600", Description="Deferred Inflows of Resources", Definition="An acquisition of net assets by the government that is applicable to a future reporting period. A deferred inflow of resources should be recognized when resources are received or recognized as a receivable before (a) the period for which property taxes are levied or (b) the period when the resources are required to be used. When an asset is recorded in governmental fund financial statements but the revenue is not available, the government should report a deferred inflow of resources until such time as the revenue becomes available.", SortOrder=Convert.ToDecimal("75.00") },
            new ReferenceModelBase { Id=Guid.Parse("16923eb6-3141-4894-9dd5-f1f776296433"), Code="710", Description="Nonspendable Fund Balance", Definition="The nonspendable fund balance classification includes amounts that cannot be spent because they are either (a) not in spendable form or (b) legally or contractually required to be maintained intact. This would include items not expected to be converted to cash, including inventories and prepaid amounts. It may also include the long-term amount of loans and receivables, as well as property acquired for resale and the corpus (principal) of a permanent fund.", SortOrder=Convert.ToDecimal("76.00") },
            new ReferenceModelBase { Id=Guid.Parse("20fbfed4-d091-4a19-8edb-f4945ec8490a"), Code="720", Description="Restricted Fund Balance", Definition="The restricted fund balance classification should be reported when legally enforceable constraints placed on the use of resources are either (a) externally imposed by creditors, grantors, contributors, or laws or regulations of other governments or (b) imposed by law through constitutional provisions or enabling legislation.", SortOrder=Convert.ToDecimal("77.00") },
            new ReferenceModelBase { Id=Guid.Parse("acd0fe1d-7652-429f-a14c-07ee00060d43"), Code="730", Description="Committed Fund Balance", Definition="The committed fund balance classification reflects specific purposes pursuant to constraints imposed by formal action at the district's highest level of decisionmaking authority (generally the governing board). Such constraints can only be removed or changed by the same form of formal action.", SortOrder=Convert.ToDecimal("78.00") },
            new ReferenceModelBase { Id=Guid.Parse("287df6e3-3dd3-4197-b62b-e637afbe7e8b"), Code="740", Description="Assigned Fund Balance", Definition="The assigned fund balance classification reflects amounts that are constrained by the government's intent to be used for specific purposes, but meet neither the restricted nor committed forms of constraint. Also, the assigned fund balance classification is the residual classification for the special revenue, debt service, capital projects, and/or permanent funds after nonspendable, restricted, and committed balances have been identified (unless the residual amount is negative, which would require presentation as unassigned fund balance).", SortOrder=Convert.ToDecimal("79.00") },
            new ReferenceModelBase { Id=Guid.Parse("ae8ce1cd-1312-43c7-b86c-bcb623737f28"), Code="750", Description="Unassigned Fund Balance", Definition="The unassigned fund balance classification is the residual classification, for the general fund only, after nonspendable, restricted, committed, and assigned balances have been identified. It is also used to report the residual amount for all other governmental funds after nonspendable, restricted, and committed balances have been identified, if the residual amount is negative.", SortOrder=Convert.ToDecimal("80.00") },
            new ReferenceModelBase { Id=Guid.Parse("747b471e-3164-4b5f-a31b-92cebef7e19d"), Code="760", Description="Net Investment in Capital Assets", Definition="This account is used to record the component of net position invested in capital assets, net of related debt, that represents total capital assets less accumulated depreciation less debt directly related to capital assets. This account is to be used only in proprietary funds and entity-wide statements. (This was previously fund balance code 740.)", SortOrder=Convert.ToDecimal("81.00") },
            new ReferenceModelBase { Id=Guid.Parse("9328dbf8-b5a2-4fa5-95ef-b2664ccd9524"), Code="770", Description="Restricted Net Position", Definition="This account is used to record the component of net position that represents net assets legally restricted by sources internal or external to the organization. This account is to be used only in proprietary funds and entity-wide statements. (This was previously fund balance code 750.)", SortOrder=Convert.ToDecimal("82.00") },
            new ReferenceModelBase { Id=Guid.Parse("010d780a-acc4-44cf-bb95-e4fc71324abf"), Code="780", Description="Unrestricted Net Position", Definition="This account is used to record the component of net position that represents net position not classified in accounts 760 and 770. This account is to be used only in proprietary funds and entity-wide statements. (This was previously fund balance code 760.)", SortOrder=Convert.ToDecimal("83.00") },
        };
        #endregion
    }
}
