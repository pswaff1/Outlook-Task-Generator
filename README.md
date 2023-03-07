# Outlook-Task-Generator
A script to create tasks in outlook

1. Figure out where you want this program. I recommend c:\Program Files. 

2. Pull up Powershell and enter the command "cd [path]" ("cd c:\program files" if you take took my recommendation)

3. Enter the command "git clone https://github.com/pswaff1/Outlook-Task-Generator.git"

3.5. If error, make sure you actually have git installed and in your PATH

4. Enter the command "cd Outlook-Task-Generator" to enter the directory

5. Enter the command "csc MakeTasks.cs" to compile the cs file into an exe file

5.5. If error, make sure "C:\windows\Microsoft.NET\Framework\v4.0.30319" is in your PATH environment variable

6. Add the full path into the PATH environment variable. Full path if you followed earlier recommendation should be "C:\Program Files\Outlook-Task-Generator"

7. You should now be able to run "MakeTasks" command anywhere on your PC.