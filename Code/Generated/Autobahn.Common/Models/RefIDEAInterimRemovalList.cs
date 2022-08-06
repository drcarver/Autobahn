//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefIDEAInterimRemovalList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefIDEAInterimRemoval Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefIDEAInterimRemoval"> List
         /// </summary>
        public static List<RefIDEAInterimRemoval> RefIDEAInterimRemovalList = new List<RefIDEAInterimRemoval> =
        {
            new RefIDEAInterimRemoval { Id=Guid.Parse("523ed2a1-f7f5-41fc-b4c6-866dbc9f9684"), Code="Unilateral removal to an interim alternative educational setting by School Personnel for drugs, weapons, or serious bodily injury", Description="REMDW", Definition="", SortOrder=0 },
            new RefIDEAInterimRemoval { Id=Guid.Parse("d1179dab-5357-403c-827d-9a9465c190b2"), Code="Removed to an interim alternative educational setting based on a Hearing Officer finding that there is substantial likelihood of injury to the child or others", Description="REMHO", Definition="", SortOrder=0 },
        };

        /// <summary>
        /// The RefIDEAInterimRemoval Pick List
         /// </summary>
        public static List<RefIDEAInterimRemoval> RefIDEAInterimRemovalPickList = new List<RefIDEAInterimRemoval> =
        {
            new RefIDEAInterimRemoval { Id=Guid.Parse("523ed2a1-f7f5-41fc-b4c6-866dbc9f9684"), Code="Unilateral removal to an interim alternative educational setting by School Personnel for drugs, weapons, or serious bodily injury", SortOrder=0 },
            new RefIDEAInterimRemoval { Id=Guid.Parse("d1179dab-5357-403c-827d-9a9465c190b2"), Code="Removed to an interim alternative educational setting based on a Hearing Officer finding that there is substantial likelihood of injury to the child or others", SortOrder=0 },
       };
   }
}
