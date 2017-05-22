namespace OAuthVk.Core
{
  public interface IOccupation
  {
    /// <summary>
    /// Тип.
    /// </summary>
    /// <value>work — работа.</value>
    /// <value>school — среднее образование.</value>
    /// <value>university — высшее образование.</value>
    string Type { get; set; }

    /// <summary>
    /// Идентификатор школы, вуза, сообщества компании (в которой пользователь работает).
    /// </summary>
    int Id { get; set; }

    /// <summary>
    /// Название школы, вуза или места работы.
    /// </summary>
    string Name { get; set; }
  }
}