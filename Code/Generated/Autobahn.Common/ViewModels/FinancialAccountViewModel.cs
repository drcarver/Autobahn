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
            new ReferenceModelBase { Id=Guid.Parse("59f4cacf-111e-497d-9de6-8b5a9d0721fe"), Code="101", Description="Cash in Bank", Definition="All funds on deposit with a bank or savings and loan institution, normally in non-interest-bearing accounts. Interest-bearing accounts, however, that do not meet the definition of an investment (e.g., demand deposits that are interest-bearing) should be recorded herein as well.", SortOrder=Convert.ToDecimal("1.00") },
            new ReferenceModelBase { Id=Guid.Parse("66fd01e2-f46f-45b1-b959-1d4237827506"), Code="102", Description="Cash on Hand", Definition="Currency, coins, checks, postal and express money orders, and bankers' drafts on hand.", SortOrder=Convert.ToDecimal("2.00") },
            new ReferenceModelBase { Id=Guid.Parse("574fd29d-c3ce-4838-9ae0-50ad0fe0ebba"), Code="103", Description="Petty Cash", Definition="A sum of money set aside to pay small obligations for which the issuance of a formal voucher and check would be too expensive and time consuming.", SortOrder=Convert.ToDecimal("3.00") },
            new ReferenceModelBase { Id=Guid.Parse("fbb3b779-7637-474f-8812-70f0f5182e2f"), Code="104", Description="Change Cash", Definition="A sum of money set aside to provide change.", SortOrder=Convert.ToDecimal("4.00") },
            new ReferenceModelBase { Id=Guid.Parse("06765a0a-5986-40ab-939e-4e75b6d3bb98"), Code="105", Description="Cash With Fiscal Agents", Definition="Deposits with fiscal agents, such as commercial banks, for paying matured bonds and interest.", SortOrder=Convert.ToDecimal("5.00") },
            new ReferenceModelBase { Id=Guid.Parse("13d8e016-9553-4f60-b580-93b39977976f"), Code="111", Description="Investments", Definition="Securities and real estate held for producing income in the form of interest, dividends, rentals, or lease payments. Investments should be presented at fair value as of the reporting date. Gains from changes in the fair value of investments are recorded using revenue account 1530. Losses from changes in the fair value of investments are recorded using expenditure object code 930. Alternatively, gains and losses may be netted and recorded in revenue account 1530. The account does not include capital assets used in school district operations. Separate accounts may be maintained for each category of investments.", SortOrder=Convert.ToDecimal("6.00") },
            new ReferenceModelBase { Id=Guid.Parse("e796593a-0d5e-49d6-a1ce-0c48bc976a83"), Code="112", Description="Unamortized Premiums on Investments", Definition="The excess of the amount paid for securities over the face value that has not yet been amortized. Use of this account is restricted to short- term money market investments.", SortOrder=Convert.ToDecimal("7.00") },
            new ReferenceModelBase { Id=Guid.Parse("f3257b5a-595f-4a5c-8d65-e000dfc1f740"), Code="113", Description="Unamortized Discounts on Investments (Credit)", Definition="The excess of the face value of securities over the amount paid for them that has not yet been written off. Use of this account is restricted to short-term investments.", SortOrder=Convert.ToDecimal("8.00") },
            new ReferenceModelBase { Id=Guid.Parse("dfc14c2d-bd1f-46d6-9daf-808178357876"), Code="114", Description="Interest Receivable on Investments", Definition="The amount of interest receivable on investments, excluding interest purchased. Interest purchased should be shown in a separate account.", SortOrder=Convert.ToDecimal("9.00") },
            new ReferenceModelBase { Id=Guid.Parse("458e8916-6171-4df5-be37-dc8f3f482ff9"), Code="115", Description="Accrued Interest on Investments Purchased", Definition="Interest accrued on investments between the last interest payment date and the date of purchase. The account is carried as an asset until the first interest payment date after the date of purchase.", SortOrder=Convert.ToDecimal("10.00") },
            new ReferenceModelBase { Id=Guid.Parse("74ffa7c5-1cb9-4ca9-87f5-6243e098f898"), Code="121", Description="Taxes Receivable", Definition="The uncollected portion of taxes that a school district or government unit has levied and that has become due, including any interest or penalties that may be accrued. Separate accounts may be maintained on the basis of tax roll year, current and delinquent taxes, or both.", SortOrder=Convert.ToDecimal("11.00") },
            new ReferenceModelBase { Id=Guid.Parse("16fcacc6-a8ac-4d1c-b8b0-e0a4f1a5053e"), Code="122", Description="Allowance for Uncollectible Taxes (Credit)", Definition="The portion of taxes receivable estimated not to be collected. The account is shown on the balance sheet as a deduction from the taxes receivable account to arrive at the net taxes receivable. Separate accounts may be maintained on the basis of tax roll year, delinquent taxes, or both.", SortOrder=Convert.ToDecimal("12.00") },
            new ReferenceModelBase { Id=Guid.Parse("69c918b7-93df-44f8-bf5c-72fb3f3a0707"), Code="131", Description="Interfund Loans Receivable", Definition="An asset account used to record a loan by one fund to another fund in the same governmental unit. It is recommended that separate accounts be maintained for each interfund receivable loan.", SortOrder=Convert.ToDecimal("13.00") },
            new ReferenceModelBase { Id=Guid.Parse("a1f78a69-8f5d-47c9-8243-1b8cf6af2d00"), Code="132", Description="Interfund Accounts Receivable", Definition="An asset account used to indicate amounts owed to a particular fund by another fund in the same school district for goods sold or services rendered. It is recommended that separate accounts be maintained for each interfund receivable.", SortOrder=Convert.ToDecimal("14.00") },
            new ReferenceModelBase { Id=Guid.Parse("0386ee02-c69d-47cc-a170-7bc421497a9b"), Code="141", Description="Intergovernmental Accounts Receivable", Definition="Amounts due to the reporting governmental unit from another governmental unit. These amounts may represent grants-in-aid, shared taxes, taxes collected for the reporting unit by another unit, loans, and charges for services rendered by the reporting unit for another government. It is recommended that separate accounts be maintained for each interagency receivable.", SortOrder=Convert.ToDecimal("15.00") },
            new ReferenceModelBase { Id=Guid.Parse("966ccea1-f1f6-4283-a816-5c31d10e483b"), Code="151", Description="Loans Receivable", Definition="Amounts that have been loaned to persons or organizations, including notes taken as security for such loans, where permitted by statutory authority.", SortOrder=Convert.ToDecimal("16.00") },
            new ReferenceModelBase { Id=Guid.Parse("8f982d24-365e-4b4f-a4c6-69ff24afd464"), Code="152", Description="Allowance for Uncollectible Loans (Credit)", Definition="The portion of loans receivable estimated not to be collected. The account is shown on the balance sheet as a deduction from the other loans receivable account.", SortOrder=Convert.ToDecimal("17.00") },
            new ReferenceModelBase { Id=Guid.Parse("f8df95f4-92d7-4cae-9538-4b48312324a6"), Code="153", Description="Other Accounts Receivable", Definition="Amounts due on open account from private persons, firms, or corporations for goods and services furnished by a school district (but not including amounts due from other funds or from other governmental units).", SortOrder=Convert.ToDecimal("18.00") },
            new ReferenceModelBase { Id=Guid.Parse("b29c3598-641f-4bb3-ab0e-f6f267840fd1"), Code="154", Description="Allowance for Uncollectible Accounts Receivable (Credit)", Definition="A provision for that portion of accounts receivable that is estimated will not be collected. The account is shown on the balance sheet as a deduction from the other accounts receivable account.", SortOrder=Convert.ToDecimal("19.00") },
            new ReferenceModelBase { Id=Guid.Parse("69026bd4-b44d-47e9-86dc-9fe98a7eed30"), Code="171", Description="Inventories for Consumption", Definition="The cost of supplies and equipment on hand not yet distributed to requisitioning units.", SortOrder=Convert.ToDecimal("20.00") },
            new ReferenceModelBase { Id=Guid.Parse("3b1ea9e4-ebe2-4184-b2e2-20de8557771e"), Code="172", Description="Inventories for Resale", Definition="The value of goods purchased and held by a school district for resale rather than for use in its own operations. Such goods could include unique manufactured inventories, such as student-built homes or equipment.", SortOrder=Convert.ToDecimal("21.00") },
            new ReferenceModelBase { Id=Guid.Parse("648b9dcb-eacd-419b-b503-9292ba5aec4e"), Code="181", Description="Prepaid Items", Definition="Expenditures/expenses paid for benefits not yet received. Prepaid expenses differ from deferred charges in that they are spread over a shorter period of time and are regularly recurring costs of operation. Examples of prepaid expenses are prepaid rent, prepaid interest, and unexpired insurance premiums.", SortOrder=Convert.ToDecimal("22.00") },
            new ReferenceModelBase { Id=Guid.Parse("78388b1a-681d-48c9-9068-e45a5f206f19"), Code="191", Description="Deposits", Definition="Funds deposited by the school district as a prerequisite to receiving services, goods, or both.", SortOrder=Convert.ToDecimal("23.00") },
            new ReferenceModelBase { Id=Guid.Parse("abb6994f-97bd-479d-a83a-635043eff968"), Code="193", Description="Bond Insurance Costs", Definition="Bond insurance costs that are a form of prepayment to be amortized.", SortOrder=Convert.ToDecimal("24.00") },
            new ReferenceModelBase { Id=Guid.Parse("4b9d3964-4236-4fe0-a512-958031a9a61c"), Code="194", Description="Premium and Discount on Issuance of Bonds", Definition="Represents amounts to be amortized as debt premium/discount in connection with the issuance of bonds.", SortOrder=Convert.ToDecimal("25.00") },
            new ReferenceModelBase { Id=Guid.Parse("91399556-59c3-4064-85c9-8828bccd07b6"), Code="199", Description="Other Current Assets", Definition="Current assets not provided for elsewhere.", SortOrder=Convert.ToDecimal("26.00") },
            new ReferenceModelBase { Id=Guid.Parse("eb2c5d37-15cd-47c8-a843-0c038f8a8a1c"), Code="200", Description="Capital Assets", Definition="Those assets that the school district intends to hold or continue to use over a long period of time. Specifically, capital assets include land, improvements to land, easements, buildings and building improvements, vehicles, machinery, equipment, works of art and historical treasures, infrastructure, and all other tangible or intangible assets that are used in operations and that have initial useful lives that extend beyond a single reporting period. This account is used only in proprietary funds, fiduciary funds, and the government-wide financial statements.", SortOrder=Convert.ToDecimal("27.00") },
            new ReferenceModelBase { Id=Guid.Parse("b16f4d83-d835-4104-9f02-dda8dbcb3160"), Code="211", Description="Land and Land Improvements", Definition="A capital asset account that reflects the acquisition value of land owned by a school district. If land is purchased, this account includes the purchase price and costs such as legal fees, filling and excavation costs, and other associated improvement costs incurred to put the land in condition for its intended use. If land is acquired by gift, the account reflects its fair value at the time of acquisition. Permanent improvements to land, such as grading and fill, should also be accounted for in this account. Land and land improvements are considered nonexhaustible assets owing to their significantly long expected useful life. Nonexhaustible assets are not to be depreciated. Therefore, assets classified by asset code 211 should result in no depreciation expense.", SortOrder=Convert.ToDecimal("28.00") },
            new ReferenceModelBase { Id=Guid.Parse("5960385b-af6d-4d93-9ff9-c35319baf4e9"), Code="221", Description="Site Improvements", Definition="A capital asset account that reflects the value of nonpermanent improvements to building sites, other than buildings, that add value to land. Examples of such improvements are fences, retaining walls, sidewalks, pavements, gutters, tunnels, and bridges. If the improvements are purchased or constructed, this account contains the purchase or contract price. If improvements are obtained by gift, it reflects the fair value at the time of acquisition. Site improvements are improvements that have a limited useful life. Because these improvements decrease in their value/usefulness over time, it is appropriate to depreciate these assets. Therefore, all capitalized site improvements should be depreciated over their expected useful life.", SortOrder=Convert.ToDecimal("29.00") },
            new ReferenceModelBase { Id=Guid.Parse("8fb4828f-0018-4ee1-9b73-6b6454212311"), Code="222", Description="Accumulated Depreciation on Site Improvements", Definition="Accumulated amounts for the depreciation of land improvements.", SortOrder=Convert.ToDecimal("30.00") },
            new ReferenceModelBase { Id=Guid.Parse("6083fee7-05d8-4176-a164-0a98b76f4b58"), Code="231", Description="Buildings and Building Improvements", Definition="A capital asset account that reflects the acquisition value of permanent structures used to house persons and property owned by the school district. If buildings are purchased or constructed, this account includes the purchase or contract price of all permanent buildings and the fixtures attached to and forming a permanent part of such buildings. This account includes all building improvements, including upgrades made to building wiring for technology. If buildings are acquired by gift, the account reflects their fair value at the time of acquisition.", SortOrder=Convert.ToDecimal("31.00") },
            new ReferenceModelBase { Id=Guid.Parse("11703147-c3a4-4b12-9635-8c6d5c7e996e"), Code="232", Description="Accumulated Depreciation on Buildings and Building Improvements", Definition="Accumulated amounts for the depreciation of buildings and building improvements.", SortOrder=Convert.ToDecimal("32.00") },
            new ReferenceModelBase { Id=Guid.Parse("f2ff26be-6119-44d8-9fe5-01bf8d49683a"), Code="241", Description="Machinery and Equipment", Definition="Tangible property of a more or less permanent nature, other than land, buildings, or improvements thereto, that is useful in carrying on operations. Examples are machinery, tools, trucks, cars, buses, computers, purchased software, furniture, and furnishings. Appendix E provides criteria to distinguish whether a purchase is a supply or a piece of machinery or equipment.", SortOrder=Convert.ToDecimal("33.00") },
            new ReferenceModelBase { Id=Guid.Parse("2b2cbf9c-a612-461e-ba0b-d415ec4da9ce"), Code="242", Description="Accumulated Depreciation on Machinery and Equipment", Definition="Accumulated amounts for the depreciation of machinery and equipment.", SortOrder=Convert.ToDecimal("34.00") },
            new ReferenceModelBase { Id=Guid.Parse("2dbb36f7-bd6a-4115-9a0c-0195417adcd4"), Code="251", Description="Works of Art and Historical Treasures", Definition="Individual items or collections of items that are of artistic or cultural importance.", SortOrder=Convert.ToDecimal("35.00") },
            new ReferenceModelBase { Id=Guid.Parse("3c8b4fd6-c686-4b15-8c8d-7ebc7406808c"), Code="252", Description="Accumulated Depreciation on Works of Art and Historical Collections", Definition="Accumulated amounts for the depreciation (as applicable) of works of art and historical treasures.", SortOrder=Convert.ToDecimal("36.00") },
            new ReferenceModelBase { Id=Guid.Parse("aa7788a5-6b7f-41ab-9f27-ec283225f6a1"), Code="261", Description="Infrastructure", Definition="A capital asset, network, or subsystem that has a useful life that is significantly longer than those of other capital assets. These assets may include water/sewer systems, roads, bridges, tunnels, and other similar assets.", SortOrder=Convert.ToDecimal("37.00") },
            new ReferenceModelBase { Id=Guid.Parse("e0f1c753-9253-4eff-ad13-bbcacac22cdf"), Code="262", Description="Accumulated Depreciation on Infrastructure", Definition="Accumulated amounts for the depreciation of infrastructure assets.", SortOrder=Convert.ToDecimal("38.00") },
            new ReferenceModelBase { Id=Guid.Parse("7a98c3a2-63ea-4582-94f8-05cf02279f21"), Code="271", Description="Construction in Progress", Definition="The cost of construction work undertaken but not yet completed.", SortOrder=Convert.ToDecimal("39.00") },
            new ReferenceModelBase { Id=Guid.Parse("34d65614-ac36-4165-8bcd-529285199db0"), Code="281", Description="Intangible Assets", Definition="An intangible asset is a capital asset that lacks physical substance, is nonfinancial in nature, and has an initial useful life of more than 1 year. Intangible assets may be purchased or licensed, acquired through nonexchange transactions, or internally generated. Examples include easements, contractual rights, patents, trademarks, and computer software.", SortOrder=Convert.ToDecimal("40.00") },
            new ReferenceModelBase { Id=Guid.Parse("692a538b-5267-44b8-b586-fe450acd0cf3"), Code="282", Description="Accumulated Amortization of Intangible Assets", Definition="Accumulated amounts for the amortization of intangible assets.", SortOrder=Convert.ToDecimal("41.00") },
            new ReferenceModelBase { Id=Guid.Parse("d122b443-326f-4a7c-aff6-e189fcb06825"), Code="300", Description="Deferred Outflows of Resources", Definition="A consumption of net assets by the government that is applicable to a future reporting period.", SortOrder=Convert.ToDecimal("42.00") },
            new ReferenceModelBase { Id=Guid.Parse("1507fcce-494c-440c-8f65-1bca94ffada8"), Code="401", Description="Interfund Loans Payable", Definition="A liability account used to record a debt owed by one fund to another fund in the same governmental unit. It is recommended that separate accounts be maintained for each interfund loan.", SortOrder=Convert.ToDecimal("43.00") },
            new ReferenceModelBase { Id=Guid.Parse("28251cb7-0ef3-43d4-b2fd-e952376933fc"), Code="402", Description="Interfund Accounts Payable", Definition="A liability account used to indicate amounts owed by a particular fund for services rendered. It is recommended that separate accounts be maintained for each interfund payable.", SortOrder=Convert.ToDecimal("44.00") },
            new ReferenceModelBase { Id=Guid.Parse("9dbc5455-705f-49d7-8ec4-66b01d1cf024"), Code="411", Description="Intergovernmental Accounts Payable", Definition="Amounts owed by the reporting school district to another governmental unit. It is recommended that separate accounts be maintained for each intergovernmental payable.", SortOrder=Convert.ToDecimal("45.00") },
            new ReferenceModelBase { Id=Guid.Parse("7a2cb853-9afc-4809-b949-c8c5396b5219"), Code="421", Description="Accounts Payable", Definition="Liabilities on open account owed to private persons, firms, or corporations for goods and services received by a school district (but not including amounts due to other funds of the same school district or to other governmental units).", SortOrder=Convert.ToDecimal("46.00") },
            new ReferenceModelBase { Id=Guid.Parse("284eedd3-349f-4a5c-bd77-07a12b7d85d5"), Code="422", Description="Judgments Payable", Definition="Amounts due to be paid by a school district as the result of court decisions, including condemnation awards paid for private property taken for public use.", SortOrder=Convert.ToDecimal("47.00") },
            new ReferenceModelBase { Id=Guid.Parse("a1455979-98fc-4b14-b9ed-8d11c232f5f6"), Code="423", Description="Warrants Payable", Definition="Amounts due to designated payees in the form of a written order drawn by the school district directing the school district treasurer to pay a specific amount.", SortOrder=Convert.ToDecimal("48.00") },
            new ReferenceModelBase { Id=Guid.Parse("93ed5736-8b3b-46c0-bd4b-9af4c2864984"), Code="431", Description="Contracts Payable", Definition="Amounts due on contracts for assets, goods, and services received by a school district.", SortOrder=Convert.ToDecimal("49.00") },
            new ReferenceModelBase { Id=Guid.Parse("d590f5b9-1234-4318-a126-b58ebe256d47"), Code="432", Description="Construction Contracts Payable-Retainage", Definition="Liabilities on account of construction contracts for that portion of the work that has been completed but on which part the liability has not been paid pending final inspection, the lapse of a specified time period, or both. The unpaid amount is usually a stated percentage of the contract price.", SortOrder=Convert.ToDecimal("50.00") },
            new ReferenceModelBase { Id=Guid.Parse("97ee121f-8e57-4c1a-bdf9-00e44cbdbf88"), Code="433", Description="Construction Contracts Payable", Definition="Amounts due by a school district on contracts for constructing buildings and other structures and other improvements.", SortOrder=Convert.ToDecimal("51.00") },
            new ReferenceModelBase { Id=Guid.Parse("35beda4a-6dc9-46c7-b392-64044f8efd10"), Code="441", Description="Matured Bonds Payable", Definition="Bonds that have reached or passed their maturity date but that remain unpaid.", SortOrder=Convert.ToDecimal("52.00") },
            new ReferenceModelBase { Id=Guid.Parse("aad1cf10-bb9f-4a7f-9910-84905e7d04f9"), Code="442", Description="Bonds Payable-Current", Definition="Bonds that have not reached or passed their maturity date but are due within 1 year or less. This account is used only in proprietary or fiduciary funds, as well as in the government-wide financial statements.", SortOrder=Convert.ToDecimal("53.00") },
            new ReferenceModelBase { Id=Guid.Parse("0a5d13dc-faba-4896-bf23-c6ad5e44532b"), Code="443", Description="Unamortized Premiums on Issuance of Bonds", Definition="An account that represents that portion of the excess of bond proceeds over par value and that remains to be amortized over the remaining life of such bonds. This account is used only in proprietary or fiduciary funds, as well as in the government-wide financial statements.", SortOrder=Convert.ToDecimal("54.00") },
            new ReferenceModelBase { Id=Guid.Parse("06be6a0c-567d-4d07-bcca-d55bf6822877"), Code="451", Description="Loans Payable", Definition="Short-term obligations representing amounts borrowed for short periods of time, usually evidenced by notes payable or warrants payable.", SortOrder=Convert.ToDecimal("55.00") },
            new ReferenceModelBase { Id=Guid.Parse("f23adf88-3efb-4140-9f10-9179c1c35b98"), Code="452", Description="Lease Obligations-Current", Definition="Capital lease obligations that are due within 1 year.", SortOrder=Convert.ToDecimal("56.00") },
            new ReferenceModelBase { Id=Guid.Parse("fe37430e-c01e-4594-9e11-1de3561eb70f"), Code="455", Description="Interest Payable", Definition="Interest due within 1 year.", SortOrder=Convert.ToDecimal("57.00") },
            new ReferenceModelBase { Id=Guid.Parse("5ec6b47c-25c9-40d4-b8d9-76a9239c5536"), Code="461", Description="Accrued Salaries and Benefits", Definition="Salary and fringe benefit costs incurred during the current accounting period that are not payable until a subsequent accounting period.", SortOrder=Convert.ToDecimal("58.00") },
            new ReferenceModelBase { Id=Guid.Parse("f4ef1094-1644-41b0-9ca5-fa547d444c3f"), Code="471", Description="Payroll Deductions and Withholdings", Definition="Amounts deducted from employees' salaries for withholding taxes and other purposes. District-paid benefits amounts payable are also included. A separate liability account may be used for each type of benefit.", SortOrder=Convert.ToDecimal("59.00") },
            new ReferenceModelBase { Id=Guid.Parse("561ac06d-b9c3-4f7f-aec6-010b8940416c"), Code="472", Description="Compensated Absences-Current", Definition="Compensated absences that will be paid within 1 year.", SortOrder=Convert.ToDecimal("60.00") },
            new ReferenceModelBase { Id=Guid.Parse("b449b0f9-16f8-4cf7-91f4-a2b2cc8df0b5"), Code="473", Description="Accrued Annual Requirement Contribution Liability", Definition="A liability arising from payments not made to pension funds. This amount represents any difference between the actuarially determined annual required contribution and actual payments made to the pension fund.", SortOrder=Convert.ToDecimal("61.00") },
            new ReferenceModelBase { Id=Guid.Parse("89ea7570-64c8-4390-924f-1be9e9047a6c"), Code="481", Description="Advances from Grantors", Definition="A liability account that represents resources received from grantors before eligibility requirements are met.", SortOrder=Convert.ToDecimal("62.00") },
            new ReferenceModelBase { Id=Guid.Parse("8ad199b8-f299-4d14-8000-611645aca8ce"), Code="491", Description="Deposits Payable", Definition="Liability for deposits received as a prerequisite to providing or receiving services, goods, or both.", SortOrder=Convert.ToDecimal("63.00") },
            new ReferenceModelBase { Id=Guid.Parse("0470e607-e109-4a33-8ccd-09bd54c9264e"), Code="499", Description="Other Current Liabilities", Definition="Other current liabilities not provided for elsewhere.", SortOrder=Convert.ToDecimal("64.00") },
            new ReferenceModelBase { Id=Guid.Parse("dc64a065-3298-473c-9299-3719eff9266a"), Code="500", Description="Long-Term Liabilities", Definition="Obligations with a maturity of more than 1 year. These accounts should be used only with proprietary and fiduciary funds, as well as at the entity-wide level of reporting.", SortOrder=Convert.ToDecimal("65.00") },
            new ReferenceModelBase { Id=Guid.Parse("a764a9e4-13ef-400c-9f00-c0bac5c95935"), Code="511", Description="Bonds Payable", Definition="Bonds (general obligation, asset-backed, or revenue-backed) that have not reached or passed their maturity date and that are not due within 1 year.", SortOrder=Convert.ToDecimal("66.00") },
            new ReferenceModelBase { Id=Guid.Parse("80951109-0506-4af4-898b-d7e37f8e8458"), Code="512", Description="Accreted Interest", Definition="An account that represents interest that is accrued on deep discount bonds. This account should be used by school districts that issue capital appreciation bonds. Such bonds are usually issued at a deep discount from the face value, and no interest payment is made until maturity. Under full accrual accounting, the district is required to accrete the interest on the bonds over the life of the bonds. Accretion is the process of systematically increasing the carrying amount of the bond to its estimated value at the maturity date of the bond. To calculate accreted interest, the district should impute the effective interest rate, using the present value, the face value (or the future value), and the period of the bond, and multiply the effective interest rate by the book value of the debt at the end of the period. Accreted interest is usually recorded as an addition to the outstanding debt liability.", SortOrder=Convert.ToDecimal("67.00") },
            new ReferenceModelBase { Id=Guid.Parse("c62f45dd-6231-4936-991c-5b7c7ff27253"), Code="513", Description="Unamortized Gains/Losses on Debt Refundings", Definition="An account that represents the difference between the reacquisition price and the net carrying amount of old debt when a current or advance refunding of debt occurs. This account should be used only when defeasance of debt occurs for proprietary funds and entity-wide statements. The unamortized loss amount should be reported as a deferred outflow of resources and amortized as a component of interest expense in a systematic and rational manner over the remaining life of the old debt or the life of the new debt, whichever is shorter. The unamortized gain amount should be reported as a deferred inflow of resources and amortized as a component of interest expense in a systematic and rational manner over the remaining life of the old debt or the life of the new debt, whichever is shorter.", SortOrder=Convert.ToDecimal("68.00") },
            new ReferenceModelBase { Id=Guid.Parse("d5535793-d1ff-4be4-8a65-ba32144f09c4"), Code="521", Description="Loans Payable", Definition="An unconditional written promise signed by the maker to pay a certain sum of money 1 year or more after the issuance date.", SortOrder=Convert.ToDecimal("69.00") },
            new ReferenceModelBase { Id=Guid.Parse("9c3b4c09-39eb-4d27-a9dd-fb58c9812b4d"), Code="531", Description="Capital Lease Obligations", Definition="Amounts remaining to be paid on capital lease agreements.", SortOrder=Convert.ToDecimal("70.00") },
            new ReferenceModelBase { Id=Guid.Parse("b1c81424-8cc3-4e7d-ae18-aeb1c827bfba"), Code="551", Description="Compensated Absences", Definition="Amounts remaining beyond the period of 1 year to be paid on compensated absences balances.", SortOrder=Convert.ToDecimal("71.00") },
            new ReferenceModelBase { Id=Guid.Parse("ead44b64-c5ca-4981-85ff-c838b4d994e9"), Code="553", Description="Special Termination Benefits", Definition="These are benefits offered for a short period of time to employees in connection with their termination of employment. Special termination benefits are often used as an inducement for early retirement or to address budgetary problems.", SortOrder=Convert.ToDecimal("72.00") },
            new ReferenceModelBase { Id=Guid.Parse("c45289b2-d2ca-455e-9e28-b792a51f94a6"), Code="561", Description="Arbitrage Rebate Liability", Definition="Liabilities arising from arbitrage rebates to the Internal Revenue Service (IRS) from bond financing.", SortOrder=Convert.ToDecimal("73.00") },
            new ReferenceModelBase { Id=Guid.Parse("e3a4279e-0f35-4445-9360-3ea62a583eb8"), Code="590", Description="Other Long-Term Liabilities", Definition="Other long-term liabilities not provided for elsewhere. This account represents amounts due after more than 1 year from the balance sheet date for advances from other funds and certain miscellaneous liabilities, including workers' compensation, self-funded insurance, special termination benefits, and legal claims and judgments.", SortOrder=Convert.ToDecimal("74.00") },
            new ReferenceModelBase { Id=Guid.Parse("1c168f11-c4b2-43f2-802a-76d288da59d6"), Code="600", Description="Deferred Inflows of Resources", Definition="An acquisition of net assets by the government that is applicable to a future reporting period. A deferred inflow of resources should be recognized when resources are received or recognized as a receivable before (a) the period for which property taxes are levied or (b) the period when the resources are required to be used. When an asset is recorded in governmental fund financial statements but the revenue is not available, the government should report a deferred inflow of resources until such time as the revenue becomes available.", SortOrder=Convert.ToDecimal("75.00") },
            new ReferenceModelBase { Id=Guid.Parse("b9cf86de-a43f-4fef-bdda-d77a9555ffbd"), Code="710", Description="Nonspendable Fund Balance", Definition="The nonspendable fund balance classification includes amounts that cannot be spent because they are either (a) not in spendable form or (b) legally or contractually required to be maintained intact. This would include items not expected to be converted to cash, including inventories and prepaid amounts. It may also include the long-term amount of loans and receivables, as well as property acquired for resale and the corpus (principal) of a permanent fund.", SortOrder=Convert.ToDecimal("76.00") },
            new ReferenceModelBase { Id=Guid.Parse("dcd703e3-80be-4793-9916-51f6f96fdfe7"), Code="720", Description="Restricted Fund Balance", Definition="The restricted fund balance classification should be reported when legally enforceable constraints placed on the use of resources are either (a) externally imposed by creditors, grantors, contributors, or laws or regulations of other governments or (b) imposed by law through constitutional provisions or enabling legislation.", SortOrder=Convert.ToDecimal("77.00") },
            new ReferenceModelBase { Id=Guid.Parse("bf8ff02c-5508-4c66-a275-164c04ff02d2"), Code="730", Description="Committed Fund Balance", Definition="The committed fund balance classification reflects specific purposes pursuant to constraints imposed by formal action at the district's highest level of decisionmaking authority (generally the governing board). Such constraints can only be removed or changed by the same form of formal action.", SortOrder=Convert.ToDecimal("78.00") },
            new ReferenceModelBase { Id=Guid.Parse("b123f973-9550-458c-8cba-352f1fc3ca55"), Code="740", Description="Assigned Fund Balance", Definition="The assigned fund balance classification reflects amounts that are constrained by the government's intent to be used for specific purposes, but meet neither the restricted nor committed forms of constraint. Also, the assigned fund balance classification is the residual classification for the special revenue, debt service, capital projects, and/or permanent funds after nonspendable, restricted, and committed balances have been identified (unless the residual amount is negative, which would require presentation as unassigned fund balance).", SortOrder=Convert.ToDecimal("79.00") },
            new ReferenceModelBase { Id=Guid.Parse("da4a79fd-ac22-4fbc-8644-9daa18d9b304"), Code="750", Description="Unassigned Fund Balance", Definition="The unassigned fund balance classification is the residual classification, for the general fund only, after nonspendable, restricted, committed, and assigned balances have been identified. It is also used to report the residual amount for all other governmental funds after nonspendable, restricted, and committed balances have been identified, if the residual amount is negative.", SortOrder=Convert.ToDecimal("80.00") },
            new ReferenceModelBase { Id=Guid.Parse("5d995e97-c444-4a42-8bbd-c54451549814"), Code="760", Description="Net Investment in Capital Assets", Definition="This account is used to record the component of net position invested in capital assets, net of related debt, that represents total capital assets less accumulated depreciation less debt directly related to capital assets. This account is to be used only in proprietary funds and entity-wide statements. (This was previously fund balance code 740.)", SortOrder=Convert.ToDecimal("81.00") },
            new ReferenceModelBase { Id=Guid.Parse("b4e2b63e-5051-46a4-943e-e34fccf7eceb"), Code="770", Description="Restricted Net Position", Definition="This account is used to record the component of net position that represents net assets legally restricted by sources internal or external to the organization. This account is to be used only in proprietary funds and entity-wide statements. (This was previously fund balance code 750.)", SortOrder=Convert.ToDecimal("82.00") },
            new ReferenceModelBase { Id=Guid.Parse("9c0fa4ca-28ff-4d81-8abc-4f558789368b"), Code="780", Description="Unrestricted Net Position", Definition="This account is used to record the component of net position that represents net position not classified in accounts 760 and 770. This account is to be used only in proprietary funds and entity-wide statements. (This was previously fund balance code 760.)", SortOrder=Convert.ToDecimal("83.00") },
        };
        #endregion
    }
}
