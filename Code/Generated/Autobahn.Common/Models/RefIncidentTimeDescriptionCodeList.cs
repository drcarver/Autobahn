//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefIncidentTimeDescriptionCodeList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefIncidentTimeDescriptionCode Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefIncidentTimeDescriptionCode"> List
         /// </summary>
        public static List<RefIncidentTimeDescriptionCode> RefIncidentTimeDescriptionCodeList = new List<RefIncidentTimeDescriptionCode> =
        {
            new RefIncidentTimeDescriptionCode { Id=Guid.Parse("b46d14e4-8eff-4196-9711-3e1f0873bb60"), Code="The incident took place After classes.", Description="13765", Definition="", SortOrder=0 },
            new RefIncidentTimeDescriptionCode { Id=Guid.Parse("52218181-24fc-4683-8cae-7e54212fe2a4"), Code="The incident took place Before classes.", Description="13761", Definition="", SortOrder=0 },
            new RefIncidentTimeDescriptionCode { Id=Guid.Parse("be22392f-ca39-44bc-901b-5eac6bd75dcf"), Code="The incident took place During class.", Description="13762", Definition="", SortOrder=0 },
            new RefIncidentTimeDescriptionCode { Id=Guid.Parse("aba5219c-5c56-4594-ba55-ab7c8e28c4c4"), Code="The incident took place During lunch/recess.", Description="13764", Definition="", SortOrder=0 },
            new RefIncidentTimeDescriptionCode { Id=Guid.Parse("288c821b-133f-4a58-9b1c-23c78d9b4567"), Code="The incident took place During passing.", Description="13763", Definition="", SortOrder=0 },
            new RefIncidentTimeDescriptionCode { Id=Guid.Parse("7a6ca9bd-e445-4383-b078-f139a9eeeddb"), Code="The incident took place during a Nonschool-sponsored activity.", Description="13770", Definition="", SortOrder=0 },
            new RefIncidentTimeDescriptionCode { Id=Guid.Parse("e13f1b79-0ba1-437e-9fb1-0653a524af83"), Code="The incident took place On the way from school.", Description="13768", Definition="", SortOrder=0 },
            new RefIncidentTimeDescriptionCode { Id=Guid.Parse("c20e7632-3261-4c44-adf0-067e03f447f6"), Code="The incident took place On the way to school.", Description="13767", Definition="", SortOrder=0 },
            new RefIncidentTimeDescriptionCode { Id=Guid.Parse("ed2ec3b3-f899-4510-acc8-ad8b0e7b7fb0"), Code="The incident took place during an Other time during school hours.", Description="13766", Definition="", SortOrder=0 },
            new RefIncidentTimeDescriptionCode { Id=Guid.Parse("3ae34f9e-49a8-4e1c-95d1-b033196615c1"), Code="The incident took place during an Other time outside school hours.", Description="13771", Definition="", SortOrder=0 },
            new RefIncidentTimeDescriptionCode { Id=Guid.Parse("00fb190a-1ea9-4790-933a-471f23bf632d"), Code="The incident took place during a School-sponsored activity.", Description="13769", Definition="", SortOrder=0 },
            new RefIncidentTimeDescriptionCode { Id=Guid.Parse("a54163c2-6f94-4386-bf64-f837ef1d0c79"), Code="The time description of when the incident took place is Unknown.", Description="13772", Definition="", SortOrder=0 },
        };

        /// <summary>
        /// The RefIncidentTimeDescriptionCode Pick List
         /// </summary>
        public static List<RefIncidentTimeDescriptionCode> RefIncidentTimeDescriptionCodePickList = new List<RefIncidentTimeDescriptionCode> =
        {
            new RefIncidentTimeDescriptionCode { Id=Guid.Parse("b46d14e4-8eff-4196-9711-3e1f0873bb60"), Code="The incident took place After classes.", SortOrder=0 },
            new RefIncidentTimeDescriptionCode { Id=Guid.Parse("52218181-24fc-4683-8cae-7e54212fe2a4"), Code="The incident took place Before classes.", SortOrder=0 },
            new RefIncidentTimeDescriptionCode { Id=Guid.Parse("be22392f-ca39-44bc-901b-5eac6bd75dcf"), Code="The incident took place During class.", SortOrder=0 },
            new RefIncidentTimeDescriptionCode { Id=Guid.Parse("aba5219c-5c56-4594-ba55-ab7c8e28c4c4"), Code="The incident took place During lunch/recess.", SortOrder=0 },
            new RefIncidentTimeDescriptionCode { Id=Guid.Parse("288c821b-133f-4a58-9b1c-23c78d9b4567"), Code="The incident took place During passing.", SortOrder=0 },
            new RefIncidentTimeDescriptionCode { Id=Guid.Parse("7a6ca9bd-e445-4383-b078-f139a9eeeddb"), Code="The incident took place during a Nonschool-sponsored activity.", SortOrder=0 },
            new RefIncidentTimeDescriptionCode { Id=Guid.Parse("e13f1b79-0ba1-437e-9fb1-0653a524af83"), Code="The incident took place On the way from school.", SortOrder=0 },
            new RefIncidentTimeDescriptionCode { Id=Guid.Parse("c20e7632-3261-4c44-adf0-067e03f447f6"), Code="The incident took place On the way to school.", SortOrder=0 },
            new RefIncidentTimeDescriptionCode { Id=Guid.Parse("ed2ec3b3-f899-4510-acc8-ad8b0e7b7fb0"), Code="The incident took place during an Other time during school hours.", SortOrder=0 },
            new RefIncidentTimeDescriptionCode { Id=Guid.Parse("3ae34f9e-49a8-4e1c-95d1-b033196615c1"), Code="The incident took place during an Other time outside school hours.", SortOrder=0 },
            new RefIncidentTimeDescriptionCode { Id=Guid.Parse("00fb190a-1ea9-4790-933a-471f23bf632d"), Code="The incident took place during a School-sponsored activity.", SortOrder=0 },
            new RefIncidentTimeDescriptionCode { Id=Guid.Parse("a54163c2-6f94-4386-bf64-f837ef1d0c79"), Code="The time description of when the incident took place is Unknown.", SortOrder=0 },
       };
   }
}
