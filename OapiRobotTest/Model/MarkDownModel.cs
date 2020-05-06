using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OapiRobotTest.Model
{
    /// <summary>
    /// 此消息类型为固定markdown
    /// </summary>
    public class MarkDownModel
    {
        /// <summary>
        /// 此消息类型为固定markdown
        /// </summary>
        public string msgtype { get; set; }
        /// <summary>
        /// 消息内容
        /// </summary>
        public markdown markdown { get; set; }
        /// <summary>
        /// @人
        /// </summary>
        public atMarkdown at { get; set; }
    }

    /// <summary>
    /// 消息内容
    /// </summary>
    public class markdown
    {
        /// <summary>
        /// 标题
        /// </summary>
        public string title { get; set; }
        /// <summary>
        /// 消息内容
        /// </summary>
        public string text { get; set; }
    }
    /// <summary>
    /// @人
    /// </summary>
    public class atMarkdown
    {
        /// <summary>
        /// 被@人的手机号
        /// </summary>
        public List<string> atMobiles { get; set; }
        /// <summary>
        /// @所有人时:true,否则为:false
        /// </summary>
        public bool isAtAll { get; set; }
    }
}
