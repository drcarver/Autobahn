//**********************************************************
//* DomainName: Autobahn.Facilities
//* FileName:   RefFacilityMaintStandardTypeList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Facilities.Models
{
     /// <summary>
     /// The list of RefFacilityMaintStandardType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefFacilityMaintStandardTypeModel"> List
         /// </summary>
        public static List<RefFacilityMaintStandardTypeModel> RefFacilityMaintStandardTypeList = new List<RefFacilityMaintStandardTypeModel>
        {
            new RefFacilityMaintStandardType { Id=Guid.Parse("0a162ac3-164e-47b7-a645-63bd68a7ba65"), Code="02989", Description="Emergency maintenance repair", Definition="A plan that addresses the maintenance in which a critical system, component, equipment, or furnishing breaks down and must be repaired to secure the safety of students, staff, or visitors and/or for operation of the program or service to continue. Unexpected events beyond normal wear and tear may mandate overtime, as situations may have to be dealt with immediately.", SortOrder=Convert.ToDecimal("1.00") },
            new RefFacilityMaintStandardType { Id=Guid.Parse("9a2a7cee-ae15-4c43-afcc-de4e8dec1683"), Code="02839", Description="Predictive", Definition="The process of monitoring selected performance data for a system, component, or equipment against a baseline reference to identify and predict impending failures for just-in-time maintenance attention. A system of maintenance in which computers and software are used to forecast the failure of a piece of equipment based on its age, user demand, and various performance measures.", SortOrder=Convert.ToDecimal("2.00") },
            new RefFacilityMaintStandardType { Id=Guid.Parse("2db66db1-ec5a-4d64-adf4-5b69d02c0803"), Code="02838", Description="Preventive", Definition="The process of performing scheduled equipment inspection, testing, and repair services. Activities are performed on a scheduled basis annually, or more frequently, to identify additional maintenance or required systems testing.", SortOrder=Convert.ToDecimal("3.00") },
            new RefFacilityMaintStandardType { Id=Guid.Parse("a6c2d256-b299-411f-9aa7-f42294b03dcf"), Code="02837", Description="Routine", Definition="A work-order based approach to maintenance that addresses lists of broken items, deteriorated finishes or equipment/parts nearing the end of their life cycle, maintenance required as a result of normal wear and tear, equipment/parts that should be fixed or replaced during a regular work day eliminating the need for overtime pay.", SortOrder=Convert.ToDecimal("4.00") },
            new RefFacilityMaintStandardType { Id=Guid.Parse("7a37313c-2be5-458b-94bc-bb47a32dda96"), Code="02836", Description="Run to fail", Definition="An approach to maintenance in which management allows equipment and parts to run until they break down or wear out beyond repair.", SortOrder=Convert.ToDecimal("5.00") },
        };

        /// <summary>
        /// The Reference RefFacilityMaintStandardType Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefFacilityMaintStandardTypeViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefFacilityMaintStandardType { Id=Guid.Parse("0a162ac3-164e-47b7-a645-63bd68a7ba65"), Description="Emergency maintenance repair", SortOrder=Convert.ToDecimal("1.00") },
            new RefFacilityMaintStandardType { Id=Guid.Parse("9a2a7cee-ae15-4c43-afcc-de4e8dec1683"), Description="Predictive", SortOrder=Convert.ToDecimal("2.00") },
            new RefFacilityMaintStandardType { Id=Guid.Parse("2db66db1-ec5a-4d64-adf4-5b69d02c0803"), Description="Preventive", SortOrder=Convert.ToDecimal("3.00") },
            new RefFacilityMaintStandardType { Id=Guid.Parse("a6c2d256-b299-411f-9aa7-f42294b03dcf"), Description="Routine", SortOrder=Convert.ToDecimal("4.00") },
            new RefFacilityMaintStandardType { Id=Guid.Parse("7a37313c-2be5-458b-94bc-bb47a32dda96"), Description="Run to fail", SortOrder=Convert.ToDecimal("5.00") },
       };
   }
}
