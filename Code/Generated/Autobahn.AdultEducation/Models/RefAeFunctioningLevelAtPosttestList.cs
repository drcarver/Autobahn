//**********************************************************
//* DomainName: Autobahn.AdultEducation
//* FileName:   RefAeFunctioningLevelAtPosttestList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.AdultEducation.Models
{
     /// <summary>
     /// The list of RefAeFunctioningLevelAtPosttest Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefAeFunctioningLevelAtPosttestModel"> List
         /// </summary>
        public static List<RefAeFunctioningLevelAtPosttestModel> RefAeFunctioningLevelAtPosttestList = new List<RefAeFunctioningLevelAtPosttestModel>
        {
            new RefAeFunctioningLevelAtPosttest { Id=Guid.Parse("0853b204-3cde-47d4-8b09-3a01e843e880"), Code="ABEBegLit", Description="ABE Beginning Literacy", Definition="ABE Beginning Literacy is specified as the individual's skill level, as defined by the National Reporting System for Adult Education and determined by an approved standardized assessment after a set time period or number of instructional hours.", SortOrder=Convert.ToDecimal("1.00") },
            new RefAeFunctioningLevelAtPosttest { Id=Guid.Parse("51d9e639-0810-472f-bb35-dbf04f77d347"), Code="ABEBegBasic", Description="Beginning Basic Education", Definition="Beginning Basic Education is specified as the individual's skill level, as defined by the National Reporting System for Adult Education and determined by an approved standardized assessment after a set time period or number of instructional hours.", SortOrder=Convert.ToDecimal("2.00") },
            new RefAeFunctioningLevelAtPosttest { Id=Guid.Parse("7c1e6d96-79b0-4bf8-a90c-07a553a1e9e9"), Code="ABEIntLow", Description="Low Intermediate Basic Education", Definition="Low Intermediate Basic Education is specified as the individual's skill level, as defined by the National Reporting System for Adult Education and determined by an approved standardized assessment after a set time period or number of instructional hours.", SortOrder=Convert.ToDecimal("3.00") },
            new RefAeFunctioningLevelAtPosttest { Id=Guid.Parse("b1463a12-d62e-4370-9b48-178adcda4745"), Code="ABEIntHigh", Description="High Intermediate Basic Education", Definition="High Intermediate Basic Education is specified as the individual's skill level, as defined by the National Reporting System for Adult Education and determined by an approved standardized assessment after a set time period or number of instructional hours.", SortOrder=Convert.ToDecimal("4.00") },
            new RefAeFunctioningLevelAtPosttest { Id=Guid.Parse("70ad7a1e-520c-4a60-b0cf-94c9e2354013"), Code="ASELow", Description="Adult Secondary Education Low", Definition="Adult Secondary Education Low is specified as the individual's skill level, as defined by the National Reporting System for Adult Education and determined by an approved standardized assessment after a set time period or number of instructional hours.", SortOrder=Convert.ToDecimal("5.00") },
            new RefAeFunctioningLevelAtPosttest { Id=Guid.Parse("620c0651-6d54-43bb-9d6f-c6cf28bd0303"), Code="ASEHigh", Description="Adult Secondary Education High", Definition="Adult Secondary Education High is specified as the individual's skill level, as defined by the National Reporting System for Adult Education and determined by an approved standardized assessment after a set time period or number of instructional hours.", SortOrder=Convert.ToDecimal("6.00") },
            new RefAeFunctioningLevelAtPosttest { Id=Guid.Parse("f057dc89-399d-4f65-9c7f-56809f6c2ec2"), Code="ESLBegLit", Description="Beginning ESL Literacy", Definition="Beginning ESL Literacy is specified as the individual's skill level, as defined by the National Reporting System for Adult Education and determined by an approved standardized assessment after a set time period or number of instructional hours.", SortOrder=Convert.ToDecimal("7.00") },
            new RefAeFunctioningLevelAtPosttest { Id=Guid.Parse("b7cc1b06-b5b5-432d-bace-929a654a869b"), Code="ESLBegLow", Description="ESL Low Beginning", Definition="ESL Low Beginning is specified as the individual's skill level, as defined by the National Reporting System for Adult Education and determined by an approved standardized assessment after a set time period or number of instructional hours.", SortOrder=Convert.ToDecimal("8.00") },
            new RefAeFunctioningLevelAtPosttest { Id=Guid.Parse("a8bc0be8-caec-434c-bc67-99692f1bf265"), Code="ESLBegHigh", Description="ESL High Beginning", Definition="ESL High Beginning is specified as the individual's skill level, as defined by the National Reporting System for Adult Education and determined by an approved standardized assessment after a set time period or number of instructional hours.", SortOrder=Convert.ToDecimal("9.00") },
            new RefAeFunctioningLevelAtPosttest { Id=Guid.Parse("20e79613-dd10-45b8-9a2b-25ce02d05060"), Code="ESLIntLow", Description="ESL Low Intermediate", Definition="ESL Low Intermediate is specified as the individual's skill level, as defined by the National Reporting System for Adult Education and determined by an approved standardized assessment after a set time period or number of instructional hours.", SortOrder=Convert.ToDecimal("10.00") },
            new RefAeFunctioningLevelAtPosttest { Id=Guid.Parse("5751c13c-a3ca-4112-9271-7b77dd2e5214"), Code="ESLIntHigh", Description="ESL Intermediate High", Definition="ESL Intermediate High is specified as the individual's skill level, as defined by the National Reporting System for Adult Education and determined by an approved standardized assessment after a set time period or number of instructional hours.", SortOrder=Convert.ToDecimal("11.00") },
            new RefAeFunctioningLevelAtPosttest { Id=Guid.Parse("17dbcf95-3e21-4438-898e-cd2f29e32456"), Code="ESLAdv", Description="ESL Advanced", Definition="ESL Advanced is specified as the individual's skill level, as defined by the National Reporting System for Adult Education and determined by an approved standardized assessment after a set time period or number of instructional hours.", SortOrder=Convert.ToDecimal("12.00") },
        };

        /// <summary>
        /// The Reference RefAeFunctioningLevelAtPosttest Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefAeFunctioningLevelAtPosttestViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefAeFunctioningLevelAtPosttest { Id=Guid.Parse("0853b204-3cde-47d4-8b09-3a01e843e880"), Description="ABE Beginning Literacy", SortOrder=Convert.ToDecimal("1.00") },
            new RefAeFunctioningLevelAtPosttest { Id=Guid.Parse("51d9e639-0810-472f-bb35-dbf04f77d347"), Description="Beginning Basic Education", SortOrder=Convert.ToDecimal("2.00") },
            new RefAeFunctioningLevelAtPosttest { Id=Guid.Parse("7c1e6d96-79b0-4bf8-a90c-07a553a1e9e9"), Description="Low Intermediate Basic Education", SortOrder=Convert.ToDecimal("3.00") },
            new RefAeFunctioningLevelAtPosttest { Id=Guid.Parse("b1463a12-d62e-4370-9b48-178adcda4745"), Description="High Intermediate Basic Education", SortOrder=Convert.ToDecimal("4.00") },
            new RefAeFunctioningLevelAtPosttest { Id=Guid.Parse("70ad7a1e-520c-4a60-b0cf-94c9e2354013"), Description="Adult Secondary Education Low", SortOrder=Convert.ToDecimal("5.00") },
            new RefAeFunctioningLevelAtPosttest { Id=Guid.Parse("620c0651-6d54-43bb-9d6f-c6cf28bd0303"), Description="Adult Secondary Education High", SortOrder=Convert.ToDecimal("6.00") },
            new RefAeFunctioningLevelAtPosttest { Id=Guid.Parse("f057dc89-399d-4f65-9c7f-56809f6c2ec2"), Description="Beginning ESL Literacy", SortOrder=Convert.ToDecimal("7.00") },
            new RefAeFunctioningLevelAtPosttest { Id=Guid.Parse("b7cc1b06-b5b5-432d-bace-929a654a869b"), Description="ESL Low Beginning", SortOrder=Convert.ToDecimal("8.00") },
            new RefAeFunctioningLevelAtPosttest { Id=Guid.Parse("a8bc0be8-caec-434c-bc67-99692f1bf265"), Description="ESL High Beginning", SortOrder=Convert.ToDecimal("9.00") },
            new RefAeFunctioningLevelAtPosttest { Id=Guid.Parse("20e79613-dd10-45b8-9a2b-25ce02d05060"), Description="ESL Low Intermediate", SortOrder=Convert.ToDecimal("10.00") },
            new RefAeFunctioningLevelAtPosttest { Id=Guid.Parse("5751c13c-a3ca-4112-9271-7b77dd2e5214"), Description="ESL Intermediate High", SortOrder=Convert.ToDecimal("11.00") },
            new RefAeFunctioningLevelAtPosttest { Id=Guid.Parse("17dbcf95-3e21-4438-898e-cd2f29e32456"), Description="ESL Advanced", SortOrder=Convert.ToDecimal("12.00") },
       };
   }
}
