<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128615391/21.1.5%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E1620)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->

# WPF Dock Layout Manager - Associate a DockLayoutManager's Command with a Button


The [DockLayoutManager](https://docs.devexpress.com/WPF/DevExpress.Xpf.Docking.DockLayoutManager) includes the [DockControllerCommand](https://docs.devexpress.com/WPF/DevExpress.Xpf.Docking.DockControllerCommand), which contains the following set of dock panel commands:

| Command | Description |
|-----|----|
| [Activate](https://docs.devexpress.com/WPF/DevExpress.Xpf.Docking.DockControllerCommand.Activate) | Activates a specific dock item. |
| [Close](https://docs.devexpress.com/WPF/DevExpress.Xpf.Docking.DockControllerCommand.Close) | Closes a specific dock item. |
| [Dock](https://docs.devexpress.com/WPF/DevExpress.Xpf.Docking.DockControllerCommand.Dock) | Docks a floating or an auto-hidden dock item. |
| [Float](https://docs.devexpress.com/WPF/DevExpress.Xpf.Docking.DockControllerCommand.Float) | Makes the specified item floating. |
| [Hide](https://docs.devexpress.com/WPF/DevExpress.Xpf.Docking.DockControllerCommand.Hide) | Enables the auto-hide functionality for the item/panel and hides it at a corresponding edge of the [DockLayoutManager](https://docs.devexpress.com/WPF/DevExpress.Xpf.Docking.DockLayoutManager) container. |
| [Restore](https://docs.devexpress.com/WPF/DevExpress.Xpf.Docking.DockControllerCommand.Restore) | Restores a closed (hidden) panel at its previous dock position. |

This example associates the [DockControllerCommand.Close](https://docs.devexpress.com/WPF/DevExpress.Xpf.Docking.DockControllerCommand.Close) command with a button. When a user clicks the button, the active dock panel is closed.

![image](https://user-images.githubusercontent.com/12169834/173897637-5f73cbb6-cc5f-43db-a8a6-4a5126d4eb3f.png)

<!-- default file list -->
## Files to Look At:

* [Window1.xaml](./CS/DXDockingCommand/Window1.xaml) (VB: [Window1.xaml](./VB/DXDockingCommand/Window1.xaml))
<!-- default file list end -->

## Documentation

- [Dock UI Items](https://docs.devexpress.com/WPF/7209/controls-and-libraries/layout-management/dock-windows/dock-items)
- [LayoutGroup](https://docs.devexpress.com/WPF/DevExpress.Xpf.Docking.LayoutGroup)
- [LayoutPanel](https://docs.devexpress.com/WPF/DevExpress.Xpf.Docking.LayoutPanel)
- [DockControllerCommand](https://docs.devexpress.com/WPF/DevExpress.Xpf.Docking.DockControllerCommand)

## More Examples

- [WPF Dock Layout Manager - Create a Simple Layout of Dock Panes](https://github.com/DevExpress-Examples/how-to-create-a-simple-layout-of-dock-panes-e1600)
- [WPF Dock Layout Manager - Create a Complex Layout of Dock Panels](https://github.com/DevExpress-Examples/how-to-create-a-complex-layout-of-dock-panels-e1663)
- [WPF Dock Layout Manager - Сreate a DocumentGroup with Two Tabs](https://github.com/DevExpress-Examples/how-to-create-a-documentgroup-with-two-tabs-e1670)
- [WPF Dock Layout Manager - Create Tabbed and Document Groups](https://github.com/DevExpress-Examples/how-to-create-a-tabbedgroup-and-documentgroup-groups-e1656)
