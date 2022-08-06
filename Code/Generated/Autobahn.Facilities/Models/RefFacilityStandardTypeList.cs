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
        public static List<RefFacilityStandardType> RefFacilityStandardTypeList = new List<RefFacilityStandardType>
        {
            new RefFacilityStandardType { Id=Guid.Parse("52e3b2c1-3876-480c-8d44-167d19dd6752"), Code="02622", Description="Design guidelines", Definition="The guidelines that establish site, building and room sizes, quality and type of finishes, systems, components, furnishings and fixtures of a facility.", SortOrder=Convert.ToDecimal("1.00") },
            new RefFacilityStandardType { Id=Guid.Parse("1f621af0-afcf-4bb2-9e08-946a3519c877"), Code="02626", Description="Energy performance standards", Definition="The metrics for the levels of water, electricity, gas, oil, or coal consumption that a district seeks to meet on a district wide or facility specific basis.", SortOrder=Convert.ToDecimal("2.00") },
            new RefFacilityStandardType { Id=Guid.Parse("dc8dc38e-d942-4cbc-b4b5-679537f2f3e7"), Code="13628", Description="Environmental Standards", Definition="A policy guideline that regulates the effect of human activity upon the environment. Standards may specify a desired state (e.g. daylighting should provide 75% of lighting needed for classrooms)or limit alterations (e.g. new school sites should be no more than 4 acres for an elementary school).", SortOrder=Convert.ToDecimal("3.00") },
            new RefFacilityStandardType { Id=Guid.Parse("bfbe3cd8-ed3c-4723-8ad5-09d40559a8be"), Code="02625", Description="Health and safety standards", Definition="A set of rules which require conditions, or the adoption or use of one or more practices, means, methods, operations, or processes, reasonably necessary or appropriate to provide for a safe and healthy school environment.", SortOrder=Convert.ToDecimal("4.00") },
            new RefFacilityStandardType { Id=Guid.Parse("7c85f1ef-7606-45a9-9086-a5b08984a149"), Code="02624", Description="Master construction specifications", Definition="A written or printed description of work to be done, forming part of the contract and describing qualities of material and mode of construction, and also giving dimensions and other information not shown in the drawings.", SortOrder=Convert.ToDecimal("5.00") },
            new RefFacilityStandardType { Id=Guid.Parse("dde091e4-c324-478e-8982-a00f100d0fe4"), Code="02627", Description="Site selection guidelines", Definition="Guidelines to assist the school district identify school building sites that are environmentally, educationally, and community appropriate.", SortOrder=Convert.ToDecimal("6.00") },
            new RefFacilityStandardType { Id=Guid.Parse("9d6ee6e8-b3d2-4945-ab06-b09c718ed35b"), Code="02623", Description="Space standards", Definition="A set of rules that specify the minimum acceptable amount of space required per student in a school building.", SortOrder=Convert.ToDecimal("7.00") },
            new RefFacilityStandardType { Id=Guid.Parse("3d96514c-7856-457b-aee3-9f9b883745a9"), Code="09999", Description="Other", Definition="Other is specified as an indication of the district or state requirements or guidelines for the design and construction of school facilities.", SortOrder=Convert.ToDecimal("99.00") },
        };

        /// <summary>
        /// The RefFacilityStandardType Pick List
         /// </summary>
        public static List<RefFacilityStandardType> RefFacilityStandardTypePickList = new List<RefFacilityStandardType>
        {
            new RefFacilityStandardType { Id=Guid.Parse("52e3b2c1-3876-480c-8d44-167d19dd6752"), Code="02622", Description="Design guidelines", SortOrder=Convert.ToDecimal("1.00") },
            new RefFacilityStandardType { Id=Guid.Parse("1f621af0-afcf-4bb2-9e08-946a3519c877"), Code="02626", Description="Energy performance standards", SortOrder=Convert.ToDecimal("2.00") },
            new RefFacilityStandardType { Id=Guid.Parse("dc8dc38e-d942-4cbc-b4b5-679537f2f3e7"), Code="13628", Description="Environmental Standards", SortOrder=Convert.ToDecimal("3.00") },
            new RefFacilityStandardType { Id=Guid.Parse("bfbe3cd8-ed3c-4723-8ad5-09d40559a8be"), Code="02625", Description="Health and safety standards", SortOrder=Convert.ToDecimal("4.00") },
            new RefFacilityStandardType { Id=Guid.Parse("7c85f1ef-7606-45a9-9086-a5b08984a149"), Code="02624", Description="Master construction specifications", SortOrder=Convert.ToDecimal("5.00") },
            new RefFacilityStandardType { Id=Guid.Parse("dde091e4-c324-478e-8982-a00f100d0fe4"), Code="02627", Description="Site selection guidelines", SortOrder=Convert.ToDecimal("6.00") },
            new RefFacilityStandardType { Id=Guid.Parse("9d6ee6e8-b3d2-4945-ab06-b09c718ed35b"), Code="02623", Description="Space standards", SortOrder=Convert.ToDecimal("7.00") },
            new RefFacilityStandardType { Id=Guid.Parse("3d96514c-7856-457b-aee3-9f9b883745a9"), Code="09999", Description="Other", SortOrder=Convert.ToDecimal("99.00") },
       };
   }
}
