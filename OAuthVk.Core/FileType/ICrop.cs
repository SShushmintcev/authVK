namespace OAuthVk.Core.FileType
{
  public interface ICrop
  {
    /// <summary>
    /// Фотографии пользователя, из которой вырезается главное фото профиля.
    /// </summary>
    IPhoto Photo { get; }

    /// <summary>
    /// Вырезанная фотография пользователя.
    /// </summary>
    ICoordinates PhotoCrop { get; }

    /// <summary>
    /// Миниатюрная квадратная фотография, вырезанная из фотографии <see cref="PhotoCrop"/>.
    /// </summary>
    ICoordinates PhotoRect { get; }
  }


}