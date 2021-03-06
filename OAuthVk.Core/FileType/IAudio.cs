﻿using System.Collections.Generic;
using OAuthVk.Core.Enums;

namespace OAuthVk.Core.FileType
{
  public interface IAudio
  {
    /// <summary>
    /// Идентификатор аудиозаписи.
    /// </summary>
    int Id { get; set; }

    /// <summary>
    /// Идентификатор владельца аудиозаписи.
    /// </summary>
    int OwnerId { get; set; }

    /// <summary>
    /// Исполнитель.
    /// </summary>
    string Artist {get;set;}

    /// <summary>
    /// Название композиции.
    /// </summary>
    string Title {get;set;}

    /// <summary>
    /// Длительность аудиозаписи в секундах.
    /// </summary>
    int Duration { get; set; }

    /// <summary>
    /// Массив значений(integer) для визуального отображения звука.
    /// </summary>
    /// <remarks>Используется в медиавложении в личных сообщениях - тип Документ.</remarks>
    IEnumerable<int> Waveform { get; }

    /// <summary>
    /// URL .ogg-файла.
    /// </summary>
    /// <remarks>Используется в медиавложении в личных сообщениях - тип Документ.</remarks>
    string OggUrl { get; set; }

    /// <summary>
    /// URL .mp3-файла.
    /// </summary>
    /// <remarks>Используется в медиавложении в личных сообщениях - тип Документ.</remarks>
    string Mp3Url { get; set; }

    /// <summary>
    /// Ссылка на mp3.
    /// </summary>
    string Url {get;set;}

    /// <summary>
    ///  Идентификатор текста аудиозаписи.
    /// </summary>
    int? LyricsId { get; set; }

    /// <summary>
    /// Идентификатор альбома, в котором находится аудиозапись(если присвоен).
    /// </summary>
    int AlbumId { get; set; }

    /// <summary>
    /// Тип жанра.
    /// </summary>
    AudioGenreType GenreType { get; set; }

    /// <summary>
    /// Дата добавления.
    /// </summary>
    int Date { get; set; }

    ///// <summary>
    ///// Истина если включена опция «Не выводить при поиске». Если опция отключена, поле не возвращается.
    ///// </summary>
    //bool no_search { get; set; }
  }
}