# Rename Files Script

import os, re

# explain the program
def welcome():
    print("Ariel's File Renaming Script")
    print('This script will rename all files in a folder '\
          'based on values provided by the user.')
    print('Values provided by the user include: folder path, '\
          'text to include in new file name, and whether '\
          'to add a dash/hyphen after the new text.')
    print()
    
def main():
    welcome()
    # declare variables
    validate = 'n'
    # get user input
    while validate == 'n':
        pathInput = input('What is the full path for the folder '\
                          'containing the files you want to rename? ')
        replaceTextInput = input('What is the text you want to replace '\
                                 'in the file names? ')
        includeDashInput = input('Does a dash/hyphen need to be added '
                                 'after the new text? y/n ')
        # repeat input to user to validate before continuing
        print('Folder Path: ', pathInput)
        print('New Filename Text: ', replaceTextInput)
        print('Include Dash/Hyphen: ', includeDashInput)
        validate = input('Does this look correct? y/n ').lower()
    files = os.listdir(pathInput)
    numFiles = renameFiles(files)
    print(numFiles, 'Files renamed successfully!')

# rename the files in the list and return a count of the renamed files
def renameFiles(fileList):
    count = 0
    for file in fileList:
        if file.endswith(".mp3"):
            count += 1
    return count

# run the script!
main()

# define variables
#path = "E:\\My Music\\Video Game Music\\Stardew Valley Soundtrack\\"
#files = os.listdir(path)
#pattern = re.compile(r'([0-9]+)-([A-Z]+)\.*$')
#pattern = re.compile(r'(\d{1-3})-(\d{})')
#replace = r"Stardew Valley - \1.mp3"
#folderName = ''

# create list of files in folder
#for oldFile in os.listdir(myFolder):
#    fileList.append(oldFile)

# print the old file name
#oldFile = files[0]
#print oldFile

# rename and print new file name
#newFile = oldFile.expand(replace)
#print newFile

# rename and close the file
#newFile = os.rename(myFolder+str(fileList[0]), myFolder+'')
#os.close(myFolder+newFile)
