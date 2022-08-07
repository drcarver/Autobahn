//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   RefCharterSchoolAuthorizerTypeList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.K12.Models
{
     /// <summary>
     /// The list of RefCharterSchoolAuthorizerType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefCharterSchoolAuthorizerTypeModel"> List
         /// </summary>
        public static List<RefCharterSchoolAuthorizerTypeModel> RefCharterSchoolAuthorizerTypeList = new List<RefCharterSchoolAuthorizerTypeModel>
        {
            new RefCharterSchoolAuthorizerType { Id=Guid.Parse("8b4a7e6a-5003-46de-903a-9089d865b1c3"), Code="SBE", Description="State board of education", Definition="State board of education is specified as the type of agency that authorized the establishment or continuation of a charter school.", SortOrder=Convert.ToDecimal("1.00") },
            new RefCharterSchoolAuthorizerType { Id=Guid.Parse("d78f9178-dec5-45e0-8edf-ebadce590998"), Code="PCSB", Description="Public charter school board", Definition="Public charter school board is specified as the type of agency that authorized the establishment or continuation of a charter school.", SortOrder=Convert.ToDecimal("3.00") },
            new RefCharterSchoolAuthorizerType { Id=Guid.Parse("aa1abeca-1403-4fd2-ab52-2108a92fe754"), Code="UNI", Description="University", Definition="University is specified as the type of agency that authorized the establishment or continuation of a charter school.", SortOrder=Convert.ToDecimal("5.00") },
            new RefCharterSchoolAuthorizerType { Id=Guid.Parse("d52a8744-a9d3-45c9-8198-370166a3f4e4"), Code="CC", Description="Community college", Definition="Community college is specified as the type of agency that authorized the establishment or continuation of a charter school.", SortOrder=Convert.ToDecimal("6.00") },
            new RefCharterSchoolAuthorizerType { Id=Guid.Parse("b1a0b49f-a957-444c-878b-48505f27d646"), Code="LEA", Description="Local education agency", Definition="Local education agency is specified as the type of agency that authorized the establishment or continuation of a charter school.", SortOrder=Convert.ToDecimal("7.00") },
            new RefCharterSchoolAuthorizerType { Id=Guid.Parse("92909321-78f7-419d-b4f5-80058b34c24e"), Code="OTH", Description="Other", Definition="Other is specified as the type of agency that authorized the establishment or continuation of a charter school.", SortOrder=Convert.ToDecimal("7.00") },
            new RefCharterSchoolAuthorizerType { Id=Guid.Parse("85f2b478-7aed-4ca0-ab95-3d2910e2b425"), Code="GOVTENT", Description="Non educational government entities", Definition="Non educational government entities is specified as the type of agency that authorized the establishment or continuation of a charter school.", SortOrder=Convert.ToDecimal("8.00") },
            new RefCharterSchoolAuthorizerType { Id=Guid.Parse("3283851a-fd9a-4528-b4cb-d62b2597be66"), Code="NONPROFIT", Description="Not for profit organization", Definition="Not for profit organization is specified as the type of agency that authorized the establishment or continuation of a charter school.", SortOrder=Convert.ToDecimal("9.00") },
            new RefCharterSchoolAuthorizerType { Id=Guid.Parse("dc7d2dd4-9407-4c0c-9350-2d7b75322a49"), Code="SEA", Description="State department of education", Definition="State department of education is specified as the type of agency that authorized the establishment or continuation of a charter school.", SortOrder=Convert.ToDecimal("10.00") },
        };

        /// <summary>
        /// The Reference RefCharterSchoolAuthorizerType Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefCharterSchoolAuthorizerTypeViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefCharterSchoolAuthorizerType { Id=Guid.Parse("8b4a7e6a-5003-46de-903a-9089d865b1c3"), Description="State board of education", SortOrder=Convert.ToDecimal("1.00") },
            new RefCharterSchoolAuthorizerType { Id=Guid.Parse("d78f9178-dec5-45e0-8edf-ebadce590998"), Description="Public charter school board", SortOrder=Convert.ToDecimal("3.00") },
            new RefCharterSchoolAuthorizerType { Id=Guid.Parse("aa1abeca-1403-4fd2-ab52-2108a92fe754"), Description="University", SortOrder=Convert.ToDecimal("5.00") },
            new RefCharterSchoolAuthorizerType { Id=Guid.Parse("d52a8744-a9d3-45c9-8198-370166a3f4e4"), Description="Community college", SortOrder=Convert.ToDecimal("6.00") },
            new RefCharterSchoolAuthorizerType { Id=Guid.Parse("b1a0b49f-a957-444c-878b-48505f27d646"), Description="Local education agency", SortOrder=Convert.ToDecimal("7.00") },
            new RefCharterSchoolAuthorizerType { Id=Guid.Parse("92909321-78f7-419d-b4f5-80058b34c24e"), Description="Other", SortOrder=Convert.ToDecimal("7.00") },
            new RefCharterSchoolAuthorizerType { Id=Guid.Parse("85f2b478-7aed-4ca0-ab95-3d2910e2b425"), Description="Non educational government entities", SortOrder=Convert.ToDecimal("8.00") },
            new RefCharterSchoolAuthorizerType { Id=Guid.Parse("3283851a-fd9a-4528-b4cb-d62b2597be66"), Description="Not for profit organization", SortOrder=Convert.ToDecimal("9.00") },
            new RefCharterSchoolAuthorizerType { Id=Guid.Parse("dc7d2dd4-9407-4c0c-9350-2d7b75322a49"), Description="State department of education", SortOrder=Convert.ToDecimal("10.00") },
       };
   }
}
