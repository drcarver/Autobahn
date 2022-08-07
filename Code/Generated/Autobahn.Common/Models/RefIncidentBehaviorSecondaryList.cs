//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefIncidentBehaviorSecondaryList.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefIncidentBehaviorSecondary Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefIncidentBehaviorSecondaryModel"> List
         /// </summary>
        public static List<RefIncidentBehaviorSecondaryModel> RefIncidentBehaviorSecondaryList = new List<RefIncidentBehaviorSecondaryModel>
        {
            new RefIncidentBehaviorSecondary { Id=Guid.Parse("1426c7db-29f3-4b0b-b1ba-0eda30ddaa83"), Code="03066", Description="Alcohol-related", Definition="Alcohol-related is a secondary behavior in addition to the more serious primary Incident Behavior.", SortOrder=Convert.ToDecimal("1.00") },
            new RefIncidentBehaviorSecondary { Id=Guid.Parse("b8ec9c84-6fdf-4343-87cb-a8006ddbaed1"), Code="03067", Description="Drug-related", Definition="Drug-related is a secondary behavior in addition to the more serious primary Incident Behavior.", SortOrder=Convert.ToDecimal("2.00") },
            new RefIncidentBehaviorSecondary { Id=Guid.Parse("4f4ab6d8-e85e-4dfd-8a6b-4d631872bcc7"), Code="03068", Description="Gang-related", Definition="Gang-related is a secondary behavior in addition to the more serious primary Incident Behavior.", SortOrder=Convert.ToDecimal("3.00") },
            new RefIncidentBehaviorSecondary { Id=Guid.Parse("cec0b4d7-1b67-4c49-8688-b7378eb6125d"), Code="13778", Description="Hate-related (Disability)", Definition="Hate-related (Disability) is a secondary behavior in addition to the more serious primary Incident Behavior.", SortOrder=Convert.ToDecimal("4.00") },
            new RefIncidentBehaviorSecondary { Id=Guid.Parse("9620c25f-55aa-4fa5-8eaa-ac93a9940f0a"), Code="13777", Description="Hate-related (Other)", Definition="Hate-related (Other) is a secondary behavior in addition to the more serious primary Incident Behavior.", SortOrder=Convert.ToDecimal("5.00") },
            new RefIncidentBehaviorSecondary { Id=Guid.Parse("18ac8cf7-8657-4c8d-8aef-0ed210bf4ac2"), Code="13779", Description="Hate-related (Race, Color, or National Origin)", Definition="Hate-related (Race, Color, or National Origin) is a secondary behavior in addition to the more serious primary Incident Behavior.", SortOrder=Convert.ToDecimal("6.00") },
            new RefIncidentBehaviorSecondary { Id=Guid.Parse("6df0a953-cf69-4331-b122-b6011f2ffed1"), Code="13780", Description="Hate-related (Sex)", Definition="Hate-related (Sex) is a secondary behavior in addition to the more serious primary Incident Behavior.", SortOrder=Convert.ToDecimal("7.00") },
            new RefIncidentBehaviorSecondary { Id=Guid.Parse("ed03e4ba-638e-4147-a6cf-b5c8c5403e5d"), Code="03070", Description="Weapon-related", Definition="Weapon-related is a secondary behavior in addition to the more serious primary Incident Behavior.", SortOrder=Convert.ToDecimal("8.00") },
        };

        /// <summary>
        /// The Reference RefIncidentBehaviorSecondary Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefIncidentBehaviorSecondaryViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefIncidentBehaviorSecondary { Id=Guid.Parse("1426c7db-29f3-4b0b-b1ba-0eda30ddaa83"), Description="Alcohol-related", SortOrder=Convert.ToDecimal("1.00") },
            new RefIncidentBehaviorSecondary { Id=Guid.Parse("b8ec9c84-6fdf-4343-87cb-a8006ddbaed1"), Description="Drug-related", SortOrder=Convert.ToDecimal("2.00") },
            new RefIncidentBehaviorSecondary { Id=Guid.Parse("4f4ab6d8-e85e-4dfd-8a6b-4d631872bcc7"), Description="Gang-related", SortOrder=Convert.ToDecimal("3.00") },
            new RefIncidentBehaviorSecondary { Id=Guid.Parse("cec0b4d7-1b67-4c49-8688-b7378eb6125d"), Description="Hate-related (Disability)", SortOrder=Convert.ToDecimal("4.00") },
            new RefIncidentBehaviorSecondary { Id=Guid.Parse("9620c25f-55aa-4fa5-8eaa-ac93a9940f0a"), Description="Hate-related (Other)", SortOrder=Convert.ToDecimal("5.00") },
            new RefIncidentBehaviorSecondary { Id=Guid.Parse("18ac8cf7-8657-4c8d-8aef-0ed210bf4ac2"), Description="Hate-related (Race, Color, or National Origin)", SortOrder=Convert.ToDecimal("6.00") },
            new RefIncidentBehaviorSecondary { Id=Guid.Parse("6df0a953-cf69-4331-b122-b6011f2ffed1"), Description="Hate-related (Sex)", SortOrder=Convert.ToDecimal("7.00") },
            new RefIncidentBehaviorSecondary { Id=Guid.Parse("ed03e4ba-638e-4147-a6cf-b5c8c5403e5d"), Description="Weapon-related", SortOrder=Convert.ToDecimal("8.00") },
       };
   }
}
