using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OapiRobotTest.Model
{
    /// <summary>
    /// 此消息类型为固定text
    /// </summary>
    public class TextModel
    {
        /// <summary>
        /// 此消息类型为固定text
        /// </summary>
        public string msgtype { get; set; }
        /// <summary>
        /// 消息内容
        /// </summary>
        public text text { get; set; }
        /// <summary>
        /// @人
        /// </summary>
        public atText at { get; set; }
    }
    /// <summary>
    /// 消息内容
    /// </summary>
    public class text
    {
        /// <summary>
        /// 消息内容
        /// </summary>
        public string content{get;set;}
    }
    /// <summary>
    /// @人
    /// </summary>
    public class atText
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
