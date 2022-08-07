//**********************************************************
//* DomainName: Autobahn.Facilities
//* FileName:   RefFacilityMortgageInterestTypeList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Facilities.Models
{
     /// <summary>
     /// The list of RefFacilityMortgageInterestType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefFacilityMortgageInterestTypeModel"> List
         /// </summary>
        public static List<RefFacilityMortgageInterestTypeModel> RefFacilityMortgageInterestTypeList = new List<RefFacilityMortgageInterestTypeModel>
        {
            new RefFacilityMortgageInterestType { Id=Guid.Parse("ec526de7-40fa-4f19-b149-4c56f68321af"), Code="13730", Description="Add-on interest", Definition="Interest added to the amount of the loan on the front end, or beginning of the loan repayment period. The balance (of principal and interest) is then paid by installments. This form of interest is much more expensive than simple interest paid on the entire amount for the entire term of the loan.", SortOrder=Convert.ToDecimal("1.00") },
            new RefFacilityMortgageInterestType { Id=Guid.Parse("700c3ca1-094c-426e-9671-f0788e09b4f5"), Code="13731", Description="Adjustable-Rate Mortgage (ARM)", Definition="A mortgage in which interest and payment rates vary periodically, based on a specific index, such as 30-year Treasury bills or the Cost-of-Funds index.", SortOrder=Convert.ToDecimal("2.00") },
            new RefFacilityMortgageInterestType { Id=Guid.Parse("031f00a5-f9d0-4f25-b943-a504e0e25f19"), Code="13732", Description="Balloon Mortgage", Definition="A short-term mortgage, generally at a fixed rate of interest, to be paid back in pre-determined, equal monthly payments, with a large, final payment for the balance of the loan paid at the end of the term.", SortOrder=Convert.ToDecimal("3.00") },
            new RefFacilityMortgageInterestType { Id=Guid.Parse("247fd2ec-9810-494e-b130-070ace623a05"), Code="13733", Description="Deferred Interest", Definition="Interest due but unpaid. Mortgages that permit negative amortization (such as a graduated-payment mortgage or a floating rate loan without a rate cap) will allow deferred interest.", SortOrder=Convert.ToDecimal("4.00") },
            new RefFacilityMortgageInterestType { Id=Guid.Parse("75abbc92-ff75-4d72-bc91-1d16daf31c27"), Code="13734", Description="Fixed Payment Mortgage", Definition="Periodic payments of principal and interest on a mortgage which remain constant over the loan term.", SortOrder=Convert.ToDecimal("5.00") },
            new RefFacilityMortgageInterestType { Id=Guid.Parse("ca80a7e8-340d-4ef8-8d0a-1679e6449115"), Code="13735", Description="Fixed-rate Mortgage", Definition="A mortgage in which the interest rate does not change during the entire term of the loan.", SortOrder=Convert.ToDecimal("6.00") },
            new RefFacilityMortgageInterestType { Id=Guid.Parse("60fc9df6-ec96-4f18-87a9-090054e6d6bf"), Code="13736", Description="Floating Rate", Definition="An interest rate on a loan which changes during the life of the loan, often monthly, but can change quarterly or annually. These variable rates are based on an index rate and can be used for mortgages and other loans such as lines of credit.", SortOrder=Convert.ToDecimal("7.00") },
            new RefFacilityMortgageInterestType { Id=Guid.Parse("fd761963-ec3f-417c-8b9c-fc91ad041f0d"), Code="13737", Description="Fully Amortizing Mortgage", Definition="A method of loan amortization in which equal periodic payments completely repay the loan during the loan term.", SortOrder=Convert.ToDecimal("8.00") },
            new RefFacilityMortgageInterestType { Id=Guid.Parse("7eade9a8-df1c-49d3-9c6b-f5f8e2a79876"), Code="13738", Description="Graduated-payment Mortgage (GPM)", Definition="A type of stepped-payment loan in which the borrower's payments are initially lower than those on a comparable level-rate mortgage. The payments gradually increase over a predetermined period, and then cap at a final level for the duration of the mortgage.", SortOrder=Convert.ToDecimal("9.00") },
            new RefFacilityMortgageInterestType { Id=Guid.Parse("2687ade6-f3e5-48ac-a299-ada5cf297ca9"), Code="13739", Description="Interest-only loan", Definition="A method of loan amortization in which interest is paid periodically over the term of the loan and the entire loan amount (principal) is paid at maturity.", SortOrder=Convert.ToDecimal("10.00") },
            new RefFacilityMortgageInterestType { Id=Guid.Parse("af137ca7-ae64-4f37-b3b4-93c1bb9fc75c"), Code="13740", Description="Open-end Mortgage", Definition="A mortgage agreement that allows the mortgagor to borrow additional funds from the mortgage lender in the future, normally with a borrowing limit. This limit may be based on loan-to-value or may simply be the original loan amount.", SortOrder=Convert.ToDecimal("11.00") },
        };

        /// <summary>
        /// The Reference RefFacilityMortgageInterestType Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefFacilityMortgageInterestTypeViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefFacilityMortgageInterestType { Id=Guid.Parse("ec526de7-40fa-4f19-b149-4c56f68321af"), Description="Add-on interest", SortOrder=Convert.ToDecimal("1.00") },
            new RefFacilityMortgageInterestType { Id=Guid.Parse("700c3ca1-094c-426e-9671-f0788e09b4f5"), Description="Adjustable-Rate Mortgage (ARM)", SortOrder=Convert.ToDecimal("2.00") },
            new RefFacilityMortgageInterestType { Id=Guid.Parse("031f00a5-f9d0-4f25-b943-a504e0e25f19"), Description="Balloon Mortgage", SortOrder=Convert.ToDecimal("3.00") },
            new RefFacilityMortgageInterestType { Id=Guid.Parse("247fd2ec-9810-494e-b130-070ace623a05"), Description="Deferred Interest", SortOrder=Convert.ToDecimal("4.00") },
            new RefFacilityMortgageInterestType { Id=Guid.Parse("75abbc92-ff75-4d72-bc91-1d16daf31c27"), Description="Fixed Payment Mortgage", SortOrder=Convert.ToDecimal("5.00") },
            new RefFacilityMortgageInterestType { Id=Guid.Parse("ca80a7e8-340d-4ef8-8d0a-1679e6449115"), Description="Fixed-rate Mortgage", SortOrder=Convert.ToDecimal("6.00") },
            new RefFacilityMortgageInterestType { Id=Guid.Parse("60fc9df6-ec96-4f18-87a9-090054e6d6bf"), Description="Floating Rate", SortOrder=Convert.ToDecimal("7.00") },
            new RefFacilityMortgageInterestType { Id=Guid.Parse("fd761963-ec3f-417c-8b9c-fc91ad041f0d"), Description="Fully Amortizing Mortgage", SortOrder=Convert.ToDecimal("8.00") },
            new RefFacilityMortgageInterestType { Id=Guid.Parse("7eade9a8-df1c-49d3-9c6b-f5f8e2a79876"), Description="Graduated-payment Mortgage (GPM)", SortOrder=Convert.ToDecimal("9.00") },
            new RefFacilityMortgageInterestType { Id=Guid.Parse("2687ade6-f3e5-48ac-a299-ada5cf297ca9"), Description="Interest-only loan", SortOrder=Convert.ToDecimal("10.00") },
            new RefFacilityMortgageInterestType { Id=Guid.Parse("af137ca7-ae64-4f37-b3b4-93c1bb9fc75c"), Description="Open-end Mortgage", SortOrder=Convert.ToDecimal("11.00") },
       };
   }
}
