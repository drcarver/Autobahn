//**********************************************************
//* DomainName: Autobahn.Facilities
//* FileName:   RefFacilityFurnishingsTypeList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Facilities.Models
{
     /// <summary>
     /// The list of RefFacilityFurnishingsType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefFacilityFurnishingsType"> List
         /// </summary>
        public static List<RefFacilityFurnishingsType> RefFacilityFurnishingsTypeList = new List<RefFacilityFurnishingsType> =
        {
            new RefFacilityFurnishingsType { Id=Guid.Parse("faf9a774-9042-405d-9bd5-182512102d18"), Code="A building or site used to house offices to support activities concerned with the overall business/management, planning, and evaluation of an education agency or school.", Description="00103", Definition="", SortOrder=0 },
            new RefFacilityFurnishingsType { Id=Guid.Parse("27b13586-1454-458d-bd04-7dc31ea5159c"), Code="A space equipped primarily for the preparation, serving, consumption and clean-up of food.", Description="02792", Definition="", SortOrder=0 },
            new RefFacilityFurnishingsType { Id=Guid.Parse("f715764a-bf42-4bf0-b2af-10fbd5bfdc28"), Code="A location on campus inside a classroom.", Description="03014", Definition="", SortOrder=0 },
            new RefFacilityFurnishingsType { Id=Guid.Parse("73f96b5f-7099-42a6-83db-2cb4ebdc6f0e"), Code="Services that address the functional needs of an individual relating to adaptive development, adaptive behavior and play, and sensory, motor, and postural development. These services are designed to improve the individual's functional ability to perform tasks in the home, school, and community settings and include: 1) identification assessment and intervention; 2) adaptation of the environment, and selection, design and fabrication of assistive and orthodontic devices to facilitate the development and promote the acquisition of functional skills; and 3) prevention or minimization of the impact of initial or future impairment, delay in development, or loss of functional ability.", Description="00309", Definition="", SortOrder=0 },
            new RefFacilityFurnishingsType { Id=Guid.Parse("1c3c1d6c-fd5a-4ed8-b04c-9c217377d712"), Code="A space equipped primarily for physical education.", Description="00559", Definition="", SortOrder=0 },
            new RefFacilityFurnishingsType { Id=Guid.Parse("8045eb44-e7b2-40fe-97b7-d252caddd41d"), Code="Services to prevent or alleviate movement dysfunction and related functional problems that include: 1) screening, evaluation, and assessment of children and youth with disabilities to identify movement dysfunction; 2) obtaining, interpreting, and integrating information appropriate to program planning to prevent or alleviate movement dysfunction and related functional problems; and 3) providing individual or group services or treatment to prevent, alleviate, or compensate for movement dysfunction and related functional problems.", Description="00313", Definition="", SortOrder=0 },
        };

        /// <summary>
        /// The RefFacilityFurnishingsType Pick List
         /// </summary>
        public static List<RefFacilityFurnishingsType> RefFacilityFurnishingsTypePickList = new List<RefFacilityFurnishingsType> =
        {
            new RefFacilityFurnishingsType { Id=Guid.Parse("faf9a774-9042-405d-9bd5-182512102d18"), Code="A building or site used to house offices to support activities concerned with the overall business/management, planning, and evaluation of an education agency or school.", SortOrder=0 },
            new RefFacilityFurnishingsType { Id=Guid.Parse("27b13586-1454-458d-bd04-7dc31ea5159c"), Code="A space equipped primarily for the preparation, serving, consumption and clean-up of food.", SortOrder=0 },
            new RefFacilityFurnishingsType { Id=Guid.Parse("f715764a-bf42-4bf0-b2af-10fbd5bfdc28"), Code="A location on campus inside a classroom.", SortOrder=0 },
            new RefFacilityFurnishingsType { Id=Guid.Parse("73f96b5f-7099-42a6-83db-2cb4ebdc6f0e"), Code="Services that address the functional needs of an individual relating to adaptive development, adaptive behavior and play, and sensory, motor, and postural development. These services are designed to improve the individual's functional ability to perform tasks in the home, school, and community settings and include: 1) identification assessment and intervention; 2) adaptation of the environment, and selection, design and fabrication of assistive and orthodontic devices to facilitate the development and promote the acquisition of functional skills; and 3) prevention or minimization of the impact of initial or future impairment, delay in development, or loss of functional ability.", SortOrder=0 },
            new RefFacilityFurnishingsType { Id=Guid.Parse("1c3c1d6c-fd5a-4ed8-b04c-9c217377d712"), Code="A space equipped primarily for physical education.", SortOrder=0 },
            new RefFacilityFurnishingsType { Id=Guid.Parse("8045eb44-e7b2-40fe-97b7-d252caddd41d"), Code="Services to prevent or alleviate movement dysfunction and related functional problems that include: 1) screening, evaluation, and assessment of children and youth with disabilities to identify movement dysfunction; 2) obtaining, interpreting, and integrating information appropriate to program planning to prevent or alleviate movement dysfunction and related functional problems; and 3) providing individual or group services or treatment to prevent, alleviate, or compensate for movement dysfunction and related functional problems.", SortOrder=0 },
       };
   }
}
