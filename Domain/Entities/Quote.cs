using System.Net.Mime;
namespace Domain.Entities;
public class Quote
{
    public int Categoryid { get; set; }
    public int id { get; set; }
    public string? Author { get; set; }
    public string? QuoteText { get; set; }
}

