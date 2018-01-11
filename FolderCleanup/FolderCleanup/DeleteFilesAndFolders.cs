using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FolderCleanup
{
    class DeleteFilesAndFolders
    {
        public string _Path{get;set;}

        public DeleteFilesAndFolders(string Path)
        {
            _Path = Path;
        }

        public void Delete()
        {
            DirectoryInfo di = new DirectoryInfo(_Path);
            DirectoryInfo[] Dinfo = di.GetDirectories("*.*", SearchOption.AllDirectories);

            foreach (var file in di.GetFiles("*.*", SearchOption.AllDirectories))
            {
                try
                {
                    file.Delete();
                }
                catch { }
            }

            foreach (DirectoryInfo dir in di.GetDirectories())
            {
                FileInfo[] fi = dir.GetFiles("*.*", SearchOption.AllDirectories);
                if (fi.Length == 0)
                {
                    try
                    {
                        dir.Delete(true);
                    }
                    catch { }
                }
            }
        }
    }
}
