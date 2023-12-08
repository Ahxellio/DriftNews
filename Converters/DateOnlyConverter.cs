namespace DriftNews.Converters
{
    public static class DateOnlyConverter
    {
        public static DateOnly ToDateOnly(this DateTime datetime)
                => DateOnly.FromDateTime(datetime);
    }
}
