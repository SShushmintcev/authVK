using System;
using OAuthVk.Core;

namespace OAuthVk.Model
{
  [Serializable]
  public class Answer : IAnswer
  {
    /// <summary>
    /// идентификатор ответа.
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// Текст ответа.
    /// </summary>
    public string Text { get; set; }

    /// <summary>
    /// Число проголосовавших за этот ответ.
    /// </summary>
    public int Votes { get; set; }

    /// <summary>
    /// Рейтинг ответа.
    /// </summary>
    public double Rate { get; set; }
  }
}