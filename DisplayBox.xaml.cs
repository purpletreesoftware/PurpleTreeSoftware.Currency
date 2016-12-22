using System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;


namespace PurpleTreeSoftware.Currency
{
    public sealed partial class DisplayBox : UserControl
    {
        /// <summary>
        /// The currency value expressed as decimal value
        /// </summary>
        public decimal CurrencyValue
        {
            get { return Convert.ToDecimal(GetValue(CurrencyValueProperty)); }
            set { SetValue(CurrencyValueProperty, value); }
        }

        // Using a DependencyProperty as the backing store for CurrencyValue.  
        public static readonly DependencyProperty CurrencyValueProperty =
            DependencyProperty.Register("CurrencyValue", typeof(decimal), typeof(DisplayBox), new PropertyMetadata(0));

        


        /// <summary>
        /// Number of decimal places for currency value to display
        /// </summary>
        public int DecimalPlaces
        {
            get { return (int)GetValue(DecimalPlacesProperty); }
            set {SetValue(DecimalPlacesProperty, value); }
        }

        // Using a DependencyProperty as the backing store for DecimalPlaces. 
        public static readonly DependencyProperty DecimalPlacesProperty =
            DependencyProperty.Register("DecimalPlaces", typeof(int), typeof(DisplayBox), new PropertyMetadata(0));


       

        /// <summary>
        /// Constructor
        /// </summary>
        public DisplayBox()
        {
            this.InitializeComponent();
        }




    }
}
