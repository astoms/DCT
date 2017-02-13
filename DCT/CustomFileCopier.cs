using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace DCT
{
    public delegate void AsyncMethodCaller();
    public delegate void ProgressChangeDelegate(double Persentage, ref bool Cancel);
    public delegate void Completedelegate(bool canceled);

    public class CustomFileCopier
    {
        public CustomFileCopier(string Source, string Dest)
        {
            this.SourceFilePath = Source;
            this.DestFilePath = Dest;

            OnProgressChanged += delegate { };
            OnComplete += delegate { };
        }

        public void Copy()
        {
            bool cancelFlag = false;

            try
            {
                byte[] buffer = new byte[0x1000];

                using (FileStream source = new FileStream(SourceFilePath, FileMode.Open, FileAccess.Read, FileShare.Read, 4096, true))
                {
                    long fileLength = source.Length;
                    using (FileStream dest = new FileStream(DestFilePath, FileMode.CreateNew, FileAccess.Write))
                    {
                        long totalBytes = 0;
                        int currentBlockSize = 0;

                        while ((currentBlockSize = source.Read(buffer, 0, buffer.Length)) > 0)
                        {
                            totalBytes += currentBlockSize;
                            double persentage = (double)totalBytes * 100.0 / fileLength;

                            dest.Write(buffer, 0, currentBlockSize);

                            cancelFlag = false;
                            OnProgressChanged(persentage, ref cancelFlag);

                            if (cancelFlag == true)
                            {
                                // Delete dest file here
                                break;
                            }
                        }
                    }
                }

            }
            catch (IOException e)
            {
                cancelFlag = true;
                MessageBox.Show("Неудалось получить обновление! \n" + SourceFilePath + "\n" + DestFilePath);
                MessageBox.Show(e.Message);
            }
            catch (Exception e)
            {
                cancelFlag = true;
                MessageBox.Show("Неудалось получить обновление! \n" + SourceFilePath + "\n" + DestFilePath);
                MessageBox.Show(e.Message);
            }

            OnComplete(cancelFlag);
        }

        public string SourceFilePath { get; set; }
        public string DestFilePath { get; set; }

        public event ProgressChangeDelegate OnProgressChanged;
        public event Completedelegate OnComplete;
    }
}