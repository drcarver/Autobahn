//**********************************************************
//* DomainName: Postsecondary (PS)
//* FileName:   IPEDSFinanceViewModel.cs
//***************************************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using Autobahn.Common.Models;
using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Postsecondary.ViewModels
{
     /// <summary>
     /// The IPEDSFinance View Model
     /// </summary>
    public partial class IPEDSFinanceViewModel : ViewModelBase, Interfaces.IIPEDSFinance
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from IPEDSFinance";

        // member variable for the OrganizationFinancialId property
        private Guid _OrganizationFinancialId;

        // RefIPEDSFASBFinancialPositionId -- (backing property for IPEDS Finance FASB Financial Position Category)
        private Guid? _RefIPEDSFASBFinancialPositionId;

        // RefIPEDSFASBFunctionalExpenseId -- (backing property for IPEDS Finance FASB Functional Expense Category)
        private Guid? _RefIPEDSFASBFunctionalExpenseId;

        // RefIPEDSFASBPellGrantTransactionsId -- (backing property for IPEDS Finance FASB Pell Grant Transactions)
        private Guid? _RefIPEDSFASBPellGrantTransactionsId;

        // RefIPEDSFASBRevenueId -- (backing property for IPEDS Finance FASB Revenue Category)
        private Guid? _RefIPEDSFASBRevenueId;

        // RefIPEDSFASBRevenueRestrictionId -- (backing property for IPEDS Finance FASB Revenue Restriction Category)
        private Guid? _RefIPEDSFASBRevenueRestrictionId;

        // RefIPEDSFASBScholarshipsandFellowshipsRevenueId -- (backing property for IPEDS Finance FASB Scholarships and Fellowships Revenue Category)
        private Guid? _RefIPEDSFASBScholarshipsandFellowshipsRevenueId;

        // RefIPEDSGASBFinancialPositionId -- (backing property for IPEDS Finance GASB Financial Position Category)
        private Guid? _RefIPEDSGASBFinancialPositionId;

        // RefIPEDSGASBFunctionalExpenseId -- (backing property for IPEDS Finance GASB Functional Expense Category)
        private Guid? _RefIPEDSGASBFunctionalExpenseId;

        // RefIPEDSGASBRevenueId -- (backing property for IPEDS Finance GASB Revenue Category)
        private Guid? _RefIPEDSGASBRevenueId;

        // RefIPEDSGASBScholarshipsandFellowshipsRevenueId -- (backing property for IPEDS Finance GASB Scholarships and Fellowships Revenue Category)
        private Guid? _RefIPEDSGASBScholarshipsandFellowshipsRevenueId;

        // RefIPEDSIntercollegiateAthleticsExpensesId -- (backing property for IPEDS Finance Intercollegiate Athletics Expenses)
        private Guid? _RefIPEDSIntercollegiateAthleticsExpensesId;

        // RefIPEDSNaturalExpenseId -- (backing property for IPEDS Finance Natural Expense Category)
        private Guid? _RefIPEDSNaturalExpenseId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IOrganizationFinancial"/> model
        /// </summary>
        public Guid OrganizationFinancialId { get => _OrganizationFinancialId; set => SetProperty(ref _OrganizationFinancialId, value); }

        /// <summary>
        /// IPEDS Finance FASB Financial Position Category
        /// <para>
        /// IPEDS financial position classification used by degree-granting private, not-for-profit institutions and public institutions using FASB Reporting Standards for reporting the assets, liabilities, and net assets in a manner consistent with the Statement of Financial Position in the General Purpose Financial Statements (GPFS).
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20652">IPEDS Finance FASB Financial Position Category</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefIPEDSFASBFinancialPositionId { get => _RefIPEDSFASBFinancialPositionId; set => SetProperty(ref _RefIPEDSFASBFinancialPositionId, value); }

        /// <summary>
        /// IPEDS Finance FASB Functional Expense Category
        /// <para>
        /// A functional expense classification is a method of grouping expenses according to the purpose for which the costs are incurred. The classifications tell�why�an expense was incurred rather than�what�was purchased.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20640">IPEDS Finance FASB Functional Expense Category</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefIPEDSFASBFunctionalExpenseId { get => _RefIPEDSFASBFunctionalExpenseId; set => SetProperty(ref _RefIPEDSFASBFunctionalExpenseId, value); }

        /// <summary>
        /// IPEDS Finance FASB Pell Grant Transactions
        /// <para>
        /// Method of reporting Pell Grants in IPEDS by degree-granting private, not-for-profit institutions and public institutions using FASB Reporting Standards.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20661">IPEDS Finance FASB Pell Grant Transactions</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefIPEDSFASBPellGrantTransactionsId { get => _RefIPEDSFASBPellGrantTransactionsId; set => SetProperty(ref _RefIPEDSFASBPellGrantTransactionsId, value); }

        /// <summary>
        /// IPEDS Finance FASB Revenue Category
        /// <para>
        /// IPEDS revenue classification used by degree-granting private, not-for-profit institutions and public institutions using FASB Reporting Standards for reporting revenues and investment return by source in a manner consistent with the definitions from the National Association of College and University Business Officers (NACUBO) Financial Accounting and Reporting Manual for Higher Education (FARM).
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20654">IPEDS Finance FASB Revenue Category</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefIPEDSFASBRevenueId { get => _RefIPEDSFASBRevenueId; set => SetProperty(ref _RefIPEDSFASBRevenueId, value); }

        /// <summary>
        /// IPEDS Finance FASB Revenue Restriction Category
        /// <para>
        /// IPEDS revenue restriction classification used by degree-granting private, not-for-profit institutions and public institutions using FASB Reporting Standards for reporting revenues by restriction.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20655">IPEDS Finance FASB Revenue Restriction Category</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefIPEDSFASBRevenueRestrictionId { get => _RefIPEDSFASBRevenueRestrictionId; set => SetProperty(ref _RefIPEDSFASBRevenueRestrictionId, value); }

        /// <summary>
        /// IPEDS Finance FASB Scholarships and Fellowships Revenue Category
        /// <para>
        /// IPEDS revenue category used by degree-granting private, not-for-profit institutions and public institutions using FASB Reporting Standards for the reporting of resources received for supporting student grant aid.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20659">IPEDS Finance FASB Scholarships and Fellowships Revenue Category</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefIPEDSFASBScholarshipsandFellowshipsRevenueId { get => _RefIPEDSFASBScholarshipsandFellowshipsRevenueId; set => SetProperty(ref _RefIPEDSFASBScholarshipsandFellowshipsRevenueId, value); }

        /// <summary>
        /// IPEDS Finance GASB Financial Position Category
        /// <para>
        /// IPEDS financial position classification used by degree-granting public institutions using GASB Reporting Standards for reporting the assets, liabilities, and net position in a manner consistent with the Statement of Net Position in the General Purpose Financial Statements (GPFS).
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20651">IPEDS Finance GASB Financial Position Category</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefIPEDSGASBFinancialPositionId { get => _RefIPEDSGASBFinancialPositionId; set => SetProperty(ref _RefIPEDSGASBFinancialPositionId, value); }

        /// <summary>
        /// IPEDS Finance GASB Functional Expense Category
        /// <para>
        /// A functional expense classification is a method of grouping expenses according to the purpose for which the costs are incurred. The classifications tell why an expense was incurred rather than what was purchased.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20656">IPEDS Finance GASB Functional Expense Category</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefIPEDSGASBFunctionalExpenseId { get => _RefIPEDSGASBFunctionalExpenseId; set => SetProperty(ref _RefIPEDSGASBFunctionalExpenseId, value); }

        /// <summary>
        /// IPEDS Finance GASB Revenue Category
        /// <para>
        /// IPEDS revenue classification used by degree-granting public institutions using GASB Reporting Standards for reporting revenues and other additions by source including all operating revenues, nonoperating revenues, and other additions for the reporting period. This includes unrestricted and restricted revenues and additions, whether expendable or nonexpendable.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20653">IPEDS Finance GASB Revenue Category</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefIPEDSGASBRevenueId { get => _RefIPEDSGASBRevenueId; set => SetProperty(ref _RefIPEDSGASBRevenueId, value); }

        /// <summary>
        /// IPEDS Finance GASB Scholarships and Fellowships Revenue Category
        /// <para>
        /// IPEDS revenue category used by degree-granting public institutions using GASB Reporting Standards for the reporting of resources received for supporting student scholarships and fellowships.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20658">IPEDS Finance GASB Scholarships and Fellowships Revenue Category</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefIPEDSGASBScholarshipsandFellowshipsRevenueId { get => _RefIPEDSGASBScholarshipsandFellowshipsRevenueId; set => SetProperty(ref _RefIPEDSGASBScholarshipsandFellowshipsRevenueId, value); }

        /// <summary>
        /// IPEDS Finance Intercollegiate Athletics Expenses
        /// <para>
        /// Identifies the functional expense category where the institution allocates its intercollegiate athletics expenses.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20660">IPEDS Finance Intercollegiate Athletics Expenses</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefIPEDSIntercollegiateAthleticsExpensesId { get => _RefIPEDSIntercollegiateAthleticsExpensesId; set => SetProperty(ref _RefIPEDSIntercollegiateAthleticsExpensesId, value); }

        /// <summary>
        /// IPEDS Finance Natural Expense Category
        /// <para>
        /// A natural expense classification is a method of grouping expenses according to the type of costs that are incurred. The classifications tell what was purchased rather than why an expense was incurred.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20657">IPEDS Finance Natural Expense Category</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefIPEDSNaturalExpenseId { get => _RefIPEDSNaturalExpenseId; set => SetProperty(ref _RefIPEDSNaturalExpenseId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IIPEDSFinance model)
        {
            IsBusy = true;
            Id = model.Id;
            OrganizationFinancialId = model.OrganizationFinancialId; // 
            RefIPEDSFASBFinancialPositionId = model.RefIPEDSFASBFinancialPositionId; // IPEDS Finance FASB Financial Position Category
            RefIPEDSFASBFunctionalExpenseId = model.RefIPEDSFASBFunctionalExpenseId; // IPEDS Finance FASB Functional Expense Category
            RefIPEDSFASBPellGrantTransactionsId = model.RefIPEDSFASBPellGrantTransactionsId; // IPEDS Finance FASB Pell Grant Transactions
            RefIPEDSFASBRevenueId = model.RefIPEDSFASBRevenueId; // IPEDS Finance FASB Revenue Category
            RefIPEDSFASBRevenueRestrictionId = model.RefIPEDSFASBRevenueRestrictionId; // IPEDS Finance FASB Revenue Restriction Category
            RefIPEDSFASBScholarshipsandFellowshipsRevenueId = model.RefIPEDSFASBScholarshipsandFellowshipsRevenueId; // IPEDS Finance FASB Scholarships and Fellowships Revenue Category
            RefIPEDSGASBFinancialPositionId = model.RefIPEDSGASBFinancialPositionId; // IPEDS Finance GASB Financial Position Category
            RefIPEDSGASBFunctionalExpenseId = model.RefIPEDSGASBFunctionalExpenseId; // IPEDS Finance GASB Functional Expense Category
            RefIPEDSGASBRevenueId = model.RefIPEDSGASBRevenueId; // IPEDS Finance GASB Revenue Category
            RefIPEDSGASBScholarshipsandFellowshipsRevenueId = model.RefIPEDSGASBScholarshipsandFellowshipsRevenueId; // IPEDS Finance GASB Scholarships and Fellowships Revenue Category
            RefIPEDSIntercollegiateAthleticsExpensesId = model.RefIPEDSIntercollegiateAthleticsExpensesId; // IPEDS Finance Intercollegiate Athletics Expenses
            RefIPEDSNaturalExpenseId = model.RefIPEDSNaturalExpenseId; // IPEDS Finance Natural Expense Category
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
