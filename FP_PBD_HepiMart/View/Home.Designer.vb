<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Home
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Home))
        Dim StateProperties1 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties()
        Dim StateProperties2 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties()
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.PanelLeftSidebar = New System.Windows.Forms.Panel()
        Me.btnHome = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnDriver = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnMenu = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnPelanggan = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnTransaksi = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnPesanan = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BunifuProgressBar1 = New Bunifu.UI.WinForms.BunifuProgressBar()
        Me.btnLogout = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.PanelNav = New System.Windows.Forms.Panel()
        Me.btnMini = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnExit = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.HepiMart = New Bunifu.UI.WinForms.BunifuLabel()
        Me.BunifuDragControl1 = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.Splitter1 = New System.Windows.Forms.Splitter()
        Me.BunifuCards2 = New Bunifu.Framework.UI.BunifuCards()
        Me.txtTodayTrx = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.BunifuCards4 = New Bunifu.Framework.UI.BunifuCards()
        Me.txtProfitToday = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.BunifuCards1 = New Bunifu.Framework.UI.BunifuCards()
        Me.txtProfitTot = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BunifuCards3 = New Bunifu.Framework.UI.BunifuCards()
        Me.txtTotTrx = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.btnCari = New Bunifu.UI.WinForms.BunifuButton.BunifuButton()
        Me.PanelLeftSidebar.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.PanelNav.SuspendLayout()
        Me.BunifuCards2.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BunifuCards4.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BunifuCards1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BunifuCards3.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 5
        Me.BunifuElipse1.TargetControl = Me
        '
        'PanelLeftSidebar
        '
        Me.PanelLeftSidebar.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.PanelLeftSidebar.Controls.Add(Me.btnHome)
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
        Me.PanelLeftSidebar.TabIndex = 0
        '
        'btnHome
        '
        Me.btnHome.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btnHome.BackColor = System.Drawing.Color.SeaGreen
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
        Me.btnHome.Normalcolor = System.Drawing.Color.SeaGreen
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
        Me.Panel1.Controls.Add(Me.BunifuProgressBar1)
        Me.Panel1.Controls.Add(Me.btnLogout)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 451)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(175, 54)
        Me.Panel1.TabIndex = 16
        '
        'BunifuProgressBar1
        '
        Me.BunifuProgressBar1.Animation = 0
        Me.BunifuProgressBar1.AnimationStep = 10
        Me.BunifuProgressBar1.BackgroundImage = CType(resources.GetObject("BunifuProgressBar1.BackgroundImage"), System.Drawing.Image)
        Me.BunifuProgressBar1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.BunifuProgressBar1.BorderRadius = 5
        Me.BunifuProgressBar1.BorderThickness = 2
        Me.BunifuProgressBar1.Dock = System.Windows.Forms.DockStyle.Top
        Me.BunifuProgressBar1.Location = New System.Drawing.Point(0, 0)
        Me.BunifuProgressBar1.MaximumValue = 100
        Me.BunifuProgressBar1.MinimumValue = 0
        Me.BunifuProgressBar1.Name = "BunifuProgressBar1"
        Me.BunifuProgressBar1.ProgressBackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.BunifuProgressBar1.ProgressColorLeft = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.BunifuProgressBar1.ProgressColorRight = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.BunifuProgressBar1.Size = New System.Drawing.Size(175, 10)
        Me.BunifuProgressBar1.TabIndex = 3
        Me.BunifuProgressBar1.Value = 0
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
        Me.PanelNav.TabIndex = 1
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
        'BunifuDragControl1
        '
        Me.BunifuDragControl1.Fixed = True
        Me.BunifuDragControl1.Horizontal = True
        Me.BunifuDragControl1.TargetControl = Me.PanelNav
        Me.BunifuDragControl1.Vertical = True
        '
        'Splitter1
        '
        Me.Splitter1.Location = New System.Drawing.Point(0, 0)
        Me.Splitter1.Name = "Splitter1"
        Me.Splitter1.Size = New System.Drawing.Size(3, 505)
        Me.Splitter1.TabIndex = 22
        Me.Splitter1.TabStop = False
        '
        'BunifuCards2
        '
        Me.BunifuCards2.BackColor = System.Drawing.Color.SteelBlue
        Me.BunifuCards2.BorderRadius = 5
        Me.BunifuCards2.BottomSahddow = True
        Me.BunifuCards2.color = System.Drawing.Color.Purple
        Me.BunifuCards2.Controls.Add(Me.txtTodayTrx)
        Me.BunifuCards2.Controls.Add(Me.Label2)
        Me.BunifuCards2.Controls.Add(Me.PictureBox2)
        Me.BunifuCards2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(156, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.BunifuCards2.LeftSahddow = False
        Me.BunifuCards2.Location = New System.Drawing.Point(607, 83)
        Me.BunifuCards2.Name = "BunifuCards2"
        Me.BunifuCards2.RightSahddow = True
        Me.BunifuCards2.ShadowDepth = 20
        Me.BunifuCards2.Size = New System.Drawing.Size(369, 106)
        Me.BunifuCards2.TabIndex = 3
        '
        'txtTodayTrx
        '
        Me.txtTodayTrx.AutoSize = True
        Me.txtTodayTrx.Font = New System.Drawing.Font("Yu Gothic UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTodayTrx.ForeColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.txtTodayTrx.Location = New System.Drawing.Point(199, 58)
        Me.txtTodayTrx.Name = "txtTodayTrx"
        Me.txtTodayTrx.Size = New System.Drawing.Size(47, 37)
        Me.txtTodayTrx.TabIndex = 8
        Me.txtTodayTrx.Text = "25"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Yu Gothic UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(145, 17)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(157, 25)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Transaksi Hari Ini"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(19, 17)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(76, 74)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'BunifuCards4
        '
        Me.BunifuCards4.BackColor = System.Drawing.Color.SteelBlue
        Me.BunifuCards4.BorderRadius = 5
        Me.BunifuCards4.BottomSahddow = True
        Me.BunifuCards4.color = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.BunifuCards4.Controls.Add(Me.txtProfitToday)
        Me.BunifuCards4.Controls.Add(Me.Label4)
        Me.BunifuCards4.Controls.Add(Me.PictureBox4)
        Me.BunifuCards4.LeftSahddow = False
        Me.BunifuCards4.Location = New System.Drawing.Point(607, 215)
        Me.BunifuCards4.Name = "BunifuCards4"
        Me.BunifuCards4.RightSahddow = True
        Me.BunifuCards4.ShadowDepth = 20
        Me.BunifuCards4.Size = New System.Drawing.Size(369, 106)
        Me.BunifuCards4.TabIndex = 5
        '
        'txtProfitToday
        '
        Me.txtProfitToday.AutoSize = True
        Me.txtProfitToday.Font = New System.Drawing.Font("Yu Gothic UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProfitToday.ForeColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.txtProfitToday.Location = New System.Drawing.Point(160, 45)
        Me.txtProfitToday.Name = "txtProfitToday"
        Me.txtProfitToday.Size = New System.Drawing.Size(154, 37)
        Me.txtProfitToday.TabIndex = 8
        Me.txtProfitToday.Text = "Rp 300.532"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Yu Gothic UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(145, 17)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(182, 25)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Pendapatan Hari Ini"
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(19, 17)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(76, 74)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 1
        Me.PictureBox4.TabStop = False
        '
        'BunifuCards1
        '
        Me.BunifuCards1.BackColor = System.Drawing.Color.SteelBlue
        Me.BunifuCards1.BorderRadius = 5
        Me.BunifuCards1.BottomSahddow = True
        Me.BunifuCards1.color = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BunifuCards1.Controls.Add(Me.txtProfitTot)
        Me.BunifuCards1.Controls.Add(Me.Label3)
        Me.BunifuCards1.Controls.Add(Me.PictureBox1)
        Me.BunifuCards1.LeftSahddow = False
        Me.BunifuCards1.Location = New System.Drawing.Point(212, 215)
        Me.BunifuCards1.Name = "BunifuCards1"
        Me.BunifuCards1.RightSahddow = True
        Me.BunifuCards1.ShadowDepth = 20
        Me.BunifuCards1.Size = New System.Drawing.Size(369, 106)
        Me.BunifuCards1.TabIndex = 7
        '
        'txtProfitTot
        '
        Me.txtProfitTot.AutoSize = True
        Me.txtProfitTot.Font = New System.Drawing.Font("Yu Gothic UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProfitTot.ForeColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.txtProfitTot.Location = New System.Drawing.Point(150, 45)
        Me.txtProfitTot.Name = "txtProfitTot"
        Me.txtProfitTot.Size = New System.Drawing.Size(140, 37)
        Me.txtProfitTot.TabIndex = 8
        Me.txtProfitTot.Text = "Rp 26.054"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Yu Gothic UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(140, 17)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(160, 25)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Total Pendapatan"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(19, 17)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(76, 74)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'BunifuCards3
        '
        Me.BunifuCards3.BackColor = System.Drawing.Color.SteelBlue
        Me.BunifuCards3.BorderRadius = 5
        Me.BunifuCards3.BottomSahddow = True
        Me.BunifuCards3.color = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BunifuCards3.Controls.Add(Me.txtTotTrx)
        Me.BunifuCards3.Controls.Add(Me.Label1)
        Me.BunifuCards3.Controls.Add(Me.PictureBox3)
        Me.BunifuCards3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(101, Byte), Integer))
        Me.BunifuCards3.LeftSahddow = False
        Me.BunifuCards3.Location = New System.Drawing.Point(212, 83)
        Me.BunifuCards3.Name = "BunifuCards3"
        Me.BunifuCards3.RightSahddow = True
        Me.BunifuCards3.ShadowDepth = 20
        Me.BunifuCards3.Size = New System.Drawing.Size(369, 106)
        Me.BunifuCards3.TabIndex = 6
        '
        'txtTotTrx
        '
        Me.txtTotTrx.AutoSize = True
        Me.txtTotTrx.Font = New System.Drawing.Font("Yu Gothic UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotTrx.ForeColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.txtTotTrx.Location = New System.Drawing.Point(178, 54)
        Me.txtTotTrx.Name = "txtTotTrx"
        Me.txtTotTrx.Size = New System.Drawing.Size(47, 37)
        Me.txtTotTrx.TabIndex = 3
        Me.txtTotTrx.Text = "25"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Yu Gothic UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(140, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(135, 25)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Total Transaksi"
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(19, 17)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(76, 74)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 1
        Me.PictureBox3.TabStop = False
        '
        'btnCari
        '
        Me.btnCari.BackColor = System.Drawing.Color.Transparent
        Me.btnCari.BackgroundImage = CType(resources.GetObject("btnCari.BackgroundImage"), System.Drawing.Image)
        Me.btnCari.ButtonText = "REPORT"
        Me.btnCari.ButtonTextMarginLeft = 0
        Me.btnCari.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCari.DisabledBorderColor = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.btnCari.DisabledFillColor = System.Drawing.Color.Gray
        Me.btnCari.DisabledForecolor = System.Drawing.Color.White
        Me.btnCari.Font = New System.Drawing.Font("Segoe UI", 13.75!, System.Drawing.FontStyle.Bold)
        Me.btnCari.ForeColor = System.Drawing.Color.White
        Me.btnCari.IconLeftCursor = System.Windows.Forms.Cursors.Hand
        Me.btnCari.IconPadding = 10
        Me.btnCari.IconRightCursor = System.Windows.Forms.Cursors.Hand
        Me.btnCari.IdleBorderColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.btnCari.IdleBorderRadius = 6
        Me.btnCari.IdleBorderThickness = 1
        Me.btnCari.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(195, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.btnCari.IdleIconLeftImage = Nothing
        Me.btnCari.IdleIconRightImage = Nothing
        Me.btnCari.Location = New System.Drawing.Point(516, 386)
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
        Me.btnCari.Size = New System.Drawing.Size(139, 54)
        Me.btnCari.TabIndex = 8
        Me.btnCari.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Home
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(156, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1036, 550)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnCari)
        Me.Controls.Add(Me.BunifuCards1)
        Me.Controls.Add(Me.BunifuCards3)
        Me.Controls.Add(Me.BunifuCards4)
        Me.Controls.Add(Me.BunifuCards2)
        Me.Controls.Add(Me.PanelLeftSidebar)
        Me.Controls.Add(Me.PanelNav)
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(81, Byte), Integer))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Home"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
        Me.Text = "Form1"
        Me.PanelLeftSidebar.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.PanelNav.ResumeLayout(False)
        Me.PanelNav.PerformLayout()
        Me.BunifuCards2.ResumeLayout(False)
        Me.BunifuCards2.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BunifuCards4.ResumeLayout(False)
        Me.BunifuCards4.PerformLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BunifuCards1.ResumeLayout(False)
        Me.BunifuCards1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BunifuCards3.ResumeLayout(False)
        Me.BunifuCards3.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents PanelLeftSidebar As Panel
    Friend WithEvents PanelNav As Panel
    Friend WithEvents BunifuDragControl1 As Bunifu.Framework.UI.BunifuDragControl
    Friend WithEvents HepiMart As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnLogout As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btnPesanan As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btnMenu As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btnPelanggan As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btnTransaksi As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btnDriver As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btnExit As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents Splitter1 As Splitter
    Friend WithEvents btnMini As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents BunifuProgressBar1 As Bunifu.UI.WinForms.BunifuProgressBar
    Friend WithEvents BunifuCards1 As Bunifu.Framework.UI.BunifuCards
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents BunifuCards3 As Bunifu.Framework.UI.BunifuCards
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents BunifuCards4 As Bunifu.Framework.UI.BunifuCards
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents BunifuCards2 As Bunifu.Framework.UI.BunifuCards
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents btnHome As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtProfitTot As Label
    Friend WithEvents txtTotTrx As Label
    Friend WithEvents txtProfitToday As Label
    Friend WithEvents txtTodayTrx As Label
    Friend WithEvents btnCari As Bunifu.UI.WinForms.BunifuButton.BunifuButton
End Class
