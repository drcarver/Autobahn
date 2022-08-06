//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefAdministrativeFundingControlList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefAdministrativeFundingControl Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefAdministrativeFundingControl"> List
         /// </summary>
        public static List<RefAdministrativeFundingControl> RefAdministrativeFundingControlList = new List<RefAdministrativeFundingControl>
        {
            new RefAdministrativeFundingControl { Id=Guid.Parse("0c082487-4baf-4cb0-af62-37205306c138"), Code="Public", Description="Public School", Definition="Public School is specified as the type of education institution as classified by its funding source.", SortOrder=Convert.ToDecimal("1.00") },
            new RefAdministrativeFundingControl { Id=Guid.Parse("2045ce77-00c3-429d-9e39-79f34904db79"), Code="Private", Description="Private School", Definition="Private School is specified as the type of education institution as classified by its funding source.", SortOrder=Convert.ToDecimal("2.00") },
            new RefAdministrativeFundingControl { Id=Guid.Parse("dc228d91-5974-4878-9c0a-2eff7a080d94"), Code="Other", Description="Other", Definition="Other is specified as the type of education institution as classified by its funding source.", SortOrder=Convert.ToDecimal("3.00") },
        };

        /// <summary>
        /// The RefAdministrativeFundingControl Pick List
         /// </summary>
        public static List<RefAdministrativeFundingControl> RefAdministrativeFundingControlPickList = new List<RefAdministrativeFundingControl>
        {
            new RefAdministrativeFundingControl { Id=Guid.Parse("0c082487-4baf-4cb0-af62-37205306c138"), Code="Public", Description="Public School", SortOrder=Convert.ToDecimal("1.00") },
            new RefAdministrativeFundingControl { Id=Guid.Parse("2045ce77-00c3-429d-9e39-79f34904db79"), Code="Private", Description="Private School", SortOrder=Convert.ToDecimal("2.00") },
            new RefAdministrativeFundingControl { Id=Guid.Parse("dc228d91-5974-4878-9c0a-2eff7a080d94"), Code="Other", Description="Other", SortOrder=Convert.ToDecimal("3.00") },
       };
   }
}
