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
        /// The complete <see cref="RefFacilityFurnishingsTypeModel"> List
         /// </summary>
        public static List<RefFacilityFurnishingsTypeModel> RefFacilityFurnishingsTypeList = new List<RefFacilityFurnishingsTypeModel>
        {
            new RefFacilityFurnishingsType { Id=Guid.Parse("97ce8ea5-cb37-436b-ad9d-cdb61e450631"), Code="00103", Description="Administrative office", Definition="A building or site used to house offices to support activities concerned with the overall business/management, planning, and evaluation of an education agency or school.", SortOrder=Convert.ToDecimal("1.00") },
            new RefFacilityFurnishingsType { Id=Guid.Parse("5d8d843b-9121-49d4-9949-65aa16e1a1e0"), Code="02792", Description="Cafeteria", Definition="A space equipped primarily for the preparation, serving, consumption and clean-up of food.", SortOrder=Convert.ToDecimal("2.00") },
            new RefFacilityFurnishingsType { Id=Guid.Parse("2b82936a-e5bf-4a5d-8829-514e195c917e"), Code="03014", Description="Classroom", Definition="A location on campus inside a classroom.", SortOrder=Convert.ToDecimal("3.00") },
            new RefFacilityFurnishingsType { Id=Guid.Parse("8323c7ed-8301-4c1a-9a3a-2c45c3beb0cf"), Code="00309", Description="Occupational therapy", Definition="Services that address the functional needs of an individual relating to adaptive development, adaptive behavior and play, and sensory, motor, and postural development. These services are designed to improve the individual's functional ability to perform tasks in the home, school, and community settings and include: 1) identification assessment and intervention; 2) adaptation of the environment, and selection, design and fabrication of assistive and orthodontic devices to facilitate the development and promote the acquisition of functional skills; and 3) prevention or minimization of the impact of initial or future impairment, delay in development, or loss of functional ability.", SortOrder=Convert.ToDecimal("4.00") },
            new RefFacilityFurnishingsType { Id=Guid.Parse("6b5ea9b1-b4da-42f7-9ca1-6fce45ff25b5"), Code="00559", Description="Physical education", Definition="A space equipped primarily for physical education.", SortOrder=Convert.ToDecimal("5.00") },
            new RefFacilityFurnishingsType { Id=Guid.Parse("d1972ab2-f5ed-4542-a047-3401d310a918"), Code="00313", Description="Physical therapy", Definition="Services to prevent or alleviate movement dysfunction and related functional problems that include: 1) screening, evaluation, and assessment of children and youth with disabilities to identify movement dysfunction; 2) obtaining, interpreting, and integrating information appropriate to program planning to prevent or alleviate movement dysfunction and related functional problems; and 3) providing individual or group services or treatment to prevent, alleviate, or compensate for movement dysfunction and related functional problems.", SortOrder=Convert.ToDecimal("6.00") },
        };

        /// <summary>
        /// The Reference RefFacilityFurnishingsType Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefFacilityFurnishingsTypeViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefFacilityFurnishingsType { Id=Guid.Parse("97ce8ea5-cb37-436b-ad9d-cdb61e450631"), Description="Administrative office", SortOrder=Convert.ToDecimal("1.00") },
            new RefFacilityFurnishingsType { Id=Guid.Parse("5d8d843b-9121-49d4-9949-65aa16e1a1e0"), Description="Cafeteria", SortOrder=Convert.ToDecimal("2.00") },
            new RefFacilityFurnishingsType { Id=Guid.Parse("2b82936a-e5bf-4a5d-8829-514e195c917e"), Description="Classroom", SortOrder=Convert.ToDecimal("3.00") },
            new RefFacilityFurnishingsType { Id=Guid.Parse("8323c7ed-8301-4c1a-9a3a-2c45c3beb0cf"), Description="Occupational therapy", SortOrder=Convert.ToDecimal("4.00") },
            new RefFacilityFurnishingsType { Id=Guid.Parse("6b5ea9b1-b4da-42f7-9ca1-6fce45ff25b5"), Description="Physical education", SortOrder=Convert.ToDecimal("5.00") },
            new RefFacilityFurnishingsType { Id=Guid.Parse("d1972ab2-f5ed-4542-a047-3401d310a918"), Description="Physical therapy", SortOrder=Convert.ToDecimal("6.00") },
       };
   }
}
