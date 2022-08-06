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
        public static List<RefCorrectionalEducationFacilityType> RefCorrectionalEducationFacilityTypeList = new List<RefCorrectionalEducationFacilityType> =
        {
            new RefCorrectionalEducationFacilityType { Id=Guid.Parse("9db4328e-79c9-45f9-b0b4-c17345b9303a"), Code="Prison, Penitentiary or Correctional Institution is specified as the  type of facility in which an inmate receives correctional education services.", Description="Prison", Definition="", SortOrder=0 },
            new RefCorrectionalEducationFacilityType { Id=Guid.Parse("218c86b2-665e-467f-83a0-adfcc940d0b6"), Code="Jail is specified as the  type of facility in which an inmate receives correctional education services.", Description="Jail", Definition="", SortOrder=0 },
            new RefCorrectionalEducationFacilityType { Id=Guid.Parse("47e2aa98-296c-4213-b5cb-a48f0cae9268"), Code="Juvenile Facility is specified as the  type of facility in which an inmate receives correctional education services.", Description="JuvenileFacility", Definition="", SortOrder=0 },
            new RefCorrectionalEducationFacilityType { Id=Guid.Parse("9674ff4a-618b-4239-b867-566378768df1"), Code="Community Corrections is specified as the  type of facility in which an inmate receives correctional education services.", Description="CommunityCorrections", Definition="", SortOrder=0 },
            new RefCorrectionalEducationFacilityType { Id=Guid.Parse("3b50523b-3778-43e0-9d01-a39b2bb742f8"), Code="Other Institution is specified as the  type of facility in which an inmate receives correctional education services.", Description="Other", Definition="", SortOrder=0 },
        };

        /// <summary>
        /// The RefCorrectionalEducationFacilityType Pick List
         /// </summary>
        public static List<RefCorrectionalEducationFacilityType> RefCorrectionalEducationFacilityTypePickList = new List<RefCorrectionalEducationFacilityType> =
        {
            new RefCorrectionalEducationFacilityType { Id=Guid.Parse("9db4328e-79c9-45f9-b0b4-c17345b9303a"), Code="Prison, Penitentiary or Correctional Institution is specified as the  type of facility in which an inmate receives correctional education services.", SortOrder=0 },
            new RefCorrectionalEducationFacilityType { Id=Guid.Parse("218c86b2-665e-467f-83a0-adfcc940d0b6"), Code="Jail is specified as the  type of facility in which an inmate receives correctional education services.", SortOrder=0 },
            new RefCorrectionalEducationFacilityType { Id=Guid.Parse("47e2aa98-296c-4213-b5cb-a48f0cae9268"), Code="Juvenile Facility is specified as the  type of facility in which an inmate receives correctional education services.", SortOrder=0 },
            new RefCorrectionalEducationFacilityType { Id=Guid.Parse("9674ff4a-618b-4239-b867-566378768df1"), Code="Community Corrections is specified as the  type of facility in which an inmate receives correctional education services.", SortOrder=0 },
            new RefCorrectionalEducationFacilityType { Id=Guid.Parse("3b50523b-3778-43e0-9d01-a39b2bb742f8"), Code="Other Institution is specified as the  type of facility in which an inmate receives correctional education services.", SortOrder=0 },
       };
   }
}
