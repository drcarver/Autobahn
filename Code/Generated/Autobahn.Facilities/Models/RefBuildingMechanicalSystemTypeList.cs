//**********************************************************
//* DomainName: Autobahn.Facilities
//* FileName:   RefBuildingMechanicalSystemTypeList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Facilities.Models
{
     /// <summary>
     /// The list of RefBuildingMechanicalSystemType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefBuildingMechanicalSystemTypeModel"> List
         /// </summary>
        public static List<RefBuildingMechanicalSystemTypeModel> RefBuildingMechanicalSystemTypeList = new List<RefBuildingMechanicalSystemTypeModel>
        {
            new RefBuildingMechanicalSystemType { Id=Guid.Parse("2aefd554-45ab-475a-83b7-107615b534c8"), Code="02455", Description="Air distribution system", Definition="The primary means by which air is circulated, freshened, and exhausted.", SortOrder=Convert.ToDecimal("1.00") },
            new RefBuildingMechanicalSystemType { Id=Guid.Parse("383752d7-d358-4278-a650-eb0fd10d9fe0"), Code="02454", Description="Cooling generation system", Definition="The type of mechanical systems and building designs used for cooling.", SortOrder=Convert.ToDecimal("2.00") },
            new RefBuildingMechanicalSystemType { Id=Guid.Parse("d434df63-3eb3-4c03-bfa3-a82a2894259c"), Code="02453", Description="Heating generation system", Definition="The method by which the heat is distributed and delivered throughout the room(s) or building.", SortOrder=Convert.ToDecimal("3.00") },
            new RefBuildingMechanicalSystemType { Id=Guid.Parse("761e7471-ad8f-4e17-b63b-ba7f6402a306"), Code="09999", Description="Other", Definition="Other is specified as the major manufactured systems required to operate a building.", SortOrder=Convert.ToDecimal("99.00") },
        };

        /// <summary>
        /// The Reference RefBuildingMechanicalSystemType Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefBuildingMechanicalSystemTypeViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefBuildingMechanicalSystemType { Id=Guid.Parse("2aefd554-45ab-475a-83b7-107615b534c8"), Description="Air distribution system", SortOrder=Convert.ToDecimal("1.00") },
            new RefBuildingMechanicalSystemType { Id=Guid.Parse("383752d7-d358-4278-a650-eb0fd10d9fe0"), Description="Cooling generation system", SortOrder=Convert.ToDecimal("2.00") },
            new RefBuildingMechanicalSystemType { Id=Guid.Parse("d434df63-3eb3-4c03-bfa3-a82a2894259c"), Description="Heating generation system", SortOrder=Convert.ToDecimal("3.00") },
            new RefBuildingMechanicalSystemType { Id=Guid.Parse("761e7471-ad8f-4e17-b63b-ba7f6402a306"), Description="Other", SortOrder=Convert.ToDecimal("99.00") },
       };
   }
}
