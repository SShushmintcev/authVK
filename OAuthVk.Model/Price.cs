using System;
using OAuthVk.Core;

namespace OAuthVk.Model
{
  [Serializable]
  public class Price : IPrice
  {
    /// <summary>
    /// Цена товара.
    /// </summary>
    public double Amount { get; set; }

    /// <summary>
    /// Информация о валюте.
    /// </summary>
    public Currency Currency { get; set; }

    /// <summary>
    /// Информация о валюте.
    /// </summary>
    ICurrency IPrice.Currency => Currency;

    /// <summary>
    /// Строка с локализованной ценой и валютой.
    /// </summary>
    public string Text { get; set; }
  }

  [Serializable]
  public class Currency : ICurrency
  {
    /// <summary>
    /// Идентификатор валюты.
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// Буквенное обозначение валюты.
    /// </summary>
    public string Name { get; set; }
  }
}