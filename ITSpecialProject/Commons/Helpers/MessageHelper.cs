namespace ITSpecialProject.Commons.Helpers
{
    public static class MessageHelper
    {
        public static string DuplicateRecord(string text) =>
            $"{text} is already used.";

        public static string NoInput() =>
            "input required.";

        public static string InvalidTextRange(int minimum, int maximum) =>
            $"input must have a range between {minimum} to {maximum} characters.";

        public static string InvalidValueRange(int minimum, int maximum) =>
            $"value must have a range between {minimum} to {maximum}.";
    }
}
