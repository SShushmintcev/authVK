namespace OAuthVk.Core
{
  public interface IAnswer
  {
    /// <summary>
    /// идентификатор ответа.
    /// </summary>
    int Id { get; set; }

    /// <summary>
    /// Текст ответа.
    /// </summary>
    string Text { get; set; }

    /// <summary>
    /// Число проголосовавших за этот ответ.
    /// </summary>
    int Votes { get; set; }

    /// <summary>
    /// Рейтинг ответа.
    /// </summary>
    double Rate {get;set;}
  }
}