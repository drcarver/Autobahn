//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   RefStudentEnrollmentAccessTypeList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.K12.Models
{
     /// <summary>
     /// The list of RefStudentEnrollmentAccessType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefStudentEnrollmentAccessType"> List
         /// </summary>
        public static List<RefStudentEnrollmentAccessType> RefStudentEnrollmentAccessTypeList = new List<RefStudentEnrollmentAccessType> =
        {
            new RefStudentEnrollmentAccessType { Id=Guid.Parse("8b83b855-f3ec-4b4d-801b-cad3e9d05eb5"), Code="Feeder school rights is specified as the designation of how students secure access to age appropriate public schools, or publicly funded charter or private schools.", Description="75027", Definition="", SortOrder=0 },
            new RefStudentEnrollmentAccessType { Id=Guid.Parse("1a22314c-f9b9-45e7-b4d5-e71b8fa60fbb"), Code="Geographic right is specified as the designation of how students secure access to age appropriate public schools, or publicly funded charter or private schools.", Description="75028", Definition="", SortOrder=0 },
            new RefStudentEnrollmentAccessType { Id=Guid.Parse("5781fea2-25e6-40c7-a6a6-d95594563a3a"), Code="Lottery is specified as the designation of how students secure access to age appropriate public schools, or publicly funded charter or private schools.", Description="75029", Definition="", SortOrder=0 },
            new RefStudentEnrollmentAccessType { Id=Guid.Parse("33f51b70-d222-4566-a9c6-6b558bb05bf3"), Code="Policy that modifies student assignment based on preferences associated with such things as walk distances, racial or ethnic diversity, and family risk factors.", Description="75030", Definition="", SortOrder=0 },
            new RefStudentEnrollmentAccessType { Id=Guid.Parse("ad7b63c5-e756-4f24-beec-ac19703df826"), Code="Selective admissions is specified as the designation of how students secure access to age appropriate public schools, or publicly funded charter or private schools.", Description="75031", Definition="", SortOrder=0 },
        };

        /// <summary>
        /// The RefStudentEnrollmentAccessType Pick List
         /// </summary>
        public static List<RefStudentEnrollmentAccessType> RefStudentEnrollmentAccessTypePickList = new List<RefStudentEnrollmentAccessType> =
        {
            new RefStudentEnrollmentAccessType { Id=Guid.Parse("8b83b855-f3ec-4b4d-801b-cad3e9d05eb5"), Code="Feeder school rights is specified as the designation of how students secure access to age appropriate public schools, or publicly funded charter or private schools.", SortOrder=0 },
            new RefStudentEnrollmentAccessType { Id=Guid.Parse("1a22314c-f9b9-45e7-b4d5-e71b8fa60fbb"), Code="Geographic right is specified as the designation of how students secure access to age appropriate public schools, or publicly funded charter or private schools.", SortOrder=0 },
            new RefStudentEnrollmentAccessType { Id=Guid.Parse("5781fea2-25e6-40c7-a6a6-d95594563a3a"), Code="Lottery is specified as the designation of how students secure access to age appropriate public schools, or publicly funded charter or private schools.", SortOrder=0 },
            new RefStudentEnrollmentAccessType { Id=Guid.Parse("33f51b70-d222-4566-a9c6-6b558bb05bf3"), Code="Policy that modifies student assignment based on preferences associated with such things as walk distances, racial or ethnic diversity, and family risk factors.", SortOrder=0 },
            new RefStudentEnrollmentAccessType { Id=Guid.Parse("ad7b63c5-e756-4f24-beec-ac19703df826"), Code="Selective admissions is specified as the designation of how students secure access to age appropriate public schools, or publicly funded charter or private schools.", SortOrder=0 },
       };
   }
}
