using System;
using Newtonsoft.Json;
using OAuthVk.Core;
using OAuthVk.Core.FileType;
using OAuthVk.Model.FileType;

namespace OAuthVk.Model
{
  [Serializable]
  public class Attachment : IAttachment
  {
    /// <summary>
    /// Тип вложения
    /// (photo, video, audio, doc, link, market, market_album, wall, wall_reply, sticker, gift).
    /// </summary>
    public string Type { get; set; }

    /// <summary>
    /// Объект, представляющий медиавложение - Фотография (type = photo).
    /// </summary>
    [JsonProperty]
    public Photo Photo { get; set; }

    /// <summary>
    /// Объект, представляющий медиавложение - Фотография (type = photo).
    /// </summary>
    IPhoto IAttachment.Photo => Photo;

    /// <summary>
    /// Объект, представляющий медиавложение - Видеозапись (type = video).
    /// </summary>
    [JsonProperty]
    public Video Video { get; set; }

    /// <summary>
    /// Объект, представляющий медиавложение - Видеозапись (type = video).
    /// </summary>
    IVideo IAttachment.Video => Video;

    /// <summary>
    /// Объект, представляющий медиавложение - Аудиозапись (type = audio).
    /// </summary>
    [JsonProperty]
    public Audio Audio { get; set; }

    /// <summary>
    /// Объект, представляющий медиавложение - Аудиозапись (type = audio).
    /// </summary>
    IAudio IAttachment.Audio => Audio;

    /// <summary>
    /// Объект, представляющий медиавложение - Документ (type = doc).
    /// </summary>
    [JsonProperty("doc")]
    public Document Document { get; set; }

    /// <summary>
    /// Объект, представляющий медиавложение - Документ (type = doc).
    /// </summary>
    IDocument IAttachment.Document => Document;

    /// <summary>
    /// Объект, представляющий медиавложение - Ссылка (type = link).
    /// </summary>
    [JsonProperty]
    public Link Link { get; set; }

    /// <summary>
    /// Объект, представляющий медиавложение - Заметка (type = note).
    /// </summary>
    [JsonProperty]
    public Note Note { get; set; }

    /// <summary>
    /// Объект, представляющий медиавложение - Заметка (type = note).
    /// </summary>
    INote IAttachment.Note => Note;

    /// <summary>
    /// Объект, представляющий медиавложение - Опрос (type = poll).
    /// </summary>
    [JsonProperty]
    public Poll Poll { get; set; }

    /// <summary>
    /// Объект, представляющий медиавложение - Опрос (type = poll).
    /// </summary>
    IPoll IAttachment.Poll => Poll;

    /// <summary>
    /// Объект, представляющий медиавложение - Вики-страница (type = page).
    /// </summary>
    [JsonProperty]
    public Page Page { get; set; }

    /// <summary>
    /// Объект, представляющий медиавложение - Вики-страница (type = page).
    /// </summary>
    IPage IAttachment.Page => Page;

    /// <summary>
    /// Объект, представляющий медиавложение - Ссылка (type = link).
    /// </summary>
    ILink IAttachment.Link => Link;

    /// <summary>
    /// Объект, представляющий медиавложение - Товар (type = market).
    /// </summary>
    [JsonProperty]
    public Market Market { get; set; }

    /// <summary>
    /// Объект, представляющий медиавложение - Товар (type = market).
    /// </summary>
    IMarket IAttachment.Market => Market;

    /// <summary>
    /// Объект, представляющий медиавложение - Подборка товаров (type = market_album).
    /// </summary>
    [JsonProperty("market_album")]
    public MarketAlbum MarketAlbum { get; set; }

    /// <summary>
    /// Объект, представляющий медиавложение - Подборка товаров (type = market_album).
    /// </summary>
    IMarketAlbum IAttachment.MarketAlbum => MarketAlbum;

    /// <summary>
    /// Объект, представляющий медиавложение - Стикер (type = sticker).
    /// </summary>
    [JsonProperty]
    public Sticker Sticker { get; set; }

    /// <summary>
    /// Объект, представляющий медиавложение - Стикер (type = sticker).
    /// </summary>
    ISticker IAttachment.Sticker => Sticker;

    /// <summary>
    /// Объект, представляющий медиавложение - Запись на стене (type = wall).
    /// </summary>
    [JsonProperty]
    public Wall Wall { get; set; }

    /// <summary>
    /// Объект, представляющий медиавложение - Запись на стене (type = wall).
    /// </summary>
    IWall IAttachment.Wall => Wall;

    /// <summary>
    /// Объект, представляющий медиавложение - Комментарий на стене (type = wall_reply).
    /// </summary>
    [JsonProperty("wall_reply")]
    public WallReply WallReply { get; set; }

    /// <summary>
    /// Объект, представляющий медиавложение - Комментарий на стене (type = wall_reply).
    /// </summary>
    IWallReply IAttachment.WallReply => WallReply;

    /// <summary>
    /// Объект, представляющий медиавложение - Подарок (type=gift).
    /// </summary>
    [JsonProperty]
    public Gift Gift { get; set; }

    /// <summary>
    /// Объект, представляющий медиавложение - Подарок (type=gift).
    /// </summary>
    IGift IAttachment.Gift => Gift;
  }
}