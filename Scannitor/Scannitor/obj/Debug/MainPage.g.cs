﻿#pragma checksum "C:\Users\yahon_000\Desktop\scannitor\Scannitor\Scannitor\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "8B4E2D30BB38620EED9B3C017ACB6DB5"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34011
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Microsoft.Phone.Controls;
using System;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Resources;
using System.Windows.Shapes;
using System.Windows.Threading;


namespace Scannitor {
    
    
    public partial class MainPage : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal Microsoft.Phone.Controls.PanoramaItem Scan;
        
        internal Microsoft.Phone.Controls.PanoramaItem Generate;
        
        internal System.Windows.Controls.TextBox txt;
        
        internal System.Windows.Controls.Button Generate1;
        
        internal System.Windows.Controls.Button Save;
        
        internal System.Windows.Controls.Button Open;
        
        internal Microsoft.Phone.Controls.PanoramaItem Help;
        
        internal Microsoft.Phone.Controls.PanoramaItem Browse;
        
        internal Microsoft.Phone.Controls.PanoramaItem About;
        
        internal Microsoft.Phone.Controls.PanoramaItem CopyRight;
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Windows.Application.LoadComponent(this, new System.Uri("/Scannitor;component/MainPage.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.Scan = ((Microsoft.Phone.Controls.PanoramaItem)(this.FindName("Scan")));
            this.Generate = ((Microsoft.Phone.Controls.PanoramaItem)(this.FindName("Generate")));
            this.txt = ((System.Windows.Controls.TextBox)(this.FindName("txt")));
            this.Generate1 = ((System.Windows.Controls.Button)(this.FindName("Generate1")));
            this.Save = ((System.Windows.Controls.Button)(this.FindName("Save")));
            this.Open = ((System.Windows.Controls.Button)(this.FindName("Open")));
            this.Help = ((Microsoft.Phone.Controls.PanoramaItem)(this.FindName("Help")));
            this.Browse = ((Microsoft.Phone.Controls.PanoramaItem)(this.FindName("Browse")));
            this.About = ((Microsoft.Phone.Controls.PanoramaItem)(this.FindName("About")));
            this.CopyRight = ((Microsoft.Phone.Controls.PanoramaItem)(this.FindName("CopyRight")));
        }
    }
}

