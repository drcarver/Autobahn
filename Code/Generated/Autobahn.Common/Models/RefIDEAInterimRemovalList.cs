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
        public static List<RefIDEAInterimRemoval> RefIDEAInterimRemovalList = new List<RefIDEAInterimRemoval>
        {
            new RefIDEAInterimRemoval { Id=Guid.Parse("561394a5-d89c-4067-a4a2-84135326fe45"), Code="REMDW", Description="Removal for drugs, weapons, or serious bodily injury", Definition="Unilateral removal to an interim alternative educational setting by School Personnel for drugs, weapons, or serious bodily injury", SortOrder=Convert.ToDecimal("1.00") },
            new RefIDEAInterimRemoval { Id=Guid.Parse("fa3b0d76-9247-4c80-8926-6b5dd9cd5584"), Code="REMHO", Description="Removed based on a Hearing Officer finding", Definition="Removed to an interim alternative educational setting based on a Hearing Officer finding that there is substantial likelihood of injury to the child or others", SortOrder=Convert.ToDecimal("2.00") },
        };

        /// <summary>
        /// The RefIDEAInterimRemoval Pick List
         /// </summary>
        public static List<RefIDEAInterimRemoval> RefIDEAInterimRemovalPickList = new List<RefIDEAInterimRemoval>
        {
            new RefIDEAInterimRemoval { Id=Guid.Parse("561394a5-d89c-4067-a4a2-84135326fe45"), Code="REMDW", Description="Removal for drugs, weapons, or serious bodily injury", SortOrder=Convert.ToDecimal("1.00") },
            new RefIDEAInterimRemoval { Id=Guid.Parse("fa3b0d76-9247-4c80-8926-6b5dd9cd5584"), Code="REMHO", Description="Removed based on a Hearing Officer finding", SortOrder=Convert.ToDecimal("2.00") },
       };
   }
}
