//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefIncidentTimeDescriptionCodeList.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefIncidentTimeDescriptionCode Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefIncidentTimeDescriptionCodeModel"> List
         /// </summary>
        public static List<RefIncidentTimeDescriptionCodeModel> RefIncidentTimeDescriptionCodeList = new List<RefIncidentTimeDescriptionCodeModel>
        {
            new RefIncidentTimeDescriptionCode { Id=Guid.Parse("e1ddfc0a-a038-41bd-8af8-53e64a0f921e"), Code="13765", Description="After classes", Definition="The incident took place After classes.", SortOrder=Convert.ToDecimal("1.00") },
            new RefIncidentTimeDescriptionCode { Id=Guid.Parse("2642cfb4-07b1-4437-a102-0cdc552e20df"), Code="13761", Description="Before classes", Definition="The incident took place Before classes.", SortOrder=Convert.ToDecimal("2.00") },
            new RefIncidentTimeDescriptionCode { Id=Guid.Parse("3427742f-ddb8-471c-920c-014d76e249e6"), Code="13762", Description="During class", Definition="The incident took place During class.", SortOrder=Convert.ToDecimal("3.00") },
            new RefIncidentTimeDescriptionCode { Id=Guid.Parse("2d8da364-099c-48d4-838e-cc3dc1741097"), Code="13764", Description="During lunch/recess", Definition="The incident took place During lunch/recess.", SortOrder=Convert.ToDecimal("4.00") },
            new RefIncidentTimeDescriptionCode { Id=Guid.Parse("bb5f0e67-1679-49f7-9f79-15009c1ca0ee"), Code="13763", Description="During passing", Definition="The incident took place During passing.", SortOrder=Convert.ToDecimal("5.00") },
            new RefIncidentTimeDescriptionCode { Id=Guid.Parse("cf0edb05-fae3-43d9-99ba-752a6e287377"), Code="13770", Description="Nonschool-sponsored activity", Definition="The incident took place during a Nonschool-sponsored activity.", SortOrder=Convert.ToDecimal("6.00") },
            new RefIncidentTimeDescriptionCode { Id=Guid.Parse("932ba89c-0b74-4c96-a722-6a2109ba74d2"), Code="13768", Description="On the way from school", Definition="The incident took place On the way from school.", SortOrder=Convert.ToDecimal("7.00") },
            new RefIncidentTimeDescriptionCode { Id=Guid.Parse("35e27d27-ed63-4cbe-ba71-adb30b90ac75"), Code="13767", Description="On the way to school", Definition="The incident took place On the way to school.", SortOrder=Convert.ToDecimal("8.00") },
            new RefIncidentTimeDescriptionCode { Id=Guid.Parse("ee57378f-d164-4406-85da-bad95b0097fe"), Code="13766", Description="Other time during school hours", Definition="The incident took place during an Other time during school hours.", SortOrder=Convert.ToDecimal("9.00") },
            new RefIncidentTimeDescriptionCode { Id=Guid.Parse("5bbdd1c2-3d98-490d-bddf-15e90764c6cd"), Code="13771", Description="Other time outside school hours", Definition="The incident took place during an Other time outside school hours.", SortOrder=Convert.ToDecimal("10.00") },
            new RefIncidentTimeDescriptionCode { Id=Guid.Parse("728e7d3b-4700-400e-85e4-f0bd254b8785"), Code="13769", Description="School-sponsored activity", Definition="The incident took place during a School-sponsored activity.", SortOrder=Convert.ToDecimal("11.00") },
            new RefIncidentTimeDescriptionCode { Id=Guid.Parse("1635be1e-3e55-4a1e-8aa8-74d50473596d"), Code="13772", Description="Unknown", Definition="The time description of when the incident took place is Unknown.", SortOrder=Convert.ToDecimal("12.00") },
        };

        /// <summary>
        /// The Reference RefIncidentTimeDescriptionCode Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefIncidentTimeDescriptionCodeViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefIncidentTimeDescriptionCode { Id=Guid.Parse("e1ddfc0a-a038-41bd-8af8-53e64a0f921e"), Description="After classes", SortOrder=Convert.ToDecimal("1.00") },
            new RefIncidentTimeDescriptionCode { Id=Guid.Parse("2642cfb4-07b1-4437-a102-0cdc552e20df"), Description="Before classes", SortOrder=Convert.ToDecimal("2.00") },
            new RefIncidentTimeDescriptionCode { Id=Guid.Parse("3427742f-ddb8-471c-920c-014d76e249e6"), Description="During class", SortOrder=Convert.ToDecimal("3.00") },
            new RefIncidentTimeDescriptionCode { Id=Guid.Parse("2d8da364-099c-48d4-838e-cc3dc1741097"), Description="During lunch/recess", SortOrder=Convert.ToDecimal("4.00") },
            new RefIncidentTimeDescriptionCode { Id=Guid.Parse("bb5f0e67-1679-49f7-9f79-15009c1ca0ee"), Description="During passing", SortOrder=Convert.ToDecimal("5.00") },
            new RefIncidentTimeDescriptionCode { Id=Guid.Parse("cf0edb05-fae3-43d9-99ba-752a6e287377"), Description="Nonschool-sponsored activity", SortOrder=Convert.ToDecimal("6.00") },
            new RefIncidentTimeDescriptionCode { Id=Guid.Parse("932ba89c-0b74-4c96-a722-6a2109ba74d2"), Description="On the way from school", SortOrder=Convert.ToDecimal("7.00") },
            new RefIncidentTimeDescriptionCode { Id=Guid.Parse("35e27d27-ed63-4cbe-ba71-adb30b90ac75"), Description="On the way to school", SortOrder=Convert.ToDecimal("8.00") },
            new RefIncidentTimeDescriptionCode { Id=Guid.Parse("ee57378f-d164-4406-85da-bad95b0097fe"), Description="Other time during school hours", SortOrder=Convert.ToDecimal("9.00") },
            new RefIncidentTimeDescriptionCode { Id=Guid.Parse("5bbdd1c2-3d98-490d-bddf-15e90764c6cd"), Description="Other time outside school hours", SortOrder=Convert.ToDecimal("10.00") },
            new RefIncidentTimeDescriptionCode { Id=Guid.Parse("728e7d3b-4700-400e-85e4-f0bd254b8785"), Description="School-sponsored activity", SortOrder=Convert.ToDecimal("11.00") },
            new RefIncidentTimeDescriptionCode { Id=Guid.Parse("1635be1e-3e55-4a1e-8aa8-74d50473596d"), Description="Unknown", SortOrder=Convert.ToDecimal("12.00") },
       };
   }
}
