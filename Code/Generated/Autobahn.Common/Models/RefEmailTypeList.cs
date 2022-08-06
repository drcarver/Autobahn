//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefEmailTypeList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefEmailType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefEmailType"> List
         /// </summary>
        public static List<RefEmailType> RefEmailTypeList = new List<RefEmailType>
        {
            new RefEmailType { Id=Guid.Parse("c8dc40e3-5f8a-41cf-9095-8fca8be0e29f"), Code="Home", Description="Home/personal", Definition="Home/personal is the type of electronic mail (e-mail) address listed for a person or organization.", SortOrder=Convert.ToDecimal("1.00") },
            new RefEmailType { Id=Guid.Parse("5aed9278-38e8-47e4-a2b7-429fcbdf2107"), Code="Work", Description="Work", Definition="Work is the type of electronic mail (e-mail) address listed for a person or organization.", SortOrder=Convert.ToDecimal("2.00") },
            new RefEmailType { Id=Guid.Parse("a7cbbcdc-8374-4eec-b53b-025e9175d6c6"), Code="Organizational", Description="Organizational (school) address", Definition="Organizational (school) address is the type of electronic mail (e-mail) address listed for a person or organization.", SortOrder=Convert.ToDecimal("3.00") },
            new RefEmailType { Id=Guid.Parse("0f6f3162-7dc5-42cb-9e1c-921b528c8ea6"), Code="Other", Description="Other", Definition="Other is the type of electronic mail (e-mail) address listed for a person or organization.", SortOrder=Convert.ToDecimal("4.00") },
        };

        /// <summary>
        /// The RefEmailType Pick List
         /// </summary>
        public static List<RefEmailType> RefEmailTypePickList = new List<RefEmailType>
        {
            new RefEmailType { Id=Guid.Parse("c8dc40e3-5f8a-41cf-9095-8fca8be0e29f"), Code="Home", Description="Home/personal", SortOrder=Convert.ToDecimal("1.00") },
            new RefEmailType { Id=Guid.Parse("5aed9278-38e8-47e4-a2b7-429fcbdf2107"), Code="Work", Description="Work", SortOrder=Convert.ToDecimal("2.00") },
            new RefEmailType { Id=Guid.Parse("a7cbbcdc-8374-4eec-b53b-025e9175d6c6"), Code="Organizational", Description="Organizational (school) address", SortOrder=Convert.ToDecimal("3.00") },
            new RefEmailType { Id=Guid.Parse("0f6f3162-7dc5-42cb-9e1c-921b528c8ea6"), Code="Other", Description="Other", SortOrder=Convert.ToDecimal("4.00") },
       };
   }
}
