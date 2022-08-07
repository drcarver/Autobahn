//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   RubricView.cs
//**********************************************************

using Autobahn.Assessment.ViewModels;

namespace Autobahn.Assessment.Views
{
     /// <summary>
     /// The RubricView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RubricView : ContentPage
    {
        /// <summary>
        /// Inject the IRubricViewModel as the data context for the view
        /// </summary>
        public RubricView(IRubricViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}
