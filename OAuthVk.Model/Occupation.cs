using OAuthVk.Core;

namespace OAuthVk.Model
{
  public class Occupation : IOccupation
  {
    /// <summary>
    /// Тип.
    /// </summary>
    /// <value>work — работа.</value>
    /// <value>school — среднее образование.</value>
    /// <value>university — высшее образование.</value>
    public string Type { get; set; }

    /// <summary>
    /// Идентификатор школы, вуза, сообщества компании (в которой пользователь работает).
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// Название школы, вуза или места работы.
    /// </summary>
    public string Name { get; set; }
  }
}