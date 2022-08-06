//**********************************************************
//* DomainName: Autobahn.Postsecondary
//* FileName:   RefNeedDeterminationMethodList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Postsecondary.Models
{
     /// <summary>
     /// The list of RefNeedDeterminationMethod Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefNeedDeterminationMethod"> List
         /// </summary>
        public static List<RefNeedDeterminationMethod> RefNeedDeterminationMethodList = new List<RefNeedDeterminationMethod> =
        {
            new RefNeedDeterminationMethod { Id=Guid.Parse("da0dabca-86a7-4a4b-801b-d6fc9a0546da"), Code="Federal", Description="Federal", Definition="", SortOrder=0 },
            new RefNeedDeterminationMethod { Id=Guid.Parse("bb2b8807-ce54-4c02-b213-1f275650c656"), Code="Institutional", Description="Institutional", Definition="", SortOrder=0 },
        };

        /// <summary>
        /// The RefNeedDeterminationMethod Pick List
         /// </summary>
        public static List<RefNeedDeterminationMethod> RefNeedDeterminationMethodPickList = new List<RefNeedDeterminationMethod> =
        {
            new RefNeedDeterminationMethod { Id=Guid.Parse("da0dabca-86a7-4a4b-801b-d6fc9a0546da"), Code="Federal", SortOrder=0 },
            new RefNeedDeterminationMethod { Id=Guid.Parse("bb2b8807-ce54-4c02-b213-1f275650c656"), Code="Institutional", SortOrder=0 },
       };
   }
}
