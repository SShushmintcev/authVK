namespace OAuthVk.Core.FileType
{
  public interface IGift
  {
    /// <summary>
    /// Идентификатор подарка.
    /// </summary>
    int Id { get; set; }

    /// <summary>
    /// URL изображения 48x48px.
    /// </summary>
    string Photo48 { get; set; }

    /// <summary>
    /// URL изображения 96x96px.
    /// </summary>
    string Photo96 { get; set; }

    /// <summary>
    /// URL изображения 256x256px.
    /// </summary>
    string Photo256 { get; set; }
  }
}