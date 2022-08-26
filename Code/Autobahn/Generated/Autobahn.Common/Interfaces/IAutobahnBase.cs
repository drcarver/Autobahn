//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IAutobahnBase.cs
//**********************************************************

using System.ComponentModel;

namespace Autobahn.Common.Interfaces;

public interface IAutobahnBase : IChangeTracking
{
    /// <summary>
    /// True if the model is new and unsaved
    /// </summary>
    public bool IsNew { get; set; }
    
    /// <summary>
    /// Is it a deleted model?
    /// </summary>
    public bool IsDeleted { get; set; }

    /// <summary>
    /// THe Id of the ViewModel
    /// </summary>
    public Guid Id { get; set; }
}