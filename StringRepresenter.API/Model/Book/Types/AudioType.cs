namespace StringRepresenter.API.Model.Book.Types
{
    public class AudioType : BookType
    {
        public string PerformedBy { get; set; }
        public string PerformanceType { get; set; }
        public string Storage { get; set; }
        public string Format { get; set; }
        public string RecordingLength { get; set; }

        public AudioType(string nameOfType, string performedBy, string perfomanceType, string storage, string format, string recordingLength)
            : base(nameOfType)
        {
			PerformedBy = performedBy;
            PerformanceType = perfomanceType;
            Storage = storage;
            Format = format;
            RecordingLength = recordingLength;
        }
    }
}
