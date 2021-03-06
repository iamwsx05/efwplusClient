﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EFWCoreLib.WinformFrame.Controller;
using MainUIFrame.Entity;
using System.Data;

namespace WinMainUIFrame.Winform.IView.RightManager
{
    public interface IfrmGroupMenu : IBaseView
    {
        void loadWorkers(DataTable dt, int defaultWorkID);
        int CurrWorkId { get; }

        void loadGroupGrid(List<BaseGroup> groupList);
        void loadMenuTree(List<BaseModule> moduleList, List<BaseMenu> menuList, List<BaseMenu> groupmenuList);

        int currGroupId { get; }
        BaseMenu currMenu { get; }
        bool panelPageEnabled { set; }
        void loadPageMenu(DataTable dt);
    }
}
