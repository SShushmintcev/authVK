using OAuthVk.Core.Enums;

namespace OAuthVk.Core.FileType
{
  public interface IDocument
  {
    /// <summary>
    /// Идентификатор документа.
    /// </summary>
    int Id { get; set; }

    /// <summary>
    /// Идентификатор пользователя, загрузившего документ.
    /// </summary>
    int OwnerId { get; set; }

    /// <summary>
    /// Название документа.
    /// </summary>
    string Title { get; set; }

    /// <summary>
    /// Размер документа в байтах.
    /// </summary>
    int Size { get; set; }

    /// <summary>
    /// Расширение документа.
    /// </summary>
    string Ext { get; set; }

    /// <summary>
    /// Адрес документа, по которому его можно загрузить.
    /// </summary>
    string Url { get; set; }

    /// <summary>
    /// Дата добавления в формате Unixtime.
    /// </summary>
    int Date { get; set; }

    /// <summary>
    /// Тип документа.
    /// </summary>
    DocumentType Type { get; set; }

    /// <summary>
    /// Информация для предварительного просмотра документа.
    /// </summary>
    IPreview Preview { get; }
  }
}