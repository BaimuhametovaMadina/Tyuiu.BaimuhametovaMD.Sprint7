namespace Project.V4.Lib
{
    public class DataService
    {
        public string[,] LoadFromFileData(string filePath)
        {
            string[] fileData = File.ReadAllText(filePath).Replace('\n', '\r').Split('\r', StringSplitOptions.RemoveEmptyEntries);
            if (fileData.Length < 2)
            {
                return null;
            }

            int rows, cols;
            rows = fileData.Length - 1;
            cols = fileData[0].Split(';').Length;

            string[,] arrayValues = new string[rows, cols];

            for (int i = 1; i < fileData.Length; i++)
            {
                string[] line_r = fileData[i].Split(';');
                for (int j = 0; j < cols; j++)
                {
                    arrayValues[i - 1, j] = Convert.ToString(line_r[j]);
                }
            }

            return arrayValues;
        }

        public string CheckDataBase(string filePath)
        {
            string[] fileData = File.ReadAllText(filePath).Replace('\n', '\r').Split('\r', StringSplitOptions.RemoveEmptyEntries);
            string[] firstString = fileData[0].Split(";");
            if (firstString[0] == "ISDN") return "books";
            else if (firstString[0] == "Номер читательского билета") return "readers";
            else return null;
        }
    }
}
