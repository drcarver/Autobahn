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
        public static List<RefCharterSchoolAuthorizerType> RefCharterSchoolAuthorizerTypeList = new List<RefCharterSchoolAuthorizerType>
        {
            new RefCharterSchoolAuthorizerType { Id=Guid.Parse("7dd9badd-2d80-4ac4-afb0-d3cdde73572e"), Code="SBE", Description="State board of education", Definition="State board of education is specified as the type of agency that authorized the establishment or continuation of a charter school.", SortOrder=Convert.ToDecimal("1.00") },
            new RefCharterSchoolAuthorizerType { Id=Guid.Parse("93f5085c-df1b-49b3-a66d-77ab8b4fd974"), Code="PCSB", Description="Public charter school board", Definition="Public charter school board is specified as the type of agency that authorized the establishment or continuation of a charter school.", SortOrder=Convert.ToDecimal("3.00") },
            new RefCharterSchoolAuthorizerType { Id=Guid.Parse("dcb6530e-a267-4de0-afe7-f03bf5af983e"), Code="UNI", Description="University", Definition="University is specified as the type of agency that authorized the establishment or continuation of a charter school.", SortOrder=Convert.ToDecimal("5.00") },
            new RefCharterSchoolAuthorizerType { Id=Guid.Parse("4d7af452-a9c0-42e7-9a02-5abf2559a27f"), Code="CC", Description="Community college", Definition="Community college is specified as the type of agency that authorized the establishment or continuation of a charter school.", SortOrder=Convert.ToDecimal("6.00") },
            new RefCharterSchoolAuthorizerType { Id=Guid.Parse("163d2e79-09c6-4e6f-83db-96117781ac15"), Code="LEA", Description="Local education agency", Definition="Local education agency is specified as the type of agency that authorized the establishment or continuation of a charter school.", SortOrder=Convert.ToDecimal("7.00") },
            new RefCharterSchoolAuthorizerType { Id=Guid.Parse("661bce06-4e36-41fb-aa37-df5e519f6920"), Code="OTH", Description="Other", Definition="Other is specified as the type of agency that authorized the establishment or continuation of a charter school.", SortOrder=Convert.ToDecimal("7.00") },
            new RefCharterSchoolAuthorizerType { Id=Guid.Parse("7621df6c-7475-456f-b73a-2238542efba5"), Code="GOVTENT", Description="Non educational government entities", Definition="Non educational government entities is specified as the type of agency that authorized the establishment or continuation of a charter school.", SortOrder=Convert.ToDecimal("8.00") },
            new RefCharterSchoolAuthorizerType { Id=Guid.Parse("61a69c8e-4d7e-4045-85bb-0dfb11c16a77"), Code="NONPROFIT", Description="Not for profit organization", Definition="Not for profit organization is specified as the type of agency that authorized the establishment or continuation of a charter school.", SortOrder=Convert.ToDecimal("9.00") },
            new RefCharterSchoolAuthorizerType { Id=Guid.Parse("cb23daec-ce66-4915-b222-ee04ed8a3802"), Code="SEA", Description="State department of education", Definition="State department of education is specified as the type of agency that authorized the establishment or continuation of a charter school.", SortOrder=Convert.ToDecimal("10.00") },
        };

        /// <summary>
        /// The RefCharterSchoolAuthorizerType Pick List
         /// </summary>
        public static List<RefCharterSchoolAuthorizerType> RefCharterSchoolAuthorizerTypePickList = new List<RefCharterSchoolAuthorizerType>
        {
            new RefCharterSchoolAuthorizerType { Id=Guid.Parse("7dd9badd-2d80-4ac4-afb0-d3cdde73572e"), Code="SBE", Description="State board of education", SortOrder=Convert.ToDecimal("1.00") },
            new RefCharterSchoolAuthorizerType { Id=Guid.Parse("93f5085c-df1b-49b3-a66d-77ab8b4fd974"), Code="PCSB", Description="Public charter school board", SortOrder=Convert.ToDecimal("3.00") },
            new RefCharterSchoolAuthorizerType { Id=Guid.Parse("dcb6530e-a267-4de0-afe7-f03bf5af983e"), Code="UNI", Description="University", SortOrder=Convert.ToDecimal("5.00") },
            new RefCharterSchoolAuthorizerType { Id=Guid.Parse("4d7af452-a9c0-42e7-9a02-5abf2559a27f"), Code="CC", Description="Community college", SortOrder=Convert.ToDecimal("6.00") },
            new RefCharterSchoolAuthorizerType { Id=Guid.Parse("163d2e79-09c6-4e6f-83db-96117781ac15"), Code="LEA", Description="Local education agency", SortOrder=Convert.ToDecimal("7.00") },
            new RefCharterSchoolAuthorizerType { Id=Guid.Parse("661bce06-4e36-41fb-aa37-df5e519f6920"), Code="OTH", Description="Other", SortOrder=Convert.ToDecimal("7.00") },
            new RefCharterSchoolAuthorizerType { Id=Guid.Parse("7621df6c-7475-456f-b73a-2238542efba5"), Code="GOVTENT", Description="Non educational government entities", SortOrder=Convert.ToDecimal("8.00") },
            new RefCharterSchoolAuthorizerType { Id=Guid.Parse("61a69c8e-4d7e-4045-85bb-0dfb11c16a77"), Code="NONPROFIT", Description="Not for profit organization", SortOrder=Convert.ToDecimal("9.00") },
            new RefCharterSchoolAuthorizerType { Id=Guid.Parse("cb23daec-ce66-4915-b222-ee04ed8a3802"), Code="SEA", Description="State department of education", SortOrder=Convert.ToDecimal("10.00") },
       };
   }
}
