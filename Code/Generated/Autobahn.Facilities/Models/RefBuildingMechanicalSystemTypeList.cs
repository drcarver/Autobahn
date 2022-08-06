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
        public static List<RefBuildingMechanicalSystemType> RefBuildingMechanicalSystemTypeList = new List<RefBuildingMechanicalSystemType> =
        {
            new RefBuildingMechanicalSystemType { Id=Guid.Parse("5a6fccfa-e42a-4d59-8016-d4fcb14e484e"), Code="The primary means by which air is circulated, freshened, and exhausted.", Description="02455", Definition="", SortOrder=0 },
            new RefBuildingMechanicalSystemType { Id=Guid.Parse("32b3d63e-a5f9-4607-a953-ba261c6216fc"), Code="The type of mechanical systems and building designs used for cooling.", Description="02454", Definition="", SortOrder=0 },
            new RefBuildingMechanicalSystemType { Id=Guid.Parse("f5cb6db5-3068-4648-a803-a5aa54e86030"), Code="The method by which the heat is distributed and delivered throughout the room(s) or building.", Description="02453", Definition="", SortOrder=0 },
            new RefBuildingMechanicalSystemType { Id=Guid.Parse("dfbbafc3-6463-484d-9860-a1db4b921c0d"), Code="Other is specified as the major manufactured systems required to operate a building.", Description="09999", Definition="", SortOrder=0 },
        };

        /// <summary>
        /// The RefBuildingMechanicalSystemType Pick List
         /// </summary>
        public static List<RefBuildingMechanicalSystemType> RefBuildingMechanicalSystemTypePickList = new List<RefBuildingMechanicalSystemType> =
        {
            new RefBuildingMechanicalSystemType { Id=Guid.Parse("5a6fccfa-e42a-4d59-8016-d4fcb14e484e"), Code="The primary means by which air is circulated, freshened, and exhausted.", SortOrder=0 },
            new RefBuildingMechanicalSystemType { Id=Guid.Parse("32b3d63e-a5f9-4607-a953-ba261c6216fc"), Code="The type of mechanical systems and building designs used for cooling.", SortOrder=0 },
            new RefBuildingMechanicalSystemType { Id=Guid.Parse("f5cb6db5-3068-4648-a803-a5aa54e86030"), Code="The method by which the heat is distributed and delivered throughout the room(s) or building.", SortOrder=0 },
            new RefBuildingMechanicalSystemType { Id=Guid.Parse("dfbbafc3-6463-484d-9860-a1db4b921c0d"), Code="Other is specified as the major manufactured systems required to operate a building.", SortOrder=0 },
       };
   }
}
