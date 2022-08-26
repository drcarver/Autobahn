//***************************************************************************
//* DomainName: Postsecondary (PS) Interfaces (used by both models and View Models
//* FileName:   IPsStudentApplication.cs
//* Name:       High School Student Class Rank
//* Definition: The academic rank of a student in relation to his or her high school graduating class (e.g., 1, 2, 3) based on high school GPA.
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Postsecondary.Interfaces
{
     /// <summary>
     /// The academic rank of a student in relation to his or her high school graduating class (e.g., 1, 2, 3) based on high school GPA.
     /// </summary>
    public partial interface IPsStudentApplication : IAutobahnBase
    {
    }
}
