﻿#pragma checksum "C:\RPA22\Hamburger\Hamburger\MainPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "55AD6530231630F8520B48E1651CA8116EBB135CEB4CE7CE6524FB066A3EEDC8"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Hamburger
{
    partial class MainPage : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.19041.685")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 2: // MainPage.xaml line 19
                {
                    this.mojSplit = (global::Windows.UI.Xaml.Controls.SplitView)(target);
                }
                break;
            case 3: // MainPage.xaml line 22
                {
                    this.lstIkone = (global::Windows.UI.Xaml.Controls.ListBox)(target);
                    ((global::Windows.UI.Xaml.Controls.ListBox)this.lstIkone).SelectionChanged += this.lstIkone_SelectionChanged;
                }
                break;
            case 4: // MainPage.xaml line 23
                {
                    this.lbShare = (global::Windows.UI.Xaml.Controls.ListBoxItem)(target);
                }
                break;
            case 5: // MainPage.xaml line 29
                {
                    this.lbFav = (global::Windows.UI.Xaml.Controls.ListBoxItem)(target);
                }
                break;
            case 6: // MainPage.xaml line 38
                {
                    this.tbRezultat = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 7: // MainPage.xaml line 17
                {
                    this.btnHamburger = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.btnHamburger).Click += this.btnHamburger_Click;
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        /// <summary>
        /// GetBindingConnector(int connectionId, object target)
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.19041.685")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}

