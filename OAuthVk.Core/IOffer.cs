using System.Security.Cryptography.X509Certificates;

namespace OAuthVk.Core
{
  public interface IOffer
  {
    int Id { get; set; }

    string Title { get; set; }

    string Instruction { get; set; }

    string InstructionHtml { get; set; }

    string ShortDescription { get; set; }

    string Description { get; set; }

    string Tag { get; set; }

    string ImgUrl { get; set; }

    double Price { get; set; }

    int LinkId { get; set; }

    string LinkType { get; set; }
  }
}