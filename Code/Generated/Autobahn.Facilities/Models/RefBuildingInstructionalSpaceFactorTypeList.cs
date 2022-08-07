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
        /// The complete <see cref="RefBuildingInstructionalSpaceFactorTypeModel"> List
         /// </summary>
        public static List<RefBuildingInstructionalSpaceFactorTypeModel> RefBuildingInstructionalSpaceFactorTypeList = new List<RefBuildingInstructionalSpaceFactorTypeModel>
        {
            new RefBuildingInstructionalSpaceFactorType { Id=Guid.Parse("ac311fdf-801e-4257-a631-ac15134663fc"), Code="02811", Description="Instructional space", Definition="A space designed and used primarily or exclusively for instruction and direct instructional support, including basic and specialty classrooms, laboratories, studios, science prep rooms, library/media center spaces, and indoor physical education spaces.", SortOrder=Convert.ToDecimal("1.00") },
            new RefBuildingInstructionalSpaceFactorType { Id=Guid.Parse("df1ed55b-b20f-4eba-a648-f6ec662d148d"), Code="02812", Description="Noninstructional space", Definition="Any space that is not classified as instructional, including areas designed primarily for administration and student services, common areas used by students, such as cafeteria and auditorium, but that are generally not used for instruction, as well as required for the general operation of the building (such as hallways, stairwells, custodial, mechanical, and storage areas).", SortOrder=Convert.ToDecimal("2.00") },
        };

        /// <summary>
        /// The Reference RefBuildingInstructionalSpaceFactorType Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefBuildingInstructionalSpaceFactorTypeViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefBuildingInstructionalSpaceFactorType { Id=Guid.Parse("ac311fdf-801e-4257-a631-ac15134663fc"), Description="Instructional space", SortOrder=Convert.ToDecimal("1.00") },
            new RefBuildingInstructionalSpaceFactorType { Id=Guid.Parse("df1ed55b-b20f-4eba-a648-f6ec662d148d"), Description="Noninstructional space", SortOrder=Convert.ToDecimal("2.00") },
       };
   }
}
