//**********************************************************
//* DomainName: Autobahn.Education.Interfaces
//* FileName:   IViewModelBase.cs
//**********************************************************

using System.ComponentModel;

namespace Autobahn.Education.Interfaces.Common;

public interface IViewModelBase : IAutobahnBase
{
    /// <summary>
    /// Property changed handler
    /// </summary>
    event PropertyChangedEventHandler PropertyChanged;

    /// <summary>
    /// True if the view model is busy (usually when being saved ir loaded).
    /// </summary>
    bool IsBusy { get; set; }
}