//**********************************************************
//* DomainName: Autobahn.Facilities
//* FileName:   RefBuildingEnergyConservationMeasureTypeList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Facilities.Models
{
     /// <summary>
     /// The list of RefBuildingEnergyConservationMeasureType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefBuildingEnergyConservationMeasureType"> List
         /// </summary>
        public static List<RefBuildingEnergyConservationMeasureType> RefBuildingEnergyConservationMeasureTypeList = new List<RefBuildingEnergyConservationMeasureType>
        {
            new RefBuildingEnergyConservationMeasureType { Id=Guid.Parse("ecca76ca-2315-4167-a6b7-101386ebe1d1"), Code="13653", Description="Daylighting", Definition="Practice of using natural light, rather than electric lights, to illuminate a space.", SortOrder=Convert.ToDecimal("1.00") },
            new RefBuildingEnergyConservationMeasureType { Id=Guid.Parse("3f073cea-a5e4-4b2f-93e2-346853aa07fd"), Code="13654", Description="Delamping", Definition="Process of removing lamps from a light fixture--for example, using only 2 fluorescent tubes in a 3-tube fixture--wherever there is extra light.", SortOrder=Convert.ToDecimal("2.00") },
            new RefBuildingEnergyConservationMeasureType { Id=Guid.Parse("117aaf1f-1bfa-430e-8dee-758589fdeeea"), Code="02848", Description="HVAC replacement", Definition="The replacement of a HVAC system with one that is more energy efficient.", SortOrder=Convert.ToDecimal("3.00") },
            new RefBuildingEnergyConservationMeasureType { Id=Guid.Parse("7d890872-d192-4477-bac4-fd39aa6511cd"), Code="02847", Description="Installation of energy controls", Definition="The installation of energy controls that increase the energy efficiency of a building.", SortOrder=Convert.ToDecimal("4.00") },
            new RefBuildingEnergyConservationMeasureType { Id=Guid.Parse("a7951c9b-5e6a-4827-b4c8-799c6809da78"), Code="14904", Description="Installation of solar equipment", Definition="Installation of solar equipment is specified as the type of modification to, or replacement of, a piece of equipment or building shell/system that increases energy efficiency.", SortOrder=Convert.ToDecimal("5.00") },
            new RefBuildingEnergyConservationMeasureType { Id=Guid.Parse("a6697657-ad98-4e15-a0cd-fda4234dd622"), Code="02850", Description="Insulation improvements", Definition="The replacement or addition of insulation to a building to make it more energy efficient.", SortOrder=Convert.ToDecimal("6.00") },
            new RefBuildingEnergyConservationMeasureType { Id=Guid.Parse("ba247c5f-0bb1-40f6-a706-00bc6d06f812"), Code="02849", Description="Lighting replacement", Definition="The replacement of lighting systems or fixtures with those that are more energy efficient.", SortOrder=Convert.ToDecimal("7.00") },
            new RefBuildingEnergyConservationMeasureType { Id=Guid.Parse("c63ce31b-6923-4cc0-858d-d1cfc8415aba"), Code="14903", Description="Relamping", Definition="The replacement of lamps that are not performing at peak performance.", SortOrder=Convert.ToDecimal("8.00") },
            new RefBuildingEnergyConservationMeasureType { Id=Guid.Parse("3fa24edb-3638-4436-8e5a-c60dc3f88f1a"), Code="02846", Description="Window replacement", Definition="The replacement of windows in a building with those that increase energy efficiency.", SortOrder=Convert.ToDecimal("9.00") },
            new RefBuildingEnergyConservationMeasureType { Id=Guid.Parse("0c089d3e-ec3b-4e92-8b97-b32e727699be"), Code="09999", Description="Other", Definition="Other is specified as the type of modification to, or replacement of, a piece of equipment or building shell/system that increases energy efficiency.", SortOrder=Convert.ToDecimal("99.00") },
        };

        /// <summary>
        /// The RefBuildingEnergyConservationMeasureType Pick List
         /// </summary>
        public static List<RefBuildingEnergyConservationMeasureType> RefBuildingEnergyConservationMeasureTypePickList = new List<RefBuildingEnergyConservationMeasureType>
        {
            new RefBuildingEnergyConservationMeasureType { Id=Guid.Parse("ecca76ca-2315-4167-a6b7-101386ebe1d1"), Code="13653", Description="Daylighting", SortOrder=Convert.ToDecimal("1.00") },
            new RefBuildingEnergyConservationMeasureType { Id=Guid.Parse("3f073cea-a5e4-4b2f-93e2-346853aa07fd"), Code="13654", Description="Delamping", SortOrder=Convert.ToDecimal("2.00") },
            new RefBuildingEnergyConservationMeasureType { Id=Guid.Parse("117aaf1f-1bfa-430e-8dee-758589fdeeea"), Code="02848", Description="HVAC replacement", SortOrder=Convert.ToDecimal("3.00") },
            new RefBuildingEnergyConservationMeasureType { Id=Guid.Parse("7d890872-d192-4477-bac4-fd39aa6511cd"), Code="02847", Description="Installation of energy controls", SortOrder=Convert.ToDecimal("4.00") },
            new RefBuildingEnergyConservationMeasureType { Id=Guid.Parse("a7951c9b-5e6a-4827-b4c8-799c6809da78"), Code="14904", Description="Installation of solar equipment", SortOrder=Convert.ToDecimal("5.00") },
            new RefBuildingEnergyConservationMeasureType { Id=Guid.Parse("a6697657-ad98-4e15-a0cd-fda4234dd622"), Code="02850", Description="Insulation improvements", SortOrder=Convert.ToDecimal("6.00") },
            new RefBuildingEnergyConservationMeasureType { Id=Guid.Parse("ba247c5f-0bb1-40f6-a706-00bc6d06f812"), Code="02849", Description="Lighting replacement", SortOrder=Convert.ToDecimal("7.00") },
            new RefBuildingEnergyConservationMeasureType { Id=Guid.Parse("c63ce31b-6923-4cc0-858d-d1cfc8415aba"), Code="14903", Description="Relamping", SortOrder=Convert.ToDecimal("8.00") },
            new RefBuildingEnergyConservationMeasureType { Id=Guid.Parse("3fa24edb-3638-4436-8e5a-c60dc3f88f1a"), Code="02846", Description="Window replacement", SortOrder=Convert.ToDecimal("9.00") },
            new RefBuildingEnergyConservationMeasureType { Id=Guid.Parse("0c089d3e-ec3b-4e92-8b97-b32e727699be"), Code="09999", Description="Other", SortOrder=Convert.ToDecimal("99.00") },
       };
   }
}
