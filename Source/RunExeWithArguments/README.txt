*** ABOUT ***

Adds a Windows context menu entry for executables that allows you to run an applications with the arguments that are input.


*** INSTALLATION ***

Add the following keys to the registry:

HKEY_CLASSES_ROOT\exefile\shell\Run with arguments...\Command\
Add > Type = String | Name = (Default) | Value = "path_to_this.exe" "%1"