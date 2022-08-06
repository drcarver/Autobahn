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
        public static List<RefInternetAccessTypeInResidence> RefInternetAccessTypeInResidenceList = new List<RefInternetAccessTypeInResidence> =
        {
            new RefInternetAccessTypeInResidence { Id=Guid.Parse("fb320c73-5c05-4086-a3c8-c6a696325263"), Code="The type of internet service used in the student's primary place of residence is a cellular network that creates a hot spot using a cell phone for additional device access or access to the internet is only available through a cellular device.", Description="CellularNetwork", Definition="", SortOrder=0 },
            new RefInternetAccessTypeInResidence { Id=Guid.Parse("2286f90f-9c27-47be-97b1-ea4e848a4f22"), Code="The type of internet service used in the student's primary place of residence is community provided Wi-Fi.", Description="CommunityProvidedWi-Fi", Definition="", SortOrder=0 },
            new RefInternetAccessTypeInResidence { Id=Guid.Parse("bb526c38-79aa-4994-aed0-3df05ba030dd"), Code="The type of internet service used in the student's primary place of residence is dial-up.", Description="Dialup", Definition="", SortOrder=0 },
            new RefInternetAccessTypeInResidence { Id=Guid.Parse("22fb7720-d0fb-4c3c-93f7-c44ab4c19e2f"), Code="The type of internet service used in the student's primary place of residence is a standalone hot spot device that is not a cell phone that allows for additional device access.", Description="HotSpot", Definition="", SortOrder=0 },
            new RefInternetAccessTypeInResidence { Id=Guid.Parse("9bd9f333-60ef-4f39-8924-1ef55479f503"), Code="There is no internet service in the student's primary place of residence.", Description="None", Definition="", SortOrder=0 },
            new RefInternetAccessTypeInResidence { Id=Guid.Parse("4d2f2e55-e732-4173-a186-95d76f179938"), Code="The type of internet service used in the student's primary place of residence is residential broadband.", Description="ResidentialBroadband", Definition="", SortOrder=0 },
            new RefInternetAccessTypeInResidence { Id=Guid.Parse("f43d7fad-5959-49a1-8d72-e8f46d68935c"), Code="The type of internet service used in the student's primary place of residence is satellite.", Description="Satellite", Definition="", SortOrder=0 },
            new RefInternetAccessTypeInResidence { Id=Guid.Parse("ddd41249-762f-4ce9-82d0-bb4bbcbc405f"), Code="It is not known whether there is internet service in the student's primary place of residence.", Description="Unknown", Definition="", SortOrder=0 },
            new RefInternetAccessTypeInResidence { Id=Guid.Parse("e538fd62-65dd-435f-a493-0694ed2515fa"), Code="The type of internet service used in the student's primary place of residence is not yet defined.", Description="Other", Definition="", SortOrder=0 },
        };

        /// <summary>
        /// The RefInternetAccessTypeInResidence Pick List
         /// </summary>
        public static List<RefInternetAccessTypeInResidence> RefInternetAccessTypeInResidencePickList = new List<RefInternetAccessTypeInResidence> =
        {
            new RefInternetAccessTypeInResidence { Id=Guid.Parse("fb320c73-5c05-4086-a3c8-c6a696325263"), Code="The type of internet service used in the student's primary place of residence is a cellular network that creates a hot spot using a cell phone for additional device access or access to the internet is only available through a cellular device.", SortOrder=0 },
            new RefInternetAccessTypeInResidence { Id=Guid.Parse("2286f90f-9c27-47be-97b1-ea4e848a4f22"), Code="The type of internet service used in the student's primary place of residence is community provided Wi-Fi.", SortOrder=0 },
            new RefInternetAccessTypeInResidence { Id=Guid.Parse("bb526c38-79aa-4994-aed0-3df05ba030dd"), Code="The type of internet service used in the student's primary place of residence is dial-up.", SortOrder=0 },
            new RefInternetAccessTypeInResidence { Id=Guid.Parse("22fb7720-d0fb-4c3c-93f7-c44ab4c19e2f"), Code="The type of internet service used in the student's primary place of residence is a standalone hot spot device that is not a cell phone that allows for additional device access.", SortOrder=0 },
            new RefInternetAccessTypeInResidence { Id=Guid.Parse("9bd9f333-60ef-4f39-8924-1ef55479f503"), Code="There is no internet service in the student's primary place of residence.", SortOrder=0 },
            new RefInternetAccessTypeInResidence { Id=Guid.Parse("4d2f2e55-e732-4173-a186-95d76f179938"), Code="The type of internet service used in the student's primary place of residence is residential broadband.", SortOrder=0 },
            new RefInternetAccessTypeInResidence { Id=Guid.Parse("f43d7fad-5959-49a1-8d72-e8f46d68935c"), Code="The type of internet service used in the student's primary place of residence is satellite.", SortOrder=0 },
            new RefInternetAccessTypeInResidence { Id=Guid.Parse("ddd41249-762f-4ce9-82d0-bb4bbcbc405f"), Code="It is not known whether there is internet service in the student's primary place of residence.", SortOrder=0 },
            new RefInternetAccessTypeInResidence { Id=Guid.Parse("e538fd62-65dd-435f-a493-0694ed2515fa"), Code="The type of internet service used in the student's primary place of residence is not yet defined.", SortOrder=0 },
       };
   }
}
