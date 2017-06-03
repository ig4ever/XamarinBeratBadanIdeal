using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Tugas1
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class HalamanUtama : ContentPage
	{
        public double opt1, opt2;
        public String opt3;

		public HalamanUtama ()
		{
			InitializeComponent ();
            pria.Clicked += Pria;
            wanita.Clicked += Wanita;
        }

        private void Pria(object sender, EventArgs e)
        {
            opt1 = (Convert.ToDouble(tinggi.Text)-100.0) - (0.1 * (Convert.ToDouble(tinggi.Text)-100.0));
            opt2 = Convert.ToDouble(berat.Text) / Math.Pow(Convert.ToDouble(tinggi.Text) / 100, 2);

            if (opt2 < 17.0)
                opt3 = "Under(< 17 Kg)";
            else if (opt2 >= 17.0 && opt2 < 23.0)
                opt3 = "Normal(18 - 25 Kg)";
            else if (opt2 >= 23.0 && opt2 <= 27.0)
                opt3 = "Over(25 - 27 Kg)";
            else if (opt2 > 27.0)
                opt3 = "Obesitas(> 27 Kg)";

            brocha.Text = Convert.ToString((decimal)opt1);
            bmi.Text = Convert.ToString((int)opt2);
            kesimpulan.Text = opt3;
        }

        private void Wanita(object sender, EventArgs e)
        {
            opt1 = (Convert.ToDouble(tinggi.Text) - 100.0) - (0.15 * (Convert.ToDouble(tinggi.Text) - 100.0));
            opt2 = Convert.ToDouble(berat.Text) / Math.Pow(Convert.ToDouble(tinggi.Text) / 100, 2);

            if (opt2 < 18.0)
                opt3 = "Under(< 18 Kg)";
            else if(opt2 >= 18.0 && opt2 < 25.0)
                opt3 = "Normal(18 - 25 Kg)";
            else if (opt2 >= 25.0 && opt2 <= 27.0)
                opt3 = "Over(25 - 27 Kg)";
            else if (opt2 > 27.0)
                opt3 = "Obesitas(> 27 Kg)";

            brocha.Text = Convert.ToString((decimal)opt1);
            bmi.Text = Convert.ToString((int)opt2);
            kesimpulan.Text = opt3;
        }
    }
}