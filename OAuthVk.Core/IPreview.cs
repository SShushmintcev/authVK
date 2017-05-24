using System;
using OAuthVk.Core.FileType;

namespace OAuthVk.Core
{
  public interface IPreview
  {
    /// <summary>
    /// Изображения для предпросмотра.
    /// </summary>
    IPhoto Photo { get; }

    /// <summary>
    /// Данные о граффити.
    /// </summary>
    ISize Graffiti { get; }

    /// <summary>
    /// Данные об аудиосообщении.
    /// </summary>
    IAudio AudioMsg { get; }
  }
}
