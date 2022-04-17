using WebCrawler.DataAccessLayer.Context;
using WebCrawler.BusinessLayer.DataTransferObjects;
using System.Linq;

namespace WebCrawler.BusinessLayer.Services
{
    public class RecordsService
    {
        private readonly AppDbContext db;

        public RecordsService(AppDbContext db)
        { 
            this.db = db;
        }

        public List<WebsiteRecordDTO> GetAllRecords()
        {
            var records = db.Records.ToList();

        }

    }
}
