//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   RefPublicSchoolResidenceList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.K12.Models
{
     /// <summary>
     /// The list of RefPublicSchoolResidence Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefPublicSchoolResidence"> List
         /// </summary>
        public static List<RefPublicSchoolResidence> RefPublicSchoolResidenceList = new List<RefPublicSchoolResidence> =
        {
            new RefPublicSchoolResidence { Id=Guid.Parse("8c38ebb6-f4d7-4a58-a11c-a82134c9ea62"), Code="The person is/was a resident of administrative unit and usual school attendance area.", Description="01652", Definition="", SortOrder=0 },
            new RefPublicSchoolResidence { Id=Guid.Parse("05e23700-3d53-4bf8-ba3d-88bb868718d1"), Code="The person is/was a resident of administrative unit, but of other school attendance area.", Description="01653", Definition="", SortOrder=0 },
            new RefPublicSchoolResidence { Id=Guid.Parse("2a91a950-7ac4-4d5f-b0d1-268733225208"), Code="The person is/was a resident of this state, but not of this administrative unit.", Description="01654", Definition="", SortOrder=0 },
            new RefPublicSchoolResidence { Id=Guid.Parse("099238e6-30a5-4abc-8a0b-b6ff7f9e278b"), Code="The person is/was a resident of an administrative unit that crosses state boundaries.", Description="01655", Definition="", SortOrder=0 },
            new RefPublicSchoolResidence { Id=Guid.Parse("385cf297-cb83-4e7b-83c0-e25227749d6d"), Code="The person is/was a resident of another state.", Description="01656", Definition="", SortOrder=0 },
        };

        /// <summary>
        /// The RefPublicSchoolResidence Pick List
         /// </summary>
        public static List<RefPublicSchoolResidence> RefPublicSchoolResidencePickList = new List<RefPublicSchoolResidence> =
        {
            new RefPublicSchoolResidence { Id=Guid.Parse("8c38ebb6-f4d7-4a58-a11c-a82134c9ea62"), Code="The person is/was a resident of administrative unit and usual school attendance area.", SortOrder=0 },
            new RefPublicSchoolResidence { Id=Guid.Parse("05e23700-3d53-4bf8-ba3d-88bb868718d1"), Code="The person is/was a resident of administrative unit, but of other school attendance area.", SortOrder=0 },
            new RefPublicSchoolResidence { Id=Guid.Parse("2a91a950-7ac4-4d5f-b0d1-268733225208"), Code="The person is/was a resident of this state, but not of this administrative unit.", SortOrder=0 },
            new RefPublicSchoolResidence { Id=Guid.Parse("099238e6-30a5-4abc-8a0b-b6ff7f9e278b"), Code="The person is/was a resident of an administrative unit that crosses state boundaries.", SortOrder=0 },
            new RefPublicSchoolResidence { Id=Guid.Parse("385cf297-cb83-4e7b-83c0-e25227749d6d"), Code="The person is/was a resident of another state.", SortOrder=0 },
       };
   }
}
