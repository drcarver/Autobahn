//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IAutobahnBase.cs
//**********************************************************

using System.ComponentModel;

namespace Autobahn.Interfaces.Common;

public interface IAutobahnBase : IChangeTracking
{
    /// <summary>
    /// True if the model is new and unsaved
    /// </summary>
    bool IsNew { get; set; }

    /// <summary>
    /// Is it a deleted model?
    /// </summary>
    bool IsDeleted { get; set; }

    /// <summary>
    /// The Id of the ViewModel
    /// </summary>
     Guid Id { get; set; }
}