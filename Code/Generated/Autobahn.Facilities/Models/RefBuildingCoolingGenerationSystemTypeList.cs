//**********************************************************
//* DomainName: Autobahn.Facilities
//* FileName:   RefBuildingCoolingGenerationSystemTypeList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Facilities.Models
{
     /// <summary>
     /// The list of RefBuildingCoolingGenerationSystemType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefBuildingCoolingGenerationSystemTypeModel"> List
         /// </summary>
        public static List<RefBuildingCoolingGenerationSystemTypeModel> RefBuildingCoolingGenerationSystemTypeList = new List<RefBuildingCoolingGenerationSystemTypeModel>
        {
            new RefBuildingCoolingGenerationSystemType { Id=Guid.Parse("04215fb8-8822-4535-92e9-d89d0c46d6b6"), Code="02490", Description="Ceiling fans or ventilation fans", Definition="Ceiling fans or ventilation fans is specified as the type of mechanical systems and building designs used for cooling.", SortOrder=Convert.ToDecimal("1.00") },
            new RefBuildingCoolingGenerationSystemType { Id=Guid.Parse("67b940c1-99a8-49b9-a7b0-0a592eca96fa"), Code="02486", Description="Central cooling system", Definition="Central cooling system is specified as the type of mechanical systems and building designs used for cooling.", SortOrder=Convert.ToDecimal("2.00") },
            new RefBuildingCoolingGenerationSystemType { Id=Guid.Parse("5b798fa3-a44d-410b-b58e-f4183e2a079d"), Code="02489", Description="Combination cooling systems", Definition="Combination cooling systems is specified as the type of mechanical systems and building designs used for cooling.", SortOrder=Convert.ToDecimal("3.00") },
            new RefBuildingCoolingGenerationSystemType { Id=Guid.Parse("5ac51725-2d28-4e60-a8dd-797ff0f409ac"), Code="02488", Description="Individual (room) unit cooling system", Definition="Individual (room) unit cooling system is specified as the type of mechanical systems and building designs used for cooling.", SortOrder=Convert.ToDecimal("4.00") },
            new RefBuildingCoolingGenerationSystemType { Id=Guid.Parse("f4c3d98f-2fe7-4639-ba74-4ee0ad97e6f6"), Code="02487", Description="Local zone cooling system", Definition="Local zone cooling system is specified as the type of mechanical systems and building designs used for cooling.", SortOrder=Convert.ToDecimal("5.00") },
            new RefBuildingCoolingGenerationSystemType { Id=Guid.Parse("0355bcad-b202-474e-84ab-15b9f3b91ee1"), Code="02491", Description="Natural systems", Definition="Natural systems is specified as the type of mechanical systems and building designs used for cooling.", SortOrder=Convert.ToDecimal("6.00") },
            new RefBuildingCoolingGenerationSystemType { Id=Guid.Parse("ae37edcc-981d-4317-9926-cac410176cbe"), Code="09998", Description="None", Definition="No type of mechanical systems and building designs used for cooling is specified.", SortOrder=Convert.ToDecimal("7.00") },
            new RefBuildingCoolingGenerationSystemType { Id=Guid.Parse("9e7b9edd-75cf-4009-acc6-fb422633b987"), Code="09999", Description="Other", Definition="Other is specified as the type of mechanical systems and building designs used for cooling.", SortOrder=Convert.ToDecimal("99.00") },
        };

        /// <summary>
        /// The Reference RefBuildingCoolingGenerationSystemType Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefBuildingCoolingGenerationSystemTypeViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefBuildingCoolingGenerationSystemType { Id=Guid.Parse("04215fb8-8822-4535-92e9-d89d0c46d6b6"), Description="Ceiling fans or ventilation fans", SortOrder=Convert.ToDecimal("1.00") },
            new RefBuildingCoolingGenerationSystemType { Id=Guid.Parse("67b940c1-99a8-49b9-a7b0-0a592eca96fa"), Description="Central cooling system", SortOrder=Convert.ToDecimal("2.00") },
            new RefBuildingCoolingGenerationSystemType { Id=Guid.Parse("5b798fa3-a44d-410b-b58e-f4183e2a079d"), Description="Combination cooling systems", SortOrder=Convert.ToDecimal("3.00") },
            new RefBuildingCoolingGenerationSystemType { Id=Guid.Parse("5ac51725-2d28-4e60-a8dd-797ff0f409ac"), Description="Individual (room) unit cooling system", SortOrder=Convert.ToDecimal("4.00") },
            new RefBuildingCoolingGenerationSystemType { Id=Guid.Parse("f4c3d98f-2fe7-4639-ba74-4ee0ad97e6f6"), Description="Local zone cooling system", SortOrder=Convert.ToDecimal("5.00") },
            new RefBuildingCoolingGenerationSystemType { Id=Guid.Parse("0355bcad-b202-474e-84ab-15b9f3b91ee1"), Description="Natural systems", SortOrder=Convert.ToDecimal("6.00") },
            new RefBuildingCoolingGenerationSystemType { Id=Guid.Parse("ae37edcc-981d-4317-9926-cac410176cbe"), Description="None", SortOrder=Convert.ToDecimal("7.00") },
            new RefBuildingCoolingGenerationSystemType { Id=Guid.Parse("9e7b9edd-75cf-4009-acc6-fb422633b987"), Description="Other", SortOrder=Convert.ToDecimal("99.00") },
       };
   }
}
