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
        /// The complete <see cref="RefFacilityMaintStandardType"> List
         /// </summary>
        public static List<RefFacilityMaintStandardType> RefFacilityMaintStandardTypeList = new List<RefFacilityMaintStandardType>
        {
            new RefFacilityMaintStandardType { Id=Guid.Parse("325d7ec4-b026-4c6b-b896-f37c71240d7d"), Code="02989", Description="Emergency maintenance repair", Definition="A plan that addresses the maintenance in which a critical system, component, equipment, or furnishing breaks down and must be repaired to secure the safety of students, staff, or visitors and/or for operation of the program or service to continue. Unexpected events beyond normal wear and tear may mandate overtime, as situations may have to be dealt with immediately.", SortOrder=Convert.ToDecimal("1.00") },
            new RefFacilityMaintStandardType { Id=Guid.Parse("0ec633ef-dcc6-4ab6-ba35-235817afc8f1"), Code="02839", Description="Predictive", Definition="The process of monitoring selected performance data for a system, component, or equipment against a baseline reference to identify and predict impending failures for just-in-time maintenance attention. A system of maintenance in which computers and software are used to forecast the failure of a piece of equipment based on its age, user demand, and various performance measures.", SortOrder=Convert.ToDecimal("2.00") },
            new RefFacilityMaintStandardType { Id=Guid.Parse("cfa4d9fb-5544-44d4-b237-286032a29103"), Code="02838", Description="Preventive", Definition="The process of performing scheduled equipment inspection, testing, and repair services. Activities are performed on a scheduled basis annually, or more frequently, to identify additional maintenance or required systems testing.", SortOrder=Convert.ToDecimal("3.00") },
            new RefFacilityMaintStandardType { Id=Guid.Parse("982f5eb1-936d-4082-a3cf-fb2ac0e883a8"), Code="02837", Description="Routine", Definition="A work-order based approach to maintenance that addresses lists of broken items, deteriorated finishes or equipment/parts nearing the end of their life cycle, maintenance required as a result of normal wear and tear, equipment/parts that should be fixed or replaced during a regular work day eliminating the need for overtime pay.", SortOrder=Convert.ToDecimal("4.00") },
            new RefFacilityMaintStandardType { Id=Guid.Parse("ec664e50-e054-494e-bcd9-d6239d427195"), Code="02836", Description="Run to fail", Definition="An approach to maintenance in which management allows equipment and parts to run until they break down or wear out beyond repair.", SortOrder=Convert.ToDecimal("5.00") },
        };

        /// <summary>
        /// The RefFacilityMaintStandardType Pick List
         /// </summary>
        public static List<RefFacilityMaintStandardType> RefFacilityMaintStandardTypePickList = new List<RefFacilityMaintStandardType>
        {
            new RefFacilityMaintStandardType { Id=Guid.Parse("325d7ec4-b026-4c6b-b896-f37c71240d7d"), Code="02989", Description="Emergency maintenance repair", SortOrder=Convert.ToDecimal("1.00") },
            new RefFacilityMaintStandardType { Id=Guid.Parse("0ec633ef-dcc6-4ab6-ba35-235817afc8f1"), Code="02839", Description="Predictive", SortOrder=Convert.ToDecimal("2.00") },
            new RefFacilityMaintStandardType { Id=Guid.Parse("cfa4d9fb-5544-44d4-b237-286032a29103"), Code="02838", Description="Preventive", SortOrder=Convert.ToDecimal("3.00") },
            new RefFacilityMaintStandardType { Id=Guid.Parse("982f5eb1-936d-4082-a3cf-fb2ac0e883a8"), Code="02837", Description="Routine", SortOrder=Convert.ToDecimal("4.00") },
            new RefFacilityMaintStandardType { Id=Guid.Parse("ec664e50-e054-494e-bcd9-d6239d427195"), Code="02836", Description="Run to fail", SortOrder=Convert.ToDecimal("5.00") },
       };
   }
}
