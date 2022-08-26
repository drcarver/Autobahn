//***************************************************************************
//* DomainName: Postsecondary (PS) Interfaces (used by both models and View Models
//* FileName:   IPsStudentEnrollment.cs
//* Name:       Degree or Certificate Seeking Student
//* Definition: Person is enrolled in courses for credit and recognized by the institution as seeking a degree, certificate, or other formal award. High school students also enrolled in postsecondary courses for credit are not considered degree/certificate-seeking.
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Postsecondary.Interfaces
{
     /// <summary>
     /// Person is enrolled in courses for credit and recognized by the institution as seeking a degree, certificate, or other formal award. High school students also enrolled in postsecondary courses for credit are not considered degree/certificate-seeking.
     /// </summary>
    public partial interface IPsStudentEnrollment : IAutobahnBase
    {
    }
}
