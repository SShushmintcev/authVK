using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using OAuthVk.Core.Enums;
using OAuthVk.Core.FileType;

namespace OAuthVk.Model.FileType
{
  [Serializable]
  public class Audio : IAudio
  {
    /// <summary>
    /// Идентификатор аудиозаписи.
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// Идентификатор владельца аудиозаписи.
    /// </summary>
    [JsonProperty("owner_id")]
    public int OwnerId { get; set; }

    /// <summary>
    /// Исполнитель.
    /// </summary>
    public string Artist { get; set; }

    /// <summary>
    /// Название композиции.
    /// </summary>
    public string Title { get; set; }

    /// <summary>
    /// Длительность аудиозаписи в секундах.
    /// </summary>
    public int Duration { get; set; }

    /// <summary>
    /// Массив значений для визуального отображения звука.
    /// </summary>
    /// <remarks>Используется в медиавложении в личных сообщениях - тип Документ.</remarks>
    [JsonProperty]
    public List<int> Waveform { get; set; }

    /// <summary>
    /// Массив значений(integer) для визуального отображения звука.
    /// </summary>
    /// <remarks>Используется в медиавложении в личных сообщениях - тип Документ.</remarks>
    IEnumerable<int> IAudio.Waveform => Waveform;

    /// <summary>
    /// URL .ogg-файла.
    /// </summary>
    /// <remarks>Используется в медиавложении в личных сообщениях - тип Документ.</remarks>
    [JsonProperty("link_ogg")]
    public string OggUrl { get; set; }

    /// <summary>
    /// URL .mp3-файла.
    /// </summary>
    /// <remarks>Используется в медиавложении в личных сообщениях - тип Документ.</remarks>
    [JsonProperty("link_mp3")]
    public string Mp3Url { get; set; }

    /// <summary>
    /// Ссылка на mp3.
    /// </summary>
    public string Url { get; set; }

    /// <summary>
    ///  Идентификатор текста аудиозаписи.
    /// </summary>
    [JsonProperty("lyrics_id")]
    public int? LyricsId { get; set; }

    /// <summary>
    /// Идентификатор альбома, в котором находится аудиозапись(если присвоен).
    /// </summary>
    [JsonProperty("album_id")]
    public int AlbumId { get; set; }

    /// <summary>
    /// Тип жанра.
    /// </summary>
    [JsonProperty("genre_id")]
    public AudioGenreType GenreType { get; set; }

    /// <summary>
    /// Дата добавления.
    /// </summary>
    public int Date { get; set; }
  }
}