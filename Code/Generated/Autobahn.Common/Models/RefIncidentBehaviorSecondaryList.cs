//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefIncidentBehaviorSecondaryList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefIncidentBehaviorSecondary Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefIncidentBehaviorSecondary"> List
         /// </summary>
        public static List<RefIncidentBehaviorSecondary> RefIncidentBehaviorSecondaryList = new List<RefIncidentBehaviorSecondary>
        {
            new RefIncidentBehaviorSecondary { Id=Guid.Parse("3703c83b-1082-4ccd-8b98-88e9fdc9bf5f"), Code="03066", Description="Alcohol-related", Definition="Alcohol-related is a secondary behavior in addition to the more serious primary Incident Behavior.", SortOrder=Convert.ToDecimal("1.00") },
            new RefIncidentBehaviorSecondary { Id=Guid.Parse("b91e1ac4-7392-4b9b-a74b-7bd0f59e4d54"), Code="03067", Description="Drug-related", Definition="Drug-related is a secondary behavior in addition to the more serious primary Incident Behavior.", SortOrder=Convert.ToDecimal("2.00") },
            new RefIncidentBehaviorSecondary { Id=Guid.Parse("0436dc70-c228-4c21-a93e-4e95cf98df07"), Code="03068", Description="Gang-related", Definition="Gang-related is a secondary behavior in addition to the more serious primary Incident Behavior.", SortOrder=Convert.ToDecimal("3.00") },
            new RefIncidentBehaviorSecondary { Id=Guid.Parse("69b412b1-2a6e-43ca-942f-75c0d924a216"), Code="13778", Description="Hate-related (Disability)", Definition="Hate-related (Disability) is a secondary behavior in addition to the more serious primary Incident Behavior.", SortOrder=Convert.ToDecimal("4.00") },
            new RefIncidentBehaviorSecondary { Id=Guid.Parse("428d066c-b881-4a2c-b8c6-e9172a70fcb3"), Code="13777", Description="Hate-related (Other)", Definition="Hate-related (Other) is a secondary behavior in addition to the more serious primary Incident Behavior.", SortOrder=Convert.ToDecimal("5.00") },
            new RefIncidentBehaviorSecondary { Id=Guid.Parse("068bd948-2361-4bf8-8c79-931845589154"), Code="13779", Description="Hate-related (Race, Color, or National Origin)", Definition="Hate-related (Race, Color, or National Origin) is a secondary behavior in addition to the more serious primary Incident Behavior.", SortOrder=Convert.ToDecimal("6.00") },
            new RefIncidentBehaviorSecondary { Id=Guid.Parse("aa135169-55f2-4753-ab0c-05496d1910f1"), Code="13780", Description="Hate-related (Sex)", Definition="Hate-related (Sex) is a secondary behavior in addition to the more serious primary Incident Behavior.", SortOrder=Convert.ToDecimal("7.00") },
            new RefIncidentBehaviorSecondary { Id=Guid.Parse("560686a7-de23-4526-a226-4acbd6915863"), Code="03070", Description="Weapon-related", Definition="Weapon-related is a secondary behavior in addition to the more serious primary Incident Behavior.", SortOrder=Convert.ToDecimal("8.00") },
        };

        /// <summary>
        /// The RefIncidentBehaviorSecondary Pick List
         /// </summary>
        public static List<RefIncidentBehaviorSecondary> RefIncidentBehaviorSecondaryPickList = new List<RefIncidentBehaviorSecondary>
        {
            new RefIncidentBehaviorSecondary { Id=Guid.Parse("3703c83b-1082-4ccd-8b98-88e9fdc9bf5f"), Code="03066", Description="Alcohol-related", SortOrder=Convert.ToDecimal("1.00") },
            new RefIncidentBehaviorSecondary { Id=Guid.Parse("b91e1ac4-7392-4b9b-a74b-7bd0f59e4d54"), Code="03067", Description="Drug-related", SortOrder=Convert.ToDecimal("2.00") },
            new RefIncidentBehaviorSecondary { Id=Guid.Parse("0436dc70-c228-4c21-a93e-4e95cf98df07"), Code="03068", Description="Gang-related", SortOrder=Convert.ToDecimal("3.00") },
            new RefIncidentBehaviorSecondary { Id=Guid.Parse("69b412b1-2a6e-43ca-942f-75c0d924a216"), Code="13778", Description="Hate-related (Disability)", SortOrder=Convert.ToDecimal("4.00") },
            new RefIncidentBehaviorSecondary { Id=Guid.Parse("428d066c-b881-4a2c-b8c6-e9172a70fcb3"), Code="13777", Description="Hate-related (Other)", SortOrder=Convert.ToDecimal("5.00") },
            new RefIncidentBehaviorSecondary { Id=Guid.Parse("068bd948-2361-4bf8-8c79-931845589154"), Code="13779", Description="Hate-related (Race, Color, or National Origin)", SortOrder=Convert.ToDecimal("6.00") },
            new RefIncidentBehaviorSecondary { Id=Guid.Parse("aa135169-55f2-4753-ab0c-05496d1910f1"), Code="13780", Description="Hate-related (Sex)", SortOrder=Convert.ToDecimal("7.00") },
            new RefIncidentBehaviorSecondary { Id=Guid.Parse("560686a7-de23-4526-a226-4acbd6915863"), Code="03070", Description="Weapon-related", SortOrder=Convert.ToDecimal("8.00") },
       };
   }
}
