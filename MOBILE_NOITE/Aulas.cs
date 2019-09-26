using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace MOBILE_NOITE
{
    [Activity(Label = "Aulas",MainLauncher = true)]
    public class Aulas : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.Aulas);

            var btComplete = FindViewById<Button>(Resource.Id.AutoComplet);

            btComplete.Click += (sende,args) => {
                // fazr um link (Chamar tela)
                StartActivity(typeof(ViewAutoCompleteTextView));
            };
        }
    }
}