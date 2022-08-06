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
        public static List<RefLevelOfInstitution> RefLevelOfInstitutionList = new List<RefLevelOfInstitution> =
        {
            new RefLevelOfInstitution { Id=Guid.Parse("c95791b5-273e-451f-a37f-844e168cb527"), Code="The postsecondary institution's highest level of offering is a program of four or more years.", Description="FourYear", Definition="", SortOrder=0 },
            new RefLevelOfInstitution { Id=Guid.Parse("0fcdfbf8-6b70-4471-9df8-c2130842171f"), Code="The postsecondary institution's highest level of offering is a program of at least 2 but less than 4 years.", Description="TwoToFour", Definition="", SortOrder=0 },
            new RefLevelOfInstitution { Id=Guid.Parse("a7a800f2-2214-4c9a-a435-1f52adae7329"), Code="The postsecondary institution's highest level of offering is a program of less than 2 years (below associate).", Description="LessThanTwo", Definition="", SortOrder=0 },
        };

        /// <summary>
        /// The RefLevelOfInstitution Pick List
         /// </summary>
        public static List<RefLevelOfInstitution> RefLevelOfInstitutionPickList = new List<RefLevelOfInstitution> =
        {
            new RefLevelOfInstitution { Id=Guid.Parse("c95791b5-273e-451f-a37f-844e168cb527"), Code="The postsecondary institution's highest level of offering is a program of four or more years.", SortOrder=0 },
            new RefLevelOfInstitution { Id=Guid.Parse("0fcdfbf8-6b70-4471-9df8-c2130842171f"), Code="The postsecondary institution's highest level of offering is a program of at least 2 but less than 4 years.", SortOrder=0 },
            new RefLevelOfInstitution { Id=Guid.Parse("a7a800f2-2214-4c9a-a435-1f52adae7329"), Code="The postsecondary institution's highest level of offering is a program of less than 2 years (below associate).", SortOrder=0 },
       };
   }
}
