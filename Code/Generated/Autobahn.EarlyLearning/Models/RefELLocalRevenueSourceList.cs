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
        /// The complete <see cref="RefELLocalRevenueSourceModel"> List
         /// </summary>
        public static List<RefELLocalRevenueSourceModel> RefELLocalRevenueSourceList = new List<RefELLocalRevenueSourceModel>
        {
            new RefELLocalRevenueSource { Id=Guid.Parse("80981e91-fd40-47d5-9579-64553cebd7a7"), Code="LEA", Description="LEA", Definition="LEA is a source of funds that originate at the local level, and not from the state or federal level, that contribute to EL program.", SortOrder=Convert.ToDecimal("1.00") },
            new RefELLocalRevenueSource { Id=Guid.Parse("6a7a7cda-6f19-49ef-adeb-737786db39fc"), Code="CountyLevyTax", Description="County Levy Tax", Definition="County Levy Tax is a source of funds that originate at the local level, and not from the state or federal level, that contribute to EL program.", SortOrder=Convert.ToDecimal("3.00") },
            new RefELLocalRevenueSource { Id=Guid.Parse("34242824-eeff-43a3-a19b-2bfd025e8ef8"), Code="Foundations", Description="Foundations", Definition="Foundations is a source of funds that originate at the local level, and not from the state or federal level, that contribute to EL program.", SortOrder=Convert.ToDecimal("5.00") },
            new RefELLocalRevenueSource { Id=Guid.Parse("4c351359-8c8c-447f-ad56-6b4596caca63"), Code="SpecialFundRaising", Description="Special Fund Raising", Definition="Special Fund Raising is a source of funds that originate at the local level, and not from the state or federal level, that contribute to EL program.", SortOrder=Convert.ToDecimal("7.00") },
            new RefELLocalRevenueSource { Id=Guid.Parse("5df89777-316d-4424-83ae-f99e0794b394"), Code="LocalGovernment", Description="Local Government", Definition="Local Government is a source of funds that originate at the local level, and not from the state or federal level, that contribute to EL program.", SortOrder=Convert.ToDecimal("9.00") },
            new RefELLocalRevenueSource { Id=Guid.Parse("114b0528-d1c6-47d1-92c0-9a7695918606"), Code="CashDonations", Description="Cash Donations", Definition="Cash Donations is a source of funds that originate at the local level, and not from the state or federal level, that contribute to EL program.", SortOrder=Convert.ToDecimal("11.00") },
            new RefELLocalRevenueSource { Id=Guid.Parse("0c56af75-90ce-4c8f-ba4f-3dd8fac02f87"), Code="UnitedWay", Description="United Way", Definition="United Way is a source of funds that originate at the local level, and not from the state or federal level, that contribute to EL program.", SortOrder=Convert.ToDecimal("13.00") },
            new RefELLocalRevenueSource { Id=Guid.Parse("0e75c746-5a66-438f-82a9-7b20755a67e0"), Code="PrivateInsurance", Description="Private Insurance", Definition="Private Insurance is a source of funds that originate at the local level, and not from the state or federal level, that contribute to EL program.", SortOrder=Convert.ToDecimal("15.00") },
            new RefELLocalRevenueSource { Id=Guid.Parse("2818c910-d975-4e9c-9379-c62998bb69cd"), Code="FamilyFees", Description="Family Fees", Definition="Family Fees is a source of funds that originate at the local level, and not from the state or federal level, that contribute to EL program.", SortOrder=Convert.ToDecimal("17.00") },
            new RefELLocalRevenueSource { Id=Guid.Parse("cf3bcd0b-6e44-4edf-ba33-de2e26ae2969"), Code="Other", Description="Other", Definition="A source of funds is in a category not yet included in CEDS..", SortOrder=Convert.ToDecimal("19.00") },
        };

        /// <summary>
        /// The Reference RefELLocalRevenueSource Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefELLocalRevenueSourceViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefELLocalRevenueSource { Id=Guid.Parse("80981e91-fd40-47d5-9579-64553cebd7a7"), Description="LEA", SortOrder=Convert.ToDecimal("1.00") },
            new RefELLocalRevenueSource { Id=Guid.Parse("6a7a7cda-6f19-49ef-adeb-737786db39fc"), Description="County Levy Tax", SortOrder=Convert.ToDecimal("3.00") },
            new RefELLocalRevenueSource { Id=Guid.Parse("34242824-eeff-43a3-a19b-2bfd025e8ef8"), Description="Foundations", SortOrder=Convert.ToDecimal("5.00") },
            new RefELLocalRevenueSource { Id=Guid.Parse("4c351359-8c8c-447f-ad56-6b4596caca63"), Description="Special Fund Raising", SortOrder=Convert.ToDecimal("7.00") },
            new RefELLocalRevenueSource { Id=Guid.Parse("5df89777-316d-4424-83ae-f99e0794b394"), Description="Local Government", SortOrder=Convert.ToDecimal("9.00") },
            new RefELLocalRevenueSource { Id=Guid.Parse("114b0528-d1c6-47d1-92c0-9a7695918606"), Description="Cash Donations", SortOrder=Convert.ToDecimal("11.00") },
            new RefELLocalRevenueSource { Id=Guid.Parse("0c56af75-90ce-4c8f-ba4f-3dd8fac02f87"), Description="United Way", SortOrder=Convert.ToDecimal("13.00") },
            new RefELLocalRevenueSource { Id=Guid.Parse("0e75c746-5a66-438f-82a9-7b20755a67e0"), Description="Private Insurance", SortOrder=Convert.ToDecimal("15.00") },
            new RefELLocalRevenueSource { Id=Guid.Parse("2818c910-d975-4e9c-9379-c62998bb69cd"), Description="Family Fees", SortOrder=Convert.ToDecimal("17.00") },
            new RefELLocalRevenueSource { Id=Guid.Parse("cf3bcd0b-6e44-4edf-ba33-de2e26ae2969"), Description="Other", SortOrder=Convert.ToDecimal("19.00") },
       };
   }
}
