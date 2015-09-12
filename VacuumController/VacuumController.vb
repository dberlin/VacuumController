Public Class VacuumController
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Select Case CInt(AddressFirstDigit)
        '    Case 0 : m_ReadFunctionCode = 1
        '        WriteSingleFunctionCode = 5
        '        WriteMultiFunctionCode = 15
        '        m_BitsPerElement = 1
        '    Case 1 : m_ReadFunctionCode = 2
        '        WriteMultiFunctionCode = 0 '* Invalid
        '        m_BitsPerElement = 1
        '    Case 3 : m_ReadFunctionCode = 4
        '        WriteMultiFunctionCode = 0
        '        m_Element = CInt(Address.Substring(1)) - 1
        '        m_BitsPerElement = 16
        '    Case 4 : m_ReadFunctionCode = 3
        '        WriteSingleFunctionCode = 6
        '        WriteMultiFunctionCode = 16
        '        m_Element = CInt(Address.Substring(1)) - 1
        '        m_BitsPerElement = 16
    End Sub

    Private Sub FlowLayoutPanel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub MomentaryButton1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub UpButton_Click(sender As Object, e As EventArgs) Handles UpButton.Click

    End Sub

    Private Sub PIDSetpoint_GotFocus(sender As Object, e As EventArgs) Handles PIDSetpointVC75.GotFocus

    End Sub

    Private Sub PIDSetpoint_TextChanged(sender As Object, e As EventArgs) Handles PIDSetpointVC75.TextChanged

    End Sub

    Private Sub PIDSetpoint_ValueChanged(sender As Object, e As EventArgs) Handles PIDSetpointVC75.ValueChanged
        UpButton.ValueToWrite = PIDSetpointVC75.Value + 5
        DownButton.ValueToWrite = PIDSetpointVC75.Value - 5
    End Sub

    Private Sub DigitalPanelMeter1_Click(sender As Object, e As EventArgs) Handles OutputPowerVC75.Click

    End Sub

    Private Sub ModBusToSV65_ConnectionEstablished(sender As Object, e As EventArgs) Handles ModBusToSV65.ConnectionEstablished
        'Unlock drive
        ModBusToSV65.Write(40049, 0)
        'ModBusToSV65.Write(40002, 8)
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs)

    End Sub
End Class
