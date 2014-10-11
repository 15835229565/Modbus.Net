﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModBus.Net
{
    /// <summary>
    /// 协议字节伸缩
    /// </summary>
    public abstract class ProtocalLinkerBytesExtend
    {
        /// <summary>
        /// 协议扩展，协议内容发送前调用
        /// </summary>
        /// <param name="content">扩展前的原始协议内容</param>
        /// <returns>扩展后的协议内容</returns>
        public abstract byte[] BytesExtend(byte[] content);

        /// <summary>
        /// 协议收缩，协议内容接收后调用
        /// </summary>
        /// <param name="content">收缩前的完整协议内容</param>
        /// <returns>收缩后的协议内容</returns>
        public abstract byte[] BytesDecact(byte[] content);
    }
}