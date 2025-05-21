# Rename Files Script

import os

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
        path = input('What is the full path for the folder '\
                     'containing the files you want to rename? ')
        replaceText = input('What is the text you want to replace '\
                            'in the file names? ')
        includeHyphen = input('Does a hyphen need to be added '\
                              'after the new text? y/n ')
        print()
        # repeat input to user to validate before continuing
        print('Folder Path: ', path)
        print('New Filename Text: ', replaceText)
        print('Include Hyphen: ', includeHyphen)
        validate = input('Does this look correct? y/n ').lower()
    files = os.listdir(path)
    numFiles = renameFiles(files, path, replaceText, includeHyphen)
    print(numFiles, 'Files renamed successfully!')

# rename the files in the list and return a count of the renamed files
def renameFiles(fileList):
    count = 0
    tempFile = ''
    newFile = ''
    for file in fileList:
        if file.endswith(".mp3"):
            #print('oldfile:', file)
            index = 0
            for char in file:
                index += 1
                # looks for the first space in the file name
                if char == " ":
                    tempFile = file[index-1:]
                    #print('tempfile:', tempFile)
                    if addHyphen == 'y':
                        newFile = newText + '- ' + tempFile
                    else:
                        newFile = newText + tempFile
                    #print('newfile:', newFile)
                    break
            os.rename(folder+"\\"+file, folder+"\\"+newFile)
            count += 1
    return count

# run the script!
main()
