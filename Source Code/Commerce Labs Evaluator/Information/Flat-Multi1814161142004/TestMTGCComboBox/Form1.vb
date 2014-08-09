Public Class frmTest
    Inherits System.Windows.Forms.Form

#Region " Codice generato da Progettazione Windows Form "

    Public Sub New()
        MyBase.New()

        'Chiamata richiesta da Progettazione Windows Form.
        InitializeComponent()

        'Aggiungere le eventuali istruzioni di inizializzazione dopo la chiamata a InitializeComponent()

    End Sub

    'Form esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Richiesto da Progettazione Windows Form
    Private components As System.ComponentModel.IContainer

    'NOTA: la procedura che segue è richiesta da Progettazione Windows Form.
    'Può essere modificata in Progettazione Windows Form.  
    'Non modificarla nell'editor del codice.
    Friend WithEvents lsvData As System.Windows.Forms.ListView
    Friend WithEvents chName As System.Windows.Forms.ColumnHeader
    Friend WithEvents chkHighLight As System.Windows.Forms.CheckBox
    Friend WithEvents chkFast As System.Windows.Forms.CheckBox
    Friend WithEvents gbColors As System.Windows.Forms.GroupBox
    Friend WithEvents chkGridH As System.Windows.Forms.CheckBox
    Friend WithEvents chkGridV As System.Windows.Forms.CheckBox
    Friend WithEvents cdColor As System.Windows.Forms.ColorDialog
    Friend WithEvents comboTest As MTGCComboBox
    Friend WithEvents lblBorderColor As System.Windows.Forms.Label
    Friend WithEvents lblHighLight As System.Windows.Forms.Label
    Friend WithEvents btnBorder As System.Windows.Forms.Button
    Friend WithEvents pnlBorder As System.Windows.Forms.Panel
    Friend WithEvents pnlHighLight As System.Windows.Forms.Panel
    Friend WithEvents btnHighLight As System.Windows.Forms.Button
    Friend WithEvents pnlGrid As System.Windows.Forms.Panel
    Friend WithEvents btnGrid As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents pnlDDArrowBack As System.Windows.Forms.Panel
    Friend WithEvents btnDDArrowBack As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents pnlDDBack As System.Windows.Forms.Panel
    Friend WithEvents btnDDBack As System.Windows.Forms.Button
    Friend WithEvents pnlDDFore As System.Windows.Forms.Panel
    Friend WithEvents btnDDFore As System.Windows.Forms.Button
    Friend WithEvents chAbbreviation As System.Windows.Forms.ColumnHeader
    Friend WithEvents chPopulation As System.Windows.Forms.ColumnHeader
    Friend WithEvents chSize As System.Windows.Forms.ColumnHeader
    Friend WithEvents gbColumns As System.Windows.Forms.GroupBox
    Friend WithEvents ttpHelp As System.Windows.Forms.ToolTip
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents opt1 As System.Windows.Forms.RadioButton
    Friend WithEvents opt2 As System.Windows.Forms.RadioButton
    Friend WithEvents opt3 As System.Windows.Forms.RadioButton
    Friend WithEvents opt4 As System.Windows.Forms.RadioButton
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtWCol1 As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtWCol4 As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtWCol3 As System.Windows.Forms.TextBox
    Friend WithEvents txtWCol2 As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents gbSelectedValues As System.Windows.Forms.GroupBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtCol1 As System.Windows.Forms.TextBox
    Friend WithEvents txtCol2 As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtCol3 As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txtCol4 As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents gbFlatStyle As System.Windows.Forms.GroupBox
    Friend WithEvents rbFixed3D As System.Windows.Forms.RadioButton
    Friend WithEvents rbFlatXP As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rbDropDownList As System.Windows.Forms.RadioButton
    Friend WithEvents rbDropDown As System.Windows.Forms.RadioButton
    Friend WithEvents chkEnabled As System.Windows.Forms.CheckBox
    Friend WithEvents MainMenu1 As System.Windows.Forms.MainMenu
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem3 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem4 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem2 As System.Windows.Forms.MenuItem
    Friend WithEvents btnLoad_ComboBoxItem As System.Windows.Forms.Button
    Friend WithEvents btnLoad_DataTable As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmTest))
        Me.comboTest = New MTGCComboBox
        Me.lsvData = New System.Windows.Forms.ListView
        Me.chName = New System.Windows.Forms.ColumnHeader
        Me.chAbbreviation = New System.Windows.Forms.ColumnHeader
        Me.chPopulation = New System.Windows.Forms.ColumnHeader
        Me.chSize = New System.Windows.Forms.ColumnHeader
        Me.chkHighLight = New System.Windows.Forms.CheckBox
        Me.chkFast = New System.Windows.Forms.CheckBox
        Me.gbColors = New System.Windows.Forms.GroupBox
        Me.pnlDDFore = New System.Windows.Forms.Panel
        Me.btnDDFore = New System.Windows.Forms.Button
        Me.Label3 = New System.Windows.Forms.Label
        Me.pnlDDBack = New System.Windows.Forms.Panel
        Me.btnDDBack = New System.Windows.Forms.Button
        Me.Label4 = New System.Windows.Forms.Label
        Me.pnlDDArrowBack = New System.Windows.Forms.Panel
        Me.btnDDArrowBack = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.pnlGrid = New System.Windows.Forms.Panel
        Me.btnGrid = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.pnlHighLight = New System.Windows.Forms.Panel
        Me.btnHighLight = New System.Windows.Forms.Button
        Me.pnlBorder = New System.Windows.Forms.Panel
        Me.btnBorder = New System.Windows.Forms.Button
        Me.lblHighLight = New System.Windows.Forms.Label
        Me.lblBorderColor = New System.Windows.Forms.Label
        Me.chkGridH = New System.Windows.Forms.CheckBox
        Me.chkGridV = New System.Windows.Forms.CheckBox
        Me.cdColor = New System.Windows.Forms.ColorDialog
        Me.gbColumns = New System.Windows.Forms.GroupBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.txtWCol4 = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.txtWCol2 = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtWCol3 = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtWCol1 = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.opt4 = New System.Windows.Forms.RadioButton
        Me.opt3 = New System.Windows.Forms.RadioButton
        Me.opt2 = New System.Windows.Forms.RadioButton
        Me.opt1 = New System.Windows.Forms.RadioButton
        Me.Label5 = New System.Windows.Forms.Label
        Me.ttpHelp = New System.Windows.Forms.ToolTip(Me.components)
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.gbSelectedValues = New System.Windows.Forms.GroupBox
        Me.txtCol4 = New System.Windows.Forms.TextBox
        Me.Label17 = New System.Windows.Forms.Label
        Me.txtCol3 = New System.Windows.Forms.TextBox
        Me.Label16 = New System.Windows.Forms.Label
        Me.txtCol2 = New System.Windows.Forms.TextBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.txtCol1 = New System.Windows.Forms.TextBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.gbFlatStyle = New System.Windows.Forms.GroupBox
        Me.rbFixed3D = New System.Windows.Forms.RadioButton
        Me.rbFlatXP = New System.Windows.Forms.RadioButton
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.rbDropDownList = New System.Windows.Forms.RadioButton
        Me.rbDropDown = New System.Windows.Forms.RadioButton
        Me.chkEnabled = New System.Windows.Forms.CheckBox
        Me.MainMenu1 = New System.Windows.Forms.MainMenu
        Me.MenuItem1 = New System.Windows.Forms.MenuItem
        Me.MenuItem2 = New System.Windows.Forms.MenuItem
        Me.MenuItem3 = New System.Windows.Forms.MenuItem
        Me.MenuItem4 = New System.Windows.Forms.MenuItem
        Me.btnLoad_ComboBoxItem = New System.Windows.Forms.Button
        Me.btnLoad_DataTable = New System.Windows.Forms.Button
        Me.gbColors.SuspendLayout()
        Me.gbColumns.SuspendLayout()
        Me.gbSelectedValues.SuspendLayout()
        Me.gbFlatStyle.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'comboTest
        '
        Me.comboTest.BorderStyle = MTGCComboBox.TipiBordi.FlatXP
        Me.comboTest.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.comboTest.ColumnNum = 4
        Me.comboTest.ColumnWidth = "120; 40;100;120"
        Me.comboTest.DisplayMember = "Text"
        Me.comboTest.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.comboTest.DropDownArrowBackColor = System.Drawing.Color.FromArgb(CType(136, Byte), CType(169, Byte), CType(223, Byte))
        Me.comboTest.DropDownBackColor = System.Drawing.Color.FromArgb(CType(193, Byte), CType(210, Byte), CType(238, Byte))
        Me.comboTest.DropDownForeColor = System.Drawing.Color.Black
        Me.comboTest.DropDownStyle = MTGCComboBox.CustomDropDownStyle.DropDown
        Me.comboTest.DropDownWidth = 400
        Me.comboTest.GridLineColor = System.Drawing.Color.LightGray
        Me.comboTest.GridLineHorizontal = False
        Me.comboTest.GridLineVertical = False
        Me.comboTest.HighlightBorderColor = System.Drawing.Color.Blue
        Me.comboTest.HighlightBorderOnMouseEvents = True
        Me.comboTest.LoadingType = MTGCComboBox.CaricamentoCombo.ComboBoxItem
        Me.comboTest.Location = New System.Drawing.Point(8, 196)
        Me.comboTest.ManagingFastMouseMoving = True
        Me.comboTest.ManagingFastMouseMovingInterval = 30
        Me.comboTest.Name = "comboTest"
        Me.comboTest.NormalBorderColor = System.Drawing.Color.Black
        Me.comboTest.Size = New System.Drawing.Size(320, 21)
        Me.comboTest.TabIndex = 0
        '
        'lsvData
        '
        Me.lsvData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lsvData.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.chName, Me.chAbbreviation, Me.chPopulation, Me.chSize})
        Me.lsvData.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lsvData.FullRowSelect = True
        Me.lsvData.GridLines = True
        Me.lsvData.Location = New System.Drawing.Point(8, 32)
        Me.lsvData.Name = "lsvData"
        Me.lsvData.Size = New System.Drawing.Size(496, 104)
        Me.lsvData.TabIndex = 1
        Me.lsvData.View = System.Windows.Forms.View.Details
        '
        'chName
        '
        Me.chName.Text = "Name"
        Me.chName.Width = 112
        '
        'chAbbreviation
        '
        Me.chAbbreviation.Text = "Abbreviation"
        Me.chAbbreviation.Width = 76
        '
        'chPopulation
        '
        Me.chPopulation.Text = "Population"
        Me.chPopulation.Width = 135
        '
        'chSize
        '
        Me.chSize.Text = "Size"
        Me.chSize.Width = 149
        '
        'chkHighLight
        '
        Me.chkHighLight.Checked = True
        Me.chkHighLight.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkHighLight.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkHighLight.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkHighLight.Location = New System.Drawing.Point(136, 312)
        Me.chkHighLight.Name = "chkHighLight"
        Me.chkHighLight.Size = New System.Drawing.Size(112, 16)
        Me.chkHighLight.TabIndex = 2
        Me.chkHighLight.Text = "Highlight Border"
        '
        'chkFast
        '
        Me.chkFast.Checked = True
        Me.chkFast.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkFast.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkFast.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkFast.Location = New System.Drawing.Point(136, 328)
        Me.chkFast.Name = "chkFast"
        Me.chkFast.Size = New System.Drawing.Size(192, 16)
        Me.chkFast.TabIndex = 3
        Me.chkFast.Text = "Fast Mouse Moving Management"
        '
        'gbColors
        '
        Me.gbColors.Controls.Add(Me.pnlDDFore)
        Me.gbColors.Controls.Add(Me.btnDDFore)
        Me.gbColors.Controls.Add(Me.Label3)
        Me.gbColors.Controls.Add(Me.pnlDDBack)
        Me.gbColors.Controls.Add(Me.btnDDBack)
        Me.gbColors.Controls.Add(Me.Label4)
        Me.gbColors.Controls.Add(Me.pnlDDArrowBack)
        Me.gbColors.Controls.Add(Me.btnDDArrowBack)
        Me.gbColors.Controls.Add(Me.Label2)
        Me.gbColors.Controls.Add(Me.pnlGrid)
        Me.gbColors.Controls.Add(Me.btnGrid)
        Me.gbColors.Controls.Add(Me.Label1)
        Me.gbColors.Controls.Add(Me.pnlHighLight)
        Me.gbColors.Controls.Add(Me.btnHighLight)
        Me.gbColors.Controls.Add(Me.pnlBorder)
        Me.gbColors.Controls.Add(Me.btnBorder)
        Me.gbColors.Controls.Add(Me.lblHighLight)
        Me.gbColors.Controls.Add(Me.lblBorderColor)
        Me.gbColors.Location = New System.Drawing.Point(8, 448)
        Me.gbColors.Name = "gbColors"
        Me.gbColors.Size = New System.Drawing.Size(496, 120)
        Me.gbColors.TabIndex = 4
        Me.gbColors.TabStop = False
        Me.gbColors.Text = "Colors"
        '
        'pnlDDFore
        '
        Me.pnlDDFore.BackColor = System.Drawing.Color.Black
        Me.pnlDDFore.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlDDFore.Location = New System.Drawing.Point(240, 80)
        Me.pnlDDFore.Name = "pnlDDFore"
        Me.pnlDDFore.Size = New System.Drawing.Size(72, 24)
        Me.pnlDDFore.TabIndex = 19
        '
        'btnDDFore
        '
        Me.btnDDFore.Location = New System.Drawing.Point(312, 80)
        Me.btnDDFore.Name = "btnDDFore"
        Me.btnDDFore.Size = New System.Drawing.Size(32, 24)
        Me.btnDDFore.TabIndex = 18
        Me.btnDDFore.Text = "<<"
        Me.ttpHelp.SetToolTip(Me.btnDDFore, "Click here to change the Color")
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(352, 86)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(108, 17)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "DropDownFore Color"
        '
        'pnlDDBack
        '
        Me.pnlDDBack.BackColor = System.Drawing.Color.FromArgb(CType(193, Byte), CType(210, Byte), CType(238, Byte))
        Me.pnlDDBack.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlDDBack.Location = New System.Drawing.Point(8, 80)
        Me.pnlDDBack.Name = "pnlDDBack"
        Me.pnlDDBack.Size = New System.Drawing.Size(72, 24)
        Me.pnlDDBack.TabIndex = 16
        '
        'btnDDBack
        '
        Me.btnDDBack.Location = New System.Drawing.Point(80, 80)
        Me.btnDDBack.Name = "btnDDBack"
        Me.btnDDBack.Size = New System.Drawing.Size(32, 24)
        Me.btnDDBack.TabIndex = 15
        Me.btnDDBack.Text = "<<"
        Me.ttpHelp.SetToolTip(Me.btnDDBack, "Click here to change the Color")
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(119, 86)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(110, 17)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "DropDownBack Color"
        '
        'pnlDDArrowBack
        '
        Me.pnlDDArrowBack.BackColor = System.Drawing.Color.FromArgb(CType(136, Byte), CType(169, Byte), CType(223, Byte))
        Me.pnlDDArrowBack.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlDDArrowBack.Location = New System.Drawing.Point(240, 48)
        Me.pnlDDArrowBack.Name = "pnlDDArrowBack"
        Me.pnlDDArrowBack.Size = New System.Drawing.Size(72, 24)
        Me.pnlDDArrowBack.TabIndex = 13
        '
        'btnDDArrowBack
        '
        Me.btnDDArrowBack.Location = New System.Drawing.Point(312, 48)
        Me.btnDDArrowBack.Name = "btnDDArrowBack"
        Me.btnDDArrowBack.Size = New System.Drawing.Size(32, 24)
        Me.btnDDArrowBack.TabIndex = 12
        Me.btnDDArrowBack.Text = "<<"
        Me.ttpHelp.SetToolTip(Me.btnDDArrowBack, "Click here to change the Color")
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(352, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(139, 17)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "DropDownArrowBack Color"
        '
        'pnlGrid
        '
        Me.pnlGrid.BackColor = System.Drawing.Color.LightGray
        Me.pnlGrid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlGrid.Location = New System.Drawing.Point(240, 16)
        Me.pnlGrid.Name = "pnlGrid"
        Me.pnlGrid.Size = New System.Drawing.Size(72, 24)
        Me.pnlGrid.TabIndex = 10
        '
        'btnGrid
        '
        Me.btnGrid.Location = New System.Drawing.Point(312, 16)
        Me.btnGrid.Name = "btnGrid"
        Me.btnGrid.Size = New System.Drawing.Size(32, 24)
        Me.btnGrid.TabIndex = 9
        Me.btnGrid.Text = "<<"
        Me.ttpHelp.SetToolTip(Me.btnGrid, "Click here to change the Color")
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(352, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 17)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "GridLine Color"
        '
        'pnlHighLight
        '
        Me.pnlHighLight.BackColor = System.Drawing.Color.Blue
        Me.pnlHighLight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlHighLight.Location = New System.Drawing.Point(8, 48)
        Me.pnlHighLight.Name = "pnlHighLight"
        Me.pnlHighLight.Size = New System.Drawing.Size(72, 24)
        Me.pnlHighLight.TabIndex = 7
        '
        'btnHighLight
        '
        Me.btnHighLight.Location = New System.Drawing.Point(80, 48)
        Me.btnHighLight.Name = "btnHighLight"
        Me.btnHighLight.Size = New System.Drawing.Size(32, 24)
        Me.btnHighLight.TabIndex = 6
        Me.btnHighLight.Text = "<<"
        Me.ttpHelp.SetToolTip(Me.btnHighLight, "Click here to change the Color")
        '
        'pnlBorder
        '
        Me.pnlBorder.BackColor = System.Drawing.Color.Black
        Me.pnlBorder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlBorder.Location = New System.Drawing.Point(8, 16)
        Me.pnlBorder.Name = "pnlBorder"
        Me.pnlBorder.Size = New System.Drawing.Size(72, 24)
        Me.pnlBorder.TabIndex = 5
        '
        'btnBorder
        '
        Me.btnBorder.Location = New System.Drawing.Point(80, 16)
        Me.btnBorder.Name = "btnBorder"
        Me.btnBorder.Size = New System.Drawing.Size(32, 24)
        Me.btnBorder.TabIndex = 4
        Me.btnBorder.Text = "<<"
        Me.ttpHelp.SetToolTip(Me.btnBorder, "Click here to change the Color")
        '
        'lblHighLight
        '
        Me.lblHighLight.AutoSize = True
        Me.lblHighLight.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHighLight.Location = New System.Drawing.Point(118, 52)
        Me.lblHighLight.Name = "lblHighLight"
        Me.lblHighLight.Size = New System.Drawing.Size(81, 17)
        Me.lblHighLight.TabIndex = 3
        Me.lblHighLight.Text = "HighLight Color"
        '
        'lblBorderColor
        '
        Me.lblBorderColor.AutoSize = True
        Me.lblBorderColor.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBorderColor.Location = New System.Drawing.Point(117, 21)
        Me.lblBorderColor.Name = "lblBorderColor"
        Me.lblBorderColor.Size = New System.Drawing.Size(67, 17)
        Me.lblBorderColor.TabIndex = 1
        Me.lblBorderColor.Text = "Border Color"
        '
        'chkGridH
        '
        Me.chkGridH.Checked = True
        Me.chkGridH.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkGridH.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkGridH.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkGridH.Location = New System.Drawing.Point(336, 312)
        Me.chkGridH.Name = "chkGridH"
        Me.chkGridH.Size = New System.Drawing.Size(160, 16)
        Me.chkGridH.TabIndex = 5
        Me.chkGridH.Text = "GridLine Horizontal"
        '
        'chkGridV
        '
        Me.chkGridV.Checked = True
        Me.chkGridV.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkGridV.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkGridV.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkGridV.Location = New System.Drawing.Point(336, 328)
        Me.chkGridV.Name = "chkGridV"
        Me.chkGridV.Size = New System.Drawing.Size(160, 16)
        Me.chkGridV.TabIndex = 6
        Me.chkGridV.Text = "GridLine Vertical"
        '
        'gbColumns
        '
        Me.gbColumns.Controls.Add(Me.Label11)
        Me.gbColumns.Controls.Add(Me.Label10)
        Me.gbColumns.Controls.Add(Me.txtWCol4)
        Me.gbColumns.Controls.Add(Me.Label9)
        Me.gbColumns.Controls.Add(Me.txtWCol2)
        Me.gbColumns.Controls.Add(Me.Label8)
        Me.gbColumns.Controls.Add(Me.txtWCol3)
        Me.gbColumns.Controls.Add(Me.Label7)
        Me.gbColumns.Controls.Add(Me.txtWCol1)
        Me.gbColumns.Controls.Add(Me.Label6)
        Me.gbColumns.Controls.Add(Me.opt4)
        Me.gbColumns.Controls.Add(Me.opt3)
        Me.gbColumns.Controls.Add(Me.opt2)
        Me.gbColumns.Controls.Add(Me.opt1)
        Me.gbColumns.Controls.Add(Me.Label5)
        Me.gbColumns.Location = New System.Drawing.Point(8, 368)
        Me.gbColumns.Name = "gbColumns"
        Me.gbColumns.Size = New System.Drawing.Size(496, 72)
        Me.gbColumns.TabIndex = 8
        Me.gbColumns.TabStop = False
        Me.gbColumns.Text = "Columns"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(261, 42)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(36, 17)
        Me.Label11.TabIndex = 14
        Me.Label11.Text = "(pixel)"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(408, 43)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(21, 17)
        Me.Label10.TabIndex = 13
        Me.Label10.Text = "C 4"
        '
        'txtWCol4
        '
        Me.txtWCol4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtWCol4.Location = New System.Drawing.Point(432, 40)
        Me.txtWCol4.Name = "txtWCol4"
        Me.txtWCol4.Size = New System.Drawing.Size(48, 20)
        Me.txtWCol4.TabIndex = 12
        Me.txtWCol4.Text = "120"
        Me.txtWCol4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(408, 19)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(21, 17)
        Me.Label9.TabIndex = 11
        Me.Label9.Text = "C 2"
        '
        'txtWCol2
        '
        Me.txtWCol2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtWCol2.Location = New System.Drawing.Point(432, 16)
        Me.txtWCol2.Name = "txtWCol2"
        Me.txtWCol2.Size = New System.Drawing.Size(48, 20)
        Me.txtWCol2.TabIndex = 10
        Me.txtWCol2.Text = "40"
        Me.txtWCol2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(328, 43)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(21, 17)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "C 3"
        '
        'txtWCol3
        '
        Me.txtWCol3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtWCol3.Location = New System.Drawing.Point(352, 40)
        Me.txtWCol3.Name = "txtWCol3"
        Me.txtWCol3.Size = New System.Drawing.Size(48, 20)
        Me.txtWCol3.TabIndex = 8
        Me.txtWCol3.Text = "100"
        Me.txtWCol3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(328, 19)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(21, 17)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "C 1"
        '
        'txtWCol1
        '
        Me.txtWCol1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtWCol1.Location = New System.Drawing.Point(352, 16)
        Me.txtWCol1.Name = "txtWCol1"
        Me.txtWCol1.Size = New System.Drawing.Size(48, 20)
        Me.txtWCol1.TabIndex = 6
        Me.txtWCol1.Text = "120"
        Me.txtWCol1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(240, 28)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(83, 17)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Columns widths"
        '
        'opt4
        '
        Me.opt4.Checked = True
        Me.opt4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.opt4.Location = New System.Drawing.Point(152, 40)
        Me.opt4.Name = "opt4"
        Me.opt4.Size = New System.Drawing.Size(32, 16)
        Me.opt4.TabIndex = 4
        Me.opt4.TabStop = True
        Me.opt4.Text = "4"
        '
        'opt3
        '
        Me.opt3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.opt3.Location = New System.Drawing.Point(152, 16)
        Me.opt3.Name = "opt3"
        Me.opt3.Size = New System.Drawing.Size(32, 16)
        Me.opt3.TabIndex = 3
        Me.opt3.Text = "3"
        '
        'opt2
        '
        Me.opt2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.opt2.Location = New System.Drawing.Point(112, 40)
        Me.opt2.Name = "opt2"
        Me.opt2.Size = New System.Drawing.Size(32, 16)
        Me.opt2.TabIndex = 2
        Me.opt2.Text = "2"
        '
        'opt1
        '
        Me.opt1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.opt1.Location = New System.Drawing.Point(112, 16)
        Me.opt1.Name = "opt1"
        Me.opt1.Size = New System.Drawing.Size(32, 16)
        Me.opt1.TabIndex = 1
        Me.opt1.Text = "1"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(8, 32)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(89, 17)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Columns showed"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(9, 12)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(337, 17)
        Me.Label12.TabIndex = 9
        Me.Label12.Text = "These are values showed in the combobox (US states information)"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(8, 176)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(263, 17)
        Me.Label13.TabIndex = 10
        Me.Label13.Text = "Here we have the flat multicolumn combobox"
        '
        'gbSelectedValues
        '
        Me.gbSelectedValues.Controls.Add(Me.txtCol4)
        Me.gbSelectedValues.Controls.Add(Me.Label17)
        Me.gbSelectedValues.Controls.Add(Me.txtCol3)
        Me.gbSelectedValues.Controls.Add(Me.Label16)
        Me.gbSelectedValues.Controls.Add(Me.txtCol2)
        Me.gbSelectedValues.Controls.Add(Me.Label15)
        Me.gbSelectedValues.Controls.Add(Me.txtCol1)
        Me.gbSelectedValues.Controls.Add(Me.Label14)
        Me.gbSelectedValues.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbSelectedValues.Location = New System.Drawing.Point(8, 224)
        Me.gbSelectedValues.Name = "gbSelectedValues"
        Me.gbSelectedValues.Size = New System.Drawing.Size(496, 72)
        Me.gbSelectedValues.TabIndex = 11
        Me.gbSelectedValues.TabStop = False
        Me.gbSelectedValues.Text = "Selected Values"
        '
        'txtCol4
        '
        Me.txtCol4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCol4.Location = New System.Drawing.Point(376, 40)
        Me.txtCol4.Name = "txtCol4"
        Me.txtCol4.ReadOnly = True
        Me.txtCol4.Size = New System.Drawing.Size(112, 21)
        Me.txtCol4.TabIndex = 7
        Me.txtCol4.Text = ""
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(376, 24)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(31, 17)
        Me.Label17.TabIndex = 6
        Me.Label17.Text = "COL4"
        '
        'txtCol3
        '
        Me.txtCol3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCol3.Location = New System.Drawing.Point(256, 40)
        Me.txtCol3.Name = "txtCol3"
        Me.txtCol3.ReadOnly = True
        Me.txtCol3.Size = New System.Drawing.Size(112, 21)
        Me.txtCol3.TabIndex = 5
        Me.txtCol3.Text = ""
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(256, 24)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(31, 17)
        Me.Label16.TabIndex = 4
        Me.Label16.Text = "COL3"
        '
        'txtCol2
        '
        Me.txtCol2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCol2.Location = New System.Drawing.Point(136, 40)
        Me.txtCol2.Name = "txtCol2"
        Me.txtCol2.ReadOnly = True
        Me.txtCol2.Size = New System.Drawing.Size(112, 21)
        Me.txtCol2.TabIndex = 3
        Me.txtCol2.Text = ""
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(136, 24)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(31, 17)
        Me.Label15.TabIndex = 2
        Me.Label15.Text = "COL2"
        '
        'txtCol1
        '
        Me.txtCol1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCol1.Location = New System.Drawing.Point(16, 40)
        Me.txtCol1.Name = "txtCol1"
        Me.txtCol1.ReadOnly = True
        Me.txtCol1.Size = New System.Drawing.Size(112, 21)
        Me.txtCol1.TabIndex = 1
        Me.txtCol1.Text = ""
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(16, 24)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(31, 17)
        Me.Label14.TabIndex = 0
        Me.Label14.Text = "COL1"
        '
        'gbFlatStyle
        '
        Me.gbFlatStyle.Controls.Add(Me.rbFixed3D)
        Me.gbFlatStyle.Controls.Add(Me.rbFlatXP)
        Me.gbFlatStyle.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbFlatStyle.Location = New System.Drawing.Point(416, 168)
        Me.gbFlatStyle.Name = "gbFlatStyle"
        Me.gbFlatStyle.Size = New System.Drawing.Size(88, 56)
        Me.gbFlatStyle.TabIndex = 12
        Me.gbFlatStyle.TabStop = False
        Me.gbFlatStyle.Text = "Flat Style"
        '
        'rbFixed3D
        '
        Me.rbFixed3D.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rbFixed3D.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbFixed3D.Location = New System.Drawing.Point(8, 32)
        Me.rbFixed3D.Name = "rbFixed3D"
        Me.rbFixed3D.Size = New System.Drawing.Size(72, 16)
        Me.rbFixed3D.TabIndex = 1
        Me.rbFixed3D.Text = "Fixed3D"
        '
        'rbFlatXP
        '
        Me.rbFlatXP.Checked = True
        Me.rbFlatXP.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rbFlatXP.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbFlatXP.Location = New System.Drawing.Point(8, 16)
        Me.rbFlatXP.Name = "rbFlatXP"
        Me.rbFlatXP.Size = New System.Drawing.Size(72, 16)
        Me.rbFlatXP.TabIndex = 0
        Me.rbFlatXP.TabStop = True
        Me.rbFlatXP.Text = "FlatXP"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbDropDownList)
        Me.GroupBox1.Controls.Add(Me.rbDropDown)
        Me.GroupBox1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(8, 304)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(120, 56)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "DropDown Style"
        '
        'rbDropDownList
        '
        Me.rbDropDownList.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rbDropDownList.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbDropDownList.Location = New System.Drawing.Point(8, 32)
        Me.rbDropDownList.Name = "rbDropDownList"
        Me.rbDropDownList.Size = New System.Drawing.Size(96, 16)
        Me.rbDropDownList.TabIndex = 1
        Me.rbDropDownList.Text = "DropDownList"
        '
        'rbDropDown
        '
        Me.rbDropDown.Checked = True
        Me.rbDropDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rbDropDown.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbDropDown.Location = New System.Drawing.Point(8, 16)
        Me.rbDropDown.Name = "rbDropDown"
        Me.rbDropDown.Size = New System.Drawing.Size(72, 16)
        Me.rbDropDown.TabIndex = 0
        Me.rbDropDown.TabStop = True
        Me.rbDropDown.Text = "DropDown"
        '
        'chkEnabled
        '
        Me.chkEnabled.Checked = True
        Me.chkEnabled.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkEnabled.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkEnabled.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkEnabled.Location = New System.Drawing.Point(136, 344)
        Me.chkEnabled.Name = "chkEnabled"
        Me.chkEnabled.Size = New System.Drawing.Size(192, 16)
        Me.chkEnabled.TabIndex = 14
        Me.chkEnabled.Text = "Enabled"
        '
        'MainMenu1
        '
        Me.MainMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem1, Me.MenuItem3})
        '
        'MenuItem1
        '
        Me.MenuItem1.Index = 0
        Me.MenuItem1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem2})
        Me.MenuItem1.Text = "File"
        '
        'MenuItem2
        '
        Me.MenuItem2.Index = 0
        Me.MenuItem2.Text = "Close"
        '
        'MenuItem3
        '
        Me.MenuItem3.Index = 1
        Me.MenuItem3.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem4})
        Me.MenuItem3.Text = "?"
        '
        'MenuItem4
        '
        Me.MenuItem4.Index = 0
        Me.MenuItem4.Text = "About"
        '
        'btnLoad_ComboBoxItem
        '
        Me.btnLoad_ComboBoxItem.BackColor = System.Drawing.Color.FromArgb(CType(253, Byte), CType(218, Byte), CType(125, Byte))
        Me.btnLoad_ComboBoxItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLoad_ComboBoxItem.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLoad_ComboBoxItem.Location = New System.Drawing.Point(101, 140)
        Me.btnLoad_ComboBoxItem.Name = "btnLoad_ComboBoxItem"
        Me.btnLoad_ComboBoxItem.Size = New System.Drawing.Size(152, 32)
        Me.btnLoad_ComboBoxItem.TabIndex = 15
        Me.btnLoad_ComboBoxItem.Text = "Load Combo with ComboBoxItem"
        '
        'btnLoad_DataTable
        '
        Me.btnLoad_DataTable.BackColor = System.Drawing.Color.FromArgb(CType(253, Byte), CType(218, Byte), CType(125, Byte))
        Me.btnLoad_DataTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLoad_DataTable.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLoad_DataTable.Location = New System.Drawing.Point(261, 140)
        Me.btnLoad_DataTable.Name = "btnLoad_DataTable"
        Me.btnLoad_DataTable.Size = New System.Drawing.Size(152, 32)
        Me.btnLoad_DataTable.TabIndex = 16
        Me.btnLoad_DataTable.Text = "Load Combo with DataTable"
        '
        'frmTest
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(514, 571)
        Me.Controls.Add(Me.btnLoad_DataTable)
        Me.Controls.Add(Me.btnLoad_ComboBoxItem)
        Me.Controls.Add(Me.chkEnabled)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.gbFlatStyle)
        Me.Controls.Add(Me.gbSelectedValues)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.gbColumns)
        Me.Controls.Add(Me.chkGridV)
        Me.Controls.Add(Me.chkGridH)
        Me.Controls.Add(Me.gbColors)
        Me.Controls.Add(Me.chkFast)
        Me.Controls.Add(Me.chkHighLight)
        Me.Controls.Add(Me.lsvData)
        Me.Controls.Add(Me.comboTest)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Menu = Me.MainMenu1
        Me.MinimizeBox = False
        Me.Name = "frmTest"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Testing MTGCComboBox"
        Me.gbColors.ResumeLayout(False)
        Me.gbColumns.ResumeLayout(False)
        Me.gbSelectedValues.ResumeLayout(False)
        Me.gbFlatStyle.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub frmTest_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadListView()
    End Sub

    Private Sub LoadListView()
        With lsvData.Items.Add("Alabama")
            .SubItems.Add("AL")
            .SubItems.Add("4,447,100")
            .SubItems.Add("52,423 sq miles")
        End With

        With lsvData.Items.Add("Alaska")
            .SubItems.Add("AK")
            .SubItems.Add("626,932")
            .SubItems.Add("656,425 sq miles")
        End With

        With lsvData.Items.Add("Arizona")
            .SubItems.Add("AZ")
            .SubItems.Add("5,130,632")
            .SubItems.Add("114,006 sq miles")
        End With

        With lsvData.Items.Add("Arkansas")
            .SubItems.Add("AR")
            .SubItems.Add("2,673,400")
            .SubItems.Add("53,182 sq miles")
        End With

        With lsvData.Items.Add("California")
            .SubItems.Add("CA")
            .SubItems.Add("33,871,648")
            .SubItems.Add("163,707 sq miles")
        End With

        With lsvData.Items.Add("Colorado")
            .SubItems.Add("CO")
            .SubItems.Add("4,301,261")
            .SubItems.Add("104,100 sq miles")
        End With

        With lsvData.Items.Add("Connecticut")
            .SubItems.Add("CT")
            .SubItems.Add("3,405,565")
            .SubItems.Add("5,544 sq miles")
        End With

        With lsvData.Items.Add("Delaware")
            .SubItems.Add("DE")
            .SubItems.Add("783,600")
            .SubItems.Add("1,954 sq miles")
        End With

        With lsvData.Items.Add("District of Columbia")
            .SubItems.Add("DC")
            .SubItems.Add("572,059")
            .SubItems.Add("68.25 sq miles")
        End With

        With lsvData.Items.Add("Florida")
            .SubItems.Add("FL")
            .SubItems.Add("15,982,378")
            .SubItems.Add("65,758 sq miles")
        End With

        With lsvData.Items.Add("Georgia")
            .SubItems.Add("GA")
            .SubItems.Add("8,186,453")
            .SubItems.Add("59,441 sq miles")
        End With

        With lsvData.Items.Add("Hawaii")
            .SubItems.Add("HI")
            .SubItems.Add("1,211,537")
            .SubItems.Add("10,932 sq miles")
        End With

        With lsvData.Items.Add("Idaho")
            .SubItems.Add("ID")
            .SubItems.Add("1,293,953")
            .SubItems.Add("83,574 sq miles")
        End With

        With lsvData.Items.Add("Illinois")
            .SubItems.Add("IL")
            .SubItems.Add("12,419,293")
            .SubItems.Add("57,918 sq miles")
        End With

        With lsvData.Items.Add("Indiana")
            .SubItems.Add("IN")
            .SubItems.Add("6,080,485")
            .SubItems.Add("36,420 sq miles")
        End With

        With lsvData.Items.Add("Iowa")
            .SubItems.Add("IA")
            .SubItems.Add("2,926,324")
            .SubItems.Add("56,276 sq miles")
        End With

        With lsvData.Items.Add("Kansas")
            .SubItems.Add("KS")
            .SubItems.Add("2,688,418")
            .SubItems.Add("82,282 sq miles")
        End With

        With lsvData.Items.Add("Kentucky")
            .SubItems.Add("KY")
            .SubItems.Add("4,041,769")
            .SubItems.Add("40,411 sq miles")
        End With

        With lsvData.Items.Add("Louisiana")
            .SubItems.Add("LA")
            .SubItems.Add("4,468,976")
            .SubItems.Add("51,843 sq miles")
        End With

        With lsvData.Items.Add("Maine")
            .SubItems.Add("ME")
            .SubItems.Add("1,274,923")
            .SubItems.Add("35,387 sq miles")
        End With

        With lsvData.Items.Add("Maryland")
            .SubItems.Add("MD")
            .SubItems.Add("5,296,486")
            .SubItems.Add("12,407 sq miles")
        End With

        With lsvData.Items.Add("Massachusetts")
            .SubItems.Add("MA")
            .SubItems.Add("6,349,097")
            .SubItems.Add("10,555 sq miles")
        End With

        With lsvData.Items.Add("Michigan")
            .SubItems.Add("MI")
            .SubItems.Add("9,938,444")
            .SubItems.Add("96,810 sq miles")
        End With

        With lsvData.Items.Add("Minnesota")
            .SubItems.Add("MN")
            .SubItems.Add("4,919,479")
            .SubItems.Add("86,943 sq miles")
        End With

        With lsvData.Items.Add("Mississippi")
            .SubItems.Add("MS")
            .SubItems.Add("2,844,658")
            .SubItems.Add("48,434 sq miles")
        End With

        With lsvData.Items.Add("Missouri")
            .SubItems.Add("MO")
            .SubItems.Add("5,595,211")
            .SubItems.Add("69,709 sq miles")
        End With

        With lsvData.Items.Add("Montana")
            .SubItems.Add("MT")
            .SubItems.Add("902,195")
            .SubItems.Add("147,046 sq miles")
        End With

        With lsvData.Items.Add("Nebraska")
            .SubItems.Add("NE")
            .SubItems.Add("1,711,263")
            .SubItems.Add("77,358 sq miles")
        End With

        With lsvData.Items.Add("Nevada")
            .SubItems.Add("NV")
            .SubItems.Add("1,998,257")
            .SubItems.Add("110,567 sq miles")
        End With

        With lsvData.Items.Add("New Hampshire")
            .SubItems.Add("NH")
            .SubItems.Add("1,235,786")
            .SubItems.Add("9,351 sq miles")
        End With

        With lsvData.Items.Add("New Mexico")
            .SubItems.Add("NM")
            .SubItems.Add("1,819,046")
            .SubItems.Add("121,593 sq miles")
        End With

        With lsvData.Items.Add("New Jersey")
            .SubItems.Add("NJ")
            .SubItems.Add("8,414,350")
            .SubItems.Add("8,722 sq miles")
        End With

        With lsvData.Items.Add("New York")
            .SubItems.Add("NY")
            .SubItems.Add("18,976,457")
            .SubItems.Add("54,475 sq miles")
        End With

        With lsvData.Items.Add("North Carolina")
            .SubItems.Add("NC")
            .SubItems.Add("8,049,313")
            .SubItems.Add("53,821 sq miles")
        End With

        With lsvData.Items.Add("North Dakota")
            .SubItems.Add("ND")
            .SubItems.Add("642,200")
            .SubItems.Add("70,704 sq miles")
        End With

        With lsvData.Items.Add("Oklahoma")
            .SubItems.Add("OK")
            .SubItems.Add("3,450,654")
            .SubItems.Add("69,903 sq miles")
        End With

        With lsvData.Items.Add("Ohio")
            .SubItems.Add("OH")
            .SubItems.Add("11,353,140")
            .SubItems.Add("44,828 sq miles")
        End With

        With lsvData.Items.Add("Oregon")
            .SubItems.Add("OR")
            .SubItems.Add("3,421,399")
            .SubItems.Add("98,386 sq miles")
        End With

        With lsvData.Items.Add("Pennsylvania")
            .SubItems.Add("PA")
            .SubItems.Add("12,281,054")
            .SubItems.Add("46,058 sq miles")
        End With

        With lsvData.Items.Add("Rhode Island")
            .SubItems.Add("RI")
            .SubItems.Add("1,048,319")
            .SubItems.Add("1,545 sq miles")
        End With

        With lsvData.Items.Add("South Carolina")
            .SubItems.Add("SC")
            .SubItems.Add("4,012,012")
            .SubItems.Add("32,007 sq miles")
        End With

        With lsvData.Items.Add("South Dakota")
            .SubItems.Add("SD")
            .SubItems.Add("754,844")
            .SubItems.Add("77,121 sq miles")
        End With

        With lsvData.Items.Add("Tennessee")
            .SubItems.Add("TN")
            .SubItems.Add("5,689,283")
            .SubItems.Add("42,146 sq miles")
        End With

        With lsvData.Items.Add("Texas")
            .SubItems.Add("TX")
            .SubItems.Add("20,851,820")
            .SubItems.Add("268,601 sq miles")
        End With

        With lsvData.Items.Add("Utah")
            .SubItems.Add("UT")
            .SubItems.Add("2,233,169")
            .SubItems.Add("84,904 sq miles")
        End With

        With lsvData.Items.Add("Vermont")
            .SubItems.Add("VT")
            .SubItems.Add("608,827")
            .SubItems.Add("9,615 sq miles")
        End With

        With lsvData.Items.Add("Virginia")
            .SubItems.Add("VA")
            .SubItems.Add("7,078,515")
            .SubItems.Add("42,769 sq miles")
        End With

        With lsvData.Items.Add("Washington")
            .SubItems.Add("WA")
            .SubItems.Add("5,894,121")
            .SubItems.Add("71,303 sq miles")
        End With

        With lsvData.Items.Add("West Virginia")
            .SubItems.Add("WV")
            .SubItems.Add("1,808,344")
            .SubItems.Add("24,231 sq miles")
        End With

        With lsvData.Items.Add("Wisconsin")
            .SubItems.Add("WI")
            .SubItems.Add("5,363,675")
            .SubItems.Add("65,503 sq miles")
        End With

        With lsvData.Items.Add("Wyoming")
            .SubItems.Add("WY")
            .SubItems.Add("493,782")
            .SubItems.Add("97,818 sq miles")
        End With
    End Sub

    Private Sub LoadComboBox_MtgcComboBoxItem()
        Dim USstates(50) As MTGCComboBoxItem
        Dim i As Integer = 0

        For Each li As ListViewItem In lsvData.Items
            USstates(i) = New MTGCComboBoxItem(li.Text, li.SubItems(1).Text, li.SubItems(2).Text, li.SubItems(3).Text)
            i += 1
        Next

        comboTest.SelectedIndex = -1
        comboTest.Items.Clear()
        comboTest.LoadingType = MTGCComboBox.CaricamentoCombo.ComboBoxItem
        comboTest.Items.AddRange(USstates)
        MsgBox("Loading completed!", MsgBoxStyle.Information)
    End Sub

    Private Sub LoadComboBox_DataTable()
        Dim dtLoading As New DataTable("UsStates")

        dtLoading.Columns.Add("Name", System.Type.GetType("System.String"))
        dtLoading.Columns.Add("Abbreviation", System.Type.GetType("System.String"))
        dtLoading.Columns.Add("Population", System.Type.GetType("System.String"))
        dtLoading.Columns.Add("Size", System.Type.GetType("System.String"))

        For Each li As ListViewItem In lsvData.Items
            Dim dr As DataRow
            dr = dtLoading.NewRow

            dr("Name") = li.Text
            dr("Abbreviation") = li.SubItems(1).Text
            dr("Population") = li.SubItems(2).Text
            dr("Size") = li.SubItems(3).Text

            dtLoading.Rows.Add(dr)
        Next

        comboTest.SelectedIndex = -1
        comboTest.Items.Clear()
        comboTest.LoadingType = MTGCComboBox.CaricamentoCombo.DataTable
        comboTest.SourceDataString = New String(3) {"Name", "Abbreviation", "Population", "Size"}
        comboTest.SourceDataTable = dtLoading
        MsgBox("Loading completed!", MsgBoxStyle.Information)
    End Sub

    Private Sub rbFixed3D_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbFixed3D.CheckedChanged
        If rbFixed3D.Checked Then
            comboTest.BorderStyle = MTGCComboBox.TipiBordi.Fixed3D
        End If
    End Sub

    Private Sub rbFlatXP_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbFlatXP.CheckedChanged
        If rbFlatXP.Checked Then
            comboTest.BorderStyle = MTGCComboBox.TipiBordi.FlatXP
        End If
    End Sub

    Private Sub btnBorder_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBorder.Click
        If cdColor.ShowDialog() = DialogResult.OK Then
            pnlBorder.BackColor = cdColor.Color
            comboTest.NormalBorderColor = cdColor.Color
        End If
    End Sub

    Private Sub btnHighLight_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHighLight.Click
        If cdColor.ShowDialog() = DialogResult.OK Then
            pnlHighLight.BackColor = cdColor.Color
            comboTest.HighlightBorderColor = cdColor.Color
        End If
    End Sub

    Private Sub btnGrid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGrid.Click
        If cdColor.ShowDialog() = DialogResult.OK Then
            pnlGrid.BackColor = cdColor.Color
            comboTest.GridLineColor = cdColor.Color
        End If
    End Sub

    Private Sub btnDDArrowBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDDArrowBack.Click
        If cdColor.ShowDialog() = DialogResult.OK Then
            pnlDDArrowBack.BackColor = cdColor.Color
            comboTest.DropDownArrowBackColor = cdColor.Color
        End If
    End Sub

    Private Sub chkHighLight_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkHighLight.CheckedChanged
        If chkHighLight.Checked Then
            comboTest.HighlightBorderOnMouseEvents = True
        Else
            comboTest.HighlightBorderOnMouseEvents = False
        End If
    End Sub

    Private Sub chkFast_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkFast.CheckedChanged
        If chkFast.Checked Then
            comboTest.ManagingFastMouseMoving = True
        Else
            comboTest.ManagingFastMouseMoving = False
        End If
    End Sub

    Private Sub chkGridH_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkGridH.CheckedChanged
        If chkGridH.Checked Then
            comboTest.GridLineHorizontal = True
        Else
            comboTest.GridLineHorizontal = False
        End If
    End Sub

    Private Sub chkGridV_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkGridV.CheckedChanged
        If chkGridV.Checked Then
            comboTest.GridLineVertical = True
        Else
            comboTest.GridLineVertical = False
        End If
    End Sub

    Private Sub btnDDBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDDBack.Click
        If cdColor.ShowDialog() = DialogResult.OK Then
            pnlDDBack.BackColor = cdColor.Color
            comboTest.DropDownBackColor = cdColor.Color
        End If
    End Sub

    Private Sub btnDDFore_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDDFore.Click
        If cdColor.ShowDialog() = DialogResult.OK Then
            pnlDDFore.BackColor = cdColor.Color
            comboTest.DropDownForeColor = cdColor.Color
        End If
    End Sub

    Private Sub opt1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles opt1.CheckedChanged
        comboTest.ColumnNum = 1
    End Sub

    Private Sub opt2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles opt2.CheckedChanged
        comboTest.ColumnNum = 2
    End Sub

    Private Sub opt3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles opt3.CheckedChanged
        comboTest.ColumnNum = 3
    End Sub

    Private Sub opt4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles opt4.CheckedChanged
        comboTest.ColumnNum = 4
    End Sub

    Private Sub txtWCol1_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtWCol1.Leave
        If Len(Trim(txtWCol1.Text)) = 0 Then txtWCol1.Text = "0"
        If Not IsNumeric(txtWCol1.Text) OrElse (CLng(txtWCol1.Text) < 0) Then
            MsgBox("You must enter a positive integer!", MsgBoxStyle.Critical)
            txtWCol1.Focus()
            Exit Sub
        End If
        Select Case comboTest.ColumnNum
            Case 1
                comboTest.ColumnWidth = txtWCol1.Text
            Case 2
                comboTest.ColumnWidth = txtWCol1.Text & ";" & txtWCol2.Text
            Case 3
                comboTest.ColumnWidth = txtWCol1.Text & ";" & txtWCol2.Text & ";" & txtWCol3.Text
            Case 4
                comboTest.ColumnWidth = txtWCol1.Text & ";" & txtWCol2.Text & ";" & txtWCol3.Text & ";" & txtWCol4.Text
        End Select
    End Sub

    Private Sub txtWCol2_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtWCol2.Leave
        If Len(Trim(txtWCol2.Text)) = 0 Then txtWCol2.Text = "0"
        If Not IsNumeric(txtWCol2.Text) OrElse (CLng(txtWCol2.Text) < 0) Then
            MsgBox("You must enter a positive integer!", MsgBoxStyle.Critical)
            txtWCol2.Focus()
            Exit Sub
        End If
        Select Case comboTest.ColumnNum
            Case 1
                comboTest.ColumnWidth = txtWCol1.Text
            Case 2
                comboTest.ColumnWidth = txtWCol1.Text & ";" & txtWCol2.Text
            Case 3
                comboTest.ColumnWidth = txtWCol1.Text & ";" & txtWCol2.Text & ";" & txtWCol3.Text
            Case 4
                comboTest.ColumnWidth = txtWCol1.Text & ";" & txtWCol2.Text & ";" & txtWCol3.Text & ";" & txtWCol4.Text
        End Select
    End Sub

    Private Sub txtWCol3_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtWCol3.Leave
        If Len(Trim(txtWCol3.Text)) = 0 Then txtWCol3.Text = "0"
        If Not IsNumeric(txtWCol3.Text) OrElse (CLng(txtWCol3.Text) < 0) Then
            MsgBox("You must enter a positive integer!", MsgBoxStyle.Critical)
            txtWCol3.Focus()
            Exit Sub
        End If
        Select Case comboTest.ColumnNum
            Case 1
                comboTest.ColumnWidth = txtWCol1.Text
            Case 2
                comboTest.ColumnWidth = txtWCol1.Text & ";" & txtWCol2.Text
            Case 3
                comboTest.ColumnWidth = txtWCol1.Text & ";" & txtWCol2.Text & ";" & txtWCol3.Text
            Case 4
                comboTest.ColumnWidth = txtWCol1.Text & ";" & txtWCol2.Text & ";" & txtWCol3.Text & ";" & txtWCol4.Text
        End Select
    End Sub

    Private Sub txtWCol4_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtWCol4.Leave
        If Len(Trim(txtWCol4.Text)) = 0 Then txtWCol4.Text = "0"
        If Not IsNumeric(txtWCol4.Text) OrElse (CLng(txtWCol4.Text) < 0) Then
            MsgBox("You must enter a positive integer!", MsgBoxStyle.Critical)
            txtWCol4.Focus()
            Exit Sub
        End If
        Select Case comboTest.ColumnNum
            Case 1
                comboTest.ColumnWidth = txtWCol1.Text
            Case 2
                comboTest.ColumnWidth = txtWCol1.Text & ";" & txtWCol2.Text
            Case 3
                comboTest.ColumnWidth = txtWCol1.Text & ";" & txtWCol2.Text & ";" & txtWCol3.Text
            Case 4
                comboTest.ColumnWidth = txtWCol1.Text & ";" & txtWCol2.Text & ";" & txtWCol3.Text & ";" & txtWCol4.Text
        End Select
    End Sub

    Private Sub comboTest_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles comboTest.SelectedIndexChanged
        If Not comboTest.SelectedItem Is Nothing Then
            txtCol1.Text = comboTest.SelectedItem.col1
            txtCol2.Text = comboTest.SelectedItem.col2
            txtCol3.Text = comboTest.SelectedItem.col3
            txtCol4.Text = comboTest.SelectedItem.col4
        Else
            txtCol1.Text = ""
            txtCol2.Text = ""
            txtCol3.Text = ""
            txtCol4.Text = ""
        End If
    End Sub

    Private Sub comboTest_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles comboTest.Validated
        If comboTest.SelectedItem Is Nothing Then
            txtCol1.Text = ""
            txtCol2.Text = ""
            txtCol3.Text = ""
            txtCol4.Text = ""
        End If
    End Sub

    Private Sub rbDropDown_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbDropDown.CheckedChanged
        comboTest.DropDownStyle = MTGCComboBox.CustomDropDownStyle.DropDown
    End Sub

    Private Sub rbDropDownList_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbDropDownList.CheckedChanged
        comboTest.DropDownStyle = MTGCComboBox.CustomDropDownStyle.DropDownList
    End Sub

    Private Sub chkEnabled_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkEnabled.CheckedChanged
        If chkEnabled.Checked Then
            comboTest.Enabled = True
        Else
            comboTest.Enabled = False
        End If
    End Sub

    Private Sub MenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem2.Click
        Me.Close()
    End Sub

    Private Sub MenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem4.Click
        Dim frmAbout As New frmAboutComboBox

        frmAbout.ShowDialog()
    End Sub

    Private Sub btnLoad_ComboBoxItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLoad_ComboBoxItem.Click
        LoadComboBox_MtgcComboBoxItem()
    End Sub

    Private Sub btnLoad_DataTable_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLoad_DataTable.Click
        LoadComboBox_DataTable()
    End Sub

End Class
