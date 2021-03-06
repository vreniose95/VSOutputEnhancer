namespace Balakin.VSOutputEnhancer.Logic.Events
{
    public class SpanParsedEvent<TParsedData> : IEvent
    {
        public TParsedData ParsedData { get; }

        public SpanParsedEvent(TParsedData parsedData)
        {
            ParsedData = parsedData;
        }
    }
}