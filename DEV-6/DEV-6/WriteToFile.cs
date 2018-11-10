using System.Collections.Generic;
using System.IO;


namespace DEV_6
{
    class WriteToFile
    {
        private string addressJSON = "D:\\MyPrograms\\Courses\\HomeTasks\\DEV-6\\JSON.json";

        public void WriteToJSON (List<string> dataFromXML)
        {
            using (StreamWriter sw = new StreamWriter(addressJSON, false, System.Text.Encoding.Default))
            {
                foreach ( string str in dataFromXML)
                {
                    sw.WriteLine(str);
                }
            }
        }
    }
}
