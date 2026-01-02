namespace WifiSurvey;

/// <summary>
/// WiFi Survey Tool - Site survey and heatmap generation
/// CosmicBytez IT Operations
/// </summary>
static class Program
{
    [STAThread]
    static void Main()
    {
        ApplicationConfiguration.Initialize();
        Application.Run(new MainForm());
    }
}
