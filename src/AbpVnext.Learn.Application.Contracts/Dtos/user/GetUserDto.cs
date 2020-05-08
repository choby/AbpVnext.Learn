﻿using System;
using System.Collections.Generic;
using System.Text;

namespace AbpVnext.Learn.Dtos.user
{
    /// <summary>
    /// 获取用户信息的dto
    /// </summary>
    public class GetUserDto
    {
        /// <summary>
        /// 用户id
        /// </summary>
        public Guid userid { get; set; }
        
    }
}
