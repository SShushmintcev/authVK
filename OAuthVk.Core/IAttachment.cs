using OAuthVk.Core.FileType;

namespace OAuthVk.Core
{
  public interface IAttachment
  {
    /// <summary>
    /// Тип вложения (photo, video, audio, doc, link, market, market_album, wall, wall_reply, sticker, gift).
    /// </summary>
    string Type { get; set; }

    IPhoto Photo { get; }

    IVideo Video { get; }
  }
}