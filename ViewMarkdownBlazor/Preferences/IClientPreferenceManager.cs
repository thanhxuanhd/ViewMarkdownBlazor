using MudBlazor;

namespace ViewMarkdownBlazor.Preferences;
public interface IClientPreferenceManager
{
    Task<MudTheme> GetCurrentThemeAsync();

    Task<bool> ToggleDarkModeAsync();
}