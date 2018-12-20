using KW.WinFormsUI.Docking;
using static KW.WinFormsUI.Docking.DockPanel.DockDragHandler;
using static KW.WinFormsUI.Docking.DockPanelExtender;

namespace KW.WinFormsUI.ThemeVS2005
{
    public class VS2005DockIndicatorFactory : IDockIndicatorFactory
    {
        public DockIndicator CreateDockIndicator(DockPanel.DockDragHandler dockDragHandler)
        {
            return new DockIndicator(dockDragHandler);
        }
    }
}
