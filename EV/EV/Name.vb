Module Name
    '负载发送字符帧
    Public Iout_set As String
    '带载显示控制开关
    Public LoadShow_Button As Boolean = False
    '电源设置参数
    Public Vsource, Isource As Integer
    Public VsourTran, IsourTran As String
    '电源四位数字转换位ASCII码
    Public ASCII1, ASCII2, ASCII3, ASCII4 As String '电源四位数字转ASCII码
    Public Data_ASCII(4) As Byte ' 转换后四位ASCII码
    '负载循环参数定义
    Public CycNum As Integer
    Public CycStep As Integer
    '控制时间参数定义
    '大循环
    Public timecounter As Double
    Public timestop As Double
    Public StartTime As System.DateTime
    Public EndTime As System.DateTime
    Public ts As System.TimeSpan
    '小循环
    Public timecoun As Double
    Public timelast As Double
    Public TimeStart As System.DateTime
    Public TimeEnd As System.DateTime
    Public ts2 As System.TimeSpan
    '数据库记录时间控制
    Public RecordTime As Double
    Public TimeGo As Double
    Public TimeRecord As System.DateTime
    Public GoTime As System.DateTime
    Public ts3 As System.TimeSpan
    '定义电源负载返回读数
    Public rec_sour, I_loadrec, V_loadrec As String
    '负载接收
    Public rec_load As String
    '循环终止
    Public StopButton As Boolean = False
End Module
