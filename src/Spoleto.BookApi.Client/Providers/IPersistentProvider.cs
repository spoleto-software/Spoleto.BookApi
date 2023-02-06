using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Spoleto.BookApi.Interfaces.Models;

namespace Spoleto.BookApi.Client.Providers
{
    public interface IPersistentProvider
    {
        List<T> FindObject<T>(PersistentProviderOption settings, string dataBaseName, T objWithKeys, bool findDeleted, string[] includeAttributes = null) where T : PersistentObjectBase
            => FindObjectAsync(settings, dataBaseName, objWithKeys, findDeleted, includeAttributes).GetAwaiter().GetResult();

        Task<List<T>> FindObjectAsync<T>(PersistentProviderOption settings, string dataBaseName, T objWithKeys, bool findDeleted, string[] includeAttributes = null) where T : PersistentObjectBase;

        T LoadObject<T>(PersistentProviderOption settings, string dataBaseName, Guid objectKey, string[] includeAttributes = null) where T : PersistentObjectBase
            => LoadObjectAsync<T>(settings, dataBaseName, objectKey, includeAttributes).GetAwaiter().GetResult();

        Task<T> LoadObjectAsync<T>(PersistentProviderOption settings, string dataBaseName, Guid objectKey, string[] includeAttributes = null) where T : PersistentObjectBase;

        List<T> LoadObjectList<T>(PersistentProviderOption settings, string dataBaseName, ObjectCriteria objectCriteria = null, string[] includeAttributes = null) where T : PersistentObjectBase
            => LoadObjectListAsync<T>(settings, dataBaseName, objectCriteria, includeAttributes).GetAwaiter().GetResult();

        Task<List<T>> LoadObjectListAsync<T>(PersistentProviderOption settings, string dataBaseName, ObjectCriteria objectCriteria = null, string[] includeAttributes = null) where T : PersistentObjectBase;

        T CreateObject<T>(PersistentProviderOption settings, string dataBaseName, T newObject) where T : PersistentObjectBase
            => CreateObjectAsync(settings, dataBaseName, newObject).GetAwaiter().GetResult();

        Task<T> CreateObjectAsync<T>(PersistentProviderOption settings, string dataBaseName, T newObject) where T : PersistentObjectBase;

        T UpdateObject<T>(PersistentProviderOption settings, string dataBaseName, T updatedObject) where T : PersistentObjectBase
            => UpdateObjectAsync(settings, dataBaseName, updatedObject).GetAwaiter().GetResult();

        Task<T> UpdateObjectAsync<T>(PersistentProviderOption settings, string dataBaseName, T updatedObject) where T : PersistentObjectBase;

        T UpdateOnlyObject<T>(PersistentProviderOption settings, string dataBaseName, Guid updatingObjectId, Expression<Func<T>> updateFields) where T : PersistentObjectBase
            => UpdateOnlyObjectAsync<T>(settings, dataBaseName, updatingObjectId, updateFields).GetAwaiter().GetResult();

        Task<T> UpdateOnlyObjectAsync<T>(PersistentProviderOption settings, string dataBaseName, Guid updatingObjectId, Expression<Func<T>> updateFields) where T : PersistentObjectBase;

        T UpdateOnlyObject<T>(PersistentProviderOption settings, string dataBaseName, Guid updatingObjectId, Dictionary<string, object> updatingValues) where T : PersistentObjectBase
            => UpdateOnlyObjectAsync<T>(settings, dataBaseName, updatingObjectId, updatingValues).GetAwaiter().GetResult();

        Task<T> UpdateOnlyObjectAsync<T>(PersistentProviderOption settings, string dataBaseName, Guid updatingObjectId, Dictionary<string, object> updatingValues) where T : PersistentObjectBase;

        void DeleteObject<T>(PersistentProviderOption settings, string dataBaseName, Guid id) where T : PersistentObjectBase
            => DeleteObjectAsync<T>(settings, dataBaseName, id).GetAwaiter().GetResult();

        Task DeleteObjectAsync<T>(PersistentProviderOption settings, string dataBaseName, Guid id) where T : PersistentObjectBase;
    }
}
