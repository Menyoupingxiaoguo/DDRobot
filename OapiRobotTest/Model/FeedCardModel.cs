/*----------------------------------------------------------------
* 项目名称 ：OapiRobotTest.Model
* 项目描述 ：
* 类 名 称 ：FeedCardModel
* 类 描 述 ：
* 所在的域 ：YANGKANG-PC
* 命名空间 ：OapiRobotTest.Model
* 机器名称 ：YANGKANG-PC 
* 作    者 ：Administrator
* 创建时间 ：2019/1/2 13:59:16
* 更新时间 ：2019/1/2 13:59:16
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
    /// <summary>
    /// FeedCard类型
    /// </summary>
    public class FeedCardModel
    {
        /// <summary>
        /// 此消息类型为固定feedCard
        /// </summary>
        public string msgtype { get; set; }
        /// <summary>
        /// feedCard类型
        /// </summary>
        public feedCard feedCard { get; set; }
    }
    /// <summary>
    /// feedCard类型
    /// </summary>
    public class feedCard
    {
        /// <summary>
        /// link消息
        /// </summary>
        public List<links> links { get; set; }
    }
    /// <summary>
    /// link消息
    /// </summary>
    public class links
    {
        /// <summary>
        /// 单条信息文本
        /// </summary>
        public string title { get; set; }
        /// <summary>
        /// 点击单条信息到跳转链接
        /// </summary>
        public string messageURL { get; set; }
        /// <summary>
        /// 单条信息后面图片的URL
        /// </summary>
        public string picURL { get; set; }
    }
}
