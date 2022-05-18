using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

using WPFExample.Models;
using WPFExample.ViewModels;
using WPFExample.UI;
using System.Reflection;
using System.Windows.Media.Effects;

namespace WPFExample.Views;

public partial class AuthorsView : UserControl
{
  public AuthorsView()
  {
    InitializeComponent();

    var context = new AuthorsViewModel();
    DataContext = context;


  }




  public ICommand BarCommand { get; set; }

}


//fxc BandedSwirl_PS3.fx /O0 /Fc /Zi /T ps_2_0 /Fo BandedSwirl.ps
public class RippleEffect : ShaderEffect
{
  public static readonly DependencyProperty InputProperty = ShaderEffect.RegisterPixelShaderSamplerProperty("Input", typeof(RippleEffect), 0);

  public static readonly DependencyProperty CenterProperty = DependencyProperty.Register("Center", typeof(Point), typeof(RippleEffect), new UIPropertyMetadata(new Point(0.5D, 0.5D), PixelShaderConstantCallback(0)));

  public static readonly DependencyProperty AmplitudeProperty = DependencyProperty.Register("Amplitude", typeof(double), typeof(RippleEffect), new UIPropertyMetadata(0.1D, PixelShaderConstantCallback(1)));

  public static readonly DependencyProperty FrequencyProperty = DependencyProperty.Register("Frequency", typeof(double), typeof(RippleEffect), new UIPropertyMetadata(70D, PixelShaderConstantCallback(2)));

  public static readonly DependencyProperty PhaseProperty = DependencyProperty.Register("Phase", typeof(double), typeof(RippleEffect), new UIPropertyMetadata(0D, PixelShaderConstantCallback(3)));

  public static readonly DependencyProperty AspectRatioProperty = DependencyProperty.Register("AspectRatio", typeof(double), typeof(RippleEffect), new UIPropertyMetadata(1.5D, PixelShaderConstantCallback(4)));

  /// <summary>
  /// The uri should be something like pack://application:,,,/Gu.Wpf.Geometry;component/Effects/RippleEffect.ps
  /// The file RippleEffect.ps should have BuildAction: Resource
  /// </summary>
  private static readonly PixelShader Shader = new PixelShader
  {
    UriSource = new Uri("pack://application:,,,/WPFExample;component/Ripple.ps", UriKind.Absolute)
  };

  public RippleEffect()
  {
    this.PixelShader = Shader;
    this.UpdateShaderValue(InputProperty);
    this.UpdateShaderValue(CenterProperty);
    this.UpdateShaderValue(AmplitudeProperty);
    this.UpdateShaderValue(FrequencyProperty);
    this.UpdateShaderValue(PhaseProperty);
    this.UpdateShaderValue(AspectRatioProperty);
  }

  /// <summary>
  /// There has to be a property of type Brush called "Input". This property contains the input image and it is usually not set directly - it is set automatically when our effect is applied to a control.
  /// </summary>
  public Brush Input
  {
    get
    {
      return ((Brush)(this.GetValue(InputProperty)));
    }
    set
    {
      this.SetValue(InputProperty, value);
    }
  }

  /// <summary>The center point of the ripples.</summary>
  public Point Center
  {
    get
    {
      return ((Point)(this.GetValue(CenterProperty)));
    }
    set
    {
      this.SetValue(CenterProperty, value);
    }
  }

  /// <summary>The amplitude of the ripples.</summary>
  public double Amplitude
  {
    get
    {
      return ((double)(this.GetValue(AmplitudeProperty)));
    }
    set
    {
      this.SetValue(AmplitudeProperty, value);
    }
  }

  /// <summary>The frequency of the ripples.</summary>
  public double Frequency
  {
    get
    {
      return ((double)(this.GetValue(FrequencyProperty)));
    }
    set
    {
      this.SetValue(FrequencyProperty, value);
    }
  }

  /// <summary>The phase of the ripples.</summary>
  public double Phase
  {
    get
    {
      return ((double)(this.GetValue(PhaseProperty)));
    }
    set
    {
      this.SetValue(PhaseProperty, value);
    }
  }

