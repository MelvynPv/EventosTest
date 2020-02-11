namespace Curso2_BuenasPracticas.Services.Interfaces
{
    public interface IFileReaderEvent
    {
        /// <summary>
        /// Lee el archivo y devuelve un resultado en formato cadena.
        /// </summary>
        /// <returns></returns>
        string ReadFile(string filePath = null);
    }
}
