Imports System.Windows
Imports System.Windows.Controls

Namespace DXDockingCommand

    ''' <summary>
    ''' Interaction logic for Window1.xaml
    ''' </summary>
    Public Partial Class Window1
        Inherits Window

        Public Sub New()
            Me.InitializeComponent()
            Me.dockManager1.DockController.Activate(Me.paneMessages)
        End Sub
    End Class
End Namespace
