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
    [Activity(Label = "ViewImageView", MainLauncher = false)]
    public class Activity1 : Activity
    {
        ImageButton img1, img2, img3;
        ImageView imgCentral;
        Drawable caminho;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            // Create your application here
            base.OnCreate(savedInstanceState);
            //chamar a tela  do xml
           SetContentView(Resource.Layout.ViewImageView);

            //Referenciar os elementos xml com c#
            img1 = FindViewById<ImageButton>(Resource.Id.imgXamarim);
            img2 = FindViewById<ImageButton>(Resource.Id.imgIos);
            img3 = FindViewById<ImageButton>(Resource.Id.xamarim);
            imgCentral = FindViewById <ImageView>(Resource.Id.imgv);

            //Evento do botão
            img1.Click += Img1_Click;
            img2.Click += Img2_Click;
            img3.Click += Img3_Click;

        }

        private void Img3_Click(object sender, EventArgs e)
        {
            //Colocar a referencia do caminha da imagem grande
            caminho = Resources.GetDrawable(Resource.Drawable.baseline_motorcycle_black_48dp);
            //Colocar na imagem na central
            imgCentral.SetImageDrawable(caminho);

        }

        private void Img2_Click(object sender, EventArgs e)
        {
            //Colocar a referencia do caminha da imagem grande
            caminho = Resources.GetDrawable(Resource.Drawable.baseline_face_black_48dp);
            //Colocar na imagem na central
            imgCentral.SetImageDrawable(caminho);

        }

        private void Img1_Click(object sender, EventArgs e)
        {
            //Colocar a referencia do caminha da imagem grande
            caminho = Resources.GetDrawable(Resource.Drawable.baseline_android_black_48dp);
            //Colocar na imagem na central
            imgCentral.SetImageDrawable(caminho);
               
        }
    }
}