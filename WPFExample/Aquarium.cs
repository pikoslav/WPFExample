using System;
using System.Windows;

namespace WPFExample;


public class Aquarium : UIElement
{
  public static readonly DependencyProperty HasFishProperty = DependencyProperty.RegisterAttached(
    "HasFish",
    typeof(Boolean),
    typeof(Aquarium),
    new FrameworkPropertyMetadata(defaultValue: false, flags: FrameworkPropertyMetadataOptions.AffectsRender)
  );

  public static Boolean GetHasFish(UIElement target) => (Boolean)target.GetValue(HasFishProperty);
  public static void SetHasFish(UIElement target, Boolean value) => target.SetValue(HasFishProperty, value);
}
