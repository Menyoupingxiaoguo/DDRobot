/*----------------------------------------------------------------
* 项目名称 ：OapiRobotTest.Model
* 项目描述 ：
* 类 名 称 ：ActionCardOverallModel
* 类 描 述 ：
* 所在的域 ：YANGKANG-PC
* 命名空间 ：OapiRobotTest.Model
* 机器名称 ：YANGKANG-PC 
* 作    者 ：Administrator
* 创建时间 ：2019/1/2 9:40:42
* 更新时间 ：2019/1/2 9:40:42
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
    public class ActionCardOverallModel
    {
        /// <summary>
        /// 此消息类型为固定actionCard
        /// </summary>
        public string msgtype { get; set; }
        /// <summary>
        /// 整体跳转ActionCard类型
        /// </summary>
        public actionCard actionCard { get; set; }
    }
    /// <summary>
    /// 整体跳转ActionCard类型
    /// </summary>
    public class actionCard
    {
        /// <summary>
        /// 必须-首屏会话透出的展示内容
        /// </summary>
        public string title { get; set; }
        /// <summary>
        /// 必须-markdown格式的消息
        /// </summary>
        public string text { get; set; }
        /// <summary>
        /// 必须-单个按钮的方案。(设置此项和singleURL后btns无效。)
        /// </summary>
        public string singleTitle { get; set; }
        /// <summary>
        /// 必须-点击singleTitle按钮触发的URL
        /// </summary>
        public string singleURL { get; set; }
        /// <summary>
        /// 非必须-0-按钮竖直排列，1-按钮横向排列
        /// </summary>
        public string btnOrientation { get; set; }
        /// <summary>
        /// 非必须-0-正常发消息者头像,1-隐藏发消息者头像
        /// </summary>
        public string hideAvatar { get; set; }
    }
}
