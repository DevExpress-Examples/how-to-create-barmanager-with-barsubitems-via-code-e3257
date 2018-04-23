Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Windows
Imports System.Windows.Controls
Imports System.Windows.Data
Imports System.Windows.Documents
Imports System.Windows.Input
Imports System.Windows.Media
Imports System.Windows.Media.Imaging
Imports System.Windows.Navigation
Imports System.Windows.Shapes
Imports DevExpress.Xpf.Docking
Imports DevExpress.Xpf.Bars
Imports DevExpress.Xpf.Docking.Customization
Imports DevExpress.Xpf.Layout.Core

Namespace WpfApplication38
	''' <summary>
	''' Interaction logic for Window1.xaml
	''' </summary>
	Partial Public Class Window1
		Inherits Window
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub Window_Loaded(ByVal sender As Object, ByVal e As RoutedEventArgs)
			Dim manager As New BarManager()
			manager.CreateStandardLayout = True
			Dim bar As New Bar()
			manager.Bars.Add(bar)
			Dim TempBarDockInfo As BarDockInfo = New BarDockInfo With {.ContainerType = BarContainerType.Top}
			bar.DockInfo = TempBarDockInfo


			Dim item1 As BarButtonItem = New BarButtonItem With {.Name = "item1", .IsVisible = True, .Content = "item1"}
			Dim item2 As BarButtonItem = New BarButtonItem With {.Name = "item2", .IsVisible = True, .Content = "item2"}

			Dim sub1 As New BarSubItem() With {.Name = "sub1", .Content = "sub1"}
			Dim sub2 As BarSubItem = New BarSubItem With {.Name = "sub2", .Content = "sub2"}



			sub1.ItemLinks.Add(item1)
			sub1.ItemLinks.Add(sub2)

			sub2.ItemLinks.Add(item2)

			manager.Items.Add(item1)
			manager.Items.Add(sub2)
			manager.Items.Add(item2)
			manager.Items.Add(sub1)

			bar.ItemLinks.Add(sub1)

			grid.Children.Add(manager)


		End Sub
	End Class
End Namespace
