using System;
using OAuthVk.Core;

namespace OAuthVk.Model
{
  [Serializable]
  public class Size : ISize
  {
    /// <summary>
    /// Url копии изображения
    /// </summary>
    public string Src { get; set; }

    /// <summary>
    /// Ширина копии в пикселах
    /// </summary>
    public int Width { get; set; }

    /// <summary>
    /// Высота копии в пикселах
    /// </summary>
    public int Height { get; set; }

    /// <summary>
    /// Обозначение размера и пропорций копии.
    /// </summary>
    public string Type { get; set; }
  }
}