<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPelanggan
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
        Dim StateProperties1 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties()
        Dim StateProperties2 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormPelanggan))
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
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
        Me.BunifuDragControl1 = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnHapusPlg = New Bunifu.UI.WinForms.BunifuButton.BunifuButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DGVTransaksi = New Bunifu.UI.WinForms.BunifuDataGridView()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.DGVPelanggan = New Bunifu.UI.WinForms.BunifuDataGridView()
        Me.tbTotalHarga = New Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tbShowID = New System.Windows.Forms.TextBox()
        Me.PanelNav.SuspendLayout()
        Me.PanelLeftSidebar.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DGVTransaksi, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DGVPelanggan, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.PanelLeftSidebar.Size = New System.Drawing.Size(175, 590)
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
        Me.BunifuProgressBar1.Location = New System.Drawing.Point(-1, 536)
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
        Me.btnPelanggan.Activecolor = System.Drawing.Color.SeaGreen
        Me.btnPelanggan.BackColor = System.Drawing.Color.SeaGreen
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
        Me.btnPelanggan.Normalcolor = System.Drawing.Color.SeaGreen
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
        Me.btnTransaksi.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btnTransaksi.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(166, Byte), Integer))
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
        Me.btnTransaksi.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(166, Byte), Integer))
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
        Me.Panel1.Location = New System.Drawing.Point(0, 536)
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
        'BunifuDragControl1
        '
        Me.BunifuDragControl1.Fixed = True
        Me.BunifuDragControl1.Horizontal = True
        Me.BunifuDragControl1.TargetControl = Me.PanelNav
        Me.BunifuDragControl1.Vertical = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btnHapusPlg)
        Me.GroupBox3.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Italic)
        Me.GroupBox3.Location = New System.Drawing.Point(210, 102)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(184, 141)
        Me.GroupBox3.TabIndex = 15
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Pilihan"
        '
        'btnHapusPlg
        '
        Me.btnHapusPlg.BackColor = System.Drawing.Color.Transparent
        Me.btnHapusPlg.BackgroundImage = CType(resources.GetObject("btnHapusPlg.BackgroundImage"), System.Drawing.Image)
        Me.btnHapusPlg.ButtonText = "Hapus Pelanggan"
        Me.btnHapusPlg.ButtonTextMarginLeft = 0
        Me.btnHapusPlg.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnHapusPlg.DisabledBorderColor = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.btnHapusPlg.DisabledFillColor = System.Drawing.Color.Gray
        Me.btnHapusPlg.DisabledForecolor = System.Drawing.Color.White
        Me.btnHapusPlg.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!)
        Me.btnHapusPlg.ForeColor = System.Drawing.Color.White
        Me.btnHapusPlg.IconLeftCursor = System.Windows.Forms.Cursors.Hand
        Me.btnHapusPlg.IconPadding = 10
        Me.btnHapusPlg.IconRightCursor = System.Windows.Forms.Cursors.Hand
        Me.btnHapusPlg.IdleBorderColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.btnHapusPlg.IdleBorderRadius = 1
        Me.btnHapusPlg.IdleBorderThickness = 1
        Me.btnHapusPlg.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.btnHapusPlg.IdleIconLeftImage = Nothing
        Me.btnHapusPlg.IdleIconRightImage = Nothing
        Me.btnHapusPlg.Location = New System.Drawing.Point(17, 51)
        Me.btnHapusPlg.Name = "btnHapusPlg"
        StateProperties1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(221, Byte), Integer))
        StateProperties1.BorderRadius = 1
        StateProperties1.BorderThickness = 1
        StateProperties1.FillColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(221, Byte), Integer))
        StateProperties1.ForeColor = System.Drawing.Color.White
        StateProperties1.IconLeftImage = Nothing
        StateProperties1.IconRightImage = Nothing
        Me.btnHapusPlg.onHoverState = StateProperties1
        StateProperties2.BorderColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(144, Byte), Integer))
        StateProperties2.BorderRadius = 1
        StateProperties2.BorderThickness = 1
        StateProperties2.FillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(144, Byte), Integer))
        StateProperties2.ForeColor = System.Drawing.Color.White
        StateProperties2.IconLeftImage = Nothing
        StateProperties2.IconRightImage = Nothing
        Me.btnHapusPlg.OnPressedState = StateProperties2
        Me.btnHapusPlg.Size = New System.Drawing.Size(147, 48)
        Me.btnHapusPlg.TabIndex = 10
        Me.btnHapusPlg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DGVTransaksi)
        Me.GroupBox1.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(207, 342)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(796, 202)
        Me.GroupBox1.TabIndex = 16
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Daftar Pesanan"
        '
        'DGVTransaksi
        '
        Me.DGVTransaksi.AllowCustomTheming = False
        Me.DGVTransaksi.AllowUserToAddRows = False
        Me.DGVTransaksi.AllowUserToDeleteRows = False
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(198, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        Me.DGVTransaksi.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.DGVTransaksi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGVTransaksi.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DGVTransaksi.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DGVTransaksi.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.DodgerBlue
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI Semibold", 11.75!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGVTransaksi.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
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
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGVTransaksi.DefaultCellStyle = DataGridViewCellStyle6
        Me.DGVTransaksi.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGVTransaksi.EnableHeadersVisualStyles = False
        Me.DGVTransaksi.GridColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DGVTransaksi.HeaderBackColor = System.Drawing.Color.DodgerBlue
        Me.DGVTransaksi.HeaderBgColor = System.Drawing.Color.Empty
        Me.DGVTransaksi.HeaderForeColor = System.Drawing.Color.White
        Me.DGVTransaksi.Location = New System.Drawing.Point(3, 18)
        Me.DGVTransaksi.Name = "DGVTransaksi"
        Me.DGVTransaksi.ReadOnly = True
        Me.DGVTransaksi.RowHeadersVisible = False
        Me.DGVTransaksi.RowTemplate.Height = 40
        Me.DGVTransaksi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGVTransaksi.Size = New System.Drawing.Size(790, 181)
        Me.DGVTransaksi.TabIndex = 0
        Me.DGVTransaksi.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.DodgerBlue
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DGVPelanggan)
        Me.GroupBox2.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(422, 102)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(581, 222)
        Me.GroupBox2.TabIndex = 17
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Data Pelanggan"
        '
        'DGVPelanggan
        '
        Me.DGVPelanggan.AllowCustomTheming = False
        Me.DGVPelanggan.AllowUserToAddRows = False
        Me.DGVPelanggan.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(198, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        Me.DGVPelanggan.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DGVPelanggan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGVPelanggan.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DGVPelanggan.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DGVPelanggan.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI Semibold", 11.75!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGVPelanggan.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DGVPelanggan.ColumnHeadersHeight = 40
        Me.DGVPelanggan.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(198, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DGVPelanggan.CurrentTheme.AlternatingRowsStyle.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.DGVPelanggan.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black
        Me.DGVPelanggan.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DGVPelanggan.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.White
        Me.DGVPelanggan.CurrentTheme.BackColor = System.Drawing.Color.DodgerBlue
        Me.DGVPelanggan.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DGVPelanggan.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue
        Me.DGVPelanggan.CurrentTheme.HeaderStyle.Font = New System.Drawing.Font("Segoe UI Semibold", 11.75!, System.Drawing.FontStyle.Bold)
        Me.DGVPelanggan.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.DGVPelanggan.CurrentTheme.Name = Nothing
        Me.DGVPelanggan.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DGVPelanggan.CurrentTheme.RowsStyle.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.DGVPelanggan.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.DGVPelanggan.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DGVPelanggan.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGVPelanggan.DefaultCellStyle = DataGridViewCellStyle3
        Me.DGVPelanggan.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGVPelanggan.EnableHeadersVisualStyles = False
        Me.DGVPelanggan.GridColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DGVPelanggan.HeaderBackColor = System.Drawing.Color.DodgerBlue
        Me.DGVPelanggan.HeaderBgColor = System.Drawing.Color.Empty
        Me.DGVPelanggan.HeaderForeColor = System.Drawing.Color.White
        Me.DGVPelanggan.Location = New System.Drawing.Point(3, 18)
        Me.DGVPelanggan.Name = "DGVPelanggan"
        Me.DGVPelanggan.ReadOnly = True
        Me.DGVPelanggan.RowHeadersVisible = False
        Me.DGVPelanggan.RowTemplate.Height = 40
        Me.DGVPelanggan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGVPelanggan.Size = New System.Drawing.Size(575, 201)
        Me.DGVPelanggan.TabIndex = 0
        Me.DGVPelanggan.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.DodgerBlue
        '
        'tbTotalHarga
        '
        Me.tbTotalHarga.AcceptsReturn = False
        Me.tbTotalHarga.AcceptsTab = False
        Me.tbTotalHarga.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.tbTotalHarga.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.tbTotalHarga.BackColor = System.Drawing.Color.White
        Me.tbTotalHarga.BackgroundImage = CType(resources.GetObject("tbTotalHarga.BackgroundImage"), System.Drawing.Image)
        Me.tbTotalHarga.BorderColorActive = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(145, Byte), Integer))
        Me.tbTotalHarga.BorderColorDisabled = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.tbTotalHarga.BorderColorHover = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(157, Byte), Integer))
        Me.tbTotalHarga.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(107, Byte), Integer), CType(CType(107, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.tbTotalHarga.BorderRadius = 1
        Me.tbTotalHarga.BorderThickness = 2
        Me.tbTotalHarga.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.tbTotalHarga.DefaultFont = New System.Drawing.Font("Segoe UI", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbTotalHarga.DefaultText = ""
        Me.tbTotalHarga.Enabled = False
        Me.tbTotalHarga.FillColor = System.Drawing.Color.Gainsboro
        Me.tbTotalHarga.HideSelection = True
        Me.tbTotalHarga.IconLeft = CType(resources.GetObject("tbTotalHarga.IconLeft"), System.Drawing.Image)
        Me.tbTotalHarga.IconLeftCursor = System.Windows.Forms.Cursors.Default
        Me.tbTotalHarga.IconPadding = 10
        Me.tbTotalHarga.IconRight = Nothing
        Me.tbTotalHarga.IconRightCursor = System.Windows.Forms.Cursors.Default
        Me.tbTotalHarga.Location = New System.Drawing.Point(803, 561)
        Me.tbTotalHarga.MaxLength = 32767
        Me.tbTotalHarga.MinimumSize = New System.Drawing.Size(100, 35)
        Me.tbTotalHarga.Modified = False
        Me.tbTotalHarga.Name = "tbTotalHarga"
        Me.tbTotalHarga.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbTotalHarga.ReadOnly = False
        Me.tbTotalHarga.SelectedText = ""
        Me.tbTotalHarga.SelectionLength = 0
        Me.tbTotalHarga.SelectionStart = 0
        Me.tbTotalHarga.ShortcutsEnabled = True
        Me.tbTotalHarga.Size = New System.Drawing.Size(200, 48)
        Me.tbTotalHarga.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu
        Me.tbTotalHarga.TabIndex = 19
        Me.tbTotalHarga.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.tbTotalHarga.TextMarginLeft = 5
        Me.tbTotalHarga.TextPlaceholder = ""
        Me.tbTotalHarga.UseSystemPasswordChar = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(870, 75)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(18, 13)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "ID"
        '
        'tbShowID
        '
        Me.tbShowID.Enabled = False
        Me.tbShowID.Location = New System.Drawing.Point(903, 72)
        Me.tbShowID.Name = "tbShowID"
        Me.tbShowID.Size = New System.Drawing.Size(100, 20)
        Me.tbShowID.TabIndex = 20
        '
        'FormPelanggan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(156, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1036, 635)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.tbShowID)
        Me.Controls.Add(Me.tbTotalHarga)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.PanelLeftSidebar)
        Me.Controls.Add(Me.PanelNav)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormPelanggan"
        Me.Text = "FormPelanggan"
        Me.PanelNav.ResumeLayout(False)
        Me.PanelNav.PerformLayout()
        Me.PanelLeftSidebar.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DGVTransaksi, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DGVPelanggan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
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
    Friend WithEvents BunifuDragControl1 As Bunifu.Framework.UI.BunifuDragControl
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents btnHapusPlg As Bunifu.UI.WinForms.BunifuButton.BunifuButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents DGVPelanggan As Bunifu.UI.WinForms.BunifuDataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents DGVTransaksi As Bunifu.UI.WinForms.BunifuDataGridView
    Friend WithEvents tbTotalHarga As Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents tbShowID As TextBox
End Class
