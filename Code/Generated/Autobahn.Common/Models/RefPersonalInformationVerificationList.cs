//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefPersonalInformationVerificationList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefPersonalInformationVerification Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefPersonalInformationVerification"> List
         /// </summary>
        public static List<RefPersonalInformationVerification> RefPersonalInformationVerificationList = new List<RefPersonalInformationVerification>
        {
            new RefPersonalInformationVerification { Id=Guid.Parse("6243af26-47ee-48b1-b3b7-96fe7ead7f5b"), Code="01003", Description="Baptismal or church certificate", Definition="Baptismal or church certificate was used as evidence to verify a person's name, address, date of birth, etc.", SortOrder=Convert.ToDecimal("1.00") },
            new RefPersonalInformationVerification { Id=Guid.Parse("21249012-44c4-4ce8-9c3d-6f65469f2953"), Code="01004", Description="Birth certificate", Definition="Birth certificate was used as evidence to verify a person's name, address, date of birth, etc.", SortOrder=Convert.ToDecimal("2.00") },
            new RefPersonalInformationVerification { Id=Guid.Parse("ec297dd9-6d53-4ae7-af91-a0c8bd768237"), Code="01012", Description="Driver's license", Definition="Driver's license was used as evidence to verify a person's name, address, date of birth, etc.", SortOrder=Convert.ToDecimal("3.00") },
            new RefPersonalInformationVerification { Id=Guid.Parse("cf271f0d-2951-41e9-92d1-4b81e7379075"), Code="01005", Description="Entry in family Bible", Definition="Entry in family Bible was used as evidence to verify a person's name, address, date of birth, etc.", SortOrder=Convert.ToDecimal("4.00") },
            new RefPersonalInformationVerification { Id=Guid.Parse("c97c17a3-8de0-4ac4-9749-af4dc719e6ec"), Code="01006", Description="Hospital certificate", Definition="Hospital certificate was used as evidence to verify a person's name, address, date of birth, etc.", SortOrder=Convert.ToDecimal("5.00") },
            new RefPersonalInformationVerification { Id=Guid.Parse("e1af450c-14a2-4e8b-920a-73c129a9b08d"), Code="01013", Description="Immigration document/visa", Definition="Immigration document/visa was used as evidence to verify a person's name, address, date of birth, etc.", SortOrder=Convert.ToDecimal("6.00") },
            new RefPersonalInformationVerification { Id=Guid.Parse("603d5a0f-aa21-429c-9407-ef467fe5397f"), Code="02382", Description="Life insurance policy", Definition="Life insurance policy was used as evidence to verify a person's name, address, date of birth, etc.", SortOrder=Convert.ToDecimal("7.00") },
            new RefPersonalInformationVerification { Id=Guid.Parse("baf16c2c-a6a5-40a5-84aa-02512c6305d3"), Code="09999", Description="Other", Definition="Evidence used to verify a person's name, address, date of birth, etc. is in a category not yet defined in CEDS.", SortOrder=Convert.ToDecimal("8.00") },
            new RefPersonalInformationVerification { Id=Guid.Parse("f337fa72-dd4b-41f6-8edd-d7158dcfdf61"), Code="03424", Description="Other non-official document", Definition="Other non-official document  was used as evidence to verify a person's name, address, date of birth, etc.", SortOrder=Convert.ToDecimal("9.00") },
            new RefPersonalInformationVerification { Id=Guid.Parse("073d9ffe-e2a0-4cb6-b6d1-831d4d62aaa6"), Code="03423", Description="Other official document", Definition="Other official document was used as evidence to verify a person's name, address, date of birth, etc.", SortOrder=Convert.ToDecimal("10.00") },
            new RefPersonalInformationVerification { Id=Guid.Parse("dc737fa1-2a49-4d08-ba07-9cbc1ec3efb5"), Code="01007", Description="Parent's affidavit", Definition="Parent's affidavit was used as evidence to verify a person's name, address, date of birth, etc.", SortOrder=Convert.ToDecimal("11.00") },
            new RefPersonalInformationVerification { Id=Guid.Parse("dfa552fd-421b-4903-89c1-0c032a7bdd6d"), Code="01008", Description="Passport", Definition="Passport was used as evidence to verify a person's name, address, date of birth, etc.", SortOrder=Convert.ToDecimal("12.00") },
            new RefPersonalInformationVerification { Id=Guid.Parse("71ca9c72-a983-47d2-90ff-c912ffc8bc77"), Code="01009", Description="Physician's certificate", Definition="Physician's certificate was used as evidence to verify a person's name, address, date of birth, etc.", SortOrder=Convert.ToDecimal("13.00") },
            new RefPersonalInformationVerification { Id=Guid.Parse("1a455017-6131-4030-a8af-e2f8f301bd03"), Code="01010", Description="Previously verified school records", Definition="Previously verified school records was used as evidence to verify a person's name, address, date of birth, etc.", SortOrder=Convert.ToDecimal("14.00") },
            new RefPersonalInformationVerification { Id=Guid.Parse("0701a5c4-c5de-4746-beaa-0b81731f4f1a"), Code="01011", Description="State-issued ID", Definition="State-issued ID was used as evidence to verify a person's name, address, date of birth, etc.", SortOrder=Convert.ToDecimal("15.00") },
            new RefPersonalInformationVerification { Id=Guid.Parse("a3ee6b2e-9b9b-42cf-ad4b-4ebdc05df446"), Code="73095", Description="Approved Transfer", Definition="An approved student transfer in the student information system was used as evidence to verify a person's name, address, date of birth, etc.", SortOrder=Convert.ToDecimal("16.00") },
            new RefPersonalInformationVerification { Id=Guid.Parse("6457ed0c-077b-4eb5-beee-c30f7fba24de"), Code="73102", Description="Birth Registration Form", Definition="A birth registration form was used as evidence to verify a person's name, address, date of birth, etc.", SortOrder=Convert.ToDecimal("17.00") },
            new RefPersonalInformationVerification { Id=Guid.Parse("d9f335d8-b564-4752-8068-9c115f7ebbd6"), Code="73097", Description="Citizenship Card", Definition="A citizenship card was used as evidence to verify a person's name, address, date of birth, etc.", SortOrder=Convert.ToDecimal("18.00") },
            new RefPersonalInformationVerification { Id=Guid.Parse("ee976220-6c10-483e-82a2-5c861af83dc1"), Code="73100", Description="Lease Agreement", Definition="A lease agreement was used as evidence to verify a person's name, address, date of birth, etc.", SortOrder=Convert.ToDecimal("19.00") },
            new RefPersonalInformationVerification { Id=Guid.Parse("c72098a5-ab9c-48da-a95c-82ab33f1a7ca"), Code="73093", Description="Non-Parent Affidavit of Residence", Definition="A non-parent's affidavit of residency was used as evidence to verify a person's name, address, date of birth, etc.", SortOrder=Convert.ToDecimal("20.00") },
            new RefPersonalInformationVerification { Id=Guid.Parse("2a0d5679-7d12-4093-8fb8-aa13c68e675a"), Code="73094", Description="Parent's Affidavit of Residence", Definition="A parent/guardian affidavit of residency was used as evidence to verify a person's name, address, date of birth, etc.", SortOrder=Convert.ToDecimal("21.00") },
            new RefPersonalInformationVerification { Id=Guid.Parse("b8bc53bb-cc8f-4574-89b2-ea844f13519e"), Code="73101", Description="Purchase Agreement", Definition="A purchase agreement was used as evidence to verify a person's name, address, date of birth, etc.", SortOrder=Convert.ToDecimal("22.00") },
            new RefPersonalInformationVerification { Id=Guid.Parse("5f07e2b3-40b4-4b10-8507-6cddc58d9d91"), Code="73092", Description="Residence Verification Form", Definition="A form verifying residency was used as evidence to verify a person's name, address, date of birth, etc.", SortOrder=Convert.ToDecimal("23.00") },
            new RefPersonalInformationVerification { Id=Guid.Parse("e4377ad2-82d9-44c5-b138-6d78e26e7390"), Code="73098", Description="Tax Bill", Definition="A tax bill was used as evidence to verify a person's name, address, date of birth, etc.", SortOrder=Convert.ToDecimal("24.00") },
            new RefPersonalInformationVerification { Id=Guid.Parse("bbe61427-4dbd-42ef-bc44-0917170ee4d7"), Code="73091", Description="Telephone Bill", Definition="A telephone bill was used as evidence to verify a person's name, address, date of birth, etc.", SortOrder=Convert.ToDecimal("25.00") },
            new RefPersonalInformationVerification { Id=Guid.Parse("3e262a93-5d33-4767-9829-01868dfe6994"), Code="73099", Description="Utility Bill", Definition="A utility bill was used as evidence to verify a person's name, address, date of birth, etc.", SortOrder=Convert.ToDecimal("26.00") },
            new RefPersonalInformationVerification { Id=Guid.Parse("df6e9b0c-15e6-4d7b-b24c-88c0e8058ed6"), Code="73096", Description="Water Bill", Definition="A water bill was used as evidence to verify a person's name, address, date of birth, etc.", SortOrder=Convert.ToDecimal("27.00") },
        };

        /// <summary>
        /// The RefPersonalInformationVerification Pick List
         /// </summary>
        public static List<RefPersonalInformationVerification> RefPersonalInformationVerificationPickList = new List<RefPersonalInformationVerification>
        {
            new RefPersonalInformationVerification { Id=Guid.Parse("6243af26-47ee-48b1-b3b7-96fe7ead7f5b"), Code="01003", Description="Baptismal or church certificate", SortOrder=Convert.ToDecimal("1.00") },
            new RefPersonalInformationVerification { Id=Guid.Parse("21249012-44c4-4ce8-9c3d-6f65469f2953"), Code="01004", Description="Birth certificate", SortOrder=Convert.ToDecimal("2.00") },
            new RefPersonalInformationVerification { Id=Guid.Parse("ec297dd9-6d53-4ae7-af91-a0c8bd768237"), Code="01012", Description="Driver's license", SortOrder=Convert.ToDecimal("3.00") },
            new RefPersonalInformationVerification { Id=Guid.Parse("cf271f0d-2951-41e9-92d1-4b81e7379075"), Code="01005", Description="Entry in family Bible", SortOrder=Convert.ToDecimal("4.00") },
            new RefPersonalInformationVerification { Id=Guid.Parse("c97c17a3-8de0-4ac4-9749-af4dc719e6ec"), Code="01006", Description="Hospital certificate", SortOrder=Convert.ToDecimal("5.00") },
            new RefPersonalInformationVerification { Id=Guid.Parse("e1af450c-14a2-4e8b-920a-73c129a9b08d"), Code="01013", Description="Immigration document/visa", SortOrder=Convert.ToDecimal("6.00") },
            new RefPersonalInformationVerification { Id=Guid.Parse("603d5a0f-aa21-429c-9407-ef467fe5397f"), Code="02382", Description="Life insurance policy", SortOrder=Convert.ToDecimal("7.00") },
            new RefPersonalInformationVerification { Id=Guid.Parse("baf16c2c-a6a5-40a5-84aa-02512c6305d3"), Code="09999", Description="Other", SortOrder=Convert.ToDecimal("8.00") },
            new RefPersonalInformationVerification { Id=Guid.Parse("f337fa72-dd4b-41f6-8edd-d7158dcfdf61"), Code="03424", Description="Other non-official document", SortOrder=Convert.ToDecimal("9.00") },
            new RefPersonalInformationVerification { Id=Guid.Parse("073d9ffe-e2a0-4cb6-b6d1-831d4d62aaa6"), Code="03423", Description="Other official document", SortOrder=Convert.ToDecimal("10.00") },
            new RefPersonalInformationVerification { Id=Guid.Parse("dc737fa1-2a49-4d08-ba07-9cbc1ec3efb5"), Code="01007", Description="Parent's affidavit", SortOrder=Convert.ToDecimal("11.00") },
            new RefPersonalInformationVerification { Id=Guid.Parse("dfa552fd-421b-4903-89c1-0c032a7bdd6d"), Code="01008", Description="Passport", SortOrder=Convert.ToDecimal("12.00") },
            new RefPersonalInformationVerification { Id=Guid.Parse("71ca9c72-a983-47d2-90ff-c912ffc8bc77"), Code="01009", Description="Physician's certificate", SortOrder=Convert.ToDecimal("13.00") },
            new RefPersonalInformationVerification { Id=Guid.Parse("1a455017-6131-4030-a8af-e2f8f301bd03"), Code="01010", Description="Previously verified school records", SortOrder=Convert.ToDecimal("14.00") },
            new RefPersonalInformationVerification { Id=Guid.Parse("0701a5c4-c5de-4746-beaa-0b81731f4f1a"), Code="01011", Description="State-issued ID", SortOrder=Convert.ToDecimal("15.00") },
            new RefPersonalInformationVerification { Id=Guid.Parse("a3ee6b2e-9b9b-42cf-ad4b-4ebdc05df446"), Code="73095", Description="Approved Transfer", SortOrder=Convert.ToDecimal("16.00") },
            new RefPersonalInformationVerification { Id=Guid.Parse("6457ed0c-077b-4eb5-beee-c30f7fba24de"), Code="73102", Description="Birth Registration Form", SortOrder=Convert.ToDecimal("17.00") },
            new RefPersonalInformationVerification { Id=Guid.Parse("d9f335d8-b564-4752-8068-9c115f7ebbd6"), Code="73097", Description="Citizenship Card", SortOrder=Convert.ToDecimal("18.00") },
            new RefPersonalInformationVerification { Id=Guid.Parse("ee976220-6c10-483e-82a2-5c861af83dc1"), Code="73100", Description="Lease Agreement", SortOrder=Convert.ToDecimal("19.00") },
            new RefPersonalInformationVerification { Id=Guid.Parse("c72098a5-ab9c-48da-a95c-82ab33f1a7ca"), Code="73093", Description="Non-Parent Affidavit of Residence", SortOrder=Convert.ToDecimal("20.00") },
            new RefPersonalInformationVerification { Id=Guid.Parse("2a0d5679-7d12-4093-8fb8-aa13c68e675a"), Code="73094", Description="Parent's Affidavit of Residence", SortOrder=Convert.ToDecimal("21.00") },
            new RefPersonalInformationVerification { Id=Guid.Parse("b8bc53bb-cc8f-4574-89b2-ea844f13519e"), Code="73101", Description="Purchase Agreement", SortOrder=Convert.ToDecimal("22.00") },
            new RefPersonalInformationVerification { Id=Guid.Parse("5f07e2b3-40b4-4b10-8507-6cddc58d9d91"), Code="73092", Description="Residence Verification Form", SortOrder=Convert.ToDecimal("23.00") },
            new RefPersonalInformationVerification { Id=Guid.Parse("e4377ad2-82d9-44c5-b138-6d78e26e7390"), Code="73098", Description="Tax Bill", SortOrder=Convert.ToDecimal("24.00") },
            new RefPersonalInformationVerification { Id=Guid.Parse("bbe61427-4dbd-42ef-bc44-0917170ee4d7"), Code="73091", Description="Telephone Bill", SortOrder=Convert.ToDecimal("25.00") },
            new RefPersonalInformationVerification { Id=Guid.Parse("3e262a93-5d33-4767-9829-01868dfe6994"), Code="73099", Description="Utility Bill", SortOrder=Convert.ToDecimal("26.00") },
            new RefPersonalInformationVerification { Id=Guid.Parse("df6e9b0c-15e6-4d7b-b24c-88c0e8058ed6"), Code="73096", Description="Water Bill", SortOrder=Convert.ToDecimal("27.00") },
       };
   }
}
