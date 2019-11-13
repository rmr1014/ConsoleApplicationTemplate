namespace ConsoleApplicationBase
{
    public static class ConsoleFormatting
    {
        public static string Indent(int count)
        {
            return "".PadLeft(count);
        }
    }
}
