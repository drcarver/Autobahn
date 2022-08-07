//**********************************************************
//* DomainName: Autobahn.Facilities
//* FileName:   RefBuildingAirDistributionSystemTypeList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Facilities.Models
{
     /// <summary>
     /// The list of RefBuildingAirDistributionSystemType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefBuildingAirDistributionSystemTypeModel"> List
         /// </summary>
        public static List<RefBuildingAirDistributionSystemTypeModel> RefBuildingAirDistributionSystemTypeList = new List<RefBuildingAirDistributionSystemTypeModel>
        {
            new RefBuildingAirDistributionSystemType { Id=Guid.Parse("8ef2dd14-da86-4d11-a462-d06e3e3805a3"), Code="02497", Description="Air handler units", Definition="Air handler units is specified as the primary means by which air is circulated, freshened, and exhausted.", SortOrder=Convert.ToDecimal("1.00") },
            new RefBuildingAirDistributionSystemType { Id=Guid.Parse("08916b5a-f036-40b1-9d0f-8182c0252abc"), Code="02496", Description="Both mechanical exhaust and supply units", Definition="Both mechanical exhaust and supply units is specified as the primary means by which air is circulated, freshened, and exhausted.", SortOrder=Convert.ToDecimal("2.00") },
            new RefBuildingAirDistributionSystemType { Id=Guid.Parse("7044f44f-a7a7-44af-b0e6-2c3795f9b9c5"), Code="02493", Description="Gravity ventilation units", Definition="Gravity ventilation units is specified as the primary means by which air is circulated, freshened, and exhausted.", SortOrder=Convert.ToDecimal("3.00") },
            new RefBuildingAirDistributionSystemType { Id=Guid.Parse("6d9ab995-33d9-4c33-9a62-293daf93dc91"), Code="02494", Description="Mechanical exhaust units", Definition="Mechanical exhaust units is specified as the primary means by which air is circulated, freshened, and exhausted.", SortOrder=Convert.ToDecimal("4.00") },
            new RefBuildingAirDistributionSystemType { Id=Guid.Parse("34407084-c2d1-4f1f-8b81-43fd3bd8de69"), Code="02495", Description="Mechanical supply units", Definition="Mechanical supply units is specified as the primary means by which air is circulated, freshened, and exhausted.", SortOrder=Convert.ToDecimal("5.00") },
            new RefBuildingAirDistributionSystemType { Id=Guid.Parse("cc995ad6-501c-41fa-b6a8-321aed05c36f"), Code="09999", Description="Other units", Definition="Other units is specified as the primary means by which air is circulated, freshened, and exhausted.", SortOrder=Convert.ToDecimal("6.00") },
            new RefBuildingAirDistributionSystemType { Id=Guid.Parse("b7c249c6-5179-437a-941e-6bdc5a9f2c49"), Code="02492", Description="Window ventilation units", Definition="Window ventilation units is specified as the primary means by which air is circulated, freshened, and exhausted.", SortOrder=Convert.ToDecimal("7.00") },
        };

        /// <summary>
        /// The Reference RefBuildingAirDistributionSystemType Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefBuildingAirDistributionSystemTypeViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefBuildingAirDistributionSystemType { Id=Guid.Parse("8ef2dd14-da86-4d11-a462-d06e3e3805a3"), Description="Air handler units", SortOrder=Convert.ToDecimal("1.00") },
            new RefBuildingAirDistributionSystemType { Id=Guid.Parse("08916b5a-f036-40b1-9d0f-8182c0252abc"), Description="Both mechanical exhaust and supply units", SortOrder=Convert.ToDecimal("2.00") },
            new RefBuildingAirDistributionSystemType { Id=Guid.Parse("7044f44f-a7a7-44af-b0e6-2c3795f9b9c5"), Description="Gravity ventilation units", SortOrder=Convert.ToDecimal("3.00") },
            new RefBuildingAirDistributionSystemType { Id=Guid.Parse("6d9ab995-33d9-4c33-9a62-293daf93dc91"), Description="Mechanical exhaust units", SortOrder=Convert.ToDecimal("4.00") },
            new RefBuildingAirDistributionSystemType { Id=Guid.Parse("34407084-c2d1-4f1f-8b81-43fd3bd8de69"), Description="Mechanical supply units", SortOrder=Convert.ToDecimal("5.00") },
            new RefBuildingAirDistributionSystemType { Id=Guid.Parse("cc995ad6-501c-41fa-b6a8-321aed05c36f"), Description="Other units", SortOrder=Convert.ToDecimal("6.00") },
            new RefBuildingAirDistributionSystemType { Id=Guid.Parse("b7c249c6-5179-437a-941e-6bdc5a9f2c49"), Description="Window ventilation units", SortOrder=Convert.ToDecimal("7.00") },
       };
   }
}
