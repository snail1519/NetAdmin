using NetAdmin.Domain.Dto.Sys.Menu;

namespace NetAdmin.SysComponent.Application.Modules.Sys;

/// <summary>
///     菜单模块
/// </summary>
public interface IMenuModule : ICrudModule<CreateMenuReq, QueryMenuRsp // 创建类型
  , EditMenuReq                                                        // 编辑类型
  , QueryMenuReq, QueryMenuRsp                                         // 查询类型
  , DelReq                                                             // 删除类型
>
{
    /// <summary>
    ///     当前用户菜单
    /// </summary>
    Task<IEnumerable<QueryMenuRsp>> UserMenusAsync();
}