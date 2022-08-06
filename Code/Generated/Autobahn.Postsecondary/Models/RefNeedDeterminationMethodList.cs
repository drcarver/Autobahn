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
        public static List<RefNeedDeterminationMethod> RefNeedDeterminationMethodList = new List<RefNeedDeterminationMethod>
        {
            new RefNeedDeterminationMethod { Id=Guid.Parse("b87db85d-8a10-4f1f-8b68-f7eb529c4987"), Code="Federal", Description="Federal", Definition="Federal", SortOrder=Convert.ToDecimal("1.00") },
            new RefNeedDeterminationMethod { Id=Guid.Parse("6fc40ac5-d687-4ad5-9d36-330b21fc2a2a"), Code="Institutional", Description="Institutional", Definition="Institutional", SortOrder=Convert.ToDecimal("2.00") },
        };

        /// <summary>
        /// The RefNeedDeterminationMethod Pick List
         /// </summary>
        public static List<RefNeedDeterminationMethod> RefNeedDeterminationMethodPickList = new List<RefNeedDeterminationMethod>
        {
            new RefNeedDeterminationMethod { Id=Guid.Parse("b87db85d-8a10-4f1f-8b68-f7eb529c4987"), Code="Federal", Description="Federal", SortOrder=Convert.ToDecimal("1.00") },
            new RefNeedDeterminationMethod { Id=Guid.Parse("6fc40ac5-d687-4ad5-9d36-330b21fc2a2a"), Code="Institutional", Description="Institutional", SortOrder=Convert.ToDecimal("2.00") },
       };
   }
}
