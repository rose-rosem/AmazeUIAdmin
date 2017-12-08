using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using HankClassLibrary;

namespace NewStaffWeb.Views.Home
{
    public partial class Data : System.Web.Mvc.ViewPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Dictionary<String, String> dic = new Dictionary<string, string>();
            HankWcf.returnDsDt("后台_当天录题", dic);
            if (HankWcf.returnFlag == true)
            {
                DataTable dt = HankWcf.tempTable.Copy();
                int total = 0;
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    total += (int)dt.Rows[i][1];
                }
                DataRow rowTotal = dt.NewRow();
                rowTotal[0] = "合计";
                rowTotal[1] = total;
                dt.Rows.Add(rowTotal);
                GridView1.DataSource = dt;
                GridView1.DataBind();
                Label1.Text = "日期：" + DateTime.Now.ToString();

                查看全职题目修整情况();
                查看待整错题数();
                查看作业批改情况();
                查看学生做题情况();
            }
            else
            {
                hankFile.hankLog(HankWcf.wcfError);
            }
        }

        private void 查看待整错题数()
        {
            Dictionary<String, String> dic = new Dictionary<string, string>();
            HankWcf.returnDsDt("后台查看改错题", dic);
            DataTable dt = HankWcf.tempTable.Copy();
            GridView4.DataSource = dt;
            GridView4.DataBind();
        }


        private void 查看学生做题情况()
        {
            Dictionary<String, String> dic = new Dictionary<string, string>();
            HankWcf.returnDsDt("教师查看当天情况", dic);
            DataTable dt = HankWcf.tempTable.Copy();
            int total = 0;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                total += (int)dt.Rows[i][1];
            }
            DataRow rowTotal = dt.NewRow();
            rowTotal[2] = "合计";
            rowTotal[1] = total;
            rowTotal[0] = dt.Rows.Count;
            dt.Rows.Add(rowTotal);
            GridView3.DataSource = dt;
            GridView3.DataBind();
        }

        private void 查看全职题目修整情况()
        {
            Dictionary<String, String> dic = new Dictionary<string, string>();
            HankWcf.returnDsDt("后台查看全职题目整理记录", dic);
            DataTable dt = HankWcf.tempTable.Copy();
            GridView2.DataSource = dt;
            GridView2.DataBind();
        }

        private void 查看作业批改情况()
        {
            Dictionary<String, String> dic = new Dictionary<string, string>();
            HankWcf.returnDsDt("utool_revise", dic);
            DataTable dt = HankWcf.tempTable.Copy();
            GridViewRevise.DataSource = dt;
            GridViewRevise.DataBind();
        }
    }
}