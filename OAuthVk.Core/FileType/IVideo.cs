namespace OAuthVk.Core.FileType
{
  public interface IVideo
  {
    /// <summary>
    /// Идентификатор видеозаписи.
    /// </summary>
    int Id { get; set; }

    /// <summary>
    /// Идентификатор владельца видеозаписи.
    /// </summary>
    int OwnerId { get; set; }

    /// <summary>
    /// Название видеозаписи.
    /// </summary>
    string Title { get; set; }

    /// <summary>
    /// Текст описания видеозаписи.
    /// </summary>
    string Description { get; set; }

    /// <summary>
    /// Длительность ролика в секундах.
    /// </summary>
    int Duration { get; set; }

    /// <summary>
    /// URL изображения-обложки ролика с размером 130x98 px.
    /// </summary>
    string Photo130 { get; set; }

    /// <summary>
    /// URL изображения-обложки ролика с размером 320x240 px.
    /// </summary>
    string Photo320 { get; set; }

    /// <summary>
    ///  URL изображения-обложки ролика с размером 640x480 px.
    /// </summary>
    string Photo640 { get; set; }

    /// <summary>
    ///  URL изображения-обложки ролика с размером 800x450 px.
    /// </summary>
    string Photo800 { get; set; }

    /// <summary>
    /// Дата создания видеозаписи в формате Unixtime.
    /// </summary>
    int Date {get;set;}

    /// <summary>
    /// Дата добавления видеозаписи пользователем или группой в формате Unixtime.
    /// </summary>
    int AddingDate { get; set; }

    /// <summary>
    /// Количество просмотров видеозаписи.
    /// </summary>
    int Views { get; set; }

    /// <summary>
    /// Количество комментариев к видеозаписи.
    /// </summary>
    int Comments { get; set; }

    /// <summary>
    /// URL страницы с плеером, который можно использовать для воспроизведения ролика в браузере.
    /// Поддерживается flash и html5, плеер всегда масштабируется по размеру окна.
    /// </summary>
    string Player { get; set; }

    /// <summary>
    /// Ключ доступа к объекту.
    /// </summary>
    string AccessKey { get; set; }

    /// <summary>
    /// Поле возвращается в том случае, если видеоролик находится в процессе обработки, всегда содержит 1.
    /// </summary>
    int Processing { get; set; }

    /// <summary>
    /// Поле возвращается в том случае, если видеозапись является прямой трансляцией, всегда содержит 1.
    /// </summary>
    /// <remarks>Внимание, в этом случае в поле duration содержится значение 0.</remarks>
    int Live { get; set; }
  }
}