<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Dim StateProperties1 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties()
        Dim StateProperties2 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties()
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnMini = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnExit = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.HepiMart = New Bunifu.UI.WinForms.BunifuLabel()
        Me.BunifuDragControl1 = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BunifuCards1 = New Bunifu.Framework.UI.BunifuCards()
        Me.tbUsername = New Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox()
        Me.BunifuCustomLabel1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnLogin = New Bunifu.UI.WinForms.BunifuButton.BunifuButton()
        Me.tbPassword = New Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BunifuCards1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 5
        Me.BunifuElipse1.TargetControl = Me
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.Panel1.Controls.Add(Me.btnMini)
        Me.Panel1.Controls.Add(Me.btnExit)
        Me.Panel1.Controls.Add(Me.HepiMart)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(608, 39)
        Me.Panel1.TabIndex = 0
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
        Me.btnMini.Location = New System.Drawing.Point(517, 0)
        Me.btnMini.Name = "btnMini"
        Me.btnMini.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.btnMini.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.btnMini.OnHoverTextColor = System.Drawing.Color.White
        Me.btnMini.selected = False
        Me.btnMini.Size = New System.Drawing.Size(46, 39)
        Me.btnMini.TabIndex = 7
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
        Me.btnExit.Location = New System.Drawing.Point(559, 0)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.btnExit.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.btnExit.OnHoverTextColor = System.Drawing.Color.White
        Me.btnExit.selected = False
        Me.btnExit.Size = New System.Drawing.Size(46, 39)
        Me.btnExit.TabIndex = 6
        Me.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExit.Textcolor = System.Drawing.Color.White
        Me.btnExit.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'HepiMart
        '
        Me.HepiMart.AutoEllipsis = False
        Me.HepiMart.CursorType = Nothing
        Me.HepiMart.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.HepiMart.Location = New System.Drawing.Point(250, 9)
        Me.HepiMart.Name = "HepiMart"
        Me.HepiMart.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.HepiMart.Size = New System.Drawing.Size(82, 23)
        Me.HepiMart.TabIndex = 4
        Me.HepiMart.Text = "Login Kasir"
        Me.HepiMart.TextAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.HepiMart.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        '
        'BunifuDragControl1
        '
        Me.BunifuDragControl1.Fixed = True
        Me.BunifuDragControl1.Horizontal = True
        Me.BunifuDragControl1.TargetControl = Me.Panel1
        Me.BunifuDragControl1.Vertical = True
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(608, 420)
        Me.Panel2.TabIndex = 2
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(608, 420)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'BunifuCards1
        '
        Me.BunifuCards1.BackColor = System.Drawing.Color.LightGray
        Me.BunifuCards1.BorderRadius = 70
        Me.BunifuCards1.BottomSahddow = True
        Me.BunifuCards1.color = System.Drawing.Color.LightGray
        Me.BunifuCards1.Controls.Add(Me.tbUsername)
        Me.BunifuCards1.Controls.Add(Me.BunifuCustomLabel1)
        Me.BunifuCards1.Controls.Add(Me.Label1)
        Me.BunifuCards1.Controls.Add(Me.btnLogin)
        Me.BunifuCards1.Controls.Add(Me.tbPassword)
        Me.BunifuCards1.Controls.Add(Me.PictureBox2)
        Me.BunifuCards1.LeftSahddow = False
        Me.BunifuCards1.Location = New System.Drawing.Point(138, 106)
        Me.BunifuCards1.Name = "BunifuCards1"
        Me.BunifuCards1.RightSahddow = True
        Me.BunifuCards1.ShadowDepth = 20
        Me.BunifuCards1.Size = New System.Drawing.Size(337, 238)
        Me.BunifuCards1.TabIndex = 1
        '
        'tbUsername
        '
        Me.tbUsername.AcceptsReturn = False
        Me.tbUsername.AcceptsTab = False
        Me.tbUsername.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.tbUsername.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.tbUsername.BackColor = System.Drawing.Color.Transparent
        Me.tbUsername.BackgroundImage = CType(resources.GetObject("tbUsername.BackgroundImage"), System.Drawing.Image)
        Me.tbUsername.BorderColorActive = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(145, Byte), Integer))
        Me.tbUsername.BorderColorDisabled = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.tbUsername.BorderColorHover = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(157, Byte), Integer))
        Me.tbUsername.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(107, Byte), Integer), CType(CType(107, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.tbUsername.BorderRadius = 1
        Me.tbUsername.BorderThickness = 2
        Me.tbUsername.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.tbUsername.DefaultFont = New System.Drawing.Font("Segoe UI Semibold", 9.75!)
        Me.tbUsername.DefaultText = ""
        Me.tbUsername.FillColor = System.Drawing.Color.White
        Me.tbUsername.HideSelection = True
        Me.tbUsername.IconLeft = Nothing
        Me.tbUsername.IconLeftCursor = System.Windows.Forms.Cursors.Default
        Me.tbUsername.IconPadding = 10
        Me.tbUsername.IconRight = Nothing
        Me.tbUsername.IconRightCursor = System.Windows.Forms.Cursors.Default
        Me.tbUsername.Location = New System.Drawing.Point(112, 94)
        Me.tbUsername.MaxLength = 32767
        Me.tbUsername.MinimumSize = New System.Drawing.Size(100, 35)
        Me.tbUsername.Modified = False
        Me.tbUsername.Name = "tbUsername"
        Me.tbUsername.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbUsername.ReadOnly = False
        Me.tbUsername.SelectedText = ""
        Me.tbUsername.SelectionLength = 0
        Me.tbUsername.SelectionStart = 0
        Me.tbUsername.ShortcutsEnabled = True
        Me.tbUsername.Size = New System.Drawing.Size(200, 35)
        Me.tbUsername.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu
        Me.tbUsername.TabIndex = 6
        Me.tbUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.tbUsername.TextMarginLeft = 5
        Me.tbUsername.TextPlaceholder = ""
        Me.tbUsername.UseSystemPasswordChar = False
        '
        'BunifuCustomLabel1
        '
        Me.BunifuCustomLabel1.AutoSize = True
        Me.BunifuCustomLabel1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold)
        Me.BunifuCustomLabel1.Location = New System.Drawing.Point(19, 140)
        Me.BunifuCustomLabel1.Name = "BunifuCustomLabel1"
        Me.BunifuCustomLabel1.Size = New System.Drawing.Size(80, 19)
        Me.BunifuCustomLabel1.TabIndex = 5
        Me.BunifuCustomLabel1.Text = "Password"
        Me.BunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(19, 94)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 19)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Username"
        '
        'btnLogin
        '
        Me.btnLogin.BackColor = System.Drawing.Color.Transparent
        Me.btnLogin.BackgroundImage = CType(resources.GetObject("btnLogin.BackgroundImage"), System.Drawing.Image)
        Me.btnLogin.ButtonText = "Login"
        Me.btnLogin.ButtonTextMarginLeft = 0
        Me.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLogin.DisabledBorderColor = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.btnLogin.DisabledFillColor = System.Drawing.Color.Gray
        Me.btnLogin.DisabledForecolor = System.Drawing.Color.White
        Me.btnLogin.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!)
        Me.btnLogin.ForeColor = System.Drawing.Color.White
        Me.btnLogin.IconLeftCursor = System.Windows.Forms.Cursors.Hand
        Me.btnLogin.IconPadding = 10
        Me.btnLogin.IconRightCursor = System.Windows.Forms.Cursors.Hand
        Me.btnLogin.IdleBorderColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.btnLogin.IdleBorderRadius = 1
        Me.btnLogin.IdleBorderThickness = 1
        Me.btnLogin.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.btnLogin.IdleIconLeftImage = Nothing
        Me.btnLogin.IdleIconRightImage = Nothing
        Me.btnLogin.Location = New System.Drawing.Point(212, 191)
        Me.btnLogin.Name = "btnLogin"
        StateProperties1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(221, Byte), Integer))
        StateProperties1.BorderRadius = 1
        StateProperties1.BorderThickness = 1
        StateProperties1.FillColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(221, Byte), Integer))
        StateProperties1.ForeColor = System.Drawing.Color.White
        StateProperties1.IconLeftImage = Nothing
        StateProperties1.IconRightImage = Nothing
        Me.btnLogin.onHoverState = StateProperties1
        StateProperties2.BorderColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(144, Byte), Integer))
        StateProperties2.BorderRadius = 1
        StateProperties2.BorderThickness = 1
        StateProperties2.FillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(144, Byte), Integer))
        StateProperties2.ForeColor = System.Drawing.Color.White
        StateProperties2.IconLeftImage = Nothing
        StateProperties2.IconRightImage = Nothing
        Me.btnLogin.OnPressedState = StateProperties2
        Me.btnLogin.Size = New System.Drawing.Size(100, 31)
        Me.btnLogin.TabIndex = 3
        Me.btnLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tbPassword
        '
        Me.tbPassword.AcceptsReturn = False
        Me.tbPassword.AcceptsTab = False
        Me.tbPassword.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.tbPassword.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.tbPassword.BackColor = System.Drawing.Color.Transparent
        Me.tbPassword.BackgroundImage = CType(resources.GetObject("tbPassword.BackgroundImage"), System.Drawing.Image)
        Me.tbPassword.BorderColorActive = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(145, Byte), Integer))
        Me.tbPassword.BorderColorDisabled = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.tbPassword.BorderColorHover = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(157, Byte), Integer))
        Me.tbPassword.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(107, Byte), Integer), CType(CType(107, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.tbPassword.BorderRadius = 1
        Me.tbPassword.BorderThickness = 2
        Me.tbPassword.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.tbPassword.DefaultFont = New System.Drawing.Font("Segoe UI Semibold", 9.75!)
        Me.tbPassword.DefaultText = ""
        Me.tbPassword.FillColor = System.Drawing.Color.White
        Me.tbPassword.HideSelection = True
        Me.tbPassword.IconLeft = Nothing
        Me.tbPassword.IconLeftCursor = System.Windows.Forms.Cursors.Default
        Me.tbPassword.IconPadding = 10
        Me.tbPassword.IconRight = Nothing
        Me.tbPassword.IconRightCursor = System.Windows.Forms.Cursors.Default
        Me.tbPassword.Location = New System.Drawing.Point(112, 140)
        Me.tbPassword.MaxLength = 32767
        Me.tbPassword.MinimumSize = New System.Drawing.Size(100, 35)
        Me.tbPassword.Modified = False
        Me.tbPassword.Name = "tbPassword"
        Me.tbPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tbPassword.ReadOnly = False
        Me.tbPassword.SelectedText = ""
        Me.tbPassword.SelectionLength = 0
        Me.tbPassword.SelectionStart = 0
        Me.tbPassword.ShortcutsEnabled = True
        Me.tbPassword.Size = New System.Drawing.Size(200, 35)
        Me.tbPassword.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu
        Me.tbPassword.TabIndex = 1
        Me.tbPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.tbPassword.TextMarginLeft = 5
        Me.tbPassword.TextPlaceholder = ""
        Me.tbPassword.UseSystemPasswordChar = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(90, -3)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(160, 105)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 7
        Me.PictureBox2.TabStop = False
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(156, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(608, 420)
        Me.ControlBox = False
        Me.Controls.Add(Me.BunifuCards1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Login"
        Me.Text = "Login"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BunifuCards1.ResumeLayout(False)
        Me.BunifuCards1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents Panel1 As Panel
    Friend WithEvents BunifuDragControl1 As Bunifu.Framework.UI.BunifuDragControl
    Friend WithEvents HepiMart As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents btnMini As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btnExit As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents BunifuCards1 As Bunifu.Framework.UI.BunifuCards
    Friend WithEvents BunifuCustomLabel1 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents Label1 As Label
    Friend WithEvents btnLogin As Bunifu.UI.WinForms.BunifuButton.BunifuButton
    Friend WithEvents tbPassword As Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents tbUsername As Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox
End Class
