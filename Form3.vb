Imports Magic_Gift.Details
Public Class frmAnniversary

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        product_name = prodname1.Text
        product_price = prodprice1.Text
        If prodqty1.Text = "" Then
            MsgBox("  Please enter Quantity  ")
        Else
            product_qty = prodqty1.Text
            Me.Hide()
            frmOrder.Show()
            frmOrder.SetDesktopLocation(150, 130)
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        product_name = prodname2.Text
        product_price = prodprice2.Text
        If prodqty2.Text = "" Then
            MsgBox("  Please enter Quantity  ")
        Else
            product_qty = prodqty2.Text
            Me.Hide()
            frmOrder.Show()
            frmOrder.SetDesktopLocation(150, 130)
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        product_name = prodname3.Text
        product_price = prodprice3.Text
        If prodqty3.Text = "" Then
            MsgBox("  Please enter Quantity  ")
        Else
            product_qty = prodqty3.Text
            Me.Hide()
            frmOrder.Show()
            frmOrder.SetDesktopLocation(150, 130)
        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        product_name = prodname4.Text
        product_price = prodprice4.Text
        If prodqty4.Text = "" Then
            MsgBox("  Please enter Quantity  ")
        Else
            product_qty = prodqty4.Text
            Me.Hide()
            frmOrder.Show()
            frmOrder.SetDesktopLocation(150, 130)
        End If
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        product_name = prodname5.Text
        product_price = prodprice5.Text
        If prodqty5.Text = "" Then
            MsgBox("  Please enter Quantity  ")
        Else
            product_qty = prodqty5.Text
            Me.Hide()
            frmOrder.Show()
            frmOrder.SetDesktopLocation(150, 130)
        End If
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        product_name = prodname6.Text
        product_price = prodprice6.Text
        If prodqty6.Text = "" Then
            MsgBox("  Please enter Quantity  ")
        Else
            product_qty = prodqty6.Text
            Me.Hide()
            frmOrder.Show()
            frmOrder.SetDesktopLocation(150, 130)
        End If
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        product_name = prodname7.Text
        product_price = prodprice7.Text
        If prodqty7.Text = "" Then
            MsgBox("  Please enter Quantity  ")
        Else
            product_qty = prodqty7.Text
            Me.Hide()
            frmOrder.Show()
            frmOrder.SetDesktopLocation(150, 130)
        End If
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        product_name = prodname8.Text
        product_price = prodprice8.Text
        If prodqty8.Text = "" Then
            MsgBox("  Please enter Quantity  ")
        Else
            product_qty = prodqty8.Text
            Me.Hide()
            frmOrder.Show()
            frmOrder.SetDesktopLocation(150, 130)
        End If
    End Sub
End Class