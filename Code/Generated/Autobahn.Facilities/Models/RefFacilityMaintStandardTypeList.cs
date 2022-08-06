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
        public static List<RefFacilityMaintStandardType> RefFacilityMaintStandardTypeList = new List<RefFacilityMaintStandardType> =
        {
            new RefFacilityMaintStandardType { Id=Guid.Parse("49977071-7bab-4efb-9fb1-d576a123cc0d"), Code="A plan that addresses the maintenance in which a critical system, component, equipment, or furnishing breaks down and must be repaired to secure the safety of students, staff, or visitors and/or for operation of the program or service to continue. Unexpected events beyond normal wear and tear may mandate overtime, as situations may have to be dealt with immediately.", Description="02989", Definition="", SortOrder=0 },
            new RefFacilityMaintStandardType { Id=Guid.Parse("344fa29f-524a-46c5-8b5a-c044e98d7339"), Code="The process of monitoring selected performance data for a system, component, or equipment against a baseline reference to identify and predict impending failures for just-in-time maintenance attention. A system of maintenance in which computers and software are used to forecast the failure of a piece of equipment based on its age, user demand, and various performance measures.", Description="02839", Definition="", SortOrder=0 },
            new RefFacilityMaintStandardType { Id=Guid.Parse("8a5181cc-a59e-4884-b3ca-a758ab47a274"), Code="The process of performing scheduled equipment inspection, testing, and repair services. Activities are performed on a scheduled basis annually, or more frequently, to identify additional maintenance or required systems testing.", Description="02838", Definition="", SortOrder=0 },
            new RefFacilityMaintStandardType { Id=Guid.Parse("5fe49418-1df2-4b0c-9154-3983fefeea05"), Code="A work-order based approach to maintenance that addresses lists of broken items, deteriorated finishes or equipment/parts nearing the end of their life cycle, maintenance required as a result of normal wear and tear, equipment/parts that should be fixed or replaced during a regular work day eliminating the need for overtime pay.", Description="02837", Definition="", SortOrder=0 },
            new RefFacilityMaintStandardType { Id=Guid.Parse("7e7e8b59-fd1f-4bd6-b6a1-4546fb1afe6f"), Code="An approach to maintenance in which management allows equipment and parts to run until they break down or wear out beyond repair.", Description="02836", Definition="", SortOrder=0 },
        };

        /// <summary>
        /// The RefFacilityMaintStandardType Pick List
         /// </summary>
        public static List<RefFacilityMaintStandardType> RefFacilityMaintStandardTypePickList = new List<RefFacilityMaintStandardType> =
        {
            new RefFacilityMaintStandardType { Id=Guid.Parse("49977071-7bab-4efb-9fb1-d576a123cc0d"), Code="A plan that addresses the maintenance in which a critical system, component, equipment, or furnishing breaks down and must be repaired to secure the safety of students, staff, or visitors and/or for operation of the program or service to continue. Unexpected events beyond normal wear and tear may mandate overtime, as situations may have to be dealt with immediately.", SortOrder=0 },
            new RefFacilityMaintStandardType { Id=Guid.Parse("344fa29f-524a-46c5-8b5a-c044e98d7339"), Code="The process of monitoring selected performance data for a system, component, or equipment against a baseline reference to identify and predict impending failures for just-in-time maintenance attention. A system of maintenance in which computers and software are used to forecast the failure of a piece of equipment based on its age, user demand, and various performance measures.", SortOrder=0 },
            new RefFacilityMaintStandardType { Id=Guid.Parse("8a5181cc-a59e-4884-b3ca-a758ab47a274"), Code="The process of performing scheduled equipment inspection, testing, and repair services. Activities are performed on a scheduled basis annually, or more frequently, to identify additional maintenance or required systems testing.", SortOrder=0 },
            new RefFacilityMaintStandardType { Id=Guid.Parse("5fe49418-1df2-4b0c-9154-3983fefeea05"), Code="A work-order based approach to maintenance that addresses lists of broken items, deteriorated finishes or equipment/parts nearing the end of their life cycle, maintenance required as a result of normal wear and tear, equipment/parts that should be fixed or replaced during a regular work day eliminating the need for overtime pay.", SortOrder=0 },
            new RefFacilityMaintStandardType { Id=Guid.Parse("7e7e8b59-fd1f-4bd6-b6a1-4546fb1afe6f"), Code="An approach to maintenance in which management allows equipment and parts to run until they break down or wear out beyond repair.", SortOrder=0 },
       };
   }
}
