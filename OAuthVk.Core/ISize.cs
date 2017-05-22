namespace OAuthVk.Core
{
  public interface ISize
  {
    /// <summary>
    /// Url копии изображения
    /// </summary>
    string Src { get; set; }

    /// <summary>
    /// Ширина копии в пикселах
    /// </summary>
    int Width { get; set; }

    /// <summary>
    /// Высота копии в пикселах
    /// </summary>
    int Height { get; set; }

    /// <summary>
    /// Обозначение размера и пропорций копии.
    /// </summary>
    string Type { get; set; }
  }
}