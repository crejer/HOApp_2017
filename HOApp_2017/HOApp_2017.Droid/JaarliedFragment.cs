using Android.OS;
using Android.Views;

namespace HOApp_2017.Droid
{
    public class JaarliedFragment : ContentBaseFragment
    {
        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            var view = base.OnCreateView(inflater, container, savedInstanceState);

            HeaderImage.SetImageResource(Resource.Drawable.headers_jaarlied);
            Title.Text = "Jaarlied";

            return view;
        }
    }
}