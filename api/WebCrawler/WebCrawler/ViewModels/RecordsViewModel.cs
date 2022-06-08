using WebCrawler.BusinessLayer.Services;
using WebCrawler.BusinessLayer.DataTransferObjects;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace WebCrawler.Web.ViewModels
{
    public class RecordsViewModel : MasterPageViewModel
    {
        public readonly RecordsService recordsService;
        public List<WebsiteRecordDTO> AllWebsiteRecords { get; set; }
        public WebsiteRecordDTO newRecord { get; set; }
        public List<TagDTO> tagDTOs { get; set; }
        public TagDTO newTag { get; set; }

        public bool URLSort { get; set; }
        public bool LastCrawlingSort { get; set; }

        public RecordsViewModel(RecordsService recordsService)
        {
            this.recordsService = recordsService;
        }
        public override async Task PreRender()
        {
            if (!Context.IsPostBack)
            {
                AllWebsiteRecords = await recordsService.GetAllRecords();
                newRecord = new WebsiteRecordDTO();
                tagDTOs = new List<TagDTO>();
                newTag = new TagDTO();
            }
            await base.PreRender();
        }

        public void AddRecord()
        {

        }
        public async Task SaveNewRecord()
        {
            await recordsService.AddWebsiteRecord(newRecord, tagDTOs);
            newRecord = new WebsiteRecordDTO();
            tagDTOs = new List<TagDTO>();
            AllWebsiteRecords = await recordsService.GetAllRecords();
        }
        public void SaveNewTag()
        {
            if (newTag != null)
            {
                tagDTOs.Add(newTag);
                newTag = new TagDTO();
            }
        }

        public void CancelTag(TagDTO tag)
        {
            tagDTOs.Remove(tag);
        }

        public async Task DeleteRecord(WebsiteRecordDTO record)
        {
            await recordsService.DeleteWebsiteRecord(record);
            AllWebsiteRecords = await recordsService.GetAllRecords();
        }

        public async Task Sort()
        { 
            
        }

        public async Task Filter()
        { 
            
        }
    }
}

