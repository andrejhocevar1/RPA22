﻿#pragma checksum "C:\RPA22\TestKontrolnikov\TestKontrolnikov\MainPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "309A9158E6C2CB964108AC2C270605D29097B4D084991647066173AFE1EE0353"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TestKontrolnikov
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
            case 2: // MainPage.xaml line 67
                {
                    this.mojToggleButton = (global::Windows.UI.Xaml.Controls.Primitives.ToggleButton)(target);
                }
                break;
            case 3: // MainPage.xaml line 87
                {
                    this.mojASB = (global::Windows.UI.Xaml.Controls.AutoSuggestBox)(target);
                    ((global::Windows.UI.Xaml.Controls.AutoSuggestBox)this.mojASB).TextChanged += this.mojASB_TextChanged;
                }
                break;
            case 4: // MainPage.xaml line 38
                {
                    this.mojFlyout = (global::Windows.UI.Xaml.Controls.Flyout)(target);
                }
                break;
            case 5: // MainPage.xaml line 41
                {
                    this.Innerbutton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.Innerbutton).Click += this.Innerbutton_Click;
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

