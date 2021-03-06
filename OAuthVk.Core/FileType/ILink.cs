﻿namespace OAuthVk.Core.FileType
{
  public interface ILink
  {
    /// <summary>
    /// URL ссылки.
    /// </summary>
    string Url { get; set; }

    /// <summary>
    /// Заголовок ссылки.
    /// </summary>
    string Title { get; set; }

    /// <summary>
    /// Подпись ссылки(если имеется).
    /// </summary>
    string Caption { get; set; }

    /// <summary>
    /// Описание ссылки.
    /// </summary>
    string Description { get; set; }

    /// <summary>
    /// Изображение превью, объект фотографии(если имеется).
    /// </summary>
    IPhoto Photo { get; }

    /// <summary>
    /// Является ли ссылка внешней.
    /// </summary>
    bool IsExternal { get; set; }

    /// <summary>
    /// Информация о продукте(если имеется).
    /// Поле возвращается для ссылок на магазины, например, Aliexpress.
    /// </summary>
    IProduct Product { get; }

    /// <summary>
    /// Информация о кнопке для перехода(если имеется).
    /// </summary>
    IButtonInfo Button { get; }

    /// <summary>
    /// Идентификатор вики-страницы с контентом для предпросмотра содержимого страницы.
    /// Возвращается в формате "owner_id_page_id".
    /// </summary>
    string PreviewPage { get; set; }

    /// <summary>
    /// URL страницы с контентом для предпросмотра содержимого страницы.
    /// </summary>
    string PreviewUrl { get; set; }
  }
}