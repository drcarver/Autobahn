//**********************************************************
//* DomainName: Autobahn.AdultEducation
//* FileName:   RefAeFunctioningLevelAtIntakeList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.AdultEducation.Models
{
     /// <summary>
     /// The list of RefAeFunctioningLevelAtIntake Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefAeFunctioningLevelAtIntakeModel"> List
         /// </summary>
        public static List<RefAeFunctioningLevelAtIntakeModel> RefAeFunctioningLevelAtIntakeList = new List<RefAeFunctioningLevelAtIntakeModel>
        {
            new RefAeFunctioningLevelAtIntake { Id=Guid.Parse("b977f971-70d9-4762-b860-2865cf5f7407"), Code="ABEBegLit", Description="ABE Beginning Literacy", Definition="ABE Beginning Literacy is specified as the individual's entering skill level, as defined by the National Reporting System for Adult Education and determined by an approved standardized assessment at program intake.", SortOrder=Convert.ToDecimal("1.00") },
            new RefAeFunctioningLevelAtIntake { Id=Guid.Parse("743671c4-3b48-481c-904d-028f6f888ea2"), Code="ABEBegBasic", Description="Beginning Basic Education", Definition="Beginning Basic Education is specified as the individual's entering skill level, as defined by the National Reporting System for Adult Education and determined by an approved standardized assessment at program intake.", SortOrder=Convert.ToDecimal("2.00") },
            new RefAeFunctioningLevelAtIntake { Id=Guid.Parse("d191be09-d40d-45b3-bd9d-d6e302bbb157"), Code="ABEIntLow", Description="Low Intermediate Basic Education", Definition="Low Intermediate Basic Education is specified as the individual's entering skill level, as defined by the National Reporting System for Adult Education and determined by an approved standardized assessment at program intake.", SortOrder=Convert.ToDecimal("3.00") },
            new RefAeFunctioningLevelAtIntake { Id=Guid.Parse("aacbed9f-cfc8-49c9-bfd0-3877e4c23f98"), Code="ABEIntHigh", Description="High Intermediate Basic Education", Definition="High Intermediate Basic Education is specified as the individual's entering skill level, as defined by the National Reporting System for Adult Education and determined by an approved standardized assessment at program intake.", SortOrder=Convert.ToDecimal("4.00") },
            new RefAeFunctioningLevelAtIntake { Id=Guid.Parse("c5665bf9-76de-4ab6-9468-cce6aac1ebe6"), Code="ASELow", Description="Adult Secondary Education Low", Definition="Adult Secondary Education Lowy is specified as the individual's entering skill level, as defined by the National Reporting System for Adult Education and determined by an approved standardized assessment at program intake.", SortOrder=Convert.ToDecimal("5.00") },
            new RefAeFunctioningLevelAtIntake { Id=Guid.Parse("242afd6c-e1cf-499d-bfe2-7873819149cf"), Code="ASEHigh", Description="Adult Secondary Education High", Definition="Adult Secondary Education High is specified as the individual's entering skill level, as defined by the National Reporting System for Adult Education and determined by an approved standardized assessment at program intake.", SortOrder=Convert.ToDecimal("6.00") },
            new RefAeFunctioningLevelAtIntake { Id=Guid.Parse("ea96a1e4-7ddb-4357-9a06-427c7ab35746"), Code="ESLBegLit", Description="Beginning ESL Literacy", Definition="Beginning ESL Literacy is specified as the individual's entering skill level, as defined by the National Reporting System for Adult Education and determined by an approved standardized assessment at program intake.", SortOrder=Convert.ToDecimal("7.00") },
            new RefAeFunctioningLevelAtIntake { Id=Guid.Parse("1f392130-c93f-4876-87f0-b48762bfb45d"), Code="ESLBegLow", Description="ESL Low Beginning", Definition="ESL Low Beginning is specified as the individual's entering skill level, as defined by the National Reporting System for Adult Education and determined by an approved standardized assessment at program intake.", SortOrder=Convert.ToDecimal("8.00") },
            new RefAeFunctioningLevelAtIntake { Id=Guid.Parse("115b70bd-1132-4bc0-baa8-4ab00fd16f01"), Code="ESLBegHigh", Description="ESL High Beginning", Definition="ESL High Beginning is specified as the individual's entering skill level, as defined by the National Reporting System for Adult Education and determined by an approved standardized assessment at program intake.", SortOrder=Convert.ToDecimal("9.00") },
            new RefAeFunctioningLevelAtIntake { Id=Guid.Parse("7daf3ea2-3a5b-4a11-a04a-ead02bb18871"), Code="ESLIntLow", Description="ESL Low Intermediate", Definition="ESL Low Intermediate is specified as the individual's entering skill level, as defined by the National Reporting System for Adult Education and determined by an approved standardized assessment at program intake.", SortOrder=Convert.ToDecimal("10.00") },
            new RefAeFunctioningLevelAtIntake { Id=Guid.Parse("d4c7921f-bc1b-4763-a3c9-649d0536f3c2"), Code="ESLIntHigh", Description="ESL Intermediate High", Definition="ESL Intermediate High is specified as the individual's entering skill level, as defined by the National Reporting System for Adult Education and determined by an approved standardized assessment at program intake.", SortOrder=Convert.ToDecimal("11.00") },
            new RefAeFunctioningLevelAtIntake { Id=Guid.Parse("4b751272-823e-4cd5-8277-da02c2386de9"), Code="ESLAdv", Description="ESL Advanced", Definition="ESL Advanced is specified as the individual's entering skill level, as defined by the National Reporting System for Adult Education and determined by an approved standardized assessment at program intake.", SortOrder=Convert.ToDecimal("12.00") },
        };

        /// <summary>
        /// The Reference RefAeFunctioningLevelAtIntake Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefAeFunctioningLevelAtIntakeViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefAeFunctioningLevelAtIntake { Id=Guid.Parse("b977f971-70d9-4762-b860-2865cf5f7407"), Description="ABE Beginning Literacy", SortOrder=Convert.ToDecimal("1.00") },
            new RefAeFunctioningLevelAtIntake { Id=Guid.Parse("743671c4-3b48-481c-904d-028f6f888ea2"), Description="Beginning Basic Education", SortOrder=Convert.ToDecimal("2.00") },
            new RefAeFunctioningLevelAtIntake { Id=Guid.Parse("d191be09-d40d-45b3-bd9d-d6e302bbb157"), Description="Low Intermediate Basic Education", SortOrder=Convert.ToDecimal("3.00") },
            new RefAeFunctioningLevelAtIntake { Id=Guid.Parse("aacbed9f-cfc8-49c9-bfd0-3877e4c23f98"), Description="High Intermediate Basic Education", SortOrder=Convert.ToDecimal("4.00") },
            new RefAeFunctioningLevelAtIntake { Id=Guid.Parse("c5665bf9-76de-4ab6-9468-cce6aac1ebe6"), Description="Adult Secondary Education Low", SortOrder=Convert.ToDecimal("5.00") },
            new RefAeFunctioningLevelAtIntake { Id=Guid.Parse("242afd6c-e1cf-499d-bfe2-7873819149cf"), Description="Adult Secondary Education High", SortOrder=Convert.ToDecimal("6.00") },
            new RefAeFunctioningLevelAtIntake { Id=Guid.Parse("ea96a1e4-7ddb-4357-9a06-427c7ab35746"), Description="Beginning ESL Literacy", SortOrder=Convert.ToDecimal("7.00") },
            new RefAeFunctioningLevelAtIntake { Id=Guid.Parse("1f392130-c93f-4876-87f0-b48762bfb45d"), Description="ESL Low Beginning", SortOrder=Convert.ToDecimal("8.00") },
            new RefAeFunctioningLevelAtIntake { Id=Guid.Parse("115b70bd-1132-4bc0-baa8-4ab00fd16f01"), Description="ESL High Beginning", SortOrder=Convert.ToDecimal("9.00") },
            new RefAeFunctioningLevelAtIntake { Id=Guid.Parse("7daf3ea2-3a5b-4a11-a04a-ead02bb18871"), Description="ESL Low Intermediate", SortOrder=Convert.ToDecimal("10.00") },
            new RefAeFunctioningLevelAtIntake { Id=Guid.Parse("d4c7921f-bc1b-4763-a3c9-649d0536f3c2"), Description="ESL Intermediate High", SortOrder=Convert.ToDecimal("11.00") },
            new RefAeFunctioningLevelAtIntake { Id=Guid.Parse("4b751272-823e-4cd5-8277-da02c2386de9"), Description="ESL Advanced", SortOrder=Convert.ToDecimal("12.00") },
       };
   }
}
