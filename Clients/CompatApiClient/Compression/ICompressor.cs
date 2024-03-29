﻿using System.IO;
using System.Threading.Tasks;

namespace CompatApiClient.Compression;

public interface ICompressor
{
    string EncodingType { get; }
    Task<long> CompressAsync(Stream source, Stream destination);
    Task<long> DecompressAsync(Stream source, Stream destination);
}