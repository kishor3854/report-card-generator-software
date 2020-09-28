Public Class Form1
    Dim bmp As Bitmap
    Dim filename As String

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub TextBox5_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox5.TextChanged

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If Me.ComboBox1.SelectedIndex <= 4 And Me.ComboBox1.SelectedIndex >= 0 Then
            First()
            Second()
            Third()
            Four()
        ElseIf Me.ComboBox1.SelectedIndex <= 12 And Me.ComboBox1.SelectedIndex >= 10 Then
            First()
            Second()
            Third()
            Four()
            Five()
        Else
            First()
            Second()
            Third()
            Four()
            Five()
            Six()
        End If
    End Sub

    Private Sub First()
        Me.TextBox9.Text = Val(Me.TextBox7.Text) + Val(Me.TextBox8.Text)
    End Sub

    Private Sub Second()
        Me.TextBox36.Text = Val(Me.TextBox38.Text) + Val(Me.TextBox37.Text)
    End Sub

    Private Sub Third()
        Me.TextBox69.Text = Val(Me.TextBox70.Text) + Val(Me.TextBox71.Text)
    End Sub

    Private Sub Four()
        Me.TextBox88.Text = Val(Me.TextBox89.Text) + Val(Me.TextBox90.Text)
    End Sub

    Private Sub Five()
        Me.TextBox107.Text = Val(Me.TextBox109.Text) + Val(Me.TextBox108.Text)
    End Sub

    Private Sub Six()
        Me.TextBox126.Text = Val(Me.TextBox128.Text) + Val(Me.TextBox127.Text)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If Me.ComboBox1.SelectedIndex <= 4 And Me.ComboBox1.SelectedIndex >= 0 Then
            sf()
            ss()
            st()
            sfo()
        ElseIf Me.ComboBox1.SelectedIndex <= 12 And Me.ComboBox1.SelectedIndex >= 10 Then
            sf()
            ss()
            st()
            sfo()
            sfi()
        Else
            sf()
            ss()
            st()
            sfo()
            sfi()
            ssi()
        End If
    End Sub
    Private Sub sf()
        Me.TextBox12.Text = Val(Me.TextBox10.Text) + Val(Me.TextBox11.Text)
    End Sub

    Private Sub ss()
        Me.TextBox51.Text = Val(Me.TextBox35.Text) + Val(Me.TextBox34.Text)
    End Sub

    Private Sub st()
        Me.TextBox66.Text = Val(Me.TextBox68.Text) + Val(Me.TextBox67.Text)
    End Sub

    Private Sub sfo()
        Me.TextBox85.Text = Val(Me.TextBox86.Text) + Val(Me.TextBox87.Text)
    End Sub

    Private Sub sfi()
        Me.TextBox104.Text = Val(Me.TextBox106.Text) + Val(Me.TextBox105.Text)
    End Sub

    Private Sub ssi()
        Me.TextBox123.Text = Val(Me.TextBox124.Text) + Val(Me.TextBox125.Text)
    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If Me.ComboBox1.SelectedIndex <= 4 And Me.ComboBox1.SelectedIndex >= 0 Then
            THF()
            THS()
            THT()
            THFO()
        ElseIf Me.ComboBox1.SelectedIndex <= 12 And Me.ComboBox1.SelectedIndex >= 10 Then
            THF()
            THS()
            THT()
            THFO()
            THFI()
        Else
            THF()
            THS()
            THT()
            THFO()
            THFI()
            THSI()
        End If
    End Sub

    Private Sub THF()
        Me.TextBox15.Text = Val(Me.TextBox13.Text) + Val(Me.TextBox14.Text)
    End Sub

    Private Sub THS()
        Me.TextBox48.Text = Val(Me.TextBox49.Text) + Val(Me.TextBox50.Text)
    End Sub

    Private Sub THT()
        Me.TextBox63.Text = Val(Me.TextBox65.Text) + Val(Me.TextBox64.Text)
    End Sub

    Private Sub THFO()
        Me.TextBox82.Text = Val(Me.TextBox84.Text) + Val(Me.TextBox83.Text)
    End Sub

    Private Sub THFI()
        Me.TextBox101.Text = Val(Me.TextBox102.Text) + Val(Me.TextBox103.Text)
    End Sub

    Private Sub THSI()
        Me.TextBox120.Text = Val(Me.TextBox122.Text) + Val(Me.TextBox121.Text)
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        If Me.ComboBox1.SelectedIndex <= 4 And Me.ComboBox1.SelectedIndex >= 0 Then
            FF()
            FS()
            FT()
            FFO()
        ElseIf Me.ComboBox1.SelectedIndex <= 12 And Me.ComboBox1.SelectedIndex >= 10 Then
            FF()
            FS()
            FT()
            FFO()
            FFI()
        Else
            FF()
            FS()
            FT()
            FFO()
            FFI()
            FSI()
        End If
    End Sub

    Private Sub FF()
        Me.TextBox18.Text = Val(Me.TextBox16.Text) + Val(Me.TextBox17.Text)
    End Sub

    Private Sub FS()
        Me.TextBox45.Text = Val(Me.TextBox46.Text) + Val(Me.TextBox47.Text)
    End Sub

    Private Sub FT()
        Me.TextBox60.Text = Val(Me.TextBox61.Text) + Val(Me.TextBox62.Text)
    End Sub

    Private Sub FFO()
        Me.TextBox79.Text = Val(Me.TextBox80.Text) + Val(Me.TextBox81.Text)
    End Sub

    Private Sub FFI()
        Me.TextBox98.Text = Val(Me.TextBox99.Text) + Val(Me.TextBox100.Text)
    End Sub

    Private Sub FSI()
        Me.TextBox117.Text = Val(Me.TextBox118.Text) + Val(Me.TextBox119.Text)
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        If Me.ComboBox1.SelectedIndex <= 4 And Me.ComboBox1.SelectedIndex >= 0 Then
            HF()
            HS()
            HT()
            HFO()
        ElseIf Me.ComboBox1.SelectedIndex <= 12 And Me.ComboBox1.SelectedIndex >= 10 Then
            HF()
            HS()
            HT()
            HFO()
            HFI()
        Else
            HF()
            HS()
            HT()
            HFO()
            HFI()
            HSI()
        End If
    End Sub

    Private Sub HF()
        Me.TextBox19.Text = Val(Me.TextBox9.Text) + Val(Me.TextBox12.Text) + Val(Me.TextBox15.Text) + Val(Me.TextBox18.Text)
    End Sub

    Private Sub HS()
        Me.TextBox44.Text = Val(Me.TextBox36.Text) + Val(Me.TextBox51.Text) + Val(Me.TextBox48.Text) + Val(Me.TextBox45.Text)
    End Sub

    Private Sub HT()
        Me.TextBox59.Text = Val(Me.TextBox69.Text) + Val(Me.TextBox66.Text) + Val(Me.TextBox63.Text) + Val(Me.TextBox60.Text)
    End Sub

    Private Sub HFO()
        Me.TextBox78.Text = Val(Me.TextBox88.Text) + Val(Me.TextBox85.Text) + Val(Me.TextBox82.Text) + Val(Me.TextBox79.Text)
    End Sub

    Private Sub HFI()
        Me.TextBox97.Text = Val(Me.TextBox107.Text) + Val(Me.TextBox104.Text) + Val(Me.TextBox101.Text) + Val(Me.TextBox98.Text)
    End Sub

    Private Sub HSI()
        Me.TextBox116.Text = Val(Me.TextBox126.Text) + Val(Me.TextBox123.Text) + Val(Me.TextBox120.Text) + Val(Me.TextBox117.Text)
    End Sub

    Private Sub TextBox32_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged

        If Me.ComboBox1.SelectedIndex <= 4 And Me.ComboBox1.SelectedIndex >= 0 Then

            Me.TextBox110.Enabled = False
            Me.TextBox111.Enabled = False
            Me.TextBox112.Enabled = False
            Me.TextBox113.Enabled = False
            Me.TextBox114.Enabled = False
            Me.TextBox115.Enabled = False
            Me.TextBox116.Enabled = False
            Me.TextBox117.Enabled = False
            Me.TextBox118.Enabled = False
            Me.TextBox119.Enabled = False
            Me.TextBox120.Enabled = False
            Me.TextBox121.Enabled = False
            Me.TextBox122.Enabled = False
            Me.TextBox123.Enabled = False
            Me.TextBox124.Enabled = False
            Me.TextBox125.Enabled = False
            Me.TextBox126.Enabled = False
            Me.TextBox127.Enabled = False
            Me.TextBox128.Enabled = False
            Me.TextBox91.Enabled = False
            Me.TextBox92.Enabled = False
            Me.TextBox93.Enabled = False
            Me.TextBox94.Enabled = False
            Me.TextBox95.Enabled = False
            Me.TextBox96.Enabled = False
            Me.TextBox97.Enabled = False
            Me.TextBox98.Enabled = False
            Me.TextBox99.Enabled = False
            Me.TextBox100.Enabled = False
            Me.TextBox101.Enabled = False
            Me.TextBox102.Enabled = False
            Me.TextBox103.Enabled = False
            Me.TextBox104.Enabled = False
            Me.TextBox105.Enabled = False
            Me.TextBox106.Enabled = False
            Me.TextBox107.Enabled = False
            Me.TextBox108.Enabled = False
            Me.TextBox109.Enabled = False
            Label30.Text = " "
            Label32.Text = " "
            Label47.Text = "50"
            Label50.Text = "100"
            Label54.Text = "200"
            Label25.Text = "Maths"
            Label26.Text = "Evs"
            Label15.Text = "40"
            Label34.Text = "40"
            Label57.Text = "40"
            Label58.Text = "280"
            Label70.Text = "400"
            Label71.Text = "800"
            Label49.Text = "70"
        ElseIf Me.ComboBox1.SelectedIndex <= 12 And Me.ComboBox1.SelectedIndex >= 10 Then
            Me.TextBox110.Enabled = False
            Me.TextBox111.Enabled = False
            Me.TextBox112.Enabled = False
            Me.TextBox113.Enabled = False
            Me.TextBox114.Enabled = False
            Me.TextBox115.Enabled = False
            Me.TextBox116.Enabled = False
            Me.TextBox117.Enabled = False
            Me.TextBox118.Enabled = False
            Me.TextBox119.Enabled = False
            Me.TextBox120.Enabled = False
            Me.TextBox121.Enabled = False
            Me.TextBox122.Enabled = False
            Me.TextBox123.Enabled = False
            Me.TextBox124.Enabled = False
            Me.TextBox125.Enabled = False
            Me.TextBox126.Enabled = False
            Me.TextBox127.Enabled = False
            Me.TextBox128.Enabled = False
            Label25.Text = "Physics"
            Label26.Text = "Chemistry"
            Label30.Text = "Maths/Biology"
            Label32.Text = " "
            Label15.Text = "50"
            Label34.Text = "50"
            Label57.Text = "50"
            Label58.Text = "500"
            Label70.Text = "500"
            Label71.Text = "1150"
            Label49.Text = "70"
        Else
            Label71.Text = "1200"
            Label70.Text = "600"
            Label15.Text = "60"
            Label34.Text = "60"
            Label57.Text = "60"
            Label25.Text = "Maths"
            Label26.Text = "Social Science"
            Label30.Text = "Sanskrit"
            Label32.Text = "Science"
            Label47.Text = "50"
            Label49.Text = "70"
            Label58.Text = "420"
            Label50.Text = "100"
            Label54.Text = "200"
            Me.TextBox110.Enabled = True
            Me.TextBox111.Enabled = True
            Me.TextBox112.Enabled = True
            Me.TextBox113.Enabled = True
            Me.TextBox114.Enabled = True
            Me.TextBox115.Enabled = True
            Me.TextBox116.Enabled = True
            Me.TextBox117.Enabled = True
            Me.TextBox118.Enabled = True
            Me.TextBox119.Enabled = True
            Me.TextBox120.Enabled = True
            Me.TextBox121.Enabled = True
            Me.TextBox122.Enabled = True
            Me.TextBox123.Enabled = True
            Me.TextBox124.Enabled = True
            Me.TextBox125.Enabled = True
            Me.TextBox126.Enabled = True
            Me.TextBox127.Enabled = True
            Me.TextBox128.Enabled = True
            Me.TextBox91.Enabled = True
            Me.TextBox92.Enabled = True
            Me.TextBox93.Enabled = True
            Me.TextBox94.Enabled = True
            Me.TextBox95.Enabled = True
            Me.TextBox96.Enabled = True
            Me.TextBox97.Enabled = True
            Me.TextBox98.Enabled = True
            Me.TextBox99.Enabled = True
            Me.TextBox100.Enabled = True
            Me.TextBox101.Enabled = True
            Me.TextBox102.Enabled = True
            Me.TextBox103.Enabled = True
            Me.TextBox104.Enabled = True
            Me.TextBox105.Enabled = True
            Me.TextBox106.Enabled = True
            Me.TextBox107.Enabled = True
            Me.TextBox108.Enabled = True
            Me.TextBox109.Enabled = True


        End If
    End Sub

    Private Sub TextBox33_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        If Me.ComboBox1.SelectedIndex <= 4 And Me.ComboBox1.SelectedIndex >= 0 Then
            TOF()
        ElseIf Me.ComboBox1.SelectedIndex <= 12 And Me.ComboBox1.SelectedIndex >= 10 Then
            TOS()
        Else
            TOTH()
        End If
    End Sub

    Private Sub TOF()
        Me.TextBox6.Text = Val(Me.TextBox9.Text) + Val(Me.TextBox36.Text) + Val(Me.TextBox69.Text) + Val(Me.TextBox88.Text)

        Me.TextBox26.Text = Val(Me.TextBox12.Text) + Val(Me.TextBox66.Text) + Val(Me.TextBox51.Text) + Val(Me.TextBox85.Text)

        Me.TextBox27.Text = Val(Me.TextBox15.Text) + Val(Me.TextBox48.Text) + Val(Me.TextBox63.Text) + Val(Me.TextBox82.Text)

        Me.TextBox156.Text = Val(Me.TextBox18.Text) + Val(Me.TextBox60.Text) + Val(Me.TextBox45.Text) + Val(Me.TextBox79.Text)

        Me.TextBox154.Text = Val(Me.TextBox19.Text) + Val(Me.TextBox44.Text) + Val(Me.TextBox59.Text) + Val(Me.TextBox78.Text)

        Me.TextBox153.Text = Val(Me.TextBox22.Text) + Val(Me.TextBox41.Text) + Val(Me.TextBox56.Text) + Val(Me.TextBox75.Text)

        Me.TextBox150.Text = Val(Me.TextBox23.Text) + Val(Me.TextBox40.Text) + Val(Me.TextBox55.Text) + Val(Me.TextBox74.Text)
    End Sub

    Private Sub TOS()
        Me.TextBox6.Text = Val(Me.TextBox9.Text) + Val(Me.TextBox36.Text) + Val(Me.TextBox69.Text) + Val(Me.TextBox88.Text) + Val(Me.TextBox107.Text)

        Me.TextBox26.Text = Val(Me.TextBox12.Text) + Val(Me.TextBox66.Text) + Val(Me.TextBox51.Text) + Val(Me.TextBox85.Text) + Val(Me.TextBox104.Text)

        Me.TextBox27.Text = Val(Me.TextBox15.Text) + Val(Me.TextBox48.Text) + Val(Me.TextBox63.Text) + Val(Me.TextBox82.Text) + Val(Me.TextBox101.Text)

        Me.TextBox156.Text = Val(Me.TextBox18.Text) + Val(Me.TextBox60.Text) + Val(Me.TextBox45.Text) + Val(Me.TextBox79.Text) + Val(Me.TextBox98.Text)

        Me.TextBox154.Text = Val(Me.TextBox19.Text) + Val(Me.TextBox44.Text) + Val(Me.TextBox59.Text) + Val(Me.TextBox78.Text) + Val(Me.TextBox97.Text)

        Me.TextBox153.Text = Val(Me.TextBox22.Text) + Val(Me.TextBox41.Text) + Val(Me.TextBox56.Text) + Val(Me.TextBox75.Text) + Val(Me.TextBox94.Text)

        Me.TextBox150.Text = Val(Me.TextBox23.Text) + Val(Me.TextBox40.Text) + Val(Me.TextBox55.Text) + Val(Me.TextBox74.Text) + Val(Me.TextBox93.Text)
    End Sub

    Private Sub TOTH()
        Me.TextBox6.Text = Val(Me.TextBox9.Text) + Val(Me.TextBox36.Text) + Val(Me.TextBox69.Text) + Val(Me.TextBox88.Text) + Val(Me.TextBox107.Text) + Val(Me.TextBox126.Text)

        Me.TextBox26.Text = Val(Me.TextBox12.Text) + Val(Me.TextBox66.Text) + Val(Me.TextBox51.Text) + Val(Me.TextBox85.Text) + Val(Me.TextBox104.Text) + Val(Me.TextBox123.Text)

        Me.TextBox27.Text = Val(Me.TextBox15.Text) + Val(Me.TextBox48.Text) + Val(Me.TextBox63.Text) + Val(Me.TextBox82.Text) + Val(Me.TextBox101.Text) + Val(Me.TextBox120.Text)

        Me.TextBox156.Text = Val(Me.TextBox18.Text) + Val(Me.TextBox60.Text) + Val(Me.TextBox45.Text) + Val(Me.TextBox79.Text) + Val(Me.TextBox98.Text) + Val(Me.TextBox117.Text)

        Me.TextBox154.Text = Val(Me.TextBox19.Text) + Val(Me.TextBox44.Text) + Val(Me.TextBox59.Text) + Val(Me.TextBox78.Text) + Val(Me.TextBox97.Text) + Val(Me.TextBox116.Text)

        Me.TextBox153.Text = Val(Me.TextBox22.Text) + Val(Me.TextBox41.Text) + Val(Me.TextBox56.Text) + Val(Me.TextBox75.Text) + Val(Me.TextBox94.Text) + Val(Me.TextBox113.Text)

        Me.TextBox150.Text = Val(Me.TextBox23.Text) + Val(Me.TextBox40.Text) + Val(Me.TextBox55.Text) + Val(Me.TextBox74.Text) + Val(Me.TextBox93.Text) + Val(Me.TextBox112.Text)
    End Sub


    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        If Me.ComboBox1.SelectedIndex <= 4 And Me.ComboBox1.SelectedIndex >= 0 Then
            SEF()
            SES()
            SETH()
            SEFO()
        ElseIf Me.ComboBox1.SelectedIndex <= 12 And Me.ComboBox1.SelectedIndex >= 10 Then
            SEF()
            SES()
            SETH()
            SEFO()
            SEFI()
        Else
            SEF()
            SES()
            SETH()
            SEFO()
            SEFI()
            SESI()
        End If
    End Sub

    Private Sub SEF()
        Me.TextBox23.Text = Val(Me.TextBox19.Text) + Val(Me.TextBox22.Text)
    End Sub

    Private Sub SES()
        Me.TextBox40.Text = Val(Me.TextBox41.Text) + Val(Me.TextBox44.Text)
    End Sub

    Private Sub SETH()
        Me.TextBox55.Text = Val(Me.TextBox56.Text) + Val(Me.TextBox59.Text)
    End Sub

    Private Sub SEFO()
        Me.TextBox74.Text = Val(Me.TextBox75.Text) + Val(Me.TextBox78.Text)
    End Sub

    Private Sub SEFI()
        Me.TextBox93.Text = Val(Me.TextBox97.Text) + Val(Me.TextBox94.Text)
    End Sub

    Private Sub SESI()
        Me.TextBox112.Text = Val(Me.TextBox113.Text) + Val(Me.TextBox116.Text)
    End Sub


    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        If Me.ComboBox1.SelectedIndex <= 4 And Me.ComboBox1.SelectedIndex >= 0 Then
            PF()
            PS()
            PT()
            PFO()
            PFI()
            PSI()
            Me.TextBox92.Enabled = False
            Me.TextBox111.Enabled = False
        ElseIf Me.ComboBox1.SelectedIndex <= 12 And Me.ComboBox1.SelectedIndex >= 10 Then
            PF()
            PS()
            PT()
            PFO()
            PFI()
            Me.TextBox111.Enabled = False
        Else
            PF()
            PS()
            PT()
            PFO()
            PFI()
            PSI()
        End If
    End Sub

    Private Sub PF()
        Me.TextBox24.Text = Val(Me.TextBox23.Text) * 100 / Label54.Text
    End Sub

    Private Sub PS()
        Me.TextBox39.Text = Val(Me.TextBox40.Text) * 100 / Label54.Text
    End Sub

    Private Sub PT()
        Me.TextBox54.Text = Val(Me.TextBox55.Text) * 100 / Label54.Text
    End Sub

    Private Sub PFO()
        Me.TextBox73.Text = Val(Me.TextBox74.Text) * 100 / Label54.Text
    End Sub

    Private Sub PFI()
        Me.TextBox92.Text = Val(Me.TextBox93.Text) * 100 / Label54.Text
    End Sub

    Private Sub PSI()
        Me.TextBox111.Text = Val(Me.TextBox112.Text) * 100 / Label54.Text
    End Sub
    Private Sub Label29_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label29.Click

    End Sub
    Private Sub Label28_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label28.Click

    End Sub
    Private Sub Label24_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label24.Click

    End Sub
    Private Sub Label23_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label23.Click

    End Sub
    Private Sub Label19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label19.Click

    End Sub
    Private Sub Label17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label17.Click

    End Sub
    Private Sub Label18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label18.Click

    End Sub
    Private Sub Label16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label16.Click

    End Sub
    Private Sub Label14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label14.Click

    End Sub
    Private Sub Label13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label13.Click

    End Sub

    Private Sub TextBox63_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox63.TextChanged

    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        If Me.ComboBox1.SelectedIndex <= 4 And Me.ComboBox1.SelectedIndex >= 0 Then
            AF()
            ASE()
            AT()
            AFO()
        Else
            AF()
            ASE()
            AT()
            AFO()
            AFI()
            ASI()
        End If
    End Sub

    Private Sub AF()
        Me.TextBox22.Text = Val(Me.TextBox21.Text) + Val(Me.TextBox20.Text)
    End Sub

    Private Sub ASE()
        Me.TextBox41.Text = Val(Me.TextBox42.Text) + Val(Me.TextBox43.Text)
    End Sub

    Private Sub AT()
        Me.TextBox56.Text = Val(Me.TextBox57.Text) + Val(Me.TextBox58.Text)
    End Sub

    Private Sub AFO()
        Me.TextBox75.Text = Val(Me.TextBox76.Text) + Val(Me.TextBox77.Text)
    End Sub

    Private Sub AFI()
        Me.TextBox94.Text = Val(Me.TextBox95.Text) + Val(Me.TextBox96.Text)
    End Sub

    Private Sub ASI()
        Me.TextBox113.Text = Val(Me.TextBox114.Text) + Val(Me.TextBox115.Text)
    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        Me.TextBox132.Text = Val(Me.TextBox6.Text) * 100 / Label15.Text

        Me.TextBox131.Text = Val(Me.TextBox26.Text) * 100 / Label34.Text

        Me.TextBox130.Text = Val(Me.TextBox27.Text) * 100 / Label57.Text

        Me.TextBox139.Text = Val(Me.TextBox156.Text) * 100 / Label58.Text

        Me.TextBox137.Text = Val(Me.TextBox153.Text) * 100 / Label70.Text

        Me.TextBox135.Text = Val(Me.TextBox150.Text) * 100 / Label71.Text

    End Sub

    Private Sub Label27_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label27.Click

    End Sub

    Private Sub Label79_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label79.Click

    End Sub

    Private Sub TextBox121_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox121.TextChanged

    End Sub

    Private Sub TextBox138_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox138.TextChanged

    End Sub

    Private Sub Label20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label20.Click

    End Sub

    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label5.Click

    End Sub

    Private Sub Label49_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label49.Click

    End Sub

    Private Sub Label71_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label71.Click

    End Sub

    Private Sub TextBox133_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox133.TextChanged

    End Sub

    Private Sub Label22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label22.Click

    End Sub

    Private Sub TextBox68_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox68.TextChanged

    End Sub

    Private Sub TextBox69_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox69.TextChanged

    End Sub

    Private Sub Label15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label15.Click

    End Sub

    Private Sub Label80_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label80.Click

    End Sub

    Private Sub TextBox60_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox60.TextChanged

    End Sub

    Private Sub TextBox61_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox61.TextChanged

    End Sub

    Private Sub TextBox62_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox62.TextChanged

    End Sub

    Private Sub Label38_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label38.Click

    End Sub

    Private Sub TextBox64_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox64.TextChanged

    End Sub

    Private Sub TextBox65_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox65.TextChanged

    End Sub

    Private Sub TextBox66_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox66.TextChanged

    End Sub

    Private Sub TextBox67_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox67.TextChanged

    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click

    End Sub

    Private Sub TextBox20_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox20.TextChanged

    End Sub

    Private Sub TextBox124_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox124.TextChanged

    End Sub

    Private Sub TextBox134_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox134.TextChanged

    End Sub

    Private Sub TextBox144_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox144.TextChanged

    End Sub

    Private Sub TextBox154_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox154.TextChanged

    End Sub

    Private Sub TextBox164_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox164.TextChanged

    End Sub

    Private Sub TextBox174_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox174.TextChanged

    End Sub

    Private Sub TextBox169_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox169.TextChanged

    End Sub

    Private Sub TextBox185_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox185.TextChanged

    End Sub

    Private Sub TextBox195_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox195.TextChanged

    End Sub

    Private Sub TextBox192_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox192.TextChanged

    End Sub

    Private Sub TextBox155_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox155.TextChanged

    End Sub

    Private Sub Label55_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label55.Click

    End Sub

    Private Sub TextBox115_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox115.TextChanged

    End Sub

    Private Sub TextBox125_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox125.TextChanged

    End Sub

    Private Sub TextBox95_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox95.TextChanged

    End Sub

    Private Sub TextBox145_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox145.TextChanged

    End Sub

    Private Sub Label83_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label83.Click

    End Sub

    Private Sub TextBox175_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox175.TextChanged

    End Sub

    Private Sub Label68_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub TextBox112_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox112.TextChanged

    End Sub

    Private Sub TextBox152_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox152.TextChanged

    End Sub

    Private Sub TextBox103_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox103.TextChanged

    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click

    End Sub

    Private Sub TextBox196_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox196.TextChanged

    End Sub

    Private Sub Label50_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label50.Click

    End Sub

    Private Sub Label6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label6.Click

    End Sub

    Private Sub TextBox126_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox126.TextChanged

    End Sub

    Private Sub Label63_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label63.Click

    End Sub

    Private Sub TextBox146_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox146.TextChanged

    End Sub

    Private Sub TextBox156_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox156.TextChanged

    End Sub

    Private Sub TextBox114_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox114.TextChanged

    End Sub

    Private Sub TextBox176_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox176.TextChanged

    End Sub

    Private Sub TextBox127_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox127.TextChanged

    End Sub

    Private Sub TextBox181_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox181.TextChanged

    End Sub

    Private Sub Label33_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label33.Click

    End Sub

    Private Sub TextBox142_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox142.TextChanged

    End Sub

    Private Sub Label40_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label40.Click

    End Sub

    Private Sub TextBox180_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox180.TextChanged

    End Sub

    Private Sub Label86_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label86.Click

    End Sub

    Private Sub TextBox131_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox131.TextChanged

    End Sub

    Private Sub Label32_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label32.Click

    End Sub

    Private Sub TextBox117_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox117.TextChanged

    End Sub

    Private Sub TextBox59_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox59.TextChanged

    End Sub

    Private Sub Label21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label21.Click

    End Sub

    Private Sub TextBox147_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox147.TextChanged

    End Sub

    Private Sub TextBox157_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox157.TextChanged

    End Sub

    Private Sub TextBox167_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox167.TextChanged

    End Sub

    Private Sub TextBox163_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox163.TextChanged

    End Sub

    Private Sub TextBox162_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox162.TextChanged

    End Sub

    Private Sub TextBox143_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox143.TextChanged

    End Sub

    Private Sub TextBox8_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox8.TextChanged

    End Sub

    Private Sub TextBox132_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox132.TextChanged

    End Sub

    Private Sub TextBox190_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox190.TextChanged

    End Sub

    Private Sub Label70_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label70.Click

    End Sub

    Private Sub TextBox3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox3.TextChanged

    End Sub

    Private Sub TextBox108_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox108.TextChanged

    End Sub

    Private Sub TextBox100_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox100.TextChanged

    End Sub

    Private Sub Label39_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label39.Click

    End Sub

    Private Sub TextBox120_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox120.TextChanged

    End Sub

    Private Sub TextBox130_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox130.TextChanged

    End Sub

    Private Sub Label65_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TextBox4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox4.TextChanged

    End Sub

    Private Sub TextBox28_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox28.TextChanged

    End Sub

    Private Sub TextBox21_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox21.TextChanged

    End Sub

    Private Sub TextBox150_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox150.TextChanged

    End Sub

    Private Sub TextBox166_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox166.TextChanged

    End Sub

    Private Sub TextBox58_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox58.TextChanged

    End Sub

    Private Sub TextBox22_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox22.TextChanged

    End Sub

    Private Sub TextBox23_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox23.TextChanged

    End Sub

    Private Sub TextBox24_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox24.TextChanged

    End Sub

    Private Sub TextBox25_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox25.TextChanged

    End Sub

    Private Sub TextBox26_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox26.TextChanged

    End Sub

    Private Sub TextBox7_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox7.TextChanged

    End Sub

    Private Sub TextBox50_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox50.TextChanged

    End Sub

    Private Sub TextBox51_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox51.TextChanged

    End Sub

    Private Sub TextBox53_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox53.TextChanged

    End Sub

    Private Sub TextBox54_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox54.TextChanged

    End Sub

    Private Sub TextBox55_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox55.TextChanged

    End Sub

    Private Sub TextBox56_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox56.TextChanged

    End Sub

    Private Sub TextBox57_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox57.TextChanged

    End Sub

    Private Sub TextBox171_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox171.TextChanged

    End Sub

    Private Sub TextBox122_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox122.TextChanged

    End Sub

    Private Sub Label84_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label84.Click

    End Sub

    Private Sub TextBox52_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox52.TextChanged

    End Sub

    Private Sub TextBox183_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox183.TextChanged

    End Sub

    Private Sub TextBox140_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox140.TextChanged

    End Sub

    Private Sub TextBox88_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox88.TextChanged

    End Sub

    Private Sub TextBox89_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox89.TextChanged

    End Sub

    Private Sub Label10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label10.Click

    End Sub

    Private Sub Label56_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label56.Click

    End Sub

    Private Sub Label51_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label51.Click

    End Sub

    Private Sub TextBox81_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox81.TextChanged

    End Sub

    Private Sub TextBox82_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox82.TextChanged

    End Sub

    Private Sub TextBox83_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox83.TextChanged

    End Sub

    Private Sub TextBox84_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox84.TextChanged

    End Sub

    Private Sub TextBox85_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox85.TextChanged

    End Sub

    Private Sub Label46_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label46.Click

    End Sub

    Private Sub TextBox87_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox87.TextChanged

    End Sub

    Private Sub TextBox102_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox102.TextChanged

    End Sub

    Private Sub TextBox110_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox110.TextChanged

    End Sub

    Private Sub Label87_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label87.Click

    End Sub

    Private Sub TextBox186_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox186.TextChanged

    End Sub

    Private Sub TextBox137_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox137.TextChanged

    End Sub

    Private Sub TextBox193_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox193.TextChanged

    End Sub

    Private Sub TextBox173_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox173.TextChanged

    End Sub

    Private Sub Label35_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label35.Click

    End Sub

    Private Sub TextBox113_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox113.TextChanged

    End Sub

    Private Sub TextBox78_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox78.TextChanged

    End Sub

    Private Sub TextBox79_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox79.TextChanged

    End Sub

    Private Sub TextBox141_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox141.TextChanged

    End Sub

    Private Sub TextBox153_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox153.TextChanged

    End Sub

    Private Sub Label76_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label76.Click

    End Sub

    Private Sub TextBox165_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox165.TextChanged

    End Sub

    Private Sub TextBox70_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox70.TextChanged

    End Sub

    Private Sub TextBox71_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox71.TextChanged

    End Sub

    Private Sub TextBox72_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox72.TextChanged

    End Sub

    Private Sub TextBox73_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox73.TextChanged

    End Sub

    Private Sub TextBox74_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox74.TextChanged

    End Sub

    Private Sub TextBox75_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox75.TextChanged

    End Sub

    Private Sub TextBox77_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox77.TextChanged

    End Sub

    Private Sub Label30_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label30.Click

    End Sub

    Private Sub Label60_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label60.Click

    End Sub

    Private Sub Label45_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label45.Click

    End Sub

    Private Sub Label25_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label25.Click

    End Sub

    Private Sub TextBox29_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox29.TextChanged

    End Sub

    Private Sub TextBox101_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox101.TextChanged

    End Sub

    Private Sub TextBox118_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox118.TextChanged

    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click

    End Sub

    Private Sub Label66_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TextBox194_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox194.TextChanged

    End Sub

    Private Sub TextBox104_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox104.TextChanged

    End Sub

    Private Sub Label72_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Label54_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label54.Click

    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label61_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label61.Click

    End Sub

    Private Sub Label82_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label82.Click

    End Sub

    Private Sub TextBox172_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox172.TextChanged

    End Sub

    Private Sub TextBox6_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox6.TextChanged

    End Sub

    Private Sub Label7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label7.Click

    End Sub

    Private Sub Label73_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Label57_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label57.Click

    End Sub

    Private Sub TextBox18_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox18.TextChanged

    End Sub

    Private Sub TextBox19_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox19.TextChanged

    End Sub

    Private Sub Label44_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label44.Click

    End Sub

    Private Sub TextBox10_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox10.TextChanged

    End Sub

    Private Sub TextBox11_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox11.TextChanged

    End Sub

    Private Sub TextBox12_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox12.TextChanged

    End Sub

    Private Sub TextBox13_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox13.TextChanged

    End Sub

    Private Sub TextBox14_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox14.TextChanged

    End Sub

    Private Sub TextBox15_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox15.TextChanged

    End Sub

    Private Sub TextBox16_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox16.TextChanged

    End Sub

    Private Sub TextBox17_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox17.TextChanged

    End Sub

    Private Sub Label52_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label52.Click

    End Sub

    Private Sub TextBox184_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox184.TextChanged

    End Sub

    Private Sub Label69_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Label47_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label47.Click

    End Sub

    Private Sub Label78_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label78.Click

    End Sub

    Private Sub TextBox177_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox177.TextChanged

    End Sub

    Private Sub Label74_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label74.Click

    End Sub

    Private Sub TextBox109_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox109.TextChanged

    End Sub

    Private Sub Label81_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label81.Click

    End Sub

    Private Sub TextBox135_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox135.TextChanged

    End Sub

    Private Sub Label89_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label89.Click

    End Sub

    Private Sub TextBox9_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox9.TextChanged

    End Sub

    Private Sub Label42_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label42.Click

    End Sub

    Private Sub TextBox86_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox86.TextChanged

    End Sub

    Private Sub TextBox151_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TextBox168_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox168.TextChanged

    End Sub

    Private Sub Label77_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label77.Click

    End Sub

    Private Sub Label88_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label88.Click

    End Sub

    Private Sub TextBox188_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox188.TextChanged

    End Sub

    Private Sub Label58_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label58.Click

    End Sub

    Private Sub TextBox107_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox107.TextChanged

    End Sub

    Private Sub TextBox27_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox27.TextChanged

    End Sub

    Private Sub TextBox170_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox170.TextChanged

    End Sub

    Private Sub Label31_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label31.Click

    End Sub

    Private Sub TextBox39_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox39.TextChanged

    End Sub

    Private Sub TextBox128_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox128.TextChanged

    End Sub

    Private Sub Label64_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label64.Click

    End Sub

    Private Sub TextBox148_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox148.TextChanged

    End Sub

    Private Sub TextBox158_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox158.TextChanged

    End Sub

    Private Sub Label26_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label26.Click

    End Sub

    Private Sub TextBox178_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox178.TextChanged

    End Sub

    Private Sub TextBox111_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox111.TextChanged

    End Sub

    Private Sub TextBox31_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox31.TextChanged

    End Sub

    Private Sub TextBox32_TextChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox32.TextChanged

    End Sub

    Private Sub TextBox33_TextChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox33.TextChanged

    End Sub

    Private Sub TextBox34_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox34.TextChanged

    End Sub

    Private Sub TextBox35_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox35.TextChanged

    End Sub

    Private Sub TextBox36_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox36.TextChanged

    End Sub

    Private Sub TextBox37_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox37.TextChanged

    End Sub

    Private Sub Label85_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label85.Click

    End Sub

    Private Sub Label48_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label48.Click

    End Sub

    Private Sub TextBox123_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox123.TextChanged

    End Sub

    Private Sub TextBox160_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox160.TextChanged

    End Sub

    Private Sub Label9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label9.Click

    End Sub

    Private Sub TextBox106_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox106.TextChanged

    End Sub

    Private Sub TextBox119_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox119.TextChanged

    End Sub

    Private Sub TextBox129_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox129.TextChanged

    End Sub

    Private Sub TextBox139_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox139.TextChanged

    End Sub

    Private Sub TextBox149_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox149.TextChanged

    End Sub

    Private Sub TextBox159_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox159.TextChanged

    End Sub

    Private Sub Label62_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label62.Click

    End Sub

    Private Sub TextBox179_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox179.TextChanged

    End Sub

    Private Sub TextBox189_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox189.TextChanged

    End Sub

    Private Sub TextBox98_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox98.TextChanged

    End Sub

    Private Sub TextBox99_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox99.TextChanged

    End Sub

    Private Sub TextBox30_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox30.TextChanged

    End Sub

    Private Sub TextBox187_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox187.TextChanged

    End Sub

    Private Sub TextBox90_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox90.TextChanged

    End Sub

    Private Sub TextBox91_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox91.TextChanged

    End Sub

    Private Sub TextBox92_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox92.TextChanged

    End Sub

    Private Sub TextBox93_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox93.TextChanged

    End Sub

    Private Sub TextBox94_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox94.TextChanged

    End Sub

    Private Sub Label8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label8.Click

    End Sub

    Private Sub TextBox96_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox96.TextChanged

    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub TextBox191_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox191.TextChanged

    End Sub

    Private Sub Label43_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label43.Click

    End Sub

    Private Sub Label12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label12.Click

    End Sub

    Private Sub TextBox80_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox80.TextChanged

    End Sub

    Private Sub Label41_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label41.Click

    End Sub

    Private Sub Label53_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label53.Click

    End Sub

    Private Sub TextBox38_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox38.TextChanged

    End Sub

    Private Sub Label67_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Label34_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label34.Click

    End Sub

    Private Sub TextBox48_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox48.TextChanged

    End Sub

    Private Sub TextBox49_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox49.TextChanged

    End Sub

    Private Sub TextBox136_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox136.TextChanged

    End Sub

    Private Sub Label75_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label75.Click

    End Sub

    Private Sub TextBox43_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox43.TextChanged

    End Sub

    Private Sub TextBox182_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox182.TextChanged

    End Sub

    Private Sub Label36_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label36.Click

    End Sub

    Private Sub TextBox40_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox40.TextChanged

    End Sub

    Private Sub TextBox41_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox41.TextChanged

    End Sub

    Private Sub TextBox42_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox42.TextChanged

    End Sub

    Private Sub Label11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label11.Click

    End Sub

    Private Sub TextBox44_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox44.TextChanged

    End Sub

    Private Sub TextBox45_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox45.TextChanged

    End Sub

    Private Sub TextBox46_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox46.TextChanged

    End Sub

    Private Sub TextBox47_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox47.TextChanged

    End Sub

    Private Sub Label37_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label37.Click

    End Sub

    Private Sub TextBox105_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox105.TextChanged

    End Sub

    Private Sub TextBox161_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox161.TextChanged

    End Sub

    Private Sub TextBox76_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox76.TextChanged

    End Sub

    Private Sub TextBox116_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox116.TextChanged

    End Sub

    Private Sub Label59_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label59.Click

    End Sub

    Private Sub TextBox97_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox97.TextChanged

    End Sub

    Private Sub Button14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button14.Click
        Dim frm = Form.ActiveForm
        Using bmp = New Bitmap(frm.Width, frm.Height)
            frm.DrawToBitmap(bmp, New Rectangle(0, 0, bmp.Width, bmp.Height))
            bmp.Save("C:\Users\user\Desktop\Result-Spring-Dale\" & "Roll-no " & Me.TextBox4.Text & ".jpg", System.Drawing.Imaging.ImageFormat.Jpeg)
        End Using
    End Sub

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        TextBox1.Text = Nothing
        TextBox2.Text = Nothing
        TextBox3.Text = Nothing
        TextBox4.Text = Nothing
        TextBox5.Text = Nothing
        TextBox6.Text = Nothing
        TextBox7.Text = Nothing
        TextBox8.Text = Nothing
        TextBox9.Text = Nothing
        TextBox10.Text = Nothing
        TextBox11.Text = Nothing
        TextBox12.Text = Nothing
        TextBox13.Text = Nothing
        TextBox14.Text = Nothing
        TextBox15.Text = Nothing
        TextBox16.Text = Nothing
        TextBox17.Text = Nothing
        TextBox18.Text = Nothing
        TextBox19.Text = Nothing
        TextBox20.Text = Nothing
        TextBox21.Text = Nothing
        TextBox22.Text = Nothing
        TextBox23.Text = Nothing
        TextBox24.Text = Nothing
        TextBox25.Text = Nothing
        TextBox26.Text = Nothing
        TextBox27.Text = Nothing
        TextBox28.Text = Nothing
        TextBox29.Text = Nothing
        TextBox30.Text = Nothing
        TextBox31.Text = Nothing
        TextBox32.Text = Nothing
        TextBox33.Text = Nothing
        TextBox34.Text = Nothing
        TextBox35.Text = Nothing
        TextBox36.Text = Nothing
        TextBox37.Text = Nothing
        TextBox38.Text = Nothing
        TextBox39.Text = Nothing
        TextBox40.Text = Nothing
        TextBox41.Text = Nothing
        TextBox42.Text = Nothing
        TextBox43.Text = Nothing
        TextBox44.Text = Nothing
        TextBox45.Text = Nothing
        TextBox46.Text = Nothing
        TextBox47.Text = Nothing
        TextBox48.Text = Nothing
        TextBox49.Text = Nothing
        TextBox50.Text = Nothing
        TextBox51.Text = Nothing
        TextBox52.Text = Nothing
        TextBox53.Text = Nothing
        TextBox54.Text = Nothing
        TextBox55.Text = Nothing
        TextBox56.Text = Nothing
        TextBox57.Text = Nothing
        TextBox58.Text = Nothing
        TextBox59.Text = Nothing
        TextBox60.Text = Nothing
        TextBox61.Text = Nothing
        TextBox62.Text = Nothing
        TextBox63.Text = Nothing
        TextBox64.Text = Nothing
        TextBox65.Text = Nothing
        TextBox66.Text = Nothing
        TextBox67.Text = Nothing
        TextBox68.Text = Nothing
        TextBox69.Text = Nothing
        TextBox70.Text = Nothing
        TextBox71.Text = Nothing
        TextBox72.Text = Nothing
        TextBox73.Text = Nothing
        TextBox74.Text = Nothing
        TextBox75.Text = Nothing
        TextBox76.Text = Nothing
        TextBox77.Text = Nothing
        TextBox78.Text = Nothing
        TextBox79.Text = Nothing
        TextBox80.Text = Nothing
        TextBox81.Text = Nothing
        TextBox82.Text = Nothing
        TextBox83.Text = Nothing
        TextBox84.Text = Nothing
        TextBox85.Text = Nothing
        TextBox86.Text = Nothing
        TextBox87.Text = Nothing
        TextBox88.Text = Nothing
        TextBox89.Text = Nothing
        TextBox90.Text = Nothing
        TextBox91.Text = Nothing
        TextBox92.Text = Nothing
        TextBox93.Text = Nothing
        TextBox94.Text = Nothing
        TextBox95.Text = Nothing
        TextBox96.Text = Nothing
        TextBox97.Text = Nothing
        TextBox98.Text = Nothing
        TextBox99.Text = Nothing
        TextBox100.Text = Nothing
        TextBox101.Text = Nothing
        TextBox102.Text = Nothing
        TextBox103.Text = Nothing
        TextBox104.Text = Nothing
        TextBox105.Text = Nothing
        TextBox106.Text = Nothing
        TextBox107.Text = Nothing
        TextBox108.Text = Nothing
        TextBox109.Text = Nothing
        TextBox110.Text = Nothing
        TextBox111.Text = Nothing
        TextBox112.Text = Nothing
        TextBox113.Text = Nothing
        TextBox114.Text = Nothing
        TextBox115.Text = Nothing
        TextBox116.Text = Nothing
        TextBox117.Text = Nothing
        TextBox118.Text = Nothing
        TextBox119.Text = Nothing
        TextBox120.Text = Nothing
        TextBox121.Text = Nothing
        TextBox122.Text = Nothing
        TextBox123.Text = Nothing
        TextBox124.Text = Nothing
        TextBox125.Text = Nothing
        TextBox126.Text = Nothing
        TextBox127.Text = Nothing
        TextBox128.Text = Nothing
        TextBox129.Text = Nothing
        TextBox130.Text = Nothing
        TextBox131.Text = Nothing
        TextBox132.Text = Nothing
        TextBox133.Text = Nothing
        TextBox134.Text = Nothing
        TextBox135.Text = Nothing
        TextBox136.Text = Nothing
        TextBox137.Text = Nothing
        TextBox138.Text = Nothing
        TextBox139.Text = Nothing
        TextBox140.Text = Nothing
        TextBox141.Text = Nothing
        TextBox142.Text = Nothing
        TextBox143.Text = Nothing
        TextBox144.Text = Nothing
        TextBox145.Text = Nothing
        TextBox146.Text = Nothing
        TextBox147.Text = Nothing
        TextBox148.Text = Nothing
        TextBox149.Text = Nothing
        TextBox150.Text = Nothing
        TextBox151.Text = Nothing
        TextBox152.Text = Nothing
        TextBox153.Text = Nothing
        TextBox154.Text = Nothing
        TextBox155.Text = Nothing
        TextBox156.Text = Nothing
        TextBox157.Text = Nothing
        TextBox158.Text = Nothing
        TextBox159.Text = Nothing
        TextBox160.Text = Nothing
        TextBox161.Text = Nothing
        TextBox162.Text = Nothing
        TextBox163.Text = Nothing
        TextBox164.Text = Nothing
        TextBox165.Text = Nothing
        TextBox166.Text = Nothing
        TextBox167.Text = Nothing
        TextBox168.Text = Nothing
        TextBox169.Text = Nothing
        TextBox170.Text = Nothing
        TextBox171.Text = Nothing
        TextBox172.Text = Nothing
        TextBox173.Text = Nothing
        TextBox174.Text = Nothing
        TextBox175.Text = Nothing
        TextBox176.Text = Nothing
        TextBox177.Text = Nothing
        TextBox178.Text = Nothing
        TextBox179.Text = Nothing
        TextBox180.Text = Nothing
        TextBox181.Text = Nothing
        TextBox182.Text = Nothing
        TextBox183.Text = Nothing
        TextBox184.Text = Nothing
        TextBox185.Text = Nothing
        TextBox186.Text = Nothing
        TextBox187.Text = Nothing
        TextBox188.Text = Nothing
        TextBox189.Text = Nothing
        TextBox190.Text = Nothing
        TextBox191.Text = Nothing
        TextBox192.Text = Nothing
        TextBox193.Text = Nothing
        TextBox194.Text = Nothing
    End Sub
End Class
