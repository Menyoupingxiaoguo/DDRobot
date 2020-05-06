/*----------------------------------------------------------------
* 项目名称 ：OapiRobotTest.Model
* 项目描述 ：
* 类 名 称 ：ActionCardSingleModel
* 类 描 述 ：
* 所在的域 ：YANGKANG-PC
* 命名空间 ：OapiRobotTest.Model
* 机器名称 ：YANGKANG-PC 
* 作    者 ：Administrator
* 创建时间 ：2019/1/2 13:39:15
* 更新时间 ：2019/1/2 13:39:15
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
    /// 独立跳转ActionCard类型
    /// </summary>
    public class ActionCardSingleModel
    {
        /// <summary>
        /// 此消息类型为固定actionCard
        /// </summary>
        public string msgtype { get; set; }
        /// <summary>
        /// 独立跳转ActionCard类型
        /// </summary>
        public actionCardSingle actionCard { get; set; }
    }
    /// <summary>
    /// 独立跳转ActionCard类型
    /// </summary>
    public class actionCardSingle
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
        /// 必须-按钮的信息：title-按钮方案，actionURL-点击按钮触发的URL
        /// </summary>
        public List<btns> btns { get; set; }
        /// <summary>
        /// 非必须-0-按钮竖直排列，1-按钮横向排列
        /// </summary>
        public string btnOrientation { get; set; }
        /// <summary>
        /// 非必须-0-正常发消息者头像,1-隐藏发消息者头像
        /// </summary>
        public string hideAvatar { get; set; }
    }

    /// <summary>
    /// 按钮的信息
    /// </summary>
    public class btns
    {
        /// <summary>
        /// 按钮方案
        /// </summary>
        public string title { get; set; }
        /// <summary>
        /// 点击按钮触发的URL
        /// </summary>
        public string actionURL { get; set; }
    }
}
