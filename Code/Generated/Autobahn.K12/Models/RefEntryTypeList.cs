//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   RefEntryTypeList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.K12.Models
{
     /// <summary>
     /// The list of RefEntryType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefEntryType"> List
         /// </summary>
        public static List<RefEntryType> RefEntryTypeList = new List<RefEntryType>
        {
            new RefEntryType { Id=Guid.Parse("80b722c9-8b8a-498f-ac60-3b84dd23c80e"), Code="01821", Description="Transfer from a public school in the same local education agency", Definition="Transfer from a public school in the same local education agency is the process by which the student entered a school during a given academic session.", SortOrder=Convert.ToDecimal("1.00") },
            new RefEntryType { Id=Guid.Parse("51fb1649-eea1-4cdb-9d48-b12ae8392ecc"), Code="01822", Description="Transfer from a public school in a different local education agency in the same state", Definition="Transfer from a public school in a different local education agency in the same state is the process by which the student entered a school during a given academic session.", SortOrder=Convert.ToDecimal("2.00") },
            new RefEntryType { Id=Guid.Parse("3b791416-3a8a-4803-abaf-7a045320eb45"), Code="01823", Description="Transfer from a public school in a different state", Definition="Transfer from a public school in a different state is the process by which the student entered a school during a given academic session.", SortOrder=Convert.ToDecimal("3.00") },
            new RefEntryType { Id=Guid.Parse("1220b113-2bb7-49f1-ab68-32cf97d48c69"), Code="01824", Description="Transfer from a private, non-religiously-affiliated school in the same local education agency", Definition="Transfer from a private, non-religiously-affiliated school in the same local education agency is the process by which the student entered a school during a given academic session.", SortOrder=Convert.ToDecimal("4.00") },
            new RefEntryType { Id=Guid.Parse("efbe6a52-792a-4462-918a-3c389b3826a0"), Code="01825", Description="Transfer from a private, non-religiously-affiliated school in a different LEA in the same state", Definition="Transfer from a private, non-religiously-affiliated school in a different LEA in the same state is the process by which the student entered a school during a given academic session.", SortOrder=Convert.ToDecimal("5.00") },
            new RefEntryType { Id=Guid.Parse("67298b04-8086-4c9e-8c80-d49dae06aca1"), Code="01826", Description="Transfer from a private, non-religiously-affiliated school in a different state", Definition="Transfer from a private, non-religiously-affiliated school in a different state is the process by which the student entered a school during a given academic session.", SortOrder=Convert.ToDecimal("6.00") },
            new RefEntryType { Id=Guid.Parse("4d894f0b-4a11-4e72-86f5-b69adb089ad5"), Code="01827", Description="Transfer from a private, religiously-affiliated school in the same local education agency", Definition="Transfer from a private, religiously-affiliated school in the same local education agency is the process by which the student entered a school during a given academic session.", SortOrder=Convert.ToDecimal("7.00") },
            new RefEntryType { Id=Guid.Parse("1bfaeb9c-d1e9-4079-92b8-eb7e5235a204"), Code="01828", Description="Transfer from a private, religiously-affiliated school in a different LEA in the same state", Definition="Transfer from a private, religiously-affiliated school in a different LEA in the same state is the process by which the student entered a school during a given academic session.", SortOrder=Convert.ToDecimal("8.00") },
            new RefEntryType { Id=Guid.Parse("d0fd0681-22ac-4c8f-8c20-43bdea1060db"), Code="01829", Description="Transfer from a private, religiously-affiliated school in a different state", Definition="Transfer from a private, religiously-affiliated school in a different state", SortOrder=Convert.ToDecimal("9.00") },
            new RefEntryType { Id=Guid.Parse("1724660a-6afc-4cc1-924b-0da9fe0cf75e"), Code="01830", Description="Transfer from a school outside of the country", Definition="Transfer from a school outside of the country is the process by which the student entered a school during a given academic session.", SortOrder=Convert.ToDecimal("10.00") },
            new RefEntryType { Id=Guid.Parse("1d684cd3-fd8c-4a4b-955a-929ace4591e6"), Code="01831", Description="Transfer from an institution", Definition="Transfer from an institution is the process by which the student entered a school during a given academic session.", SortOrder=Convert.ToDecimal("11.00") },
            new RefEntryType { Id=Guid.Parse("5f46a837-925a-4752-8c83-7e17e3c735fe"), Code="01832", Description="Transfer from a charter school", Definition="Transfer from a charter school is the process by which the student entered a school during a given academic session.", SortOrder=Convert.ToDecimal("12.00") },
            new RefEntryType { Id=Guid.Parse("73796084-8847-45fb-bb1a-3c9ac59fde7c"), Code="01833", Description="Transfer from home schooling", Definition="Transfer from home schooling is the process by which the student entered a school during a given academic session.", SortOrder=Convert.ToDecimal("13.00") },
            new RefEntryType { Id=Guid.Parse("a3506e4e-a764-41e1-8f03-2ca0eb7d02ca"), Code="01835", Description="Re-entry from the same school with no interruption of schooling", Definition="Re-entry from the same school with no interruption of schooling is the process by which the student entered a school during a given academic session.", SortOrder=Convert.ToDecimal("14.00") },
            new RefEntryType { Id=Guid.Parse("8e827292-d3b6-4fe2-a7de-a7b0ae9986a5"), Code="01836", Description="Re-entry after a voluntary withdrawal", Definition="Re-entry after a voluntary withdrawal is the process by which the student entered a school during a given academic session.", SortOrder=Convert.ToDecimal("15.00") },
            new RefEntryType { Id=Guid.Parse("0b455b86-3106-448b-b010-8bd0e447b943"), Code="01837", Description="Re-entry after an involuntary withdrawal", Definition="Re-entry after an involuntary withdrawal is the process by which the student entered a school during a given academic session.", SortOrder=Convert.ToDecimal("16.00") },
            new RefEntryType { Id=Guid.Parse("bf2f034b-cc83-4f37-9397-5aef8143a3fb"), Code="01838", Description="Original entry into a United States school", Definition="Original entry into a United States school is the process by which the student entered a school during a given academic session.", SortOrder=Convert.ToDecimal("17.00") },
            new RefEntryType { Id=Guid.Parse("bcfa20e6-071d-407c-a395-671ee8cd0c31"), Code="01839", Description="Original entry into a United States school from a foreign country with no interruption in schooling", Definition="Original entry into a United States school from a foreign country with no interruption in schooling is the process by which the student entered a school during a given academic session.", SortOrder=Convert.ToDecimal("18.00") },
            new RefEntryType { Id=Guid.Parse("8a39bf80-eb50-463a-a951-55a44998e2cb"), Code="01840", Description="Original entry into a United States school from a foreign country with an interruption in schooling", Definition="Original entry into a United States school from a foreign country with an interruption in schooling is the process by which the student entered a school during a given academic session.", SortOrder=Convert.ToDecimal("19.00") },
            new RefEntryType { Id=Guid.Parse("8559c565-5273-4062-923e-33817b063b89"), Code="09999", Description="Other", Definition="The process by which the student entered a school during a given academic session is in a category not yet defined in CEDS.", SortOrder=Convert.ToDecimal("20.00") },
        };

        /// <summary>
        /// The RefEntryType Pick List
         /// </summary>
        public static List<RefEntryType> RefEntryTypePickList = new List<RefEntryType>
        {
            new RefEntryType { Id=Guid.Parse("80b722c9-8b8a-498f-ac60-3b84dd23c80e"), Code="01821", Description="Transfer from a public school in the same local education agency", SortOrder=Convert.ToDecimal("1.00") },
            new RefEntryType { Id=Guid.Parse("51fb1649-eea1-4cdb-9d48-b12ae8392ecc"), Code="01822", Description="Transfer from a public school in a different local education agency in the same state", SortOrder=Convert.ToDecimal("2.00") },
            new RefEntryType { Id=Guid.Parse("3b791416-3a8a-4803-abaf-7a045320eb45"), Code="01823", Description="Transfer from a public school in a different state", SortOrder=Convert.ToDecimal("3.00") },
            new RefEntryType { Id=Guid.Parse("1220b113-2bb7-49f1-ab68-32cf97d48c69"), Code="01824", Description="Transfer from a private, non-religiously-affiliated school in the same local education agency", SortOrder=Convert.ToDecimal("4.00") },
            new RefEntryType { Id=Guid.Parse("efbe6a52-792a-4462-918a-3c389b3826a0"), Code="01825", Description="Transfer from a private, non-religiously-affiliated school in a different LEA in the same state", SortOrder=Convert.ToDecimal("5.00") },
            new RefEntryType { Id=Guid.Parse("67298b04-8086-4c9e-8c80-d49dae06aca1"), Code="01826", Description="Transfer from a private, non-religiously-affiliated school in a different state", SortOrder=Convert.ToDecimal("6.00") },
            new RefEntryType { Id=Guid.Parse("4d894f0b-4a11-4e72-86f5-b69adb089ad5"), Code="01827", Description="Transfer from a private, religiously-affiliated school in the same local education agency", SortOrder=Convert.ToDecimal("7.00") },
            new RefEntryType { Id=Guid.Parse("1bfaeb9c-d1e9-4079-92b8-eb7e5235a204"), Code="01828", Description="Transfer from a private, religiously-affiliated school in a different LEA in the same state", SortOrder=Convert.ToDecimal("8.00") },
            new RefEntryType { Id=Guid.Parse("d0fd0681-22ac-4c8f-8c20-43bdea1060db"), Code="01829", Description="Transfer from a private, religiously-affiliated school in a different state", SortOrder=Convert.ToDecimal("9.00") },
            new RefEntryType { Id=Guid.Parse("1724660a-6afc-4cc1-924b-0da9fe0cf75e"), Code="01830", Description="Transfer from a school outside of the country", SortOrder=Convert.ToDecimal("10.00") },
            new RefEntryType { Id=Guid.Parse("1d684cd3-fd8c-4a4b-955a-929ace4591e6"), Code="01831", Description="Transfer from an institution", SortOrder=Convert.ToDecimal("11.00") },
            new RefEntryType { Id=Guid.Parse("5f46a837-925a-4752-8c83-7e17e3c735fe"), Code="01832", Description="Transfer from a charter school", SortOrder=Convert.ToDecimal("12.00") },
            new RefEntryType { Id=Guid.Parse("73796084-8847-45fb-bb1a-3c9ac59fde7c"), Code="01833", Description="Transfer from home schooling", SortOrder=Convert.ToDecimal("13.00") },
            new RefEntryType { Id=Guid.Parse("a3506e4e-a764-41e1-8f03-2ca0eb7d02ca"), Code="01835", Description="Re-entry from the same school with no interruption of schooling", SortOrder=Convert.ToDecimal("14.00") },
            new RefEntryType { Id=Guid.Parse("8e827292-d3b6-4fe2-a7de-a7b0ae9986a5"), Code="01836", Description="Re-entry after a voluntary withdrawal", SortOrder=Convert.ToDecimal("15.00") },
            new RefEntryType { Id=Guid.Parse("0b455b86-3106-448b-b010-8bd0e447b943"), Code="01837", Description="Re-entry after an involuntary withdrawal", SortOrder=Convert.ToDecimal("16.00") },
            new RefEntryType { Id=Guid.Parse("bf2f034b-cc83-4f37-9397-5aef8143a3fb"), Code="01838", Description="Original entry into a United States school", SortOrder=Convert.ToDecimal("17.00") },
            new RefEntryType { Id=Guid.Parse("bcfa20e6-071d-407c-a395-671ee8cd0c31"), Code="01839", Description="Original entry into a United States school from a foreign country with no interruption in schooling", SortOrder=Convert.ToDecimal("18.00") },
            new RefEntryType { Id=Guid.Parse("8a39bf80-eb50-463a-a951-55a44998e2cb"), Code="01840", Description="Original entry into a United States school from a foreign country with an interruption in schooling", SortOrder=Convert.ToDecimal("19.00") },
            new RefEntryType { Id=Guid.Parse("8559c565-5273-4062-923e-33817b063b89"), Code="09999", Description="Other", SortOrder=Convert.ToDecimal("20.00") },
       };
   }
}
