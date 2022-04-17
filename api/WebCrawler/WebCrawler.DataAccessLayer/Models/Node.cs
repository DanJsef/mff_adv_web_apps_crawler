namespace WebCrawler.DataAccessLayer.Models
{
    public class Node
    {
        public int Id { get; set; } 
        public string Domain { get; set; }
        public IList<Node> Nodes { get; set; }
    }
}
