//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefMepProjectBasedList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefMepProjectBased Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefMepProjectBased"> List
         /// </summary>
        public static List<RefMepProjectBased> RefMepProjectBasedList = new List<RefMepProjectBased>
        {
            new RefMepProjectBased { Id=Guid.Parse("ca114b1b-1a61-4c0e-a592-5ee48b35586e"), Code="SchoolBased", Description="School-based MEP Project", Definition="School-based Migrant Education Program Project", SortOrder=Convert.ToDecimal("1.00") },
            new RefMepProjectBased { Id=Guid.Parse("b599e2e2-f2f3-49a9-a8d7-3d4e51ceb1fb"), Code="NonSchoolBased", Description="Non-school-based MEP project", Definition="Non-school-based Migrant Education Program project", SortOrder=Convert.ToDecimal("2.00") },
        };

        /// <summary>
        /// The RefMepProjectBased Pick List
         /// </summary>
        public static List<RefMepProjectBased> RefMepProjectBasedPickList = new List<RefMepProjectBased>
        {
            new RefMepProjectBased { Id=Guid.Parse("ca114b1b-1a61-4c0e-a592-5ee48b35586e"), Code="SchoolBased", Description="School-based MEP Project", SortOrder=Convert.ToDecimal("1.00") },
            new RefMepProjectBased { Id=Guid.Parse("b599e2e2-f2f3-49a9-a8d7-3d4e51ceb1fb"), Code="NonSchoolBased", Description="Non-school-based MEP project", SortOrder=Convert.ToDecimal("2.00") },
       };
   }
}
