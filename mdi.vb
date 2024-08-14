Imports System.Data.OleDb
Public Class mdi
    Private Sub mdi_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub EXITToolStripMenuItem_Click(sender As Object, e As EventArgs)
        home.Show()
        Me.Hide()
    End Sub

    Private Sub RegisterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegisterToolStripMenuItem.Click

    End Sub

    Private Sub ViewAllRegistrationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewAllRegistrationToolStripMenuItem.Click
        view.Show()
    End Sub

    Private Sub RegisterYourselfToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegisterYourselfToolStripMenuItem.Click
        registration.Show()
    End Sub

    Private Sub ModifyRegistrationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ModifyRegistrationToolStripMenuItem.Click
        modifyed.Show()
    End Sub

    Private Sub CancelYourRegistrationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CancelYourRegistrationToolStripMenuItem.Click
        delete.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        '  viewall.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub GiveFeedbackToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GiveFeedbackToolStripMenuItem.Click
        feedb.Show()
    End Sub

    Private Sub CarInsurenceToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub INSURENCEToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles INSURENCEToolStripMenuItem.Click
        ' insu.Show()
    End Sub

    Private Sub ViewPolicyDetailToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewPolicyDetailToolStripMenuItem.Click
        vinsu.Show()
    End Sub

    Private Sub InsurencePolicyToolStripMenuItem_Click(sender As Object, e As EventArgs)
        'insu.Show()
    End Sub

    Private Sub InsurenceToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles InsurenceToolStripMenuItem1.Click
        ipd.Show()
    End Sub

    Private Sub PremiumDetailToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PremiumDetailToolStripMenuItem.Click
        ppd.Show()
    End Sub

    Private Sub ShowAllFeedbackToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ShowAllFeedbackToolStripMenuItem.Click
        sfeed.Show()
    End Sub

    Private Sub ContactUsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ContactUsToolStripMenuItem.Click
        Form3.Show()
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        insu.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        insu1.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        insu2.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        insu3.Show()
    End Sub

    Private Sub LoginToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoginToolStripMenuItem.Click
        home.Show()
        Me.Hide()
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        login.Show()
        Me.Hide()
    End Sub

    Private Sub ExitXToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitXToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub OurBussinessToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OurBussinessToolStripMenuItem.Click
        obuss.Show()
    End Sub

    Private Sub ViewAllRegistrationToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ViewAllRegistrationToolStripMenuItem1.Click
        viewall.Show()
    End Sub

    Private Sub FileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FileToolStripMenuItem.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub InsuredPaymentDetailToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InsuredPaymentDetailToolStripMenuItem.Click
        iad.Show()
    End Sub
End Class

