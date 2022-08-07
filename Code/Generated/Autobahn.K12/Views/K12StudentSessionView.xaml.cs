//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   K12StudentSessionView.cs
//**********************************************************

using Autobahn.K12.ViewModels;

namespace Autobahn.K12.Views
{
     /// <summary>
     /// The K12StudentSessionView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class K12StudentSessionView : ContentPage
    {
        /// <summary>
        /// Inject the IK12StudentSessionViewModel as the data context for the view
        /// </summary>
        public K12StudentSessionView(IK12StudentSessionViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}
