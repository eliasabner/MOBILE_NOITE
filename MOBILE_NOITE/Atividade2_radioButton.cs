using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Graphics.Drawables;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace MOBILE_NOITE
{
    [Activity(Label = "Atividade2_radioButton",MainLauncher = false)]
    public class Atividade2_radioButton : Activity
    {
        RadioButton rdbXamarin;
        RadioButton rdbAndroid;
        RadioButton rdbIOS;
        ImageView image01;
        Drawable caminho;


        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.Atividade2_radioButton);

            //referencia dos elementos
            rdbXamarin = FindViewById<RadioButton>(Resource.Id.rD01);
            rdbAndroid = FindViewById < RadioButton>(Resource.Id.rD02);
            rdbIOS = FindViewById<RadioButton>(Resource.Id.rD03);
            image01 = FindViewById<ImageView>(Resource.Id.img01);

            
            rdbXamarin.Click += seleciona;
            rdbAndroid.Click += seleciona;

            rdbIOS.Click += (senderArg, arg) => {
                caminho = Resources.GetDrawable(Resource.Drawable.baseline_face_black_48dp);
                image01.SetImageDrawable(caminho);

            };
        }

        private void seleciona (object sender,EventArgs e)
        {
            if(rdbXamarin.Checked == true)
            {
                caminho = Resources.GetDrawable(Resource.Drawable.baseline_motorcycle_black_48dp);
                image01.SetImageDrawable(caminho);
            }
            else if(rdbAndroid.Checked==true)
            {
                caminho = Resources.GetDrawable(Resource.Drawable.baseline_android_black_48dp);
                image01.SetImageDrawable(caminho);

            }
            
        }

    }
}