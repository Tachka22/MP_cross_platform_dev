﻿namespace mauiCalc;

public partial class MainPage : ContentPage
{
    Calc calc = new();


    public MainPage()
	{

		InitializeComponent();

        calc.ChangedDisplay += (s, e) => laDisplay.Text = calc.DisplayText;

        buCE.Clicked += (s, e) => calc.CE();
        buNum0.Clicked += (s, e) => calc.PressNum(0);
        buNum1.Clicked += (s, e) => calc.PressNum(1);
        buNum2.Clicked += (s, e) => calc.PressNum(2);
        buNum3.Clicked += (s, e) => calc.PressNum(3);
        buNum4.Clicked += (s, e) => calc.PressNum(4);
        buNum5.Clicked += (s, e) => calc.PressNum(5);
        buNum6.Clicked += (s, e) => calc.PressNum(6);
        buNum7.Clicked += (s, e) => calc.PressNum(7);
        buNum8.Clicked += (s, e) => calc.PressNum(8);
        buNum9.Clicked += (s, e) => calc.PressNum(9);

        buPow.Clicked += (s, e) => calc.Pow();
        buDiv.Clicked += (s, e) => calc.PressDiv();
        buMult.Clicked += (s, e) => calc.PressMul();
        buSub.Clicked += (s, e) => calc.PressSub();
        buSum.Clicked += (s, e) => calc.PressSum();

        buEquals.Clicked += (s, e) => calc.PressEquals();
	}
}

