namespace Task_1
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Text.Encodings.Web;
    using System.Text.Json;
    using System.Text.Json.Nodes;
    using System.Text.RegularExpressions;
    using System.Threading.Tasks;
    using Task_1.Library;

    internal static class Parser
    {
        private static readonly JsonSerializerOptions _serializaitionOptions = new JsonSerializerOptions()
        {
            AllowTrailingCommas = false, // не добавлять запятую в конце
            WriteIndented = true, // //добавляем пробелы для красоты
            Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping, // не экранируем символы в строках
        };

        public static IEnumerable<Autor> AutorsParse(string data)
        {
            List<Autor> autors = new List<Autor>();

            autors = JsonSerializer.Deserialize<List<Autor>>(data);

            return autors;
        }

        internal static string GetAutorJSON(Autor autor)
        {
            return JsonSerializer.Serialize<Autor>(autor, _serializaitionOptions);
        }
    }
}
