//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefLevelOfInstitutionList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefLevelOfInstitution Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefLevelOfInstitution"> List
         /// </summary>
        public static List<RefLevelOfInstitution> RefLevelOfInstitutionList = new List<RefLevelOfInstitution>
        {
            new RefLevelOfInstitution { Id=Guid.Parse("8a381255-a49b-40cc-afcb-9697cbdb5905"), Code="FourYear", Description="Four or more years", Definition="The postsecondary institution's highest level of offering is a program of four or more years.", SortOrder=Convert.ToDecimal("1.00") },
            new RefLevelOfInstitution { Id=Guid.Parse("45049f50-131c-4c6a-a0c3-6d51a6e8ebc4"), Code="TwoToFour", Description="At least 2 but less than 4 years", Definition="The postsecondary institution's highest level of offering is a program of at least 2 but less than 4 years.", SortOrder=Convert.ToDecimal("2.00") },
            new RefLevelOfInstitution { Id=Guid.Parse("bd5e90ad-aece-44a8-a61f-223df5c9c84f"), Code="LessThanTwo", Description="Less than 2 years (below associate)", Definition="The postsecondary institution's highest level of offering is a program of less than 2 years (below associate).", SortOrder=Convert.ToDecimal("3.00") },
        };

        /// <summary>
        /// The RefLevelOfInstitution Pick List
         /// </summary>
        public static List<RefLevelOfInstitution> RefLevelOfInstitutionPickList = new List<RefLevelOfInstitution>
        {
            new RefLevelOfInstitution { Id=Guid.Parse("8a381255-a49b-40cc-afcb-9697cbdb5905"), Code="FourYear", Description="Four or more years", SortOrder=Convert.ToDecimal("1.00") },
            new RefLevelOfInstitution { Id=Guid.Parse("45049f50-131c-4c6a-a0c3-6d51a6e8ebc4"), Code="TwoToFour", Description="At least 2 but less than 4 years", SortOrder=Convert.ToDecimal("2.00") },
            new RefLevelOfInstitution { Id=Guid.Parse("bd5e90ad-aece-44a8-a61f-223df5c9c84f"), Code="LessThanTwo", Description="Less than 2 years (below associate)", SortOrder=Convert.ToDecimal("3.00") },
       };
   }
}
