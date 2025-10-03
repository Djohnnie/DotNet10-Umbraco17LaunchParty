using BenchmarkDotNet.Running;
using DotNet10.ImprovedZipArchive;


var summary = BenchmarkRunner.Run<ZipArchiveBenchmarks>();