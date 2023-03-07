// Patrick Swafford

using System;
using System.IO;
using System.Collections;

class MakeTasks {
    public static void Main(String [] args) {
        DateTime currentDate = DateTime.Now;
        var dateList = new ArrayList();
        string fileName = "out.csv";
        string filePath = Path.Combine(Directory.GetCurrentDirectory(), fileName);

        // Create a new file if it does not exist yet
        if (!File.Exists(filePath)) {
            using (StreamWriter writer = File.CreateText(filePath)) {
                // Write header row if desired
                writer.WriteLine("Subject,Due Date");
            }
        }      

        // Get book title
        Console.Write("Enter tile: ");
        String title = Console.ReadLine();

        // Get number of chapters
        Console.Write("Enter number of chapters: ");
        int numChapters = Int32.Parse(Console.ReadLine());

        // Iterate through each chapter
        for(int i = 0; i < numChapters; i++) {
            // Get number of Sections
            Console.Write("How many sections does chapter {0} have? Or enter -1 to skip this chapter. ", i+1);
            int numSections = Int32.Parse(Console.ReadLine());

            // Skip completed chapter
            if (numSections == -1) {
                continue;
            }

            // Iterate through sections
            for(int j = 0; j < numSections; j++) {
                // Write the tasks and dates to file out.csv
                currentDate = DateTime.Now;
                while (dateList.Contains(currentDate.ToString("MM/dd/yyyy"))) {
                    currentDate = currentDate.AddDays(1);
                }

                for(int k = 0; k < 15; k++) {

                    using (StreamWriter writer = File.AppendText(filePath)) {
                        writer.WriteLine("{0}-{1}-Chapter {2}-Section {3},{4}", k, title, i+1, j+1, currentDate.AddDays(Math.Pow(2,k)-1).ToString("MM/dd/yyyy"));
                    }

                    if(!dateList.Contains(currentDate.AddDays(Math.Pow(2,k)-1).ToString("MM/dd/yyyy"))) {
                        dateList.Add(currentDate.AddDays(Math.Pow(2,k)-1).ToString("MM/dd/yyyy"));
                    }
                }
            }

        }

        
    }
}