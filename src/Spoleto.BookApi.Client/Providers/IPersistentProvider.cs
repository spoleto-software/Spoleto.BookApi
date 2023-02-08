using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Spoleto.BookApi.Interfaces.Models;

namespace Spoleto.BookApi.Client.Providers
{
    public interface IPersistentProvider
    {
        List<T> FindObject<T>(PersistentProviderOption settings, string dataBaseName, T objWithKeys, bool findDeleted, string[] includeAttributes = null) where T : PersistentObjectBase;

        Task<List<T>> FindObjectAsync<T>(PersistentProviderOption settings, string dataBaseName, T objWithKeys, bool findDeleted, string[] includeAttributes = null) where T : PersistentObjectBase;

        T LoadObject<T>(PersistentProviderOption settings, string dataBaseName, Guid objectKey, string[] includeAttributes = null) where T : PersistentObjectBase;

        Task<T> LoadObjectAsync<T>(PersistentProviderOption settings, string dataBaseName, Guid objectKey, string[] includeAttributes = null) where T : PersistentObjectBase;

        List<T> LoadObjectList<T>(PersistentProviderOption settings, string dataBaseName, object objectCriteria = null, string[] includeAttributes = null) where T : PersistentObjectBase;

        Task<List<T>> LoadObjectListAsync<T>(PersistentProviderOption settings, string dataBaseName, object objectCriteria = null, string[] includeAttributes = null) where T : PersistentObjectBase;

        T CreateObject<T>(PersistentProviderOption settings, string dataBaseName, T newObject) where T : PersistentObjectBase;

        Task<T> CreateObjectAsync<T>(PersistentProviderOption settings, string dataBaseName, T newObject) where T : PersistentObjectBase;

        T UpdateObject<T>(PersistentProviderOption settings, string dataBaseName, T updatedObject) where T : PersistentObjectBase;

        Task<T> UpdateObjectAsync<T>(PersistentProviderOption settings, string dataBaseName, T updatedObject) where T : PersistentObjectBase;

        T UpdateOnlyObject<T>(PersistentProviderOption settings, string dataBaseName, Guid updatingObjectId, Expression<Func<T>> updateFields) where T : PersistentObjectBase;

        Task<T> UpdateOnlyObjectAsync<T>(PersistentProviderOption settings, string dataBaseName, Guid updatingObjectId, Expression<Func<T>> updateFields) where T : PersistentObjectBase;

        T UpdateOnlyObject<T>(PersistentProviderOption settings, string dataBaseName, Guid updatingObjectId, Dictionary<string, object> updatingValues) where T : PersistentObjectBase;

        Task<T> UpdateOnlyObjectAsync<T>(PersistentProviderOption settings, string dataBaseName, Guid updatingObjectId, Dictionary<string, object> updatingValues) where T : PersistentObjectBase;

        void DeleteObject<T>(PersistentProviderOption settings, string dataBaseName, Guid id) where T : PersistentObjectBase;

        Task DeleteObjectAsync<T>(PersistentProviderOption settings, string dataBaseName, Guid id) where T : PersistentObjectBase;
    }
}
