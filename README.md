# exerciseFiles

# Readme

## Introduction
This C# console application demonstrates the creation of a text file (`mytekst.txt`) with some initial content 
and then reads and displays the content of the file using a `StreamReader`. The program uses exception handling 
to catch and display any errors that may occur during file creation or reading.

## Usage
1. Run the application in Visual Studio Code or your preferred C# development environment.
2. The program will attempt to create a text file named `mytekst.txt` and write some initial content to it.
3. After creating the file, the program will read its content using a `StreamReader` and display it on the console.
4. Check the console for the content of the file and any error messages that may occur.

## Code Explanation
### Main Method
- Initializes the file name as `mytekst.txt`.
- Attempts to delete the file if it already exists to ensure a fresh start.
- Uses a `StreamWriter` to create the file and write three lines of text to it.
- Uses a `StreamReader` to read the content of the file and display it on the console.
- Catches and handles any exceptions that may occur during file creation or reading.

### Note
- The file name is set to `mytekst.txt` within the program (`string fileName = @"mytekst.txt";`). You can
- modify this filename based on your preferences.
- If the file already exists, it will be deleted before creating a new one. Make sure the file does
- not contain important information before running the program.
- Check the console for both the content of the file and any error messages that may occur during execution.
