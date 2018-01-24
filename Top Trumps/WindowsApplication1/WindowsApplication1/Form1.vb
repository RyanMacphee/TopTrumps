'Ryan MacPhee
'Top Trumps
'


Public Class Form1
    'Declare Variables
    Dim username(5) As String
    Dim randomvalue As Integer = 0
    Dim randomvalue2 As Integer = 0
    Dim score As Integer = 0
    Dim hints As Integer = 3
    Dim user As System.Windows.Forms.DialogResult
    Dim cards As Integer = 3
    Dim lifes As Integer = 3

    'This record structure is contains all the variables for the cards
    Structure Card
        Dim Id As Integer
        Dim Name As String
        Dim speed As Single
        Dim size As Single
        Dim lifespan As Integer
        Dim weight As Single
        Dim filepath As String
    End Structure
    Structure scores
        Dim username As String
        Dim userscore As Integer
    End Structure

    Dim Animal(20) As Card
    Dim sorted(5) As scores
    Dim unsorted(5) As scores
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles StartButton.Click
        'Used to hide/show buttons from user.
        StartButton.Visible = False
        hintButton.Visible = True
        Button_Card.Visible = True

        'Intiates sub routines 
        input(Animal)
        RandomCard(randomvalue, randomvalue2)



    End Sub
    Sub input(animal() As Card)


        Dim filestring As String
        'filestring = "E:\Adv H Comp\Top Trumps\Excel\AnimalsE.csv"
        filestring = "D:\Adv H Comp\Top Trumps\Excel\AnimalsD.csv"
        For counter = 1 To 20
            'Intiates objreader
            Using Myreader As New Microsoft.VisualBasic.FileIO.TextFieldParser(filestring)
                Myreader.TextFieldType = FileIO.FieldType.Delimited
                Myreader.SetDelimiters(",")
                Dim row As String()

                'Used to read in lines of code
                While Not Myreader.EndOfData
                    row = Myreader.ReadFields()
                    animal(counter).Id = row(0) 'sets this collum in the csv as id
                    animal(counter).Name = row(1) 'sets this collum in the csv as name
                    animal(counter).speed = row(2) 'sets this collum in the csv as speed
                    animal(counter).size = row(3) 'sets this collum in the csv as size
                    animal(counter).lifespan = row(4) 'sets this collum in the csv as lifespan
                    animal(counter).weight = row(5) 'sets this collum in the csv as weight
                    animal(counter).filepath = row(6) 'sets this collum in the csv as filepath
                    counter = counter + 1
                End While
            End Using
        Next
    End Sub

    Sub RandomCard(ByRef randomvalue, ByRef randomvalue2)


        'Changes the visabilty of labels
        Speed1.Visible = True
        Size1.Visible = True
        Lifespan1.Visible = True
        Weight1.Visible = True
        Speed2.Visible = True
        Size2.Visible = True
        Lifespan2.Visible = True
        Weight2.Visible = True

        'Clears listboxes
        ListBoxName1.Items.Clear()
        ListBoxName2.Items.Clear()

        'Creates Random Values
        Randomize()
        Do
            randomvalue = Int(20 * Rnd() + 1)
            randomvalue2 = Int(20 * Rnd() + 1)
        Loop Until randomvalue <> randomvalue2

        'Cards Images
        picDisplay.ImageLocation = Animal(randomvalue).filepath
        picDisplay2.ImageLocation = Animal(randomvalue2).filepath


        'Card Names
        ListBoxName1.Items.Add(Animal(randomvalue).Name)
        ListBoxName2.Items.Add(Animal(randomvalue2).Name)

        'Card's Attributes
        SpeedAI.Text = Animal(randomvalue2).speed
        SizeAI.Text = Animal(randomvalue2).size
        LifespanAI.Text = Animal(randomvalue2).lifespan
        WeightAI.Text = Animal(randomvalue2).weight







    End Sub
    'Quit Button
    Private Sub Qbutton_Click(sender As Object, e As EventArgs) Handles Qbutton.Click
        Dim ExitYN As System.Windows.Forms.DialogResult
        ExitYN = MsgBox("Do you really want to exit?", MsgBoxStyle.YesNo + MsgBoxStyle.Critical, "Exit")
        If ExitYN = MsgBoxResult.Yes Then
            Close()
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Everything in this subroutine starts when the form loads.

        'Changes the transparency of labels
        MenuStrip1.Parent = PictureBox3
        Ibutton.Parent = PictureBox3
        LabelScore.Parent = PictureBox3
        Label6.Parent = PictureBox3
        StartButton.Parent = PictureBox3
        Qbutton.Parent = PictureBox3
        Button_Card.Parent = PictureBox3
        hintButton.Parent = PictureBox3
        lbl_lifesvalue.Parent = PictureBox3
        lbl_lifes.Parent = PictureBox3


        'Filepaths for .gif and music
        PictureBox3.ImageLocation = "D:\Adv H Comp\Top Trumps\giphy.gif"
        My.Computer.Audio.Play("D:\Adv H Comp\Top Trumps\music.wav",
        AudioPlayMode.Background)


        'Changes the visability of labels 
        hintButton.Visible = False
        Speed1.Visible = False
        Size1.Visible = False
        Lifespan1.Visible = False
        Weight1.Visible = False
        Speed2.Visible = False
        Size2.Visible = False
        Lifespan2.Visible = False
        Weight2.Visible = False
        Button_Card.Visible = False


        user = MsgBox("Would you like Instructions?", MsgBoxStyle.YesNo, "Instuctions")
        If user = MsgBoxResult.Yes Then
            instructions()
        End If


    End Sub

    Sub instructions()
        'Message boxes are used to display the instructions.
        MsgBox("Press start to begin playing", MsgBoxStyle.Information, "Instructions")
        MsgBox("You are the card on the left and your goal is to select a bigger value than the one on the right.", MsgBoxStyle.Information, "Instructions")
        MsgBox("You click on attribute you would like to compare", MsgBoxStyle.Information, "Instructions")
        MsgBox("You can recieve hints from the hint button, when prompted to enter a value you must enter the 1 digit number which is attached to the attribute", MsgBoxStyle.Information, "Instructions")
        MsgBox("You can recieve cards from the card button", MsgBoxStyle.Information, "Information")
        MsgBox("When you are incorrect you will be asked if you would like to add your name to the database.", MsgBoxStyle.Information, "Instructions")

    End Sub
    Private Sub Speed1_Click(sender As Object, e As EventArgs) Handles Speed1.Click

        'Compares the chosen attribute
        If Animal(randomvalue).speed >= Animal(randomvalue2).speed Then
            score = score + 1
            LabelScore.Text = score
            RandomCard(randomvalue, randomvalue2)
        Else
            MsgBox("Wrong, The speed of the " & Animal(randomvalue).Name & " is " & Animal(randomvalue).speed & " Miles per Hour")
            lifes = lifes - 1
            lbl_lifesvalue.Text = lifes
            checklifes()
            RandomCard(randomvalue, randomvalue2)

        End If

    End Sub

    Private Sub Size1_Click(sender As Object, e As EventArgs) Handles Size1.Click

        'Compares the chosen attribute
        If Animal(randomvalue).size >= Animal(randomvalue2).size Then
            score = score + 1
            LabelScore.Text = score
            RandomCard(randomvalue, randomvalue2)
        Else
            MsgBox("Wrong, The size of the " & Animal(randomvalue).Name & " is " & Animal(randomvalue).size & " Meters")
            lifes = lifes - 1
            lbl_lifesvalue.Text = lifes
            checklifes()
            RandomCard(randomvalue, randomvalue2)
        End If
    End Sub

    Private Sub Lifespan1_Click(sender As Object, e As EventArgs) Handles Lifespan1.Click

        'Compares the chosen attribute
        If Animal(randomvalue).lifespan >= Animal(randomvalue2).lifespan Then
            score = score + 1
            LabelScore.Text = score
            RandomCard(randomvalue, randomvalue2)
        Else
            MsgBox("Wrong, The lifespan of the " & Animal(randomvalue).Name & " is " & Animal(randomvalue).lifespan & " Years")
            lifes = lifes - 1
            lbl_lifesvalue.Text = lifes
            checklifes()
            RandomCard(randomvalue, randomvalue2)
        End If
    End Sub

    Private Sub Weight1_Click(sender As Object, e As EventArgs) Handles Weight1.Click

        'Compares the chosen attribute
        If Animal(randomvalue).weight >= Animal(randomvalue2).weight Then
            score = score + 1
            LabelScore.Text = score
            RandomCard(randomvalue, randomvalue2)
        Else
            MsgBox("Wrong, The Weight of the " & Animal(randomvalue).Name & " is " & Animal(randomvalue).weight & " Kilograms")
            lifes = lifes - 1
            lbl_lifesvalue.Text = lifes
            checklifes()
            RandomCard(randomvalue, randomvalue2)
        End If
    End Sub
    Sub leaderboard(unsorted() As scores, sorted() As scores)

        'Gets the username from the username and checks that it is limited to 5 characters.
        unsorted(5).username = InputBox("Please enter your username", "Input")
        Do While unsorted(5).username.Length > 5
            MsgBox("Limited to 5 characters", MsgBoxStyle.Exclamation, "Excepted Value")
            unsorted(5).username = InputBox("Please enter your username", "Input")
        Loop

        'Assigns the score from the game as the user's score.
        unsorted(5).userscore = score

        'Intiates the 
        Dim fileL As String
        fileL = "D:\Adv H Comp\Top Trumps\leaderboard.txt"
        Dim objreader As New System.IO.StreamReader(fileL)


        For counter = 0 To 4
            unsorted(counter).username = objreader.ReadLine
            unsorted(counter).userscore = objreader.ReadLine
        Next

        objreader.Close()

        Dim dummy As Integer
        dummy = 0 'sets dummy equal to 0
        Dim maxvalue As Integer

        'selection sort
        For counter = 0 To 5
            maxvalue = counter
            For index = 0 To 5
                If unsorted(index).userscore > unsorted(maxvalue).userscore Then
                    maxvalue = index
                End If
            Next

            ' Sets the values in the right positions
            sorted(counter).username = unsorted(maxvalue).username
            sorted(counter).userscore = unsorted(maxvalue).userscore
            unsorted(maxvalue).userscore = dummy
        Next


        'Writes values to file.
        Dim objWriter As New System.IO.StreamWriter(fileL)
        For counter = 0 To 4
            objWriter.WriteLine(sorted(counter).username)
            objWriter.WriteLine(sorted(counter).userscore)

        Next
        objWriter.Close()

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles hintButton.Click
        Dim Help As Integer




        'Asks the user if they would like to use a hint
        If hints = 0 Then
            MsgBox("You have no hints left.", "Hint")
            Exit Sub
        End If


        user = MsgBox("Would you like to use a hint. You have " & hints & " left ", MsgBoxStyle.YesNo, "Hint")
        If user = MsgBoxResult.Yes Then

        Else
            Exit Sub
        End If


        'Validates if there is hints left
        If hints > 0 Then
            hints = hints - 1

            'loop validation
            Do
                Help = InputBox("1:Speed    2:Size      3:Lifespan      4:Weight", "Hint")
            Loop Until Help > 0 And Help < 5

            'Case if statement used show the hint
            If Help = 1 Then
                MsgBox("The speed of the " & Animal(randomvalue).Name & " is " & Animal(randomvalue).speed & " Miles per hour.")
            ElseIf Help = 2 Then
                MsgBox("The size of the " & Animal(randomvalue).Name & " is " & Animal(randomvalue).size & " Meters.")
            ElseIf Help = 3 Then
                MsgBox("The lifespan of the " & Animal(randomvalue).Name & " is " & Animal(randomvalue).lifespan & " Years.")
            ElseIf Help = 4 Then
                MsgBox("The weight of your animal is " & Animal(randomvalue).Name & " is " & Animal(randomvalue).weight & " Kilograms.")
            End If
        Else
            MsgBox("You have no hints left", "Hint")

        End If
    End Sub
    Private Sub Ibutton_Click(sender As Object, e As EventArgs) Handles Ibutton.Click
        'Intiates instructions sub routine.
        instructions()
    End Sub
    Private Sub ShowLeaderboardToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ShowLeaderboardToolStripMenuItem.Click
        Form2.Show()
    End Sub
    Private Sub Button_Card_Click(sender As Object, e As EventArgs) Handles Button_Card.Click
        'validates to check if any cards are left.
        If cards = 0 Then
            MsgBox("You have no new cards left.", "New Cards")
            Exit Sub
        End If

        ' Gives the user a new card upon their request
        user = MsgBox("Would you like a new card. You have " & cards & " left ", MsgBoxStyle.YesNo, "New Cards")
        If user = MsgBoxResult.Yes Then
            If cards > 0 Then
                cards = cards - 1
                ListBoxName1.Items.Clear()
                Do
                    randomvalue = Int(20 * Rnd() + 1)
                Loop Until randomvalue <> randomvalue2


                picDisplay.ImageLocation = Animal(randomvalue).filepath
                ListBoxName1.Items.Add(Animal(randomvalue).Name)

            Else
                MsgBox("You have no new cards left", "New Cards")
            End If
        Else
            Exit Sub
        End If
    End Sub
    Sub checklifes()
        'Validates number of lifes if lifes is 0 then user has choice to add name to leaderboard.
        If lifes = 0 Then
            user = MsgBox("Would you like to add your name to the Leaderboard?", MsgBoxStyle.YesNo, "Leaderboard")

            If user = MsgBoxResult.Yes Then
                leaderboard(unsorted, sorted)
            End If
            Close()
        End If
    End Sub
End Class
