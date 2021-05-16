using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using UnityCommons;

namespace Utils {
    public partial class Benchmark {
        public static void Run(string name, Action action, int runs = 8, int warmupRuns = 4) {
            Debug.Assert(action != null);
            Debug.Assert(name != null);
            Console.WriteLine($"RUNNING BENCHMARK [{name}]");
            if (warmupRuns <= 0) warmupRuns = 1;
            if (runs <= 0) runs = 1;
            Console.WriteLine("Running warm-up");
            DoWarmup(warmupRuns);
            Console.WriteLine("Running benchmark");
            var sw = new Stopwatch();
            var sum = TimeSpan.Zero;
            for (var i = 0; i < runs; i++) {
                sw.Restart();
                action();
                var elapsed = sw.Elapsed;
                sum += elapsed;
                Console.WriteLine($"Run {i} => {elapsed.TotalMilliseconds} ms");
            }

            Console.WriteLine($"Average => {(sum / runs).TotalMilliseconds} ms\n");
        }

        private static void DoWarmup(int warmupRuns) {
            for (var i = 0; i < warmupRuns; i++) {
                DoWarmupRun();
            }
        }

        private static void DoWarmupRun() {
            var list = new List<int>(Enumerable.Range(0, 1_000_000));
            Shuffle(list);
            list.Sort();
            Shuffle(list);
            list.Sort();
        }

        private static void Shuffle<T>(IList<T> list) {
            var n = list.Count;  
            while (n > 1) {  
                n--;  
                var k = Rand.Range(n + 1);  
                var value = list[k];  
                list[k] = list[n];  
                list[n] = value;  
            }  
        }
    }

    public partial class Benchmark : IDisposable {
        private readonly Stopwatch stopwatch;
        private readonly string name;
        public Benchmark(string name) {
            Debug.Assert(name != null);
            this.name = name;
            stopwatch = new Stopwatch();
            stopwatch.Restart();
        }
        
        ~Benchmark() {Dispose();}

        public void Dispose() {
            Console.WriteLine($"Benchmark [{name}] => {stopwatch.Elapsed.TotalMilliseconds} ms");
        }
    }
}