using KW.WinFormsUI.Docking;

namespace KW.WinFormsUI.ThemeVS2013
{
    internal class VS2013DockPaneCaptionFactory : DockPanelExtender.IDockPaneCaptionFactory
    {
        public DockPaneCaptionBase CreateDockPaneCaption(DockPane pane)
        {
            return new VS2013DockPaneCaption(pane);
        }
    }
}
