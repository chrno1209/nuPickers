using Umbraco.Core.Models.PublishedContent;
using System.Collections.Generic;
using System.Linq;
using Umbraco.Core.Models;
using Umbraco.Web;

namespace nuPickers.Extensions
{

    internal static class IEnumerableStringExtensions
    {
        /// <summary>
        /// TODO: migrate out of Picker obj
        /// parse a collection of strings, and attempt to return a collection of IPublishedContent
        /// </summary>
        /// <param name="keys"></param>
        /// <returns>a collection (populated, or empty)</returns>
        //internal static IEnumerable<IPublishedContent> AsPublishedContent(this IEnumerable<string> keys)
        //{
        //    UmbracoContext

        //    return keys
        //            .Select(x => umbracoHelper.GetPublishedContent(x))
        //            .Where(x => x != null);
        //}
    }
}