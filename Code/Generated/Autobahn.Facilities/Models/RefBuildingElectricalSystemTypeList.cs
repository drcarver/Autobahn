//**********************************************************
//* DomainName: Autobahn.Facilities
//* FileName:   RefBuildingElectricalSystemTypeList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Facilities.Models
{
     /// <summary>
     /// The list of RefBuildingElectricalSystemType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefBuildingElectricalSystemTypeModel"> List
         /// </summary>
        public static List<RefBuildingElectricalSystemTypeModel> RefBuildingElectricalSystemTypeList = new List<RefBuildingElectricalSystemTypeModel>
        {
            new RefBuildingElectricalSystemType { Id=Guid.Parse("678410a7-9d23-4448-928f-cb1b2ee8aa43"), Code="02476", Description="Circuit breakers", Definition="Circuit breakers is specified as the component and system required to distribute electricity throughout the building or site.", SortOrder=Convert.ToDecimal("1.00") },
            new RefBuildingElectricalSystemType { Id=Guid.Parse("c969ad30-c5f7-4cf2-b1d5-ed9680580314"), Code="13570", Description="Communications and security", Definition="Communications and security is specified as the component and system required to distribute electricity throughout the building or site.", SortOrder=Convert.ToDecimal("2.00") },
            new RefBuildingElectricalSystemType { Id=Guid.Parse("4a881dae-fedf-4a26-8076-f181bd75863c"), Code="02473", Description="Electrical distribution", Definition="Electrical distribution is specified as the component and system required to distribute electricity throughout the building or site.", SortOrder=Convert.ToDecimal("3.00") },
            new RefBuildingElectricalSystemType { Id=Guid.Parse("ceb4466f-ade6-4c9d-bf03-80f4bc0fb03a"), Code="02475", Description="Electrical interface", Definition="Electrical interface is specified as the component and system required to distribute electricity throughout the building or site.", SortOrder=Convert.ToDecimal("4.00") },
            new RefBuildingElectricalSystemType { Id=Guid.Parse("458583dc-f4a4-4042-8156-b0c941d5bd74"), Code="13571", Description="Electrical service and distribution", Definition="Electrical service and distribution is specified as the component and system required to distribute electricity throughout the building or site.", SortOrder=Convert.ToDecimal("5.00") },
            new RefBuildingElectricalSystemType { Id=Guid.Parse("378c23f3-46de-444e-98f9-ab9545ba3ce6"), Code="02472", Description="Electrical supply", Definition="Electrical supply is specified as the component and system required to distribute electricity throughout the building or site.", SortOrder=Convert.ToDecimal("6.00") },
            new RefBuildingElectricalSystemType { Id=Guid.Parse("50931870-3555-4802-a3f3-692b243e6d14"), Code="02474", Description="Emergency generator", Definition="Emergency generator is specified as the component and system required to distribute electricity throughout the building or site.", SortOrder=Convert.ToDecimal("7.00") },
            new RefBuildingElectricalSystemType { Id=Guid.Parse("fa911e77-bac2-418e-9bac-de2b9838217e"), Code="13572", Description="Lighting and branch wiring", Definition="Lighting and branch wiring is specified as the component and system required to distribute electricity throughout the building or site.", SortOrder=Convert.ToDecimal("8.00") },
            new RefBuildingElectricalSystemType { Id=Guid.Parse("bf33eb29-bc09-4969-b1ba-aca8e349ebbc"), Code="09999", Description="Other", Definition="Other is specified as the component and system required to distribute electricity throughout the building or site.", SortOrder=Convert.ToDecimal("99.00") },
        };

        /// <summary>
        /// The Reference RefBuildingElectricalSystemType Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefBuildingElectricalSystemTypeViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefBuildingElectricalSystemType { Id=Guid.Parse("678410a7-9d23-4448-928f-cb1b2ee8aa43"), Description="Circuit breakers", SortOrder=Convert.ToDecimal("1.00") },
            new RefBuildingElectricalSystemType { Id=Guid.Parse("c969ad30-c5f7-4cf2-b1d5-ed9680580314"), Description="Communications and security", SortOrder=Convert.ToDecimal("2.00") },
            new RefBuildingElectricalSystemType { Id=Guid.Parse("4a881dae-fedf-4a26-8076-f181bd75863c"), Description="Electrical distribution", SortOrder=Convert.ToDecimal("3.00") },
            new RefBuildingElectricalSystemType { Id=Guid.Parse("ceb4466f-ade6-4c9d-bf03-80f4bc0fb03a"), Description="Electrical interface", SortOrder=Convert.ToDecimal("4.00") },
            new RefBuildingElectricalSystemType { Id=Guid.Parse("458583dc-f4a4-4042-8156-b0c941d5bd74"), Description="Electrical service and distribution", SortOrder=Convert.ToDecimal("5.00") },
            new RefBuildingElectricalSystemType { Id=Guid.Parse("378c23f3-46de-444e-98f9-ab9545ba3ce6"), Description="Electrical supply", SortOrder=Convert.ToDecimal("6.00") },
            new RefBuildingElectricalSystemType { Id=Guid.Parse("50931870-3555-4802-a3f3-692b243e6d14"), Description="Emergency generator", SortOrder=Convert.ToDecimal("7.00") },
            new RefBuildingElectricalSystemType { Id=Guid.Parse("fa911e77-bac2-418e-9bac-de2b9838217e"), Description="Lighting and branch wiring", SortOrder=Convert.ToDecimal("8.00") },
            new RefBuildingElectricalSystemType { Id=Guid.Parse("bf33eb29-bc09-4969-b1ba-aca8e349ebbc"), Description="Other", SortOrder=Convert.ToDecimal("99.00") },
       };
   }
}