  /// <summary>The aspect ratio (width / height) of the input.</summary>
  public double AspectRatio
  {
    get
    {
      return ((double)(this.GetValue(AspectRatioProperty)));
    }
    set
    {
      this.SetValue(AspectRatioProperty, value);
    }
  }
}


//fxc BandedSwirl_PS3.fx /O0 /Fc /Zi /T ps_2_0 /Fo BandedSwirl.ps
/// <summary>An effect that swirls the input in alternating clockwise and counterclockwise bands.</summary>
public class BandedSwirlEffect : ShaderEffect
{
  public static readonly DependencyProperty InputProperty = ShaderEffect.RegisterPixelShaderSamplerProperty("Input", typeof(BandedSwirlEffect), 0);

  public static readonly DependencyProperty CenterProperty = DependencyProperty.Register("Center", typeof(Point), typeof(BandedSwirlEffect), new UIPropertyMetadata(new Point(0.5D, 0.5D), PixelShaderConstantCallback(0)));

  public static readonly DependencyProperty BandsProperty = DependencyProperty.Register("Bands", typeof(double), typeof(BandedSwirlEffect), new UIPropertyMetadata(10D, PixelShaderConstantCallback(1)));

  public static readonly DependencyProperty StrengthProperty = DependencyProperty.Register("Strength", typeof(double), typeof(BandedSwirlEffect), new UIPropertyMetadata(0.5D, PixelShaderConstantCallback(2)));

  public static readonly DependencyProperty AspectRatioProperty = DependencyProperty.Register("AspectRatio", typeof(double), typeof(BandedSwirlEffect), new UIPropertyMetadata(1.5D, PixelShaderConstantCallback(3)));

  /// <summary>
  /// The uri should be something like pack://application:,,,/Gu.Wpf.Geometry;component/Effects/BandedSwirlEffect.ps
  /// The file BandedSwirlEffect.ps should have BuildAction: Resource
  /// </summary>
  private static readonly PixelShader Shader = new PixelShader
  {
    
    UriSource = new Uri("pack://application:,,,/WPFExample;component/BandedSwirl.ps", UriKind.Absolute)
  };

  public BandedSwirlEffect()
  {
    this.PixelShader = Shader;
    this.UpdateShaderValue(InputProperty);
    this.UpdateShaderValue(CenterProperty);
    this.UpdateShaderValue(BandsProperty);
    this.UpdateShaderValue(StrengthProperty);
    this.UpdateShaderValue(AspectRatioProperty);
  }

  /// <summary>
  /// There has to be a property of type Brush called "Input". This property contains the input image and it is usually not set directly - it is set automatically when our effect is applied to a control.
  /// </summary>
  public Brush Input
  {
    get
    {
      return ((Brush)(this.GetValue(InputProperty)));
    }
    set
    {
      this.SetValue(InputProperty, value);
    }
  }

  /// <summary>The center of the swirl. (100,100) is lower right corner </summary>
  public Point Center
  {
    get
    {
      return ((Point)(this.GetValue(CenterProperty)));
    }
    set
    {
      this.SetValue(CenterProperty, value);
    }
  }

  /// <summary>The number of bands in the swirl.</summary>
  public double Bands
  {
    get
    {
      return ((double)(this.GetValue(BandsProperty)));
    }
    set
    {
      this.SetValue(BandsProperty, value);
    }
  }

  /// <summary>The strength of the effect.</summary>
  public double Strength
  {
    get
    {
      return ((double)(this.GetValue(StrengthProperty)));
    }
    set
    {
      this.SetValue(StrengthProperty, value);
    }
  }

  /// <summary>The aspect ratio (width / height) of the input.</summary>
  public double AspectRatio
  {
    get
    {
      return ((double)(this.GetValue(AspectRatioProperty)));
    }
    set
    {
      this.SetValue(AspectRatioProperty, value);
    }
  }
}


