//**********************************************************
//* DomainName: Invalid or Unreferenced Models
//* FileName:   ProgramView.cs
//**********************************************************

namespace Autobahn.Invalid.Views
{
     /// <summary>
     /// The ProgramView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProgramView : ContentPage
    {
        /// <summary>
        /// Inject the IProgram View Model as the data context for the view
        /// </summary>
        public ProgramView(Interfaces.IProgram vm)
        {
            BindingContext  = vm;
        }
    }
}
