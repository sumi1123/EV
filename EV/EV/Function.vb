Module FC
    Public Iout_249, Vout_249, Temp_249 As Double
    Public Iout_250, Vout_250, Temp_250 As Double
    Public Vout_UVP249, Vout_OVP249, Vin_UVP249, Vin_OVP249, Vout_Short249, OTP249 As Boolean
    Public Vout_UVP250, Vout_OVP250, Vin_UVP250, Vin_OVP250, Vout_Short250, OTP250 As Boolean
    '延时函数
    Public Sub Delay(ByVal interval)
        Dim time As DateTime = DateTime.Now
        Dim Span As Int64 = interval * 10000 '因为时间是以1ms为单位。
        While (DateTime.Now.Ticks - time.Ticks < Span)
            Application.DoEvents()
        End While
    End Sub
    '将一个integer型数字转换成四位的字符串
    Public Function Tran_String(ByVal num As Integer) As String
        Tran_String = ""
        If num < 10 Then
            Tran_String = num
            Tran_String = "000" + Tran_String
        Else
            If num < 100 Then
                Tran_String = num
                Tran_String = "00" + Tran_String
            Else
                If num < 1000 Then
                    Tran_String = num
                    Tran_String = "0" + Tran_String
                Else
                    Tran_String = num
                End If
            End If
        End If
    End Function
    '将一个string型四位数字分成4个一位string型，然后转换位ASCII码型
    Public Function Tran_ASCII(ByVal ASCII0 As System.Object) As Object
        Tran_ASCII = ""
        ASCII1 = Microsoft.VisualBasic.Left(ASCII0, 1)
        ASCII2 = Microsoft.VisualBasic.Mid(ASCII0, 2, 1)
        ASCII3 = Microsoft.VisualBasic.Mid(ASCII0, 3, 1)
        ASCII4 = Microsoft.VisualBasic.Right(ASCII0, 1)
        Data_ASCII(1) = Change_ASCII(ASCII1)
        Data_ASCII(2) = Change_ASCII(ASCII2)
        Data_ASCII(3) = Change_ASCII(ASCII3)
        Data_ASCII(4) = Change_ASCII(ASCII4)
    End Function
    Public Function Change_ASCII(ByVal ASCII0 As System.Object) As Byte
        Change_ASCII = &H0
        If ASCII0 = 0 Then
            Change_ASCII = &H30
        End If
        If ASCII0 = 1 Then
            Change_ASCII = &H31
        End If
        If ASCII0 = 2 Then
            Change_ASCII = &H32
        End If
        If ASCII0 = 3 Then
            Change_ASCII = &H33
        End If
        If ASCII0 = 4 Then
            Change_ASCII = &H34
        End If
        If ASCII0 = 5 Then
            Change_ASCII = &H35
        End If
        If ASCII0 = 6 Then
            Change_ASCII = &H36
        End If
        If ASCII0 = 7 Then
            Change_ASCII = &H37
        End If
        If ASCII0 = 8 Then
            Change_ASCII = &H38
        End If
        If ASCII0 = 9 Then
            Change_ASCII = &H39
        End If
    End Function
    '解析电源读数
    Public Function Exp_sour(ByVal Sour_rec As String) '06 3030 30333330 30303230 30303030 3030 0D
        Form1.Vsour.Text = Val(Microsoft.VisualBasic.Mid(Sour_rec, 8, 1) & Microsoft.VisualBasic.Mid(Sour_rec, 10, 1) & Microsoft.VisualBasic.Mid(Sour_rec, 12, 1) & Microsoft.VisualBasic.Mid(Sour_rec, 14, 1))
        If Val(Form1.Vsour.Text) < Val(Form1.VsourMin.Text) Then
            Form1.Result.Text = "电源电压过低"
            StopButton = True
            Spec_Ending()
        End If
        Form1.Isour.Text = Val(Microsoft.VisualBasic.Mid(Sour_rec, 16, 1) & Microsoft.VisualBasic.Mid(Sour_rec, 18, 1) & Microsoft.VisualBasic.Mid(Sour_rec, 20, 1) & Microsoft.VisualBasic.Mid(Sour_rec, 22, 1)) / 10
        If Val(Form1.Vsour.Text) > Val(Form1.VsourMax.Text) Then
            Form1.Result.Text = "电源电压过高"
            StopButton = True
            Spec_Ending()
        End If
    End Function
    '解析负载电流读数
    Public Function Exp_Iload(ByVal Sour_rec As String)
        Form1.ILoadBox.Text = Sour_rec
    End Function
    '解析负载电压读数
    Public Function Exp_Vload(ByVal Sour_rec As String)
        Form1.VLoadBox.Text = Sour_rec
        If Val(Sour_rec) > 32 Then
            Form1.Result.Text = "负载电压过高"
            StopButton = True
            Spec_Ending()
        End If
        If Val(Sour_rec) < 24 Then
            Form1.Result.Text = "负载电压过低"
            StopButton = True
            Spec_Ending()
        End If
    End Function
    '解析can接收信息
    Public Function Exp_Can(ByVal Can_rec As String)
        Dim RecCanData(8) As String
        RecCanData(0) = Microsoft.VisualBasic.Left(Can_rec, 2)
        RecCanData(1) = Microsoft.VisualBasic.Mid(Can_rec, 3, 4)
        RecCanData(2) = Microsoft.VisualBasic.Mid(Can_rec, 7, 2)
        RecCanData(3) = Microsoft.VisualBasic.Mid(Can_rec, 9, 4)
        RecCanData(4) = Microsoft.VisualBasic.Mid(Can_rec, 13, 2)
        RecCanData(5) = Microsoft.VisualBasic.Mid(Can_rec, 15, 4)
        RecCanData(6) = Microsoft.VisualBasic.Mid(Can_rec, 19, 2)
        RecCanData(7) = Microsoft.VisualBasic.Right(Can_rec, 4)
        Dim Recdata_Can(8) As Byte
        Recdata_Can(0) = Val("&H" & RecCanData(0))
        Recdata_Can(1) = Val("&H" & RecCanData(1))
        Recdata_Can(2) = Val("&H" & RecCanData(2))
        Recdata_Can(3) = Val("&H" & RecCanData(3))
        Recdata_Can(4) = Val("&H" & RecCanData(4))
        Recdata_Can(5) = Val("&H" & RecCanData(5))
        Recdata_Can(6) = Val("&H" & RecCanData(6))
        Recdata_Can(7) = Val("&H" & RecCanData(7))
        '249模块显示
        If Recdata_Can(1) = &H6F Then '249号模块
            Vout_249 = (((Recdata_Can(0) And &H1) << 8) + Recdata_Can(1)) * 0.125  '输出电压, 分辨率0.125
            Iout_249 = (((Recdata_Can(3) And &HFF) << 4) + ((Recdata_Can(4) And &HF0) >> 4)) * 0.125 '输出电流，分辨率0.125
            Temp_249 = (Recdata_Can(2) And &HFF) - 40 'DCDC温度，偏移量-40
            Vout_UVP249 = (Recdata_Can(5) And &H2) >> 1 '输入欠压
            Vout_OVP249 = (Recdata_Can(5) And &H1) >> 0 '输入过压
            Vin_UVP249 = (Recdata_Can(6) And &H80) >> 7 '输出欠压
            Vin_OVP249 = (Recdata_Can(6) And &H40) >> 6 '输出过压
            Vout_Short249 = (Recdata_Can(6) And &H20) >> 5 '短路
            OTP249 = (Recdata_Can(6) And &H10) >> 4 '过温
            Form1.IoutBox1.Text = Iout_249
            Form1.VoutBox1.Text = Vout_249
            Form1.TempBox1.Text = Temp_249
            If Vin_UVP249 = True Then
                Form1.Vin_UVP_Shape1.Text = "异常"
                Form1.Vin_UVP_Shape1.ForeColor = Color.Red
                Form1.Result.Text = "输入欠压"
                StopButton = True
                Spec_Ending()
            End If
            If Vin_OVP249 = True Then
                Form1.Vin_OVP_Shape1.Text = "异常"
                Form1.Vin_OVP_Shape1.ForeColor = Color.Red
                Form1.Result.Text = "输入过压"
                StopButton = True
                Spec_Ending()
            End If
            If Vout_OVP249 = True Then
                Form1.Vout_OVP_Shape1.Text = "异常"
                Form1.Vout_OVP_Shape1.ForeColor = Color.Red
                Form1.Result.Text = "输出过压"
                StopButton = True
                Spec_Ending()
            End If
            If Vout_Short249 = True Then
                Form1.Vout_Short_Shape1.Text = "异常"
                Form1.Vout_Short_Shape1.ForeColor = Color.Red
                Form1.Result.Text = "短路"
                StopButton = True
                Spec_Ending()
            End If
            If OTP249 = True Then
                Form1.OTP_Shape1.Text = "异常"
                Form1.OTP_Shape1.ForeColor = Color.Red
                Form1.Result.Text = "过温"
                StopButton = True
                Spec_Ending()
            End If
            Form1.Vout_OVP_Shape1.Text = "正常"
            Form1.Vout_Short_Shape1.Text = "正常"
            Form1.Vin_UVP_Shape1.Text = "正常"
            Form1.Vin_OVP_Shape1.Text = "正常"
            Form1.OTP_Shape1.Text = "正常"
        End If
        '250模块显示
        If Recdata_Can(1) = &H6F Then '250号模块
            Vout_250 = (((Recdata_Can(0) And &H1) << 8) + Recdata_Can(1)) * 0.125  '输出电压, 分辨率0.125
            Iout_250 = (((Recdata_Can(3) And &HFF) << 4) + ((Recdata_Can(4) And &HF0) >> 4)) * 0.125 '输出电流，分辨率0.125
            Temp_250 = (Recdata_Can(2) And &HFF) - 40 'DCDC温度，偏移量-40
            Vout_UVP250 = (Recdata_Can(5) And &H2) >> 1 '输入欠压
            Vout_OVP250 = (Recdata_Can(5) And &H1) >> 0 '输入过压
            Vin_UVP250 = (Recdata_Can(6) And &H80) >> 7 '输出欠压
            Vin_OVP250 = (Recdata_Can(6) And &H40) >> 6 '输出过压
            Vout_Short250 = (Recdata_Can(6) And &H20) >> 5 '短路
            OTP250 = (Recdata_Can(6) And &H10) >> 4 '过温
            Form1.IoutBox2.Text = Iout_250
            Form1.VoutBox2.Text = Vout_250
            Form1.TempBox2.Text = Temp_250
            If Vin_UVP250 = True Then
                Form1.Vin_UVP_Shape2.Text = "异常"
                Form1.Vin_UVP_Shape2.ForeColor = Color.Red
                Form1.Result.Text = "输入欠压"
                StopButton = True
                Spec_Ending()
            End If
            If Vin_OVP250 = True Then
                Form1.Vin_OVP_Shape2.Text = "异常"
                Form1.Vin_OVP_Shape2.ForeColor = Color.Red
                Form1.Result.Text = "输入过压"
                StopButton = True
                Spec_Ending()
            End If
            If Vout_OVP250 = True Then
                Form1.Vout_OVP_Shape2.Text = "异常"
                Form1.Vout_OVP_Shape2.ForeColor = Color.Red
                Form1.Result.Text = "输出过压"
                StopButton = True
                Spec_Ending()
            End If
            If Vout_Short250 = True Then
                Form1.Vout_Short_Shape2.Text = "异常"
                Form1.Vout_Short_Shape2.ForeColor = Color.Red
                Form1.Result.Text = "短路"
                StopButton = True
                Spec_Ending()
            End If
            If OTP250 = True Then
                Form1.OTP_Shape2.Text = "异常"
                Form1.OTP_Shape2.ForeColor = Color.Red
                Form1.Result.Text = "过温"
                StopButton = True
                Spec_Ending()
            End If
            Form1.Vout_OVP_Shape2.Text = "正常"
            Form1.Vout_Short_Shape2.Text = "正常"
            Form1.Vin_UVP_Shape2.Text = "正常"
            Form1.Vin_OVP_Shape2.Text = "正常"
            Form1.OTP_Shape2.Text = "正常"
        End If
        If Recdata_Can(1) = &H0 Then
            Form1.Vout_OVP_Shape1.Text = "未工作"
            Form1.Vout_Short_Shape1.Text = "未工作"
            Form1.Vin_UVP_Shape1.Text = "未工作"
            Form1.Vin_OVP_Shape1.Text = "未工作"
            Form1.OTP_Shape1.Text = "未工作"
            Form1.Vout_OVP_Shape2.Text = "未工作"
            Form1.Vout_Short_Shape2.Text = "未工作"
            Form1.Vin_UVP_Shape2.Text = "未工作"
            Form1.Vin_OVP_Shape2.Text = "未工作"
            Form1.OTP_Shape2.Text = "未工作"
        End If
    End Function
    '异常关机
    Public Function Spec_Ending()
        Dim VCU_RollingCounter1_215 As Integer = 0
        Dim VCU_Checksum1_215 As Single = 0
        Dim Num1 As Integer = 0
        Dim NumCounter1 As Integer
        NumCounter1 = VCU_RollingCounter1_215
        Send_FrameInfo.SendType = WorkMode
        sendframeinterval = 20 '写入帧间隔时间
        Send_FrameInfo.ID = &H194
        Send_FrameInfo.RemoteFlag = 0 '数据帧
        Send_FrameInfo.ExternFlag = 0 '标准帧
        Send_FrameInfo.DataLen = 8 '获取数据帧长度
        Send_FrameInfo.Data1 = 0 + ((CDbl(Form1.tb_VCU_DCDC_HVCurrSet.Text) * 8) And &HF00) >> 8 '分辨率0.125
        Send_FrameInfo.Data2 = (CDbl(Form1.tb_VCU_DCDC_HVCurrSet.Text) * 8) And &HFF '分辨率0.125
        Send_FrameInfo.Data3 = 0
        Send_FrameInfo.Data4 = ((CDbl(Form1.tb_VCU_DCDC_LVVoltSet.Text) * 8) And &HF00) >> 8 '分辨率0.125
        Send_FrameInfo.Data5 = (CDbl(Form1.tb_VCU_DCDC_LVVoltSet.Text) * 8) And &HFF '分辨率0.125
        Send_FrameInfo.Data6 = CDbl(NumCounter1) And &HF
        VCU_Checksum1_215 = VCU_Checksum1_215 + Send_FrameInfo.Data0
        VCU_Checksum1_215 = VCU_Checksum1_215 + Send_FrameInfo.Data1
        VCU_Checksum1_215 = VCU_Checksum1_215 + Send_FrameInfo.Data2
        VCU_Checksum1_215 = VCU_Checksum1_215 + Send_FrameInfo.Data3
        VCU_Checksum1_215 = VCU_Checksum1_215 + Send_FrameInfo.Data4
        VCU_Checksum1_215 = VCU_Checksum1_215 + Send_FrameInfo.Data5
        VCU_Checksum1_215 = VCU_Checksum1_215 + Send_FrameInfo.Data6
        VCU_Checksum1_215 = VCU_Checksum1_215 And &HFF
        VCU_Checksum1_215 = VCU_Checksum1_215 Xor &HFF
        Send_FrameInfo.Data7 = VCU_Checksum1_215
        CAN_Frame_Send()
        VCU_Checksum1_215 = 0
        VCU_RollingCounter1_215 = VCU_RollingCounter1_215 + 1
        If VCU_RollingCounter1_215 > 15 Then
            VCU_RollingCounter1_215 = 0
        End If
        Dim Send_Data2(6) As Byte
        Send_Data2(0) = &H5
        Send_Data2(1) = &H30
        Send_Data2(2) = &H30
        Send_Data2(3) = &H62
        Send_Data2(4) = &H32
        Send_Data2(5) = &HD
        Form1.SerialPort1.DiscardOutBuffer()
        Form1.SerialPort1.Write(Send_Data2, 0, 6)
        Delay(100)
        Form1.SerialPort2.Write("INPUT  OFF" & vbCrLf)
    End Function
End Module
