//**********************************************************
//* DomainName: Authentication and Authorization
//* FileName:   IncidentView.cs
//**********************************************************

namespace Autobahn.Authorization.Views
{
     /// <summary>
     /// The IncidentView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class IncidentView : ContentPage
    {
        /// <summary>
        /// Inject the IIncident View Model as the data context for the view
        /// </summary>
        public IncidentView(Interfaces.IIncident vm)
        {
            BindingContext  = vm;
        }
    }
}
