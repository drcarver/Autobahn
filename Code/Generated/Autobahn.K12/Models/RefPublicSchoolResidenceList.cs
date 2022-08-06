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
        public static List<RefPublicSchoolResidence> RefPublicSchoolResidenceList = new List<RefPublicSchoolResidence>
        {
            new RefPublicSchoolResidence { Id=Guid.Parse("70ace184-3c50-4cf1-8c87-a78153e61e04"), Code="01652", Description="Resident of administrative unit and usual school attendance area", Definition="The person is/was a resident of administrative unit and usual school attendance area.", SortOrder=Convert.ToDecimal("1.00") },
            new RefPublicSchoolResidence { Id=Guid.Parse("baafedb3-c515-4755-8acf-7c78fa358343"), Code="01653", Description="Resident of administrative unit, but of other school attendance area", Definition="The person is/was a resident of administrative unit, but of other school attendance area.", SortOrder=Convert.ToDecimal("2.00") },
            new RefPublicSchoolResidence { Id=Guid.Parse("64a6ecf0-fe8b-4e46-9e35-f47f4462b532"), Code="01654", Description="Resident of this state, but not of this administrative unit", Definition="The person is/was a resident of this state, but not of this administrative unit.", SortOrder=Convert.ToDecimal("3.00") },
            new RefPublicSchoolResidence { Id=Guid.Parse("0f6ebee0-5849-49c7-b7e4-31f713d0dc39"), Code="01655", Description="Resident of an administrative unit that crosses state boundaries", Definition="The person is/was a resident of an administrative unit that crosses state boundaries.", SortOrder=Convert.ToDecimal("4.00") },
            new RefPublicSchoolResidence { Id=Guid.Parse("6576892f-df0e-4735-ab27-ea239a01b850"), Code="01656", Description="Resident of another state", Definition="The person is/was a resident of another state.", SortOrder=Convert.ToDecimal("5.00") },
        };

        /// <summary>
        /// The RefPublicSchoolResidence Pick List
         /// </summary>
        public static List<RefPublicSchoolResidence> RefPublicSchoolResidencePickList = new List<RefPublicSchoolResidence>
        {
            new RefPublicSchoolResidence { Id=Guid.Parse("70ace184-3c50-4cf1-8c87-a78153e61e04"), Code="01652", Description="Resident of administrative unit and usual school attendance area", SortOrder=Convert.ToDecimal("1.00") },
            new RefPublicSchoolResidence { Id=Guid.Parse("baafedb3-c515-4755-8acf-7c78fa358343"), Code="01653", Description="Resident of administrative unit, but of other school attendance area", SortOrder=Convert.ToDecimal("2.00") },
            new RefPublicSchoolResidence { Id=Guid.Parse("64a6ecf0-fe8b-4e46-9e35-f47f4462b532"), Code="01654", Description="Resident of this state, but not of this administrative unit", SortOrder=Convert.ToDecimal("3.00") },
            new RefPublicSchoolResidence { Id=Guid.Parse("0f6ebee0-5849-49c7-b7e4-31f713d0dc39"), Code="01655", Description="Resident of an administrative unit that crosses state boundaries", SortOrder=Convert.ToDecimal("4.00") },
            new RefPublicSchoolResidence { Id=Guid.Parse("6576892f-df0e-4735-ab27-ea239a01b850"), Code="01656", Description="Resident of another state", SortOrder=Convert.ToDecimal("5.00") },
       };
   }
}
