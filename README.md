# SimVault

SimVault is a lightweight utility that automatically compresses, extracts, and eventually uploads backups of The Sims save files to the cloud.  
It is still in an early prototype stage but continues to evolve.

## Current Features
- Compresses or extracts a selected folder or file using LZMA2 (Normal compression level)
- Displays a file list from the selected directory

## Roadmap / Todo
- Improve the file and folder TreeView (currently very barebones and mainly a proof of concept)
- Allow selecting specific files and folders to compress
- Add a configurable settings dialog with persistent defaults  
  (such as the default Sims/Documents folder path)
- Enable cloud backup uploads  
  - Starting with Google Drive  
  - Possibly adding OneDrive, Dropbox, and others
- Allow choosing compression method and level to reduce CPU usage
- Add tools to manage backups directly inside the app  
  (hide, delete, rename, sort, etc.)
- Optimize processes, refactor, and clean up code for easier contributions
- Additional ideas to be added over time

## Contributing
Suggestions and improvements are welcome.  
Please feel free to open issues or submit pull requests.