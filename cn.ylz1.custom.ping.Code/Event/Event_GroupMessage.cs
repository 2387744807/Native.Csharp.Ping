
using Native.Sdk.Cqp.EventArgs;
using Native.Sdk.Cqp.Interface;
using Native.Sdk.Cqp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cn.ylz1.custom.ping.Code.Event
{
    public class Event_GroupMessage : IGroupMessage
    {
        /// <summary>
        /// 收到群消息
        /// </summary>
        /// <param name="sender">事件来源</param>
        /// <param name="e">事件参数</param>
        public void GroupMessage(object sender, CQGroupMessageEventArgs e)
        {
            if (e.Message.Text.StartsWith("查询备案"))
            {
                e.FromGroup.SendGroupMessage(Call.Record(e.Message.Text));
            }
            else if (e.Message.Text.StartsWith("ping"))
            {
                e.FromGroup.SendGroupMessage(Call.Ping(e.Message.Text));
            }
            else if (e.Message.Text == "开启ping")
            {
                e.FromGroup.SendGroupMessage(Call.Open(e.FromQQ.Id));
            }
            else if (e.Message.Text == "关闭ping")
            {
                e.FromGroup.SendGroupMessage(Call.Close(e.FromQQ.Id));
            }
        }
    }
}
