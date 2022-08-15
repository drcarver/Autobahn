//***************************************************************************
//* DomainName: Common Models Interfaces (used by both models and View Models
//* FileName:   IPersonDetail.cs
//***************************************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IPersonDetail Interface
     /// </summary>
    public partial interface IPersonDetail : IAutobahnBase
    {
        /// <summary>
        /// The year, month and day on which a person was born.
        /// </summary>
        System.DateTime? Birthdate { get; set; }

    }
}
