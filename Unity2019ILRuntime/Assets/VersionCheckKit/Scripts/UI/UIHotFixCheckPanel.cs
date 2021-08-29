//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QFramework.Example
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using UnityEngine;
    using UnityEngine.UI;
    
    
    public class UIHotFixCheckPanelData : QFramework.UIPanelData
    {
        public string LocalVersion { get; set; }
        
        public string ServerVersion { get; set; }
        
        public Action OnCancel { get; set; }
        
        public Action OnOk { get; set; }
    }
    
    public partial class UIHotFixCheckPanel : QFramework.UIPanel
    {
        
        protected override void ProcessMsg(int eventId, QFramework.QMsg msg)
        {
            throw new System.NotImplementedException ();
        }
        
        protected override void OnInit(QFramework.IUIData uiData)
        {
            mData = uiData as UIHotFixCheckPanelData ?? new UIHotFixCheckPanelData();
            // please add init code here
            
            BtnUpdate.onClick.AddListener(() =>
            {
                mData.OnOk.InvokeGracefully();
            });

            BtnCancel.onClick.AddListener(() => { mData.OnCancel.InvokeGracefully(); });

            Content.text = "服务器版本:" + mData.ServerVersion + "\n本地版本:" + mData.LocalVersion;
        }
        
        protected override void OnOpen(QFramework.IUIData uiData)
        {
        }
        
        protected override void OnShow()
        {
        }
        
        protected override void OnHide()
        {
        }
        
        protected override void OnClose()
        {
        }
    }
}