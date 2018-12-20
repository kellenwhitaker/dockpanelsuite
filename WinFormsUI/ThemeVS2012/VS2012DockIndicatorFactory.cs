﻿using KW.WinFormsUI.Docking;

namespace KW.WinFormsUI.ThemeVS2012
{
    internal class VS2012DockIndicatorFactory : DockPanelExtender.IDockIndicatorFactory
    {
        public DockPanel.DockDragHandler.DockIndicator CreateDockIndicator(DockPanel.DockDragHandler dockDragHandler)
        {
            return new DockPanel.DockDragHandler.DockIndicator(dockDragHandler) { Opacity = 0.7 };
        }
    }
}