Option Strict Off
Option Explicit On
Imports System.Runtime.InteropServices
Imports TPCANHandle = System.UInt16
Imports TPCANBitrateFD = System.String
Imports TPCANTimestampFD = System.UInt64
Module ECAN
    '定义需要用到的数据结构
    Public Enum ECANStatus As UInteger
        ''' <summary>
        '''  error
        ''' </summary>
        STATUS_ERR = &H0
        ''' <summary>
        ''' No error
        ''' </summary>
        STATUS_OK = &H1
    End Enum

    Public Structure VCI_BOARD_INFO
        Dim hw_Version As Short
        Dim fw_Version As Short
        Dim dr_Version As Short
        Dim in_Version As Short
        Dim irq_num As Short
        Dim can_num As Byte
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=20)> Dim str_Serial_Num() As Byte
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=40)> Dim str_hw_Type() As Byte
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=4)> Dim Reserved() As Short
    End Structure
    'CAN信息帧结构体
    Public Structure CAN_OBJ
        Public ID As UInteger
        Public TimeStamp As UInteger
        Public TimeFlag As Byte
        Public SendType As Byte
        Public RemoteFlag As Byte
        Public ExternFlag As Byte
        Public DataLen As Byte

        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=8)> _
        Public Data As Byte()

        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=3)> _
        Public Reserved As Byte()
    End Structure
    'CAN控制器状态信息
    Public Structure CAN_STATUS
        Public ErrInterrupt As Char
        Public regMode As Char
        Public regStatus As Char
        Public regALCapture As Char
        Public regECCapture As Char
        Public regEWLimit As Char
        Public regRECounter As Char
        Public regTECounter As Char
        Public Reserved As UInt32
    End Structure
    Public Structure VCI_ERR_INFO
        Dim ErrCode As Integer
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=3)> Dim Passive_ErrData() As Byte
        Dim ArLost_ErrData As Byte
    End Structure
    '初始化CAN配置结构体
    Public Structure INIT_CONFIG_Struct
        Public AccCode As UInteger
        Public AccMask As UInteger
        Public reserved As UInteger
        Public FilterType As Byte
        Public Timing0 As Byte
        Public Timing1 As Byte
        Public Mode As Byte
    End Structure
    '************************************************
    'ZLG Adapter底层调用函数
    '************************************************
    '打开设备，入口参数DeviceType表示设备类型号；DeviceInd表示设备索引号（具体见接口函数库使用手册）；当设备为CAN232时Reserved表示打开串口的波特率，当为其他设备时参数无意义
    Declare Function VCI_OpenDevice Lib "ControlCAN.dll" (ByVal DeviceType As Integer, ByVal DeviceInd As Integer, ByVal Reserved As Integer) As Integer
    '关闭设备
    Declare Function VCI_CloseDevice Lib "ControlCAN.dll" (ByVal DeviceType As Integer, ByVal DeviceInd As Integer) As Integer
    '初始化指定的CAN
    Declare Function VCI_InitCAN Lib "ControlCAN.dll" (ByVal DeviceType As Integer, ByVal DeviceInd As Integer, ByVal CANInd As Integer, ByRef InitConfig As ECAN.INIT_CONFIG_Struct) As Integer
    '获取设备信息
    Declare Function VCI_ReadBoardInfo Lib "ControlCAN.dll" (ByVal DeviceType As Integer, ByVal DeviceInd As Integer, ByRef info As VCI_BOARD_INFO) As Integer
    '获取最后一次错误信息
    Declare Function VCI_ReadErrInfo Lib "ControlCAN.dll" (ByVal DeviceType As Integer, ByVal DeviceInd As Integer, ByVal CANInd As Integer, ByRef ErrInfo As VCI_ERR_INFO) As Integer
    '获取CAN状态
    Declare Function VCI_ReadCANStatus Lib "ControlCAN.dll" (ByVal DeviceType As Integer, ByVal DeviceInd As Integer, ByVal CANInd As Integer, ByRef CANStatus As ECAN.CAN_STATUS) As Integer
    '获取设备的相应参数
    Declare Function VCI_GetReference Lib "ControlCAN.dll" (ByVal DeviceType As Integer, ByVal DeviceInd As Integer, ByVal CANInd As Integer, ByVal RefType As Integer, ByRef data As Long) As Integer
    '设置设备的相应参数，主要处理不同设备的特定操作
    Declare Function VCI_SetReference Lib "ControlCAN.dll" (ByVal DeviceType As Integer, ByVal DeviceInd As Integer, ByVal CANInd As Integer, ByVal RefType As Integer, ByRef data As Long) As Integer
    '获取指定接收缓冲区中接收到但尚未被读取得帧数
    Declare Function VCI_GetReceiveNum Lib "ControlCAN.dll" (ByVal DeviceType As Integer, ByVal DeviceInd As Integer, ByVal CANInd As Integer) As Integer
    '清空指定缓冲区
    Declare Function VCI_ClearBuffer Lib "ControlCAN.dll" (ByVal DeviceType As Integer, ByVal DeviceInd As Integer, ByVal CANInd As Integer) As Integer
    '启动CAN
    Declare Function VCI_StartCAN Lib "ControlCAN.dll" (ByVal DeviceType As Integer, ByVal DeviceInd As Integer, ByVal CANInd As Integer) As Integer
    '复位CAN
    Declare Function VCI_ResetCAN Lib "ControlCAN.dll" (ByVal DeviceType As Integer, ByVal DeviceInd As Integer, ByVal CANInd As Integer) As Integer
    '向指定的的设备发送数据
    Declare Function VCI_Transmit Lib "ControlCAN.dll" (ByVal DeviceType As Integer, ByVal DeviceInd As Integer, ByVal CANInd As Integer, ByRef Sendbuf As ECAN.CAN_OBJ, ByVal length As Integer) As Integer
    '从指定的设备读取数据
    Declare Function VCI_Receive Lib "ControlCAN.dll" (ByVal DeviceType As Integer, ByVal DeviceInd As Integer, ByVal CANInd As Integer, ByRef Receive As ECAN.CAN_OBJ, ByVal length As Integer, ByVal WaitTime As Integer) As Integer
    '************************************************
    'GCT Adapter底层调用函数
    '************************************************
    '打开CAN
    Declare Function OpenDevice Lib "ECANVCI.dll " (ByVal DeviceType As UInt32, ByVal DeviceInd As UInt32, ByVal Reserved As UInt32) As ECANStatus
    '关闭CAN
    Declare Function CloseDevice Lib "ECANVCI.dll " (ByVal DeviceType As UInt32, ByVal DeviceInd As UInt32) As ECANStatus
    '初始化CAN
    Declare Function InitCAN Lib "ECANVCI.dll " (ByVal DeviceType As UInt32, ByVal DeviceInd As UInt32, ByVal CANInd As UInt32, ByRef InitConfig As INIT_CONFIG_Struct) As ECANStatus
    '启动CAN
    Declare Function StartCAN Lib "ECANVCI.dll " (ByVal DeviceType As UInt32, ByVal DeviceInd As UInt32, ByVal CANInd As UInt32) As ECANStatus
    '复位CAN
    Declare Function ResetCAN Lib "ECANVCI.dll " (ByVal DeviceType As UInt32, ByVal DeviceInd As UInt32, ByVal CANInd As UInt32) As ECANStatus
    '发送
    Declare Function Transmit Lib "ECANVCI.dll " (ByVal DeviceType As UInt32, ByVal DeviceInd As UInt32, ByVal CANInd As UInt32, ByRef Send As CAN_OBJ, ByVal length As UInt16) As ECANStatus
    '接收
    Declare Function Receive Lib "ECANVCI.dll " (ByVal DeviceType As UInt32, ByVal DeviceInd As UInt32, ByVal CANInd As UInt32, ByRef mReceive As CAN_OBJ, ByVal length As UInt32, ByVal WaitTime As UInt32) As ECANStatus
    '清除缓冲器
    Declare Function ClearBuffer Lib "ECANVCI.dll " (ByVal DeviceType As UInt32, ByVal DeviceInd As UInt32, ByVal CANInd As UInt32) As ECANStatus
    '读取CAN状态
    Declare Function ReadCanStatus Lib "ECANVCI.dll " (ByVal DeviceType As UInt32, ByVal DeviceInd As UInt32, ByVal CANInd As UInt32, ByRef pCANStatus As CAN_STATUS) As ECANStatus
    '读取CAN错误信息
    Declare Function ReadErrInfo Lib "ECANVCI.dll " (ByVal DeviceType As UInt32, ByVal DeviceInd As UInt32, ByVal CANInd As UInt32, ByRef pErrInfo As VCI_ERR_INFO) As ECANStatus
    '读取CAN接收缓冲器中接收到尚未被读取的帧数
    Declare Function GetReceiveNum Lib "ECANVCI.dll " (ByVal DeviceType As UInt32, ByVal DeviceInd As UInt32, ByVal CANInd As UInt32) As ECANStatus
End Module