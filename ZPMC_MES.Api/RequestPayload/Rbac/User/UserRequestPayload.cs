﻿
using ZPMC_MES.Api.Entities;
using static ZPMC_MES.Api.Entities.Enums.CommonEnum;

namespace ZPMC_MES.Api.RequestPayload.Rbac.User
{
    /// <summary>
    /// 
    /// </summary>
    public class UserRequestPayload : RequestPayload
    {
        /// <summary>
        /// 是否已被删除
        /// </summary>
        public IsDeleted IsDeleted { get; set; }
        /// <summary>
        /// 用户状态
        /// </summary>
        public UserStatus Status { get; set; }
    }
}
