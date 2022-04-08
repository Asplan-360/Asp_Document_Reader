namespace Asp_Document_Reader.Shared;

internal class ServiceResponse<T>
{

    public T? DataT { get; set; }
    public bool Success { get; set; } = true;
    public string Message { get; set; } = string.Empty;
}
