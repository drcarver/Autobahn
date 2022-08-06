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
        /// The complete <see cref="RefFacilityMortgageInterestType"> List
         /// </summary>
        public static List<RefFacilityMortgageInterestType> RefFacilityMortgageInterestTypeList = new List<RefFacilityMortgageInterestType>
        {
            new RefFacilityMortgageInterestType { Id=Guid.Parse("5a4fa3d5-09bb-4f87-9fd7-1519825f9a3d"), Code="13730", Description="Add-on interest", Definition="Interest added to the amount of the loan on the front end, or beginning of the loan repayment period. The balance (of principal and interest) is then paid by installments. This form of interest is much more expensive than simple interest paid on the entire amount for the entire term of the loan.", SortOrder=Convert.ToDecimal("1.00") },
            new RefFacilityMortgageInterestType { Id=Guid.Parse("344eac82-2532-4ab5-95a9-ee22804b9a9b"), Code="13731", Description="Adjustable-Rate Mortgage (ARM)", Definition="A mortgage in which interest and payment rates vary periodically, based on a specific index, such as 30-year Treasury bills or the Cost-of-Funds index.", SortOrder=Convert.ToDecimal("2.00") },
            new RefFacilityMortgageInterestType { Id=Guid.Parse("29dca3c3-53ed-4b7e-839c-d7b2c198ce91"), Code="13732", Description="Balloon Mortgage", Definition="A short-term mortgage, generally at a fixed rate of interest, to be paid back in pre-determined, equal monthly payments, with a large, final payment for the balance of the loan paid at the end of the term.", SortOrder=Convert.ToDecimal("3.00") },
            new RefFacilityMortgageInterestType { Id=Guid.Parse("99daa627-ce15-4f46-b364-1d1ef6b18c20"), Code="13733", Description="Deferred Interest", Definition="Interest due but unpaid. Mortgages that permit negative amortization (such as a graduated-payment mortgage or a floating rate loan without a rate cap) will allow deferred interest.", SortOrder=Convert.ToDecimal("4.00") },
            new RefFacilityMortgageInterestType { Id=Guid.Parse("e989b9cd-b87e-4e15-8cb9-23096616fec9"), Code="13734", Description="Fixed Payment Mortgage", Definition="Periodic payments of principal and interest on a mortgage which remain constant over the loan term.", SortOrder=Convert.ToDecimal("5.00") },
            new RefFacilityMortgageInterestType { Id=Guid.Parse("9db11425-1597-4126-889d-229311ab2722"), Code="13735", Description="Fixed-rate Mortgage", Definition="A mortgage in which the interest rate does not change during the entire term of the loan.", SortOrder=Convert.ToDecimal("6.00") },
            new RefFacilityMortgageInterestType { Id=Guid.Parse("cbcf57af-83cd-49ef-96e9-de22603fcd02"), Code="13736", Description="Floating Rate", Definition="An interest rate on a loan which changes during the life of the loan, often monthly, but can change quarterly or annually. These variable rates are based on an index rate and can be used for mortgages and other loans such as lines of credit.", SortOrder=Convert.ToDecimal("7.00") },
            new RefFacilityMortgageInterestType { Id=Guid.Parse("6ff0ae3c-1df8-47fa-9e9e-019429e696b9"), Code="13737", Description="Fully Amortizing Mortgage", Definition="A method of loan amortization in which equal periodic payments completely repay the loan during the loan term.", SortOrder=Convert.ToDecimal("8.00") },
            new RefFacilityMortgageInterestType { Id=Guid.Parse("83133ce6-28e9-4f41-93b8-514fddf170f1"), Code="13738", Description="Graduated-payment Mortgage (GPM)", Definition="A type of stepped-payment loan in which the borrower's payments are initially lower than those on a comparable level-rate mortgage. The payments gradually increase over a predetermined period, and then cap at a final level for the duration of the mortgage.", SortOrder=Convert.ToDecimal("9.00") },
            new RefFacilityMortgageInterestType { Id=Guid.Parse("bf237b0b-80a6-4b46-922c-55495530512b"), Code="13739", Description="Interest-only loan", Definition="A method of loan amortization in which interest is paid periodically over the term of the loan and the entire loan amount (principal) is paid at maturity.", SortOrder=Convert.ToDecimal("10.00") },
            new RefFacilityMortgageInterestType { Id=Guid.Parse("4d704a48-7bd6-4163-9efa-5519b67a9e16"), Code="13740", Description="Open-end Mortgage", Definition="A mortgage agreement that allows the mortgagor to borrow additional funds from the mortgage lender in the future, normally with a borrowing limit. This limit may be based on loan-to-value or may simply be the original loan amount.", SortOrder=Convert.ToDecimal("11.00") },
        };

        /// <summary>
        /// The RefFacilityMortgageInterestType Pick List
         /// </summary>
        public static List<RefFacilityMortgageInterestType> RefFacilityMortgageInterestTypePickList = new List<RefFacilityMortgageInterestType>
        {
            new RefFacilityMortgageInterestType { Id=Guid.Parse("5a4fa3d5-09bb-4f87-9fd7-1519825f9a3d"), Code="13730", Description="Add-on interest", SortOrder=Convert.ToDecimal("1.00") },
            new RefFacilityMortgageInterestType { Id=Guid.Parse("344eac82-2532-4ab5-95a9-ee22804b9a9b"), Code="13731", Description="Adjustable-Rate Mortgage (ARM)", SortOrder=Convert.ToDecimal("2.00") },
            new RefFacilityMortgageInterestType { Id=Guid.Parse("29dca3c3-53ed-4b7e-839c-d7b2c198ce91"), Code="13732", Description="Balloon Mortgage", SortOrder=Convert.ToDecimal("3.00") },
            new RefFacilityMortgageInterestType { Id=Guid.Parse("99daa627-ce15-4f46-b364-1d1ef6b18c20"), Code="13733", Description="Deferred Interest", SortOrder=Convert.ToDecimal("4.00") },
            new RefFacilityMortgageInterestType { Id=Guid.Parse("e989b9cd-b87e-4e15-8cb9-23096616fec9"), Code="13734", Description="Fixed Payment Mortgage", SortOrder=Convert.ToDecimal("5.00") },
            new RefFacilityMortgageInterestType { Id=Guid.Parse("9db11425-1597-4126-889d-229311ab2722"), Code="13735", Description="Fixed-rate Mortgage", SortOrder=Convert.ToDecimal("6.00") },
            new RefFacilityMortgageInterestType { Id=Guid.Parse("cbcf57af-83cd-49ef-96e9-de22603fcd02"), Code="13736", Description="Floating Rate", SortOrder=Convert.ToDecimal("7.00") },
            new RefFacilityMortgageInterestType { Id=Guid.Parse("6ff0ae3c-1df8-47fa-9e9e-019429e696b9"), Code="13737", Description="Fully Amortizing Mortgage", SortOrder=Convert.ToDecimal("8.00") },
            new RefFacilityMortgageInterestType { Id=Guid.Parse("83133ce6-28e9-4f41-93b8-514fddf170f1"), Code="13738", Description="Graduated-payment Mortgage (GPM)", SortOrder=Convert.ToDecimal("9.00") },
            new RefFacilityMortgageInterestType { Id=Guid.Parse("bf237b0b-80a6-4b46-922c-55495530512b"), Code="13739", Description="Interest-only loan", SortOrder=Convert.ToDecimal("10.00") },
            new RefFacilityMortgageInterestType { Id=Guid.Parse("4d704a48-7bd6-4163-9efa-5519b67a9e16"), Code="13740", Description="Open-end Mortgage", SortOrder=Convert.ToDecimal("11.00") },
       };
   }
}
