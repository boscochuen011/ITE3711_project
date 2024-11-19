Public Class Form1

    Const Appleprice As Double = 10.0
    Const Lettuceprice As Double = 12.5
    Const Tomatoprice As Double = 8.5
    Const Hamprice As Double = 20
    Const Tunaprice As Double = 18.5
    Const GrainWheatPrice As Double = 8.0
    Const HoneyOatPrice As Double = 10.5
    Const dbldiscount As Double = 0.9

    Dim AppleCount As Integer
    Dim Lettucecount As Integer
    Dim TomatoCount As Integer
    Dim HamCount As Integer
    Dim tunaCount As Integer

    Dim TotalSales As Double
    Dim LargestSales As Double
    Dim AverageofSales As Double
    Dim dblBeforeDiscount As Double
    Dim dblTotal As Double
    Dim Numord As Integer

    Dim nameline As Integer
    Dim Display As String
    Dim Ranklist As String
    Dim popularitem As String
    Dim checkline As String
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        chkapple.Text += FormatCurrency(Appleprice, 2)
        chkLettuce.Text += FormatCurrency(Lettuceprice, 2)
        chkTomato.Text += FormatCurrency(Tomatoprice, 2)
        chkHam.Text += FormatCurrency(Hamprice, 2)
        chkTuna.Text += FormatCurrency(Tunaprice, 2)
        radHoneyOat.Text += FormatCurrency(HoneyOatPrice, 2)
        radGrainWheat.Text += FormatCurrency(GrainWheatPrice, 2)

        txtNumberofOrders.Text = 0
        txtAverageofSales.Text = "---"
        txtTotalSales.Text = "$0.00"
        txtLargestSales.Text = "$0.00"
        lstCustomerHistory.Items.Clear()

    End Sub
    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click

        Dim AppleCount1 As Integer
        Dim Lettucecount1 As Integer
        Dim TomatoCount1 As Integer
        Dim HamCount1 As Integer
        Dim tunaCount1 As Integer
        Dim GrainWheatcount1 As Integer
        Dim HoneyOatcount1 As Integer

        If (chkapple.Checked = True Or chkHam.Checked = True Or chkLettuce.Checked = True Or chkTomato.Checked = True Or chkTuna.Checked = True) And (radGrainWheat.Checked = True Or radHoneyOat.Checked = True) And (Not String.IsNullOrEmpty(txtCustomername.Text)) Then
            Dim msgcomfirm As String
            msgcomfirm = MsgBox(" Do you confirm order ? ", vbQuestion + vbYesNo + vbDefaultButton2, " My Cafe system ")

            If msgcomfirm = vbYes Then

                Numord = Numord + 1
                txtNumberofOrders.Text = CStr(Numord)

                For i As Integer = 0 To lstCustomerHistory.Items.Count
                    nameline = i + 1
                Next

                lstCustomerHistory.Items.Add((nameline) & ": " & (txtCustomername.Text.Trim))

                Dim dblLettuce, dblTomato, dbltuna, dblsob, dblApple, dblHam As Double

                If chkapple.Checked = True Then
                    dblApple = Appleprice
                    AppleCount1 += NudQuantity.Value
                    AppleCount = Addcount(AppleCount)

                Else
                    dblApple = 0
                End If

                If chkHam.Checked = True Then
                    dblHam = Hamprice
                    HamCount1 += NudQuantity.Value
                    HamCount = Addcount(HamCount)

                Else
                    dblHam = 0
                End If

                If chkLettuce.Checked = True Then
                    dblLettuce = Lettuceprice
                    Lettucecount1 += NudQuantity.Value
                    Lettucecount = Addcount(Lettucecount)

                Else
                    dblLettuce = 0
                End If

                If chkTomato.Checked = True Then
                    dblTomato = Tomatoprice
                    TomatoCount1 += NudQuantity.Value
                    TomatoCount = Addcount(TomatoCount)

                Else
                    dblTomato = 0
                End If

                If chkTuna.Checked = True Then
                    dbltuna = Tunaprice
                    tunaCount1 += NudQuantity.Value
                    tunaCount = Addcount(tunaCount)

                Else
                    dbltuna = 0
                End If

                If radGrainWheat.Checked = True Then
                    dblsob = GrainWheatPrice
                    GrainWheatcount1 = Addcount(GrainWheatcount1)
                End If

                If radHoneyOat.Checked = True Then
                    dblsob = HoneyOatPrice
                    HoneyOatcount1 = Addcount(HoneyOatcount1)
                End If

                dblBeforeDiscount = NudQuantity.Value * (dblLettuce + dblTomato + dblsob + dblApple + dblHam + dbltuna)

                If dblBeforeDiscount >= 100 Then
                    dblTotal = GetDiscount(dblBeforeDiscount)
                Else
                    dblTotal = dblBeforeDiscount
                End If

                txtOrderamt.Text = ("$" & CStr(Format(dblTotal, "Fixed")))

                If dblTotal > LargestSales Then
                    LargestSales = dblTotal
                    txtLargestSales.Text = CStr(("$" & Format(LargestSales, "Fixed")))
                End If

                TotalSales = TotalSales + dblTotal
                txtTotalSales.Text = CStr("$" & Format(TotalSales, "Fixed"))

                AverageofSales = TotalSales / Numord
                txtAverageofSales.Text = "$" & Format(AverageofSales, "Fixed")

                Dim k, Line As Integer
                Dim count1() As Integer = {AppleCount1, Lettucecount1, TomatoCount1, HamCount1, tunaCount1, GrainWheatcount1, HoneyOatcount1}
                Dim strName() As String = {"Apple", "Lettuce", "Tomato", "Ham", "Tuna", "GrainWheat", "HoneyOat"}

                For k = 0 To count1.Count - 1

                    If count1(k) > 0 Then
                        Line += 1
                        Display = Display & vbCrLf & (Line) & ". " & strName(k) & " x " & (count1(k))
                    End If
                Next

                MessageBox.Show("Your order is confilm" & vbCrLf & Display, "My Cafe system")
                Display = ""
            End If
        End If

        If chkapple.Checked = False And chkHam.Checked = False And chkLettuce.Checked = False And chkTomato.Checked = False And chkTuna.Checked = False Then
            MessageBox.Show("At least pick one for the Salad Ingredients", " My Cafe system ")
        End If

        If radGrainWheat.Checked = False And radHoneyOat.Checked = False Then
            MessageBox.Show("At least pick one for the Bread", " My Cafe system ")
        End If

        If String.IsNullOrEmpty(txtCustomername.Text) Then
            MessageBox.Show("Please enter customer name", " My Cafe system ")
        End If

    End Sub
    Function Addcount(ByVal countnum As Double)
        Return countnum + NudQuantity.Value
    End Function
    Function GetDiscount(ByVal dblprice As Double) As Double
        Return dblprice * dbldiscount
    End Function
    Private Sub btnClearorder_Click(sender As Object, e As EventArgs) Handles btnClearorder.Click

        chkapple.Checked = False
        chkHam.Checked = False
        chkLettuce.Checked = False
        chkTomato.Checked = False
        chkTuna.Checked = False

        radGrainWheat.Checked = False
        radHoneyOat.Checked = False

        NudQuantity.Value = 1
        txtOrderamt.Clear()
        txtCustomername.Clear()

        MessageBox.Show("Order is clear", " My cafe system ")

    End Sub

    Private Sub btnClearAccumulation_Click(sender As Object, e As EventArgs) Handles btnClearAccumulation.Click

        txtNumberofOrders.Text = 0
        NudQuantity.Value = 1
        txtAverageofSales.Text = "---"
        txtTotalSales.Text = "$0.00"
        txtLargestSales.Text = "$0.00"
        lstCustomerHistory.Items.Clear()
        txtfind.Clear()

        AppleCount = 0
        Lettucecount = 0
        TomatoCount = 0
        HamCount = 0
        tunaCount = 0

        Numord = 0
        TotalSales = 0
        AverageofSales = 0
        LargestSales = 0

        MessageBox.Show("Accumulation is clear", " My Cafe system ")

    End Sub
    Private Sub BtnMostPopularIngredient_Click(sender As Object, e As EventArgs) Handles BtnMostPopularIngredient.Click
        Dim intRank, intnum1st As Integer
        Dim Ingredientcount() As Integer = {AppleCount, Lettucecount, TomatoCount, HamCount, tunaCount}
        Dim IngredientName() As String = {"Apple", "Lettuce", "Tomato", "Ham", "Tuna"}
        Array.Sort(Ingredientcount, IngredientName)

        For i As Integer = Ingredientcount.Count - 1 To 0 Step -1
            intRank += 1
            intnum1st = Ingredientcount(4)
            Ranklist = Ranklist & vbCrLf & (intRank) & "." & IngredientName(i) & " x " & CStr(Ingredientcount(i))
            If Ingredientcount(i) = Ingredientcount(4) Then
                popularitem = popularitem & " " & IngredientName(i)
            End If
        Next

        If intnum1st > 0 Then
            MessageBox.Show("Most Popular Ingredient:" & popularitem & " " & vbCrLf & "Ranking list :" & Ranklist, " My Cafe system ")
        Else MessageBox.Show("No record", " My Cafe system ")
        End If

        popularitem = ""
        Ranklist = ""

    End Sub

    Private Sub btnFind_Click_1(sender As Object, e As EventArgs) Handles btnFind.Click

        Dim i, j As Integer
        Dim keyword As String = txtfind.Text.Trim
        Dim ans As Integer = -1

        If Not (String.IsNullOrEmpty(txtfind.Text)) Then

            For j = 0 To nameline
                For i = 0 To lstCustomerHistory.Items.Count - 1 Step 1
                    If CStr(lstCustomerHistory.Items(i)) = j & ": " + keyword Then
                        checkline = checkline & " " & i + 1
                        ans = +1
                    End If
                Next
            Next

            If ans >= 0 Then
                MessageBox.Show((txtfind.Text.Trim) & " is on line" & checkline & " of the list.", " My Cafe system ")
            End If

            If ans - 1 Then
                MessageBox.Show("Customer not found", " My Cafe system ")
            End If

        End If

        If String.IsNullOrEmpty(txtfind.Text) Then
            MessageBox.Show("Please enter the name", " My Cafe system ")
        End If

        checkline = ""

    End Sub
End Class



