//**********************************************************
//* DomainName: Autobahn.Facilities
//* FileName:   RefBuildingPrimaryUseTypeList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Facilities.Models
{
     /// <summary>
     /// The list of RefBuildingPrimaryUseType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefBuildingPrimaryUseType"> List
         /// </summary>
        public static List<RefBuildingPrimaryUseType> RefBuildingPrimaryUseTypeList = new List<RefBuildingPrimaryUseType> =
        {
            new RefBuildingPrimaryUseType { Id=Guid.Parse("d916ef39-7d6a-4667-b74f-84e20168e874"), Code="Church is specified as the primary use type of the building in which a school is located.", Description="13561", Definition="", SortOrder=0 },
            new RefBuildingPrimaryUseType { Id=Guid.Parse("6a98af57-9774-4bfb-9948-bb0f7b30be00"), Code="Commercial office building is specified as the primary use type of the building in which a school is located.", Description="13562", Definition="", SortOrder=0 },
            new RefBuildingPrimaryUseType { Id=Guid.Parse("2314e715-4c22-465e-8546-1d6b790d1b4b"), Code="Commercial warehouse is specified as the primary use type of the building in which a school is located.", Description="13563", Definition="", SortOrder=0 },
            new RefBuildingPrimaryUseType { Id=Guid.Parse("ad2bf060-7458-42a9-8217-4f85d1287815"), Code="Community center is specified as the primary use type of the building in which a school is located.", Description="13564", Definition="", SortOrder=0 },
            new RefBuildingPrimaryUseType { Id=Guid.Parse("e6e7f845-789f-4617-8952-4f189fe70fa9"), Code="Public school building is specified as the primary use type of the building in which a school is located.", Description="13565", Definition="", SortOrder=0 },
        };

        /// <summary>
        /// The RefBuildingPrimaryUseType Pick List
         /// </summary>
        public static List<RefBuildingPrimaryUseType> RefBuildingPrimaryUseTypePickList = new List<RefBuildingPrimaryUseType> =
        {
            new RefBuildingPrimaryUseType { Id=Guid.Parse("d916ef39-7d6a-4667-b74f-84e20168e874"), Code="Church is specified as the primary use type of the building in which a school is located.", SortOrder=0 },
            new RefBuildingPrimaryUseType { Id=Guid.Parse("6a98af57-9774-4bfb-9948-bb0f7b30be00"), Code="Commercial office building is specified as the primary use type of the building in which a school is located.", SortOrder=0 },
            new RefBuildingPrimaryUseType { Id=Guid.Parse("2314e715-4c22-465e-8546-1d6b790d1b4b"), Code="Commercial warehouse is specified as the primary use type of the building in which a school is located.", SortOrder=0 },
            new RefBuildingPrimaryUseType { Id=Guid.Parse("ad2bf060-7458-42a9-8217-4f85d1287815"), Code="Community center is specified as the primary use type of the building in which a school is located.", SortOrder=0 },
            new RefBuildingPrimaryUseType { Id=Guid.Parse("e6e7f845-789f-4617-8952-4f189fe70fa9"), Code="Public school building is specified as the primary use type of the building in which a school is located.", SortOrder=0 },
       };
   }
}
