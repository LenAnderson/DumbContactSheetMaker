# DumbContactSheetMaker
makes contact sheets from the images inside a folder

## Download And Installation
Get the [latest release](https://github.com/LenAnderson/DumbContactSheetMaker/releases/latest). No installation required.

## Features
- single .exe, no installation
- contact sheet for one folder or recursive
- show all images on the contact sheet or only a limited number
- add a custom cover image
- use the folder name as the title, use a custom title, or no title at all
- custom background colors and fonts
- headless mode (create contact sheets from the command line)

### Application Window
![screenshot](https://i.imgur.com/gki22j0.png)

### Command Line Options
```
usage: DumbContactSheetMaker --help       to show this help
       DumbContactSheetMaker --fonts      to list available fonts

       DumbContactSheetMaker [<options>] <path> [<options>]

options:
    --output [i|r|<path>]               where to save the cover sheet
    -o [i|r|<path>]                     defaults to root folder
                                         i: with the images
                                         r: in the root folder 
                                            (if recursive)
                                         <path>: specify your own dir
                                        
    --recursive                         recursively search through
    -r                                  sub directories and create
                                        contact sheet for all leaves
                                        of the directory tree
                                        
    --width ###                         width of the contact sheet in
    -w ###                              px
                                        
    --height ###                        maximum thumbnail height in px
    -h ###                              
                                        
    --max-num ###                       maximum number of images to use
    -mn ###                             in the contact sheet
                                        
    --large-first                       make the first image fill the 
    -lf                                 whole width of the contact 
                                        sheet
                                        
    --cover <path>                      use a custom cover image that
    -c <path>                           will fill the whole width of 
                                        the contact sheet
                                        
    --cover-first                       use the cover image as the 
    -cf                                 first image of the contact
                                        sheet (by default the cover
                                        will be put last)
                                        
    --title                             show a title above the contact
    -t                                  sheet
                                        
    --title-text <custom title text>    provide a custom text to be used
    -tt <custom title text>             as the title (by default the 
                                        directory name will be used)
                                        
    --background <rgba hex>             background color for the title
    -bg <rgba hex>                      default is black: 000000FF
                                        
    --font <font name>                  font for the title, use --fonts
    -f <font name>                      to list available fonts
                                        
    --font-color <rgba hex>             text color for the title
    -fc <rgba hex>                      default is white: FFFFFFFF
                                        
    --font-size ###                     title's font size in pt
    -fs ###                             
                                        
    --font-style [b|i|bi]               title's font style, combination
    -fst [b|i|bi]                        of (b)old and (i)talic
```

### Example with cover image (as first) and large first image
![example](http://i.imgur.com/IAGB016.jpg)
