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

    Private Sub PIDSetpoint_GotFocus(sender As Object, e As EventArgs) Handles PIDSetpoint.GotFocus

    End Sub

    Private Sub PIDSetpoint_TextChanged(sender As Object, e As EventArgs) Handles PIDSetpoint.TextChanged

    End Sub

    Private Sub PIDSetpoint_ValueChanged(sender As Object, e As EventArgs) Handles PIDSetpoint.ValueChanged
        UpButton.ValueToWrite = PIDSetpoint.Value + 10
        DownButton.ValueToWrite = PIDSetpoint.Value - 10
    End Sub

    Private Sub DigitalPanelMeter1_Click(sender As Object, e As EventArgs) Handles DigitalPanelMeter1.Click

    End Sub
End Class
