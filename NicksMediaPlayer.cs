using System;
using System.ComponentModel;
using System.Media;
using System.Windows.Forms;

namespace NicksMediaPlayer
{
    public class MediaForm : Form
    {
        [STAThread]

        static void Main() // The Main method is the entry point from where the execution starts. The Main method calls Run to start the application.
        {
            Application.Run(new MediaForm()); // This will start the application. Begins running a standard application message loop on the current thread.
        }

        // These are all the Windows.Forms for the buttons and textbox. These are all classes of windows forms.
        private Label MyLabel;
        private Label MyLabel2;
        private TextBox Textbox;
        private Button openFileButton;
        private Button loadButton;
        private Button playButton;
        private Button playLoopButton;
        private Button stopButton;
        private StatusBar statusBar;
        private Button exitButton;
        private SoundPlayer player; // SoundPlayer class which controls playback of a sound from a .wav file.

        #region Windows Form Designer generated code

        // This is all the Windows.Forms layouts. I messed around to center all my buttons and move them in different locations.
        private void InitializeComponent() // This method is used to initialize the Windows Forms designer. This creates a layout of the application.
        { // These are all controls or instance created for all the labels, buttons, status bar and textbox.
            ComponentResourceManager resources = new ComponentResourceManager(typeof(MediaForm));
            MyLabel = new Label();
            MyLabel2 = new Label();
            Textbox = new TextBox();
            openFileButton = new Button();
            loadButton = new Button();
            playButton = new Button();
            playLoopButton = new Button();
            stopButton = new Button();
            statusBar = new StatusBar();
            exitButton = new Button();
            SuspendLayout(); // Temporarily suspends the layout logic for the control. Another method of System.Windows.Forms namespace.
            // 
            // MyLabel
            // 
            MyLabel.FlatStyle = FlatStyle.Flat; // This will get or set the flat style appearance of the button control.
            MyLabel.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0))); // This is the font of the text used for MyLabel.
            MyLabel.ForeColor = System.Drawing.SystemColors.Desktop; // This is the Color structure that is the color of the desktop.
            MyLabel.Location = new System.Drawing.Point(87, 1); // This places the MyLabel in different locations.
            MyLabel.Size = new System.Drawing.Size(300, 34); // This will change the size of MyLabel.
            MyLabel.Text = "Nick\'s Media Player"; //This is the text property to show the text MyLabel.
            MyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter; // This will align the text to center of the label.
            // 
            // MyLabel2
            // 
            MyLabel2.FlatStyle = FlatStyle.Flat; // This will get or set the flat style appearance of the button control.
            MyLabel2.Font = new System.Drawing.Font("Verdana", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            MyLabel2.ForeColor = System.Drawing.SystemColors.Desktop; // This is the Color structure that is the color of the desktop.
            MyLabel2.Location = new System.Drawing.Point(420, 219); // This places the MyLabel2 in different locations.
            MyLabel2.Size = new System.Drawing.Size(60, 20); // This will change the size of MyLabel2.
            MyLabel2.Text = DateTime.Now.ToShortDateString(); // The ToShortDateString method converts the value of the current DateTime object to its equivalent short date string representation.
            MyLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter; // This will align the text to center of the label.
            // 
            // Textbox
            // 
            Textbox.BackColor = System.Drawing.SystemColors.ControlDarkDark; // This is setting the color for the Backcolor.
            Textbox.BorderStyle = BorderStyle.FixedSingle; // This is the borderstyle property for the textbox.
            Textbox.ForeColor = System.Drawing.SystemColors.Desktop; // This is the Color structure that is the color of the desktop.
            Textbox.Location = new System.Drawing.Point(71, 38); // This places the Textbox in different locations.
            Textbox.Size = new System.Drawing.Size(329, 40); // This will change the size of the Texboxt.
            Textbox.Text = DateTime.Now.ToString("dddd, MMM dd yyyy, hh:mm"); // The ToString method converts the value of the current DateTime object to its equivalent string representation.
            Textbox.TextAlign = HorizontalAlignment.Center; // This will align the text to center of the Textbox.
            // 
            // selectFileButton
            // 
            openFileButton.BackColor = System.Drawing.SystemColors.ControlDarkDark; // This is setting the color for the Backcolor.
            openFileButton.FlatStyle = FlatStyle.Flat; // This will get or set the flat style appearance of the button control.
            openFileButton.Location = new System.Drawing.Point(406, 38); // This places the openFileButton in different locations.
            openFileButton.Size = new System.Drawing.Size(66, 21); // This will change the size of the openFileButton.
            openFileButton.Text = "Open File"; // This will be the text displayed on the button.
            openFileButton.UseVisualStyleBackColor = false; // Gets or sets a value that determines if the background is drawn using visual styles.
            openFileButton.Click += new EventHandler(OpenFileButton);  // Event handler when user clicks the button.
            // 
            // loadButton
            // 
            loadButton.BackColor = System.Drawing.SystemColors.ControlDarkDark; // This is setting the color for the Backcolor.
            loadButton.FlatStyle = FlatStyle.Flat; // This will get or set the flat style appearance of the button control.
            loadButton.Location = new System.Drawing.Point(160, 72); // This places the loadButton in different locations.
            loadButton.Size = new System.Drawing.Size(147, 23); // This will change the size of the loadButton.
            loadButton.Text = "Load"; // This will be the text displayed on the button.
            loadButton.UseVisualStyleBackColor = false; // Gets or sets a value that determines if the background is drawn using visual styles.
            loadButton.Click += new EventHandler(LoadButton); // Event handler when user clicks the button.
            // 
            // playButton
            // 
            playButton.BackColor = System.Drawing.SystemColors.ControlDarkDark; // This is setting the color for the Backcolor.
            playButton.FlatStyle = FlatStyle.Flat; // This will get or set the flat style appearance of the button control.
            playButton.Location = new System.Drawing.Point(160, 101); // This places the playButton in different locations.
            playButton.Size = new System.Drawing.Size(147, 23); // This will change the size of the playButton.
            playButton.Text = "Play"; // This will be the text displayed on the button.
            playButton.UseVisualStyleBackColor = false; // Gets or sets a value that determines if the background is drawn using visual styles.
            playButton.Click += new EventHandler(PlayButton); // Event handler when user clicks the button.
            // 
            // playLoopButton
            // 
            playLoopButton.BackColor = System.Drawing.SystemColors.ControlDarkDark; // This is setting the color for the Backcolor.
            playLoopButton.FlatStyle = FlatStyle.Flat; // This will get or set the flat style appearance of the button control.
            playLoopButton.Location = new System.Drawing.Point(160, 130); // This places the playLoopButton in different locations.
            playLoopButton.Size = new System.Drawing.Size(147, 23); // This will change the size of the playLoopButton.
            playLoopButton.Text = "Play On Repeat"; // This will be the text displayed on the button.
            playLoopButton.UseVisualStyleBackColor = false; // Gets or sets a value that determines if the background is drawn using visual styles.
            playLoopButton.Click += new EventHandler(PlayLoopButton); // Event handler when user clicks the button.
            // 
            // stopButton
            // 
            stopButton.BackColor = System.Drawing.SystemColors.ControlDarkDark; // This is setting the color for the Backcolor.
            stopButton.FlatStyle = FlatStyle.Flat; // This will get or set the flat style appearance of the button control.
            stopButton.Location = new System.Drawing.Point(160, 159); // This places the stopButton in different locations.
            stopButton.Size = new System.Drawing.Size(147, 23); // This will change the size of the stopButton.
            stopButton.Text = "Stop"; // This will be the text displayed on the button.
            stopButton.UseVisualStyleBackColor = false; // Gets or sets a value that determines if the background is drawn using visual styles.
            stopButton.Click += new EventHandler(StopButton); // Event handler when user clicks the button.
            // 
            // statusBar
            // 
            statusBar.Location = new System.Drawing.Point(0, 217); // This places the statusBar in different locations.
            statusBar.Size = new System.Drawing.Size(484, 22); // This will change the size of the statusBar.
            statusBar.SizingGrip = false; // Gets or sets a value indicating whether a sizing handle (grip) is displayed in the lower-right corner of the control.
            // 
            // exitButton
            // 
            exitButton.BackColor = System.Drawing.SystemColors.ControlDarkDark; // This is setting the color for the Backcolor.
            exitButton.FlatStyle = FlatStyle.Flat; // This will get or set the flat style appearance of the button control.
            exitButton.Location = new System.Drawing.Point(160, 188); // This places the exitButton in different locations.
            exitButton.Size = new System.Drawing.Size(147, 23); // This will change the size of the exitButton.
            exitButton.Text = "Exit"; // This will be the text displayed on the button.
            exitButton.UseVisualStyleBackColor = false; // Gets or sets a value that determines if the background is drawn using visual styles.
            exitButton.Click += new EventHandler(ExitButton); // Event handler when user clicks the button.
            // 
            // MediaForm
            // 
            BackColor = System.Drawing.SystemColors.Window; // This is setting the color for the Backcolor.
            ClientSize = new System.Drawing.Size(484, 239); // This will change the size of the Form.
            Controls.Add(MyLabel); // Gets the collection of controls contained with the control.
            Controls.Add(MyLabel2); // Gets the collection of controls contained with the control.
            Controls.Add(Textbox); // Gets the collection of controls contained with the control.
            Controls.Add(openFileButton); // Gets the collection of controls contained with the control.
            Controls.Add(loadButton); // Gets the collection of controls contained with the control.
            Controls.Add(playButton); // Gets the collection of controls contained with the control.
            Controls.Add(playLoopButton); // Gets the collection of controls contained with the control.
            Controls.Add(stopButton); // Gets the collection of controls contained with the control.
            Controls.Add(statusBar); // Gets the collection of controls contained with the control.
            Controls.Add(exitButton); // Gets the collection of controls contained with the control.
            Font = new System.Drawing.Font("Verdana", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))); // This is the font and font size for the text title.
            ForeColor = System.Drawing.SystemColors.ButtonHighlight; // This is the Color structure that is the color of the desktop.
            FormBorderStyle = FormBorderStyle.None; // This is the border style, which is set to none.
            Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            MinimumSize = new System.Drawing.Size(400, 183); // This will change the size of the Form if it is minimized.
            SizeGripStyle = SizeGripStyle.Show; // Gets or sets the style of the size grip to display in the lower-right corner of the form.
            StartPosition = FormStartPosition.CenterScreen; // This places the Form in the center of the screen when open.
            Text = "My Media Player"; // This will be the text displayed on the Form.
            ResumeLayout(false); /* Resumes usual layout logic, optionally forcing an immediate layout of pending layout requests. 
            The SuspendLayout and ResumeLayout methods are used in tandem to suppress multiple Layout events while you adjust multiple attributes of the control. 
            For example, you would typically call the SuspendLayout method, then set the Size, Location, Anchor, or Dock properties of the control, and then call the ResumeLayout method to enable the changes to take effect. 
            When ResumeLayout is called with false, there is a control collection that is looped through and the LayoutEngine calls Layout on each of the controls in the layout. */
            PerformLayout(); // Forces the control to apply layout logic to all its child controls.
        }
        #endregion
        public MediaForm() // Parameterless constructor.
        {
            // This will initialize Forms Designer.
            InitializeComponent();
            // This will initialize the SoundPlayer.
            Player();
            // This will initialize status bar.
            StatusBar();
            // This disables playback funstion until file has been selected ad loaded into the app.
            EnablePlayback(false);
        }
        // This will initialize the SoundPlayer object.
        private void Player()
        {
            // This creates an instance of the SoundPlayer class.
            player = new SoundPlayer();
            // New event handler for the LoadComplete method. Ocurrs when a new .wav has been successfully or unsuccessfully loaded.
            player.LoadCompleted += new AsyncCompletedEventHandler(LoadCompleted);
            // New event handler for the SelectedFile method. This is an event where a new audio source path for the SoundPlayer has been set.
            player.SoundLocationChanged += new EventHandler(SelectedFile);
        }
        // This will initialize status bar and other controls.
        private void StatusBar()
        {
            // This will initialize status bar and other controls. New instance for the StatusBarPanel.
            StatusBarPanel panel = new StatusBarPanel
            {
                BorderStyle = StatusBarPanelBorderStyle.None, // Border style of the StatusBar.
                Text = "Welcome, Please Click The Open File Button.", // Text that shows status when application is ready to load file.
                AutoSize = StatusBarPanelAutoSize.Spring // Autosize property to autosize the StatusBar or set a fixed size.
            };
            statusBar.ShowPanels = true; // Gets or sets a value indicating whether any panels that have been added to the statusbar are displayed. Boolean true if panels are displayed.
            statusBar.Panels.Add(panel); // This adds the panel to the StatusBar.
        }
        // I create the MessageBar method for setting message text in the status bar.
        private void MessageBar(string statusMessage) // This method is created to show status of file in the StatusBar. 
        {
            if (!string.IsNullOrEmpty(statusMessage)) // Indicates whether the specified string is null or an empty string (""). Null forgiving operator.
            {
                statusBar.Panels[0].Text = statusMessage;
            }
        }
        private void EnablePlayback(bool enabled) // This is the EnablePlayback method that will enable the play, playLoop and stop Button once file has been loaded.
        {
            playButton.Enabled = enabled;
            playLoopButton.Enabled = enabled;
            stopButton.Enabled = enabled;
        }
        // The OpenFileButton method is called to openFileButton so the user can click the button and select the music file they want to add in the application.
        // This assumes that the Click event of the Button control is connected to the event handler method defined below.
        // The OpenFileDialog function will take control once the Click event handler is activated through the Button method. This allows user to search for file they want to select.
        private void OpenFileButton(object sender, EventArgs e)
        {
            // The OpenFileDialog represents a common dialog box that allows a user to specify a filename for one or more files to open.
            OpenFileDialog file = new OpenFileDialog
            {
                // Make sure the dialog checks for existence of the selected file.
                CheckFileExists = true, // It sets a value indicating whether the dialog box displays a warning if the user specifies a file name that does not exist.
                Filter = "WAV files (*.wav)|*.wav", // Filter by .wav files only. This determines what types of files are displayed from the OpenFileDialog
                DefaultExt = ".wav" // This specifies the default extension string to use to filter the list of files that are displayed.
            };
            // This activates the file selection dialog.
            if (file.ShowDialog() == DialogResult.OK) // Shows the form as a modal dialog box.
            { // Dialog box is a graphical control element in the form of a small window that communicates information to the user and prompts them for a response.
                // This will get the selected file's path from the dialog. When this method is called, the code following it is not executed until after the dialog box is closed.
                Textbox.Text = file.FileName; // This is a string containing the file name selected in the file dialog box.
                // This will assign the selected file's path to the SoundPlayer object and display the filepath name in the Textbox form.  
                player.SoundLocation = Textbox.Text;
            }
        }
        // Event handler for the SelectedFile method. This will select the file the user has selected.
        private void SelectedFile(object sender, EventArgs e)
        {
            string message = string.Format("Selected File: {0}", player.SoundLocation);
            // Converts the value of objects to strings based on the formats specified and inserts them into another string.
            MessageBar(message);
        }
        // The LoadButton method is called to loadButton so the user can click the button and load the music file in the application.
        // This assumes that the Click event of the Button control is connected to the event handler method defined below.
        // The player.LoadAsync function will control the file once the Click event handler is activated through the Button method.
        private void LoadButton(object sender, EventArgs e)
        {
            EnablePlayback(false);
            try // try will attempt to load file but if there is something wrong with the file an exception will occur. This also stop the other button methods from playing.
            {
                // This will assign the selected file's path to the SoundPlayer object and display the filepath name in the Textbox form.
                player.SoundLocation = Textbox.Text;
                player.LoadAsync();
            }
            catch (Exception exception)
            {
                MessageBar(exception.Message);
            }
        }
        // Event handler for the LoadComplete method. This will inform user that file has been loaded to the application.
        private void LoadCompleted(object sender, AsyncCompletedEventArgs e) // LoadCompleted method used when load is completed.
        { // An instance of the event data class is passed to the event handler for the AsyncCompleted event. the AsyncCompletedEventArgs is required to call the event.
            string message = string.Format("Ready When You Are! {0}", Textbox.Text); // Converts the value of objects to strings based on the formats specified and inserts them into another string.
            MessageBar(message);
            EnablePlayback(true); // Once file is loaded into the app, user will be able to play the file.
        }
        // The PlayButton method is called to playButton so the user can click the button and start playing music file.
        // This assumes that the Click event of the Button control is connected to the event handler method defined below.
        // The player.PlayLooping function will control the file once the Click event handler is activated through the Button method.
        private void PlayButton(object sender, EventArgs e)
        {
            player.Play();
            MessageBar("Playing");
        }
        // The PlayLoopButton method is called to playLoopButton so the user can click the button and start playing music file in a loop.
        // This assumes that the Click event of the Button control is connected to the event handler method defined below.
        // The player.PlayLooping function will control the file once the Click event handler is activated through the Button method.
        private void PlayLoopButton(object sender, EventArgs e)
        {
            player.PlayLooping();
            MessageBar("Play On Repeat");
        }
        // The StopButton method is called to stopButton so the user can click the button to stop music.
        // This assumes that the Click event of the Button control is connected to the event handler method defined below.
        // The player.Stop function will control the file once the Click event handler is activated through the Button method.
        private void StopButton(object sender, EventArgs e)
        {
            player.Stop();
            MessageBar("Stop. Have A Nice Day!");
        }
        // The ExitButton method is called to exitButton so the user can click the button to exit application.
        private void ExitButton(object sender, EventArgs e)
        {
            Application.Exit(); // This will exit or close the application.
        }
    }
}
