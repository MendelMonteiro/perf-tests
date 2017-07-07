
BenchmarkDotNet=v0.10.6, OS=Windows 7 SP1 (6.1.7601)
Processor=Intel Core i7-6600U CPU 2.60GHz (Skylake), ProcessorCount=4
Frequency=2742343 Hz, Resolution=364.6517 ns, Timer=TSC
  [Host]     : Clr 4.0.30319.42000, 32bit LegacyJIT-v4.6.1098.0
  DefaultJob : Clr 4.0.30319.42000, 32bit LegacyJIT-v4.6.1098.0


          Method |  NbRows |         Mean |       Error |      StdDev |          Min |          Max |
---------------- |-------- |-------------:|------------:|------------:|-------------:|-------------:|
    **RowEnumerate** |      **10** |     **9.743 us** |   **0.1520 us** |   **0.1689 us** |     **9.522 us** |     **10.03 us** |
 ColumnEnumerate |      10 |    21.781 us |   0.4343 us |   0.7256 us |    20.456 us |     23.69 us |
    **RowEnumerate** |      **20** |    **38.645 us** |   **0.7421 us** |   **0.6942 us** |    **37.518 us** |     **39.89 us** |
 ColumnEnumerate |      20 |    99.932 us |   1.5015 us |   1.4045 us |    97.536 us |    102.26 us |
    **RowEnumerate** |     **200** | **4,138.125 us** |  **86.8165 us** | **124.5097 us** | **3,973.301 us** |  **4,509.77 us** |
 ColumnEnumerate |     200 | 9,916.997 us | 194.4462 us | 365.2171 us | 9,172.717 us | 10,727.35 us |
    **RowEnumerate** |    **2000** |           **NA** |          **NA** |          **NA** |           **NA** |           **NA** |
 ColumnEnumerate |    2000 |           NA |          NA |          NA |           NA |           NA |
    **RowEnumerate** |   **20000** |           **NA** |          **NA** |          **NA** |           **NA** |           **NA** |
 ColumnEnumerate |   20000 |           NA |          NA |          NA |           NA |           NA |
    **RowEnumerate** |  **200000** |           **NA** |          **NA** |          **NA** |           **NA** |           **NA** |
 ColumnEnumerate |  200000 |           NA |          NA |          NA |           NA |           NA |
    **RowEnumerate** | **2000000** |           **NA** |          **NA** |          **NA** |           **NA** |           **NA** |
 ColumnEnumerate | 2000000 |           NA |          NA |          NA |           NA |           NA |

Benchmarks with issues:
  Benchmark7.RowEnumerate: DefaultJob [NbRows=2000]
  Benchmark7.ColumnEnumerate: DefaultJob [NbRows=2000]
  Benchmark7.RowEnumerate: DefaultJob [NbRows=20000]
  Benchmark7.ColumnEnumerate: DefaultJob [NbRows=20000]
  Benchmark7.RowEnumerate: DefaultJob [NbRows=200000]
  Benchmark7.ColumnEnumerate: DefaultJob [NbRows=200000]
  Benchmark7.RowEnumerate: DefaultJob [NbRows=2000000]
  Benchmark7.ColumnEnumerate: DefaultJob [NbRows=2000000]
