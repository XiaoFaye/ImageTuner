namespace ImageTuner;

public partial class MainForm : Form
{
    public MainForm()
    {
        InitializeComponent();
    }

    private bool IsRunning = false;
    private bool IgnoreDateCheck = false;
    private bool ReplaceOriginalFile = true;
    private bool ExitAfterProcessing = true;

    private void MainForm_Load(object sender, EventArgs e)
    {
        lblFolder.Text = Environment.CurrentDirectory;
    }

    private void ReloadFlags()
    {
        IgnoreDateCheck = chkIgonreDateCheck.Checked;
        ReplaceOriginalFile = chkRemoveOriginalFile.Checked;
        ExitAfterProcessing = chkExitApp.Checked;
    }

    private void ChangeControlStatus(bool status)
    {
        numJPGQuality.Enabled = status;
        numSizePercentage.Enabled = status;
        numParallelCount.Enabled = status;

        chkIgonreDateCheck.Enabled = status;
        chkExitApp.Enabled = status;
        chkRemoveOriginalFile.Enabled = status;

        btnResaveImage.Enabled = status;
        btnResaveAllImage.Enabled = status;
        btnResizeImage.Enabled = status;
        btnResizeAllImage.Enabled = status;

        btnClearLogging.Enabled = status;
    }

    List<Task> ResizeImage2JPGFolder(string path, bool recursive = false)
    {
        var tasks = new List<Task>();

        if (recursive)
        {
            foreach (var d in Directory.GetDirectories(path))
                tasks.AddRange(ResizeImage2JPGFolder(d, recursive));
        }

        foreach (var f in Directory.GetFiles(path, "*.*").Where(s => s.EndsWith(".jpg", StringComparison.InvariantCultureIgnoreCase) || 
                                                                     s.EndsWith(".png", StringComparison.InvariantCultureIgnoreCase) || 
                                                                     s.EndsWith(".bmp", StringComparison.InvariantCultureIgnoreCase)))
        {
            tasks.Add(new Task(() =>
            {
                lstLogging.Items.Add($"Processing Resize {Path.GetFileName(f)}...");

                try
                {
                    ImageExtensions.ResizeImage2JPG(f, (float)numSizePercentage.Value / 100, (long)numJPGQuality.Value, ReplaceOriginalFile);
                }
                catch (Exception ex)
                {
                    lstLogging.Items.Add($"Processing Resize {Path.GetFileName(f)} Error: {ex.Message}");
                }
            }));
        }

        return tasks;
    }

    List<Task> ResaveImage2JPGFolder(string path, bool recursive = false)
    {
        var tasks = new List<Task>();

        if (recursive)
        {
            foreach (var d in Directory.GetDirectories(path))
                tasks.AddRange(ResaveImage2JPGFolder(d, recursive));
        }

        foreach (var f in Directory.GetFiles(path, "*.*").Where(s => s.EndsWith(".jpg", StringComparison.InvariantCultureIgnoreCase) ||
                                                                     s.EndsWith(".png", StringComparison.InvariantCultureIgnoreCase) ||
                                                                     s.EndsWith(".bmp", StringComparison.InvariantCultureIgnoreCase)))
        {
            tasks.Add(new Task(() =>
            {
                lstLogging.Items.Add($"Processing Resave {Path.GetFileName(f)}...");

                try
                {
                    ImageExtensions.ResaveImage2JPG(f, (long)numJPGQuality.Value, IgnoreDateCheck, ReplaceOriginalFile);
                }
                catch (Exception ex)
                {
                    lstLogging.Items.Add($"Processing Resave {Path.GetFileName(f)} Error: {ex.Message}");
                }
            }));
        }

        return tasks;
    }

    private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
    {
        e.Cancel = IsRunning;
    }

    private void btnClearLogging_Click(object sender, EventArgs e)
    {
        lstLogging.Items.Clear();
    }

    private async void btnResaveImage_Click(object sender, EventArgs e)
    {
        ReloadFlags();
        ChangeControlStatus(false);
        IsRunning = true;

        var tasks = ResaveImage2JPGFolder(Environment.CurrentDirectory);
        await tasks.RunParallelAsync(Convert.ToInt16(numParallelCount.Value));

        IsRunning = false;
        ChangeControlStatus(true);

        if (ExitAfterProcessing)
            Application.Exit();
        else
            MessageBox.Show("Image Processing Done!", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    private async void btnResaveAllImage_Click(object sender, EventArgs e)
    {
        ReloadFlags();
        ChangeControlStatus(false);
        IsRunning = true;

        var tasks = ResaveImage2JPGFolder(Environment.CurrentDirectory, true);
        await tasks.RunParallelAsync(Convert.ToInt16(numParallelCount.Value));

        IsRunning = false;
        ChangeControlStatus(true);

        if (ExitAfterProcessing)
            Application.Exit();
        else
            MessageBox.Show("Image Processing Done!", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    private async void btnResizeImage_Click(object sender, EventArgs e)
    {
        ReloadFlags();
        ChangeControlStatus(false);
        IsRunning = true;

        var tasks = ResizeImage2JPGFolder(Environment.CurrentDirectory);
        await tasks.RunParallelAsync(Convert.ToInt16(numParallelCount.Value));

        IsRunning = false;
        ChangeControlStatus(true);

        if (ExitAfterProcessing)
            Application.Exit();
        else
            MessageBox.Show("Image Processing Done!", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    private async void btnResizeAllImage_Click(object sender, EventArgs e)
    {
        ReloadFlags();
        ChangeControlStatus(false);
        IsRunning = true;

        var tasks = ResizeImage2JPGFolder(Environment.CurrentDirectory, true);
        await tasks.RunParallelAsync(Convert.ToInt16(numParallelCount.Value));

        IsRunning = false;
        ChangeControlStatus(true);

        if (ExitAfterProcessing)
            Application.Exit();
        else
            MessageBox.Show("Image Processing Done!", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
    }
}
