using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using System.Net.Http;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using System.Threading.Tasks;
using Android.Content;


namespace TEST_IBT
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity, ILoginView
    {


        EditText loginField;
        EditText pasFiesld;
        Button login;
        //TextView ResponseText;
        Presenter_Main presenter;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);
            loginField = FindViewById<EditText>(Resource.Id.ETlogin);
            pasFiesld = FindViewById<EditText>(Resource.Id.ETpassword);
            // ResponseText = FindViewById<TextView>(Resource.Id.textViewResponse);
            presenter = new Presenter_Main(this);
            login = FindViewById<Button>(Resource.Id.btnlogin);
            login.Click += Login_Click;

        }



        private void Login_Click(object sender, System.EventArgs e)
        {
            presenter.GetAuthorization(loginField.Text, pasFiesld.Text);
        }

        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
        protected override void OnDestroy()
        {
            base.OnDestroy();
            login.Click -= Login_Click;
            presenter = null;
        }

        public void TranslateSignal(string signal)
        {
            Intent intent = new Intent(this.BaseContext, typeof(Signals_Activity));
            intent.PutExtra("signals", signal);
            StartActivity(intent);

        }

    }
}