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
        /// The complete <see cref="RefBuildingEnergyConservationMeasureTypeModel"> List
         /// </summary>
        public static List<RefBuildingEnergyConservationMeasureTypeModel> RefBuildingEnergyConservationMeasureTypeList = new List<RefBuildingEnergyConservationMeasureTypeModel>
        {
            new RefBuildingEnergyConservationMeasureType { Id=Guid.Parse("d395c540-0086-4492-8f40-d115ca098e7c"), Code="13653", Description="Daylighting", Definition="Practice of using natural light, rather than electric lights, to illuminate a space.", SortOrder=Convert.ToDecimal("1.00") },
            new RefBuildingEnergyConservationMeasureType { Id=Guid.Parse("260fb235-dc48-49cd-b442-6e7905dda22c"), Code="13654", Description="Delamping", Definition="Process of removing lamps from a light fixture--for example, using only 2 fluorescent tubes in a 3-tube fixture--wherever there is extra light.", SortOrder=Convert.ToDecimal("2.00") },
            new RefBuildingEnergyConservationMeasureType { Id=Guid.Parse("f61d9212-f966-44ed-87e8-9c9a365adcc5"), Code="02848", Description="HVAC replacement", Definition="The replacement of a HVAC system with one that is more energy efficient.", SortOrder=Convert.ToDecimal("3.00") },
            new RefBuildingEnergyConservationMeasureType { Id=Guid.Parse("a15a911d-7396-48d7-b866-5bdb541bded4"), Code="02847", Description="Installation of energy controls", Definition="The installation of energy controls that increase the energy efficiency of a building.", SortOrder=Convert.ToDecimal("4.00") },
            new RefBuildingEnergyConservationMeasureType { Id=Guid.Parse("9d712bcf-cdaf-40e6-8484-0d3c10309f03"), Code="14904", Description="Installation of solar equipment", Definition="Installation of solar equipment is specified as the type of modification to, or replacement of, a piece of equipment or building shell/system that increases energy efficiency.", SortOrder=Convert.ToDecimal("5.00") },
            new RefBuildingEnergyConservationMeasureType { Id=Guid.Parse("641803c0-9eed-4a25-92f6-c53dfc719e92"), Code="02850", Description="Insulation improvements", Definition="The replacement or addition of insulation to a building to make it more energy efficient.", SortOrder=Convert.ToDecimal("6.00") },
            new RefBuildingEnergyConservationMeasureType { Id=Guid.Parse("5eafbd15-edc0-4f55-9b0f-6bd3856a3bf6"), Code="02849", Description="Lighting replacement", Definition="The replacement of lighting systems or fixtures with those that are more energy efficient.", SortOrder=Convert.ToDecimal("7.00") },
            new RefBuildingEnergyConservationMeasureType { Id=Guid.Parse("e1bd5cff-4252-4ed7-95f6-788b87bac2bc"), Code="14903", Description="Relamping", Definition="The replacement of lamps that are not performing at peak performance.", SortOrder=Convert.ToDecimal("8.00") },
            new RefBuildingEnergyConservationMeasureType { Id=Guid.Parse("0d10a76a-8ab1-4bbc-93cf-dd9e7fb4da2c"), Code="02846", Description="Window replacement", Definition="The replacement of windows in a building with those that increase energy efficiency.", SortOrder=Convert.ToDecimal("9.00") },
            new RefBuildingEnergyConservationMeasureType { Id=Guid.Parse("291b7ff4-11c8-4d14-8bdd-28d5a944e089"), Code="09999", Description="Other", Definition="Other is specified as the type of modification to, or replacement of, a piece of equipment or building shell/system that increases energy efficiency.", SortOrder=Convert.ToDecimal("99.00") },
        };

        /// <summary>
        /// The Reference RefBuildingEnergyConservationMeasureType Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefBuildingEnergyConservationMeasureTypeViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefBuildingEnergyConservationMeasureType { Id=Guid.Parse("d395c540-0086-4492-8f40-d115ca098e7c"), Description="Daylighting", SortOrder=Convert.ToDecimal("1.00") },
            new RefBuildingEnergyConservationMeasureType { Id=Guid.Parse("260fb235-dc48-49cd-b442-6e7905dda22c"), Description="Delamping", SortOrder=Convert.ToDecimal("2.00") },
            new RefBuildingEnergyConservationMeasureType { Id=Guid.Parse("f61d9212-f966-44ed-87e8-9c9a365adcc5"), Description="HVAC replacement", SortOrder=Convert.ToDecimal("3.00") },
            new RefBuildingEnergyConservationMeasureType { Id=Guid.Parse("a15a911d-7396-48d7-b866-5bdb541bded4"), Description="Installation of energy controls", SortOrder=Convert.ToDecimal("4.00") },
            new RefBuildingEnergyConservationMeasureType { Id=Guid.Parse("9d712bcf-cdaf-40e6-8484-0d3c10309f03"), Description="Installation of solar equipment", SortOrder=Convert.ToDecimal("5.00") },
            new RefBuildingEnergyConservationMeasureType { Id=Guid.Parse("641803c0-9eed-4a25-92f6-c53dfc719e92"), Description="Insulation improvements", SortOrder=Convert.ToDecimal("6.00") },
            new RefBuildingEnergyConservationMeasureType { Id=Guid.Parse("5eafbd15-edc0-4f55-9b0f-6bd3856a3bf6"), Description="Lighting replacement", SortOrder=Convert.ToDecimal("7.00") },
            new RefBuildingEnergyConservationMeasureType { Id=Guid.Parse("e1bd5cff-4252-4ed7-95f6-788b87bac2bc"), Description="Relamping", SortOrder=Convert.ToDecimal("8.00") },
            new RefBuildingEnergyConservationMeasureType { Id=Guid.Parse("0d10a76a-8ab1-4bbc-93cf-dd9e7fb4da2c"), Description="Window replacement", SortOrder=Convert.ToDecimal("9.00") },
            new RefBuildingEnergyConservationMeasureType { Id=Guid.Parse("291b7ff4-11c8-4d14-8bdd-28d5a944e089"), Description="Other", SortOrder=Convert.ToDecimal("99.00") },
       };
   }
}
