using System;
using System.IO;

namespace OBO_Tools.Scripts
{
    class Methods
    {

        public static Boolean checkFile(String path)
        {
            return File.Exists(path);
        }
        //**//

    }
}
