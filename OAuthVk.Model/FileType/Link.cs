using System;
using Newtonsoft.Json;
using OAuthVk.Core;
using OAuthVk.Core.FileType;

namespace OAuthVk.Model.FileType
{
  [Serializable]
  public class Link : ILink
  {
    /// <summary>
    /// URL ссылки.
    /// </summary>
    public string Url { get; set; }

    /// <summary>
    /// Заголовок ссылки.
    /// </summary>
    public string Title { get; set; }

    /// <summary>
    /// Подпись ссылки(если имеется).
    /// </summary>
    public string Caption { get; set; }

    /// <summary>
    /// Описание ссылки.
    /// </summary>
    public string Description { get; set; }

    /// <summary>
    /// Изображение превью, объект фотографии(если имеется).
    /// </summary>
    [JsonProperty]
    public Photo Photo { get; set; }

    /// <summary>
    /// Изображение превью, объект фотографии(если имеется).
    /// </summary>
    IPhoto ILink.Photo => Photo;

    /// <summary>
    /// Является ли ссылка внешней.
    /// </summary>
    [JsonProperty("is_external")]
    public bool IsExternal { get; set; }

    /// <summary>
    /// Информация о продукте(если имеется).
    /// Поле возвращается для ссылок на магазины, например, Aliexpress.
    /// </summary>
    [JsonProperty]
    public Product Product { get; set; }

    /// <summary>
    /// Информация о продукте(если имеется).
    /// Поле возвращается для ссылок на магазины, например, Aliexpress.
    /// </summary>
    IProduct ILink.Product => Product;

    /// <summary>
    /// Информация о кнопке для перехода(если имеется).
    /// </summary>
    [JsonProperty]
    public ButtonInfo Button { get; set; }

    /// <summary>
    /// Информация о кнопке для перехода(если имеется).
    /// </summary>
    IButtonInfo ILink.Button => Button;

    /// <summary>
    /// Идентификатор вики-страницы с контентом для предпросмотра содержимого страницы.
    /// Возвращается в формате "owner_id_page_id".
    /// </summary>
    [JsonProperty("preview_page")]
    public string PreviewPage { get; set; }

    /// <summary>
    /// URL страницы с контентом для предпросмотра содержимого страницы.
    /// </summary>
    [JsonProperty("preview_url")]
    public string PreviewUrl { get; set; }
  }
}