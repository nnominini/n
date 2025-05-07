public static class FormSelectionTracker
{
    public static string Selection7 = "";
    public static string Selection8 = "";
    public static string Selection9 = "";

    public static void Reset()
    {
        Selection7 = "";
        Selection8 = "";
        Selection9 = "";
    }

    public static bool IsAllSelected()
    {
        return !string.IsNullOrEmpty(Selection7) &&
               !string.IsNullOrEmpty(Selection8) &&
               !string.IsNullOrEmpty(Selection9);
    }
}
