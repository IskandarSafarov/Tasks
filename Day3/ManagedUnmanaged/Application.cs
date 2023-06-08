using System;
using System.Text;

namespace UnmanagedCode;

public class Application : IDisposable
{
    private string filePath;
    FileStream fs;
    public Application(string filePath)
    {
        this.filePath = filePath;
        fs = new FileStream(this.filePath, FileMode.OpenOrCreate);
    }

    public void Dispose()
    {
        fs.Close();
    }

    public void WriteToFile(string data)
    {
        byte[] strToByte = Encoding.UTF8.GetBytes(data + "\n");
        fs.Write(strToByte, 0, strToByte.Length);

    }

    public string ReadFromFile()
    {
        byte[] b = new byte[1024];
        StringBuilder res = new StringBuilder();
        UTF8Encoding temp = new UTF8Encoding(true);
        int readLen;
        while ((readLen = fs.Read(b, 0, b.Length)) > 0)
        {
            res.Append(temp.GetString(b, 0, readLen));
        }
        return res.ToString();
    }
}
/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagedUnmanaged
{
    public class Application : IDisposable
    {
        StreamWriter StreamWriter;
        public Application()
        {
            StreamWriter = new StreamWriter("store.txt", true);
        }

        public void Dispose()
        {
            Dispose(true);
        }

        bool disposed;
        protected void Dispose(bool disposing)
        {
            if (disposed)
                return;

            if (disposing)
            {
                //Clean up managed code
                StreamWriter.Dispose();
            }
            //clean up unmanaged code
            disposed = true;
        }

        ~Application()
        {
            Dispose(false);
        }

        public void WriteProduct(string name, int count)
        {
            StreamWriter.WriteLine($"{name} {count}");
            StreamWriter.Flush();
        }
    }
}
*/
