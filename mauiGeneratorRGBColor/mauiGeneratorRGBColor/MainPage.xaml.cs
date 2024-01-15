namespace mauiGeneratorRGBColor;

public partial class MainPage : ContentPage
{
    Random rnd = new();
	public MainPage()
	{
		InitializeComponent();

        slider_r.ValueChanged += Slider_All_ValueChanged;
        slider_g.ValueChanged += Slider_All_ValueChanged;
        slider_b.ValueChanged += Slider_All_ValueChanged;
        buRandomColor.Clicked += BuRandomColor_Clicked;
	}

    private void Slider_All_ValueChanged(object sender, ValueChangedEventArgs e)
    {
        boxview_color.Color = Color.FromRgb((int)slider_r.Value,(int)slider_g.Value,(int)slider_b.Value);
    }

    private void BuRandomColor_Clicked(object sender, EventArgs e)
    {
        slider_r.Value = rnd.Next(256);
        slider_g.Value = rnd.Next(256);
        slider_b.Value = rnd.Next(256);
    }

    //private void Slider_b_ValueChanged(object sender, ValueChangedEventArgs e)
    //{
    //    throw new NotImplementedException();
    //}

    //private void Slider_g_ValueChanged(object sender, ValueChangedEventArgs e)
    //{
    //    throw new NotImplementedException();
    //}

    //private void Slider_r_ValueChanged(object sender, ValueChangedEventArgs e)
    //{
    //    throw new NotImplementedException();
    //}
}

