//***************************************************************************
//* DomainName: Learning Resources Interfaces (used by both models and View Models
//* FileName:   ILearningResource.cs
//* Name:       Learning Resource URL
//* Definition: The Uniform Resource Locator where the resource may be accessed, or a proxy for the resource, such as an information page for a commercially available resource.
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.LearningResources.Interfaces
{
     /// <summary>
     /// The Uniform Resource Locator where the resource may be accessed, or a proxy for the resource, such as an information page for a commercially available resource.
     /// </summary>
    public partial interface ILearningResource : IAutobahnBase
    {
    }
}
