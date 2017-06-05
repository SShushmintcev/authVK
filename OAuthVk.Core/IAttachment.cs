using OAuthVk.Core.FileType;

namespace OAuthVk.Core
{
  public interface IAttachment
  {
    /// <summary>
    /// Тип вложения (photo, video, audio, doc, link, market, market_album, wall, wall_reply, sticker, gift).
    /// </summary>
    string Type { get; set; }

    /// <summary>
    /// Объект, представляющий медиавложение - Фотография (type = photo).
    /// </summary>
    IPhoto Photo { get; }

    /// <summary>
    /// Объект, представляющий медиавложение - Видеозапись (type = video).
    /// </summary>
    IVideo Video { get; }

    /// <summary>
    /// Объект, представляющий медиавложение - Аудиозапись (type = audio).
    /// </summary>
    IAudio Audio { get; }

    /// <summary>
    /// Объект, представляющий медиавложение - Документ (type = doc).
    /// </summary>
    IDocument Document { get; }

    /// <summary>
    /// Объект, представляющий медиавложение - Ссылка (type = link).
    /// </summary>
    ILink Link { get; }

    /// <summary>
    /// Объект, представляющий медиавложение - Заметка (type = note).
    /// </summary>
    INote Note { get; }

    /// <summary>
    /// Объект, представляющий медиавложение - Опрос (type = poll).
    /// </summary>
    IPoll Poll { get; }

    /// <summary>
    /// Объект, представляющий медиавложение - Вики-страница (type = page).
    /// </summary>
    IPage Page { get; }

    /// <summary>
    /// Объект, представляющий медиавложение - Товар (type = market).
    /// </summary>
    IMarket Market { get; }

    /// <summary>
    /// Объект, представляющий медиавложение - Подборка товаров (type = market_album).
    /// </summary>
    IMarketAlbum MarketAlbum { get; }

    /// <summary>
    /// Объект, представляющий медиавложение - Стикер (type = sticker).
    /// </summary>
    ISticker Sticker { get; }

    /// <summary>
    /// Объект, представляющий медиавложение - Запись на стене (type = wall).
    /// </summary>
    IWall Wall { get; }

    /// <summary>
    /// Объект, представляющий медиавложение - Комментарий на стене (type = wall_reply).
    /// </summary>
    IWallReply WallReply { get; }

    /// <summary>
    /// Объект, представляющий медиавложение - Подарок (type=gift).
    /// </summary>
    IGift Gift { get; }
  }
}