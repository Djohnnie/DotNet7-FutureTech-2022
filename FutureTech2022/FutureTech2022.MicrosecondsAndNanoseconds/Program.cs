using System.Diagnostics;
using static System.Console;



var sw = Stopwatch.StartNew();
sw.Stop();

WriteLine($"{sw.Elapsed.TotalMilliseconds} ms");
WriteLine($"{sw.Elapsed.TotalMicroseconds} µs");
WriteLine($"{sw.Elapsed.TotalNanoseconds} ns");


var ts = new TimeSpan(0, 0, 0, 0, 0, 1);
DateTime.Now.AddMicroseconds(1);