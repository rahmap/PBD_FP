<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormToolsMenu
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormToolsMenu))
        Dim StateProperties1 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties()
        Dim StateProperties2 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.PanelNav = New System.Windows.Forms.Panel()
        Me.btnMini = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnExit = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.HepiMart = New Bunifu.UI.WinForms.BunifuLabel()
        Me.BunifuDragControl1 = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.btnAktifkanMenu = New Bunifu.UI.WinForms.BunifuButton.BunifuButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dataMenuTidakAktif = New Bunifu.UI.WinForms.BunifuDataGridView()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tbShowID = New System.Windows.Forms.TextBox()
        Me.PanelNav.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dataMenuTidakAktif, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 5
        Me.BunifuElipse1.TargetControl = Me
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
        Me.PanelNav.Size = New System.Drawing.Size(1111, 45)
        Me.PanelNav.TabIndex = 5
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
        Me.btnMini.Location = New System.Drawing.Point(1011, 3)
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
        Me.btnExit.Location = New System.Drawing.Point(1053, 3)
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
        Me.HepiMart.Location = New System.Drawing.Point(475, 12)
        Me.HepiMart.Name = "HepiMart"
        Me.HepiMart.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.HepiMart.Size = New System.Drawing.Size(80, 23)
        Me.HepiMart.TabIndex = 3
        Me.HepiMart.Text = "Hepi Mart"
        Me.HepiMart.TextAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.HepiMart.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        '
        'BunifuDragControl1
        '
        Me.BunifuDragControl1.Fixed = True
        Me.BunifuDragControl1.Horizontal = True
        Me.BunifuDragControl1.TargetControl = Me.PanelNav
        Me.BunifuDragControl1.Vertical = True
        '
        'btnAktifkanMenu
        '
        Me.btnAktifkanMenu.BackColor = System.Drawing.Color.Transparent
        Me.btnAktifkanMenu.BackgroundImage = CType(resources.GetObject("btnAktifkanMenu.BackgroundImage"), System.Drawing.Image)
        Me.btnAktifkanMenu.ButtonText = "Aktifkan Menu"
        Me.btnAktifkanMenu.ButtonTextMarginLeft = 0
        Me.btnAktifkanMenu.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAktifkanMenu.DisabledBorderColor = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.btnAktifkanMenu.DisabledFillColor = System.Drawing.Color.Gray
        Me.btnAktifkanMenu.DisabledForecolor = System.Drawing.Color.White
        Me.btnAktifkanMenu.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!)
        Me.btnAktifkanMenu.ForeColor = System.Drawing.Color.White
        Me.btnAktifkanMenu.IconLeftCursor = System.Windows.Forms.Cursors.Hand
        Me.btnAktifkanMenu.IconPadding = 10
        Me.btnAktifkanMenu.IconRightCursor = System.Windows.Forms.Cursors.Hand
        Me.btnAktifkanMenu.IdleBorderColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.btnAktifkanMenu.IdleBorderRadius = 1
        Me.btnAktifkanMenu.IdleBorderThickness = 1
        Me.btnAktifkanMenu.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.btnAktifkanMenu.IdleIconLeftImage = Nothing
        Me.btnAktifkanMenu.IdleIconRightImage = Nothing
        Me.btnAktifkanMenu.Location = New System.Drawing.Point(445, 73)
        Me.btnAktifkanMenu.Name = "btnAktifkanMenu"
        StateProperties1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(221, Byte), Integer))
        StateProperties1.BorderRadius = 1
        StateProperties1.BorderThickness = 1
        StateProperties1.FillColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(221, Byte), Integer))
        StateProperties1.ForeColor = System.Drawing.Color.White
        StateProperties1.IconLeftImage = Nothing
        StateProperties1.IconRightImage = Nothing
        Me.btnAktifkanMenu.onHoverState = StateProperties1
        StateProperties2.BorderColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(144, Byte), Integer))
        StateProperties2.BorderRadius = 1
        StateProperties2.BorderThickness = 1
        StateProperties2.FillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(144, Byte), Integer))
        StateProperties2.ForeColor = System.Drawing.Color.White
        StateProperties2.IconLeftImage = Nothing
        StateProperties2.IconRightImage = Nothing
        Me.btnAktifkanMenu.OnPressedState = StateProperties2
        Me.btnAktifkanMenu.Size = New System.Drawing.Size(150, 36)
        Me.btnAktifkanMenu.TabIndex = 10
        Me.btnAktifkanMenu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dataMenuTidakAktif)
        Me.GroupBox1.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(24, 134)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1055, 195)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Daftar Menu Tidak Aktif"
        '
        'dataMenuTidakAktif
        '
        Me.dataMenuTidakAktif.AllowCustomTheming = False
        Me.dataMenuTidakAktif.AllowUserToAddRows = False
        Me.dataMenuTidakAktif.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(198, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        Me.dataMenuTidakAktif.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dataMenuTidakAktif.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dataMenuTidakAktif.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dataMenuTidakAktif.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dataMenuTidakAktif.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI Semibold", 11.75!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dataMenuTidakAktif.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dataMenuTidakAktif.ColumnHeadersHeight = 40
        Me.dataMenuTidakAktif.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(198, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dataMenuTidakAktif.CurrentTheme.AlternatingRowsStyle.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.dataMenuTidakAktif.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black
        Me.dataMenuTidakAktif.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dataMenuTidakAktif.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.White
        Me.dataMenuTidakAktif.CurrentTheme.BackColor = System.Drawing.Color.DodgerBlue
        Me.dataMenuTidakAktif.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dataMenuTidakAktif.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue
        Me.dataMenuTidakAktif.CurrentTheme.HeaderStyle.Font = New System.Drawing.Font("Segoe UI Semibold", 11.75!, System.Drawing.FontStyle.Bold)
        Me.dataMenuTidakAktif.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dataMenuTidakAktif.CurrentTheme.Name = Nothing
        Me.dataMenuTidakAktif.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dataMenuTidakAktif.CurrentTheme.RowsStyle.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.dataMenuTidakAktif.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.dataMenuTidakAktif.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dataMenuTidakAktif.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dataMenuTidakAktif.DefaultCellStyle = DataGridViewCellStyle3
        Me.dataMenuTidakAktif.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dataMenuTidakAktif.EnableHeadersVisualStyles = False
        Me.dataMenuTidakAktif.GridColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dataMenuTidakAktif.HeaderBackColor = System.Drawing.Color.DodgerBlue
        Me.dataMenuTidakAktif.HeaderBgColor = System.Drawing.Color.Empty
        Me.dataMenuTidakAktif.HeaderForeColor = System.Drawing.Color.White
        Me.dataMenuTidakAktif.Location = New System.Drawing.Point(3, 18)
        Me.dataMenuTidakAktif.Name = "dataMenuTidakAktif"
        Me.dataMenuTidakAktif.ReadOnly = True
        Me.dataMenuTidakAktif.RowHeadersVisible = False
        Me.dataMenuTidakAktif.RowTemplate.Height = 40
        Me.dataMenuTidakAktif.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dataMenuTidakAktif.Size = New System.Drawing.Size(1049, 174)
        Me.dataMenuTidakAktif.TabIndex = 0
        Me.dataMenuTidakAktif.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.DodgerBlue
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(946, 65)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(18, 13)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "ID"
        '
        'tbShowID
        '
        Me.tbShowID.Enabled = False
        Me.tbShowID.Location = New System.Drawing.Point(979, 62)
        Me.tbShowID.Name = "tbShowID"
        Me.tbShowID.Size = New System.Drawing.Size(100, 20)
        Me.tbShowID.TabIndex = 12
        '
        'FormToolsMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(156, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1111, 353)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.tbShowID)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnAktifkanMenu)
        Me.Controls.Add(Me.PanelNav)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormToolsMenu"
        Me.Text = "FormToolsMenu"
        Me.PanelNav.ResumeLayout(False)
        Me.PanelNav.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dataMenuTidakAktif, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents PanelNav As Panel
    Friend WithEvents btnMini As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btnExit As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents HepiMart As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents BunifuDragControl1 As Bunifu.Framework.UI.BunifuDragControl
    Friend WithEvents btnAktifkanMenu As Bunifu.UI.WinForms.BunifuButton.BunifuButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents dataMenuTidakAktif As Bunifu.UI.WinForms.BunifuDataGridView
    Friend WithEvents Label5 As Label
    Friend WithEvents tbShowID As TextBox
End Class
