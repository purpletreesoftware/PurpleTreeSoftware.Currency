using System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using PurpleTreeSoftware.Currency.Common;

namespace PurpleTreeSoftware.Currency
{
    public sealed partial class EditBox : UserControl
    {
        
        /// <summary>
        /// The currency value expressed as decimal value
        /// </summary>
        public decimal CurrencyValue
        {
            get { return (decimal)GetValue(CurrencyValueProperty); }
            set { SetValue(CurrencyValueProperty, value); }
        }

        // Using a DependencyProperty as the backing store for CurrencyValue.  
        public static readonly DependencyProperty CurrencyValueProperty =
            DependencyProperty.Register("CurrencyValue", typeof(decimal), typeof(EditBox), new PropertyMetadata(0));

        
        /// <summary>
        /// Number of decimal places for currency value to display
        /// </summary>
        public int DecimalPlaces
        {
            get { return (int)GetValue(DecimalPlacesProperty); }
            set { SetValue(DecimalPlacesProperty, value); }
        }

        // Using a DependencyProperty as the backing store for DecimalPlaces. 
        public static readonly DependencyProperty DecimalPlacesProperty =
            DependencyProperty.Register("DecimalPlaces", typeof(int), typeof(EditBox), new PropertyMetadata(0));
        

        /// <summary>
        /// Converts a string to a decimal value. Used for bindback.
        /// </summary>
        /// <param name="pCurrencyString">The currency string to convert to a decimal value</param>
        public void SetCurrencyValueFromString(String pCurrencyString)
        {
            CurrencyValue = helper.ConvertStringToDecimal(pCurrencyString);
        }

        
        /// <summary>
        /// Constructor
        /// </summary>
        public EditBox()
        {
            this.InitializeComponent();
        }



       

    }
}
