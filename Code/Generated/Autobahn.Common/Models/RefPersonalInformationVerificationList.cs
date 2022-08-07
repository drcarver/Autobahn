//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefPersonalInformationVerificationList.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefPersonalInformationVerification Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefPersonalInformationVerificationModel"> List
         /// </summary>
        public static List<RefPersonalInformationVerificationModel> RefPersonalInformationVerificationList = new List<RefPersonalInformationVerificationModel>
        {
            new RefPersonalInformationVerification { Id=Guid.Parse("a5562c60-1287-4c23-8251-981acba19fbb"), Code="01003", Description="Baptismal or church certificate", Definition="Baptismal or church certificate was used as evidence to verify a person's name, address, date of birth, etc.", SortOrder=Convert.ToDecimal("1.00") },
            new RefPersonalInformationVerification { Id=Guid.Parse("89e10223-61ff-4753-b4dc-5e9fec411a9f"), Code="01004", Description="Birth certificate", Definition="Birth certificate was used as evidence to verify a person's name, address, date of birth, etc.", SortOrder=Convert.ToDecimal("2.00") },
            new RefPersonalInformationVerification { Id=Guid.Parse("e9eed9d1-4932-4723-99be-95d6758fe47d"), Code="01012", Description="Driver's license", Definition="Driver's license was used as evidence to verify a person's name, address, date of birth, etc.", SortOrder=Convert.ToDecimal("3.00") },
            new RefPersonalInformationVerification { Id=Guid.Parse("7bef90be-4a33-4062-9f43-fc49e365a114"), Code="01005", Description="Entry in family Bible", Definition="Entry in family Bible was used as evidence to verify a person's name, address, date of birth, etc.", SortOrder=Convert.ToDecimal("4.00") },
            new RefPersonalInformationVerification { Id=Guid.Parse("97303ada-2ca9-472b-a1c4-ac067ff17435"), Code="01006", Description="Hospital certificate", Definition="Hospital certificate was used as evidence to verify a person's name, address, date of birth, etc.", SortOrder=Convert.ToDecimal("5.00") },
            new RefPersonalInformationVerification { Id=Guid.Parse("288cb90e-52ff-4707-b478-c00954c9b5df"), Code="01013", Description="Immigration document/visa", Definition="Immigration document/visa was used as evidence to verify a person's name, address, date of birth, etc.", SortOrder=Convert.ToDecimal("6.00") },
            new RefPersonalInformationVerification { Id=Guid.Parse("135b22c5-cb2c-4bd8-99ad-a4b82e284ef2"), Code="02382", Description="Life insurance policy", Definition="Life insurance policy was used as evidence to verify a person's name, address, date of birth, etc.", SortOrder=Convert.ToDecimal("7.00") },
            new RefPersonalInformationVerification { Id=Guid.Parse("c7f727cd-f4f6-4fbd-a39c-21369654e867"), Code="09999", Description="Other", Definition="Evidence used to verify a person's name, address, date of birth, etc. is in a category not yet defined in CEDS.", SortOrder=Convert.ToDecimal("8.00") },
            new RefPersonalInformationVerification { Id=Guid.Parse("78891ef5-168f-49b7-93ab-fe7b82b3cc27"), Code="03424", Description="Other non-official document", Definition="Other non-official document  was used as evidence to verify a person's name, address, date of birth, etc.", SortOrder=Convert.ToDecimal("9.00") },
            new RefPersonalInformationVerification { Id=Guid.Parse("e4091391-5adc-460e-a12b-0271229e6021"), Code="03423", Description="Other official document", Definition="Other official document was used as evidence to verify a person's name, address, date of birth, etc.", SortOrder=Convert.ToDecimal("10.00") },
            new RefPersonalInformationVerification { Id=Guid.Parse("18d29487-39ae-42e7-ad43-9142fc793963"), Code="01007", Description="Parent's affidavit", Definition="Parent's affidavit was used as evidence to verify a person's name, address, date of birth, etc.", SortOrder=Convert.ToDecimal("11.00") },
            new RefPersonalInformationVerification { Id=Guid.Parse("22a3e4a5-49f0-4727-8033-d2579686c319"), Code="01008", Description="Passport", Definition="Passport was used as evidence to verify a person's name, address, date of birth, etc.", SortOrder=Convert.ToDecimal("12.00") },
            new RefPersonalInformationVerification { Id=Guid.Parse("5bc9f71d-c92b-4c89-8902-dbfedd2cd814"), Code="01009", Description="Physician's certificate", Definition="Physician's certificate was used as evidence to verify a person's name, address, date of birth, etc.", SortOrder=Convert.ToDecimal("13.00") },
            new RefPersonalInformationVerification { Id=Guid.Parse("e40829ad-e06b-40ee-a0be-84d86e921c71"), Code="01010", Description="Previously verified school records", Definition="Previously verified school records was used as evidence to verify a person's name, address, date of birth, etc.", SortOrder=Convert.ToDecimal("14.00") },
            new RefPersonalInformationVerification { Id=Guid.Parse("2d6d6d12-3b80-4134-b16b-f84bbb5485e2"), Code="01011", Description="State-issued ID", Definition="State-issued ID was used as evidence to verify a person's name, address, date of birth, etc.", SortOrder=Convert.ToDecimal("15.00") },
            new RefPersonalInformationVerification { Id=Guid.Parse("d27b2cd6-5a1d-414f-b8b6-33d48896fe55"), Code="73095", Description="Approved Transfer", Definition="An approved student transfer in the student information system was used as evidence to verify a person's name, address, date of birth, etc.", SortOrder=Convert.ToDecimal("16.00") },
            new RefPersonalInformationVerification { Id=Guid.Parse("ea4dd930-a12f-4427-8b22-9eb12c7271fb"), Code="73102", Description="Birth Registration Form", Definition="A birth registration form was used as evidence to verify a person's name, address, date of birth, etc.", SortOrder=Convert.ToDecimal("17.00") },
            new RefPersonalInformationVerification { Id=Guid.Parse("4746690a-f6cd-48a3-952d-0daf4f986a45"), Code="73097", Description="Citizenship Card", Definition="A citizenship card was used as evidence to verify a person's name, address, date of birth, etc.", SortOrder=Convert.ToDecimal("18.00") },
            new RefPersonalInformationVerification { Id=Guid.Parse("5cd4e66e-2aea-456a-8c5f-f080b0ac089a"), Code="73100", Description="Lease Agreement", Definition="A lease agreement was used as evidence to verify a person's name, address, date of birth, etc.", SortOrder=Convert.ToDecimal("19.00") },
            new RefPersonalInformationVerification { Id=Guid.Parse("8ec70572-656e-4117-9f8e-5144241fb805"), Code="73093", Description="Non-Parent Affidavit of Residence", Definition="A non-parent's affidavit of residency was used as evidence to verify a person's name, address, date of birth, etc.", SortOrder=Convert.ToDecimal("20.00") },
            new RefPersonalInformationVerification { Id=Guid.Parse("a7dc4160-cbf9-402d-a5b7-efa72f796a5e"), Code="73094", Description="Parent's Affidavit of Residence", Definition="A parent/guardian affidavit of residency was used as evidence to verify a person's name, address, date of birth, etc.", SortOrder=Convert.ToDecimal("21.00") },
            new RefPersonalInformationVerification { Id=Guid.Parse("06712d0f-b358-44c4-bf98-4ad5af8a7a6c"), Code="73101", Description="Purchase Agreement", Definition="A purchase agreement was used as evidence to verify a person's name, address, date of birth, etc.", SortOrder=Convert.ToDecimal("22.00") },
            new RefPersonalInformationVerification { Id=Guid.Parse("b36b1746-7535-4f3b-be51-bd21991553b3"), Code="73092", Description="Residence Verification Form", Definition="A form verifying residency was used as evidence to verify a person's name, address, date of birth, etc.", SortOrder=Convert.ToDecimal("23.00") },
            new RefPersonalInformationVerification { Id=Guid.Parse("4c00d0db-e33b-4505-83a1-961b56335b61"), Code="73098", Description="Tax Bill", Definition="A tax bill was used as evidence to verify a person's name, address, date of birth, etc.", SortOrder=Convert.ToDecimal("24.00") },
            new RefPersonalInformationVerification { Id=Guid.Parse("ddf50969-81a3-49cc-9148-1441d1e62dbf"), Code="73091", Description="Telephone Bill", Definition="A telephone bill was used as evidence to verify a person's name, address, date of birth, etc.", SortOrder=Convert.ToDecimal("25.00") },
            new RefPersonalInformationVerification { Id=Guid.Parse("0741b382-b468-40c4-9ce7-296d51fc1757"), Code="73099", Description="Utility Bill", Definition="A utility bill was used as evidence to verify a person's name, address, date of birth, etc.", SortOrder=Convert.ToDecimal("26.00") },
            new RefPersonalInformationVerification { Id=Guid.Parse("2871cadb-0c58-4c09-b05a-bd50f38cd996"), Code="73096", Description="Water Bill", Definition="A water bill was used as evidence to verify a person's name, address, date of birth, etc.", SortOrder=Convert.ToDecimal("27.00") },
        };

        /// <summary>
        /// The Reference RefPersonalInformationVerification Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefPersonalInformationVerificationViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefPersonalInformationVerification { Id=Guid.Parse("a5562c60-1287-4c23-8251-981acba19fbb"), Description="Baptismal or church certificate", SortOrder=Convert.ToDecimal("1.00") },
            new RefPersonalInformationVerification { Id=Guid.Parse("89e10223-61ff-4753-b4dc-5e9fec411a9f"), Description="Birth certificate", SortOrder=Convert.ToDecimal("2.00") },
            new RefPersonalInformationVerification { Id=Guid.Parse("e9eed9d1-4932-4723-99be-95d6758fe47d"), Description="Driver's license", SortOrder=Convert.ToDecimal("3.00") },
            new RefPersonalInformationVerification { Id=Guid.Parse("7bef90be-4a33-4062-9f43-fc49e365a114"), Description="Entry in family Bible", SortOrder=Convert.ToDecimal("4.00") },
            new RefPersonalInformationVerification { Id=Guid.Parse("97303ada-2ca9-472b-a1c4-ac067ff17435"), Description="Hospital certificate", SortOrder=Convert.ToDecimal("5.00") },
            new RefPersonalInformationVerification { Id=Guid.Parse("288cb90e-52ff-4707-b478-c00954c9b5df"), Description="Immigration document/visa", SortOrder=Convert.ToDecimal("6.00") },
            new RefPersonalInformationVerification { Id=Guid.Parse("135b22c5-cb2c-4bd8-99ad-a4b82e284ef2"), Description="Life insurance policy", SortOrder=Convert.ToDecimal("7.00") },
            new RefPersonalInformationVerification { Id=Guid.Parse("c7f727cd-f4f6-4fbd-a39c-21369654e867"), Description="Other", SortOrder=Convert.ToDecimal("8.00") },
            new RefPersonalInformationVerification { Id=Guid.Parse("78891ef5-168f-49b7-93ab-fe7b82b3cc27"), Description="Other non-official document", SortOrder=Convert.ToDecimal("9.00") },
            new RefPersonalInformationVerification { Id=Guid.Parse("e4091391-5adc-460e-a12b-0271229e6021"), Description="Other official document", SortOrder=Convert.ToDecimal("10.00") },
            new RefPersonalInformationVerification { Id=Guid.Parse("18d29487-39ae-42e7-ad43-9142fc793963"), Description="Parent's affidavit", SortOrder=Convert.ToDecimal("11.00") },
            new RefPersonalInformationVerification { Id=Guid.Parse("22a3e4a5-49f0-4727-8033-d2579686c319"), Description="Passport", SortOrder=Convert.ToDecimal("12.00") },
            new RefPersonalInformationVerification { Id=Guid.Parse("5bc9f71d-c92b-4c89-8902-dbfedd2cd814"), Description="Physician's certificate", SortOrder=Convert.ToDecimal("13.00") },
            new RefPersonalInformationVerification { Id=Guid.Parse("e40829ad-e06b-40ee-a0be-84d86e921c71"), Description="Previously verified school records", SortOrder=Convert.ToDecimal("14.00") },
            new RefPersonalInformationVerification { Id=Guid.Parse("2d6d6d12-3b80-4134-b16b-f84bbb5485e2"), Description="State-issued ID", SortOrder=Convert.ToDecimal("15.00") },
            new RefPersonalInformationVerification { Id=Guid.Parse("d27b2cd6-5a1d-414f-b8b6-33d48896fe55"), Description="Approved Transfer", SortOrder=Convert.ToDecimal("16.00") },
            new RefPersonalInformationVerification { Id=Guid.Parse("ea4dd930-a12f-4427-8b22-9eb12c7271fb"), Description="Birth Registration Form", SortOrder=Convert.ToDecimal("17.00") },
            new RefPersonalInformationVerification { Id=Guid.Parse("4746690a-f6cd-48a3-952d-0daf4f986a45"), Description="Citizenship Card", SortOrder=Convert.ToDecimal("18.00") },
            new RefPersonalInformationVerification { Id=Guid.Parse("5cd4e66e-2aea-456a-8c5f-f080b0ac089a"), Description="Lease Agreement", SortOrder=Convert.ToDecimal("19.00") },
            new RefPersonalInformationVerification { Id=Guid.Parse("8ec70572-656e-4117-9f8e-5144241fb805"), Description="Non-Parent Affidavit of Residence", SortOrder=Convert.ToDecimal("20.00") },
            new RefPersonalInformationVerification { Id=Guid.Parse("a7dc4160-cbf9-402d-a5b7-efa72f796a5e"), Description="Parent's Affidavit of Residence", SortOrder=Convert.ToDecimal("21.00") },
            new RefPersonalInformationVerification { Id=Guid.Parse("06712d0f-b358-44c4-bf98-4ad5af8a7a6c"), Description="Purchase Agreement", SortOrder=Convert.ToDecimal("22.00") },
            new RefPersonalInformationVerification { Id=Guid.Parse("b36b1746-7535-4f3b-be51-bd21991553b3"), Description="Residence Verification Form", SortOrder=Convert.ToDecimal("23.00") },
            new RefPersonalInformationVerification { Id=Guid.Parse("4c00d0db-e33b-4505-83a1-961b56335b61"), Description="Tax Bill", SortOrder=Convert.ToDecimal("24.00") },
            new RefPersonalInformationVerification { Id=Guid.Parse("ddf50969-81a3-49cc-9148-1441d1e62dbf"), Description="Telephone Bill", SortOrder=Convert.ToDecimal("25.00") },
            new RefPersonalInformationVerification { Id=Guid.Parse("0741b382-b468-40c4-9ce7-296d51fc1757"), Description="Utility Bill", SortOrder=Convert.ToDecimal("26.00") },
            new RefPersonalInformationVerification { Id=Guid.Parse("2871cadb-0c58-4c09-b05a-bd50f38cd996"), Description="Water Bill", SortOrder=Convert.ToDecimal("27.00") },
       };
   }
}
