//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefPDAudienceTypeList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefPDAudienceType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefPDAudienceType"> List
         /// </summary>
        public static List<RefPDAudienceType> RefPDAudienceTypeList = new List<RefPDAudienceType>
        {
            new RefPDAudienceType { Id=Guid.Parse("62cf883b-8eb1-4b7f-bb28-725d1d1f3dce"), Code="Individual", Description="Individual", Definition="The professional development activity is intended for delivery to an individual.", SortOrder=Convert.ToDecimal("1.00") },
            new RefPDAudienceType { Id=Guid.Parse("7ca1ae10-5a89-41d8-848b-aa1abac267e1"), Code="Group", Description="Group", Definition="The professional development activity is intended for delivery to a group.", SortOrder=Convert.ToDecimal("2.00") },
        };

        /// <summary>
        /// The RefPDAudienceType Pick List
         /// </summary>
        public static List<RefPDAudienceType> RefPDAudienceTypePickList = new List<RefPDAudienceType>
        {
            new RefPDAudienceType { Id=Guid.Parse("62cf883b-8eb1-4b7f-bb28-725d1d1f3dce"), Code="Individual", Description="Individual", SortOrder=Convert.ToDecimal("1.00") },
            new RefPDAudienceType { Id=Guid.Parse("7ca1ae10-5a89-41d8-848b-aa1abac267e1"), Code="Group", Description="Group", SortOrder=Convert.ToDecimal("2.00") },
       };
   }
}
