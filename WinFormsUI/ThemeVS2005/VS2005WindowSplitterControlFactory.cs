using System.ComponentModel;
using System.Windows.Forms;
using KW.WinFormsUI.Docking;
using static KW.WinFormsUI.Docking.DockPanelExtender;

namespace KW.WinFormsUI.ThemeVS2005
{
    internal class VS2005WindowSplitterControlFactory : IWindowSplitterControlFactory
    {
        public SplitterBase CreateSplitterControl(ISplitterHost host)
        {
            return new VS2005WindowSplitterControl(host);
        }

        [ToolboxItem(false)]
        private class VS2005WindowSplitterControl : SplitterBase
        {
            private ISplitterHost _host;

            public VS2005WindowSplitterControl(ISplitterHost host)
            {
                _host = host;
            }

            protected override int SplitterSize
            {
                get { return _host.DockPanel.Theme.Measures.SplitterSize; }
            }

            protected override void StartDrag()
            {
                _host.DockPanel.BeginDrag(_host, ((Control)_host).RectangleToScreen(Bounds));
            }
        }
    }
}
