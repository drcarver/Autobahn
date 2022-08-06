//**********************************************************
//* DomainName: Autobahn.Facilities
//* FileName:   RefBuildingFullServiceKitchenTypeList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Facilities.Models
{
     /// <summary>
     /// The list of RefBuildingFullServiceKitchenType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefBuildingFullServiceKitchenType"> List
         /// </summary>
        public static List<RefBuildingFullServiceKitchenType> RefBuildingFullServiceKitchenTypeList = new List<RefBuildingFullServiceKitchenType> =
        {
            new RefBuildingFullServiceKitchenType { Id=Guid.Parse("d12dd386-049e-4ff2-86ed-252d82dd7560"), Code="A kitchen used for the production of food (full meals or parts of meals such as bakeries) for facilities other than that of the central kitchen.", Description="03247", Definition="", SortOrder=0 },
            new RefBuildingFullServiceKitchenType { Id=Guid.Parse("e7948d9b-578b-423a-8801-cd1830d0b26b"), Code="A kitchen that is used for the instruction of the culinary arts. This type of kitchen does not produce food to be served.", Description="03250", Definition="", SortOrder=0 },
            new RefBuildingFullServiceKitchenType { Id=Guid.Parse("6d1b23b2-51f8-473b-9a79-0a22a1c66b21"), Code="A kitchen used for the production of food (full meals or parts of meals such as bakeries) for that facility and for other facilities.", Description="03248", Definition="", SortOrder=0 },
            new RefBuildingFullServiceKitchenType { Id=Guid.Parse("9a0ecae7-a03d-46a5-8a46-5c6df37c3230"), Code="A kitchen used for the production of food for that facility only.", Description="03249", Definition="", SortOrder=0 },
        };

        /// <summary>
        /// The RefBuildingFullServiceKitchenType Pick List
         /// </summary>
        public static List<RefBuildingFullServiceKitchenType> RefBuildingFullServiceKitchenTypePickList = new List<RefBuildingFullServiceKitchenType> =
        {
            new RefBuildingFullServiceKitchenType { Id=Guid.Parse("d12dd386-049e-4ff2-86ed-252d82dd7560"), Code="A kitchen used for the production of food (full meals or parts of meals such as bakeries) for facilities other than that of the central kitchen.", SortOrder=0 },
            new RefBuildingFullServiceKitchenType { Id=Guid.Parse("e7948d9b-578b-423a-8801-cd1830d0b26b"), Code="A kitchen that is used for the instruction of the culinary arts. This type of kitchen does not produce food to be served.", SortOrder=0 },
            new RefBuildingFullServiceKitchenType { Id=Guid.Parse("6d1b23b2-51f8-473b-9a79-0a22a1c66b21"), Code="A kitchen used for the production of food (full meals or parts of meals such as bakeries) for that facility and for other facilities.", SortOrder=0 },
            new RefBuildingFullServiceKitchenType { Id=Guid.Parse("9a0ecae7-a03d-46a5-8a46-5c6df37c3230"), Code="A kitchen used for the production of food for that facility only.", SortOrder=0 },
       };
   }
}
