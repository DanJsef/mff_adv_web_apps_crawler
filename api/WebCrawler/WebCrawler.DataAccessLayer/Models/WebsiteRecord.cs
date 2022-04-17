
namespace WebCrawler.DataAccessLayer.Models
{
    public class WebsiteRecord
    {
        public int Id { get; set; }
        public string URL { get; set; }
        public string RegExp { get; set; }
        public DateTime Periodicity { get; set; }
        public string Label { get; set; }
        public bool Active { get; set; }
    }
}
