//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IncidentView.cs
//**********************************************************

using Autobahn.Common.ViewModels;

namespace Autobahn.Common.Views
{
     /// <summary>
     /// The IncidentView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class IncidentView : ContentPage
    {
        /// <summary>
        /// Inject the IIncidentViewModel as the data context for the view
        /// </summary>
        public IncidentView(IIncidentViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}
