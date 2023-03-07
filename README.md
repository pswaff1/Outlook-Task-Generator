# Outlook-Task-Generator
A script to generate tasks in a csv file that can be imported to outlook. Specifically, the program takes from the user the title of a book (say a textbook), the number of chapters,
and the number of sections in the chapter. For each section, it will generate 14 copies of the task. The time between the due dates of these copies doubles. For example,
the first copy will be today, the second copy will be tomorrow, third will be 2 day gap, then 4 day gap, then 8 day gap, etc. 

I also made it so that the first copy of each section will be on a day that has no tasks scheduled.

This is my attempt to incorporate the "Spaced Repetition" study technique into my study habits. 


Instructions for installation: Windows
1. Figure out where you want this program. I recommend c:\Program Files. 

2. Pull up Powershell and enter the command "cd [path]" ("cd c:\program files" if you take took my recommendation)

3. Enter the command "git clone https://github.com/pswaff1/Outlook-Task-Generator.git"

3.5. If error, make sure you actually have git installed and in your PATH

4. Enter the command "cd Outlook-Task-Generator" to enter the directory

5. Enter the command "csc MakeTasks.cs" to compile the cs file into an exe file

5.5. If error, make sure "C:\windows\Microsoft.NET\Framework\v4.0.30319" is in your PATH environment variable

6. Add the full path into the PATH environment variable. Full path if you followed earlier recommendation should be "C:\Program Files\Outlook-Task-Generator"

7. You should now be able to run "MakeTasks" command anywhere on your PC.