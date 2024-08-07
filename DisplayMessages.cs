namespace paradigm_shift_csharp
{
    internal static class DisplayMessages
    {
        private static ILogger logger = new ConsoleLogger();
        private static readonly List<List<string>> messages = new List<List<string>>
{
 new List<string> { "OK.", "OK." },
 new List<string> { "WARNING: Parameter is in border range.", "WARNUNG: Parameter liegt im Grenzbereich." },
 new List<string> { "ERROR: Not in Range! Please check.", "FEHLER: Nicht in Reichweite! Überprüfen Sie bitte." }
};

        public static void PrintOkMessage(string valueType, LanguageOption languageOption)
{
    logger.Info($"{valueType} {messages[0][(int)languageOption]}");
}

public static void PrintWarnMessage(string valueType, LanguageOption languageOption)
{
    logger.Info($"{valueType} {messages[1][(int)languageOption]}");
}

public static void PrintErrorMessage(string valueType, LanguageOption languageOption)
{
    logger.Info($"{valueType} {messages[2][(int)languageOption]}");
}
    }
}
