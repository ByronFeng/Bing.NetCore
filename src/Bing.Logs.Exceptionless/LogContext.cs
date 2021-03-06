﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bing.Contexts;
using Bing.Logs.Internal;
using Bing.Utils.Helpers;

namespace Bing.Logs.Exceptionless
{
    /// <summary>
    /// Exceptionless日志上下文
    /// </summary>
    public class LogContext : Logs.Core.LogContext
    {
        /// <summary>
        /// 初始化一个<see cref="LogContext"/>类型的实例
        /// </summary>
        /// <param name="context">上下文</param>
        public LogContext(IContext context) : base(context)
        {
        }

        /// <summary>
        /// 创建日志上下文信息
        /// </summary>
        /// <returns></returns>
        protected override LogContextInfo CreateInfo()
        {
            return new LogContextInfo()
            {
                TraceId = Guid.NewGuid().ToString(),
                Stopwatch = GetStopwatch(),
                Url = Web.Url
            };
        }
    }
}
