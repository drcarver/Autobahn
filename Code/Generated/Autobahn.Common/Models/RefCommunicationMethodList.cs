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
        public static List<RefCommunicationMethod> RefCommunicationMethodList = new List<RefCommunicationMethod> =
        {
            new RefCommunicationMethod { Id=Guid.Parse("c20d028d-f967-41bc-80e3-98bee488050a"), Code="The types of communication methods with parents include in-person communication.", Description="InPerson", Definition="", SortOrder=0 },
            new RefCommunicationMethod { Id=Guid.Parse("4dfada7f-b6ad-401d-a316-1600c0473a9c"), Code="The types of communication methods with parents include Phone communications.", Description="Phone", Definition="", SortOrder=0 },
            new RefCommunicationMethod { Id=Guid.Parse("0277ad7d-2a60-44a0-bf38-ff0e379dcbd7"), Code="The types of communication methods with parents include Website.", Description="Website", Definition="", SortOrder=0 },
            new RefCommunicationMethod { Id=Guid.Parse("aeaa3916-94ed-44ae-8f0b-5a884ab77698"), Code="The types of communication methods with parents include Email.", Description="Email", Definition="", SortOrder=0 },
            new RefCommunicationMethod { Id=Guid.Parse("2495c784-03c6-4a21-891a-2af77944a39d"), Code="The types of communication methods with parents include Newsletter.", Description="Newsletter", Definition="", SortOrder=0 },
            new RefCommunicationMethod { Id=Guid.Parse("ee84aa05-8411-4631-b7e9-3701be1f9179"), Code="The types of communication methods with parents include Bulletin board.", Description="BulletinBoard", Definition="", SortOrder=0 },
            new RefCommunicationMethod { Id=Guid.Parse("0b167211-0fdf-460d-94bd-da21a1d74f3a"), Code="The types of communication methods with parents include Home visit(s).", Description="HomeVisit", Definition="", SortOrder=0 },
            new RefCommunicationMethod { Id=Guid.Parse("dc17f5ca-d54f-4207-8836-bc9e82bed87a"), Code="The types of communication methods with parents include Fax.", Description="Fax", Definition="", SortOrder=0 },
            new RefCommunicationMethod { Id=Guid.Parse("29b3cb44-c66e-461c-b7f1-6c4c049000a1"), Code="The types of communication methods with parents include Other.", Description="Other", Definition="", SortOrder=0 },
        };

        /// <summary>
        /// The RefCommunicationMethod Pick List
         /// </summary>
        public static List<RefCommunicationMethod> RefCommunicationMethodPickList = new List<RefCommunicationMethod> =
        {
            new RefCommunicationMethod { Id=Guid.Parse("c20d028d-f967-41bc-80e3-98bee488050a"), Code="The types of communication methods with parents include in-person communication.", SortOrder=0 },
            new RefCommunicationMethod { Id=Guid.Parse("4dfada7f-b6ad-401d-a316-1600c0473a9c"), Code="The types of communication methods with parents include Phone communications.", SortOrder=0 },
            new RefCommunicationMethod { Id=Guid.Parse("0277ad7d-2a60-44a0-bf38-ff0e379dcbd7"), Code="The types of communication methods with parents include Website.", SortOrder=0 },
            new RefCommunicationMethod { Id=Guid.Parse("aeaa3916-94ed-44ae-8f0b-5a884ab77698"), Code="The types of communication methods with parents include Email.", SortOrder=0 },
            new RefCommunicationMethod { Id=Guid.Parse("2495c784-03c6-4a21-891a-2af77944a39d"), Code="The types of communication methods with parents include Newsletter.", SortOrder=0 },
            new RefCommunicationMethod { Id=Guid.Parse("ee84aa05-8411-4631-b7e9-3701be1f9179"), Code="The types of communication methods with parents include Bulletin board.", SortOrder=0 },
            new RefCommunicationMethod { Id=Guid.Parse("0b167211-0fdf-460d-94bd-da21a1d74f3a"), Code="The types of communication methods with parents include Home visit(s).", SortOrder=0 },
            new RefCommunicationMethod { Id=Guid.Parse("dc17f5ca-d54f-4207-8836-bc9e82bed87a"), Code="The types of communication methods with parents include Fax.", SortOrder=0 },
            new RefCommunicationMethod { Id=Guid.Parse("29b3cb44-c66e-461c-b7f1-6c4c049000a1"), Code="The types of communication methods with parents include Other.", SortOrder=0 },
       };
   }
}
