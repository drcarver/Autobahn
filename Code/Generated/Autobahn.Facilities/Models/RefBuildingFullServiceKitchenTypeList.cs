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
        public static List<RefBuildingFullServiceKitchenType> RefBuildingFullServiceKitchenTypeList = new List<RefBuildingFullServiceKitchenType>
        {
            new RefBuildingFullServiceKitchenType { Id=Guid.Parse("10c0a479-5099-4d1d-acc8-281da72ba833"), Code="03247", Description="Central kitchen", Definition="A kitchen used for the production of food (full meals or parts of meals such as bakeries) for facilities other than that of the central kitchen.", SortOrder=Convert.ToDecimal("1.00") },
            new RefBuildingFullServiceKitchenType { Id=Guid.Parse("466485fc-3676-4654-9e88-4a7460eb886a"), Code="03250", Description="Non-production kitchen", Definition="A kitchen that is used for the instruction of the culinary arts. This type of kitchen does not produce food to be served.", SortOrder=Convert.ToDecimal("2.00") },
            new RefBuildingFullServiceKitchenType { Id=Guid.Parse("043a387b-ce14-4828-8741-5c9b35b746d6"), Code="03248", Description="Production kitchen", Definition="A kitchen used for the production of food (full meals or parts of meals such as bakeries) for that facility and for other facilities.", SortOrder=Convert.ToDecimal("3.00") },
            new RefBuildingFullServiceKitchenType { Id=Guid.Parse("dfdcf6bc-069f-4b7c-8764-63cb16acabdc"), Code="03249", Description="Self-contained kitchen", Definition="A kitchen used for the production of food for that facility only.", SortOrder=Convert.ToDecimal("4.00") },
        };

        /// <summary>
        /// The RefBuildingFullServiceKitchenType Pick List
         /// </summary>
        public static List<RefBuildingFullServiceKitchenType> RefBuildingFullServiceKitchenTypePickList = new List<RefBuildingFullServiceKitchenType>
        {
            new RefBuildingFullServiceKitchenType { Id=Guid.Parse("10c0a479-5099-4d1d-acc8-281da72ba833"), Code="03247", Description="Central kitchen", SortOrder=Convert.ToDecimal("1.00") },
            new RefBuildingFullServiceKitchenType { Id=Guid.Parse("466485fc-3676-4654-9e88-4a7460eb886a"), Code="03250", Description="Non-production kitchen", SortOrder=Convert.ToDecimal("2.00") },
            new RefBuildingFullServiceKitchenType { Id=Guid.Parse("043a387b-ce14-4828-8741-5c9b35b746d6"), Code="03248", Description="Production kitchen", SortOrder=Convert.ToDecimal("3.00") },
            new RefBuildingFullServiceKitchenType { Id=Guid.Parse("dfdcf6bc-069f-4b7c-8764-63cb16acabdc"), Code="03249", Description="Self-contained kitchen", SortOrder=Convert.ToDecimal("4.00") },
       };
   }
}
