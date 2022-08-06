//**********************************************************
//* DomainName: Autobahn.Facilities
//* FileName:   RefFacilitiesMandateAuthorityTypeList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Facilities.Models
{
     /// <summary>
     /// The list of RefFacilitiesMandateAuthorityType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefFacilitiesMandateAuthorityType"> List
         /// </summary>
        public static List<RefFacilitiesMandateAuthorityType> RefFacilitiesMandateAuthorityTypeList = new List<RefFacilitiesMandateAuthorityType> =
        {
            new RefFacilitiesMandateAuthorityType { Id=Guid.Parse("8d907427-a845-4a12-a5ce-08613e13cc49"), Code="District/Local is specified as the authority that mandates through law, regulation, or standard that pertains to a specific mandate.", Description="13390", Definition="", SortOrder=0 },
            new RefFacilitiesMandateAuthorityType { Id=Guid.Parse("e7c4c1f7-7871-4db8-9105-5a1e81f61856"), Code="Federal is specified as the authority that mandates through law, regulation, or standard that pertains to a specific mandate.", Description="00859", Definition="", SortOrder=0 },
            new RefFacilitiesMandateAuthorityType { Id=Guid.Parse("ae32fcd2-ca98-4be3-9e77-928474580780"), Code="State is specified as the authority that mandates through law, regulation, or standard that pertains to a specific mandate.", Description="00391", Definition="", SortOrder=0 },
        };

        /// <summary>
        /// The RefFacilitiesMandateAuthorityType Pick List
         /// </summary>
        public static List<RefFacilitiesMandateAuthorityType> RefFacilitiesMandateAuthorityTypePickList = new List<RefFacilitiesMandateAuthorityType> =
        {
            new RefFacilitiesMandateAuthorityType { Id=Guid.Parse("8d907427-a845-4a12-a5ce-08613e13cc49"), Code="District/Local is specified as the authority that mandates through law, regulation, or standard that pertains to a specific mandate.", SortOrder=0 },
            new RefFacilitiesMandateAuthorityType { Id=Guid.Parse("e7c4c1f7-7871-4db8-9105-5a1e81f61856"), Code="Federal is specified as the authority that mandates through law, regulation, or standard that pertains to a specific mandate.", SortOrder=0 },
            new RefFacilitiesMandateAuthorityType { Id=Guid.Parse("ae32fcd2-ca98-4be3-9e77-928474580780"), Code="State is specified as the authority that mandates through law, regulation, or standard that pertains to a specific mandate.", SortOrder=0 },
       };
   }
}
