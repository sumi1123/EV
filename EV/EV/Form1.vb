Option Strict Off
Option Explicit On
Public Class Form1
    '*******************************************************************************************************************’
    '******************************************************变量定义*****************************************************’
    '*******************************************************************************************************************’
    '发送
    Public VCU_RollingCounter_215 As Integer = 0
    Public VCU_Checksum_215 As Single = 0
    Dim Num As Integer = 0
    Dim NumCounter As Integer

    '数据库
    Dim objDs As New DataSet '  一个数据集DataSet对象
    Dim objXSTable As DataTable '  一个Table对象
    Dim objDa As New OleDb.OleDbDataAdapter '  一个OleDbDataAdapter对象
    Dim WhereStr As String '  保存查询条件字符串
    Dim sqlnum As Integer = 0
    '*******************************************************************************************************************’
    '******************************************************函数定义*****************************************************’
    '*******************************************************************************************************************’
    '电源接收函数
    Delegate Sub RecieveRefreshMethodDelegate(ByVal [text] As String) '声明委托
    Dim RecieveRefresh As New RecieveRefreshMethodDelegate(AddressOf RecieveRefreshMethod) '定义一个委托实例
    Sub RecieveRefreshMethod(ByVal str As String) '定义一个实例方法
        ShowRecieveData(str)
    End Sub
    Private Sub ShowRecieveData(ByVal str As String)
        TextBox1.Text += str
        Exit Sub
    End Sub
    Private Sub SerialPort_DataReceived(ByVal sender As Object, ByVal e As System.IO.Ports.SerialDataReceivedEventArgs) Handles SerialPort1.DataReceived
        '-----------十六进制显示------------
        Dim inDataLen As Integer = SerialPort1.BytesToRead()
        If inDataLen > 0 Then
            Dim inBytes(inDataLen - 1) As Byte, bytes As Byte
            Dim strHex As String = ""
            SerialPort1.Read(inBytes, 0, inDataLen)
            For Each bytes In inBytes
                strHex = strHex + [String].Format("{0:X2}", bytes)
            Next
            TextBox1.Invoke(RecieveRefresh, strHex)
        End If
    End Sub
    '负载接收函数
    Public Sub Sp_DataReceived(ByVal sender As Object, ByVal e As System.IO.Ports.SerialDataReceivedEventArgs) Handles SerialPort2.DataReceived
        Me.Invoke(New EventHandler(AddressOf Sp_Receiving)) '调用接收数据函数
    End Sub
    Private Sub Sp_Receiving(ByVal sender As Object, ByVal e As EventArgs)
        Dim strIncoming As String
        Try
            rec_load = Str(Val(rec_load) + SerialPort2.BytesToRead)
            If SerialPort2.BytesToRead > 0 Then
                Threading.Thread.Sleep(50) '接收缓冲区数据
                strIncoming = SerialPort2.ReadExisting.ToString '读取缓冲区中的数据
                SerialPort2.DiscardInBuffer()
                rec_load = strIncoming
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    '数据库更新函数
    Public Sub refreshdata() '  更新并刷新显示
        objDa.Update(objDs, "EV") '  更新
        objXSTable.Clear() '  清空
    End Sub

    '*******************************************************************************************************************’
    '*******************************************************主程序******************************************************’
    '*******************************************************************************************************************’
    '载入界面设置
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        '***************************************************************************************************************’
        DataGridView1(0, 0).Value = 1
        'Can通讯配置
        cbb_VCU_DCDCReq.SelectedIndex = 1 '(0=Inactive，1=Buck)
        Send_FrameInfo = New CANAdapter.CAN_OBJ
        Send_FrameData = New Byte(7) {}
        For num As Integer = 0 To 65535
            Rec_Frame(num).Data = New Byte(8) {}
            Rec_Frame(num).Data = New Byte(8) {}
        Next
        DeviceType = 0
        CANAdapter.GCT.ClearBuffer(DeviceType, DeviceInd, CANInd) '清除缓冲器数据
        '适配器选择
        USBCANAdapter = 0 'GCT Adapter
        DeviceType = 0
        '波特率选择
        CANBaudrate = 3
        '工作模式选择
        WorkMode = 0
        '协议选择
        ProtocolOption = 20
        Send_FrameInfo = New CANAdapter.CAN_OBJ
        Send_FrameData = New Byte(7) {}
        For num As Integer = 0 To 65535
            Rec_Frame(num).Data = New Byte(8) {}
            Rec_Frame(num).Data = New Byte(8) {}
        Next
        DeviceType = 0
        CANAdapter.GCT.ClearBuffer(DeviceType, DeviceInd, CANInd) '清除缓冲器数据
        '适配器选择
        USBCANAdapter = 0 'GCT Adapter
        DeviceType = 0
        '波特率选择
        CANBaudrate = 3
        '工作模式选择
        WorkMode = 0
        '协议选择
        ProtocolOption = 20
        '****************************************************************************************************************’
        '电源端口配置
        If SerialPort1.IsOpen Then
            SerialPort1.Close()
        End If
        Try
            With SerialPort1
                .PortName = "COM1"
                .BaudRate = 9600
                .Parity = IO.Ports.Parity.None '奇偶校验
                .DataBits = 8 '数据位
                .StopBits = IO.Ports.StopBits.Two '停止位
            End With
            SerialPort1.Open()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        '****************************************************************************************************************’
        '负载端口配置
        If SerialPort2.IsOpen Then
            SerialPort2.Close()
        End If
        Try
            With SerialPort2
                .PortName = "COM8"
                .BaudRate = 9600
                .Parity = IO.Ports.Parity.None '奇偶校验
                .DataBits = 8 '数据位
                .StopBits = IO.Ports.StopBits.One '停止位
            End With
            SerialPort2.Open()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        '打开、关闭CAN设备
        If CANConnect = 1 Then
            CANConnect = 0
            '适配器选择 GCT Adapter
            CANAdapter.GCT.CloseDevice(DeviceType, 0)
            Return
        End If
        Init_Config.AccCode = 0
        Init_Config.AccMask = &HFFFFFFFF&
        Init_Config.FilterType = 0
        Init_Config.Timing0 = 0
        Init_Config.Timing1 = &H1C
        Init_Config.Mode = 0
        '打开CAN  GCT Adapter
        If OpenDevice(DeviceType, DeviceInd, Reserved) <> ECAN.ECANStatus.STATUS_OK Then
            MessageBox.Show("Open device fault!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.[Error])
            Return
        End If
        '初始化CAN  GCT Adapter
        If CANAdapter.GCT.InitCAN(DeviceType, DeviceInd, CANInd, Init_Config) <> CANAdapter.ECANStatus.STATUS_OK Then
            MessageBox.Show("Init can fault!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.[Error])
            CANAdapter.GCT.CloseDevice(DeviceType, 0)
        End If
        CANConnect = 1
        If CANConnect = 0 Then
            MessageBox.Show("Not open device!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.[Error])
            Return
        End If
        '启动CAN
        '根据选择Adapter计算CAN启动函数的返回值
        StartCAN_Status = CANAdapter.GCT.StartCAN(DeviceType, DeviceInd, CANInd)
        If StartCAN_Status = CANAdapter.ECANStatus.STATUS_OK Then
            tmrRead.Enabled = True
        End If
    End Sub






   
    '****************************************************************************************************************’
    '****************************************************************************************************************’
    '****************************************************************************************************************’
    '程序开始
    Private Sub BeginButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BeginButton.Click
        '****************************************************************************************************************’
        '数据库连接
        '连接数据库
        Dim objConn As New OleDb.OleDbConnection '  创建一个OleDbConnection连接对象
        Dim objComm As New OleDb.OleDbCommand '  一个OleDbCommand对象
        ' 设置连接字符串，告诉程序应当如何连接到数据库
        objConn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\data.accdb"
        ' 设置SQL命令，告诉程序应当如何取数
        objComm.CommandText = "Select NUM as 序号,Vout_249 as 249输出电压,Iout_249 as 249输出电流,Temp_249 as 249温度,Vout_250 as 250输出电压,Iout_250 as 250输出电流,Temp_250 as 250温度,VloadRem as 负载电压,VsourRem as 电源电压,IsourRem as 电源电流,ResultRem as 结果,TM as 系统时间 From EV"
        ' 把objConn设置为objComm的数据库连接
        objComm.Connection = objConn
        objDa.SelectCommand = objComm
        ' 创建能自动生成用于协调对 DataSet 的更改与关联物理数据库的单表命令的对象
        Dim builder As OleDb.OleDbCommandBuilder = New OleDb.OleDbCommandBuilder(objDa)
        objConn.Open() '  打开数据库连接
        objDa.Fill(objDs, "EV") '  填充数据集
        objXSTable = objDs.Tables("EV")
        Dim myRow As DataRow = objXSTable.NewRow()
        '****************************************************************************************************************’
        '获取负载变化次数
        CycStep = DataGridView1.Rows.Count - 1
        '****************************************************************************************************************’
        '控制电源负载并关闭
        Dim Send_Data1(6) As Byte
        Send_Data1(0) = &H5
        Send_Data1(1) = &H30
        Send_Data1(2) = &H30
        Send_Data1(3) = &H62
        Send_Data1(4) = &H32
        Send_Data1(5) = &HD
        SerialPort1.DiscardOutBuffer()
        SerialPort1.Write(Send_Data1, 0, 6)
        Delay(100)
        SerialPort2.Write("SYST:REM" & vbCrLf)
        SerialPort2.Write("INPUT  OFF" & vbCrLf)
        '****************************************************************************************************************’
        '开启电源负载can设备
        '****************************************************************************************************************’
        '转换电源参数测试
        Vsource = Val(VsourceBox.Text)
        Isource = Val(IsourceBox.Text) * 10
        VsourTran = Tran_String(Vsource)
        IsourTran = Tran_String(Isource)
        '设置电源
        Dim Send_Data2(14) As Byte
        Send_Data2(0) = &H5 '发送命令头
        Send_Data2(1) = &H30
        Send_Data2(2) = &H30 '从机地址为0
        Send_Data2(3) = &H61
        Send_Data2(4) = &H31 '设置电源命令头
        Tran_ASCII(VsourTran)
        Send_Data2(5) = "&H" & Hex(Data_ASCII(1)) '这波从单位值补位转ASCII码发送堪称完美
        Send_Data2(6) = "&H" & Hex(Data_ASCII(2))
        Send_Data2(7) = "&H" & Hex(Data_ASCII(3))
        Send_Data2(8) = "&H" & Hex(Data_ASCII(4))
        Tran_ASCII(IsourTran)
        Send_Data2(9) = "&H" & Hex(Data_ASCII(1))
        Send_Data2(10) = "&H" & Hex(Data_ASCII(2))
        Send_Data2(11) = "&H" & Hex(Data_ASCII(3))
        Send_Data2(12) = "&H" & Hex(Data_ASCII(4))
        Send_Data2(13) = &HD '回车符结束
        SerialPort1.DiscardOutBuffer()
        SerialPort1.Write(Send_Data2, 0, 14)
        '设置负载
        Iout_set = 0
        Iout_set = "CURR " + Iout_set + "A"
        SerialPort2.Write("MODE  CURR" & vbCrLf)
        SerialPort2.Write("CURR:PROT  250A" & vbCrLf)
        SerialPort2.Write("POW:PROT  6000W" & vbCrLf)
        SerialPort2.Write(Iout_set & vbCrLf)
        '开启电源开启负载
        Delay(100)
        Send_Data1(0) = &H5
        Send_Data1(1) = &H30
        Send_Data1(2) = &H30
        Send_Data1(3) = &H62
        Send_Data1(4) = &H31
        Send_Data1(5) = &HD
        SerialPort1.DiscardOutBuffer()
        SerialPort1.Write(Send_Data1, 0, 6)
        Delay(3000)
        SerialPort2.Write("INPUT  ON" & vbCrLf)
        '启动CAN
        '根据选择Adapter计算CAN启动函数的返回值
        NumCounter = VCU_RollingCounter_215
        Send_FrameInfo.SendType = WorkMode
        sendframeinterval = 20 '写入帧间隔时间
        Send_FrameInfo.ID = &H194
        Send_FrameInfo.RemoteFlag = 0 '数据帧
        Send_FrameInfo.ExternFlag = 0 '标准帧
        Send_FrameInfo.DataLen = 8 '获取数据帧长度
        If Send_FrameInfo.RemoteFlag = 0 Then
            Select Case CByte(cbb_VCU_DCDCReq.SelectedIndex)
                Case 0
                    Send_FrameInfo.Data1 = 0 + ((CDbl(tb_VCU_DCDC_HVCurrSet.Text) * 8) And &HF00) >> 8 '分辨率0.125
                Case 1
                    Send_FrameInfo.Data1 = &H80 + (((CDbl(tb_VCU_DCDC_HVCurrSet.Text) * 8) And &HF00) >> 8) '分辨率0.125
            End Select
            Send_FrameInfo.Data2 = (CDbl(tb_VCU_DCDC_HVCurrSet.Text) * 8) And &HFF '分辨率0.125
            Send_FrameInfo.Data3 = 0
            Send_FrameInfo.Data4 = ((CDbl(tb_VCU_DCDC_LVVoltSet.Text) * 8) And &HF00) >> 8 '分辨率0.125
            Send_FrameInfo.Data5 = (CDbl(tb_VCU_DCDC_LVVoltSet.Text) * 8) And &HFF '分辨率0.125
            Send_FrameInfo.Data6 = CDbl(NumCounter) And &HF
            VCU_Checksum_215 = VCU_Checksum_215 + Send_FrameInfo.Data0
            VCU_Checksum_215 = VCU_Checksum_215 + Send_FrameInfo.Data1
            VCU_Checksum_215 = VCU_Checksum_215 + Send_FrameInfo.Data2
            VCU_Checksum_215 = VCU_Checksum_215 + Send_FrameInfo.Data3
            VCU_Checksum_215 = VCU_Checksum_215 + Send_FrameInfo.Data4
            VCU_Checksum_215 = VCU_Checksum_215 + Send_FrameInfo.Data5
            VCU_Checksum_215 = VCU_Checksum_215 + Send_FrameInfo.Data6
            VCU_Checksum_215 = VCU_Checksum_215 And &HFF
            VCU_Checksum_215 = VCU_Checksum_215 Xor &HFF
            Send_FrameInfo.Data7 = VCU_Checksum_215
        End If
        CAN_Frame_Send()
        VCU_Checksum_215 = 0
        VCU_RollingCounter_215 = VCU_RollingCounter_215 + 1
        If VCU_RollingCounter_215 > 15 Then
            VCU_RollingCounter_215 = 0
        End If
        '*********************************************************************************************************************’
        '*******************************************************循环主体******************************************************’
        '*********************************************************************************************************************’
        '开始循环
        GoTime = System.DateTime.Now
        StopButton = False
        CycNum = 0
        StartTime = System.DateTime.Now
        timestop = Val(CycTimeBox.Text)
        timecounter = 0
        While timecounter < timestop
            Dim j As Integer
            For j = 1 To CycStep
                Iout_set = DataGridView1(1, j - 1).Value
                Iout_set = "CURR " + Iout_set + "A"
                SerialPort2.Write("MODE  CURR" & vbCrLf)
                SerialPort2.Write("CURR:PROT  250A" & vbCrLf)
                SerialPort2.Write("POW:PROT  6000W" & vbCrLf)
                SerialPort2.Write(Iout_set & vbCrLf)
                TimeStart = System.DateTime.Now
                timelast = DataGridView1(2, j - 1).Value
                While timecoun < timelast
                    If StopButton = True Then
                        timelast = 0
                        CycStep = 1
                        timestop = 0
                    End If
                    TimeEnd = System.DateTime.Now
                    ts2 = TimeEnd.Subtract(TimeStart)
                    timecoun = Val(ts2.TotalMinutes.ToString("F2"))
                    '读取电源负载值
                    TextBox1.Text = ""
                    Send_Data1(0) = &H5
                    Send_Data1(1) = &H30
                    Send_Data1(2) = &H30
                    Send_Data1(3) = &H61
                    Send_Data1(4) = &H31
                    Send_Data1(5) = &HD
                    SerialPort1.DiscardOutBuffer()
                    SerialPort1.Write(Send_Data1, 0, 6)
                    Delay(100)
                    rec_sour = TextBox1.Text
                    Exp_sour(rec_sour)
                    SerialPort2.Write("MEAS:VOLT?" & vbCrLf)
                    Delay(150)
                    V_loadrec = rec_load
                    Exp_Vload(V_loadrec)
                    SerialPort2.Write("MEAS:CURR?" & vbCrLf)
                    Delay(150)
                    I_loadrec = rec_load
                    Exp_Iload(I_loadrec)
                    '导入数据库
                    TimeRecord = System.DateTime.Now
                    ts3 = TimeRecord.Subtract(GoTime)
                    TimeGo = Val(ts3.TotalMinutes.ToString("F2"))
                    RecordTime = Val(TimeRecordBox.Text)
                    If Result.Text <> "pass" Then
                        sqlnum = sqlnum + 1
                        myRow("序号") = sqlnum
                        myRow("249输出电压") = VoutBox1.Text
                        myRow("249输出电流") = IoutBox1.Text
                        myRow("249温度") = TempBox1.Text
                        myRow("250输出电压") = VoutBox2.Text
                        myRow("250输出电流") = IoutBox2.Text
                        myRow("250温度") = TempBox2.Text
                        myRow("负载电压") = VLoadBox.Text
                        myRow("电源电压") = Vsour.Text
                        myRow("电源电流") = Isour.Text
                        myRow("结果") = Result.Text
                        myRow("系统时间") = System.DateTime.Now
                        objXSTable.Rows.Add(myRow) ' 添加记录
                        refreshdata() '  更新并刷新显示
                        GoTime = System.DateTime.Now
                    End If
                    If TimeGo > RecordTime Then
                        sqlnum = sqlnum + 1
                        myRow("序号") = sqlnum
                        myRow("249输出电压") = VoutBox1.Text
                        myRow("249输出电流") = IoutBox1.Text
                        myRow("249温度") = TempBox1.Text
                        myRow("250输出电压") = VoutBox2.Text
                        myRow("250输出电流") = IoutBox2.Text
                        myRow("250温度") = TempBox2.Text
                        myRow("负载电压") = VLoadBox.Text
                        myRow("电源电压") = Vsour.Text
                        myRow("电源电流") = Isour.Text
                        myRow("结果") = Result.Text
                        myRow("系统时间") = System.DateTime.Now
                        objXSTable.Rows.Add(myRow) ' 添加记录
                        refreshdata() '  更新并刷新显示
                        GoTime = System.DateTime.Now
                    End If
                    Delay(100)
                    '运行时间
                    EndTime = System.DateTime.Now
                    ts = EndTime.Subtract(StartTime)
                    RuntimeBox.Text = ts.TotalHours.ToString("F2")
                    timecounter = Val(RuntimeBox.Text)
                End While
                timecoun = 0
            Next
            j = 1 ' reset
            CycNum = CycNum + 1
            RunnumBox.Text = CycNum
        End While
        '****************************************************************************************************************’
        '*************************************************循环结束*******************************************************’
        '****************************************************************************************************************’
        Send_Data1(0) = &H5
        Send_Data1(1) = &H30
        Send_Data1(2) = &H30
        Send_Data1(3) = &H62
        Send_Data1(4) = &H32
        Send_Data1(5) = &HD
        SerialPort1.DiscardOutBuffer()
        SerialPort1.Write(Send_Data1, 0, 6)
        Delay(100)
        SerialPort2.Write("INPUT  OFF" & vbCrLf)
    End Sub

    Private Sub EndButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EndButton.Click
        StopButton = True
        Dim Send_Data1(6) As Byte
        Send_Data1(0) = &H5
        Send_Data1(1) = &H30
        Send_Data1(2) = &H30
        Send_Data1(3) = &H62
        Send_Data1(4) = &H32
        Send_Data1(5) = &HD
        SerialPort1.DiscardOutBuffer()
        SerialPort1.Write(Send_Data1, 0, 6)
        Delay(100)
        SerialPort2.Write("INPUT  OFF" & vbCrLf)
    End Sub

    Private Sub IoutSetButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IoutSetButton.Click
        LoadShow_Button = Not LoadShow_Button
        If LoadShow_Button = False Then
            DataGridView1.Visible = False
        End If
        If LoadShow_Button = True Then
            DataGridView1.Visible = True
        End If
    End Sub

    '显示CAN帧信息数据
    Public Sub DisplayMessage()
        Dim TimeInterval As Single
        TimeInterval = RecFrmTime(Receive_FrameInfo(Receive_FrmNum))
        If stopshowflag = 0 Then '是否暂停显示
            FrmInfoShowForListView(Val(TimeInterval), "Receive", Receive_FrameInfo(Receive_FrmNum), receivefrmdata)
        End If
    End Sub
    '接收CAN信息帧
    Private Sub tmrRead_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrRead.Tick
        If CANConnect = 1 Then
            CAN_Rec() '接收函数
        End If
            RecFrameNum = 0
            SendFrameNum = 0
            Frame_Index = 0
            CANAdapter.GCT.ClearBuffer(DeviceType, DeviceInd, CANInd) '清除缓冲器数据
            ClearBuffer(DeviceType, DeviceInd, CANInd) '清除缓冲器数据
    End Sub
    '关闭Form主窗口
    Private Sub Form1_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        '关闭CAN通信，否则若没有关闭设备直接关闭Form时，CAN通信一直存在
        If OpenDeviceStatus = STATUS_OK Then
            'GCT Adapter
            CANAdapter.GCT.CloseDevice(DeviceType, 0)
        End If
    End Sub
    Private Sub Form1_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        '关闭CAN通信，否则若没有关闭设备直接关闭Form时，CAN通信一直存在
        If OpenDeviceStatus = STATUS_OK Then
            CANAdapter.GCT.CloseDevice(DeviceType, 0)
        End If
        GC.Collect() '进行及时垃圾回收，这样做任务管理器中就不会再有Excel进程在运行
    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged
        Exp_Can(TextBox2.Text)
    End Sub
End Class
