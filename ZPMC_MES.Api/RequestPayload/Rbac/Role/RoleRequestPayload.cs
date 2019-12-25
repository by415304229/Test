﻿
using static ZPMC_MES.Api.Entities.Enums.CommonEnum;

namespace ZPMC_MES.Api.RequestPayload.Rbac.Role
{
    /// <summary>
    /// 
    /// </summary>
    public class RoleRequestPayload : RequestPayload
    {
        /// <summary>
        /// 是否已被删除
        /// </summary>
        public IsDeleted IsDeleted { get; set; }
        /// <summary>
        /// 状态
        /// </summary>
        public Status Status { get; set; }
    }
}
