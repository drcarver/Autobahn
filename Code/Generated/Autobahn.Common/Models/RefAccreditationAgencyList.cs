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
        public static List<RefAccreditationAgency> RefAccreditationAgencyList = new List<RefAccreditationAgency> =
        {
            new RefAccreditationAgency { Id=Guid.Parse("7a717157-3ccb-4806-8ad0-a631b31016f7"), Code="National Association for the Education of Young Children", Description="NAEYC", Definition="", SortOrder=0 },
            new RefAccreditationAgency { Id=Guid.Parse("e19d6359-009e-4f0f-a1a0-cebe54931ab8"), Code="National Early Childhood Program Accreditation", Description="NECPA", Definition="", SortOrder=0 },
            new RefAccreditationAgency { Id=Guid.Parse("c7a2c2ed-e19c-4351-af57-a6fce75a0161"), Code="National Accreditation Commission", Description="NAC", Definition="", SortOrder=0 },
            new RefAccreditationAgency { Id=Guid.Parse("356768ea-dc12-423f-8dcc-dbb1fad88f20"), Code="Council on Accreditation", Description="COA", Definition="", SortOrder=0 },
            new RefAccreditationAgency { Id=Guid.Parse("569d6441-e9ab-47f7-a028-6336caf5589c"), Code="National Association for Family Child Care", Description="NAFCC", Definition="", SortOrder=0 },
            new RefAccreditationAgency { Id=Guid.Parse("6a61e947-0566-4f43-ae06-a1dbb2cdf838"), Code="Southern Association of Colleges and Schools", Description="SACS", Definition="", SortOrder=0 },
            new RefAccreditationAgency { Id=Guid.Parse("6ae62191-0a4a-44ad-b36e-114fd394faa4"), Code="Not accredited", Description="NotAccredited", Definition="", SortOrder=0 },
            new RefAccreditationAgency { Id=Guid.Parse("12c5dfc8-736b-4239-b14e-28751d6e8e93"), Code="Other Accreditation Agency", Description="Other", Definition="", SortOrder=0 },
        };

        /// <summary>
        /// The RefAccreditationAgency Pick List
         /// </summary>
        public static List<RefAccreditationAgency> RefAccreditationAgencyPickList = new List<RefAccreditationAgency> =
        {
            new RefAccreditationAgency { Id=Guid.Parse("7a717157-3ccb-4806-8ad0-a631b31016f7"), Code="National Association for the Education of Young Children", SortOrder=0 },
            new RefAccreditationAgency { Id=Guid.Parse("e19d6359-009e-4f0f-a1a0-cebe54931ab8"), Code="National Early Childhood Program Accreditation", SortOrder=0 },
            new RefAccreditationAgency { Id=Guid.Parse("c7a2c2ed-e19c-4351-af57-a6fce75a0161"), Code="National Accreditation Commission", SortOrder=0 },
            new RefAccreditationAgency { Id=Guid.Parse("356768ea-dc12-423f-8dcc-dbb1fad88f20"), Code="Council on Accreditation", SortOrder=0 },
            new RefAccreditationAgency { Id=Guid.Parse("569d6441-e9ab-47f7-a028-6336caf5589c"), Code="National Association for Family Child Care", SortOrder=0 },
            new RefAccreditationAgency { Id=Guid.Parse("6a61e947-0566-4f43-ae06-a1dbb2cdf838"), Code="Southern Association of Colleges and Schools", SortOrder=0 },
            new RefAccreditationAgency { Id=Guid.Parse("6ae62191-0a4a-44ad-b36e-114fd394faa4"), Code="Not accredited", SortOrder=0 },
            new RefAccreditationAgency { Id=Guid.Parse("12c5dfc8-736b-4239-b14e-28751d6e8e93"), Code="Other Accreditation Agency", SortOrder=0 },
       };
   }
}
