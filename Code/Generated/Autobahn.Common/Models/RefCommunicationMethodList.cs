//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefCommunicationMethodList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefCommunicationMethod Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefCommunicationMethod"> List
         /// </summary>
        public static List<RefCommunicationMethod> RefCommunicationMethodList = new List<RefCommunicationMethod>
        {
            new RefCommunicationMethod { Id=Guid.Parse("ebdec9cc-97bc-40bb-9daf-05d663d68fba"), Code="InPerson", Description="In-person", Definition="The types of communication methods with parents include in-person communication.", SortOrder=Convert.ToDecimal("0.00") },
            new RefCommunicationMethod { Id=Guid.Parse("1eafbdc5-e585-4bd0-801d-5440840935f8"), Code="Phone", Description="Phone", Definition="The types of communication methods with parents include Phone communications.", SortOrder=Convert.ToDecimal("1.00") },
            new RefCommunicationMethod { Id=Guid.Parse("c13baea9-3af4-489c-b2f9-6f8d337f38d9"), Code="Website", Description="Website", Definition="The types of communication methods with parents include Website.", SortOrder=Convert.ToDecimal("2.00") },
            new RefCommunicationMethod { Id=Guid.Parse("262bf2d0-d307-4c0f-9fc2-8691dff95daa"), Code="Email", Description="Email", Definition="The types of communication methods with parents include Email.", SortOrder=Convert.ToDecimal("3.00") },
            new RefCommunicationMethod { Id=Guid.Parse("7e7d13e1-d4ff-4915-b4f9-48beb6453d3c"), Code="Newsletter", Description="Newsletter", Definition="The types of communication methods with parents include Newsletter.", SortOrder=Convert.ToDecimal("4.00") },
            new RefCommunicationMethod { Id=Guid.Parse("0d632850-6a94-4d10-a568-539a80338f7a"), Code="BulletinBoard", Description="Bulletin board", Definition="The types of communication methods with parents include Bulletin board.", SortOrder=Convert.ToDecimal("5.00") },
            new RefCommunicationMethod { Id=Guid.Parse("ec6c34e1-30a1-439d-98f2-7f3ea1cfdce3"), Code="HomeVisit", Description="Home visit", Definition="The types of communication methods with parents include Home visit(s).", SortOrder=Convert.ToDecimal("10.00") },
            new RefCommunicationMethod { Id=Guid.Parse("343cb586-2386-427f-8f05-5b65e5aa242f"), Code="Fax", Description="Fax", Definition="The types of communication methods with parents include Fax.", SortOrder=Convert.ToDecimal("12.00") },
            new RefCommunicationMethod { Id=Guid.Parse("9ccca5e2-b3fe-4e94-97a1-e804e8cea814"), Code="Other", Description="Other", Definition="The types of communication methods with parents include Other.", SortOrder=Convert.ToDecimal("14.00") },
        };

        /// <summary>
        /// The RefCommunicationMethod Pick List
         /// </summary>
        public static List<RefCommunicationMethod> RefCommunicationMethodPickList = new List<RefCommunicationMethod>
        {
            new RefCommunicationMethod { Id=Guid.Parse("ebdec9cc-97bc-40bb-9daf-05d663d68fba"), Code="InPerson", Description="In-person", SortOrder=Convert.ToDecimal("0.00") },
            new RefCommunicationMethod { Id=Guid.Parse("1eafbdc5-e585-4bd0-801d-5440840935f8"), Code="Phone", Description="Phone", SortOrder=Convert.ToDecimal("1.00") },
            new RefCommunicationMethod { Id=Guid.Parse("c13baea9-3af4-489c-b2f9-6f8d337f38d9"), Code="Website", Description="Website", SortOrder=Convert.ToDecimal("2.00") },
            new RefCommunicationMethod { Id=Guid.Parse("262bf2d0-d307-4c0f-9fc2-8691dff95daa"), Code="Email", Description="Email", SortOrder=Convert.ToDecimal("3.00") },
            new RefCommunicationMethod { Id=Guid.Parse("7e7d13e1-d4ff-4915-b4f9-48beb6453d3c"), Code="Newsletter", Description="Newsletter", SortOrder=Convert.ToDecimal("4.00") },
            new RefCommunicationMethod { Id=Guid.Parse("0d632850-6a94-4d10-a568-539a80338f7a"), Code="BulletinBoard", Description="Bulletin board", SortOrder=Convert.ToDecimal("5.00") },
            new RefCommunicationMethod { Id=Guid.Parse("ec6c34e1-30a1-439d-98f2-7f3ea1cfdce3"), Code="HomeVisit", Description="Home visit", SortOrder=Convert.ToDecimal("10.00") },
            new RefCommunicationMethod { Id=Guid.Parse("343cb586-2386-427f-8f05-5b65e5aa242f"), Code="Fax", Description="Fax", SortOrder=Convert.ToDecimal("12.00") },
            new RefCommunicationMethod { Id=Guid.Parse("9ccca5e2-b3fe-4e94-97a1-e804e8cea814"), Code="Other", Description="Other", SortOrder=Convert.ToDecimal("14.00") },
       };
   }
}
