﻿using KW.WinFormsUI.Docking;

namespace KW.WinFormsUI.ThemeVS2013
{
    internal class VS2013DockPaneSplitterControlFactory : DockPanelExtender.IDockPaneSplitterControlFactory
    {
        public DockPane.SplitterControlBase CreateSplitterControl(DockPane pane)
        {
            return new VS2013SplitterControl(pane);
        }
    }
}
