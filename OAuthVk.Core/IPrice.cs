namespace OAuthVk.Core
{
  public interface IPrice
  {
    /// <summary>
    /// Цена товара.
    /// </summary>
    double Amount { get; set; }

    /// <summary>
    /// Информация о валюте.
    /// </summary>
    ICurrency Currency { get; }

    /// <summary>
    /// Строка с локализованной ценой и валютой.
    /// </summary>
    string Text { get; set; }
  }

  public interface ICurrency
  {
    /// <summary>
    /// Идентификатор валюты.
    /// </summary>
    int Id { get; set; }

    /// <summary>
    /// Буквенное обозначение валюты.
    /// </summary>
    string Name { get; set; }
  }
}