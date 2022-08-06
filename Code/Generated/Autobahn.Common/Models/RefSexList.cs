//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefSexList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefSex Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefSex"> List
         /// </summary>
        public static List<RefSex> RefSexList = new List<RefSex> =
        {
            new RefSex { Id=Guid.Parse("0798fc26-0bf2-420e-9bf2-366eb07c7864"), Code="Male", Description="Male", Definition="", SortOrder=0 },
            new RefSex { Id=Guid.Parse("30d7f5f0-165d-4345-ba2c-9f96a77311f0"), Code="Female", Description="Female", Definition="", SortOrder=0 },
            new RefSex { Id=Guid.Parse("db204484-6204-44f6-9331-314baa085946"), Code="Gender is not selected", Description="NotSelected", Definition="", SortOrder=0 },
        };

        /// <summary>
        /// The RefSex Pick List
         /// </summary>
        public static List<RefSex> RefSexPickList = new List<RefSex> =
        {
            new RefSex { Id=Guid.Parse("0798fc26-0bf2-420e-9bf2-366eb07c7864"), Code="Male", SortOrder=0 },
            new RefSex { Id=Guid.Parse("30d7f5f0-165d-4345-ba2c-9f96a77311f0"), Code="Female", SortOrder=0 },
            new RefSex { Id=Guid.Parse("db204484-6204-44f6-9331-314baa085946"), Code="Gender is not selected", SortOrder=0 },
       };
   }
}
