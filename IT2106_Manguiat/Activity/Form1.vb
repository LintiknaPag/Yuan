Public Class Form1
    Dim intAllow As Integer
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        For intAllow As Integer = 0 To 10
            ComboBox1.Items.Add(intAllow)
        Next intAllow

        For dblHours = 1 To 1000 Step 0.5
            ListBox1.Items.Add(dblHours)
        Next dblHours

        For dblRates = 1 To 1000 Step 0.5
            ListBox2.Items.Add(dblRates)
        Next dblRates
    End Sub

    Private Sub ComboBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ComboBox1.KeyPress

        If (e.KeyChar < "0" OrElse e.KeyChar > "9") _
            AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged,
           ListBox1.SelectedIndexChanged, ListBox2.SelectedIndexChanged, RadioButton1.CheckedChanged, RadioButton2.CheckedChanged, txtName.TextChanged

        txtGross.Text = String.Empty
        txtFtw.Text = String.Empty
        txtFica.Text = String.Empty
        txtNetpay.Text = String.Empty

    End Sub

    Private Sub GetSingleFwt(ByVal dblTaxPay As Double, ByRef dblFedWthTax As Double)
        Select Case dblTaxPay
            Case <= 44
                dblFedWthTax = 0
            Case <= 224
                dblFedWthTax = 0.1 * (dblTaxPay - 44)
            Case <= 774
                dblFedWthTax = 18 + 0.15 * (dblTaxPay - 224)
            Case <= 1812
                dblFedWthTax = 100.5 + 0.25 * (dblTaxPay - 774)
            Case <= 3730
                dblFedWthTax = 360 + 0.28 * (dblTaxPay - 1812)
            Case <= 8058
                dblFedWthTax = 897.04 + 0.33 * (dblTaxPay - 3730)
            Case <= 8090
                dblFedWthTax = 2325.28 + 0.35 * (dblTaxPay - 3730)
            Case Else
                dblFedWthTax = 2336.48 + 0.396 * (dblTaxPay - 8090)
        End Select

    End Sub


    Private Function GetMarriedFwt(ByVal dblTaxPay As Double) As Double
        Dim dblFedWthTax As Double

        Select Case dblTaxPay
            Case <= 166
                dblFedWthTax = 0
            Case <= 525
                dblFedWthTax = 0.1 * (dblTaxPay - 166)
            Case <= 1626
                dblFedWthTax = 35.9 + 0.15 * (dblTaxPay - 525)
            Case <= 3111
                dblFedWthTax = 201.5 + 0.25 * (dblTaxPay - 1626)
            Case <= 4654
                dblFedWthTax = 572.3 + 0.28 * (dblTaxPay - 3111)
            Case <= 8180
                dblFedWthTax = 1004.34 + 0.33 * (dblTaxPay - 4654)
            Case <= 9128
                dblFedWthTax = 2167.92 + 0.35 * (dblTaxPay - 8180)
            Case Else
                dblFedWthTax = 2531.22 + 0.396 * (dblTaxPay - 9128)
        End Select

        Return dblFedWthTax
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Const dblONE_ALLOWANCE As Double = 77.9
        Const dblFICA_RATE As Double = 0.0765
        Dim dblHours As Double
        Dim dblPayRate As Double
        Dim intAllowances As Integer
        Dim dblGross As Double
        Dim dblTaxable As Double
        Dim dblFwt As Double
        Dim dblFica As Double
        Dim dblNet As Double

        Double.TryParse(ListBox1.SelectedItem.ToString, dblHours)
        Double.TryParse(ListBox2.SelectedItem.ToString, dblPayRate)
        Integer.TryParse(ComboBox1.Text, intAllowances)

        If dblHours <= 40 Then
            dblGross = dblHours * dblPayRate
        Else
            dblGross = 40 * dblPayRate + (dblHours - 40) * dblPayRate * 1.5
        End If

        dblTaxable = dblGross - (intAllowances * dblONE_ALLOWANCE)

        If RadioButton1.Checked = True Then
            GetSingleFwt(dblTaxable, dblFwt)

        Else
            dblFwt = GetMarriedFwt(dblTaxable)
        End If


        dblFica = dblGross * dblFICA_RATE

        dblGross = Math.Round(dblGross, 2)
        dblFwt = Math.Round(dblFwt, 2)
        dblFica = Math.Round(dblFica, 2)

        dblNet = dblGross - dblFwt - dblFica

        txtGross.Text = dblGross.ToString("N2")
        txtFtw.Text = dblFwt.ToString("N2")
        txtFica.Text = dblFica.ToString("N2")
        txtNetpay.Text = dblNet.ToString("N2")



    End Sub

End Class



