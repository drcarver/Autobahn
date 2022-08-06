//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   RefMagnetSpecialProgramList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.K12.Models
{
     /// <summary>
     /// The list of RefMagnetSpecialProgram Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefMagnetSpecialProgram"> List
         /// </summary>
        public static List<RefMagnetSpecialProgram> RefMagnetSpecialProgramList = new List<RefMagnetSpecialProgram>
        {
            new RefMagnetSpecialProgram { Id=Guid.Parse("64b93ea4-d621-40cd-aa7f-0274808400d5"), Code="All", Description="All students participate", Definition="All students participate in the academic or social focus of the magnet or special program emphasis school.", SortOrder=Convert.ToDecimal("1.00") },
            new RefMagnetSpecialProgram { Id=Guid.Parse("d9fcbfe0-c753-4e0c-828c-f615b50f2b85"), Code="None", Description="No students participate", Definition="No students participate in the academic or social focus of the magnet or special program emphasis school.", SortOrder=Convert.ToDecimal("2.00") },
            new RefMagnetSpecialProgram { Id=Guid.Parse("6c89630f-0aba-44e0-b94f-2e68c61666c8"), Code="Some", Description="Some, but not all, students participate", Definition="Some, but not all, students participate in the academic or social focus of the magnet or special program emphasis school.", SortOrder=Convert.ToDecimal("3.00") },
        };

        /// <summary>
        /// The RefMagnetSpecialProgram Pick List
         /// </summary>
        public static List<RefMagnetSpecialProgram> RefMagnetSpecialProgramPickList = new List<RefMagnetSpecialProgram>
        {
            new RefMagnetSpecialProgram { Id=Guid.Parse("64b93ea4-d621-40cd-aa7f-0274808400d5"), Code="All", Description="All students participate", SortOrder=Convert.ToDecimal("1.00") },
            new RefMagnetSpecialProgram { Id=Guid.Parse("d9fcbfe0-c753-4e0c-828c-f615b50f2b85"), Code="None", Description="No students participate", SortOrder=Convert.ToDecimal("2.00") },
            new RefMagnetSpecialProgram { Id=Guid.Parse("6c89630f-0aba-44e0-b94f-2e68c61666c8"), Code="Some", Description="Some, but not all, students participate", SortOrder=Convert.ToDecimal("3.00") },
       };
   }
}
