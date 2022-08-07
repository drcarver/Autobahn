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
        /// The complete <see cref="RefEntryTypeModel"> List
         /// </summary>
        public static List<RefEntryTypeModel> RefEntryTypeList = new List<RefEntryTypeModel>
        {
            new RefEntryType { Id=Guid.Parse("1cd616b6-d200-4ab3-8925-d735d18fbd0c"), Code="01821", Description="Transfer from a public school in the same local education agency", Definition="Transfer from a public school in the same local education agency is the process by which the student entered a school during a given academic session.", SortOrder=Convert.ToDecimal("1.00") },
            new RefEntryType { Id=Guid.Parse("8395e96f-24f0-4747-ac36-81767b9b705e"), Code="01822", Description="Transfer from a public school in a different local education agency in the same state", Definition="Transfer from a public school in a different local education agency in the same state is the process by which the student entered a school during a given academic session.", SortOrder=Convert.ToDecimal("2.00") },
            new RefEntryType { Id=Guid.Parse("dddaa2bc-ef25-446d-873b-618ea012a11f"), Code="01823", Description="Transfer from a public school in a different state", Definition="Transfer from a public school in a different state is the process by which the student entered a school during a given academic session.", SortOrder=Convert.ToDecimal("3.00") },
            new RefEntryType { Id=Guid.Parse("6bd626b3-5255-4aa5-bf56-50779d5feec0"), Code="01824", Description="Transfer from a private, non-religiously-affiliated school in the same local education agency", Definition="Transfer from a private, non-religiously-affiliated school in the same local education agency is the process by which the student entered a school during a given academic session.", SortOrder=Convert.ToDecimal("4.00") },
            new RefEntryType { Id=Guid.Parse("865a0843-52b7-40e5-8827-4033aa1f2494"), Code="01825", Description="Transfer from a private, non-religiously-affiliated school in a different LEA in the same state", Definition="Transfer from a private, non-religiously-affiliated school in a different LEA in the same state is the process by which the student entered a school during a given academic session.", SortOrder=Convert.ToDecimal("5.00") },
            new RefEntryType { Id=Guid.Parse("faa54c07-42ed-42ce-97bf-404f77d75d79"), Code="01826", Description="Transfer from a private, non-religiously-affiliated school in a different state", Definition="Transfer from a private, non-religiously-affiliated school in a different state is the process by which the student entered a school during a given academic session.", SortOrder=Convert.ToDecimal("6.00") },
            new RefEntryType { Id=Guid.Parse("87a3c794-362a-4d75-85aa-62b44fc15125"), Code="01827", Description="Transfer from a private, religiously-affiliated school in the same local education agency", Definition="Transfer from a private, religiously-affiliated school in the same local education agency is the process by which the student entered a school during a given academic session.", SortOrder=Convert.ToDecimal("7.00") },
            new RefEntryType { Id=Guid.Parse("a162ea1e-127c-4470-86f5-1130eaca3142"), Code="01828", Description="Transfer from a private, religiously-affiliated school in a different LEA in the same state", Definition="Transfer from a private, religiously-affiliated school in a different LEA in the same state is the process by which the student entered a school during a given academic session.", SortOrder=Convert.ToDecimal("8.00") },
            new RefEntryType { Id=Guid.Parse("4753afb4-e7df-4618-931f-a414a7f09f66"), Code="01829", Description="Transfer from a private, religiously-affiliated school in a different state", Definition="Transfer from a private, religiously-affiliated school in a different state", SortOrder=Convert.ToDecimal("9.00") },
            new RefEntryType { Id=Guid.Parse("0d7e58fd-fa79-4cdc-925a-25df1a7fa330"), Code="01830", Description="Transfer from a school outside of the country", Definition="Transfer from a school outside of the country is the process by which the student entered a school during a given academic session.", SortOrder=Convert.ToDecimal("10.00") },
            new RefEntryType { Id=Guid.Parse("db57df3b-cef5-4da2-95f1-822727251e04"), Code="01831", Description="Transfer from an institution", Definition="Transfer from an institution is the process by which the student entered a school during a given academic session.", SortOrder=Convert.ToDecimal("11.00") },
            new RefEntryType { Id=Guid.Parse("ecbef8c6-30df-470a-9f1c-4c092567eb18"), Code="01832", Description="Transfer from a charter school", Definition="Transfer from a charter school is the process by which the student entered a school during a given academic session.", SortOrder=Convert.ToDecimal("12.00") },
            new RefEntryType { Id=Guid.Parse("3d54d9f1-a581-4ff1-b27f-5d53db13594c"), Code="01833", Description="Transfer from home schooling", Definition="Transfer from home schooling is the process by which the student entered a school during a given academic session.", SortOrder=Convert.ToDecimal("13.00") },
            new RefEntryType { Id=Guid.Parse("ec4c319d-acf3-457f-9fe9-70b7227de50f"), Code="01835", Description="Re-entry from the same school with no interruption of schooling", Definition="Re-entry from the same school with no interruption of schooling is the process by which the student entered a school during a given academic session.", SortOrder=Convert.ToDecimal("14.00") },
            new RefEntryType { Id=Guid.Parse("255e75d6-dd06-4ae9-b991-2b7dc3e13d53"), Code="01836", Description="Re-entry after a voluntary withdrawal", Definition="Re-entry after a voluntary withdrawal is the process by which the student entered a school during a given academic session.", SortOrder=Convert.ToDecimal("15.00") },
            new RefEntryType { Id=Guid.Parse("9486011f-512c-402a-99a4-07d400bbc9d6"), Code="01837", Description="Re-entry after an involuntary withdrawal", Definition="Re-entry after an involuntary withdrawal is the process by which the student entered a school during a given academic session.", SortOrder=Convert.ToDecimal("16.00") },
            new RefEntryType { Id=Guid.Parse("a54bd0e7-19be-4bbb-86b2-4c61cffe5b11"), Code="01838", Description="Original entry into a United States school", Definition="Original entry into a United States school is the process by which the student entered a school during a given academic session.", SortOrder=Convert.ToDecimal("17.00") },
            new RefEntryType { Id=Guid.Parse("29c8135d-8c5c-48d8-b3c3-898a4740af6e"), Code="01839", Description="Original entry into a United States school from a foreign country with no interruption in schooling", Definition="Original entry into a United States school from a foreign country with no interruption in schooling is the process by which the student entered a school during a given academic session.", SortOrder=Convert.ToDecimal("18.00") },
            new RefEntryType { Id=Guid.Parse("ad7fe060-87c3-49fc-ab56-f710b3ca8c6a"), Code="01840", Description="Original entry into a United States school from a foreign country with an interruption in schooling", Definition="Original entry into a United States school from a foreign country with an interruption in schooling is the process by which the student entered a school during a given academic session.", SortOrder=Convert.ToDecimal("19.00") },
            new RefEntryType { Id=Guid.Parse("4aba210f-891e-4663-92ee-6501ea08b2e1"), Code="09999", Description="Other", Definition="The process by which the student entered a school during a given academic session is in a category not yet defined in CEDS.", SortOrder=Convert.ToDecimal("20.00") },
        };

        /// <summary>
        /// The Reference RefEntryType Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefEntryTypeViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefEntryType { Id=Guid.Parse("1cd616b6-d200-4ab3-8925-d735d18fbd0c"), Description="Transfer from a public school in the same local education agency", SortOrder=Convert.ToDecimal("1.00") },
            new RefEntryType { Id=Guid.Parse("8395e96f-24f0-4747-ac36-81767b9b705e"), Description="Transfer from a public school in a different local education agency in the same state", SortOrder=Convert.ToDecimal("2.00") },
            new RefEntryType { Id=Guid.Parse("dddaa2bc-ef25-446d-873b-618ea012a11f"), Description="Transfer from a public school in a different state", SortOrder=Convert.ToDecimal("3.00") },
            new RefEntryType { Id=Guid.Parse("6bd626b3-5255-4aa5-bf56-50779d5feec0"), Description="Transfer from a private, non-religiously-affiliated school in the same local education agency", SortOrder=Convert.ToDecimal("4.00") },
            new RefEntryType { Id=Guid.Parse("865a0843-52b7-40e5-8827-4033aa1f2494"), Description="Transfer from a private, non-religiously-affiliated school in a different LEA in the same state", SortOrder=Convert.ToDecimal("5.00") },
            new RefEntryType { Id=Guid.Parse("faa54c07-42ed-42ce-97bf-404f77d75d79"), Description="Transfer from a private, non-religiously-affiliated school in a different state", SortOrder=Convert.ToDecimal("6.00") },
            new RefEntryType { Id=Guid.Parse("87a3c794-362a-4d75-85aa-62b44fc15125"), Description="Transfer from a private, religiously-affiliated school in the same local education agency", SortOrder=Convert.ToDecimal("7.00") },
            new RefEntryType { Id=Guid.Parse("a162ea1e-127c-4470-86f5-1130eaca3142"), Description="Transfer from a private, religiously-affiliated school in a different LEA in the same state", SortOrder=Convert.ToDecimal("8.00") },
            new RefEntryType { Id=Guid.Parse("4753afb4-e7df-4618-931f-a414a7f09f66"), Description="Transfer from a private, religiously-affiliated school in a different state", SortOrder=Convert.ToDecimal("9.00") },
            new RefEntryType { Id=Guid.Parse("0d7e58fd-fa79-4cdc-925a-25df1a7fa330"), Description="Transfer from a school outside of the country", SortOrder=Convert.ToDecimal("10.00") },
            new RefEntryType { Id=Guid.Parse("db57df3b-cef5-4da2-95f1-822727251e04"), Description="Transfer from an institution", SortOrder=Convert.ToDecimal("11.00") },
            new RefEntryType { Id=Guid.Parse("ecbef8c6-30df-470a-9f1c-4c092567eb18"), Description="Transfer from a charter school", SortOrder=Convert.ToDecimal("12.00") },
            new RefEntryType { Id=Guid.Parse("3d54d9f1-a581-4ff1-b27f-5d53db13594c"), Description="Transfer from home schooling", SortOrder=Convert.ToDecimal("13.00") },
            new RefEntryType { Id=Guid.Parse("ec4c319d-acf3-457f-9fe9-70b7227de50f"), Description="Re-entry from the same school with no interruption of schooling", SortOrder=Convert.ToDecimal("14.00") },
            new RefEntryType { Id=Guid.Parse("255e75d6-dd06-4ae9-b991-2b7dc3e13d53"), Description="Re-entry after a voluntary withdrawal", SortOrder=Convert.ToDecimal("15.00") },
            new RefEntryType { Id=Guid.Parse("9486011f-512c-402a-99a4-07d400bbc9d6"), Description="Re-entry after an involuntary withdrawal", SortOrder=Convert.ToDecimal("16.00") },
            new RefEntryType { Id=Guid.Parse("a54bd0e7-19be-4bbb-86b2-4c61cffe5b11"), Description="Original entry into a United States school", SortOrder=Convert.ToDecimal("17.00") },
            new RefEntryType { Id=Guid.Parse("29c8135d-8c5c-48d8-b3c3-898a4740af6e"), Description="Original entry into a United States school from a foreign country with no interruption in schooling", SortOrder=Convert.ToDecimal("18.00") },
            new RefEntryType { Id=Guid.Parse("ad7fe060-87c3-49fc-ab56-f710b3ca8c6a"), Description="Original entry into a United States school from a foreign country with an interruption in schooling", SortOrder=Convert.ToDecimal("19.00") },
            new RefEntryType { Id=Guid.Parse("4aba210f-891e-4663-92ee-6501ea08b2e1"), Description="Other", SortOrder=Convert.ToDecimal("20.00") },
       };
   }
}
