namespace GeniyIdiot.Common
{
    public interface IConvert
    {
        string Serialize<T>(T item);
        T Deserialize<T>(string data);
    }
}
