//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefPDActivityLevelList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefPDActivityLevel Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefPDActivityLevel"> List
         /// </summary>
        public static List<RefPDActivityLevel> RefPDActivityLevelList = new List<RefPDActivityLevel>
        {
            new RefPDActivityLevel { Id=Guid.Parse("c5e1dc30-1cc5-41c6-920f-65822b287b1f"), Code="Beginner", Description="Beginner", Definition="The level of expertise for the professional development activity is beginner.", SortOrder=Convert.ToDecimal("2.00") },
            new RefPDActivityLevel { Id=Guid.Parse("d40dde97-d241-4b3e-a53b-d527ce9a4f6f"), Code="Intermediate", Description="Intermediate", Definition="The level of expertise for the professional development activity is intermediate.", SortOrder=Convert.ToDecimal("4.00") },
            new RefPDActivityLevel { Id=Guid.Parse("634e6574-90fc-48e5-a400-df7a407214da"), Code="Advanced", Description="Advanced", Definition="The level of expertise for the professional development activity is advanced.", SortOrder=Convert.ToDecimal("6.00") },
        };

        /// <summary>
        /// The RefPDActivityLevel Pick List
         /// </summary>
        public static List<RefPDActivityLevel> RefPDActivityLevelPickList = new List<RefPDActivityLevel>
        {
            new RefPDActivityLevel { Id=Guid.Parse("c5e1dc30-1cc5-41c6-920f-65822b287b1f"), Code="Beginner", Description="Beginner", SortOrder=Convert.ToDecimal("2.00") },
            new RefPDActivityLevel { Id=Guid.Parse("d40dde97-d241-4b3e-a53b-d527ce9a4f6f"), Code="Intermediate", Description="Intermediate", SortOrder=Convert.ToDecimal("4.00") },
            new RefPDActivityLevel { Id=Guid.Parse("634e6574-90fc-48e5-a400-df7a407214da"), Code="Advanced", Description="Advanced", SortOrder=Convert.ToDecimal("6.00") },
       };
   }
}
