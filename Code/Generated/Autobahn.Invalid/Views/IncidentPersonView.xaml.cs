//**********************************************************
//* DomainName: Invalid or Unreferenced Models
//* FileName:   IncidentPersonView.cs
//**********************************************************

namespace Autobahn.Invalid.Views
{
     /// <summary>
     /// The IncidentPersonView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class IncidentPersonView : ContentPage
    {
        /// <summary>
        /// Inject the IIncidentPerson View Model as the data context for the view
        /// </summary>
        public IncidentPersonView(Interfaces.IIncidentPerson vm)
        {
            BindingContext  = vm;
        }
    }
}