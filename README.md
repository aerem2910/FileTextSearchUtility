**Программа является утилитой для поиска файлов и текста в файлах.**
1. **FileSearchUtility (Task2):**
   - **`SearchFiles(string path, string extension)`:** Этот метод рекурсивно ищет файлы в указанном каталоге и подкаталогах, соответствующие заданному расширению. Возвращает список полных путей к найденным файлам.

2. **TextSearchUtility (Task3):**
   - **`SearchAndPrint(string filePath, string searchText)`:** Этот метод читает содержимое файла по указанному пути и выводит на экран строки, содержащие указанный текст.
   - **`ReadFrom(string filePath)`:** Читает строки из файла по указанному пути и возвращает их в виде списка.
   - **`Filter(string searchText, List<string> text)`:** Фильтрует строки, содержащие указанный текст, и возвращает измененные строки (в верхнем регистре) в виде списка.

3. **Program (FileTextSearchUtility):**
   - **`Main(string[] args)`:** Главный метод программы, который вызывает другие методы. Если передано менее трех аргументов, выводит сообщение об использовании. Иначе вызывает метод `SearchFiles` из `Task2` для поиска файлов с заданным расширением в указанном каталоге. Затем для каждого найденного файла вызывает метод `SearchAndPrint` из `Task3`, чтобы вывести строки, содержащие указанный текст.

