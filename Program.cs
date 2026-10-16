// Console.WriteLine($"Логических процессоров (ядер):{Environment.ProcessorCount}");

// Console.WriteLine("Нагружаем процессор... Остановите программу (Ctrl+C), когда посмотрите на графики.");

// long counter = 0;
// while (true) {
//     counter++;
// }

using System.Diagnostics;

#if DEBUG
Console.WriteLine("Режим сборки: DEBUG");
#else
Console.WriteLine("Режим сборки: RELEASE");
#endif

long counter = 0;
var stopwatch = Stopwatch.StartNew();

while (stopwatch.ElapsedMilliseconds < 1000) {
    counter++;
}

Console.WriteLine($"Итераций примерно за 1 секунду: {counter:N0}");
