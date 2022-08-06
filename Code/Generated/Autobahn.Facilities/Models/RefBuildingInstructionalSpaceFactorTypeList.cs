//**********************************************************
//* DomainName: Autobahn.Facilities
//* FileName:   RefBuildingInstructionalSpaceFactorTypeList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Facilities.Models
{
     /// <summary>
     /// The list of RefBuildingInstructionalSpaceFactorType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefBuildingInstructionalSpaceFactorType"> List
         /// </summary>
        public static List<RefBuildingInstructionalSpaceFactorType> RefBuildingInstructionalSpaceFactorTypeList = new List<RefBuildingInstructionalSpaceFactorType>
        {
            new RefBuildingInstructionalSpaceFactorType { Id=Guid.Parse("898ba6de-024d-40d7-87ac-0d823404eada"), Code="02811", Description="Instructional space", Definition="A space designed and used primarily or exclusively for instruction and direct instructional support, including basic and specialty classrooms, laboratories, studios, science prep rooms, library/media center spaces, and indoor physical education spaces.", SortOrder=Convert.ToDecimal("1.00") },
            new RefBuildingInstructionalSpaceFactorType { Id=Guid.Parse("835ee388-e5fa-4826-ba7e-6f26b255e679"), Code="02812", Description="Noninstructional space", Definition="Any space that is not classified as instructional, including areas designed primarily for administration and student services, common areas used by students, such as cafeteria and auditorium, but that are generally not used for instruction, as well as required for the general operation of the building (such as hallways, stairwells, custodial, mechanical, and storage areas).", SortOrder=Convert.ToDecimal("2.00") },
        };

        /// <summary>
        /// The RefBuildingInstructionalSpaceFactorType Pick List
         /// </summary>
        public static List<RefBuildingInstructionalSpaceFactorType> RefBuildingInstructionalSpaceFactorTypePickList = new List<RefBuildingInstructionalSpaceFactorType>
        {
            new RefBuildingInstructionalSpaceFactorType { Id=Guid.Parse("898ba6de-024d-40d7-87ac-0d823404eada"), Code="02811", Description="Instructional space", SortOrder=Convert.ToDecimal("1.00") },
            new RefBuildingInstructionalSpaceFactorType { Id=Guid.Parse("835ee388-e5fa-4826-ba7e-6f26b255e679"), Code="02812", Description="Noninstructional space", SortOrder=Convert.ToDecimal("2.00") },
       };
   }
}
