namespace ProjectAnimes.Domain.Exceptions
{
    public class DomainException : Exception
    {
        private List<string> _errors;
        public IReadOnlyCollection<string> Errors { get => _errors; }

        public DomainException(string message, List<string> errors) : base(message)
        {
            _errors = errors;
        }

        public DomainException(string message, List<string> errors, Exception innerException) : base(message, innerException)
        {
            _errors = errors;
        }
    }
}
