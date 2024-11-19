<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form 覆寫 Dispose 以清除元件清單。
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

    '為 Windows Form 設計工具的必要項
    Private components As System.ComponentModel.IContainer

    '注意: 以下為 Windows Form 設計工具所需的程序
    '可以使用 Windows Form 設計工具進行修改。
    '請勿使用程式碼編輯器進行修改。
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.grpCurrentOrderInformation = New System.Windows.Forms.GroupBox()
        Me.btnClearorder = New System.Windows.Forms.Button()
        Me.btnConfirm = New System.Windows.Forms.Button()
        Me.txtOrderamt = New System.Windows.Forms.TextBox()
        Me.txtCustomername = New System.Windows.Forms.TextBox()
        Me.NudQuantity = New System.Windows.Forms.NumericUpDown()
        Me.lblOrderamt = New System.Windows.Forms.Label()
        Me.lblCustomername = New System.Windows.Forms.Label()
        Me.lblQuantity = New System.Windows.Forms.Label()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.GrpSelectionofBread = New System.Windows.Forms.GroupBox()
        Me.lblHoneyOat = New System.Windows.Forms.Label()
        Me.lblGrainWheat = New System.Windows.Forms.Label()
        Me.radHoneyOat = New System.Windows.Forms.RadioButton()
        Me.radGrainWheat = New System.Windows.Forms.RadioButton()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.grpSelectionofSaladIngredients = New System.Windows.Forms.GroupBox()
        Me.lblTuna = New System.Windows.Forms.Label()
        Me.lblHam = New System.Windows.Forms.Label()
        Me.lblTomato = New System.Windows.Forms.Label()
        Me.lbllettuce = New System.Windows.Forms.Label()
        Me.lblapple = New System.Windows.Forms.Label()
        Me.chkapple = New System.Windows.Forms.CheckBox()
        Me.chkTuna = New System.Windows.Forms.CheckBox()
        Me.chkHam = New System.Windows.Forms.CheckBox()
        Me.chkTomato = New System.Windows.Forms.CheckBox()
        Me.chkLettuce = New System.Windows.Forms.CheckBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.grpAccumulatedSales = New System.Windows.Forms.GroupBox()
        Me.btnClearAccumulation = New System.Windows.Forms.Button()
        Me.BtnMostPopularIngredient = New System.Windows.Forms.Button()
        Me.txtLargestSales = New System.Windows.Forms.TextBox()
        Me.txtAverageofSales = New System.Windows.Forms.TextBox()
        Me.txtTotalSales = New System.Windows.Forms.TextBox()
        Me.txtNumberofOrders = New System.Windows.Forms.TextBox()
        Me.lblLargestSales = New System.Windows.Forms.Label()
        Me.lblTotalSales = New System.Windows.Forms.Label()
        Me.lblNumberofOrders = New System.Windows.Forms.Label()
        Me.lblAverageofSales = New System.Windows.Forms.Label()
        Me.lstCustomerHistory = New System.Windows.Forms.ListBox()
        Me.lblCustomerHistory = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtfind = New System.Windows.Forms.TextBox()
        Me.btnFind = New System.Windows.Forms.Button()
        Me.grpCurrentOrderInformation.SuspendLayout()
        CType(Me.NudQuantity, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrpSelectionofBread.SuspendLayout()
        Me.grpSelectionofSaladIngredients.SuspendLayout()
        Me.grpAccumulatedSales.SuspendLayout()
        Me.SuspendLayout()
        '
        'ListBox1
        '
        Me.ListBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 15
        Me.ListBox1.Items.AddRange(New Object() {"Discount offered per Order: ", "10.00% discount if order amount >=$100.00"})
        Me.ListBox1.Location = New System.Drawing.Point(217, 12)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(327, 49)
        Me.ListBox1.TabIndex = 0
        Me.ListBox1.Tag = ""
        '
        'grpCurrentOrderInformation
        '
        Me.grpCurrentOrderInformation.Controls.Add(Me.btnClearorder)
        Me.grpCurrentOrderInformation.Controls.Add(Me.btnConfirm)
        Me.grpCurrentOrderInformation.Controls.Add(Me.txtOrderamt)
        Me.grpCurrentOrderInformation.Controls.Add(Me.txtCustomername)
        Me.grpCurrentOrderInformation.Controls.Add(Me.NudQuantity)
        Me.grpCurrentOrderInformation.Controls.Add(Me.lblOrderamt)
        Me.grpCurrentOrderInformation.Controls.Add(Me.lblCustomername)
        Me.grpCurrentOrderInformation.Controls.Add(Me.lblQuantity)
        Me.grpCurrentOrderInformation.Controls.Add(Me.LinkLabel1)
        Me.grpCurrentOrderInformation.Controls.Add(Me.GrpSelectionofBread)
        Me.grpCurrentOrderInformation.Controls.Add(Me.grpSelectionofSaladIngredients)
        Me.grpCurrentOrderInformation.Location = New System.Drawing.Point(25, 91)
        Me.grpCurrentOrderInformation.Name = "grpCurrentOrderInformation"
        Me.grpCurrentOrderInformation.Size = New System.Drawing.Size(696, 246)
        Me.grpCurrentOrderInformation.TabIndex = 1
        Me.grpCurrentOrderInformation.TabStop = False
        Me.grpCurrentOrderInformation.Text = "Current Order Information"
        '
        'btnClearorder
        '
        Me.btnClearorder.Location = New System.Drawing.Point(596, 196)
        Me.btnClearorder.Name = "btnClearorder"
        Me.btnClearorder.Size = New System.Drawing.Size(94, 33)
        Me.btnClearorder.TabIndex = 16
        Me.btnClearorder.Text = "Clear order"
        Me.btnClearorder.UseVisualStyleBackColor = True
        '
        'btnConfirm
        '
        Me.btnConfirm.Location = New System.Drawing.Point(488, 196)
        Me.btnConfirm.Name = "btnConfirm"
        Me.btnConfirm.Size = New System.Drawing.Size(94, 33)
        Me.btnConfirm.TabIndex = 14
        Me.btnConfirm.Text = "Confirm"
        Me.btnConfirm.UseVisualStyleBackColor = True
        '
        'txtOrderamt
        '
        Me.txtOrderamt.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtOrderamt.Location = New System.Drawing.Point(563, 24)
        Me.txtOrderamt.Name = "txtOrderamt"
        Me.txtOrderamt.ReadOnly = True
        Me.txtOrderamt.Size = New System.Drawing.Size(127, 25)
        Me.txtOrderamt.TabIndex = 13
        '
        'txtCustomername
        '
        Me.txtCustomername.Location = New System.Drawing.Point(339, 162)
        Me.txtCustomername.Name = "txtCustomername"
        Me.txtCustomername.Size = New System.Drawing.Size(100, 25)
        Me.txtCustomername.TabIndex = 7
        '
        'NudQuantity
        '
        Me.NudQuantity.Location = New System.Drawing.Point(339, 130)
        Me.NudQuantity.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NudQuantity.Name = "NudQuantity"
        Me.NudQuantity.Size = New System.Drawing.Size(85, 25)
        Me.NudQuantity.TabIndex = 6
        Me.NudQuantity.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'lblOrderamt
        '
        Me.lblOrderamt.AutoSize = True
        Me.lblOrderamt.Location = New System.Drawing.Point(457, 27)
        Me.lblOrderamt.Name = "lblOrderamt"
        Me.lblOrderamt.Size = New System.Drawing.Size(69, 15)
        Me.lblOrderamt.TabIndex = 5
        Me.lblOrderamt.Text = "Order amt:"
        '
        'lblCustomername
        '
        Me.lblCustomername.AutoSize = True
        Me.lblCustomername.Location = New System.Drawing.Point(229, 164)
        Me.lblCustomername.Name = "lblCustomername"
        Me.lblCustomername.Size = New System.Drawing.Size(95, 15)
        Me.lblCustomername.TabIndex = 4
        Me.lblCustomername.Text = "Customer name"
        '
        'lblQuantity
        '
        Me.lblQuantity.AutoSize = True
        Me.lblQuantity.Location = New System.Drawing.Point(264, 132)
        Me.lblQuantity.Name = "lblQuantity"
        Me.lblQuantity.Size = New System.Drawing.Size(56, 15)
        Me.lblQuantity.TabIndex = 3
        Me.lblQuantity.Text = "Quantity"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(229, 132)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(0, 15)
        Me.LinkLabel1.TabIndex = 2
        '
        'GrpSelectionofBread
        '
        Me.GrpSelectionofBread.Controls.Add(Me.lblHoneyOat)
        Me.GrpSelectionofBread.Controls.Add(Me.lblGrainWheat)
        Me.GrpSelectionofBread.Controls.Add(Me.radHoneyOat)
        Me.GrpSelectionofBread.Controls.Add(Me.radGrainWheat)
        Me.GrpSelectionofBread.Controls.Add(Me.Label15)
        Me.GrpSelectionofBread.Controls.Add(Me.Label14)
        Me.GrpSelectionofBread.Location = New System.Drawing.Point(231, 24)
        Me.GrpSelectionofBread.Name = "GrpSelectionofBread"
        Me.GrpSelectionofBread.Size = New System.Drawing.Size(219, 99)
        Me.GrpSelectionofBread.TabIndex = 1
        Me.GrpSelectionofBread.TabStop = False
        Me.GrpSelectionofBread.Text = "Selection of Bread"
        '
        'lblHoneyOat
        '
        Me.lblHoneyOat.AutoSize = True
        Me.lblHoneyOat.Location = New System.Drawing.Point(104, 57)
        Me.lblHoneyOat.Name = "lblHoneyOat"
        Me.lblHoneyOat.Size = New System.Drawing.Size(0, 15)
        Me.lblHoneyOat.TabIndex = 17
        '
        'lblGrainWheat
        '
        Me.lblGrainWheat.AutoSize = True
        Me.lblGrainWheat.Location = New System.Drawing.Point(119, 33)
        Me.lblGrainWheat.Name = "lblGrainWheat"
        Me.lblGrainWheat.Size = New System.Drawing.Size(0, 15)
        Me.lblGrainWheat.TabIndex = 10
        '
        'radHoneyOat
        '
        Me.radHoneyOat.AutoSize = True
        Me.radHoneyOat.Location = New System.Drawing.Point(5, 57)
        Me.radHoneyOat.Name = "radHoneyOat"
        Me.radHoneyOat.Size = New System.Drawing.Size(99, 19)
        Me.radHoneyOat.TabIndex = 9
        Me.radHoneyOat.TabStop = True
        Me.radHoneyOat.Text = "Honey Oat--"
        Me.radHoneyOat.UseVisualStyleBackColor = True
        '
        'radGrainWheat
        '
        Me.radGrainWheat.AutoSize = True
        Me.radGrainWheat.Location = New System.Drawing.Point(5, 32)
        Me.radGrainWheat.Name = "radGrainWheat"
        Me.radGrainWheat.Size = New System.Drawing.Size(110, 19)
        Me.radGrainWheat.TabIndex = 8
        Me.radGrainWheat.TabStop = True
        Me.radGrainWheat.Text = "Grain Wheat--"
        Me.radGrainWheat.UseVisualStyleBackColor = True
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(33, 60)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(0, 15)
        Me.Label15.TabIndex = 7
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(33, 33)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(0, 15)
        Me.Label14.TabIndex = 6
        '
        'grpSelectionofSaladIngredients
        '
        Me.grpSelectionofSaladIngredients.Controls.Add(Me.lblTuna)
        Me.grpSelectionofSaladIngredients.Controls.Add(Me.lblHam)
        Me.grpSelectionofSaladIngredients.Controls.Add(Me.lblTomato)
        Me.grpSelectionofSaladIngredients.Controls.Add(Me.lbllettuce)
        Me.grpSelectionofSaladIngredients.Controls.Add(Me.lblapple)
        Me.grpSelectionofSaladIngredients.Controls.Add(Me.chkapple)
        Me.grpSelectionofSaladIngredients.Controls.Add(Me.chkTuna)
        Me.grpSelectionofSaladIngredients.Controls.Add(Me.chkHam)
        Me.grpSelectionofSaladIngredients.Controls.Add(Me.chkTomato)
        Me.grpSelectionofSaladIngredients.Controls.Add(Me.chkLettuce)
        Me.grpSelectionofSaladIngredients.Controls.Add(Me.Label13)
        Me.grpSelectionofSaladIngredients.Controls.Add(Me.Label12)
        Me.grpSelectionofSaladIngredients.Controls.Add(Me.Label11)
        Me.grpSelectionofSaladIngredients.Controls.Add(Me.Label10)
        Me.grpSelectionofSaladIngredients.Controls.Add(Me.Label9)
        Me.grpSelectionofSaladIngredients.Location = New System.Drawing.Point(15, 24)
        Me.grpSelectionofSaladIngredients.Name = "grpSelectionofSaladIngredients"
        Me.grpSelectionofSaladIngredients.Size = New System.Drawing.Size(208, 205)
        Me.grpSelectionofSaladIngredients.TabIndex = 0
        Me.grpSelectionofSaladIngredients.TabStop = False
        Me.grpSelectionofSaladIngredients.Text = "Selection of Salad Ingredients"
        '
        'lblTuna
        '
        Me.lblTuna.AutoSize = True
        Me.lblTuna.Location = New System.Drawing.Point(89, 130)
        Me.lblTuna.Name = "lblTuna"
        Me.lblTuna.Size = New System.Drawing.Size(0, 15)
        Me.lblTuna.TabIndex = 17
        '
        'lblHam
        '
        Me.lblHam.AutoSize = True
        Me.lblHam.Location = New System.Drawing.Point(89, 108)
        Me.lblHam.Name = "lblHam"
        Me.lblHam.Size = New System.Drawing.Size(0, 15)
        Me.lblHam.TabIndex = 16
        '
        'lblTomato
        '
        Me.lblTomato.AutoSize = True
        Me.lblTomato.Location = New System.Drawing.Point(107, 81)
        Me.lblTomato.Name = "lblTomato"
        Me.lblTomato.Size = New System.Drawing.Size(0, 15)
        Me.lblTomato.TabIndex = 15
        '
        'lbllettuce
        '
        Me.lbllettuce.AutoSize = True
        Me.lbllettuce.Location = New System.Drawing.Point(99, 58)
        Me.lbllettuce.Name = "lbllettuce"
        Me.lbllettuce.Size = New System.Drawing.Size(0, 15)
        Me.lbllettuce.TabIndex = 14
        '
        'lblapple
        '
        Me.lblapple.AutoSize = True
        Me.lblapple.Location = New System.Drawing.Point(96, 33)
        Me.lblapple.Name = "lblapple"
        Me.lblapple.Size = New System.Drawing.Size(0, 15)
        Me.lblapple.TabIndex = 13
        '
        'chkapple
        '
        Me.chkapple.AutoSize = True
        Me.chkapple.Location = New System.Drawing.Point(28, 32)
        Me.chkapple.Name = "chkapple"
        Me.chkapple.Size = New System.Drawing.Size(73, 19)
        Me.chkapple.TabIndex = 6
        Me.chkapple.Text = "Apple--"
        Me.chkapple.UseVisualStyleBackColor = True
        '
        'chkTuna
        '
        Me.chkTuna.AutoSize = True
        Me.chkTuna.Location = New System.Drawing.Point(28, 129)
        Me.chkTuna.Name = "chkTuna"
        Me.chkTuna.Size = New System.Drawing.Size(68, 19)
        Me.chkTuna.TabIndex = 12
        Me.chkTuna.Text = "Tuna--"
        Me.chkTuna.UseVisualStyleBackColor = True
        '
        'chkHam
        '
        Me.chkHam.AutoSize = True
        Me.chkHam.Location = New System.Drawing.Point(28, 104)
        Me.chkHam.Name = "chkHam"
        Me.chkHam.Size = New System.Drawing.Size(66, 19)
        Me.chkHam.TabIndex = 11
        Me.chkHam.Text = "Ham--"
        Me.chkHam.UseVisualStyleBackColor = True
        '
        'chkTomato
        '
        Me.chkTomato.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuPopup
        Me.chkTomato.AutoSize = True
        Me.chkTomato.Location = New System.Drawing.Point(28, 80)
        Me.chkTomato.Name = "chkTomato"
        Me.chkTomato.Size = New System.Drawing.Size(83, 19)
        Me.chkTomato.TabIndex = 10
        Me.chkTomato.Text = "Tomato--"
        Me.chkTomato.UseVisualStyleBackColor = True
        '
        'chkLettuce
        '
        Me.chkLettuce.AutoSize = True
        Me.chkLettuce.Location = New System.Drawing.Point(28, 57)
        Me.chkLettuce.Name = "chkLettuce"
        Me.chkLettuce.Size = New System.Drawing.Size(81, 19)
        Me.chkLettuce.TabIndex = 9
        Me.chkLettuce.Text = "Lettuce--"
        Me.chkLettuce.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(57, 133)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(0, 15)
        Me.Label13.TabIndex = 8
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(57, 108)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(0, 15)
        Me.Label12.TabIndex = 7
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(57, 84)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(0, 15)
        Me.Label11.TabIndex = 6
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(57, 60)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(0, 15)
        Me.Label10.TabIndex = 5
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(57, 33)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(0, 15)
        Me.Label9.TabIndex = 4
        '
        'grpAccumulatedSales
        '
        Me.grpAccumulatedSales.Controls.Add(Me.btnClearAccumulation)
        Me.grpAccumulatedSales.Controls.Add(Me.BtnMostPopularIngredient)
        Me.grpAccumulatedSales.Controls.Add(Me.txtLargestSales)
        Me.grpAccumulatedSales.Controls.Add(Me.txtAverageofSales)
        Me.grpAccumulatedSales.Controls.Add(Me.txtTotalSales)
        Me.grpAccumulatedSales.Controls.Add(Me.txtNumberofOrders)
        Me.grpAccumulatedSales.Controls.Add(Me.lblLargestSales)
        Me.grpAccumulatedSales.Controls.Add(Me.lblTotalSales)
        Me.grpAccumulatedSales.Controls.Add(Me.lblNumberofOrders)
        Me.grpAccumulatedSales.Controls.Add(Me.lblAverageofSales)
        Me.grpAccumulatedSales.Location = New System.Drawing.Point(25, 343)
        Me.grpAccumulatedSales.Name = "grpAccumulatedSales"
        Me.grpAccumulatedSales.Size = New System.Drawing.Size(675, 147)
        Me.grpAccumulatedSales.TabIndex = 2
        Me.grpAccumulatedSales.TabStop = False
        Me.grpAccumulatedSales.Text = "Accumulated Sales"
        '
        'btnClearAccumulation
        '
        Me.btnClearAccumulation.Location = New System.Drawing.Point(488, 78)
        Me.btnClearAccumulation.Name = "btnClearAccumulation"
        Me.btnClearAccumulation.Size = New System.Drawing.Size(171, 27)
        Me.btnClearAccumulation.TabIndex = 16
        Me.btnClearAccumulation.Text = "Clear Accumulation"
        Me.btnClearAccumulation.UseVisualStyleBackColor = True
        '
        'BtnMostPopularIngredient
        '
        Me.BtnMostPopularIngredient.Location = New System.Drawing.Point(488, 33)
        Me.BtnMostPopularIngredient.Name = "BtnMostPopularIngredient"
        Me.BtnMostPopularIngredient.Size = New System.Drawing.Size(171, 27)
        Me.BtnMostPopularIngredient.TabIndex = 15
        Me.BtnMostPopularIngredient.Text = "Most Popular Ingredient"
        Me.BtnMostPopularIngredient.UseVisualStyleBackColor = True
        '
        'txtLargestSales
        '
        Me.txtLargestSales.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtLargestSales.Location = New System.Drawing.Point(373, 78)
        Me.txtLargestSales.Name = "txtLargestSales"
        Me.txtLargestSales.ReadOnly = True
        Me.txtLargestSales.Size = New System.Drawing.Size(100, 25)
        Me.txtLargestSales.TabIndex = 11
        '
        'txtAverageofSales
        '
        Me.txtAverageofSales.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtAverageofSales.Location = New System.Drawing.Point(373, 35)
        Me.txtAverageofSales.Name = "txtAverageofSales"
        Me.txtAverageofSales.ReadOnly = True
        Me.txtAverageofSales.Size = New System.Drawing.Size(100, 25)
        Me.txtAverageofSales.TabIndex = 10
        '
        'txtTotalSales
        '
        Me.txtTotalSales.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtTotalSales.Location = New System.Drawing.Point(92, 78)
        Me.txtTotalSales.Name = "txtTotalSales"
        Me.txtTotalSales.ReadOnly = True
        Me.txtTotalSales.Size = New System.Drawing.Size(143, 25)
        Me.txtTotalSales.TabIndex = 9
        '
        'txtNumberofOrders
        '
        Me.txtNumberofOrders.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtNumberofOrders.Location = New System.Drawing.Point(133, 35)
        Me.txtNumberofOrders.Name = "txtNumberofOrders"
        Me.txtNumberofOrders.ReadOnly = True
        Me.txtNumberofOrders.Size = New System.Drawing.Size(100, 25)
        Me.txtNumberofOrders.TabIndex = 8
        '
        'lblLargestSales
        '
        Me.lblLargestSales.AutoSize = True
        Me.lblLargestSales.Location = New System.Drawing.Point(285, 85)
        Me.lblLargestSales.Name = "lblLargestSales"
        Me.lblLargestSales.Size = New System.Drawing.Size(82, 15)
        Me.lblLargestSales.TabIndex = 7
        Me.lblLargestSales.Text = "Largest Sales"
        '
        'lblTotalSales
        '
        Me.lblTotalSales.AutoSize = True
        Me.lblTotalSales.Location = New System.Drawing.Point(20, 82)
        Me.lblTotalSales.Name = "lblTotalSales"
        Me.lblTotalSales.Size = New System.Drawing.Size(70, 15)
        Me.lblTotalSales.TabIndex = 5
        Me.lblTotalSales.Text = "Total Sales"
        '
        'lblNumberofOrders
        '
        Me.lblNumberofOrders.AutoSize = True
        Me.lblNumberofOrders.Location = New System.Drawing.Point(20, 38)
        Me.lblNumberofOrders.Name = "lblNumberofOrders"
        Me.lblNumberofOrders.Size = New System.Drawing.Size(111, 15)
        Me.lblNumberofOrders.TabIndex = 4
        Me.lblNumberofOrders.Text = "Number of Orders"
        '
        'lblAverageofSales
        '
        Me.lblAverageofSales.AutoSize = True
        Me.lblAverageofSales.Location = New System.Drawing.Point(264, 39)
        Me.lblAverageofSales.Name = "lblAverageofSales"
        Me.lblAverageofSales.Size = New System.Drawing.Size(103, 15)
        Me.lblAverageofSales.TabIndex = 6
        Me.lblAverageofSales.Text = "Average of Sales"
        '
        'lstCustomerHistory
        '
        Me.lstCustomerHistory.FormattingEnabled = True
        Me.lstCustomerHistory.ItemHeight = 15
        Me.lstCustomerHistory.Location = New System.Drawing.Point(736, 91)
        Me.lstCustomerHistory.Name = "lstCustomerHistory"
        Me.lstCustomerHistory.Size = New System.Drawing.Size(148, 334)
        Me.lstCustomerHistory.TabIndex = 3
        '
        'lblCustomerHistory
        '
        Me.lblCustomerHistory.AutoSize = True
        Me.lblCustomerHistory.Location = New System.Drawing.Point(733, 73)
        Me.lblCustomerHistory.Name = "lblCustomerHistory"
        Me.lblCustomerHistory.Size = New System.Drawing.Size(107, 15)
        Me.lblCustomerHistory.TabIndex = 17
        Me.lblCustomerHistory.Text = "Customer History"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(733, 442)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(102, 15)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Customer Name:"
        '
        'txtfind
        '
        Me.txtfind.Location = New System.Drawing.Point(736, 460)
        Me.txtfind.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtfind.Name = "txtfind"
        Me.txtfind.Size = New System.Drawing.Size(100, 25)
        Me.txtfind.TabIndex = 19
        '
        'btnFind
        '
        Me.btnFind.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnFind.Location = New System.Drawing.Point(844, 460)
        Me.btnFind.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnFind.Name = "btnFind"
        Me.btnFind.Size = New System.Drawing.Size(69, 25)
        Me.btnFind.TabIndex = 18
        Me.btnFind.Text = "find"
        Me.btnFind.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(936, 518)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtfind)
        Me.Controls.Add(Me.btnFind)
        Me.Controls.Add(Me.lblCustomerHistory)
        Me.Controls.Add(Me.lstCustomerHistory)
        Me.Controls.Add(Me.grpAccumulatedSales)
        Me.Controls.Add(Me.grpCurrentOrderInformation)
        Me.Controls.Add(Me.ListBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "My Cafe"
        Me.grpCurrentOrderInformation.ResumeLayout(False)
        Me.grpCurrentOrderInformation.PerformLayout()
        CType(Me.NudQuantity, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrpSelectionofBread.ResumeLayout(False)
        Me.GrpSelectionofBread.PerformLayout()
        Me.grpSelectionofSaladIngredients.ResumeLayout(False)
        Me.grpSelectionofSaladIngredients.PerformLayout()
        Me.grpAccumulatedSales.ResumeLayout(False)
        Me.grpAccumulatedSales.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents grpCurrentOrderInformation As GroupBox
    Friend WithEvents lblOrderamt As Label
    Friend WithEvents lblCustomername As Label
    Friend WithEvents lblQuantity As Label
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents GrpSelectionofBread As GroupBox
    Friend WithEvents grpSelectionofSaladIngredients As GroupBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents grpAccumulatedSales As GroupBox
    Friend WithEvents lblLargestSales As Label
    Friend WithEvents lblAverageofSales As Label
    Friend WithEvents lblTotalSales As Label
    Friend WithEvents lblNumberofOrders As Label
    Friend WithEvents lstCustomerHistory As ListBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents radGrainWheat As RadioButton
    Friend WithEvents radHoneyOat As RadioButton
    Friend WithEvents chkTuna As CheckBox
    Friend WithEvents chkHam As CheckBox
    Friend WithEvents chkTomato As CheckBox
    Friend WithEvents chkLettuce As CheckBox
    Friend WithEvents chkapple As CheckBox
    Friend WithEvents txtOrderamt As TextBox
    Friend WithEvents txtCustomername As TextBox
    Friend WithEvents NudQuantity As NumericUpDown
    Friend WithEvents txtLargestSales As TextBox
    Friend WithEvents txtAverageofSales As TextBox
    Friend WithEvents txtTotalSales As TextBox
    Friend WithEvents txtNumberofOrders As TextBox
    Friend WithEvents btnClearorder As Button
    Friend WithEvents btnConfirm As Button
    Friend WithEvents btnClearAccumulation As Button
    Friend WithEvents BtnMostPopularIngredient As Button
    Friend WithEvents lblCustomerHistory As Label
    Friend WithEvents lblapple As Label
    Friend WithEvents lblHam As Label
    Friend WithEvents lblTomato As Label
    Friend WithEvents lbllettuce As Label
    Friend WithEvents lblHoneyOat As Label
    Friend WithEvents lblGrainWheat As Label
    Friend WithEvents lblTuna As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtfind As TextBox
    Friend WithEvents btnFind As Button
End Class
