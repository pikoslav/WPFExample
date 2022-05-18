using System;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Windows.Data;
using System.Windows.Media;

namespace WPFExample.UI;

public class ImageFilenameToUriConverter : IValueConverter
{
  public Object? Convert(Object value, Type targetType, Object parameter, CultureInfo culture)
  {
    if (value is null) return null;

    var text = value.ToString();
    var directory = Path.Combine(Path.GetDirectoryName(Assembly.GetEntryAssembly()!.Location)!, @"..\..\..\Pictures");
    var filename = Path.Combine(directory, text!);
    return new Uri(filename);
  }

  public Object ConvertBack(Object value, Type targetType, Object parameter, CultureInfo culture) => throw new NotImplementedException();

}


public class BooleanToBrushConverter : IValueConverter
{
  private static SolidColorBrush? _red = new SolidColorBrush(Colors.Red);
  private static SolidColorBrush? _none = default(SolidColorBrush);

  public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
  {
    var v = value is null ? false : (Boolean)value;
    return v ? _none : _red;
  }

  // Only converting one way
  public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
  {
    throw new NotImplementedException();
  }

}

