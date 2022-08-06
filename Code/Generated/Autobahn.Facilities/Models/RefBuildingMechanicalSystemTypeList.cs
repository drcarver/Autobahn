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
        /// The complete <see cref="RefBuildingMechanicalSystemType"> List
         /// </summary>
        public static List<RefBuildingMechanicalSystemType> RefBuildingMechanicalSystemTypeList = new List<RefBuildingMechanicalSystemType>
        {
            new RefBuildingMechanicalSystemType { Id=Guid.Parse("ff9ad732-e42d-4ed4-882c-ca2cc3906f36"), Code="02455", Description="Air distribution system", Definition="The primary means by which air is circulated, freshened, and exhausted.", SortOrder=Convert.ToDecimal("1.00") },
            new RefBuildingMechanicalSystemType { Id=Guid.Parse("8a778e90-3f35-4f49-97d8-329afa768354"), Code="02454", Description="Cooling generation system", Definition="The type of mechanical systems and building designs used for cooling.", SortOrder=Convert.ToDecimal("2.00") },
            new RefBuildingMechanicalSystemType { Id=Guid.Parse("40c61064-0a18-4ce5-9acc-1d40da02bc59"), Code="02453", Description="Heating generation system", Definition="The method by which the heat is distributed and delivered throughout the room(s) or building.", SortOrder=Convert.ToDecimal("3.00") },
            new RefBuildingMechanicalSystemType { Id=Guid.Parse("eb36f338-0cad-4bb5-9529-0485083d9625"), Code="09999", Description="Other", Definition="Other is specified as the major manufactured systems required to operate a building.", SortOrder=Convert.ToDecimal("99.00") },
        };

        /// <summary>
        /// The RefBuildingMechanicalSystemType Pick List
         /// </summary>
        public static List<RefBuildingMechanicalSystemType> RefBuildingMechanicalSystemTypePickList = new List<RefBuildingMechanicalSystemType>
        {
            new RefBuildingMechanicalSystemType { Id=Guid.Parse("ff9ad732-e42d-4ed4-882c-ca2cc3906f36"), Code="02455", Description="Air distribution system", SortOrder=Convert.ToDecimal("1.00") },
            new RefBuildingMechanicalSystemType { Id=Guid.Parse("8a778e90-3f35-4f49-97d8-329afa768354"), Code="02454", Description="Cooling generation system", SortOrder=Convert.ToDecimal("2.00") },
            new RefBuildingMechanicalSystemType { Id=Guid.Parse("40c61064-0a18-4ce5-9acc-1d40da02bc59"), Code="02453", Description="Heating generation system", SortOrder=Convert.ToDecimal("3.00") },
            new RefBuildingMechanicalSystemType { Id=Guid.Parse("eb36f338-0cad-4bb5-9529-0485083d9625"), Code="09999", Description="Other", SortOrder=Convert.ToDecimal("99.00") },
       };
   }
}
