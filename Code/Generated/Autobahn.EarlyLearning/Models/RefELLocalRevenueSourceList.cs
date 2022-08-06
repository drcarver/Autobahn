//**********************************************************
//* DomainName: Autobahn.EarlyLearning
//* FileName:   RefELLocalRevenueSourceList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.EarlyLearning.Models
{
     /// <summary>
     /// The list of RefELLocalRevenueSource Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefELLocalRevenueSource"> List
         /// </summary>
        public static List<RefELLocalRevenueSource> RefELLocalRevenueSourceList = new List<RefELLocalRevenueSource>
        {
            new RefELLocalRevenueSource { Id=Guid.Parse("505a9220-91e0-4acf-be6f-e229747646f5"), Code="LEA", Description="LEA", Definition="LEA is a source of funds that originate at the local level, and not from the state or federal level, that contribute to EL program.", SortOrder=Convert.ToDecimal("1.00") },
            new RefELLocalRevenueSource { Id=Guid.Parse("2ddbf0b8-73e3-4980-9bc3-a49cd127ddae"), Code="CountyLevyTax", Description="County Levy Tax", Definition="County Levy Tax is a source of funds that originate at the local level, and not from the state or federal level, that contribute to EL program.", SortOrder=Convert.ToDecimal("3.00") },
            new RefELLocalRevenueSource { Id=Guid.Parse("906dc1a1-c049-438d-ac46-cc9fb22ff056"), Code="Foundations", Description="Foundations", Definition="Foundations is a source of funds that originate at the local level, and not from the state or federal level, that contribute to EL program.", SortOrder=Convert.ToDecimal("5.00") },
            new RefELLocalRevenueSource { Id=Guid.Parse("54d8efc2-5854-4e7c-a213-b3bf87a12e98"), Code="SpecialFundRaising", Description="Special Fund Raising", Definition="Special Fund Raising is a source of funds that originate at the local level, and not from the state or federal level, that contribute to EL program.", SortOrder=Convert.ToDecimal("7.00") },
            new RefELLocalRevenueSource { Id=Guid.Parse("41383539-baf1-4c1b-9c69-5e3edf10a574"), Code="LocalGovernment", Description="Local Government", Definition="Local Government is a source of funds that originate at the local level, and not from the state or federal level, that contribute to EL program.", SortOrder=Convert.ToDecimal("9.00") },
            new RefELLocalRevenueSource { Id=Guid.Parse("b0aefb45-a75a-42bf-9a4d-9534fbbfbb10"), Code="CashDonations", Description="Cash Donations", Definition="Cash Donations is a source of funds that originate at the local level, and not from the state or federal level, that contribute to EL program.", SortOrder=Convert.ToDecimal("11.00") },
            new RefELLocalRevenueSource { Id=Guid.Parse("5f73c1ce-1207-4e18-98f5-a08b8327232c"), Code="UnitedWay", Description="United Way", Definition="United Way is a source of funds that originate at the local level, and not from the state or federal level, that contribute to EL program.", SortOrder=Convert.ToDecimal("13.00") },
            new RefELLocalRevenueSource { Id=Guid.Parse("b28bf497-5ea6-4938-bbc0-1d93c95e3fee"), Code="PrivateInsurance", Description="Private Insurance", Definition="Private Insurance is a source of funds that originate at the local level, and not from the state or federal level, that contribute to EL program.", SortOrder=Convert.ToDecimal("15.00") },
            new RefELLocalRevenueSource { Id=Guid.Parse("499fe395-9b4b-4c39-8dc8-c97c545e8482"), Code="FamilyFees", Description="Family Fees", Definition="Family Fees is a source of funds that originate at the local level, and not from the state or federal level, that contribute to EL program.", SortOrder=Convert.ToDecimal("17.00") },
            new RefELLocalRevenueSource { Id=Guid.Parse("b15908d4-05c4-4cce-8070-b3bbe8a4f963"), Code="Other", Description="Other", Definition="A source of funds is in a category not yet included in CEDS..", SortOrder=Convert.ToDecimal("19.00") },
        };

        /// <summary>
        /// The RefELLocalRevenueSource Pick List
         /// </summary>
        public static List<RefELLocalRevenueSource> RefELLocalRevenueSourcePickList = new List<RefELLocalRevenueSource>
        {
            new RefELLocalRevenueSource { Id=Guid.Parse("505a9220-91e0-4acf-be6f-e229747646f5"), Code="LEA", Description="LEA", SortOrder=Convert.ToDecimal("1.00") },
            new RefELLocalRevenueSource { Id=Guid.Parse("2ddbf0b8-73e3-4980-9bc3-a49cd127ddae"), Code="CountyLevyTax", Description="County Levy Tax", SortOrder=Convert.ToDecimal("3.00") },
            new RefELLocalRevenueSource { Id=Guid.Parse("906dc1a1-c049-438d-ac46-cc9fb22ff056"), Code="Foundations", Description="Foundations", SortOrder=Convert.ToDecimal("5.00") },
            new RefELLocalRevenueSource { Id=Guid.Parse("54d8efc2-5854-4e7c-a213-b3bf87a12e98"), Code="SpecialFundRaising", Description="Special Fund Raising", SortOrder=Convert.ToDecimal("7.00") },
            new RefELLocalRevenueSource { Id=Guid.Parse("41383539-baf1-4c1b-9c69-5e3edf10a574"), Code="LocalGovernment", Description="Local Government", SortOrder=Convert.ToDecimal("9.00") },
            new RefELLocalRevenueSource { Id=Guid.Parse("b0aefb45-a75a-42bf-9a4d-9534fbbfbb10"), Code="CashDonations", Description="Cash Donations", SortOrder=Convert.ToDecimal("11.00") },
            new RefELLocalRevenueSource { Id=Guid.Parse("5f73c1ce-1207-4e18-98f5-a08b8327232c"), Code="UnitedWay", Description="United Way", SortOrder=Convert.ToDecimal("13.00") },
            new RefELLocalRevenueSource { Id=Guid.Parse("b28bf497-5ea6-4938-bbc0-1d93c95e3fee"), Code="PrivateInsurance", Description="Private Insurance", SortOrder=Convert.ToDecimal("15.00") },
            new RefELLocalRevenueSource { Id=Guid.Parse("499fe395-9b4b-4c39-8dc8-c97c545e8482"), Code="FamilyFees", Description="Family Fees", SortOrder=Convert.ToDecimal("17.00") },
            new RefELLocalRevenueSource { Id=Guid.Parse("b15908d4-05c4-4cce-8070-b3bbe8a4f963"), Code="Other", Description="Other", SortOrder=Convert.ToDecimal("19.00") },
       };
   }
}
