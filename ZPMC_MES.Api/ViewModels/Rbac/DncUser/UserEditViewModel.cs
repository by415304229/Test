﻿
using ZPMC_MES.Api.Entities;
using System;
using static ZPMC_MES.Api.Entities.Enums.CommonEnum;

namespace ZPMC_MES.Api.ViewModels.Rbac.DncUser
{
    /// <summary>
    /// 
    /// </summary>
    public class UserEditViewModel
    {
        /// <summary>
        /// 
        /// </summary>
        public Guid Guid { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string LoginName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string DisplayName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Password { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Avatar { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public UserType UserType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public IsLocked IsLocked { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public UserStatus Status { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public IsDeleted IsDeleted { get; set; }
        /// <summary>
        /// 用户描述信息
        /// </summary>
        public string Description { get; set; }
    }
}
