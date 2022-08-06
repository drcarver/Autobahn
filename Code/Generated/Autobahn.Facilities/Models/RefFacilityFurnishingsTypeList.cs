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
        public static List<RefFacilityFurnishingsType> RefFacilityFurnishingsTypeList = new List<RefFacilityFurnishingsType>
        {
            new RefFacilityFurnishingsType { Id=Guid.Parse("6e410c3d-fe29-4bec-b67c-569ad4afbda5"), Code="00103", Description="Administrative office", Definition="A building or site used to house offices to support activities concerned with the overall business/management, planning, and evaluation of an education agency or school.", SortOrder=Convert.ToDecimal("1.00") },
            new RefFacilityFurnishingsType { Id=Guid.Parse("b62f1ab4-dee9-4277-bdfa-7d97dd8cbd09"), Code="02792", Description="Cafeteria", Definition="A space equipped primarily for the preparation, serving, consumption and clean-up of food.", SortOrder=Convert.ToDecimal("2.00") },
            new RefFacilityFurnishingsType { Id=Guid.Parse("ed86ba55-168e-481a-8421-27f36e373512"), Code="03014", Description="Classroom", Definition="A location on campus inside a classroom.", SortOrder=Convert.ToDecimal("3.00") },
            new RefFacilityFurnishingsType { Id=Guid.Parse("fd1d08f7-e345-447f-a69f-03c9330b0013"), Code="00309", Description="Occupational therapy", Definition="Services that address the functional needs of an individual relating to adaptive development, adaptive behavior and play, and sensory, motor, and postural development. These services are designed to improve the individual's functional ability to perform tasks in the home, school, and community settings and include: 1) identification assessment and intervention; 2) adaptation of the environment, and selection, design and fabrication of assistive and orthodontic devices to facilitate the development and promote the acquisition of functional skills; and 3) prevention or minimization of the impact of initial or future impairment, delay in development, or loss of functional ability.", SortOrder=Convert.ToDecimal("4.00") },
            new RefFacilityFurnishingsType { Id=Guid.Parse("7ced957c-8f79-410a-8e78-f0db9419c0db"), Code="00559", Description="Physical education", Definition="A space equipped primarily for physical education.", SortOrder=Convert.ToDecimal("5.00") },
            new RefFacilityFurnishingsType { Id=Guid.Parse("2dc36a3e-5fc2-4ffc-a677-0ec835f14bda"), Code="00313", Description="Physical therapy", Definition="Services to prevent or alleviate movement dysfunction and related functional problems that include: 1) screening, evaluation, and assessment of children and youth with disabilities to identify movement dysfunction; 2) obtaining, interpreting, and integrating information appropriate to program planning to prevent or alleviate movement dysfunction and related functional problems; and 3) providing individual or group services or treatment to prevent, alleviate, or compensate for movement dysfunction and related functional problems.", SortOrder=Convert.ToDecimal("6.00") },
        };

        /// <summary>
        /// The RefFacilityFurnishingsType Pick List
         /// </summary>
        public static List<RefFacilityFurnishingsType> RefFacilityFurnishingsTypePickList = new List<RefFacilityFurnishingsType>
        {
            new RefFacilityFurnishingsType { Id=Guid.Parse("6e410c3d-fe29-4bec-b67c-569ad4afbda5"), Code="00103", Description="Administrative office", SortOrder=Convert.ToDecimal("1.00") },
            new RefFacilityFurnishingsType { Id=Guid.Parse("b62f1ab4-dee9-4277-bdfa-7d97dd8cbd09"), Code="02792", Description="Cafeteria", SortOrder=Convert.ToDecimal("2.00") },
            new RefFacilityFurnishingsType { Id=Guid.Parse("ed86ba55-168e-481a-8421-27f36e373512"), Code="03014", Description="Classroom", SortOrder=Convert.ToDecimal("3.00") },
            new RefFacilityFurnishingsType { Id=Guid.Parse("fd1d08f7-e345-447f-a69f-03c9330b0013"), Code="00309", Description="Occupational therapy", SortOrder=Convert.ToDecimal("4.00") },
            new RefFacilityFurnishingsType { Id=Guid.Parse("7ced957c-8f79-410a-8e78-f0db9419c0db"), Code="00559", Description="Physical education", SortOrder=Convert.ToDecimal("5.00") },
            new RefFacilityFurnishingsType { Id=Guid.Parse("2dc36a3e-5fc2-4ffc-a677-0ec835f14bda"), Code="00313", Description="Physical therapy", SortOrder=Convert.ToDecimal("6.00") },
       };
   }
}
