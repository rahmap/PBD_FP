<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormTransaksi
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim StateProperties3 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties()
        Dim StateProperties4 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties()
        Dim StateProperties5 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties()
        Dim StateProperties6 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormTransaksi))
        Dim StateProperties1 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties()
        Dim StateProperties2 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties()
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.BunifuDragControl1 = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.PanelNav = New System.Windows.Forms.Panel()
        Me.btnMini = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnExit = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.HepiMart = New Bunifu.UI.WinForms.BunifuLabel()
        Me.PanelLeftSidebar = New System.Windows.Forms.Panel()
        Me.btnHome = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.BunifuProgressBar1 = New Bunifu.UI.WinForms.BunifuProgressBar()
        Me.btnDriver = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnMenu = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnPelanggan = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnTransaksi = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnPesanan = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnLogout = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DGVTransaksi = New Bunifu.UI.WinForms.BunifuDataGridView()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnTampil = New Bunifu.UI.WinForms.BunifuButton.BunifuButton()
        Me.btnHapus = New Bunifu.UI.WinForms.BunifuButton.BunifuButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnCari = New Bunifu.UI.WinForms.BunifuButton.BunifuButton()
        Me.DTPWaktu = New Bunifu.Framework.UI.BunifuDatepicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tbShowID = New System.Windows.Forms.TextBox()
        Me.PanelNav.SuspendLayout()
        Me.PanelLeftSidebar.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.DGVTransaksi, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 5
        Me.BunifuElipse1.TargetControl = Me
        '
        'BunifuDragControl1
        '
        Me.BunifuDragControl1.Fixed = True
        Me.BunifuDragControl1.Horizontal = True
        Me.BunifuDragControl1.TargetControl = Me.PanelNav
        Me.BunifuDragControl1.Vertical = True
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
        Me.PanelNav.Size = New System.Drawing.Size(1036, 45)
        Me.PanelNav.TabIndex = 2
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
        Me.btnMini.Location = New System.Drawing.Point(945, 4)
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
        Me.btnExit.Location = New System.Drawing.Point(987, 4)
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
        Me.HepiMart.Location = New System.Drawing.Point(505, 12)
        Me.HepiMart.Name = "HepiMart"
        Me.HepiMart.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.HepiMart.Size = New System.Drawing.Size(80, 23)
        Me.HepiMart.TabIndex = 3
        Me.HepiMart.Text = "Hepi Mart"
        Me.HepiMart.TextAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.HepiMart.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        '
        'PanelLeftSidebar
        '
        Me.PanelLeftSidebar.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.PanelLeftSidebar.Controls.Add(Me.btnHome)
        Me.PanelLeftSidebar.Controls.Add(Me.BunifuProgressBar1)
        Me.PanelLeftSidebar.Controls.Add(Me.btnDriver)
        Me.PanelLeftSidebar.Controls.Add(Me.btnMenu)
        Me.PanelLeftSidebar.Controls.Add(Me.btnPelanggan)
        Me.PanelLeftSidebar.Controls.Add(Me.btnTransaksi)
        Me.PanelLeftSidebar.Controls.Add(Me.btnPesanan)
        Me.PanelLeftSidebar.Controls.Add(Me.Panel1)
        Me.PanelLeftSidebar.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelLeftSidebar.Location = New System.Drawing.Point(0, 45)
        Me.PanelLeftSidebar.Name = "PanelLeftSidebar"
        Me.PanelLeftSidebar.Size = New System.Drawing.Size(175, 505)
        Me.PanelLeftSidebar.TabIndex = 3
        '
        'btnHome
        '
        Me.btnHome.Activecolor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.btnHome.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.btnHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnHome.BorderRadius = 0
        Me.btnHome.ButtonText = "Dashboard"
        Me.btnHome.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnHome.DisabledColor = System.Drawing.Color.Gray
        Me.btnHome.Iconcolor = System.Drawing.Color.Transparent
        Me.btnHome.Iconimage = CType(resources.GetObject("btnHome.Iconimage"), System.Drawing.Image)
        Me.btnHome.Iconimage_right = Nothing
        Me.btnHome.Iconimage_right_Selected = Nothing
        Me.btnHome.Iconimage_Selected = Nothing
        Me.btnHome.IconMarginLeft = 0
        Me.btnHome.IconMarginRight = 0
        Me.btnHome.IconRightVisible = True
        Me.btnHome.IconRightZoom = 0R
        Me.btnHome.IconVisible = True
        Me.btnHome.IconZoom = 90.0R
        Me.btnHome.IsTab = False
        Me.btnHome.Location = New System.Drawing.Point(-1, 42)
        Me.btnHome.Name = "btnHome"
        Me.btnHome.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.btnHome.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.btnHome.OnHoverTextColor = System.Drawing.Color.White
        Me.btnHome.selected = False
        Me.btnHome.Size = New System.Drawing.Size(176, 48)
        Me.btnHome.TabIndex = 22
        Me.btnHome.Text = "Dashboard"
        Me.btnHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnHome.Textcolor = System.Drawing.Color.Black
        Me.btnHome.TextFont = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'BunifuProgressBar1
        '
        Me.BunifuProgressBar1.Animation = 0
        Me.BunifuProgressBar1.AnimationStep = 10
        Me.BunifuProgressBar1.BackgroundImage = CType(resources.GetObject("BunifuProgressBar1.BackgroundImage"), System.Drawing.Image)
        Me.BunifuProgressBar1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.BunifuProgressBar1.BorderRadius = 5
        Me.BunifuProgressBar1.BorderThickness = 2
        Me.BunifuProgressBar1.Location = New System.Drawing.Point(-7, 451)
        Me.BunifuProgressBar1.MaximumValue = 100
        Me.BunifuProgressBar1.MinimumValue = 0
        Me.BunifuProgressBar1.Name = "BunifuProgressBar1"
        Me.BunifuProgressBar1.ProgressBackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.BunifuProgressBar1.ProgressColorLeft = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.BunifuProgressBar1.ProgressColorRight = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.BunifuProgressBar1.Size = New System.Drawing.Size(183, 10)
        Me.BunifuProgressBar1.TabIndex = 3
        Me.BunifuProgressBar1.Value = 0
        '
        'btnDriver
        '
        Me.btnDriver.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btnDriver.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.btnDriver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnDriver.BorderRadius = 0
        Me.btnDriver.ButtonText = "Driver"
        Me.btnDriver.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDriver.DisabledColor = System.Drawing.Color.Gray
        Me.btnDriver.Iconcolor = System.Drawing.Color.Transparent
        Me.btnDriver.Iconimage = CType(resources.GetObject("btnDriver.Iconimage"), System.Drawing.Image)
        Me.btnDriver.Iconimage_right = Nothing
        Me.btnDriver.Iconimage_right_Selected = Nothing
        Me.btnDriver.Iconimage_Selected = Nothing
        Me.btnDriver.IconMarginLeft = 0
        Me.btnDriver.IconMarginRight = 0
        Me.btnDriver.IconRightVisible = True
        Me.btnDriver.IconRightZoom = 0R
        Me.btnDriver.IconVisible = True
        Me.btnDriver.IconZoom = 90.0R
        Me.btnDriver.IsTab = False
        Me.btnDriver.Location = New System.Drawing.Point(0, 312)
        Me.btnDriver.Name = "btnDriver"
        Me.btnDriver.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.btnDriver.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.btnDriver.OnHoverTextColor = System.Drawing.Color.White
        Me.btnDriver.selected = False
        Me.btnDriver.Size = New System.Drawing.Size(175, 48)
        Me.btnDriver.TabIndex = 21
        Me.btnDriver.Text = "Driver"
        Me.btnDriver.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDriver.Textcolor = System.Drawing.Color.Black
        Me.btnDriver.TextFont = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold)
        '
        'btnMenu
        '
        Me.btnMenu.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btnMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.btnMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnMenu.BorderRadius = 0
        Me.btnMenu.ButtonText = "Menu"
        Me.btnMenu.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMenu.DisabledColor = System.Drawing.Color.Gray
        Me.btnMenu.Iconcolor = System.Drawing.Color.Transparent
        Me.btnMenu.Iconimage = CType(resources.GetObject("btnMenu.Iconimage"), System.Drawing.Image)
        Me.btnMenu.Iconimage_right = Nothing
        Me.btnMenu.Iconimage_right_Selected = Nothing
        Me.btnMenu.Iconimage_Selected = Nothing
        Me.btnMenu.IconMarginLeft = 0
        Me.btnMenu.IconMarginRight = 0
        Me.btnMenu.IconRightVisible = True
        Me.btnMenu.IconRightZoom = 0R
        Me.btnMenu.IconVisible = True
        Me.btnMenu.IconZoom = 90.0R
        Me.btnMenu.IsTab = False
        Me.btnMenu.Location = New System.Drawing.Point(0, 258)
        Me.btnMenu.Name = "btnMenu"
        Me.btnMenu.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.btnMenu.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.btnMenu.OnHoverTextColor = System.Drawing.Color.White
        Me.btnMenu.selected = False
        Me.btnMenu.Size = New System.Drawing.Size(175, 48)
        Me.btnMenu.TabIndex = 20
        Me.btnMenu.Text = "Menu"
        Me.btnMenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnMenu.Textcolor = System.Drawing.Color.Black
        Me.btnMenu.TextFont = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold)
        '
        'btnPelanggan
        '
        Me.btnPelanggan.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btnPelanggan.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.btnPelanggan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnPelanggan.BorderRadius = 0
        Me.btnPelanggan.ButtonText = "Pelanggan"
        Me.btnPelanggan.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPelanggan.DisabledColor = System.Drawing.Color.Gray
        Me.btnPelanggan.Iconcolor = System.Drawing.Color.Transparent
        Me.btnPelanggan.Iconimage = CType(resources.GetObject("btnPelanggan.Iconimage"), System.Drawing.Image)
        Me.btnPelanggan.Iconimage_right = Nothing
        Me.btnPelanggan.Iconimage_right_Selected = Nothing
        Me.btnPelanggan.Iconimage_Selected = Nothing
        Me.btnPelanggan.IconMarginLeft = 0
        Me.btnPelanggan.IconMarginRight = 0
        Me.btnPelanggan.IconRightVisible = True
        Me.btnPelanggan.IconRightZoom = 0R
        Me.btnPelanggan.IconVisible = True
        Me.btnPelanggan.IconZoom = 90.0R
        Me.btnPelanggan.IsTab = False
        Me.btnPelanggan.Location = New System.Drawing.Point(0, 204)
        Me.btnPelanggan.Name = "btnPelanggan"
        Me.btnPelanggan.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.btnPelanggan.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.btnPelanggan.OnHoverTextColor = System.Drawing.Color.White
        Me.btnPelanggan.selected = False
        Me.btnPelanggan.Size = New System.Drawing.Size(175, 48)
        Me.btnPelanggan.TabIndex = 19
        Me.btnPelanggan.Text = "Pelanggan"
        Me.btnPelanggan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPelanggan.Textcolor = System.Drawing.Color.Black
        Me.btnPelanggan.TextFont = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold)
        '
        'btnTransaksi
        '
        Me.btnTransaksi.Activecolor = System.Drawing.Color.SeaGreen
        Me.btnTransaksi.BackColor = System.Drawing.Color.SeaGreen
        Me.btnTransaksi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnTransaksi.BorderRadius = 0
        Me.btnTransaksi.ButtonText = "Transaksi"
        Me.btnTransaksi.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnTransaksi.DisabledColor = System.Drawing.Color.Gray
        Me.btnTransaksi.Iconcolor = System.Drawing.Color.Transparent
        Me.btnTransaksi.Iconimage = CType(resources.GetObject("btnTransaksi.Iconimage"), System.Drawing.Image)
        Me.btnTransaksi.Iconimage_right = Nothing
        Me.btnTransaksi.Iconimage_right_Selected = Nothing
        Me.btnTransaksi.Iconimage_Selected = Nothing
        Me.btnTransaksi.IconMarginLeft = 0
        Me.btnTransaksi.IconMarginRight = 0
        Me.btnTransaksi.IconRightVisible = True
        Me.btnTransaksi.IconRightZoom = 0R
        Me.btnTransaksi.IconVisible = True
        Me.btnTransaksi.IconZoom = 90.0R
        Me.btnTransaksi.IsTab = False
        Me.btnTransaksi.Location = New System.Drawing.Point(-1, 150)
        Me.btnTransaksi.Name = "btnTransaksi"
        Me.btnTransaksi.Normalcolor = System.Drawing.Color.SeaGreen
        Me.btnTransaksi.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.btnTransaksi.OnHoverTextColor = System.Drawing.Color.White
        Me.btnTransaksi.selected = False
        Me.btnTransaksi.Size = New System.Drawing.Size(176, 48)
        Me.btnTransaksi.TabIndex = 18
        Me.btnTransaksi.Text = "Transaksi"
        Me.btnTransaksi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnTransaksi.Textcolor = System.Drawing.Color.Black
        Me.btnTransaksi.TextFont = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold)
        '
        'btnPesanan
        '
        Me.btnPesanan.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btnPesanan.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.btnPesanan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnPesanan.BorderRadius = 0
        Me.btnPesanan.ButtonText = "Pesanan"
        Me.btnPesanan.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPesanan.DisabledColor = System.Drawing.Color.Gray
        Me.btnPesanan.Iconcolor = System.Drawing.Color.Transparent
        Me.btnPesanan.Iconimage = CType(resources.GetObject("btnPesanan.Iconimage"), System.Drawing.Image)
        Me.btnPesanan.Iconimage_right = Nothing
        Me.btnPesanan.Iconimage_right_Selected = Nothing
        Me.btnPesanan.Iconimage_Selected = Nothing
        Me.btnPesanan.IconMarginLeft = 0
        Me.btnPesanan.IconMarginRight = 0
        Me.btnPesanan.IconRightVisible = True
        Me.btnPesanan.IconRightZoom = 0R
        Me.btnPesanan.IconVisible = True
        Me.btnPesanan.IconZoom = 90.0R
        Me.btnPesanan.IsTab = False
        Me.btnPesanan.Location = New System.Drawing.Point(0, 96)
        Me.btnPesanan.Name = "btnPesanan"
        Me.btnPesanan.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.btnPesanan.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.btnPesanan.OnHoverTextColor = System.Drawing.Color.White
        Me.btnPesanan.selected = False
        Me.btnPesanan.Size = New System.Drawing.Size(175, 48)
        Me.btnPesanan.TabIndex = 17
        Me.btnPesanan.Text = "Pesanan"
        Me.btnPesanan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPesanan.Textcolor = System.Drawing.Color.Black
        Me.btnPesanan.TextFont = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnLogout)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 451)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(175, 54)
        Me.Panel1.TabIndex = 16
        '
        'btnLogout
        '
        Me.btnLogout.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btnLogout.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnLogout.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.btnLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnLogout.BorderRadius = 0
        Me.btnLogout.ButtonText = "Log Out"
        Me.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLogout.DisabledColor = System.Drawing.Color.Gray
        Me.btnLogout.Font = New System.Drawing.Font("Century Gothic", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogout.Iconcolor = System.Drawing.Color.Transparent
        Me.btnLogout.Iconimage = Nothing
        Me.btnLogout.Iconimage_right = Nothing
        Me.btnLogout.Iconimage_right_Selected = Nothing
        Me.btnLogout.Iconimage_Selected = Nothing
        Me.btnLogout.IconMarginLeft = 0
        Me.btnLogout.IconMarginRight = 0
        Me.btnLogout.IconRightVisible = True
        Me.btnLogout.IconRightZoom = 0R
        Me.btnLogout.IconVisible = True
        Me.btnLogout.IconZoom = 90.0R
        Me.btnLogout.IsTab = False
        Me.btnLogout.Location = New System.Drawing.Point(0, 4)
        Me.btnLogout.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.btnLogout.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.btnLogout.OnHoverTextColor = System.Drawing.Color.White
        Me.btnLogout.selected = False
        Me.btnLogout.Size = New System.Drawing.Size(176, 50)
        Me.btnLogout.TabIndex = 0
        Me.btnLogout.Text = "Log Out"
        Me.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnLogout.Textcolor = System.Drawing.Color.Black
        Me.btnLogout.TextFont = New System.Drawing.Font("Century Gothic", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(512, 262)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(143, 23)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Data Transaksi"
        '
        'DGVTransaksi
        '
        Me.DGVTransaksi.AllowCustomTheming = False
        Me.DGVTransaksi.AllowUserToAddRows = False
        Me.DGVTransaksi.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(198, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        Me.DGVTransaksi.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DGVTransaksi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGVTransaksi.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DGVTransaksi.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DGVTransaksi.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI Semibold", 11.75!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGVTransaksi.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DGVTransaksi.ColumnHeadersHeight = 40
        Me.DGVTransaksi.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(198, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DGVTransaksi.CurrentTheme.AlternatingRowsStyle.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.DGVTransaksi.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black
        Me.DGVTransaksi.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DGVTransaksi.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.White
        Me.DGVTransaksi.CurrentTheme.BackColor = System.Drawing.Color.DodgerBlue
        Me.DGVTransaksi.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DGVTransaksi.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue
        Me.DGVTransaksi.CurrentTheme.HeaderStyle.Font = New System.Drawing.Font("Segoe UI Semibold", 11.75!, System.Drawing.FontStyle.Bold)
        Me.DGVTransaksi.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.DGVTransaksi.CurrentTheme.Name = Nothing
        Me.DGVTransaksi.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DGVTransaksi.CurrentTheme.RowsStyle.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.DGVTransaksi.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.DGVTransaksi.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DGVTransaksi.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGVTransaksi.DefaultCellStyle = DataGridViewCellStyle3
        Me.DGVTransaksi.EnableHeadersVisualStyles = False
        Me.DGVTransaksi.GridColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DGVTransaksi.HeaderBackColor = System.Drawing.Color.DodgerBlue
        Me.DGVTransaksi.HeaderBgColor = System.Drawing.Color.Empty
        Me.DGVTransaksi.HeaderForeColor = System.Drawing.Color.White
        Me.DGVTransaksi.Location = New System.Drawing.Point(201, 297)
        Me.DGVTransaksi.Name = "DGVTransaksi"
        Me.DGVTransaksi.ReadOnly = True
        Me.DGVTransaksi.RowHeadersVisible = False
        Me.DGVTransaksi.RowTemplate.Height = 40
        Me.DGVTransaksi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGVTransaksi.Size = New System.Drawing.Size(805, 224)
        Me.DGVTransaksi.TabIndex = 5
        Me.DGVTransaksi.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.DodgerBlue
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btnTampil)
        Me.GroupBox3.Controls.Add(Me.btnHapus)
        Me.GroupBox3.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Italic)
        Me.GroupBox3.Location = New System.Drawing.Point(271, 116)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(246, 127)
        Me.GroupBox3.TabIndex = 15
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Pilihan"
        '
        'btnTampil
        '
        Me.btnTampil.BackColor = System.Drawing.Color.Transparent
        Me.btnTampil.BackgroundImage = CType(resources.GetObject("btnTampil.BackgroundImage"), System.Drawing.Image)
        Me.btnTampil.ButtonText = "Tampilkan Semua Data"
        Me.btnTampil.ButtonTextMarginLeft = 0
        Me.btnTampil.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnTampil.DisabledBorderColor = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.btnTampil.DisabledFillColor = System.Drawing.Color.Gray
        Me.btnTampil.DisabledForecolor = System.Drawing.Color.White
        Me.btnTampil.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!)
        Me.btnTampil.ForeColor = System.Drawing.Color.White
        Me.btnTampil.IconLeftCursor = System.Windows.Forms.Cursors.Hand
        Me.btnTampil.IconPadding = 10
        Me.btnTampil.IconRightCursor = System.Windows.Forms.Cursors.Hand
        Me.btnTampil.IdleBorderColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.btnTampil.IdleBorderRadius = 1
        Me.btnTampil.IdleBorderThickness = 1
        Me.btnTampil.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.btnTampil.IdleIconLeftImage = Nothing
        Me.btnTampil.IdleIconRightImage = Nothing
        Me.btnTampil.Location = New System.Drawing.Point(45, 79)
        Me.btnTampil.Name = "btnTampil"
        StateProperties3.BorderColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(221, Byte), Integer))
        StateProperties3.BorderRadius = 1
        StateProperties3.BorderThickness = 1
        StateProperties3.FillColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(221, Byte), Integer))
        StateProperties3.ForeColor = System.Drawing.Color.White
        StateProperties3.IconLeftImage = Nothing
        StateProperties3.IconRightImage = Nothing
        Me.btnTampil.onHoverState = StateProperties3
        StateProperties4.BorderColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(144, Byte), Integer))
        StateProperties4.BorderRadius = 1
        StateProperties4.BorderThickness = 1
        StateProperties4.FillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(144, Byte), Integer))
        StateProperties4.ForeColor = System.Drawing.Color.White
        StateProperties4.IconLeftImage = Nothing
        StateProperties4.IconRightImage = Nothing
        Me.btnTampil.OnPressedState = StateProperties4
        Me.btnTampil.Size = New System.Drawing.Size(157, 31)
        Me.btnTampil.TabIndex = 13
        Me.btnTampil.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnHapus
        '
        Me.btnHapus.BackColor = System.Drawing.Color.Transparent
        Me.btnHapus.BackgroundImage = CType(resources.GetObject("btnHapus.BackgroundImage"), System.Drawing.Image)
        Me.btnHapus.ButtonText = "Hapus Transaksi"
        Me.btnHapus.ButtonTextMarginLeft = 0
        Me.btnHapus.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnHapus.DisabledBorderColor = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.btnHapus.DisabledFillColor = System.Drawing.Color.Gray
        Me.btnHapus.DisabledForecolor = System.Drawing.Color.White
        Me.btnHapus.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!)
        Me.btnHapus.ForeColor = System.Drawing.Color.White
        Me.btnHapus.IconLeftCursor = System.Windows.Forms.Cursors.Hand
        Me.btnHapus.IconPadding = 10
        Me.btnHapus.IconRightCursor = System.Windows.Forms.Cursors.Hand
        Me.btnHapus.IdleBorderColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.btnHapus.IdleBorderRadius = 1
        Me.btnHapus.IdleBorderThickness = 1
        Me.btnHapus.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.btnHapus.IdleIconLeftImage = Nothing
        Me.btnHapus.IdleIconRightImage = Nothing
        Me.btnHapus.Location = New System.Drawing.Point(63, 25)
        Me.btnHapus.Name = "btnHapus"
        StateProperties5.BorderColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(221, Byte), Integer))
        StateProperties5.BorderRadius = 1
        StateProperties5.BorderThickness = 1
        StateProperties5.FillColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(221, Byte), Integer))
        StateProperties5.ForeColor = System.Drawing.Color.White
        StateProperties5.IconLeftImage = Nothing
        StateProperties5.IconRightImage = Nothing
        Me.btnHapus.onHoverState = StateProperties5
        StateProperties6.BorderColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(144, Byte), Integer))
        StateProperties6.BorderRadius = 1
        StateProperties6.BorderThickness = 1
        StateProperties6.FillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(144, Byte), Integer))
        StateProperties6.ForeColor = System.Drawing.Color.White
        StateProperties6.IconLeftImage = Nothing
        StateProperties6.IconRightImage = Nothing
        Me.btnHapus.OnPressedState = StateProperties6
        Me.btnHapus.Size = New System.Drawing.Size(119, 31)
        Me.btnHapus.TabIndex = 11
        Me.btnHapus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnCari)
        Me.GroupBox1.Controls.Add(Me.DTPWaktu)
        Me.GroupBox1.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Italic)
        Me.GroupBox1.Location = New System.Drawing.Point(575, 116)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(358, 127)
        Me.GroupBox1.TabIndex = 16
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Cari Berdasarkan Tanggal"
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
        Me.btnCari.Location = New System.Drawing.Point(133, 80)
        Me.btnCari.Name = "btnCari"
        StateProperties1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(221, Byte), Integer))
        StateProperties1.BorderRadius = 1
        StateProperties1.BorderThickness = 1
        StateProperties1.FillColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(221, Byte), Integer))
        StateProperties1.ForeColor = System.Drawing.Color.White
        StateProperties1.IconLeftImage = Nothing
        StateProperties1.IconRightImage = Nothing
        Me.btnCari.onHoverState = StateProperties1
        StateProperties2.BorderColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(144, Byte), Integer))
        StateProperties2.BorderRadius = 1
        StateProperties2.BorderThickness = 1
        StateProperties2.FillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(144, Byte), Integer))
        StateProperties2.ForeColor = System.Drawing.Color.White
        StateProperties2.IconLeftImage = Nothing
        StateProperties2.IconRightImage = Nothing
        Me.btnCari.OnPressedState = StateProperties2
        Me.btnCari.Size = New System.Drawing.Size(100, 31)
        Me.btnCari.TabIndex = 5
        Me.btnCari.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DTPWaktu
        '
        Me.DTPWaktu.BackColor = System.Drawing.Color.SkyBlue
        Me.DTPWaktu.BorderRadius = 0
        Me.DTPWaktu.ForeColor = System.Drawing.Color.White
        Me.DTPWaktu.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTPWaktu.FormatCustom = Nothing
        Me.DTPWaktu.Location = New System.Drawing.Point(31, 25)
        Me.DTPWaktu.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DTPWaktu.Name = "DTPWaktu"
        Me.DTPWaktu.Size = New System.Drawing.Size(303, 36)
        Me.DTPWaktu.TabIndex = 0
        Me.DTPWaktu.Value = New Date(2019, 7, 11, 0, 0, 0, 0)
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(873, 69)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(18, 13)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "ID"
        '
        'tbShowID
        '
        Me.tbShowID.Enabled = False
        Me.tbShowID.Location = New System.Drawing.Point(906, 66)
        Me.tbShowID.Name = "tbShowID"
        Me.tbShowID.Size = New System.Drawing.Size(100, 20)
        Me.tbShowID.TabIndex = 17
        '
        'FormTransaksi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(156, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1036, 550)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.tbShowID)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.DGVTransaksi)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PanelLeftSidebar)
        Me.Controls.Add(Me.PanelNav)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormTransaksi"
        Me.Text = "FormTransaksi"
        Me.PanelNav.ResumeLayout(False)
        Me.PanelNav.PerformLayout()
        Me.PanelLeftSidebar.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.DGVTransaksi, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents BunifuDragControl1 As Bunifu.Framework.UI.BunifuDragControl
    Friend WithEvents PanelNav As Panel
    Friend WithEvents btnMini As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btnExit As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents HepiMart As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents PanelLeftSidebar As Panel
    Friend WithEvents btnHome As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents BunifuProgressBar1 As Bunifu.UI.WinForms.BunifuProgressBar
    Friend WithEvents btnDriver As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btnMenu As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btnPelanggan As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btnTransaksi As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btnPesanan As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnLogout As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents Label1 As Label
    Friend WithEvents DGVTransaksi As Bunifu.UI.WinForms.BunifuDataGridView
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents btnTampil As Bunifu.UI.WinForms.BunifuButton.BunifuButton
    Friend WithEvents btnHapus As Bunifu.UI.WinForms.BunifuButton.BunifuButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents DTPWaktu As Bunifu.Framework.UI.BunifuDatepicker
    Friend WithEvents btnCari As Bunifu.UI.WinForms.BunifuButton.BunifuButton
    Friend WithEvents Label5 As Label
    Friend WithEvents tbShowID As TextBox
End Class
