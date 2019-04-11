using Umbraco.Core.Composing;
using Umbraco.Core.Events;
using Umbraco.Core.Models;
using Umbraco.Core.Services;
using Umbraco.Core.Services.Implement;

namespace nuPickers.Caching
{
    public class CacheInvalidationComponent : IComponent
    {
        // initialize: runs once when Umbraco starts
        public void Initialize()
        {
            ContentService.Saved += this.ContentService_Saved;
            ContentService.Deleted += this.ContentService_Deleted;

            DataTypeService.Saved += this.DataTypeService_Saved;
            DataTypeService.Deleted += this.DataTypeService_Deleted;
        }

        // terminate: runs once when Umbraco stops
        public void Terminate()
        {
        }

        private void ContentService_Saved(IContentService sender, SaveEventArgs<IContent> e)
        {
            foreach (var content in e.SavedEntities)
            {
                Cache.Instance.Remove(y => y.StartsWith(CacheConstants.PickedKeysPrefix + content.Id.ToString()));
            }
        }

        private void ContentService_Deleted(IContentService sender, DeleteEventArgs<IContent> e)
        {
            foreach (var content in e.DeletedEntities)
            {
                Cache.Instance.Remove(y => y.StartsWith(CacheConstants.PickedKeysPrefix + content.Id.ToString()));
            }
        }

        private void DataTypeService_Saved(IDataTypeService sender, SaveEventArgs<IDataType> e)
        {
            foreach (var dataType in e.SavedEntities)
            {
                Cache.Instance.Remove(CacheConstants.DataTypePreValuesPrefix + dataType.Id);
            }
        }

        private void DataTypeService_Deleted(IDataTypeService sender, DeleteEventArgs<IDataType> e)
        {
            foreach (var dataType in e.DeletedEntities)
            {
                Cache.Instance.Remove(CacheConstants.DataTypePreValuesPrefix + dataType.Id);
            }
        }
    }
}