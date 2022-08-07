//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IncidentPersonView.cs
//**********************************************************

using Autobahn.Common.ViewModels;

namespace Autobahn.Common.Views
{
     /// <summary>
     /// The IncidentPersonView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class IncidentPersonView : ContentPage
    {
        /// <summary>
        /// Inject the IIncidentPersonViewModel as the data context for the view
        /// </summary>
        public IncidentPersonView(IIncidentPersonViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}
