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
        /// The complete <see cref="RefFacilityStandardTypeModel"> List
         /// </summary>
        public static List<RefFacilityStandardTypeModel> RefFacilityStandardTypeList = new List<RefFacilityStandardTypeModel>
        {
            new RefFacilityStandardType { Id=Guid.Parse("fed97359-ca4f-444c-8093-71bded32d12f"), Code="02622", Description="Design guidelines", Definition="The guidelines that establish site, building and room sizes, quality and type of finishes, systems, components, furnishings and fixtures of a facility.", SortOrder=Convert.ToDecimal("1.00") },
            new RefFacilityStandardType { Id=Guid.Parse("bd6733b0-ff73-4942-8505-4990d6c7f63f"), Code="02626", Description="Energy performance standards", Definition="The metrics for the levels of water, electricity, gas, oil, or coal consumption that a district seeks to meet on a district wide or facility specific basis.", SortOrder=Convert.ToDecimal("2.00") },
            new RefFacilityStandardType { Id=Guid.Parse("cc21c1df-93fb-4b0f-9bb6-01dcf31e2abd"), Code="13628", Description="Environmental Standards", Definition="A policy guideline that regulates the effect of human activity upon the environment. Standards may specify a desired state (e.g. daylighting should provide 75% of lighting needed for classrooms)or limit alterations (e.g. new school sites should be no more than 4 acres for an elementary school).", SortOrder=Convert.ToDecimal("3.00") },
            new RefFacilityStandardType { Id=Guid.Parse("777e0f68-e2d1-430e-aa5e-d510203c64c0"), Code="02625", Description="Health and safety standards", Definition="A set of rules which require conditions, or the adoption or use of one or more practices, means, methods, operations, or processes, reasonably necessary or appropriate to provide for a safe and healthy school environment.", SortOrder=Convert.ToDecimal("4.00") },
            new RefFacilityStandardType { Id=Guid.Parse("003c167f-4dc2-4773-adfa-75eb39006e9c"), Code="02624", Description="Master construction specifications", Definition="A written or printed description of work to be done, forming part of the contract and describing qualities of material and mode of construction, and also giving dimensions and other information not shown in the drawings.", SortOrder=Convert.ToDecimal("5.00") },
            new RefFacilityStandardType { Id=Guid.Parse("99e013d2-8958-4a15-ba39-51e478a9958a"), Code="02627", Description="Site selection guidelines", Definition="Guidelines to assist the school district identify school building sites that are environmentally, educationally, and community appropriate.", SortOrder=Convert.ToDecimal("6.00") },
            new RefFacilityStandardType { Id=Guid.Parse("2e8196d3-7236-4201-b2b4-b0ca3fcd633a"), Code="02623", Description="Space standards", Definition="A set of rules that specify the minimum acceptable amount of space required per student in a school building.", SortOrder=Convert.ToDecimal("7.00") },
            new RefFacilityStandardType { Id=Guid.Parse("b330d352-375e-4f0a-a30f-5d6f4f0b5b5f"), Code="09999", Description="Other", Definition="Other is specified as an indication of the district or state requirements or guidelines for the design and construction of school facilities.", SortOrder=Convert.ToDecimal("99.00") },
        };

        /// <summary>
        /// The Reference RefFacilityStandardType Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefFacilityStandardTypeViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefFacilityStandardType { Id=Guid.Parse("fed97359-ca4f-444c-8093-71bded32d12f"), Description="Design guidelines", SortOrder=Convert.ToDecimal("1.00") },
            new RefFacilityStandardType { Id=Guid.Parse("bd6733b0-ff73-4942-8505-4990d6c7f63f"), Description="Energy performance standards", SortOrder=Convert.ToDecimal("2.00") },
            new RefFacilityStandardType { Id=Guid.Parse("cc21c1df-93fb-4b0f-9bb6-01dcf31e2abd"), Description="Environmental Standards", SortOrder=Convert.ToDecimal("3.00") },
            new RefFacilityStandardType { Id=Guid.Parse("777e0f68-e2d1-430e-aa5e-d510203c64c0"), Description="Health and safety standards", SortOrder=Convert.ToDecimal("4.00") },
            new RefFacilityStandardType { Id=Guid.Parse("003c167f-4dc2-4773-adfa-75eb39006e9c"), Description="Master construction specifications", SortOrder=Convert.ToDecimal("5.00") },
            new RefFacilityStandardType { Id=Guid.Parse("99e013d2-8958-4a15-ba39-51e478a9958a"), Description="Site selection guidelines", SortOrder=Convert.ToDecimal("6.00") },
            new RefFacilityStandardType { Id=Guid.Parse("2e8196d3-7236-4201-b2b4-b0ca3fcd633a"), Description="Space standards", SortOrder=Convert.ToDecimal("7.00") },
            new RefFacilityStandardType { Id=Guid.Parse("b330d352-375e-4f0a-a30f-5d6f4f0b5b5f"), Description="Other", SortOrder=Convert.ToDecimal("99.00") },
       };
   }
}
