namespace OAuthVk.Core
{
  public interface ICoordinates
  {
    /// <summary>
    /// Координата X левого верхнего угла в процентах.
    /// </summary>
    double Left { get; set; }

    /// <summary>
    /// Координата Y левого верхнего угла в процентах.
    /// </summary>
    double Top { get; set; }


    /// <summary>
    /// Координата X правого нижнего угла в процентах.
    /// </summary>
    double Right { get; set; }


    /// <summary>
    /// Координата Y правого нижнего угла в процентах.
    /// </summary>
    double Bottom { get; set; }
    
  }
}