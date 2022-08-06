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
        public static List<RefAdministrativeFundingControl> RefAdministrativeFundingControlList = new List<RefAdministrativeFundingControl> =
        {
            new RefAdministrativeFundingControl { Id=Guid.Parse("42a592dd-8480-40de-a781-79cb66d8e9c5"), Code="Public School is specified as the type of education institution as classified by its funding source.", Description="Public", Definition="", SortOrder=0 },
            new RefAdministrativeFundingControl { Id=Guid.Parse("82dcf749-d31b-46f5-9010-d373d08f944f"), Code="Private School is specified as the type of education institution as classified by its funding source.", Description="Private", Definition="", SortOrder=0 },
            new RefAdministrativeFundingControl { Id=Guid.Parse("5475fe3c-722e-4a9e-b72a-52fa89635193"), Code="Other is specified as the type of education institution as classified by its funding source.", Description="Other", Definition="", SortOrder=0 },
        };

        /// <summary>
        /// The RefAdministrativeFundingControl Pick List
         /// </summary>
        public static List<RefAdministrativeFundingControl> RefAdministrativeFundingControlPickList = new List<RefAdministrativeFundingControl> =
        {
            new RefAdministrativeFundingControl { Id=Guid.Parse("42a592dd-8480-40de-a781-79cb66d8e9c5"), Code="Public School is specified as the type of education institution as classified by its funding source.", SortOrder=0 },
            new RefAdministrativeFundingControl { Id=Guid.Parse("82dcf749-d31b-46f5-9010-d373d08f944f"), Code="Private School is specified as the type of education institution as classified by its funding source.", SortOrder=0 },
            new RefAdministrativeFundingControl { Id=Guid.Parse("5475fe3c-722e-4a9e-b72a-52fa89635193"), Code="Other is specified as the type of education institution as classified by its funding source.", SortOrder=0 },
       };
   }
}
