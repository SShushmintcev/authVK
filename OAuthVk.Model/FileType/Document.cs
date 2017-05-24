using Newtonsoft.Json;
using OAuthVk.Core;
using OAuthVk.Core.Enums;
using OAuthVk.Core.FileType;

namespace OAuthVk.Model.FileType
{
  public class Document : IDocument
  {
    /// <summary>
    /// Идентификатор документа.
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// Идентификатор пользователя, загрузившего документ.
    /// </summary>
    [JsonProperty("owner_id")]
    public int OwnerId { get; set; }

    /// <summary>
    /// Название документа.
    /// </summary>
    public string Title { get; set; }

    /// <summary>
    /// Размер документа в байтах.
    /// </summary>
    public int Size { get; set; }

    /// <summary>
    /// Расширение документа.
    /// </summary>
    public string Ext { get; set; }

    /// <summary>
    /// Url документа, по которому его можно загрузить.
    /// </summary>
    public string Url { get; set; }

    /// <summary>
    /// Дата добавления в формате Unixtime.
    /// </summary>
    public int Date { get; set; }

    /// <summary>
    /// Тип документа.
    /// </summary>
    public DocumentType Type { get; set; }

    /// <summary>
    /// Информация для предварительного просмотра документа.
    /// </summary>
    [JsonProperty]
    public Preview Preview { get; set; }

    /// <summary>
    /// Информация для предварительного просмотра документа.
    /// </summary>
    IPreview IDocument.Preview => Preview;
  }
}