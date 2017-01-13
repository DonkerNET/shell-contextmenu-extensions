*** ABOUT ***

Adds a Windows context menu entry that allows you to generate a generic file of a specified size.


*** INSTALLATION ***

Add the following keys to the registry:

HKEY_CLASSES_ROOT\.
Add > Type = String | Name = (Default) | Value = genericfile
    
HKEY_CLASSES_ROOT\.\ShellNew
Add > Type = String | Name = Command | Value = "path_to_this.exe" "%1"
Add > Type = String | Name = NullFile | Value = 

HKEY_CLASSES_ROOT\genericfile
Add > Type = String | Name = (Default) | Value = Generic file...