Public Class Form2
    Structure scores
        Dim username As String
        Dim userscore As Integer
    End Structure
    Dim data(5) As scores


    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim place As Integer
        Label1.Parent = PictureBox1
        PictureBox1.ImageLocation = "D:\Adv H Comp\Top Trumps\giphy.gif"
        ListBox1.Parent = PictureBox1

        Dim fileL As String
        fileL = "D:\Adv H Comp\Top Trumps\leaderboard.txt"
        Dim objreader As New System.IO.StreamReader(fileL)

        For counter = 0 To 4
            place = counter + 1
            data(counter).username = objreader.ReadLine
            data(counter).userscore = objreader.ReadLine
            ListBox1.Items.Add(place & vbTab & data(counter).username & vbTab & data(counter).userscore)
            ListBox1.Items.Add("")
            ListBox1.Items.Add("")

        Next


    End Sub
End Class