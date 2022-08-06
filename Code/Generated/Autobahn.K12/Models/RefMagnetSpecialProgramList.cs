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
        public static List<RefMagnetSpecialProgram> RefMagnetSpecialProgramList = new List<RefMagnetSpecialProgram> =
        {
            new RefMagnetSpecialProgram { Id=Guid.Parse("aa888def-2735-4f31-8a9f-1b8c8b84eb50"), Code="All students participate in the academic or social focus of the magnet or special program emphasis school.", Description="All", Definition="", SortOrder=0 },
            new RefMagnetSpecialProgram { Id=Guid.Parse("9d624131-4122-4724-bfef-9b328bf23407"), Code="No students participate in the academic or social focus of the magnet or special program emphasis school.", Description="None", Definition="", SortOrder=0 },
            new RefMagnetSpecialProgram { Id=Guid.Parse("38019319-2e72-43de-82ad-79b91260934c"), Code="Some, but not all, students participate in the academic or social focus of the magnet or special program emphasis school.", Description="Some", Definition="", SortOrder=0 },
        };

        /// <summary>
        /// The RefMagnetSpecialProgram Pick List
         /// </summary>
        public static List<RefMagnetSpecialProgram> RefMagnetSpecialProgramPickList = new List<RefMagnetSpecialProgram> =
        {
            new RefMagnetSpecialProgram { Id=Guid.Parse("aa888def-2735-4f31-8a9f-1b8c8b84eb50"), Code="All students participate in the academic or social focus of the magnet or special program emphasis school.", SortOrder=0 },
            new RefMagnetSpecialProgram { Id=Guid.Parse("9d624131-4122-4724-bfef-9b328bf23407"), Code="No students participate in the academic or social focus of the magnet or special program emphasis school.", SortOrder=0 },
            new RefMagnetSpecialProgram { Id=Guid.Parse("38019319-2e72-43de-82ad-79b91260934c"), Code="Some, but not all, students participate in the academic or social focus of the magnet or special program emphasis school.", SortOrder=0 },
       };
   }
}
