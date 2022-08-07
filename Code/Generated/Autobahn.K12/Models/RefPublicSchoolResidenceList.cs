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
        /// The complete <see cref="RefPublicSchoolResidenceModel"> List
         /// </summary>
        public static List<RefPublicSchoolResidenceModel> RefPublicSchoolResidenceList = new List<RefPublicSchoolResidenceModel>
        {
            new RefPublicSchoolResidence { Id=Guid.Parse("fb8bc4be-3bb3-4e16-97bf-fafd9a1b3f87"), Code="01652", Description="Resident of administrative unit and usual school attendance area", Definition="The person is/was a resident of administrative unit and usual school attendance area.", SortOrder=Convert.ToDecimal("1.00") },
            new RefPublicSchoolResidence { Id=Guid.Parse("abc267d6-1a8c-491c-99cd-3ae1d0265558"), Code="01653", Description="Resident of administrative unit, but of other school attendance area", Definition="The person is/was a resident of administrative unit, but of other school attendance area.", SortOrder=Convert.ToDecimal("2.00") },
            new RefPublicSchoolResidence { Id=Guid.Parse("e8e1f857-6ad7-4ca9-8964-d76b95f6c070"), Code="01654", Description="Resident of this state, but not of this administrative unit", Definition="The person is/was a resident of this state, but not of this administrative unit.", SortOrder=Convert.ToDecimal("3.00") },
            new RefPublicSchoolResidence { Id=Guid.Parse("a72f6afd-e81e-45bc-8e29-ad0fa4cd0245"), Code="01655", Description="Resident of an administrative unit that crosses state boundaries", Definition="The person is/was a resident of an administrative unit that crosses state boundaries.", SortOrder=Convert.ToDecimal("4.00") },
            new RefPublicSchoolResidence { Id=Guid.Parse("3dc1cd67-895b-42b8-80e8-91ea55583b92"), Code="01656", Description="Resident of another state", Definition="The person is/was a resident of another state.", SortOrder=Convert.ToDecimal("5.00") },
        };

        /// <summary>
        /// The Reference RefPublicSchoolResidence Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefPublicSchoolResidenceViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefPublicSchoolResidence { Id=Guid.Parse("fb8bc4be-3bb3-4e16-97bf-fafd9a1b3f87"), Description="Resident of administrative unit and usual school attendance area", SortOrder=Convert.ToDecimal("1.00") },
            new RefPublicSchoolResidence { Id=Guid.Parse("abc267d6-1a8c-491c-99cd-3ae1d0265558"), Description="Resident of administrative unit, but of other school attendance area", SortOrder=Convert.ToDecimal("2.00") },
            new RefPublicSchoolResidence { Id=Guid.Parse("e8e1f857-6ad7-4ca9-8964-d76b95f6c070"), Description="Resident of this state, but not of this administrative unit", SortOrder=Convert.ToDecimal("3.00") },
            new RefPublicSchoolResidence { Id=Guid.Parse("a72f6afd-e81e-45bc-8e29-ad0fa4cd0245"), Description="Resident of an administrative unit that crosses state boundaries", SortOrder=Convert.ToDecimal("4.00") },
            new RefPublicSchoolResidence { Id=Guid.Parse("3dc1cd67-895b-42b8-80e8-91ea55583b92"), Description="Resident of another state", SortOrder=Convert.ToDecimal("5.00") },
       };
   }
}
