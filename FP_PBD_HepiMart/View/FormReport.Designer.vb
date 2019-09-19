<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormReport
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormReport))
        Dim StateProperties9 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties()
        Dim StateProperties10 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties()
        Dim StateProperties11 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties()
        Dim StateProperties12 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties()
        Me.PanelNav = New System.Windows.Forms.Panel()
        Me.btnMini = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnExit = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.HepiMart = New Bunifu.UI.WinForms.BunifuLabel()
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.btnCari = New Bunifu.UI.WinForms.BunifuButton.BunifuButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnShowAll = New Bunifu.UI.WinForms.BunifuButton.BunifuButton()
        Me.DTPWaktu = New Bunifu.Framework.UI.BunifuDatepicker()
        Me.BunifuDragControl1 = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.CRV = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.PanelNav.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelNav
        '
        Me.PanelNav.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.PanelNav.Controls.Add(Me.btnMini)
        Me.PanelNav.Controls.Add(Me.btnExit)
        Me.PanelNav.Controls.Add(Me.HepiMart)
        Me.PanelNav.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelNav.Location = New System.Drawing.Point(0, 0)
        Me.PanelNav.Name = "PanelNav"
        Me.PanelNav.Size = New System.Drawing.Size(1300, 45)
        Me.PanelNav.TabIndex = 4
        '
        'btnMini
        '
        Me.btnMini.Activecolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.btnMini.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.btnMini.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnMini.BorderRadius = 0
        Me.btnMini.ButtonText = ""
        Me.btnMini.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMini.DisabledColor = System.Drawing.Color.Gray
        Me.btnMini.Iconcolor = System.Drawing.Color.Transparent
        Me.btnMini.Iconimage = CType(resources.GetObject("btnMini.Iconimage"), System.Drawing.Image)
        Me.btnMini.Iconimage_right = Nothing
        Me.btnMini.Iconimage_right_Selected = Nothing
        Me.btnMini.Iconimage_Selected = Nothing
        Me.btnMini.IconMarginLeft = 0
        Me.btnMini.IconMarginRight = 0
        Me.btnMini.IconRightVisible = True
        Me.btnMini.IconRightZoom = 0R
        Me.btnMini.IconVisible = True
        Me.btnMini.IconZoom = 90.0R
        Me.btnMini.IsTab = False
        Me.btnMini.Location = New System.Drawing.Point(1200, 6)
        Me.btnMini.Name = "btnMini"
        Me.btnMini.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.btnMini.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.btnMini.OnHoverTextColor = System.Drawing.Color.White
        Me.btnMini.selected = False
        Me.btnMini.Size = New System.Drawing.Size(46, 39)
        Me.btnMini.TabIndex = 5
        Me.btnMini.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnMini.Textcolor = System.Drawing.Color.White
        Me.btnMini.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btnExit
        '
        Me.btnExit.Activecolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.btnExit.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnExit.BorderRadius = 0
        Me.btnExit.ButtonText = ""
        Me.btnExit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExit.DisabledColor = System.Drawing.Color.Gray
        Me.btnExit.Iconcolor = System.Drawing.Color.Transparent
        Me.btnExit.Iconimage = CType(resources.GetObject("btnExit.Iconimage"), System.Drawing.Image)
        Me.btnExit.Iconimage_right = Nothing
        Me.btnExit.Iconimage_right_Selected = Nothing
        Me.btnExit.Iconimage_Selected = Nothing
        Me.btnExit.IconMarginLeft = 0
        Me.btnExit.IconMarginRight = 0
        Me.btnExit.IconRightVisible = True
        Me.btnExit.IconRightZoom = 0R
        Me.btnExit.IconVisible = True
        Me.btnExit.IconZoom = 90.0R
        Me.btnExit.IsTab = False
        Me.btnExit.Location = New System.Drawing.Point(1242, 6)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.btnExit.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.btnExit.OnHoverTextColor = System.Drawing.Color.White
        Me.btnExit.selected = False
        Me.btnExit.Size = New System.Drawing.Size(46, 39)
        Me.btnExit.TabIndex = 4
        Me.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExit.Textcolor = System.Drawing.Color.White
        Me.btnExit.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'HepiMart
        '
        Me.HepiMart.AutoEllipsis = False
        Me.HepiMart.CursorType = Nothing
        Me.HepiMart.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.HepiMart.Location = New System.Drawing.Point(601, 12)
        Me.HepiMart.Name = "HepiMart"
        Me.HepiMart.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.HepiMart.Size = New System.Drawing.Size(80, 23)
        Me.HepiMart.TabIndex = 3
        Me.HepiMart.Text = "Hepi Mart"
        Me.HepiMart.TextAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.HepiMart.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 5
        Me.BunifuElipse1.TargetControl = Me
        '
        'btnCari
        '
        Me.btnCari.BackColor = System.Drawing.Color.Transparent
        Me.btnCari.BackgroundImage = CType(resources.GetObject("btnCari.BackgroundImage"), System.Drawing.Image)
        Me.btnCari.ButtonText = "Cari"
        Me.btnCari.ButtonTextMarginLeft = 0
        Me.btnCari.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCari.DisabledBorderColor = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.btnCari.DisabledFillColor = System.Drawing.Color.Gray
        Me.btnCari.DisabledForecolor = System.Drawing.Color.White
        Me.btnCari.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!)
        Me.btnCari.ForeColor = System.Drawing.Color.White
        Me.btnCari.IconLeftCursor = System.Windows.Forms.Cursors.Hand
        Me.btnCari.IconPadding = 10
        Me.btnCari.IconRightCursor = System.Windows.Forms.Cursors.Hand
        Me.btnCari.IdleBorderColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.btnCari.IdleBorderRadius = 1
        Me.btnCari.IdleBorderThickness = 1
        Me.btnCari.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.btnCari.IdleIconLeftImage = Nothing
        Me.btnCari.IdleIconRightImage = Nothing
        Me.btnCari.Location = New System.Drawing.Point(632, 20)
        Me.btnCari.Name = "btnCari"
        StateProperties9.BorderColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(221, Byte), Integer))
        StateProperties9.BorderRadius = 1
        StateProperties9.BorderThickness = 1
        StateProperties9.FillColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(221, Byte), Integer))
        StateProperties9.ForeColor = System.Drawing.Color.White
        StateProperties9.IconLeftImage = Nothing
        StateProperties9.IconRightImage = Nothing
        Me.btnCari.onHoverState = StateProperties9
        StateProperties10.BorderColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(144, Byte), Integer))
        StateProperties10.BorderRadius = 1
        StateProperties10.BorderThickness = 1
        StateProperties10.FillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(144, Byte), Integer))
        StateProperties10.ForeColor = System.Drawing.Color.White
        StateProperties10.IconLeftImage = Nothing
        StateProperties10.IconRightImage = Nothing
        Me.btnCari.OnPressedState = StateProperties10
        Me.btnCari.Size = New System.Drawing.Size(100, 36)
        Me.btnCari.TabIndex = 6
        Me.btnCari.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnShowAll)
        Me.Panel1.Controls.Add(Me.DTPWaktu)
        Me.Panel1.Controls.Add(Me.btnCari)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 45)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1300, 76)
        Me.Panel1.TabIndex = 7
        '
        'btnShowAll
        '
        Me.btnShowAll.BackColor = System.Drawing.Color.Transparent
        Me.btnShowAll.BackgroundImage = CType(resources.GetObject("btnShowAll.BackgroundImage"), System.Drawing.Image)
        Me.btnShowAll.ButtonText = "Tampilkan Semua"
        Me.btnShowAll.ButtonTextMarginLeft = 0
        Me.btnShowAll.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnShowAll.DisabledBorderColor = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.btnShowAll.DisabledFillColor = System.Drawing.Color.Gray
        Me.btnShowAll.DisabledForecolor = System.Drawing.Color.White
        Me.btnShowAll.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!)
        Me.btnShowAll.ForeColor = System.Drawing.Color.White
        Me.btnShowAll.IconLeftCursor = System.Windows.Forms.Cursors.Hand
        Me.btnShowAll.IconPadding = 10
        Me.btnShowAll.IconRightCursor = System.Windows.Forms.Cursors.Hand
        Me.btnShowAll.IdleBorderColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.btnShowAll.IdleBorderRadius = 1
        Me.btnShowAll.IdleBorderThickness = 1
        Me.btnShowAll.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.btnShowAll.IdleIconLeftImage = Nothing
        Me.btnShowAll.IdleIconRightImage = Nothing
        Me.btnShowAll.Location = New System.Drawing.Point(750, 20)
        Me.btnShowAll.Name = "btnShowAll"
        StateProperties11.BorderColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(221, Byte), Integer))
        StateProperties11.BorderRadius = 1
        StateProperties11.BorderThickness = 1
        StateProperties11.FillColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(221, Byte), Integer))
        StateProperties11.ForeColor = System.Drawing.Color.White
        StateProperties11.IconLeftImage = Nothing
        StateProperties11.IconRightImage = Nothing
        Me.btnShowAll.onHoverState = StateProperties11
        StateProperties12.BorderColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(144, Byte), Integer))
        StateProperties12.BorderRadius = 1
        StateProperties12.BorderThickness = 1
        StateProperties12.FillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(144, Byte), Integer))
        StateProperties12.ForeColor = System.Drawing.Color.White
        StateProperties12.IconLeftImage = Nothing
        StateProperties12.IconRightImage = Nothing
        Me.btnShowAll.OnPressedState = StateProperties12
        Me.btnShowAll.Size = New System.Drawing.Size(150, 36)
        Me.btnShowAll.TabIndex = 8
        Me.btnShowAll.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DTPWaktu
        '
        Me.DTPWaktu.BackColor = System.Drawing.Color.SkyBlue
        Me.DTPWaktu.BorderRadius = 0
        Me.DTPWaktu.ForeColor = System.Drawing.Color.White
        Me.DTPWaktu.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTPWaktu.FormatCustom = Nothing
        Me.DTPWaktu.Location = New System.Drawing.Point(311, 20)
        Me.DTPWaktu.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DTPWaktu.Name = "DTPWaktu"
        Me.DTPWaktu.Size = New System.Drawing.Size(303, 36)
        Me.DTPWaktu.TabIndex = 7
        Me.DTPWaktu.Value = New Date(2019, 7, 11, 0, 0, 0, 0)
        '
        'BunifuDragControl1
        '
        Me.BunifuDragControl1.Fixed = True
        Me.BunifuDragControl1.Horizontal = True
        Me.BunifuDragControl1.TargetControl = Me.PanelNav
        Me.BunifuDragControl1.Vertical = True
        '
        'CRV
        '
        Me.CRV.ActiveViewIndex = 0
        Me.CRV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CRV.Cursor = System.Windows.Forms.Cursors.Default
        Me.CRV.DisplayStatusBar = False
        Me.CRV.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CRV.Location = New System.Drawing.Point(0, 121)
        Me.CRV.Name = "CRV"
        Me.CRV.ReportSource = "C:\Users\asus\Documents\Visual Studio 2015\Projects\FP_PBD_HepiMart\Report\Lapora" &
    "nPendapatan.rpt"
        Me.CRV.Size = New System.Drawing.Size(1300, 635)
        Me.CRV.TabIndex = 8
        '
        'FormReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1300, 756)
        Me.Controls.Add(Me.CRV)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PanelNav)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormReport"
        Me.Text = "FormReport"
        Me.PanelNav.ResumeLayout(False)
        Me.PanelNav.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelNav As Panel
    Friend WithEvents btnMini As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btnExit As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents HepiMart As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents btnCari As Bunifu.UI.WinForms.BunifuButton.BunifuButton
    Friend WithEvents Panel1 As Panel
    Friend WithEvents DTPWaktu As Bunifu.Framework.UI.BunifuDatepicker
    Friend WithEvents btnShowAll As Bunifu.UI.WinForms.BunifuButton.BunifuButton
    Friend WithEvents BunifuDragControl1 As Bunifu.Framework.UI.BunifuDragControl
    Friend WithEvents CRV As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
