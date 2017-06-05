using Newtonsoft.Json;
using OAuthVk.Core;

namespace OAuthVk.Model
{
  public class Offer : IOffer
  {
    public int Id { get; set; }

    public string Title { get; set; }

    public string Instruction { get; set; }

    [JsonProperty("instruction_html")]
    public string InstructionHtml { get; set; }

    [JsonProperty("short_description")]
    public string ShortDescription { get; set; }

    public string Description { get; set; }

    public string Tag { get; set; }

    [JsonProperty("img")]
    public string ImgUrl { get; set; }

    public double Price { get; set; }

    [JsonProperty("link_id")]
    public int LinkId { get; set; }

    [JsonProperty("link_type")]
    public string LinkType { get; set; }

  }
}