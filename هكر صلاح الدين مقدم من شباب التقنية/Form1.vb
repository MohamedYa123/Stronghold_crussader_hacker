Public Class Form1

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        WriteInteger("Stronghold Crusader.exe", &H992FD8, 50)
        Me.Cursor = cc.Cursor

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        l3.Hide()

        a0.Text = ReadLong("Stronghold Crusader.exe", &HD64830)


        a1.Text = ReadLong("Stronghold Crusader.exe", &HD7A3E8)
        a2.Text = ReadLong("Stronghold Crusader.exe", &HD7DDDC)
        a3.Text = ReadLong("Stronghold Crusader.exe", &HD68224)
        a4.Text = ReadLong("Stronghold Crusader.exe", &HD6BC18)
        a5.Text = ReadLong("Stronghold Crusader.exe", &HD6F60C)
        a6.Text = ReadLong("Stronghold Crusader.exe", &HD73000)
        a7.Text = ReadLong("Stronghold Crusader.exe", &HD769F4)
        Me.Cursor = Cursors.Default
        If Button11.Text = "«·≈›·«” «· ·ﬁ«∆Ì „‘€·" Then
            If c1.Checked = True Then
                WriteInteger("Stronghold Crusader.exe", &HD7A3E8, 0)

            End If
            If c2.Checked = True Then
                WriteInteger("Stronghold Crusader.exe", &HD7DDDC, 0)

            End If
            If c3.Checked = True Then
                WriteInteger("Stronghold Crusader.exe", &HD68224, 0)

            End If
            If c4.Checked = True Then
                WriteInteger("Stronghold Crusader.exe", &HD6BC18, 0)

            End If
            If c5.Checked = True Then
                WriteInteger("Stronghold Crusader.exe", &HD6F60C, 0)

            End If
            If c6.Checked = True Then
                WriteInteger("Stronghold Crusader.exe", &HD73000, 0)

            End If
            If c7.Checked = True Then
                WriteInteger("Stronghold Crusader.exe", &HD769F4, 0)

            End If

        End If

    End Sub

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click


        WriteInteger("Stronghold Crusader.exe", &HD64830, (CDec(ReadLong("Stronghold Crusader.exe", &HD64830)) + CDec(t1.Text)))


    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        WriteInteger("Stronghold Crusader.exe", &HD64830, CDec(t1.Text))
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        WriteInteger("Stronghold Crusader.exe", &HD7A3E8, CDec(g1.Text))
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        WriteInteger("Stronghold Crusader.exe", &HD7DDDC, CDec(g2.Text))
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        WriteInteger("Stronghold Crusader.exe", &HD68224, CDec(g3.Text))
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        WriteInteger("Stronghold Crusader.exe", &HD6BC18, CDec(g4.Text))
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        WriteInteger("Stronghold Crusader.exe", &HD6F60C, CDec(g5.Text))
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        WriteInteger("Stronghold Crusader.exe", &HD73000, CDec(g6.Text))
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        WriteInteger("Stronghold Crusader.exe", &HD769F4, CDec(g7.Text))
    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        If Button11.Text = "«·≈›·«” «· ·ﬁ«∆Ì €Ì— „‘€·" Then
            Button11.Text = "«·≈›·«” «· ·ﬁ«∆Ì „‘€·"
        Else
            Button11.Text = "«·≈›·«” «· ·ﬁ«∆Ì €Ì— „‘€·"
        End If
    End Sub

    Private Sub Label12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label12.Click
        MsgBox("Â–Â ≈ÕœÌ «·„Ì“«  «·Õ’—Ì… ›Ì Â–« «·»—‰«„Ã  Œ ’ »‘· «·√⁄œ«¡ ÕÌÀ  ﬁ÷Ì ⁄·Ì „«ÌÃ„⁄Ê‰ „‰ √„Ê«· »«” „—«— Ê  „‰⁄Â„ „‰ »‰«¡ „„·ﬂ… ﬁÊÌ… √Ê »‰«¡ ÃÌ‘ ··ﬁÌ«„ »Â« ﬁ„ » ÕœÌœ «·„·Êﬂ «·–Ì‰  —€» ›Ì «›·«”Â„ À„ «÷€ÿ ⁄·Ì «·–—")
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles p1.Click
        Form2.la.Text = 1
        Form2.Show()

    End Sub

    Private Sub PictureBox7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles p2.Click
        Form2.la.Text = 2
        Form2.Show()

    End Sub

    Private Sub PictureBox6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles p3.Click
        Form2.la.Text = 3
        Form2.Show()

    End Sub

    Private Sub PictureBox5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles p4.Click
        Form2.la.Text = 4
        Form2.Show()

    End Sub

    Private Sub PictureBox4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles p5.Click
        Form2.la.Text = 5
        Form2.Show()

    End Sub

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles p6.Click
        Form2.la.Text = 6
        Form2.Show()

    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles p7.Click
        Form2.la.Text = 7
        Form2.Show()

    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        Form3.Show()

    End Sub

    Private Sub Form1_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed
       
    End Sub

    Private Sub Form1_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Leave
       

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Form1_VisibleChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.VisibleChanged
        Process.Start("http://tecyouthyt.blogspot.com")
        Process.Start("https://www.youtube.com/channel/UCyK_zVDWCutbm8Ji_m3QDWQ")

    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click
        If Label2.Text = "⁄œÊ" Then
            Label2.Text = "’œÌﬁ"
            Label2.ForeColor = Color.Green
            c1.Enabled = False
            c1.Checked = False

        Else
            Label2.Text = "⁄œÊ"
            Label2.ForeColor = Color.Red
            c1.Enabled = True

        End If
    End Sub

    Private Sub Label7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label7.Click
        If Label7.Text = "⁄œÊ" Then
            Label7.Text = "’œÌﬁ"
            Label7.ForeColor = Color.Green
            c2.Enabled = False
            c2.Checked = False

        Else
            Label7.Text = "⁄œÊ"
            Label7.ForeColor = Color.Red
            c2.Enabled = True

        End If
    End Sub

    Private Sub Label6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label6.Click
        If Label6.Text = "⁄œÊ" Then
            Label6.Text = "’œÌﬁ"
            Label6.ForeColor = Color.Green
            c3.Enabled = False
            c3.Checked = False

        Else
            Label6.Text = "⁄œÊ"
            Label6.ForeColor = Color.Red
            c3.Enabled = True

        End If
    End Sub

    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label5.Click
        If Label5.Text = "⁄œÊ" Then
            Label5.Text = "’œÌﬁ"
            Label5.ForeColor = Color.Green
            c4.Enabled = False
            c4.Checked = False


        Else
            Label5.Text = "⁄œÊ"
            Label5.ForeColor = Color.Red
            c4.Enabled = True

        End If
    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click
        If Label4.Text = "⁄œÊ" Then
            Label4.Text = "’œÌﬁ"
            Label4.ForeColor = Color.Green
            c5.Enabled = False
            c5.Checked = False


        Else
            Label4.Text = "⁄œÊ"
            Label4.ForeColor = Color.Red
            c5.Enabled = True

        End If
    End Sub

    Private Sub Label9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label9.Click
        If Label9.Text = "⁄œÊ" Then
            Label9.Text = "’œÌﬁ"
            Label9.ForeColor = Color.Green
            c6.Enabled = False
            c6.Checked = False

        Else
            Label9.Text = "⁄œÊ"
            Label9.ForeColor = Color.Red
            c6.Enabled = True

        End If
    End Sub

    Private Sub Label8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label8.Click
        If Label8.Text = "⁄œÊ" Then
            Label8.Text = "’œÌﬁ"
            Label8.ForeColor = Color.Green
            c7.Enabled = False
            c7.Checked = False

        Else
            Label8.Text = "⁄œÊ"
            Label8.ForeColor = Color.Red
            c7.Enabled = True

        End If
    End Sub
End Class
