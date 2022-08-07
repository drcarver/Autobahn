//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefInternetAccessTypeInResidenceList.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefInternetAccessTypeInResidence Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefInternetAccessTypeInResidenceModel"> List
         /// </summary>
        public static List<RefInternetAccessTypeInResidenceModel> RefInternetAccessTypeInResidenceList = new List<RefInternetAccessTypeInResidenceModel>
        {
            new RefInternetAccessTypeInResidence { Id=Guid.Parse("5f186b2d-166d-4f2e-b450-9336b206933f"), Code="CellularNetwork", Description="Cellular Network", Definition="The type of internet service used in the student's primary place of residence is a cellular network that creates a hot spot using a cell phone for additional device access or access to the internet is only available through a cellular device.", SortOrder=Convert.ToDecimal("1.00") },
            new RefInternetAccessTypeInResidence { Id=Guid.Parse("4d4f476a-8909-459d-b686-4b8cd2c70884"), Code="CommunityProvidedWi-Fi", Description="Community Provided Wi-Fi", Definition="The type of internet service used in the student's primary place of residence is community provided Wi-Fi.", SortOrder=Convert.ToDecimal("2.00") },
            new RefInternetAccessTypeInResidence { Id=Guid.Parse("ca4afee4-4439-49fc-bf42-197a3735248a"), Code="Dialup", Description="Dial-up", Definition="The type of internet service used in the student's primary place of residence is dial-up.", SortOrder=Convert.ToDecimal("3.00") },
            new RefInternetAccessTypeInResidence { Id=Guid.Parse("a566a2b6-5865-48e9-8509-dc84d94a3e85"), Code="HotSpot", Description="Hot Spot", Definition="The type of internet service used in the student's primary place of residence is a standalone hot spot device that is not a cell phone that allows for additional device access.", SortOrder=Convert.ToDecimal("4.00") },
            new RefInternetAccessTypeInResidence { Id=Guid.Parse("9d08abb3-6e69-49d6-8725-49dc7bba9587"), Code="None", Description="None", Definition="There is no internet service in the student's primary place of residence.", SortOrder=Convert.ToDecimal("5.00") },
            new RefInternetAccessTypeInResidence { Id=Guid.Parse("a5ee273f-7996-4b87-a1b3-a9a9d25fe1b1"), Code="ResidentialBroadband", Description="Residential Broadband", Definition="The type of internet service used in the student's primary place of residence is residential broadband.", SortOrder=Convert.ToDecimal("6.00") },
            new RefInternetAccessTypeInResidence { Id=Guid.Parse("095769fe-ca28-4b36-b69e-62188dde6f02"), Code="Satellite", Description="Satellite", Definition="The type of internet service used in the student's primary place of residence is satellite.", SortOrder=Convert.ToDecimal("7.00") },
            new RefInternetAccessTypeInResidence { Id=Guid.Parse("2675eac3-09c3-44e7-912a-7d51c305be10"), Code="Unknown", Description="Unknown", Definition="It is not known whether there is internet service in the student's primary place of residence.", SortOrder=Convert.ToDecimal("8.00") },
            new RefInternetAccessTypeInResidence { Id=Guid.Parse("f16a40bb-556b-4d39-b448-ba46a1093e92"), Code="Other", Description="Other", Definition="The type of internet service used in the student's primary place of residence is not yet defined.", SortOrder=Convert.ToDecimal("99.00") },
        };

        /// <summary>
        /// The Reference RefInternetAccessTypeInResidence Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefInternetAccessTypeInResidenceViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefInternetAccessTypeInResidence { Id=Guid.Parse("5f186b2d-166d-4f2e-b450-9336b206933f"), Description="Cellular Network", SortOrder=Convert.ToDecimal("1.00") },
            new RefInternetAccessTypeInResidence { Id=Guid.Parse("4d4f476a-8909-459d-b686-4b8cd2c70884"), Description="Community Provided Wi-Fi", SortOrder=Convert.ToDecimal("2.00") },
            new RefInternetAccessTypeInResidence { Id=Guid.Parse("ca4afee4-4439-49fc-bf42-197a3735248a"), Description="Dial-up", SortOrder=Convert.ToDecimal("3.00") },
            new RefInternetAccessTypeInResidence { Id=Guid.Parse("a566a2b6-5865-48e9-8509-dc84d94a3e85"), Description="Hot Spot", SortOrder=Convert.ToDecimal("4.00") },
            new RefInternetAccessTypeInResidence { Id=Guid.Parse("9d08abb3-6e69-49d6-8725-49dc7bba9587"), Description="None", SortOrder=Convert.ToDecimal("5.00") },
            new RefInternetAccessTypeInResidence { Id=Guid.Parse("a5ee273f-7996-4b87-a1b3-a9a9d25fe1b1"), Description="Residential Broadband", SortOrder=Convert.ToDecimal("6.00") },
            new RefInternetAccessTypeInResidence { Id=Guid.Parse("095769fe-ca28-4b36-b69e-62188dde6f02"), Description="Satellite", SortOrder=Convert.ToDecimal("7.00") },
            new RefInternetAccessTypeInResidence { Id=Guid.Parse("2675eac3-09c3-44e7-912a-7d51c305be10"), Description="Unknown", SortOrder=Convert.ToDecimal("8.00") },
            new RefInternetAccessTypeInResidence { Id=Guid.Parse("f16a40bb-556b-4d39-b448-ba46a1093e92"), Description="Other", SortOrder=Convert.ToDecimal("99.00") },
       };
   }
}
