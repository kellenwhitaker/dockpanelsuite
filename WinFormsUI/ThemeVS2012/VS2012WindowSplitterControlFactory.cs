using KW.WinFormsUI.Docking;

namespace KW.WinFormsUI.ThemeVS2012
{
    internal class VS2012WindowSplitterControlFactory : DockPanelExtender.IWindowSplitterControlFactory
    {
        public SplitterBase CreateSplitterControl(ISplitterHost host)
        {
            return new VS2012WindowSplitterControl(host);
        }
    }
}
