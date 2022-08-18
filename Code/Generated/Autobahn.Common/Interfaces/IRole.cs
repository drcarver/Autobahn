//***************************************************************************
//* DomainName: Common Models Interfaces (used by both models and View Models
//* FileName:   IRole.cs
//***************************************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IRole Interface
     /// </summary>
    public partial interface IRole : IAutobahnBase
    {
        System.String Name { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefRole"/> model
        /// </summary>
        Guid? RefRoleId { get; set; }

    }
}
