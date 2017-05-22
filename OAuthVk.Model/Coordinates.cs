using System;
using Newtonsoft.Json;
using OAuthVk.Core;

namespace OAuthVk.Model
{
  [Serializable]
  public class Coordinates : ICoordinates
  {
    /// <summary>
    /// Координата X левого верхнего угла в процентах.
    /// </summary>
    [JsonProperty("x")]
    public double Left { get; set; }

    /// <summary>
    /// Координата Y левого верхнего угла в процентах.
    /// </summary>
    [JsonProperty("y")]
    public double Top { get; set; }

    /// <summary>
    /// Координата X правого нижнего угла в процентах.
    /// </summary>
    [JsonProperty("x2")]
    public double Right { get; set; }

    /// <summary>
    /// Координата Y правого нижнего угла в процентах.
    /// </summary>
    [JsonProperty("y2")]
    public double Bottom { get; set; }
  }
}