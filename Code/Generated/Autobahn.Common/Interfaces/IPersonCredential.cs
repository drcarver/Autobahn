//***************************************************************************
//* DomainName: Common Models Interfaces (used by both models and View Models
//* FileName:   IPersonCredential.cs
//***************************************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IPersonCredential Interface
     /// </summary>
    public partial interface IPersonCredential : IAutobahnBase
    {
        /// <summary>
        /// The year, month, and day on which the child is no longer eligible for the  Program.
        /// </summary>
        System.DateTime? ExpirationDate { get; set; }

    }
}
