using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Net.Http;
using System.Threading.Tasks;
using Spoleto.Common.Extensions;
using Spoleto.Common.Helpers;

namespace Spoleto.BookApi.Client.Providers
{
    public partial class PersistentProvider
    {
        List<T> IPersistentProvider.FindObject<T>(PersistentProviderOption settings, string dataBaseName, T objWithKeys, bool findDeleted, string[] includeAttributes)
            => Provider.FindObjectAsync(settings, dataBaseName, objWithKeys, findDeleted, includeAttributes).GetAwaiter().GetResult();

        async Task<List<T>> IPersistentProvider.FindObjectAsync<T>(PersistentProviderOption settings, string dataBaseName, T objWithKeys, bool findDeleted, string[] includeAttributes)
        {
            var sUri = $"{typeof(T)}/Find/{dataBaseName}/{findDeleted}";
            if (includeAttributes?.Length > 0)
                sUri += "?" + String.Join(",", includeAttributes.Select(x => "includeAttributes=" + x));

            var uri = new Uri(new Uri(settings.ServiceUrl), sUri);
            var jsonModel = JsonHelper.ToJson(objWithKeys);

            var obj = await InvokeAsync<List<T>>(settings, uri, HttpMethod.Post, jsonModel).ConfigureAwait(false);
            return obj;
        }

        T IPersistentProvider.LoadObject<T>(PersistentProviderOption settings, string dataBaseName, Guid objectKey, string[] includeAttributes)
            => Provider.LoadObjectAsync<T>(settings, dataBaseName, objectKey, includeAttributes).GetAwaiter().GetResult();


        async Task<T> IPersistentProvider.LoadObjectAsync<T>(PersistentProviderOption settings, string dataBaseName, Guid objectKey, string[] includeAttributes)
        {
            var sUri = $"api/{typeof(T).Name}/{dataBaseName}/{objectKey:D}";
            if (includeAttributes?.Length > 0)
                sUri += "?" + String.Join(",", includeAttributes.Select(x => "includeAttributes=" + x));

            var uri = new Uri(new Uri(settings.ServiceUrl), sUri);

            var obj = await InvokeAsync<T>(settings, uri, HttpMethod.Get).ConfigureAwait(false);

            return obj;
        }

        List<T> IPersistentProvider.LoadObjectList<T>(PersistentProviderOption settings, string dataBaseName, object objectCriteria, string[] includeAttributes)
            => Provider.LoadObjectListAsync<T>(settings, dataBaseName, objectCriteria, includeAttributes).GetAwaiter().GetResult();

        async Task<List<T>> IPersistentProvider.LoadObjectListAsync<T>(PersistentProviderOption settings, string dataBaseName, object objectCriteria, string[] includeAttributes)
        {
            var sUri = $"api/{typeof(T).Name}/GetObjectList/{dataBaseName}";
            //if (objectCriteria.Rows > 0)
            //    sUri += $"/{objectCriteria.Rows}";
            //if (objectCriteria.Offset > 0)
            //    sUri += $"/{objectCriteria.Offset}";
            //if (includeAttributes?.Length > 0)
            //    sUri += "?" + String.Join(",", includeAttributes.Select(x => "includeAttributes=" + x));

            var uri = new Uri(new Uri(settings.ServiceUrl), sUri);

            //var jsonModel = JsonHelper.ToJson(objectCriteria);
            var objList = await InvokeAsync<List<T>>(settings, uri, HttpMethod.Get);

            return objList;
        }

        T IPersistentProvider.CreateObject<T>(PersistentProviderOption settings, string dataBaseName, T newObject)
            => Provider.CreateObjectAsync(settings, dataBaseName, newObject).GetAwaiter().GetResult();

        async Task<T> IPersistentProvider.CreateObjectAsync<T>(PersistentProviderOption settings, string dataBaseName, T newObject)
        {
            var uri = new Uri(new Uri(settings.ServiceUrl), $"api/{typeof(T).Name}/{dataBaseName}");

            var jsonModel = JsonHelper.ToJson(newObject);
            var obj = await InvokeAsync<T>(settings, uri, HttpMethod.Post, jsonModel).ConfigureAwait(false);

            return obj;
        }

        T IPersistentProvider.UpdateObject<T>(PersistentProviderOption settings, string dataBaseName, T updatedObject)
            => Provider.UpdateObjectAsync(settings, dataBaseName, updatedObject).GetAwaiter().GetResult();


        async Task<T> IPersistentProvider.UpdateObjectAsync<T>(PersistentProviderOption settings, string dataBaseName, T updatedObject)
        {
            var uri = new Uri(new Uri(settings.ServiceUrl), $"api/{typeof(T).Name}/{dataBaseName}");

            var jsonModel = JsonHelper.ToJson(updatedObject);
            var obj = await InvokeAsync<T>(settings, uri, HttpMethod.Put, jsonModel).ConfigureAwait(false);

            return obj;
        }

        T IPersistentProvider.UpdateOnlyObject<T>(PersistentProviderOption settings, string dataBaseName, Guid updatingObjectId, Expression<Func<T>> updateFields)
            => Provider.UpdateOnlyObjectAsync<T>(settings, dataBaseName, updatingObjectId, updateFields).GetAwaiter().GetResult();


        async Task<T> IPersistentProvider.UpdateOnlyObjectAsync<T>(PersistentProviderOption settings, string dataBaseName, Guid updatingObjectId, Expression<Func<T>> updateFields)
        {
            var uri = new Uri(new Uri(settings.ServiceUrl), $"api/{typeof(T).Name}/{dataBaseName}/{updatingObjectId:D}");

            var updatingValues = updateFields.ToDictionaryValues();
            var jsonModel = JsonHelper.ToJson(updatingValues);
            var obj = await InvokeAsync<T>(settings, uri, new HttpMethod("PATCH"), jsonModel).ConfigureAwait(false);

            return obj;
        }

        T IPersistentProvider.UpdateOnlyObject<T>(PersistentProviderOption settings, string dataBaseName, Guid updatingObjectId, Dictionary<string, object> updatingValues)
            => Provider.UpdateOnlyObjectAsync<T>(settings, dataBaseName, updatingObjectId, updatingValues).GetAwaiter().GetResult();


        async Task<T> IPersistentProvider.UpdateOnlyObjectAsync<T>(PersistentProviderOption settings, string dataBaseName, Guid updatingObjectId, Dictionary<string, object> updatingValues)
        {
            var uri = new Uri(new Uri(settings.ServiceUrl), $"api/{typeof(T).Name}/{dataBaseName}");

            var jsonModel = JsonHelper.ToJson(updatingValues);
            var obj = await InvokeAsync<T>(settings, uri, HttpMethod.Put, jsonModel).ConfigureAwait(false);

            return obj;
        }

        void IPersistentProvider.DeleteObject<T>(PersistentProviderOption settings, string dataBaseName, Guid id)
            => Provider.DeleteObjectAsync<T>(settings, dataBaseName, id).GetAwaiter().GetResult();

        async Task IPersistentProvider.DeleteObjectAsync<T>(PersistentProviderOption settings, string dataBaseName, Guid id)
        {
            var uri = new Uri(new Uri(settings.ServiceUrl), $"api/{typeof(T).Name}/{dataBaseName}/{id:D}");

            await InvokeAsync<object>(settings, uri, HttpMethod.Delete).ConfigureAwait(false);
        }
    }
}
