using System;
using Newtonsoft.Json;
using OAuthVk.Core;

namespace OAuthVk.Model
{
  [Serializable]
  public class Product : IProduct
  {
    /// <summary>
    /// Информация о цене.
    /// </summary>
    [JsonProperty]
    public Price Price { get; set; }

    /// <summary>
    /// Информация о цене.
    /// </summary>
    IPrice IProduct.Price => Price;
  }
}