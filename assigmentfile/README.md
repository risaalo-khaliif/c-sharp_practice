C# File Management Assignment 

This application demonstrates fundamental file handling operations using Visual C# and Windows Forms.

Implementation Details

A. Creating Student Records (buttonCreate_Click)

File.CreateText("Students.txt"): Initializes a stream to write student records to Students.txt.

fileWriter.WriteLine(...): Appends individual record lines.

fileWriter.Close(): Flushes and closes the stream.

B. Displaying Records (buttonRead_Click)

File.Exists(...): Ensures the input file is available before reading.

File.ReadAllLines(...): Retrieves all records into a local array.

foreach loop: Populates listBox1 sequentially.

C. Removing Specific Record (buttonDeleteSelected_Click)

listBox1.SelectedItem: Evaluates selected object reference (!= null).

listBox1.Items.Remove(...): Deletes the selected item directly from the list.

for loop re-write: Writes surviving items back into Students.txt using index-based loop (listBox1.Items[idx]).

D. Deleting Entire File (buttonDeleteAll_Click)

File.Delete(...): Erases Students.txt from the system storage and clears the user interface.