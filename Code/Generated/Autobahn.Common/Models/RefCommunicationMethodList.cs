//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefCommunicationMethodList.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefCommunicationMethod Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefCommunicationMethodModel"> List
         /// </summary>
        public static List<RefCommunicationMethodModel> RefCommunicationMethodList = new List<RefCommunicationMethodModel>
        {
            new RefCommunicationMethod { Id=Guid.Parse("fdb79901-93af-49fa-89b3-5c8d26b36bcb"), Code="InPerson", Description="In-person", Definition="The types of communication methods with parents include in-person communication.", SortOrder=Convert.ToDecimal("0.00") },
            new RefCommunicationMethod { Id=Guid.Parse("51fc5376-3808-4ea8-a213-1cd23eb9ae46"), Code="Phone", Description="Phone", Definition="The types of communication methods with parents include Phone communications.", SortOrder=Convert.ToDecimal("1.00") },
            new RefCommunicationMethod { Id=Guid.Parse("5faf91e2-a83f-4cc4-b80c-9e523ee1c6ea"), Code="Website", Description="Website", Definition="The types of communication methods with parents include Website.", SortOrder=Convert.ToDecimal("2.00") },
            new RefCommunicationMethod { Id=Guid.Parse("2568d06b-0a60-4c8c-bbca-4b7751bfce8a"), Code="Email", Description="Email", Definition="The types of communication methods with parents include Email.", SortOrder=Convert.ToDecimal("3.00") },
            new RefCommunicationMethod { Id=Guid.Parse("edf0fc52-7fdb-47c2-9e5d-5bea94411c47"), Code="Newsletter", Description="Newsletter", Definition="The types of communication methods with parents include Newsletter.", SortOrder=Convert.ToDecimal("4.00") },
            new RefCommunicationMethod { Id=Guid.Parse("3a787f6b-43c6-4d3b-baea-c4b1d9c86ab2"), Code="BulletinBoard", Description="Bulletin board", Definition="The types of communication methods with parents include Bulletin board.", SortOrder=Convert.ToDecimal("5.00") },
            new RefCommunicationMethod { Id=Guid.Parse("7d37938f-e978-4f60-b168-0566da723c21"), Code="HomeVisit", Description="Home visit", Definition="The types of communication methods with parents include Home visit(s).", SortOrder=Convert.ToDecimal("10.00") },
            new RefCommunicationMethod { Id=Guid.Parse("ac858f47-4d97-4bb0-a0e4-d838d6569e0d"), Code="Fax", Description="Fax", Definition="The types of communication methods with parents include Fax.", SortOrder=Convert.ToDecimal("12.00") },
            new RefCommunicationMethod { Id=Guid.Parse("46ad1f9f-278c-4ea2-b140-3c1a3e84a075"), Code="Other", Description="Other", Definition="The types of communication methods with parents include Other.", SortOrder=Convert.ToDecimal("14.00") },
        };

        /// <summary>
        /// The Reference RefCommunicationMethod Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefCommunicationMethodViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefCommunicationMethod { Id=Guid.Parse("fdb79901-93af-49fa-89b3-5c8d26b36bcb"), Description="In-person", SortOrder=Convert.ToDecimal("0.00") },
            new RefCommunicationMethod { Id=Guid.Parse("51fc5376-3808-4ea8-a213-1cd23eb9ae46"), Description="Phone", SortOrder=Convert.ToDecimal("1.00") },
            new RefCommunicationMethod { Id=Guid.Parse("5faf91e2-a83f-4cc4-b80c-9e523ee1c6ea"), Description="Website", SortOrder=Convert.ToDecimal("2.00") },
            new RefCommunicationMethod { Id=Guid.Parse("2568d06b-0a60-4c8c-bbca-4b7751bfce8a"), Description="Email", SortOrder=Convert.ToDecimal("3.00") },
            new RefCommunicationMethod { Id=Guid.Parse("edf0fc52-7fdb-47c2-9e5d-5bea94411c47"), Description="Newsletter", SortOrder=Convert.ToDecimal("4.00") },
            new RefCommunicationMethod { Id=Guid.Parse("3a787f6b-43c6-4d3b-baea-c4b1d9c86ab2"), Description="Bulletin board", SortOrder=Convert.ToDecimal("5.00") },
            new RefCommunicationMethod { Id=Guid.Parse("7d37938f-e978-4f60-b168-0566da723c21"), Description="Home visit", SortOrder=Convert.ToDecimal("10.00") },
            new RefCommunicationMethod { Id=Guid.Parse("ac858f47-4d97-4bb0-a0e4-d838d6569e0d"), Description="Fax", SortOrder=Convert.ToDecimal("12.00") },
            new RefCommunicationMethod { Id=Guid.Parse("46ad1f9f-278c-4ea2-b140-3c1a3e84a075"), Description="Other", SortOrder=Convert.ToDecimal("14.00") },
       };
   }
}
