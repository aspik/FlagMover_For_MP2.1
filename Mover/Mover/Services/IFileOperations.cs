﻿using System.Collections.Generic;
using System.IO;
using System.Text;

namespace FlagMover.Services
{
  public interface IFileOperations
  {
    void FileWriteAllText(string path, string contents, Encoding encoding);
    bool FileExists(string path);
    string FileReadAllText(string file);
    IDictionary<string, string> GetLogicalDrivers();
    IDictionary<string, string> GetDirectories(string path);
  }
}