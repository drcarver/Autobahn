//**********************************************************
//* DomainName: Autobahn.Facilities
//* FileName:   RefFacilityStandardTypeList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Facilities.Models
{
     /// <summary>
     /// The list of RefFacilityStandardType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefFacilityStandardType"> List
         /// </summary>
        public static List<RefFacilityStandardType> RefFacilityStandardTypeList = new List<RefFacilityStandardType> =
        {
            new RefFacilityStandardType { Id=Guid.Parse("ba9a8261-2d49-402c-97c5-55c227b8f567"), Code="The guidelines that establish site, building and room sizes, quality and type of finishes, systems, components, furnishings and fixtures of a facility.", Description="02622", Definition="", SortOrder=0 },
            new RefFacilityStandardType { Id=Guid.Parse("5e3036f1-d404-4358-9dd9-f891a24e3657"), Code="The metrics for the levels of water, electricity, gas, oil, or coal consumption that a district seeks to meet on a district wide or facility specific basis.", Description="02626", Definition="", SortOrder=0 },
            new RefFacilityStandardType { Id=Guid.Parse("8747fb30-f22a-4709-ad19-b531881f5306"), Code="A policy guideline that regulates the effect of human activity upon the environment. Standards may specify a desired state (e.g. daylighting should provide 75% of lighting needed for classrooms)or limit alterations (e.g. new school sites should be no more than 4 acres for an elementary school).", Description="13628", Definition="", SortOrder=0 },
            new RefFacilityStandardType { Id=Guid.Parse("75d7f506-bc6f-4a87-b92a-fe89640ee8f8"), Code="A set of rules which require conditions, or the adoption or use of one or more practices, means, methods, operations, or processes, reasonably necessary or appropriate to provide for a safe and healthy school environment.", Description="02625", Definition="", SortOrder=0 },
            new RefFacilityStandardType { Id=Guid.Parse("2d8f3bae-d5ae-4498-ab4e-ded083ae0677"), Code="A written or printed description of work to be done, forming part of the contract and describing qualities of material and mode of construction, and also giving dimensions and other information not shown in the drawings.", Description="02624", Definition="", SortOrder=0 },
            new RefFacilityStandardType { Id=Guid.Parse("29604db2-3097-40e8-b937-9bc91ec46717"), Code="Guidelines to assist the school district identify school building sites that are environmentally, educationally, and community appropriate.", Description="02627", Definition="", SortOrder=0 },
            new RefFacilityStandardType { Id=Guid.Parse("2bb834b1-c995-4d04-a50a-1c2ce2a9f409"), Code="A set of rules that specify the minimum acceptable amount of space required per student in a school building.", Description="02623", Definition="", SortOrder=0 },
            new RefFacilityStandardType { Id=Guid.Parse("99fc04ba-41a4-49aa-961d-9e2c4674a41f"), Code="Other is specified as an indication of the district or state requirements or guidelines for the design and construction of school facilities.", Description="09999", Definition="", SortOrder=0 },
        };

        /// <summary>
        /// The RefFacilityStandardType Pick List
         /// </summary>
        public static List<RefFacilityStandardType> RefFacilityStandardTypePickList = new List<RefFacilityStandardType> =
        {
            new RefFacilityStandardType { Id=Guid.Parse("ba9a8261-2d49-402c-97c5-55c227b8f567"), Code="The guidelines that establish site, building and room sizes, quality and type of finishes, systems, components, furnishings and fixtures of a facility.", SortOrder=0 },
            new RefFacilityStandardType { Id=Guid.Parse("5e3036f1-d404-4358-9dd9-f891a24e3657"), Code="The metrics for the levels of water, electricity, gas, oil, or coal consumption that a district seeks to meet on a district wide or facility specific basis.", SortOrder=0 },
            new RefFacilityStandardType { Id=Guid.Parse("8747fb30-f22a-4709-ad19-b531881f5306"), Code="A policy guideline that regulates the effect of human activity upon the environment. Standards may specify a desired state (e.g. daylighting should provide 75% of lighting needed for classrooms)or limit alterations (e.g. new school sites should be no more than 4 acres for an elementary school).", SortOrder=0 },
            new RefFacilityStandardType { Id=Guid.Parse("75d7f506-bc6f-4a87-b92a-fe89640ee8f8"), Code="A set of rules which require conditions, or the adoption or use of one or more practices, means, methods, operations, or processes, reasonably necessary or appropriate to provide for a safe and healthy school environment.", SortOrder=0 },
            new RefFacilityStandardType { Id=Guid.Parse("2d8f3bae-d5ae-4498-ab4e-ded083ae0677"), Code="A written or printed description of work to be done, forming part of the contract and describing qualities of material and mode of construction, and also giving dimensions and other information not shown in the drawings.", SortOrder=0 },
            new RefFacilityStandardType { Id=Guid.Parse("29604db2-3097-40e8-b937-9bc91ec46717"), Code="Guidelines to assist the school district identify school building sites that are environmentally, educationally, and community appropriate.", SortOrder=0 },
            new RefFacilityStandardType { Id=Guid.Parse("2bb834b1-c995-4d04-a50a-1c2ce2a9f409"), Code="A set of rules that specify the minimum acceptable amount of space required per student in a school building.", SortOrder=0 },
            new RefFacilityStandardType { Id=Guid.Parse("99fc04ba-41a4-49aa-961d-9e2c4674a41f"), Code="Other is specified as an indication of the district or state requirements or guidelines for the design and construction of school facilities.", SortOrder=0 },
       };
   }
}
