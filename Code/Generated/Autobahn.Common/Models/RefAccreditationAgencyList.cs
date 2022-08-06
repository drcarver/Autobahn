//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefAccreditationAgencyList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefAccreditationAgency Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefAccreditationAgency"> List
         /// </summary>
        public static List<RefAccreditationAgency> RefAccreditationAgencyList = new List<RefAccreditationAgency>
        {
            new RefAccreditationAgency { Id=Guid.Parse("f79b6218-bb07-443b-ae00-d1affab8afaa"), Code="NAEYC", Description="National Association for the Education of Young Children", Definition="National Association for the Education of Young Children", SortOrder=Convert.ToDecimal("1.00") },
            new RefAccreditationAgency { Id=Guid.Parse("edda1e1c-571a-401d-97fe-09df07471640"), Code="NECPA", Description="National Early Childhood Program Accreditation", Definition="National Early Childhood Program Accreditation", SortOrder=Convert.ToDecimal("2.00") },
            new RefAccreditationAgency { Id=Guid.Parse("54faa7c2-10a6-4737-bb96-42d87cfa93ce"), Code="NAC", Description="National Accreditation Commission", Definition="National Accreditation Commission", SortOrder=Convert.ToDecimal("3.00") },
            new RefAccreditationAgency { Id=Guid.Parse("e298027f-99b9-4f6a-adcc-307f0da1bd86"), Code="COA", Description="Council on Accreditation", Definition="Council on Accreditation", SortOrder=Convert.ToDecimal("4.00") },
            new RefAccreditationAgency { Id=Guid.Parse("45ade2bc-83ab-48e8-a29f-2e288342f4a7"), Code="NAFCC", Description="National Association for Family Child Care", Definition="National Association for Family Child Care", SortOrder=Convert.ToDecimal("5.00") },
            new RefAccreditationAgency { Id=Guid.Parse("7a47ce28-714c-49af-8d90-6c4bc3682fca"), Code="SACS", Description="Southern Association of Colleges and Schools", Definition="Southern Association of Colleges and Schools", SortOrder=Convert.ToDecimal("6.00") },
            new RefAccreditationAgency { Id=Guid.Parse("ff1cf1f9-d221-45d9-a5f1-1b4cb099c35c"), Code="NotAccredited", Description="Not accredited", Definition="Not accredited", SortOrder=Convert.ToDecimal("7.00") },
            new RefAccreditationAgency { Id=Guid.Parse("67133be3-f342-4524-8459-46f8d4480de5"), Code="Other", Description="Other Accreditation Agency", Definition="Other Accreditation Agency", SortOrder=Convert.ToDecimal("10.00") },
        };

        /// <summary>
        /// The RefAccreditationAgency Pick List
         /// </summary>
        public static List<RefAccreditationAgency> RefAccreditationAgencyPickList = new List<RefAccreditationAgency>
        {
            new RefAccreditationAgency { Id=Guid.Parse("f79b6218-bb07-443b-ae00-d1affab8afaa"), Code="NAEYC", Description="National Association for the Education of Young Children", SortOrder=Convert.ToDecimal("1.00") },
            new RefAccreditationAgency { Id=Guid.Parse("edda1e1c-571a-401d-97fe-09df07471640"), Code="NECPA", Description="National Early Childhood Program Accreditation", SortOrder=Convert.ToDecimal("2.00") },
            new RefAccreditationAgency { Id=Guid.Parse("54faa7c2-10a6-4737-bb96-42d87cfa93ce"), Code="NAC", Description="National Accreditation Commission", SortOrder=Convert.ToDecimal("3.00") },
            new RefAccreditationAgency { Id=Guid.Parse("e298027f-99b9-4f6a-adcc-307f0da1bd86"), Code="COA", Description="Council on Accreditation", SortOrder=Convert.ToDecimal("4.00") },
            new RefAccreditationAgency { Id=Guid.Parse("45ade2bc-83ab-48e8-a29f-2e288342f4a7"), Code="NAFCC", Description="National Association for Family Child Care", SortOrder=Convert.ToDecimal("5.00") },
            new RefAccreditationAgency { Id=Guid.Parse("7a47ce28-714c-49af-8d90-6c4bc3682fca"), Code="SACS", Description="Southern Association of Colleges and Schools", SortOrder=Convert.ToDecimal("6.00") },
            new RefAccreditationAgency { Id=Guid.Parse("ff1cf1f9-d221-45d9-a5f1-1b4cb099c35c"), Code="NotAccredited", Description="Not accredited", SortOrder=Convert.ToDecimal("7.00") },
            new RefAccreditationAgency { Id=Guid.Parse("67133be3-f342-4524-8459-46f8d4480de5"), Code="Other", Description="Other Accreditation Agency", SortOrder=Convert.ToDecimal("10.00") },
       };
   }
}
