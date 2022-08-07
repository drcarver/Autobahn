//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   ProgramView.cs
//**********************************************************

using Autobahn.Common.ViewModels;

namespace Autobahn.Common.Views
{
     /// <summary>
     /// The ProgramView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProgramView : ContentPage
    {
        /// <summary>
        /// Inject the IProgramViewModel as the data context for the view
        /// </summary>
        public ProgramView(IProgramViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}
