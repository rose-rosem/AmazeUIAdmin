<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Data.aspx.cs" Inherits="NewStaffWeb.Views.Home.Data" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="utf-8" />
    <meta http-equiv="X-UA-Compatible" content="IE=edge" />
    <title>每日数据</title>
    <meta name="description" content="这是一个 data 页面" />
    <meta name="keywords" content="data" />
    <meta name="viewport" content="width=device-width, initial-scale=1" />
    <meta name="renderer" content="webkit" />
    <meta http-equiv="Cache-Control" content="no-siteapp" />
    <link rel="icon" type="image/png" href="~/assets/logoico.png" />
    <link rel="apple-touch-icon-precomposed" href="~/assets/logoico.png" />
    <meta name="apple-mobile-web-app-title" content="data" />


    <link rel="stylesheet" href="~/assets/css/amazeui.min.css" />
    <link rel="stylesheet" href="~/assets/css/amazeui.datatables.min.css" />
    <link rel="stylesheet" href="~/assets/css/app.css" />
    <link href="~/assets/css/dowload.css" rel="stylesheet" />
    <script src="/assets/js/jquery.min.js"></script>

</head>

<body data-type="index">
    <script src="/assets/js/theme.js"></script>
    <div class="am-g tpl-g">
        <!-- 头部 -->
        <header>
            <!-- logo -->
            <div class="am-fl tpl-header-logo">
                <a href="javascript:;">
                    <img src="/assets/img/logo.png" alt=""></a>
            </div>
            <!-- 右侧内容 -->
            <div class="tpl-header-fluid">
                <!-- 侧边切换 -->
                <div class="am-fl tpl-header-switch-button am-icon-list">
                    <span></span>
                </div>
                <!-- 搜索 -->
                <div class="am-fl tpl-header-search">
                    <form class="tpl-header-search-form" action="https://www.baidu.com/s" target="_blank" method="get">
                        <button class="tpl-header-search-btn am-icon-search" type="submit" name="search"></button>
                        <input class="tpl-header-search-box" placeholder="搜索内容..." type="text" name="wd">
                    </form>
                </div>
                <!-- 其它功能-->
                <div class="am-fr tpl-header-navbar">
                </div>
            </div>
        </header>
        <!-- 风格切换 -->
        <div class="tpl-skiner">
            <div class="tpl-skiner-toggle am-icon-cog">
            </div>
            <div class="tpl-skiner-content">
                <div class="tpl-skiner-content-title">
                    选择主题
                </div>
                <div class="tpl-skiner-content-bar">
                    <span class="skiner-color skiner-white" data-color="theme-white"></span>
                    <span class="skiner-color skiner-black" data-color="theme-black"></span>
                </div>
            </div>
        </div>
        <!-- 侧边导航栏 -->
        <div class="left-sidebar">
            <!-- 用户信息 -->
            <div class="tpl-sidebar-user-panel">
                <div class="tpl-user-panel-slide-toggleable">
                    <div class="tpl-user-panel-profile-picture">
                        <img src="/assets/img/user04.png" alt="">
                    </div>
                    <span class="user-panel-logged-in-text">
                        <i class="am-icon-circle-o am-text-success tpl-user-panel-status-icon"></i>
                        培洛科技
                    </span>
                    <a href="javascript:;" class="tpl-user-panel-action-link"><span class="am-icon-pencil"></span>账号设置</a>
                </div>
            </div>
            <!-- 菜单 -->
            <ul class="sidebar-nav">

                <li class="sidebar-nav-link">
                    <a href="/">
                        <i class="am-icon-home sidebar-nav-link-logo"></i>首页
                    </a>
                </li>
                <li class="sidebar-nav-link">
                    <a href="/Home/Download">
                        <i class="am-icon-wpforms sidebar-nav-link-logo"></i>下载
                    </a>
                </li>
                <li class="sidebar-nav-link">
                    <a href="/Home/Data">
                        <i class="am-icon-table sidebar-nav-link-logo"></i>每日数据
                    </a>
                </li>
                <li class="sidebar-nav-link">
                    <a href="/Home/Date">
                        <i class="am-icon-calendar sidebar-nav-link-logo"></i>教师排班

                    </a>
                </li>
                <li class="sidebar-nav-link">
                    <a href="#">
                        <i class="am-icon-wpforms sidebar-nav-link-logo"></i>客户表
                    </a>
                </li>
                <li class="sidebar-nav-link">
                    <a href="#">
                        <i class="am-icon-table sidebar-nav-link-logo"></i>通知表
                    </a>
                </li>

                <li class="sidebar-nav-link">
                    <a href="#">
                        <i class="am-icon-clone sidebar-nav-link-logo"></i>教师账号注册(unable)
                    </a>
                </li>
            </ul>
        </div>

        <!-- 内容区域 -->
        <div class="tpl-content-wrapper">
            <div class="container-fluid am-cf" style="padding-bottom: 20px !important;">
                <div class="row">
                    <div class="am-u-sm-12 am-u-md-12 am-u-lg-9">
                        <div class="page-header-heading"><span class="am-icon-home page-header-heading-icon"></span>后台首页 <small>BaconLocke</small></div>
                        <p class="page-header-description">培洛利用人工智能和大数据的优势, 实现比传统课堂更高效、更吸引学生的教学。包含学生学习的所有环。</p>
                    </div>
                    <div class="am-u-lg-3 tpl-index-settings-button">
                        <button type="button" class="page-header-button" style="padding: 16px !important;">
                            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
                        </button>
                    </div>
                </div>
            </div>
            <div class="row-content am-cf">
                <form id="form1" runat="server">
                    <div class="row-content am-cf" style="background: #fff;">

                        <div class="row am-cf">

                            <asp:ScriptManager ID="ScriptManager1" runat="server">
                            </asp:ScriptManager>
                            <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                                <ContentTemplate>
                                    <div class="am-u-sm-12 am-u-md-2">
                                        <p class="text-center">
                                            <strong>题目录入表</strong>
                                        </p>
                                        <asp:GridView ID="GridView1" runat="server">
                                        </asp:GridView>
                                    </div>
                                    <div class="am-u-sm-12 am-u-md-2">
                                        <p class="text-center">
                                            <strong>错题待改表</strong>
                                        </p>
                                        <asp:GridView ID="GridView4" runat="server">
                                        </asp:GridView>
                                    </div>
                                    <div class="am-u-sm-12 am-u-md-2">
                                        <p class="text-center">
                                            <strong>整题数量表</strong>
                                        </p>
                                        <asp:GridView ID="GridView2" runat="server">
                                        </asp:GridView>
                                    </div>
                                    <div class="am-u-sm-12 am-u-md-2">
                                        <p class="text-center">
                                            <strong>作业批改表</strong>
                                            <asp:GridView ID="GridViewRevise" runat="server">
                                            </asp:GridView>
                                        </p>
                                    </div>
                                    <div class="am-u-sm-12 am-u-md-4">
                                        <p class="text-center">
                                            <strong>学生做题数量表</strong>
                                        </p>
                                        <asp:GridView ID="GridView3" runat="server">
                                        </asp:GridView>
                                    </div>

                                </ContentTemplate>
                            </asp:UpdatePanel>

                        </div>
                    </div>
                </form>
            </div>
            <div style="font-size: 15px; text-align: center; margin-top: 10px; color: #b5b5b5;">
                Copyright &copy; 2016 BaconlockeAll rights reserved.</br>
                培洛科技 &nbsp;&nbsp;苏ICP备16037756号
            </div>
        </div>
    </div>

    <script src="/assets/js/amazeui.min.js"></script>
    <script src="/assets/js/amazeui.datatables.min.js"></script>
    <script src="/assets/js/dataTables.responsive.min.js"></script>
    <script src="/assets/js/app.js"></script>
</body>

</html>
