using NetAdmin.Application.Services.Tpl.Dependency;
using NetAdmin.Cache.Tpl.Dependency;
using NetAdmin.Domain.Dto.Dependency;
using NetAdmin.Domain.Dto.Tpl.Example;

namespace NetAdmin.Cache.Tpl;

/// <inheritdoc cref="IExampleCache" />
public sealed class ExampleCache(IDistributedCache cache, IExampleService service)
    : DistributedCache<IExampleService>(cache, service), IScoped, IExampleCache
{
    /// <inheritdoc />
    public Task<int> BulkDeleteAsync(BulkReq<DelReq> req)
    {
        return Service.BulkDeleteAsync(req);
    }

    /// <inheritdoc />
    public Task<long> CountAsync(QueryReq<QueryExampleReq> req)
    {
        return Service.CountAsync(req);
    }

    /// <inheritdoc />
    public Task<IOrderedEnumerable<KeyValuePair<IImmutableDictionary<string, string>, int>>> CountByAsync(QueryReq<QueryExampleReq> req)
    {
        return Service.CountByAsync(req);
    }

    /// <inheritdoc />
    public Task<QueryExampleRsp> CreateAsync(CreateExampleReq req)
    {
        return Service.CreateAsync(req);
    }

    /// <inheritdoc />
    public Task<int> DeleteAsync(DelReq req)
    {
        return Service.DeleteAsync(req);
    }

    /// <inheritdoc />
    public Task<QueryExampleRsp> EditAsync(EditExampleReq req)
    {
        return Service.EditAsync(req);
    }

    /// <inheritdoc />
    public Task<IActionResult> ExportAsync(QueryReq<QueryExampleReq> req)
    {
        return Service.ExportAsync(req);
    }

    /// <inheritdoc />
    public Task<QueryExampleRsp> GetAsync(QueryExampleReq req)
    {
        return Service.GetAsync(req);
    }

    /// <inheritdoc />
    public Task<PagedQueryRsp<QueryExampleRsp>> PagedQueryAsync(PagedQueryReq<QueryExampleReq> req)
    {
        return Service.PagedQueryAsync(req);
    }

    /// <inheritdoc />
    public Task<IEnumerable<QueryExampleRsp>> QueryAsync(QueryReq<QueryExampleReq> req)
    {
        return Service.QueryAsync(req);
    }
}