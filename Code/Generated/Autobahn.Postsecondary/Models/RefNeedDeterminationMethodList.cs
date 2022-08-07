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
        /// The complete <see cref="RefNeedDeterminationMethodModel"> List
         /// </summary>
        public static List<RefNeedDeterminationMethodModel> RefNeedDeterminationMethodList = new List<RefNeedDeterminationMethodModel>
        {
            new RefNeedDeterminationMethod { Id=Guid.Parse("5d5cd9cb-3bfc-49f1-b994-729eab571c9e"), Code="Federal", Description="Federal", Definition="Federal", SortOrder=Convert.ToDecimal("1.00") },
            new RefNeedDeterminationMethod { Id=Guid.Parse("3f990cee-6c7d-4d66-93fb-d806870ce424"), Code="Institutional", Description="Institutional", Definition="Institutional", SortOrder=Convert.ToDecimal("2.00") },
        };

        /// <summary>
        /// The Reference RefNeedDeterminationMethod Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefNeedDeterminationMethodViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefNeedDeterminationMethod { Id=Guid.Parse("5d5cd9cb-3bfc-49f1-b994-729eab571c9e"), Description="Federal", SortOrder=Convert.ToDecimal("1.00") },
            new RefNeedDeterminationMethod { Id=Guid.Parse("3f990cee-6c7d-4d66-93fb-d806870ce424"), Description="Institutional", SortOrder=Convert.ToDecimal("2.00") },
       };
   }
}
