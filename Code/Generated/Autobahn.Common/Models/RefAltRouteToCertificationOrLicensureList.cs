//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefAltRouteToCertificationOrLicensureList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefAltRouteToCertificationOrLicensure Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefAltRouteToCertificationOrLicensure"> List
         /// </summary>
        public static List<RefAltRouteToCertificationOrLicensure> RefAltRouteToCertificationOrLicensureList = new List<RefAltRouteToCertificationOrLicensure>
        {
            new RefAltRouteToCertificationOrLicensure { Id=Guid.Parse("12f626aa-069c-4410-a263-027ae9476618"), Code="Yes", Description="Yes", Definition="", SortOrder=Convert.ToDecimal("1.00") },
            new RefAltRouteToCertificationOrLicensure { Id=Guid.Parse("cc87cc65-54ee-4cd1-93fa-c50cfe995bd6"), Code="No", Description="No", Definition="", SortOrder=Convert.ToDecimal("2.00") },
            new RefAltRouteToCertificationOrLicensure { Id=Guid.Parse("4210dc98-6011-479d-a51b-cf73231037eb"), Code="NA", Description="Not applicable", Definition="", SortOrder=Convert.ToDecimal("3.00") },
        };

        /// <summary>
        /// The RefAltRouteToCertificationOrLicensure Pick List
         /// </summary>
        public static List<RefAltRouteToCertificationOrLicensure> RefAltRouteToCertificationOrLicensurePickList = new List<RefAltRouteToCertificationOrLicensure>
        {
            new RefAltRouteToCertificationOrLicensure { Id=Guid.Parse("12f626aa-069c-4410-a263-027ae9476618"), Code="Yes", Description="Yes", SortOrder=Convert.ToDecimal("1.00") },
            new RefAltRouteToCertificationOrLicensure { Id=Guid.Parse("cc87cc65-54ee-4cd1-93fa-c50cfe995bd6"), Code="No", Description="No", SortOrder=Convert.ToDecimal("2.00") },
            new RefAltRouteToCertificationOrLicensure { Id=Guid.Parse("4210dc98-6011-479d-a51b-cf73231037eb"), Code="NA", Description="Not applicable", SortOrder=Convert.ToDecimal("3.00") },
       };
   }
}
