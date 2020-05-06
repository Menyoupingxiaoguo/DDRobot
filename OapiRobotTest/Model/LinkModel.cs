/*----------------------------------------------------------------
* 项目名称 ：OapiRobotTest.Model
* 项目描述 ：
* 类 名 称 ：LinkModel
* 类 描 述 ：
* 所在的域 ：YANGKANG-PC
* 命名空间 ：OapiRobotTest.Model
* 机器名称 ：YANGKANG-PC 
* 作    者 ：Administrator
* 创建时间 ：2019/1/2 19:38:29
* 更新时间 ：2019/1/2 19:38:29
* 版 本 号 ：v1.0.0.0
*******************************************************************
* Copyright @ Administrator 2019. All rights reserved.
*******************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OapiRobotTest.Model
{
    public class LinkModel
    {
        /// <summary>
        /// 消息类型，此时固定为:link
        /// </summary>
        public string msgtype { get; set; }
        /// <summary>
        /// link类型消息
        /// </summary>
        public link link { get; set; }
    }

    public class link
    {
        /// <summary>
        /// 消息标题
        /// </summary>
        public string title { get; set; }
        /// <summary>
        /// 消息内容。如果太长只会部分展示
        /// </summary>
        public string text { get; set; }
        /// <summary>
        /// 点击消息跳转的URL
        /// </summary>
        public string messageUrl { get; set; }
        /// <summary>
        /// 图片URL
        /// </summary>
        public string picUrl { get; set; }
    }
}
