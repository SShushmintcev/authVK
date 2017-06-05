using System.Collections;
using System.Collections.Generic;

namespace OAuthVk.Core.FileType
{
  public interface IPoll
  {
    /// <summary>
    /// Идентификатор опроса для получения информации о нем через метод polls.getById.
    /// </summary>
    ///TODO: Красивую ссылку на метод
    int Id { get; set; }

    /// <summary>
    /// Идентификатор владельца опроса.
    /// </summary>
    int OwnerId { get; set; }

    /// <summary>
    /// Дата создания в формате Unixtime.
    /// </summary>
    int Created { get; set; }

    /// <summary>
    /// Текст вопроса.
    /// </summary>
    string Question { get; set; }

    /// <summary>
    /// Количество голосов.
    /// </summary>
    int VotesCount { get; set; }

    /// <summary>
    /// Идентификатор варианта ответа, выбранного текущим пользователем.
    /// </summary>
    int AnswerId { get; set; }

    /// <summary>
    /// Массив объектов, которые содержат информацию о вариантах ответа.
    /// </summary>
    IEnumerable<IAnswer> Answers { get; }

    /// <summary>
    /// Признак анонимного опроса.
    /// </summary>
    bool Anonymous { get; set; }
  }
}