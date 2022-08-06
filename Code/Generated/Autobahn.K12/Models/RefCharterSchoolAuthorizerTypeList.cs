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
        /// The complete <see cref="RefCharterSchoolAuthorizerType"> List
         /// </summary>
        public static List<RefCharterSchoolAuthorizerType> RefCharterSchoolAuthorizerTypeList = new List<RefCharterSchoolAuthorizerType> =
        {
            new RefCharterSchoolAuthorizerType { Id=Guid.Parse("984cdd94-057f-43ab-93ca-8698f50443bb"), Code="State board of education is specified as the type of agency that authorized the establishment or continuation of a charter school.", Description="SBE", Definition="", SortOrder=0 },
            new RefCharterSchoolAuthorizerType { Id=Guid.Parse("2ab362a4-29d7-4399-9c27-7d10ad9ed97f"), Code="Public charter school board is specified as the type of agency that authorized the establishment or continuation of a charter school.", Description="PCSB", Definition="", SortOrder=0 },
            new RefCharterSchoolAuthorizerType { Id=Guid.Parse("16ab4db9-b18e-405c-adfe-214ce55a5481"), Code="University is specified as the type of agency that authorized the establishment or continuation of a charter school.", Description="UNI", Definition="", SortOrder=0 },
            new RefCharterSchoolAuthorizerType { Id=Guid.Parse("356d78d1-2d6b-417c-a790-3b2490512bbb"), Code="Community college is specified as the type of agency that authorized the establishment or continuation of a charter school.", Description="CC", Definition="", SortOrder=0 },
            new RefCharterSchoolAuthorizerType { Id=Guid.Parse("6477036b-f2e9-47ed-8944-12fdb5be6745"), Code="Local education agency is specified as the type of agency that authorized the establishment or continuation of a charter school.", Description="LEA", Definition="", SortOrder=0 },
            new RefCharterSchoolAuthorizerType { Id=Guid.Parse("68674918-7db6-4fdb-8ec2-590850916cf9"), Code="Other is specified as the type of agency that authorized the establishment or continuation of a charter school.", Description="OTH", Definition="", SortOrder=0 },
            new RefCharterSchoolAuthorizerType { Id=Guid.Parse("2dd932f1-7b39-416a-b946-c7c1e7be42ee"), Code="Non educational government entities is specified as the type of agency that authorized the establishment or continuation of a charter school.", Description="GOVTENT", Definition="", SortOrder=0 },
            new RefCharterSchoolAuthorizerType { Id=Guid.Parse("cf3251f4-e9aa-48dc-8f8b-85e2bafd892b"), Code="Not for profit organization is specified as the type of agency that authorized the establishment or continuation of a charter school.", Description="NONPROFIT", Definition="", SortOrder=0 },
            new RefCharterSchoolAuthorizerType { Id=Guid.Parse("2dc34fcd-426e-4ea1-b62e-69c00b0b40e1"), Code="State department of education is specified as the type of agency that authorized the establishment or continuation of a charter school.", Description="SEA", Definition="", SortOrder=0 },
        };

        /// <summary>
        /// The RefCharterSchoolAuthorizerType Pick List
         /// </summary>
        public static List<RefCharterSchoolAuthorizerType> RefCharterSchoolAuthorizerTypePickList = new List<RefCharterSchoolAuthorizerType> =
        {
            new RefCharterSchoolAuthorizerType { Id=Guid.Parse("984cdd94-057f-43ab-93ca-8698f50443bb"), Code="State board of education is specified as the type of agency that authorized the establishment or continuation of a charter school.", SortOrder=0 },
            new RefCharterSchoolAuthorizerType { Id=Guid.Parse("2ab362a4-29d7-4399-9c27-7d10ad9ed97f"), Code="Public charter school board is specified as the type of agency that authorized the establishment or continuation of a charter school.", SortOrder=0 },
            new RefCharterSchoolAuthorizerType { Id=Guid.Parse("16ab4db9-b18e-405c-adfe-214ce55a5481"), Code="University is specified as the type of agency that authorized the establishment or continuation of a charter school.", SortOrder=0 },
            new RefCharterSchoolAuthorizerType { Id=Guid.Parse("356d78d1-2d6b-417c-a790-3b2490512bbb"), Code="Community college is specified as the type of agency that authorized the establishment or continuation of a charter school.", SortOrder=0 },
            new RefCharterSchoolAuthorizerType { Id=Guid.Parse("6477036b-f2e9-47ed-8944-12fdb5be6745"), Code="Local education agency is specified as the type of agency that authorized the establishment or continuation of a charter school.", SortOrder=0 },
            new RefCharterSchoolAuthorizerType { Id=Guid.Parse("68674918-7db6-4fdb-8ec2-590850916cf9"), Code="Other is specified as the type of agency that authorized the establishment or continuation of a charter school.", SortOrder=0 },
            new RefCharterSchoolAuthorizerType { Id=Guid.Parse("2dd932f1-7b39-416a-b946-c7c1e7be42ee"), Code="Non educational government entities is specified as the type of agency that authorized the establishment or continuation of a charter school.", SortOrder=0 },
            new RefCharterSchoolAuthorizerType { Id=Guid.Parse("cf3251f4-e9aa-48dc-8f8b-85e2bafd892b"), Code="Not for profit organization is specified as the type of agency that authorized the establishment or continuation of a charter school.", SortOrder=0 },
            new RefCharterSchoolAuthorizerType { Id=Guid.Parse("2dc34fcd-426e-4ea1-b62e-69c00b0b40e1"), Code="State department of education is specified as the type of agency that authorized the establishment or continuation of a charter school.", SortOrder=0 },
       };
   }
}
