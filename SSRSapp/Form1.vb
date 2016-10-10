Imports System.IO

Public Class Form1
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim Write As System.IO.StreamWriter = Nothing

        Try
            Write = New System.IO.StreamWriter("C:\SSRS\" + hearing.Text + "_" + reporter.Text)

            Write.WriteLine("Hearing Date: " + hearing.Text + "
                                Reporter: " + reporter.Text + "
                                Judge: " + judge.Text + "
                                Location: " + location.Text)
            Write.WriteLine("Petitioner: " + pet.Text + "
                                Respondent: " + res.Text)
            Write.WriteLine("Pet. Firm : " + petFirm.Text + "
                                Res. Firm: " + resFirm.Text)
            Write.WriteLine("Pet. Atty. : " + petAtty.Text + "
                                Res. Atty: " + resAtty.Text)
            Write.WriteLine("Ordered : " + ComboBox2.Text + "
                                Ordered: " + ComboBox3.Text)
            Write.WriteLine("CP #'s : " + cpNumber.Text + "
                                Charge To: " + chargeTo.Text)
            Write.WriteLine("SS #: " + SocialSec.Text + "
                                Est. Pgs: " + EstPgs.Text)
            Write.WriteLine("Ins. Co. : " + InsCo.Text + "
                                Fee $: " + Fee.Text)
            Write.WriteLine("Ins. Co. Address : " + InsCoAdd.Text)
            Write.WriteLine("Ins Co. #'s: " + InsCoNum.Text + "
                                Adjuster: " + Adjuster.Text)
            Write.WriteLine("Special Instruxctions: " + specialIns.Text)
        Finally



            If Write IsNot Nothing Then

                Write.Close()



            End If

        End Try






    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim newform As New Form1
        newform.Show()
        Me.Hide()

    End Sub
End Class
