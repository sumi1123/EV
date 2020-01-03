Imports System.Collections.Generic
Imports System.Text
Imports System.Runtime.InteropServices
Namespace CANAdapter
    '定义需要用到的数据结构
    <Flags()> _
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

        Public Data0 As Byte
        Public Data1 As Byte
        Public Data2 As Byte
        Public Data3 As Byte
        Public Data4 As Byte
        Public Data5 As Byte
        Public Data6 As Byte
        Public Data7 As Byte

        Public Reserved0 As Byte
        Public Reserved1 As Byte
        Public Reserved2 As Byte
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
    'GCT Adapter底层调用函数
    '************************************************
    Public Class GCT
        Private Sub New()
        End Sub
        '打开CAN
        <DllImport("ECANVCI.dll", EntryPoint:="OpenDevice")> _
        Public Shared Function OpenDevice(ByVal DeviceType As UInt32, ByVal DeviceInd As UInt32, ByVal Reserved As UInt32) As ECANStatus
        End Function
        '关闭CAN
        <DllImport("ECANVCI.dll", EntryPoint:="CloseDevice")> _
        Public Shared Function CloseDevice(ByVal DeviceType As UInt32, ByVal DeviceInd As UInt32) As ECANStatus
        End Function
        '初始化CAN
        <DllImport("ECANVCI.dll", EntryPoint:="InitCAN")> _
        Public Shared Function InitCAN(ByVal DeviceType As UInt32, ByVal DeviceInd As UInt32, ByVal CANInd As UInt32, ByRef InitConfig As INIT_CONFIG_Struct) As ECANStatus
        End Function
        '启动CAN
        <DllImport("ECANVCI.dll", EntryPoint:="StartCAN")> _
        Public Shared Function StartCAN(ByVal DeviceType As UInt32, ByVal DeviceInd As UInt32, ByVal CANInd As UInt32) As ECANStatus
        End Function
        '复位CAN
        <DllImport("ECANVCI.dll", EntryPoint:="ResetCAN")> _
        Public Shared Function ResetCAN(ByVal DeviceType As UInt32, ByVal DeviceInd As UInt32, ByVal CANInd As UInt32) As ECANStatus
        End Function
        '发送
        <DllImport("ECANVCI.dll", EntryPoint:="Transmit")> _
        Public Shared Function Transmit(ByVal DeviceType As UInt32, ByVal DeviceInd As UInt32, ByVal CANInd As UInt32, ByRef Send As CAN_OBJ, ByVal length As UInt16) As ECANStatus
        End Function
        '接收
        <DllImport("ECANVCI.dll", EntryPoint:="Receive")> _
        Public Shared Function Receive(ByVal DeviceType As UInt32, ByVal DeviceInd As UInt32, ByVal CANInd As UInt32, ByRef mReceive As CAN_OBJ, ByVal length As UInt32, ByVal WaitTime As UInt32) As ECANStatus
        End Function
        '清除缓冲器
        <DllImport("ECANVCI.dll", EntryPoint:="ClearBuffer")> _
        Public Shared Function ClearBuffer(ByVal DeviceType As UInt32, ByVal DeviceInd As UInt32, ByVal CANInd As UInt32) As ECANStatus
        End Function
        '读取CAN状态
        <DllImport("ECANVCI.dll", EntryPoint:="ReadCanStatus")> _
        Public Shared Function ReadCanStatus(ByVal DeviceType As UInt32, ByVal DeviceInd As UInt32, ByVal CANInd As UInt32, ByRef pCANStatus As CAN_STATUS) As ECANStatus
        End Function
        '读取CAN错误信息
        <DllImport("ECANVCI.dll", EntryPoint:="ReadErrInfo")> _
        Public Shared Function ReadErrInfo(ByVal DeviceType As UInt32, ByVal DeviceInd As UInt32, ByVal CANInd As UInt32, ByRef pErrInfo As VCI_ERR_INFO) As ECANStatus
        End Function
        '读取CAN接收缓冲器中接收到尚未被读取的帧数
        <DllImport("ECANVCI.dll", EntryPoint:="GetReceiveNum")> _
        Public Shared Function GetReceiveNum(ByVal DeviceType As UInt32, ByVal DeviceInd As UInt32, ByVal CANInd As UInt32) As ECANStatus
        End Function
    End Class
End Namespace