'****************************************************************
'变量定义、公共函数定义
'****************************************************************
Module VariableModule
    '程序所需的系统参数定义
    Public NowDataTime As String '系统时间 
    Public SendFrameNum As Double = 0 '发送帧计数
    Public RecFrameNum As Double = 0 '接收帧计数
    Public stopshowflag As Integer = 0 '停止显示标志
    Public DisplaySendFrameFlag As Integer = 0 '显示发送帧标志
    Public DisplayRecFrameFlag As Integer = 0 '显示接收帧标志
    Public timebuffer0 As Single = 0 'CAN接收帧中的时间标识
    Public timebuffer1 As Single = 0 'CAN接收帧中的时间标识
    Public timebuffer As Single = 0 'CAN接收帧间隔时间
    Public txtbCurrentTextBox As TextBox
    Public item As New ListViewItem '新建ListView项
    Public Blank_Space_String As String = "     "
    'CAN总线配置相关定义
    Public DeviceType As UInt32 = 0 '设备类型号
    Public DeviceInd As UInt32 = 0 '设备索引号
    Public CANInd As UInt32 = 0 '第几路CAN
    Public Reserved As UInt32 = 0 '预留
    Public USBCANAdapter As Byte = 0 'USBCAN适配器选择
    Public CANBaudrate As Byte 'CAN波特率
    Public PCAN_Baudrate As Integer '存放PCAN的波特率
    Public CANConnect As Byte = 0 'CAN总线连接
    Public WorkMode As Integer = 0 'CAN工作模式
    Public ProtocolOption As Integer = 0 '通信协议
    Public OpenDeviceStatus As Byte = 0 '设备打开状态
    Public Const STATUS_ERR As Byte = 0
    Public Const STATUS_OK As Byte = 1
    Public Const DCDC_MFR_ID = &H1FFFFFFF '模块自定义调试ID
    Public Const DCDC_STATUS_ID = &H1FFFFFFE '模块运行状态调试ID
    Public Const DCDC_DEBUG_ID = &H1FFFFFFD 'DCDC内部调试ID
    'CAN总线信息帧相关定义
    Public Init_Config As CANAdapter.INIT_CONFIG_Struct
    Public Send_FrameInfo As CANAdapter.CAN_OBJ '发送数据帧详细信息
    Public Send_FrameData(7) As Byte '发送CAN信息帧数据
    Public Receive_FrameInfo(65535) As CANAdapter.CAN_OBJ '存放接收CAN信息帧详细信息
    Public Structure RecFrame
        Public Data() As Byte '存放接收CAN信息帧数据
    End Structure
    Public Rec_Frame(65535) As RecFrame
    Public Receive_FrmNum As Integer = 0 '存放接收CAN信息帧数目
    Public Const Receive_FrmNum_PAR = 65535 '存放接收CAN信息帧数目参数
    Public sendfrmdata As String = "" '存放发送帧数据
    Public receivefrmdata As String = "" '存放接收帧数据
    Public sendframeinterval As String = "" '存放发送帧间隔时间
    Public sendfrmdone As String = "" '存放发送帧完成标识
    Public Frame_Index As Integer '存放数据帧显示的序号
    'CAN状态信息定义
    Public CANStatus As New CANAdapter.CAN_STATUS
    Public StartCAN_Status As ULong = 0 '存放启动CAN函数返回结果值
    Public ResetCAN_Status As ULong = 0 '存放复位CAN函数返回结果值
    Public Transmit_Status As ULong = 0 '存放发送函数返回结果值
    Public ErrInfo(0) As CANAdapter.VCI_ERR_INFO
    Public FrameNum As Long '接收帧数目
    'CAN错误信息定义
    Public CANErrInfo As New CANAdapter.VCI_ERR_INFO
    Public Function FrmInfoShowForListView(ByVal TimeInterval As Single, ByVal DataDirect As String, ByVal FrameInfo As CANAdapter.CAN_OBJ, ByVal Data As String) As Boolean
        Frame_Index = Frame_Index + 1 '每调用一次，序号+1
        If FrameInfo.RemoteFlag = 0 Then
            Form1.TextBox2.Text = String.Format("{0:X4}", Data) '写入帧数据
        Else
            item.SubItems.Add("Remote Request")
        End If
    End Function
    '接收帧间隔时间
    Public Function RecFrmTime(ByVal rec_can_inf As CANAdapter.CAN_OBJ) As Single
        timebuffer1 = rec_can_inf.TimeStamp
        timebuffer = timebuffer1 - timebuffer0
        timebuffer0 = timebuffer1
        'GCT Adapter
        timebuffer = timebuffer * 0.001
        Return timebuffer
    End Function
    '赋值函数，数据转换函数
    Public Function ChangeDataForm() As Boolean
        Send_FrameData(0) = Send_FrameInfo.Data0
        Send_FrameData(1) = Send_FrameInfo.Data1
        Send_FrameData(2) = Send_FrameInfo.Data2
        Send_FrameData(3) = Send_FrameInfo.Data3
        Send_FrameData(4) = Send_FrameInfo.Data4
        Send_FrameData(5) = Send_FrameInfo.Data5
        Send_FrameData(6) = Send_FrameInfo.Data6
        Send_FrameData(7) = Send_FrameInfo.Data7
    End Function
    'CAN信息帧发送函数
    Public Function CAN_Frame_Send() As Boolean
        sendfrmdata = ""
        ChangeDataForm() '改变数据格式
        For i As Integer = 0 To 7 '写进与设定数据长度相符的数据
            sendfrmdata += String.Format("{0:X2} ", Send_FrameData(i))
        Next
        '根据选择Adapter计算发送函数的返回值
        'GCT Adapter
        Transmit_Status = CANAdapter.GCT.Transmit(DeviceType, DeviceInd, CANInd, Send_FrameInfo, 1)

        If Transmit_Status = CANAdapter.ECANStatus.STATUS_OK Then
            sendfrmdone = "Send OK"
        Else
            sendfrmdone = "Send Error"
        End If
    End Function
    '接收函数
    Public Function CAN_Rec() As Boolean
        '获取当前缓冲器中CAN数据帧的数目

        FrameNum = CANAdapter.GCT.GetReceiveNum(DeviceType, DeviceInd, CANInd)
        If FrameNum <= 0 Then '如果接收缓冲器没有数据
            CANAdapter.GCT.ReadErrInfo(DeviceType, DeviceInd, CANInd, ErrInfo(0))
        Else
            '接收CAN数据帧，返回接收帧的数目
            FrameNum = CANAdapter.GCT.Receive(DeviceType, DeviceInd, CANInd, Receive_FrameInfo(0), Receive_FrmNum_PAR, 200)
            For Receive_FrmNum = 0 To FrameNum - 1
                Rec_Frame(Receive_FrmNum).Data(0) = Receive_FrameInfo(Receive_FrmNum).Data0
                Rec_Frame(Receive_FrmNum).Data(1) = Receive_FrameInfo(Receive_FrmNum).Data1
                Rec_Frame(Receive_FrmNum).Data(2) = Receive_FrameInfo(Receive_FrmNum).Data2
                Rec_Frame(Receive_FrmNum).Data(3) = Receive_FrameInfo(Receive_FrmNum).Data3
                Rec_Frame(Receive_FrmNum).Data(4) = Receive_FrameInfo(Receive_FrmNum).Data4
                Rec_Frame(Receive_FrmNum).Data(5) = Receive_FrameInfo(Receive_FrmNum).Data5
                Rec_Frame(Receive_FrmNum).Data(6) = Receive_FrameInfo(Receive_FrmNum).Data6
                Rec_Frame(Receive_FrmNum).Data(7) = Receive_FrameInfo(Receive_FrmNum).Data7

                receivefrmdata = ""
                For frmdata_num As Integer = 0 To Receive_FrameInfo(Receive_FrmNum).DataLen - 1
                    receivefrmdata += String.Format("{0:X2} ", Rec_Frame(Receive_FrmNum).Data(frmdata_num))
                Next
                If DisplayRecFrameFlag = 0 Then
                    Form1.DisplayMessage() '显示接收CAN信息帧
                End If
            Next
        End If
    End Function
End Module
