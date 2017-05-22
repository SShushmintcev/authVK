using System;
using Newtonsoft.Json;
using OAuthVk.Core;
using OAuthVk.Core.FileType;

namespace OAuthVk.Model.FileType
{
  [Serializable]
  public class Crop : ICrop
  {
    /// <summary>
    /// Фотографии пользователя, из которой вырезается главное фото профиля.
    /// </summary>
    [JsonProperty]
    public Photo Photo { get; set; }

    IPhoto ICrop.Photo
    {
      get { return Photo; }
    }

    /// <summary>
    /// Вырезанная фотография пользователя.
    /// </summary>
    [JsonProperty("crop")]
    public Coordinates PhotoCrop { get; set; }

    ICoordinates ICrop.PhotoCrop
    {
      get { return PhotoCrop; }
    }

    /// <summary>
    /// Миниатюрная квадратная фотография, вырезанная из фотографии <see cref="ICrop.PhotoCrop"/>.
    /// </summary>
    [JsonProperty("rect")]
    public Coordinates PhotoRect { get; set; }

    ICoordinates ICrop.PhotoRect
    {
      get { return PhotoRect; }
    }
  }
}