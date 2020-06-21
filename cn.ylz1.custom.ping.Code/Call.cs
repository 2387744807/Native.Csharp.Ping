using Native.Csharp.Tool;
using Native.Tool.Http;
using Native.Tool.IniConfig;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace cn.ylz1.custom.ping.Code
{
    public static class Call
    {
        public static string Ping(string msg)
        {
            if (!IsOpen()) { return "未开启！"; }
            string ip = StrongString.GetRight(msg.Replace(" ", ""), "ping");
            Ping p = new Ping();
            PingReply reply = p.Send(ip);
            bool isDomain = IsDomain(ip);
            //获取地址
            byte[] data = HttpWebClient.Get($"https://www.ip.cn/?ip={reply.Address}");
            string str = Encoding.UTF8.GetString(data);
            string address = StrongString.Between(str,  "所在地理位置：<code>", "</code>");
            string result = (isDomain ? $"域名：{ip}\n" : "") + 
                $"IP：{reply.Address}\n延迟：{reply.RoundtripTime}ms\n地址：{address}\n当前时间：{DateTime.Now}";
            return result;
        }
        public static bool IsDomain(string str)
        {
            string pattern = @"^[a-zA-Z0-9][-a-zA-Z0-9]{0,62}(\.[a-zA-Z0-9][-a-zA-Z0-9]{0,62})+$";
            return IsMatch(pattern, str);
        }
        public static bool IsMatch(string expression, string str)
        {
            Regex reg = new Regex(expression);
            if (string.IsNullOrEmpty(str))
                return false;
            return reg.IsMatch(str);
        }
        public static string Record(string msg)
        {
            if (!IsOpen()) { return "未开启！"; }
            string host = StrongString.GetRight(msg.Replace(" ", ""), "查询备案");
            if (!IsDomain(host)) { return "查询失败，不是域名！"; }
            byte[] data = HttpWebClient.Post("http://whois.chinaz.com/ylz1.cn", Encoding.UTF8.GetBytes($"DomainName={host}&ws=&isforceupdate="));
            string str = Encoding.UTF8.GetString(data);
            string regTrade = StrongString.Between(str, "注册商</div><div class=\"fr WhLeList-right\"><div class=\"block ball\"><span>", "</span>");
            if (str.Contains("未被注册或被隐藏") || str.Contains("站长工具暂不支持") ||regTrade.Length>200) { return "该域名未被注册或被隐藏！"; }
            //string contact = StrongString.Between(str, "联系人</div><div class=\"fr WhLeList-right block ball lh24\"><span>", "</span>");
            //string email = StrongString.Between(str, "联系邮箱</div><div class=\"fr WhLeList-right block ball lh24\"><span>", "</span>");
            string createDate = StrongString.Between(str, "创建时间</div><div class=\"fr WhLeList-right\"><span>", "</span>");
            string deadline = StrongString.Between(str, "过期时间</div><div class=\"fr WhLeList-right\"><span>", "</span>");
            string state = StrongString.Between(str, "状态</div><div class=\"fr WhLeList-right clearfix\"><p class=\"lh30 pr tip-sh\"><span>", "(");
            string dns = StrongString.Between(str, "DNS</div><div class=\"fr WhLeList-right\">", "</div>").Replace("<br/>", "、");
            //return $"域名：{host}\n注册商：{regTrade}\n联系人：{contact}\n联系邮箱：{email}\n创建时间：{createDate}\n到期时间：{deadline}\n状态：{state}\ndns：{dns}";
            return $"域名：{host}\n注册商：{regTrade}\n创建时间：{createDate}\n到期时间：{deadline}\n状态：{state}\ndns：{dns}";
        }

        public static string Open(long uid)
        {
            if (!IsMaster(uid))
            {
                return "不是主人！";
            }
            IniConfig ini = new IniConfig(Common.CQApi.AppDirectory + "config.ini");
            ini.Load();
            ini.Object["System"]["Open"] = true;
            ini.Save();
            return "开启成功！";
        }

        public static string Close(long uid)
        {
            if (!IsMaster(uid))
            {
                return "不是主人！";
            }
            IniConfig ini = new IniConfig(Common.CQApi.AppDirectory + "config.ini");
            ini.Load();
            ini.Object["System"]["Open"] = false;
            ini.Save();
            return "关闭成功！";
        }

        public static bool IsMaster(long uid)
        {
            IniConfig ini = new IniConfig(Common.CQApi.AppDirectory + "config.ini");
            ini.Load();
            try
            {
                return ini.Object["System"]["Master"].ToString().Contains(uid.ToString());
            }
            catch { return false; }
        }

        public static bool IsOpen()
        {
            IniConfig ini = new IniConfig(Common.CQApi.AppDirectory + "config.ini");
            ini.Load();
            try
            {
                return ini.Object["System"]["Open"];
            }
            catch { return false; }
        }
    }
}
