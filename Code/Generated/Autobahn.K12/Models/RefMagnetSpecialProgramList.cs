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
        /// The complete <see cref="RefMagnetSpecialProgramModel"> List
         /// </summary>
        public static List<RefMagnetSpecialProgramModel> RefMagnetSpecialProgramList = new List<RefMagnetSpecialProgramModel>
        {
            new RefMagnetSpecialProgram { Id=Guid.Parse("47d58155-913f-4c97-9399-f1666aba4d85"), Code="All", Description="All students participate", Definition="All students participate in the academic or social focus of the magnet or special program emphasis school.", SortOrder=Convert.ToDecimal("1.00") },
            new RefMagnetSpecialProgram { Id=Guid.Parse("11bf91ca-7523-4b29-80b9-2ca875cf5db4"), Code="None", Description="No students participate", Definition="No students participate in the academic or social focus of the magnet or special program emphasis school.", SortOrder=Convert.ToDecimal("2.00") },
            new RefMagnetSpecialProgram { Id=Guid.Parse("74ad5c14-ee31-40b8-b26a-3e23a7451642"), Code="Some", Description="Some, but not all, students participate", Definition="Some, but not all, students participate in the academic or social focus of the magnet or special program emphasis school.", SortOrder=Convert.ToDecimal("3.00") },
        };

        /// <summary>
        /// The Reference RefMagnetSpecialProgram Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefMagnetSpecialProgramViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefMagnetSpecialProgram { Id=Guid.Parse("47d58155-913f-4c97-9399-f1666aba4d85"), Description="All students participate", SortOrder=Convert.ToDecimal("1.00") },
            new RefMagnetSpecialProgram { Id=Guid.Parse("11bf91ca-7523-4b29-80b9-2ca875cf5db4"), Description="No students participate", SortOrder=Convert.ToDecimal("2.00") },
            new RefMagnetSpecialProgram { Id=Guid.Parse("74ad5c14-ee31-40b8-b26a-3e23a7451642"), Description="Some, but not all, students participate", SortOrder=Convert.ToDecimal("3.00") },
       };
   }
}
