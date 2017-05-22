using Newtonsoft.Json;
using OAuthVk.Core.FileType;

namespace OAuthVk.Model.FileType
{
  public class Video : IVideo
  {
    /// <summary>
    /// Идентификатор видеозаписи.
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// Идентификатор владельца видеозаписи.
    /// </summary>
    [JsonProperty("owner_id")]
    public int OwnerId { get; set; }

    /// <summary>
    /// Название видеозаписи.
    /// </summary>
    public string Title { get; set; }

    /// <summary>
    /// Текст описания видеозаписи.
    /// </summary>
    public string Description { get; set; }

    /// <summary>
    /// Длительность ролика в секундах.
    /// </summary>
    public int Duration { get; set; }

    /// <summary>
    /// URL изображения-обложки ролика с размером 130x98 px.
    /// </summary>
    [JsonProperty("photo_130")]
    public string Photo130 { get; set; }

    /// <summary>
    /// URL изображения-обложки ролика с размером 320x240 px.
    /// </summary>
    [JsonProperty("photo_320")]
    public string Photo320 { get; set; }

    /// <summary>
    ///  URL изображения-обложки ролика с размером 640x480 px.
    /// </summary>
    [JsonProperty("photo_640")]
    public string Photo640 { get; set; }

    /// <summary>
    ///  URL изображения-обложки ролика с размером 800x450 px.
    /// </summary>
    [JsonProperty("photo_800")]
    public string Photo800 { get; set; }

    /// <summary>
    /// Дата создания видеозаписи в формате Unixtime.
    /// </summary>
    public int Date { get; set; }

    /// <summary>
    /// Дата добавления видеозаписи пользователем или группой в формате Unixtime.
    /// </summary>
    [JsonProperty("adding_date")]
    public int AddingDate { get; set; }

    /// <summary>
    /// Количество просмотров видеозаписи.
    /// </summary>
    public int Views { get; set; }

    /// <summary>
    /// Количество комментариев к видеозаписи.
    /// </summary>
    public int Comments { get; set; }

    /// <summary>
    /// URL страницы с плеером, который можно использовать для воспроизведения ролика в браузере.
    /// Поддерживается flash и html5, плеер всегда масштабируется по размеру окна.
    /// </summary>
    public string Player { get; set; }

    /// <summary>
    /// Ключ доступа к объекту.
    /// </summary>
    [JsonProperty("access_key")]
    public string AccessKey { get; set; }

    /// <summary>
    /// Поле возвращается в том случае, если видеоролик находится в процессе обработки, всегда содержит 1.
    /// </summary>
    public int Processing { get; set; }

    /// <summary>
    /// Поле возвращается в том случае, если видеозапись является прямой трансляцией, всегда содержит 1.
    /// </summary>
    /// <remarks>Внимание, в этом случае в поле duration содержится значение 0.</remarks>
    public int Live { get; set; }
  }
}