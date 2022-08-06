//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefInternetAccessTypeInResidenceList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefInternetAccessTypeInResidence Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefInternetAccessTypeInResidence"> List
         /// </summary>
        public static List<RefInternetAccessTypeInResidence> RefInternetAccessTypeInResidenceList = new List<RefInternetAccessTypeInResidence>
        {
            new RefInternetAccessTypeInResidence { Id=Guid.Parse("98d50152-1e19-4b86-99cd-0277b8962092"), Code="CellularNetwork", Description="Cellular Network", Definition="The type of internet service used in the student's primary place of residence is a cellular network that creates a hot spot using a cell phone for additional device access or access to the internet is only available through a cellular device.", SortOrder=Convert.ToDecimal("1.00") },
            new RefInternetAccessTypeInResidence { Id=Guid.Parse("46af88d3-7f5f-4875-9bf2-2db12e8526a6"), Code="CommunityProvidedWi-Fi", Description="Community Provided Wi-Fi", Definition="The type of internet service used in the student's primary place of residence is community provided Wi-Fi.", SortOrder=Convert.ToDecimal("2.00") },
            new RefInternetAccessTypeInResidence { Id=Guid.Parse("afe60319-a6f6-4331-83a2-1eca79922ad7"), Code="Dialup", Description="Dial-up", Definition="The type of internet service used in the student's primary place of residence is dial-up.", SortOrder=Convert.ToDecimal("3.00") },
            new RefInternetAccessTypeInResidence { Id=Guid.Parse("79d71d7b-2a22-45b9-9025-8673362bdad8"), Code="HotSpot", Description="Hot Spot", Definition="The type of internet service used in the student's primary place of residence is a standalone hot spot device that is not a cell phone that allows for additional device access.", SortOrder=Convert.ToDecimal("4.00") },
            new RefInternetAccessTypeInResidence { Id=Guid.Parse("a22d97cd-ebeb-4d01-9f3c-c7f381787379"), Code="None", Description="None", Definition="There is no internet service in the student's primary place of residence.", SortOrder=Convert.ToDecimal("5.00") },
            new RefInternetAccessTypeInResidence { Id=Guid.Parse("7ccf58f0-7c0b-4d86-8fbc-ccbf6c641b3b"), Code="ResidentialBroadband", Description="Residential Broadband", Definition="The type of internet service used in the student's primary place of residence is residential broadband.", SortOrder=Convert.ToDecimal("6.00") },
            new RefInternetAccessTypeInResidence { Id=Guid.Parse("d1fdf1a8-9880-4149-8636-383f5b467ebc"), Code="Satellite", Description="Satellite", Definition="The type of internet service used in the student's primary place of residence is satellite.", SortOrder=Convert.ToDecimal("7.00") },
            new RefInternetAccessTypeInResidence { Id=Guid.Parse("832cc3e0-2cd0-4b9f-9d95-2b58c4da7870"), Code="Unknown", Description="Unknown", Definition="It is not known whether there is internet service in the student's primary place of residence.", SortOrder=Convert.ToDecimal("8.00") },
            new RefInternetAccessTypeInResidence { Id=Guid.Parse("13c08aaa-4f79-49fe-97fd-8fd11f1f7ba0"), Code="Other", Description="Other", Definition="The type of internet service used in the student's primary place of residence is not yet defined.", SortOrder=Convert.ToDecimal("99.00") },
        };

        /// <summary>
        /// The RefInternetAccessTypeInResidence Pick List
         /// </summary>
        public static List<RefInternetAccessTypeInResidence> RefInternetAccessTypeInResidencePickList = new List<RefInternetAccessTypeInResidence>
        {
            new RefInternetAccessTypeInResidence { Id=Guid.Parse("98d50152-1e19-4b86-99cd-0277b8962092"), Code="CellularNetwork", Description="Cellular Network", SortOrder=Convert.ToDecimal("1.00") },
            new RefInternetAccessTypeInResidence { Id=Guid.Parse("46af88d3-7f5f-4875-9bf2-2db12e8526a6"), Code="CommunityProvidedWi-Fi", Description="Community Provided Wi-Fi", SortOrder=Convert.ToDecimal("2.00") },
            new RefInternetAccessTypeInResidence { Id=Guid.Parse("afe60319-a6f6-4331-83a2-1eca79922ad7"), Code="Dialup", Description="Dial-up", SortOrder=Convert.ToDecimal("3.00") },
            new RefInternetAccessTypeInResidence { Id=Guid.Parse("79d71d7b-2a22-45b9-9025-8673362bdad8"), Code="HotSpot", Description="Hot Spot", SortOrder=Convert.ToDecimal("4.00") },
            new RefInternetAccessTypeInResidence { Id=Guid.Parse("a22d97cd-ebeb-4d01-9f3c-c7f381787379"), Code="None", Description="None", SortOrder=Convert.ToDecimal("5.00") },
            new RefInternetAccessTypeInResidence { Id=Guid.Parse("7ccf58f0-7c0b-4d86-8fbc-ccbf6c641b3b"), Code="ResidentialBroadband", Description="Residential Broadband", SortOrder=Convert.ToDecimal("6.00") },
            new RefInternetAccessTypeInResidence { Id=Guid.Parse("d1fdf1a8-9880-4149-8636-383f5b467ebc"), Code="Satellite", Description="Satellite", SortOrder=Convert.ToDecimal("7.00") },
            new RefInternetAccessTypeInResidence { Id=Guid.Parse("832cc3e0-2cd0-4b9f-9d95-2b58c4da7870"), Code="Unknown", Description="Unknown", SortOrder=Convert.ToDecimal("8.00") },
            new RefInternetAccessTypeInResidence { Id=Guid.Parse("13c08aaa-4f79-49fe-97fd-8fd11f1f7ba0"), Code="Other", Description="Other", SortOrder=Convert.ToDecimal("99.00") },
       };
   }
}
