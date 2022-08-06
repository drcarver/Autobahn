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
        public static List<RefPDAudienceType> RefPDAudienceTypeList = new List<RefPDAudienceType> =
        {
            new RefPDAudienceType { Id=Guid.Parse("5a41c4f2-ec8e-4b2e-8f7e-d1ca058eac49"), Code="The professional development activity is intended for delivery to an individual.", Description="Individual", Definition="", SortOrder=0 },
            new RefPDAudienceType { Id=Guid.Parse("f189199e-b06c-49d5-bced-ea73c9e2363f"), Code="The professional development activity is intended for delivery to a group.", Description="Group", Definition="", SortOrder=0 },
        };

        /// <summary>
        /// The RefPDAudienceType Pick List
         /// </summary>
        public static List<RefPDAudienceType> RefPDAudienceTypePickList = new List<RefPDAudienceType> =
        {
            new RefPDAudienceType { Id=Guid.Parse("5a41c4f2-ec8e-4b2e-8f7e-d1ca058eac49"), Code="The professional development activity is intended for delivery to an individual.", SortOrder=0 },
            new RefPDAudienceType { Id=Guid.Parse("f189199e-b06c-49d5-bced-ea73c9e2363f"), Code="The professional development activity is intended for delivery to a group.", SortOrder=0 },
       };
   }
}
