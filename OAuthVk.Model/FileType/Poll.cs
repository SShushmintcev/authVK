using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using OAuthVk.Core;
using OAuthVk.Core.FileType;

namespace OAuthVk.Model.FileType
{
  [Serializable]
  public class Poll : IPoll
  {
    /// <summary>
    /// Конструктор классса.
    /// </summary>
    public Poll()
    {
      Answers = new List<Answer>();
    }

    /// <summary>
    /// Идентификатор опроса для получения информации о нем через метод polls.getById.
    /// </summary>
    ///TODO: Красивую ссылку на метод
    public int Id { get; set; }

    /// <summary>
    /// Идентификатор владельца опроса.
    /// </summary>
    [JsonProperty("owner_id")]
    public int OwnerId { get; set; }

    /// <summary>
    /// Дата создания в формате Unixtime.
    /// </summary>
    public int Created { get; set; }

    /// <summary>
    /// Текст вопроса.
    /// </summary>
    public string Question { get; set; }

    /// <summary>
    /// Количество голосов.
    /// </summary>
    [JsonProperty("votes")]
    public int VotesCount { get; set; }

    /// <summary>
    /// Идентификатор варианта ответа, выбранного текущим пользователем.
    /// </summary>
    [JsonProperty("answer_id")]
    public int AnswerId { get; set; }

    /// <summary>
    /// Массив объектов, которые содержат информацию о вариантах ответа.
    /// </summary>
    [JsonProperty]
    public List<Answer> Answers { get; set; }

    /// <summary>
    /// Массив объектов, которые содержат информацию о вариантах ответа.
    /// </summary>
    IEnumerable<IAnswer> IPoll.Answers => Answers;

    /// <summary>
    /// Признак анонимного опроса.
    /// </summary>
    public bool Anonymous { get; set; }
  }
}