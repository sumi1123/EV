<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
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

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.IoutSetButton = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.BeginButton = New System.Windows.Forms.Button()
        Me.EndButton = New System.Windows.Forms.Button()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.VsourceBox = New System.Windows.Forms.TextBox()
        Me.IsourceBox = New System.Windows.Forms.TextBox()
        Me.CycTimeBox = New System.Windows.Forms.TextBox()
        Me.VsourMax = New System.Windows.Forms.TextBox()
        Me.VsourMin = New System.Windows.Forms.TextBox()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.tb_VCU_DCDC_HVCurrSet = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.tb_VCU_DCDC_LVVoltSet = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label45 = New System.Windows.Forms.Label()
        Me.TimeRecordBox = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.SerialPort2 = New System.IO.Ports.SerialPort(Me.components)
        Me.tmrRead = New System.Windows.Forms.Timer(Me.components)
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Vsour = New System.Windows.Forms.TextBox()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.ILoadBox = New System.Windows.Forms.TextBox()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.VLoadBox = New System.Windows.Forms.TextBox()
        Me.Isour = New System.Windows.Forms.TextBox()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label57 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.RuntimeBox = New System.Windows.Forms.TextBox()
        Me.Result = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.RunnumBox = New System.Windows.Forms.TextBox()
        Me.SplitContainer3 = New System.Windows.Forms.SplitContainer()
        Me.Vin_OVP_Shape1 = New System.Windows.Forms.Label()
        Me.Vout_OVP_Shape1 = New System.Windows.Forms.Label()
        Me.OTP_Shape1 = New System.Windows.Forms.Label()
        Me.Vin_UVP_Shape1 = New System.Windows.Forms.Label()
        Me.Vout_Short_Shape1 = New System.Windows.Forms.Label()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.Label41 = New System.Windows.Forms.Label()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.Label43 = New System.Windows.Forms.Label()
        Me.Label44 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label46 = New System.Windows.Forms.Label()
        Me.Label47 = New System.Windows.Forms.Label()
        Me.TempBox1 = New System.Windows.Forms.TextBox()
        Me.VoutBox1 = New System.Windows.Forms.TextBox()
        Me.IoutBox1 = New System.Windows.Forms.TextBox()
        Me.Label48 = New System.Windows.Forms.Label()
        Me.Label49 = New System.Windows.Forms.Label()
        Me.Label50 = New System.Windows.Forms.Label()
        Me.Vin_OVP_Shape2 = New System.Windows.Forms.Label()
        Me.Vout_OVP_Shape2 = New System.Windows.Forms.Label()
        Me.OTP_Shape2 = New System.Windows.Forms.Label()
        Me.Vin_UVP_Shape2 = New System.Windows.Forms.Label()
        Me.Vout_Short_Shape2 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label51 = New System.Windows.Forms.Label()
        Me.Label52 = New System.Windows.Forms.Label()
        Me.Label53 = New System.Windows.Forms.Label()
        Me.TempBox2 = New System.Windows.Forms.TextBox()
        Me.VoutBox2 = New System.Windows.Forms.TextBox()
        Me.IoutBox2 = New System.Windows.Forms.TextBox()
        Me.Label54 = New System.Windows.Forms.Label()
        Me.Label55 = New System.Windows.Forms.Label()
        Me.Label56 = New System.Windows.Forms.Label()
        Me.cbb_VCU_DCDCReq = New System.Windows.Forms.ComboBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        CType(Me.SplitContainer3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer3.Panel1.SuspendLayout()
        Me.SplitContainer3.Panel2.SuspendLayout()
        Me.SplitContainer3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("宋体", 12.0!)
        Me.Label3.Location = New System.Drawing.Point(33, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "电源电压值"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("宋体", 12.0!)
        Me.Label4.Location = New System.Drawing.Point(33, 51)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(88, 16)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "电源限流值"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("宋体", 12.0!)
        Me.Label5.Location = New System.Drawing.Point(32, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(136, 16)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "电源最小输出电压"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("宋体", 12.0!)
        Me.Label6.Location = New System.Drawing.Point(32, 50)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(136, 16)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "电源最大输出电流"
        '
        'IoutSetButton
        '
        Me.IoutSetButton.Font = New System.Drawing.Font("宋体", 12.0!)
        Me.IoutSetButton.Location = New System.Drawing.Point(1137, 175)
        Me.IoutSetButton.Name = "IoutSetButton"
        Me.IoutSetButton.Size = New System.Drawing.Size(86, 28)
        Me.IoutSetButton.TabIndex = 6
        Me.IoutSetButton.Text = "带载设置"
        Me.IoutSetButton.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowDrop = True
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3})
        Me.DataGridView1.Location = New System.Drawing.Point(11, 131)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 23
        Me.DataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.DataGridView1.Size = New System.Drawing.Size(284, 311)
        Me.DataGridView1.TabIndex = 12
        Me.DataGridView1.Visible = False
        '
        'Column1
        '
        Me.Column1.HeaderText = "Num"
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 80
        '
        'Column2
        '
        Me.Column2.HeaderText = "Iout/A"
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 80
        '
        'Column3
        '
        Me.Column3.HeaderText = "LastTime/min"
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 80
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("宋体", 12.0!)
        Me.Label7.Location = New System.Drawing.Point(340, 53)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(104, 16)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "需要运行时间"
        '
        'BeginButton
        '
        Me.BeginButton.Font = New System.Drawing.Font("宋体", 12.0!)
        Me.BeginButton.Location = New System.Drawing.Point(1137, 320)
        Me.BeginButton.Name = "BeginButton"
        Me.BeginButton.Size = New System.Drawing.Size(86, 37)
        Me.BeginButton.TabIndex = 23
        Me.BeginButton.Text = "运行"
        Me.BeginButton.UseVisualStyleBackColor = True
        '
        'EndButton
        '
        Me.EndButton.Font = New System.Drawing.Font("宋体", 12.0!)
        Me.EndButton.Location = New System.Drawing.Point(1137, 404)
        Me.EndButton.Name = "EndButton"
        Me.EndButton.Size = New System.Drawing.Size(86, 37)
        Me.EndButton.TabIndex = 25
        Me.EndButton.Text = "结束"
        Me.EndButton.UseVisualStyleBackColor = True
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("宋体", 20.0!)
        Me.Label16.Location = New System.Drawing.Point(614, 9)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(40, 27)
        Me.Label16.TabIndex = 26
        Me.Label16.Text = "EV"
        '
        'VsourceBox
        '
        Me.VsourceBox.Location = New System.Drawing.Point(142, 14)
        Me.VsourceBox.Name = "VsourceBox"
        Me.VsourceBox.Size = New System.Drawing.Size(90, 21)
        Me.VsourceBox.TabIndex = 27
        Me.VsourceBox.Text = "330"
        Me.VsourceBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'IsourceBox
        '
        Me.IsourceBox.Location = New System.Drawing.Point(142, 50)
        Me.IsourceBox.Name = "IsourceBox"
        Me.IsourceBox.Size = New System.Drawing.Size(90, 21)
        Me.IsourceBox.TabIndex = 28
        Me.IsourceBox.Text = "20"
        Me.IsourceBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'CycTimeBox
        '
        Me.CycTimeBox.Location = New System.Drawing.Point(455, 50)
        Me.CycTimeBox.Name = "CycTimeBox"
        Me.CycTimeBox.Size = New System.Drawing.Size(90, 21)
        Me.CycTimeBox.TabIndex = 34
        Me.CycTimeBox.Text = "3000"
        Me.CycTimeBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'VsourMax
        '
        Me.VsourMax.Location = New System.Drawing.Point(172, 48)
        Me.VsourMax.Name = "VsourMax"
        Me.VsourMax.Size = New System.Drawing.Size(90, 21)
        Me.VsourMax.TabIndex = 35
        Me.VsourMax.Text = "340"
        Me.VsourMax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'VsourMin
        '
        Me.VsourMin.Location = New System.Drawing.Point(172, 14)
        Me.VsourMin.Name = "VsourMin"
        Me.VsourMin.Size = New System.Drawing.Size(90, 21)
        Me.VsourMin.TabIndex = 36
        Me.VsourMin.Text = "320"
        Me.VsourMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Location = New System.Drawing.Point(11, 43)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label15)
        Me.SplitContainer1.Panel1.Controls.Add(Me.tb_VCU_DCDC_HVCurrSet)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label14)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label13)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label17)
        Me.SplitContainer1.Panel1.Controls.Add(Me.tb_VCU_DCDC_LVVoltSet)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label8)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label3)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label4)
        Me.SplitContainer1.Panel1.Controls.Add(Me.VsourceBox)
        Me.SplitContainer1.Panel1.Controls.Add(Me.IsourceBox)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.BackColor = System.Drawing.SystemColors.ControlLight
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label45)
        Me.SplitContainer1.Panel2.Controls.Add(Me.VsourMin)
        Me.SplitContainer1.Panel2.Controls.Add(Me.TimeRecordBox)
        Me.SplitContainer1.Panel2.Controls.Add(Me.VsourMax)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label11)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label12)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label6)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label5)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label10)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label9)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label7)
        Me.SplitContainer1.Panel2.Controls.Add(Me.CycTimeBox)
        Me.SplitContainer1.Size = New System.Drawing.Size(1247, 95)
        Me.SplitContainer1.SplitterDistance = 619
        Me.SplitContainer1.TabIndex = 41
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("宋体", 12.0!)
        Me.Label15.Location = New System.Drawing.Point(532, 56)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(16, 16)
        Me.Label15.TabIndex = 51
        Me.Label15.Text = "A"
        '
        'tb_VCU_DCDC_HVCurrSet
        '
        Me.tb_VCU_DCDC_HVCurrSet.Location = New System.Drawing.Point(436, 51)
        Me.tb_VCU_DCDC_HVCurrSet.Name = "tb_VCU_DCDC_HVCurrSet"
        Me.tb_VCU_DCDC_HVCurrSet.Size = New System.Drawing.Size(90, 21)
        Me.tb_VCU_DCDC_HVCurrSet.TabIndex = 50
        Me.tb_VCU_DCDC_HVCurrSet.Text = "20"
        Me.tb_VCU_DCDC_HVCurrSet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("宋体", 12.0!)
        Me.Label14.Location = New System.Drawing.Point(285, 55)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(136, 16)
        Me.Label14.TabIndex = 49
        Me.Label14.Text = "模块最大输入电流"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("宋体", 12.0!)
        Me.Label13.Location = New System.Drawing.Point(532, 18)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(16, 16)
        Me.Label13.TabIndex = 48
        Me.Label13.Text = "V"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("宋体", 12.0!)
        Me.Label17.Location = New System.Drawing.Point(285, 15)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(136, 16)
        Me.Label17.TabIndex = 44
        Me.Label17.Text = "模块输出电压锁定"
        '
        'tb_VCU_DCDC_LVVoltSet
        '
        Me.tb_VCU_DCDC_LVVoltSet.Location = New System.Drawing.Point(436, 12)
        Me.tb_VCU_DCDC_LVVoltSet.Name = "tb_VCU_DCDC_LVVoltSet"
        Me.tb_VCU_DCDC_LVVoltSet.ReadOnly = True
        Me.tb_VCU_DCDC_LVVoltSet.Size = New System.Drawing.Size(90, 21)
        Me.tb_VCU_DCDC_LVVoltSet.TabIndex = 46
        Me.tb_VCU_DCDC_LVVoltSet.Text = "14"
        Me.tb_VCU_DCDC_LVVoltSet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("宋体", 12.0!)
        Me.Label8.Location = New System.Drawing.Point(238, 53)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(16, 16)
        Me.Label8.TabIndex = 39
        Me.Label8.Text = "A"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("宋体", 12.0!)
        Me.Label2.Location = New System.Drawing.Point(238, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(16, 16)
        Me.Label2.TabIndex = 38
        Me.Label2.Text = "V"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("宋体", 12.0!)
        Me.Label1.Location = New System.Drawing.Point(33, 205)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 16)
        Me.Label1.TabIndex = 37
        '
        'Label45
        '
        Me.Label45.AutoSize = True
        Me.Label45.Font = New System.Drawing.Font("宋体", 12.0!)
        Me.Label45.Location = New System.Drawing.Point(553, 15)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(32, 16)
        Me.Label45.TabIndex = 83
        Me.Label45.Text = "min"
        '
        'TimeRecordBox
        '
        Me.TimeRecordBox.Location = New System.Drawing.Point(455, 13)
        Me.TimeRecordBox.Name = "TimeRecordBox"
        Me.TimeRecordBox.Size = New System.Drawing.Size(90, 21)
        Me.TimeRecordBox.TabIndex = 45
        Me.TimeRecordBox.Text = "1"
        Me.TimeRecordBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("宋体", 12.0!)
        Me.Label11.Location = New System.Drawing.Point(553, 52)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(16, 16)
        Me.Label11.TabIndex = 42
        Me.Label11.Text = "H"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("宋体", 12.0!)
        Me.Label12.Location = New System.Drawing.Point(340, 16)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(104, 16)
        Me.Label12.TabIndex = 43
        Me.Label12.Text = "运行记录间隔"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("宋体", 12.0!)
        Me.Label10.Location = New System.Drawing.Point(268, 51)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(16, 16)
        Me.Label10.TabIndex = 41
        Me.Label10.Text = "A"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("宋体", 12.0!)
        Me.Label9.Location = New System.Drawing.Point(268, 17)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(16, 16)
        Me.Label9.TabIndex = 40
        Me.Label9.Text = "V"
        '
        'SerialPort1
        '
        '
        'SerialPort2
        '
        '
        'tmrRead
        '
        Me.tmrRead.Enabled = True
        Me.tmrRead.Interval = 200
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Location = New System.Drawing.Point(184, 328)
        Me.SplitContainer2.Name = "SplitContainer2"
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.Label18)
        Me.SplitContainer2.Panel1.Controls.Add(Me.Label29)
        Me.SplitContainer2.Panel1.Controls.Add(Me.TextBox1)
        Me.SplitContainer2.Panel1.Controls.Add(Me.Vsour)
        Me.SplitContainer2.Panel1.Controls.Add(Me.Label38)
        Me.SplitContainer2.Panel1.Controls.Add(Me.Label35)
        Me.SplitContainer2.Panel1.Controls.Add(Me.ILoadBox)
        Me.SplitContainer2.Panel1.Controls.Add(Me.Label37)
        Me.SplitContainer2.Panel1.Controls.Add(Me.Label34)
        Me.SplitContainer2.Panel1.Controls.Add(Me.Label32)
        Me.SplitContainer2.Panel1.Controls.Add(Me.Label36)
        Me.SplitContainer2.Panel1.Controls.Add(Me.VLoadBox)
        Me.SplitContainer2.Panel1.Controls.Add(Me.Isour)
        Me.SplitContainer2.Panel1.Controls.Add(Me.Label33)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.Label20)
        Me.SplitContainer2.Panel2.Controls.Add(Me.TextBox2)
        Me.SplitContainer2.Panel2.Controls.Add(Me.Label57)
        Me.SplitContainer2.Panel2.Controls.Add(Me.Label30)
        Me.SplitContainer2.Panel2.Controls.Add(Me.Label26)
        Me.SplitContainer2.Panel2.Controls.Add(Me.RuntimeBox)
        Me.SplitContainer2.Panel2.Controls.Add(Me.Result)
        Me.SplitContainer2.Panel2.Controls.Add(Me.Label28)
        Me.SplitContainer2.Panel2.Controls.Add(Me.Label31)
        Me.SplitContainer2.Panel2.Controls.Add(Me.RunnumBox)
        Me.SplitContainer2.Size = New System.Drawing.Size(893, 114)
        Me.SplitContainer2.SplitterDistance = 445
        Me.SplitContainer2.TabIndex = 99
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("宋体", 12.0!)
        Me.Label18.Location = New System.Drawing.Point(20, 13)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(104, 16)
        Me.Label18.TabIndex = 101
        Me.Label18.Text = "电源回传讯息"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("宋体", 12.0!)
        Me.Label29.Location = New System.Drawing.Point(20, 43)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(72, 16)
        Me.Label29.TabIndex = 85
        Me.Label29.Text = "电源电压"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(134, 11)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(265, 21)
        Me.TextBox1.TabIndex = 100
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Vsour
        '
        Me.Vsour.Font = New System.Drawing.Font("宋体", 10.0!)
        Me.Vsour.Location = New System.Drawing.Point(97, 40)
        Me.Vsour.Name = "Vsour"
        Me.Vsour.Size = New System.Drawing.Size(88, 23)
        Me.Vsour.TabIndex = 89
        Me.Vsour.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.Font = New System.Drawing.Font("宋体", 12.0!)
        Me.Label38.Location = New System.Drawing.Point(405, 80)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(16, 16)
        Me.Label38.TabIndex = 95
        Me.Label38.Text = "A"
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Font = New System.Drawing.Font("宋体", 12.0!)
        Me.Label35.Location = New System.Drawing.Point(195, 44)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(16, 16)
        Me.Label35.TabIndex = 92
        Me.Label35.Text = "V"
        '
        'ILoadBox
        '
        Me.ILoadBox.Font = New System.Drawing.Font("宋体", 10.0!)
        Me.ILoadBox.Location = New System.Drawing.Point(311, 77)
        Me.ILoadBox.Name = "ILoadBox"
        Me.ILoadBox.Size = New System.Drawing.Size(88, 23)
        Me.ILoadBox.TabIndex = 91
        Me.ILoadBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Font = New System.Drawing.Font("宋体", 12.0!)
        Me.Label37.Location = New System.Drawing.Point(195, 76)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(16, 16)
        Me.Label37.TabIndex = 94
        Me.Label37.Text = "V"
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Font = New System.Drawing.Font("宋体", 12.0!)
        Me.Label34.Location = New System.Drawing.Point(233, 80)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(72, 16)
        Me.Label34.TabIndex = 88
        Me.Label34.Text = "负载电流"
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Font = New System.Drawing.Font("宋体", 12.0!)
        Me.Label32.Location = New System.Drawing.Point(233, 43)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(72, 16)
        Me.Label32.TabIndex = 86
        Me.Label32.Text = "电源电流"
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Font = New System.Drawing.Font("宋体", 12.0!)
        Me.Label36.Location = New System.Drawing.Point(405, 44)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(16, 16)
        Me.Label36.TabIndex = 93
        Me.Label36.Text = "A"
        '
        'VLoadBox
        '
        Me.VLoadBox.Font = New System.Drawing.Font("宋体", 10.0!)
        Me.VLoadBox.Location = New System.Drawing.Point(97, 73)
        Me.VLoadBox.Name = "VLoadBox"
        Me.VLoadBox.Size = New System.Drawing.Size(88, 23)
        Me.VLoadBox.TabIndex = 90
        Me.VLoadBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Isour
        '
        Me.Isour.Font = New System.Drawing.Font("宋体", 10.0!)
        Me.Isour.Location = New System.Drawing.Point(311, 40)
        Me.Isour.Name = "Isour"
        Me.Isour.Size = New System.Drawing.Size(88, 23)
        Me.Isour.TabIndex = 74
        Me.Isour.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Font = New System.Drawing.Font("宋体", 12.0!)
        Me.Label33.Location = New System.Drawing.Point(20, 76)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(72, 16)
        Me.Label33.TabIndex = 87
        Me.Label33.Text = "负载电压"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("宋体", 12.0!)
        Me.Label20.Location = New System.Drawing.Point(8, 13)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(96, 16)
        Me.Label20.TabIndex = 102
        Me.Label20.Text = "CAN回传讯息"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(121, 11)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(265, 21)
        Me.TextBox2.TabIndex = 101
        Me.TextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label57
        '
        Me.Label57.AutoSize = True
        Me.Label57.Font = New System.Drawing.Font("宋体", 12.0!)
        Me.Label57.Location = New System.Drawing.Point(412, 45)
        Me.Label57.Name = "Label57"
        Me.Label57.Size = New System.Drawing.Size(24, 16)
        Me.Label57.TabIndex = 97
        Me.Label57.Text = "次"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Font = New System.Drawing.Font("宋体", 12.0!)
        Me.Label30.Location = New System.Drawing.Point(188, 45)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(16, 16)
        Me.Label30.TabIndex = 85
        Me.Label30.Text = "H"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("宋体", 12.0!)
        Me.Label26.Location = New System.Drawing.Point(5, 47)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(88, 16)
        Me.Label26.TabIndex = 75
        Me.Label26.Text = "已运行时间"
        '
        'RuntimeBox
        '
        Me.RuntimeBox.Location = New System.Drawing.Point(99, 43)
        Me.RuntimeBox.Name = "RuntimeBox"
        Me.RuntimeBox.Size = New System.Drawing.Size(83, 21)
        Me.RuntimeBox.TabIndex = 83
        Me.RuntimeBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Result
        '
        Me.Result.AutoSize = True
        Me.Result.Font = New System.Drawing.Font("宋体", 12.0!)
        Me.Result.ForeColor = System.Drawing.Color.Lime
        Me.Result.Location = New System.Drawing.Point(283, 80)
        Me.Result.Name = "Result"
        Me.Result.Size = New System.Drawing.Size(40, 16)
        Me.Result.TabIndex = 84
        Me.Result.Text = "Pass"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("宋体", 12.0!)
        Me.Label28.Location = New System.Drawing.Point(224, 47)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(88, 16)
        Me.Label28.TabIndex = 76
        Me.Label28.Text = "已运行次数"
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Font = New System.Drawing.Font("宋体", 12.0!)
        Me.Label31.Location = New System.Drawing.Point(63, 80)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(72, 16)
        Me.Label31.TabIndex = 79
        Me.Label31.Text = "实验结果"
        '
        'RunnumBox
        '
        Me.RunnumBox.Location = New System.Drawing.Point(318, 43)
        Me.RunnumBox.Name = "RunnumBox"
        Me.RunnumBox.Size = New System.Drawing.Size(88, 21)
        Me.RunnumBox.TabIndex = 82
        Me.RunnumBox.Text = "0"
        Me.RunnumBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'SplitContainer3
        '
        Me.SplitContainer3.BackColor = System.Drawing.SystemColors.ControlLight
        Me.SplitContainer3.Location = New System.Drawing.Point(185, 144)
        Me.SplitContainer3.Name = "SplitContainer3"
        '
        'SplitContainer3.Panel1
        '
        Me.SplitContainer3.Panel1.Controls.Add(Me.Vin_OVP_Shape1)
        Me.SplitContainer3.Panel1.Controls.Add(Me.Vout_OVP_Shape1)
        Me.SplitContainer3.Panel1.Controls.Add(Me.OTP_Shape1)
        Me.SplitContainer3.Panel1.Controls.Add(Me.Vin_UVP_Shape1)
        Me.SplitContainer3.Panel1.Controls.Add(Me.Vout_Short_Shape1)
        Me.SplitContainer3.Panel1.Controls.Add(Me.Label39)
        Me.SplitContainer3.Panel1.Controls.Add(Me.Label40)
        Me.SplitContainer3.Panel1.Controls.Add(Me.Label41)
        Me.SplitContainer3.Panel1.Controls.Add(Me.Label42)
        Me.SplitContainer3.Panel1.Controls.Add(Me.Label43)
        Me.SplitContainer3.Panel1.Controls.Add(Me.Label44)
        Me.SplitContainer3.Panel1.Controls.Add(Me.Label19)
        Me.SplitContainer3.Panel1.Controls.Add(Me.Label46)
        Me.SplitContainer3.Panel1.Controls.Add(Me.Label47)
        Me.SplitContainer3.Panel1.Controls.Add(Me.TempBox1)
        Me.SplitContainer3.Panel1.Controls.Add(Me.VoutBox1)
        Me.SplitContainer3.Panel1.Controls.Add(Me.IoutBox1)
        Me.SplitContainer3.Panel1.Controls.Add(Me.Label48)
        Me.SplitContainer3.Panel1.Controls.Add(Me.Label49)
        Me.SplitContainer3.Panel1.Controls.Add(Me.Label50)
        '
        'SplitContainer3.Panel2
        '
        Me.SplitContainer3.Panel2.Controls.Add(Me.Vin_OVP_Shape2)
        Me.SplitContainer3.Panel2.Controls.Add(Me.Vout_OVP_Shape2)
        Me.SplitContainer3.Panel2.Controls.Add(Me.OTP_Shape2)
        Me.SplitContainer3.Panel2.Controls.Add(Me.Vin_UVP_Shape2)
        Me.SplitContainer3.Panel2.Controls.Add(Me.Vout_Short_Shape2)
        Me.SplitContainer3.Panel2.Controls.Add(Me.Label21)
        Me.SplitContainer3.Panel2.Controls.Add(Me.Label22)
        Me.SplitContainer3.Panel2.Controls.Add(Me.Label23)
        Me.SplitContainer3.Panel2.Controls.Add(Me.Label24)
        Me.SplitContainer3.Panel2.Controls.Add(Me.Label25)
        Me.SplitContainer3.Panel2.Controls.Add(Me.Label27)
        Me.SplitContainer3.Panel2.Controls.Add(Me.Label51)
        Me.SplitContainer3.Panel2.Controls.Add(Me.Label52)
        Me.SplitContainer3.Panel2.Controls.Add(Me.Label53)
        Me.SplitContainer3.Panel2.Controls.Add(Me.TempBox2)
        Me.SplitContainer3.Panel2.Controls.Add(Me.VoutBox2)
        Me.SplitContainer3.Panel2.Controls.Add(Me.IoutBox2)
        Me.SplitContainer3.Panel2.Controls.Add(Me.Label54)
        Me.SplitContainer3.Panel2.Controls.Add(Me.Label55)
        Me.SplitContainer3.Panel2.Controls.Add(Me.Label56)
        Me.SplitContainer3.Size = New System.Drawing.Size(894, 173)
        Me.SplitContainer3.SplitterDistance = 444
        Me.SplitContainer3.TabIndex = 98
        '
        'Vin_OVP_Shape1
        '
        Me.Vin_OVP_Shape1.AutoSize = True
        Me.Vin_OVP_Shape1.Font = New System.Drawing.Font("宋体", 12.0!)
        Me.Vin_OVP_Shape1.ForeColor = System.Drawing.Color.Lime
        Me.Vin_OVP_Shape1.Location = New System.Drawing.Point(247, 126)
        Me.Vin_OVP_Shape1.Name = "Vin_OVP_Shape1"
        Me.Vin_OVP_Shape1.Size = New System.Drawing.Size(40, 16)
        Me.Vin_OVP_Shape1.TabIndex = 106
        Me.Vin_OVP_Shape1.Text = "正常"
        '
        'Vout_OVP_Shape1
        '
        Me.Vout_OVP_Shape1.AutoSize = True
        Me.Vout_OVP_Shape1.Font = New System.Drawing.Font("宋体", 12.0!)
        Me.Vout_OVP_Shape1.ForeColor = System.Drawing.Color.Lime
        Me.Vout_OVP_Shape1.Location = New System.Drawing.Point(247, 88)
        Me.Vout_OVP_Shape1.Name = "Vout_OVP_Shape1"
        Me.Vout_OVP_Shape1.Size = New System.Drawing.Size(40, 16)
        Me.Vout_OVP_Shape1.TabIndex = 105
        Me.Vout_OVP_Shape1.Text = "正常"
        '
        'OTP_Shape1
        '
        Me.OTP_Shape1.AutoSize = True
        Me.OTP_Shape1.Font = New System.Drawing.Font("宋体", 12.0!)
        Me.OTP_Shape1.ForeColor = System.Drawing.Color.Lime
        Me.OTP_Shape1.Location = New System.Drawing.Point(388, 129)
        Me.OTP_Shape1.Name = "OTP_Shape1"
        Me.OTP_Shape1.Size = New System.Drawing.Size(40, 16)
        Me.OTP_Shape1.TabIndex = 104
        Me.OTP_Shape1.Text = "正常"
        '
        'Vin_UVP_Shape1
        '
        Me.Vin_UVP_Shape1.AutoSize = True
        Me.Vin_UVP_Shape1.Font = New System.Drawing.Font("宋体", 12.0!)
        Me.Vin_UVP_Shape1.ForeColor = System.Drawing.Color.Lime
        Me.Vin_UVP_Shape1.Location = New System.Drawing.Point(93, 126)
        Me.Vin_UVP_Shape1.Name = "Vin_UVP_Shape1"
        Me.Vin_UVP_Shape1.Size = New System.Drawing.Size(40, 16)
        Me.Vin_UVP_Shape1.TabIndex = 103
        Me.Vin_UVP_Shape1.Text = "正常"
        '
        'Vout_Short_Shape1
        '
        Me.Vout_Short_Shape1.AutoSize = True
        Me.Vout_Short_Shape1.Font = New System.Drawing.Font("宋体", 12.0!)
        Me.Vout_Short_Shape1.ForeColor = System.Drawing.Color.Lime
        Me.Vout_Short_Shape1.Location = New System.Drawing.Point(388, 88)
        Me.Vout_Short_Shape1.Name = "Vout_Short_Shape1"
        Me.Vout_Short_Shape1.Size = New System.Drawing.Size(40, 16)
        Me.Vout_Short_Shape1.TabIndex = 102
        Me.Vout_Short_Shape1.Text = "正常"
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.Font = New System.Drawing.Font("宋体", 10.0!)
        Me.Label39.Location = New System.Drawing.Point(175, 126)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(63, 14)
        Me.Label39.TabIndex = 101
        Me.Label39.Text = "输入过压"
        '
        'Label40
        '
        Me.Label40.AutoSize = True
        Me.Label40.Font = New System.Drawing.Font("宋体", 10.0!)
        Me.Label40.Location = New System.Drawing.Point(17, 126)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(63, 14)
        Me.Label40.TabIndex = 100
        Me.Label40.Text = "输入欠压"
        '
        'Label41
        '
        Me.Label41.AutoSize = True
        Me.Label41.Font = New System.Drawing.Font("宋体", 10.0!)
        Me.Label41.Location = New System.Drawing.Point(175, 88)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(63, 14)
        Me.Label41.TabIndex = 99
        Me.Label41.Text = "输出过压"
        '
        'Label42
        '
        Me.Label42.AutoSize = True
        Me.Label42.Font = New System.Drawing.Font("宋体", 10.0!)
        Me.Label42.Location = New System.Drawing.Point(335, 129)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(35, 14)
        Me.Label42.TabIndex = 98
        Me.Label42.Text = "过温"
        '
        'Label43
        '
        Me.Label43.AutoSize = True
        Me.Label43.Font = New System.Drawing.Font("宋体", 10.0!)
        Me.Label43.Location = New System.Drawing.Point(319, 90)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(63, 14)
        Me.Label43.TabIndex = 97
        Me.Label43.Text = "输出短路"
        '
        'Label44
        '
        Me.Label44.AutoSize = True
        Me.Label44.Font = New System.Drawing.Font("宋体", 18.0!)
        Me.Label44.Location = New System.Drawing.Point(55, 83)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(46, 24)
        Me.Label44.TabIndex = 83
        Me.Label44.Text = "249"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("宋体", 12.0!)
        Me.Label19.Location = New System.Drawing.Point(394, 46)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(24, 16)
        Me.Label19.TabIndex = 82
        Me.Label19.Text = "℃"
        '
        'Label46
        '
        Me.Label46.AutoSize = True
        Me.Label46.Font = New System.Drawing.Font("宋体", 12.0!)
        Me.Label46.Location = New System.Drawing.Point(98, 46)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(16, 16)
        Me.Label46.TabIndex = 81
        Me.Label46.Text = "A"
        '
        'Label47
        '
        Me.Label47.AutoSize = True
        Me.Label47.Font = New System.Drawing.Font("宋体", 12.0!)
        Me.Label47.Location = New System.Drawing.Point(255, 46)
        Me.Label47.Name = "Label47"
        Me.Label47.Size = New System.Drawing.Size(16, 16)
        Me.Label47.TabIndex = 80
        Me.Label47.Text = "V"
        '
        'TempBox1
        '
        Me.TempBox1.Font = New System.Drawing.Font("宋体", 10.0!)
        Me.TempBox1.Location = New System.Drawing.Point(322, 42)
        Me.TempBox1.Name = "TempBox1"
        Me.TempBox1.Size = New System.Drawing.Size(66, 23)
        Me.TempBox1.TabIndex = 79
        Me.TempBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'VoutBox1
        '
        Me.VoutBox1.Font = New System.Drawing.Font("宋体", 10.0!)
        Me.VoutBox1.Location = New System.Drawing.Point(182, 42)
        Me.VoutBox1.Name = "VoutBox1"
        Me.VoutBox1.Size = New System.Drawing.Size(66, 23)
        Me.VoutBox1.TabIndex = 78
        Me.VoutBox1.Text = "14"
        Me.VoutBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'IoutBox1
        '
        Me.IoutBox1.Font = New System.Drawing.Font("宋体", 10.0!)
        Me.IoutBox1.Location = New System.Drawing.Point(26, 42)
        Me.IoutBox1.Name = "IoutBox1"
        Me.IoutBox1.Size = New System.Drawing.Size(66, 23)
        Me.IoutBox1.TabIndex = 77
        Me.IoutBox1.Text = "0"
        Me.IoutBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label48
        '
        Me.Label48.AutoSize = True
        Me.Label48.Font = New System.Drawing.Font("宋体", 12.0!)
        Me.Label48.Location = New System.Drawing.Point(327, 13)
        Me.Label48.Name = "Label48"
        Me.Label48.Size = New System.Drawing.Size(72, 16)
        Me.Label48.TabIndex = 76
        Me.Label48.Text = "实体温度"
        '
        'Label49
        '
        Me.Label49.AutoSize = True
        Me.Label49.Font = New System.Drawing.Font("宋体", 12.0!)
        Me.Label49.Location = New System.Drawing.Point(193, 13)
        Me.Label49.Name = "Label49"
        Me.Label49.Size = New System.Drawing.Size(72, 16)
        Me.Label49.TabIndex = 75
        Me.Label49.Text = "输出电压"
        '
        'Label50
        '
        Me.Label50.AutoSize = True
        Me.Label50.Font = New System.Drawing.Font("宋体", 12.0!)
        Me.Label50.Location = New System.Drawing.Point(29, 13)
        Me.Label50.Name = "Label50"
        Me.Label50.Size = New System.Drawing.Size(72, 16)
        Me.Label50.TabIndex = 74
        Me.Label50.Text = "输出电流"
        '
        'Vin_OVP_Shape2
        '
        Me.Vin_OVP_Shape2.AutoSize = True
        Me.Vin_OVP_Shape2.Font = New System.Drawing.Font("宋体", 12.0!)
        Me.Vin_OVP_Shape2.ForeColor = System.Drawing.Color.Lime
        Me.Vin_OVP_Shape2.Location = New System.Drawing.Point(243, 121)
        Me.Vin_OVP_Shape2.Name = "Vin_OVP_Shape2"
        Me.Vin_OVP_Shape2.Size = New System.Drawing.Size(40, 16)
        Me.Vin_OVP_Shape2.TabIndex = 121
        Me.Vin_OVP_Shape2.Text = "正常"
        '
        'Vout_OVP_Shape2
        '
        Me.Vout_OVP_Shape2.AutoSize = True
        Me.Vout_OVP_Shape2.Font = New System.Drawing.Font("宋体", 12.0!)
        Me.Vout_OVP_Shape2.ForeColor = System.Drawing.Color.Lime
        Me.Vout_OVP_Shape2.Location = New System.Drawing.Point(243, 83)
        Me.Vout_OVP_Shape2.Name = "Vout_OVP_Shape2"
        Me.Vout_OVP_Shape2.Size = New System.Drawing.Size(40, 16)
        Me.Vout_OVP_Shape2.TabIndex = 120
        Me.Vout_OVP_Shape2.Text = "正常"
        '
        'OTP_Shape2
        '
        Me.OTP_Shape2.AutoSize = True
        Me.OTP_Shape2.Font = New System.Drawing.Font("宋体", 12.0!)
        Me.OTP_Shape2.ForeColor = System.Drawing.Color.Lime
        Me.OTP_Shape2.Location = New System.Drawing.Point(384, 124)
        Me.OTP_Shape2.Name = "OTP_Shape2"
        Me.OTP_Shape2.Size = New System.Drawing.Size(40, 16)
        Me.OTP_Shape2.TabIndex = 119
        Me.OTP_Shape2.Text = "正常"
        '
        'Vin_UVP_Shape2
        '
        Me.Vin_UVP_Shape2.AutoSize = True
        Me.Vin_UVP_Shape2.Font = New System.Drawing.Font("宋体", 12.0!)
        Me.Vin_UVP_Shape2.ForeColor = System.Drawing.Color.Lime
        Me.Vin_UVP_Shape2.Location = New System.Drawing.Point(89, 121)
        Me.Vin_UVP_Shape2.Name = "Vin_UVP_Shape2"
        Me.Vin_UVP_Shape2.Size = New System.Drawing.Size(40, 16)
        Me.Vin_UVP_Shape2.TabIndex = 118
        Me.Vin_UVP_Shape2.Text = "正常"
        '
        'Vout_Short_Shape2
        '
        Me.Vout_Short_Shape2.AutoSize = True
        Me.Vout_Short_Shape2.Font = New System.Drawing.Font("宋体", 12.0!)
        Me.Vout_Short_Shape2.ForeColor = System.Drawing.Color.Lime
        Me.Vout_Short_Shape2.Location = New System.Drawing.Point(384, 83)
        Me.Vout_Short_Shape2.Name = "Vout_Short_Shape2"
        Me.Vout_Short_Shape2.Size = New System.Drawing.Size(40, 16)
        Me.Vout_Short_Shape2.TabIndex = 117
        Me.Vout_Short_Shape2.Text = "正常"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("宋体", 10.0!)
        Me.Label21.Location = New System.Drawing.Point(171, 121)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(63, 14)
        Me.Label21.TabIndex = 116
        Me.Label21.Text = "输入过压"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("宋体", 10.0!)
        Me.Label22.Location = New System.Drawing.Point(13, 121)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(63, 14)
        Me.Label22.TabIndex = 115
        Me.Label22.Text = "输入欠压"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("宋体", 10.0!)
        Me.Label23.Location = New System.Drawing.Point(171, 83)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(63, 14)
        Me.Label23.TabIndex = 114
        Me.Label23.Text = "输出过压"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("宋体", 10.0!)
        Me.Label24.Location = New System.Drawing.Point(331, 124)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(35, 14)
        Me.Label24.TabIndex = 113
        Me.Label24.Text = "过温"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("宋体", 10.0!)
        Me.Label25.Location = New System.Drawing.Point(315, 85)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(63, 14)
        Me.Label25.TabIndex = 112
        Me.Label25.Text = "输出短路"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("宋体", 18.0!)
        Me.Label27.Location = New System.Drawing.Point(53, 76)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(46, 24)
        Me.Label27.TabIndex = 99
        Me.Label27.Text = "250"
        '
        'Label51
        '
        Me.Label51.AutoSize = True
        Me.Label51.Font = New System.Drawing.Font("宋体", 12.0!)
        Me.Label51.Location = New System.Drawing.Point(391, 44)
        Me.Label51.Name = "Label51"
        Me.Label51.Size = New System.Drawing.Size(24, 16)
        Me.Label51.TabIndex = 98
        Me.Label51.Text = "℃"
        '
        'Label52
        '
        Me.Label52.AutoSize = True
        Me.Label52.Font = New System.Drawing.Font("宋体", 12.0!)
        Me.Label52.Location = New System.Drawing.Point(100, 45)
        Me.Label52.Name = "Label52"
        Me.Label52.Size = New System.Drawing.Size(16, 16)
        Me.Label52.TabIndex = 97
        Me.Label52.Text = "A"
        '
        'Label53
        '
        Me.Label53.AutoSize = True
        Me.Label53.Font = New System.Drawing.Font("宋体", 12.0!)
        Me.Label53.Location = New System.Drawing.Point(253, 43)
        Me.Label53.Name = "Label53"
        Me.Label53.Size = New System.Drawing.Size(16, 16)
        Me.Label53.TabIndex = 96
        Me.Label53.Text = "V"
        '
        'TempBox2
        '
        Me.TempBox2.Font = New System.Drawing.Font("宋体", 10.0!)
        Me.TempBox2.Location = New System.Drawing.Point(319, 41)
        Me.TempBox2.Name = "TempBox2"
        Me.TempBox2.Size = New System.Drawing.Size(66, 23)
        Me.TempBox2.TabIndex = 95
        Me.TempBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'VoutBox2
        '
        Me.VoutBox2.Font = New System.Drawing.Font("宋体", 10.0!)
        Me.VoutBox2.Location = New System.Drawing.Point(181, 39)
        Me.VoutBox2.Name = "VoutBox2"
        Me.VoutBox2.Size = New System.Drawing.Size(66, 23)
        Me.VoutBox2.TabIndex = 94
        Me.VoutBox2.Text = "14"
        Me.VoutBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'IoutBox2
        '
        Me.IoutBox2.Font = New System.Drawing.Font("宋体", 10.0!)
        Me.IoutBox2.Location = New System.Drawing.Point(28, 41)
        Me.IoutBox2.Name = "IoutBox2"
        Me.IoutBox2.Size = New System.Drawing.Size(66, 23)
        Me.IoutBox2.TabIndex = 93
        Me.IoutBox2.Text = "0"
        Me.IoutBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label54
        '
        Me.Label54.AutoSize = True
        Me.Label54.Font = New System.Drawing.Font("宋体", 12.0!)
        Me.Label54.Location = New System.Drawing.Point(322, 13)
        Me.Label54.Name = "Label54"
        Me.Label54.Size = New System.Drawing.Size(72, 16)
        Me.Label54.TabIndex = 92
        Me.Label54.Text = "实体温度"
        '
        'Label55
        '
        Me.Label55.AutoSize = True
        Me.Label55.Font = New System.Drawing.Font("宋体", 12.0!)
        Me.Label55.Location = New System.Drawing.Point(189, 13)
        Me.Label55.Name = "Label55"
        Me.Label55.Size = New System.Drawing.Size(72, 16)
        Me.Label55.TabIndex = 91
        Me.Label55.Text = "输出电压"
        '
        'Label56
        '
        Me.Label56.AutoSize = True
        Me.Label56.Font = New System.Drawing.Font("宋体", 12.0!)
        Me.Label56.Location = New System.Drawing.Point(40, 13)
        Me.Label56.Name = "Label56"
        Me.Label56.Size = New System.Drawing.Size(72, 16)
        Me.Label56.TabIndex = 90
        Me.Label56.Text = "输出电流"
        '
        'cbb_VCU_DCDCReq
        '
        Me.cbb_VCU_DCDCReq.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbb_VCU_DCDCReq.FormattingEnabled = True
        Me.cbb_VCU_DCDCReq.Items.AddRange(New Object() {"Inactive", "Buck"})
        Me.cbb_VCU_DCDCReq.Location = New System.Drawing.Point(1137, 249)
        Me.cbb_VCU_DCDCReq.Name = "cbb_VCU_DCDCReq"
        Me.cbb_VCU_DCDCReq.Size = New System.Drawing.Size(86, 20)
        Me.cbb_VCU_DCDCReq.TabIndex = 56
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1282, 458)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.cbb_VCU_DCDCReq)
        Me.Controls.Add(Me.SplitContainer3)
        Me.Controls.Add(Me.SplitContainer2)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.EndButton)
        Me.Controls.Add(Me.BeginButton)
        Me.Controls.Add(Me.IoutSetButton)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.PerformLayout()
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        Me.SplitContainer2.Panel2.PerformLayout()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        Me.SplitContainer3.Panel1.ResumeLayout(False)
        Me.SplitContainer3.Panel1.PerformLayout()
        Me.SplitContainer3.Panel2.ResumeLayout(False)
        Me.SplitContainer3.Panel2.PerformLayout()
        CType(Me.SplitContainer3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer3.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents IoutSetButton As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents BeginButton As System.Windows.Forms.Button
    Friend WithEvents EndButton As System.Windows.Forms.Button
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents VsourceBox As System.Windows.Forms.TextBox
    Friend WithEvents IsourceBox As System.Windows.Forms.TextBox
    Friend WithEvents CycTimeBox As System.Windows.Forms.TextBox
    Friend WithEvents VsourMax As System.Windows.Forms.TextBox
    Friend WithEvents VsourMin As System.Windows.Forms.TextBox
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TimeRecordBox As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label45 As System.Windows.Forms.Label
    Friend WithEvents SerialPort1 As System.IO.Ports.SerialPort
    Friend WithEvents SerialPort2 As System.IO.Ports.SerialPort
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents tb_VCU_DCDC_LVVoltSet As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents tb_VCU_DCDC_HVCurrSet As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Private WithEvents tmrRead As System.Windows.Forms.Timer
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents Vsour As System.Windows.Forms.TextBox
    Friend WithEvents Label38 As System.Windows.Forms.Label
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents ILoadBox As System.Windows.Forms.TextBox
    Friend WithEvents Label37 As System.Windows.Forms.Label
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents VLoadBox As System.Windows.Forms.TextBox
    Friend WithEvents Isour As System.Windows.Forms.TextBox
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents RuntimeBox As System.Windows.Forms.TextBox
    Friend WithEvents Result As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents RunnumBox As System.Windows.Forms.TextBox
    Friend WithEvents SplitContainer3 As System.Windows.Forms.SplitContainer
    Friend WithEvents Vin_OVP_Shape1 As System.Windows.Forms.Label
    Friend WithEvents Vout_OVP_Shape1 As System.Windows.Forms.Label
    Friend WithEvents OTP_Shape1 As System.Windows.Forms.Label
    Friend WithEvents Vin_UVP_Shape1 As System.Windows.Forms.Label
    Friend WithEvents Vout_Short_Shape1 As System.Windows.Forms.Label
    Friend WithEvents Label39 As System.Windows.Forms.Label
    Friend WithEvents Label40 As System.Windows.Forms.Label
    Friend WithEvents Label41 As System.Windows.Forms.Label
    Friend WithEvents Label42 As System.Windows.Forms.Label
    Friend WithEvents Label43 As System.Windows.Forms.Label
    Friend WithEvents Label44 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label46 As System.Windows.Forms.Label
    Friend WithEvents Label47 As System.Windows.Forms.Label
    Friend WithEvents TempBox1 As System.Windows.Forms.TextBox
    Friend WithEvents VoutBox1 As System.Windows.Forms.TextBox
    Friend WithEvents IoutBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label48 As System.Windows.Forms.Label
    Friend WithEvents Label49 As System.Windows.Forms.Label
    Friend WithEvents Label50 As System.Windows.Forms.Label
    Friend WithEvents Vin_OVP_Shape2 As System.Windows.Forms.Label
    Friend WithEvents Vout_OVP_Shape2 As System.Windows.Forms.Label
    Friend WithEvents OTP_Shape2 As System.Windows.Forms.Label
    Friend WithEvents Vin_UVP_Shape2 As System.Windows.Forms.Label
    Friend WithEvents Vout_Short_Shape2 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label51 As System.Windows.Forms.Label
    Friend WithEvents Label52 As System.Windows.Forms.Label
    Friend WithEvents Label53 As System.Windows.Forms.Label
    Friend WithEvents TempBox2 As System.Windows.Forms.TextBox
    Friend WithEvents VoutBox2 As System.Windows.Forms.TextBox
    Friend WithEvents IoutBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label54 As System.Windows.Forms.Label
    Friend WithEvents Label55 As System.Windows.Forms.Label
    Friend WithEvents Label56 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label57 As System.Windows.Forms.Label
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents cbb_VCU_DCDCReq As System.Windows.Forms.ComboBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label

End Class
