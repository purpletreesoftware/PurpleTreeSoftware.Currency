# PurpleTreeSoftware.Currency

User control for displaying currency values in .Net C# UWP applications


Add a reference to your project
```
using PurpleTreeSoftware.Currency;
```

Then add a namespace to your xaml page
```
xmlns:currency="using:PurpleTreeSoftware.Currency"
```

Then add the controls to your xaml page. Note to update the x:Bind path to point to your variable. 
Decimal places to display are also specified here.

```
  <currency:EditBox x:Name="CurrencyText"  CurrencyValue="{x:Bind CurrencyDecimalValue, Mode=TwoWay}" DecimalPlaces="2"  />
  
  <currency:DisplayBox x:Name="CurrencyDisplay" CurrencyValue="{x:Bind CurrencyDecimalValue, Mode=OneWay}" DecimalPlaces="2" />
                                    
```   

The currency symbol is based on the language setting of Windows 10.
To change the currency symbol displayed, in Windows 10, search for *Region & language settings* in the windows *start menu*. Then add your desired language.
