//**********************************************************
//* DomainName: Autobahn.AdultEducation
//* FileName:   RefCorrectionalEducationFacilityTypeList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.AdultEducation.Models
{
     /// <summary>
     /// The list of RefCorrectionalEducationFacilityType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefCorrectionalEducationFacilityType"> List
         /// </summary>
        public static List<RefCorrectionalEducationFacilityType> RefCorrectionalEducationFacilityTypeList = new List<RefCorrectionalEducationFacilityType>
        {
            new RefCorrectionalEducationFacilityType { Id=Guid.Parse("8c6fe7d4-be17-4fe8-9022-8d25ed4eea29"), Code="Prison", Description="Prison, Penitentiary or Correctional Institution", Definition="Prison, Penitentiary or Correctional Institution is specified as the  type of facility in which an inmate receives correctional education services.", SortOrder=Convert.ToDecimal("1.00") },
            new RefCorrectionalEducationFacilityType { Id=Guid.Parse("266184e2-b21e-414f-af79-489e88244918"), Code="Jail", Description="Jail", Definition="Jail is specified as the  type of facility in which an inmate receives correctional education services.", SortOrder=Convert.ToDecimal("3.00") },
            new RefCorrectionalEducationFacilityType { Id=Guid.Parse("33173fdc-82a9-4cd8-ac70-917da6be8fbd"), Code="JuvenileFacility", Description="Juvenile Facility", Definition="Juvenile Facility is specified as the  type of facility in which an inmate receives correctional education services.", SortOrder=Convert.ToDecimal("5.00") },
            new RefCorrectionalEducationFacilityType { Id=Guid.Parse("0306534c-fda6-4dd7-8057-d6df4de26bfd"), Code="CommunityCorrections", Description="Community Corrections", Definition="Community Corrections is specified as the  type of facility in which an inmate receives correctional education services.", SortOrder=Convert.ToDecimal("7.00") },
            new RefCorrectionalEducationFacilityType { Id=Guid.Parse("60371163-52b8-46bc-a79a-fe5c3ed3ad7c"), Code="Other", Description="Other Institution", Definition="Other Institution is specified as the  type of facility in which an inmate receives correctional education services.", SortOrder=Convert.ToDecimal("9.00") },
        };

        /// <summary>
        /// The RefCorrectionalEducationFacilityType Pick List
         /// </summary>
        public static List<RefCorrectionalEducationFacilityType> RefCorrectionalEducationFacilityTypePickList = new List<RefCorrectionalEducationFacilityType>
        {
            new RefCorrectionalEducationFacilityType { Id=Guid.Parse("8c6fe7d4-be17-4fe8-9022-8d25ed4eea29"), Code="Prison", Description="Prison, Penitentiary or Correctional Institution", SortOrder=Convert.ToDecimal("1.00") },
            new RefCorrectionalEducationFacilityType { Id=Guid.Parse("266184e2-b21e-414f-af79-489e88244918"), Code="Jail", Description="Jail", SortOrder=Convert.ToDecimal("3.00") },
            new RefCorrectionalEducationFacilityType { Id=Guid.Parse("33173fdc-82a9-4cd8-ac70-917da6be8fbd"), Code="JuvenileFacility", Description="Juvenile Facility", SortOrder=Convert.ToDecimal("5.00") },
            new RefCorrectionalEducationFacilityType { Id=Guid.Parse("0306534c-fda6-4dd7-8057-d6df4de26bfd"), Code="CommunityCorrections", Description="Community Corrections", SortOrder=Convert.ToDecimal("7.00") },
            new RefCorrectionalEducationFacilityType { Id=Guid.Parse("60371163-52b8-46bc-a79a-fe5c3ed3ad7c"), Code="Other", Description="Other Institution", SortOrder=Convert.ToDecimal("9.00") },
       };
   }
}
