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
        public static List<RefBuildingInstructionalSpaceFactorType> RefBuildingInstructionalSpaceFactorTypeList = new List<RefBuildingInstructionalSpaceFactorType> =
        {
            new RefBuildingInstructionalSpaceFactorType { Id=Guid.Parse("37de3166-c003-4f83-b886-b76e9ea8b606"), Code="A space designed and used primarily or exclusively for instruction and direct instructional support, including basic and specialty classrooms, laboratories, studios, science prep rooms, library/media center spaces, and indoor physical education spaces.", Description="02811", Definition="", SortOrder=0 },
            new RefBuildingInstructionalSpaceFactorType { Id=Guid.Parse("d94cbcfc-5d88-4299-8995-81f150634574"), Code="Any space that is not classified as instructional, including areas designed primarily for administration and student services, common areas used by students, such as cafeteria and auditorium, but that are generally not used for instruction, as well as required for the general operation of the building (such as hallways, stairwells, custodial, mechanical, and storage areas).", Description="02812", Definition="", SortOrder=0 },
        };

        /// <summary>
        /// The RefBuildingInstructionalSpaceFactorType Pick List
         /// </summary>
        public static List<RefBuildingInstructionalSpaceFactorType> RefBuildingInstructionalSpaceFactorTypePickList = new List<RefBuildingInstructionalSpaceFactorType> =
        {
            new RefBuildingInstructionalSpaceFactorType { Id=Guid.Parse("37de3166-c003-4f83-b886-b76e9ea8b606"), Code="A space designed and used primarily or exclusively for instruction and direct instructional support, including basic and specialty classrooms, laboratories, studios, science prep rooms, library/media center spaces, and indoor physical education spaces.", SortOrder=0 },
            new RefBuildingInstructionalSpaceFactorType { Id=Guid.Parse("d94cbcfc-5d88-4299-8995-81f150634574"), Code="Any space that is not classified as instructional, including areas designed primarily for administration and student services, common areas used by students, such as cafeteria and auditorium, but that are generally not used for instruction, as well as required for the general operation of the building (such as hallways, stairwells, custodial, mechanical, and storage areas).", SortOrder=0 },
       };
   }
}
