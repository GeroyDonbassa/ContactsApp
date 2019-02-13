using System;
using System.IO;
using Newtonsoft.Json;

namespace ContactsApp
{
    /// <summary>
    /// Менеджер проекта.
    /// </summary>
    public static class ProjectManager
    {
        /// <summary>
        /// Сериалайзер.
        /// </summary>
        private static readonly JsonSerializer JsonSerializer;

        /// <summary>
        /// Путь к файлу.
        /// </summary>
        private static readonly string PathToFile;

        /// <summary>
        /// Статический конструктор.
        /// </summary>
        static ProjectManager()
        {
            JsonSerializer = JsonSerializer.Create();
            JsonSerializer.Formatting = Formatting.Indented;

            PathToFile = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
                "ContactApp.contacts");
        }

        /// <summary>
        /// Cохраняет проект в файл.
        /// </summary>
        /// <param name="project">Проект.</param>
        public static void SaveToFile(Project project)
        {
            using (var streamWriter = new StreamWriter(PathToFile))
            using (var jsonWriter = new JsonTextWriter(streamWriter))
            {
                JsonSerializer.Serialize(jsonWriter, project);
            }
        }

        /// <summary>
        /// Загружает проект из файла.
        /// </summary>
        /// <returns>Проект.</returns>
        public static Project LoadFromFile()
        {
            if (!File.Exists(PathToFile))
                return null;

            using (var streamReader = new StreamReader(PathToFile))
            using (var jsonReader = new JsonTextReader(streamReader))
            {
                return JsonSerializer.Deserialize<Project>(jsonReader);
            }
        }
    }
}