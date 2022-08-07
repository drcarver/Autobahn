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
        /// The complete <see cref="RefCorrectionalEducationFacilityTypeModel"> List
         /// </summary>
        public static List<RefCorrectionalEducationFacilityTypeModel> RefCorrectionalEducationFacilityTypeList = new List<RefCorrectionalEducationFacilityTypeModel>
        {
            new RefCorrectionalEducationFacilityType { Id=Guid.Parse("5ec9e8d1-7e4b-40d1-9b15-a1711e21cfd4"), Code="Prison", Description="Prison, Penitentiary or Correctional Institution", Definition="Prison, Penitentiary or Correctional Institution is specified as the  type of facility in which an inmate receives correctional education services.", SortOrder=Convert.ToDecimal("1.00") },
            new RefCorrectionalEducationFacilityType { Id=Guid.Parse("7d57d64f-9d18-4691-9ce7-38f968a730b0"), Code="Jail", Description="Jail", Definition="Jail is specified as the  type of facility in which an inmate receives correctional education services.", SortOrder=Convert.ToDecimal("3.00") },
            new RefCorrectionalEducationFacilityType { Id=Guid.Parse("ab3886df-2ddf-4a90-a5a7-c85ed18be3dd"), Code="JuvenileFacility", Description="Juvenile Facility", Definition="Juvenile Facility is specified as the  type of facility in which an inmate receives correctional education services.", SortOrder=Convert.ToDecimal("5.00") },
            new RefCorrectionalEducationFacilityType { Id=Guid.Parse("b9000452-1abd-4e59-88c5-fd6ea5700775"), Code="CommunityCorrections", Description="Community Corrections", Definition="Community Corrections is specified as the  type of facility in which an inmate receives correctional education services.", SortOrder=Convert.ToDecimal("7.00") },
            new RefCorrectionalEducationFacilityType { Id=Guid.Parse("a303d870-70a5-4488-be0c-d4c6fae45f39"), Code="Other", Description="Other Institution", Definition="Other Institution is specified as the  type of facility in which an inmate receives correctional education services.", SortOrder=Convert.ToDecimal("9.00") },
        };

        /// <summary>
        /// The Reference RefCorrectionalEducationFacilityType Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefCorrectionalEducationFacilityTypeViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefCorrectionalEducationFacilityType { Id=Guid.Parse("5ec9e8d1-7e4b-40d1-9b15-a1711e21cfd4"), Description="Prison, Penitentiary or Correctional Institution", SortOrder=Convert.ToDecimal("1.00") },
            new RefCorrectionalEducationFacilityType { Id=Guid.Parse("7d57d64f-9d18-4691-9ce7-38f968a730b0"), Description="Jail", SortOrder=Convert.ToDecimal("3.00") },
            new RefCorrectionalEducationFacilityType { Id=Guid.Parse("ab3886df-2ddf-4a90-a5a7-c85ed18be3dd"), Description="Juvenile Facility", SortOrder=Convert.ToDecimal("5.00") },
            new RefCorrectionalEducationFacilityType { Id=Guid.Parse("b9000452-1abd-4e59-88c5-fd6ea5700775"), Description="Community Corrections", SortOrder=Convert.ToDecimal("7.00") },
            new RefCorrectionalEducationFacilityType { Id=Guid.Parse("a303d870-70a5-4488-be0c-d4c6fae45f39"), Description="Other Institution", SortOrder=Convert.ToDecimal("9.00") },
       };
   }
}
