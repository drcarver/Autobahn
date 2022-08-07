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
        /// The complete <see cref="RefBuildingFullServiceKitchenTypeModel"> List
         /// </summary>
        public static List<RefBuildingFullServiceKitchenTypeModel> RefBuildingFullServiceKitchenTypeList = new List<RefBuildingFullServiceKitchenTypeModel>
        {
            new RefBuildingFullServiceKitchenType { Id=Guid.Parse("b9716b02-85e0-4fc1-9fd1-797557b2c3cc"), Code="03247", Description="Central kitchen", Definition="A kitchen used for the production of food (full meals or parts of meals such as bakeries) for facilities other than that of the central kitchen.", SortOrder=Convert.ToDecimal("1.00") },
            new RefBuildingFullServiceKitchenType { Id=Guid.Parse("3ae5c282-d069-479b-b4d0-d57aa58503a5"), Code="03250", Description="Non-production kitchen", Definition="A kitchen that is used for the instruction of the culinary arts. This type of kitchen does not produce food to be served.", SortOrder=Convert.ToDecimal("2.00") },
            new RefBuildingFullServiceKitchenType { Id=Guid.Parse("5e7218f2-d96f-4018-8e7a-3e86af31b44b"), Code="03248", Description="Production kitchen", Definition="A kitchen used for the production of food (full meals or parts of meals such as bakeries) for that facility and for other facilities.", SortOrder=Convert.ToDecimal("3.00") },
            new RefBuildingFullServiceKitchenType { Id=Guid.Parse("61a32364-1abe-4a19-8c59-429e15214590"), Code="03249", Description="Self-contained kitchen", Definition="A kitchen used for the production of food for that facility only.", SortOrder=Convert.ToDecimal("4.00") },
        };

        /// <summary>
        /// The Reference RefBuildingFullServiceKitchenType Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefBuildingFullServiceKitchenTypeViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefBuildingFullServiceKitchenType { Id=Guid.Parse("b9716b02-85e0-4fc1-9fd1-797557b2c3cc"), Description="Central kitchen", SortOrder=Convert.ToDecimal("1.00") },
            new RefBuildingFullServiceKitchenType { Id=Guid.Parse("3ae5c282-d069-479b-b4d0-d57aa58503a5"), Description="Non-production kitchen", SortOrder=Convert.ToDecimal("2.00") },
            new RefBuildingFullServiceKitchenType { Id=Guid.Parse("5e7218f2-d96f-4018-8e7a-3e86af31b44b"), Description="Production kitchen", SortOrder=Convert.ToDecimal("3.00") },
            new RefBuildingFullServiceKitchenType { Id=Guid.Parse("61a32364-1abe-4a19-8c59-429e15214590"), Description="Self-contained kitchen", SortOrder=Convert.ToDecimal("4.00") },
       };
   }
}
