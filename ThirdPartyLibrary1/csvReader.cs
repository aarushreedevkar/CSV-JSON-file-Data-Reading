namespace ThirdPartyLibrary1
{
    internal class csvReader : IDisposable
    {
        private object reader;
        private object cultureInfo;
        private object invariantculture;

        public csvReader(object reader, object cultureInfo, object invariantculture)
        {
            this.reader = reader;
            this.cultureInfo = cultureInfo;
            this.invariantculture = invariantculture;
        }
    }
}